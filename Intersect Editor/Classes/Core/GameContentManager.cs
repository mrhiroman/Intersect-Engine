﻿/*
    Intersect Game Engine (Editor)
    Copyright (C) 2015  JC Snider, Joe Bridges
    
    Website: http://ascensiongamedev.com
    Contact Email: admin@ascensiongamedev.com 

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Intersect_Editor.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace Intersect_Editor.Classes.Core
{
    public static class GameContentManager
    {
        //MonoGame Content Manager
        private static ContentManager contentManger;

        //Initial Resource Downloading
        private static string resourceRelayer = "http://ascensiongamedev.com/resources/Intersect/findResources.php";
        private static frmLoadingContent loadingForm;
        private static bool downloadCompleted = false;
        private static string errorString = "";

        //Game Content
        static Dictionary<string, Texture2D> tilesetDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> itemDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> entityDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> spellDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> animationDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> faceDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> imageDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> fogDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> resourceDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> paperdollDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> guiDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Texture2D> miscDict = new Dictionary<string, Texture2D>();
        static Dictionary<string, Effect> shaderDict = new Dictionary<string, Effect>();
        static Dictionary<string, Song> musicDict = new Dictionary<string, Song>();
        static Dictionary<string, SoundEffect> soundDict = new Dictionary<string, SoundEffect>();

        //Basic Editor Textures
        private static Texture2D transparentTileTex;
        //Texture for attributes
        private static Texture2D attributesTex;
        //Texture for events
        private static Texture2D eventIconTex;
        //Single tile texture for light placement
        private static Texture2D lightIconTex;
        //Texture for NPC Spawns
        private static Texture2D spawnIconTex;

        public enum TextureType
        {
            Tileset = 0,
            Item,
            Entity,
            Spell,
            Animation,
            Face,
            Image,
            Fog,
            Resource,
            Paperdoll,
            Gui,
            Misc,
        }

        //Resource Downloader
        public static void CheckForResources()
        {
            if (!Directory.Exists("resources"))
            {
                loadingForm = new frmLoadingContent();
                loadingForm.Show();
                loadingForm.BringToFront();
                using (WebClient client = new WebClient())
                {
                    byte[] response =
                    client.UploadValues(resourceRelayer, new NameValueCollection()
                    {
                       { "version", Assembly.GetExecutingAssembly().GetName().Version.ToString() },
                    });
                    string result = Encoding.UTF8.GetString(response);
                    Uri urlResult;
                    if (Uri.TryCreate(result, UriKind.Absolute, out urlResult))
                    {
                        client.DownloadProgressChanged += Client_DownloadProgressChanged;
                        client.DownloadFileCompleted += Client_DownloadFileCompleted;
                        bool retry = true;
                        while (retry == true)
                        {
                            try
                            {
                                downloadCompleted = false;
                                errorString = "";
                                client.DownloadFileAsync(urlResult, "resources.zip");
                                while (!downloadCompleted)
                                {
                                    Application.DoEvents();
                                }
                            }
                            catch (Exception ex)
                            {
                                errorString = ex.Message;
                            }
                            if (errorString != "")
                            {
                                if (
                                    MessageBox.Show(
                                        "Failed to download client resources.\n\nException Info: " + errorString +
                                        "\n\n" +
                                        "Would you like to try again?", "Failed to load Resources!",
                                        MessageBoxButtons.YesNo) != DialogResult.Yes)
                                {
                                    retry = false;
                                }
                            }
                            else
                            {
                                retry = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Failed to load resources from client directory and Ascension Game Dev server. Cannot launch game!",
                            "Failed to load Resources!");
                    }
                }
                loadingForm.Close();
            }
            if (!Directory.Exists("resources"))
            {
                Environment.Exit(1);
            }
        }
        private static void Client_DownloadFileCompleted(global::System.Object sender, global::System.ComponentModel.AsyncCompletedEventArgs e)
        {
            downloadCompleted = true;
            if (!e.Cancelled && e.Error == null)
            {
                try
                {
                    global::System.IO.Compression.ZipFile.ExtractToDirectory("resources.zip",
                        global::System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    File.Delete("resources.zip");
                }
                catch (Exception ex)
                {
                    errorString = ex.Message;
                }
            }
            else
            {
                if (e.Cancelled)
                {
                    errorString = "Download was cancelled!";
                }
                else
                {
                    errorString = e.Error.Message;
                }
            }
        }
        private static void Client_DownloadProgressChanged(global::System.Object sender, DownloadProgressChangedEventArgs e)
        {
            loadingForm.SetProgress(e.ProgressPercentage);
        }

        public static void LoadEditorContent()
        {
            //Start by creating a MonoGame Content Manager
            //We create a dummy game service so we can load up a content manager.
            var container = new GameServiceContainer();
            container.AddService(typeof(IGraphicsDeviceService), new DummyGraphicsDeviceManager(EditorGraphics.GetGraphicsDevice()));
            contentManger = new ContentManager(container, "");
            
            LoadTilesets();
            LoadItems();
            LoadEntities();
            LoadSpells();
            LoadAnimations();
            LoadFaces();
            LoadImages();
            LoadFogs();
            LoadResources();
            LoadPaperdolls();
            //NO GUI
            LoadMisc();
            LoadShaders();
            LoadSounds();
            LoadMusic();
        }

        private static Texture2D LoadTexture(string filename)
        {
            using (var fileStream = new FileStream(filename, FileMode.Open))
            {
                return Texture2D.FromStream(EditorGraphics.GetGraphicsDevice(), fileStream);
            }
        }

        //Loading Game Resources
        public static void LoadTextureGroup(string directory, Dictionary<string, Texture2D> dict)
        {
            dict.Clear();
            if (!Directory.Exists("resources/" + directory)) { Directory.CreateDirectory("resources/" + directory); }
            var items = Directory.GetFiles("resources/" + directory, "*.png");
            for (int i = 0; i < items.Length; i++)
            {
                string filename = items[i].Replace("resources/" + directory + "\\", "").ToLower();
                dict.Add(filename, LoadTexture("resources/" + directory + "/" + filename));
            }
        }
        private static void LoadTilesets()
        {
            if (!Directory.Exists("resources/tilesets")) { Directory.CreateDirectory("resources/tilesets"); }
            var tilesets = Directory.GetFiles("resources/tilesets", "*.png");
            Array.Sort(tilesets, new AlphanumComparatorFast());
            var tilesetsUpdated = false;
            if (tilesets.Length > 0)
            {
                for (var i = 0; i < tilesets.Length; i++)
                {
                    tilesets[i] = tilesets[i].Replace("resources/tilesets\\", "");
                    if (Globals.Tilesets != null)
                    {
                        if (Globals.Tilesets.Length > 0)
                        {
                            for (var x = 0; x < Globals.Tilesets.Length; x++)
                            {
                                if (Globals.Tilesets[x] == tilesets[i])
                                {
                                    break;
                                }
                                if (x != Globals.Tilesets.Length - 1) continue;
                                var newTilesets = new string[Globals.Tilesets.Length + 1];
                                Globals.Tilesets.CopyTo(newTilesets, 0);
                                newTilesets[Globals.Tilesets.Length] = tilesets[i];
                                Globals.Tilesets = newTilesets;
                                tilesetsUpdated = true;
                            }
                        }
                        else
                        {
                            var newTilesets = new string[1];
                            newTilesets[0] = tilesets[i];
                            Globals.Tilesets = newTilesets;
                            tilesetsUpdated = true;
                        }
                    }
                    else
                    {
                        var newTilesets = new string[1];
                        newTilesets[0] = tilesets[i];
                        Globals.Tilesets = newTilesets;
                        tilesetsUpdated = true;
                    }
                }

                if (tilesetsUpdated)
                {
                    PacketSender.SendTilesets();
                }
                for (var i = 0; i < Globals.Tilesets.Length; i++)
                {
                    if (File.Exists("resources/tilesets/" + Globals.Tilesets[i]))
                    {
                        tilesetDict.Add(Globals.Tilesets[i].ToLower(), LoadTexture("resources/tilesets/" + Globals.Tilesets[i]));
                    }
                }
            }
        }
        private static void LoadItems()
        {
            LoadTextureGroup("items", itemDict);
        }
        private static void LoadEntities()
        {
            LoadTextureGroup("entities", entityDict);
        }
        private static void LoadSpells()
        {
            LoadTextureGroup("spells", spellDict);
        }
        private static void LoadAnimations()
        {
            LoadTextureGroup("animations", animationDict);
        }
        private static void LoadFaces()
        {
            LoadTextureGroup("faces", faceDict);
        }
        private static void LoadImages()
        {
            LoadTextureGroup("images", imageDict);
        }
        private static void LoadFogs()
        {
            LoadTextureGroup("fogs", fogDict);
        }
        private static void LoadResources()
        {
            LoadTextureGroup("resources", resourceDict);
        }
        private static void LoadPaperdolls()
        {
            LoadTextureGroup("paperdolls", paperdollDict);
        }
        private static void LoadMisc()
        {
            LoadTextureGroup("misc", miscDict);
        }
        public static void LoadShaders()
        {
            shaderDict.Clear();
            if (!Directory.Exists("resources/" + "shaders")) { Directory.CreateDirectory("resources/" + "shaders"); }
            var items = Directory.GetFiles("resources/" + "shaders", "*.xnb");
            for (int i = 0; i < items.Length; i++)
            {
                string filename = items[i].Replace("resources/" + "shaders" + "\\", "").ToLower();
                shaderDict.Add(filename, contentManger.Load<Effect>(RemoveExtension("resources/" + "shaders" + "/" + filename)));
            }
        }
        public static void LoadSounds()
        {
            soundDict.Clear();
            if (!Directory.Exists("resources/" + "sounds")) { Directory.CreateDirectory("resources/" + "sounds"); }
            var items = Directory.GetFiles("resources/" + "sounds", "*.wav");
            for (int i = 0; i < items.Length; i++)
            {
                string filename = items[i].Replace("resources/" + "sounds" + "\\", "").ToLower();
                SoundEffect effect;
                using (var fileStream = new FileStream("resources/" + "sounds" + "/" + filename, FileMode.Open))
                {
                    effect = SoundEffect.FromStream(fileStream);
                }
                soundDict.Add(filename, effect);
            }
        }
        public static void LoadMusic()
        {
            musicDict.Clear();
            if (!Directory.Exists("resources/" + "music")) { Directory.CreateDirectory("resources/" + "music"); }
            var items = Directory.GetFiles("resources/" + "music", "*.mp3");
            for (int i = 0; i < items.Length; i++)
            {
                string filename = items[i].Replace("resources/" + "music" + "\\", "").ToLower();
                musicDict.Add(filename, Song.FromUri("Unnamed", new Uri("resources/" + "music" + "/" + filename, UriKind.Relative)));
            }
        }
        public static string RemoveExtension(string fileName)
        {
            int fileExtPos = fileName.LastIndexOf(".");
            if (fileExtPos >= 0)
                fileName = fileName.Substring(0, fileExtPos);
            return fileName;
        }

        //Retreiving Game Resources
        //Content Getters
        public static Texture2D GetTexture(TextureType type, string name)
        {
            switch (type)
            {
                case TextureType.Tileset:
                    if (tilesetDict.ContainsKey(name.ToLower())) return tilesetDict[name.ToLower()];
                    break;
                case TextureType.Item:
                    if (itemDict.ContainsKey(name.ToLower())) return itemDict[name.ToLower()];
                    break;
                case TextureType.Entity:
                    if (entityDict.ContainsKey(name.ToLower())) return entityDict[name.ToLower()];
                    break;
                case TextureType.Spell:
                    if (spellDict.ContainsKey(name.ToLower())) return spellDict[name.ToLower()];
                    break;
                case TextureType.Animation:
                    if (animationDict.ContainsKey(name.ToLower())) return animationDict[name.ToLower()];
                    break;
                case TextureType.Face:
                    if (faceDict.ContainsKey(name.ToLower())) return faceDict[name.ToLower()];
                    break;
                case TextureType.Image:
                    if (imageDict.ContainsKey(name.ToLower())) return imageDict[name.ToLower()];
                    break;
                case TextureType.Fog:
                    if (fogDict.ContainsKey(name.ToLower())) return fogDict[name.ToLower()];
                    break;
                case TextureType.Resource:
                    if (resourceDict.ContainsKey(name.ToLower())) return resourceDict[name.ToLower()];
                    break;
                case TextureType.Paperdoll:
                    if (paperdollDict.ContainsKey(name.ToLower())) return paperdollDict[name.ToLower()];
                    break;
                case TextureType.Gui:
                    if (guiDict.ContainsKey(name.ToLower())) return guiDict[name.ToLower()];
                    break;
                case TextureType.Misc:
                    if (miscDict.ContainsKey(name.ToLower())) return miscDict[name.ToLower()];
                    break;
            }
            return null;
        }
        public static Effect GetShader(string name)
        {
            if (shaderDict.ContainsKey(name.ToLower())) return shaderDict[name.ToLower()];
            return null;
        }
        public static Song GetMusic(string name)
        {
            if (musicDict.ContainsKey(name.ToLower())) return musicDict[name.ToLower()];
            return null;
        }
        public static SoundEffect GetSound(string name)
        {
            if (soundDict.ContainsKey(name.ToLower())) return soundDict[name.ToLower()];
            return null;
        }
        //Getting Filenames
        public static string[] GetTextureNames(TextureType type)
        {
            switch (type)
            {
                case TextureType.Tileset:
                    return tilesetDict.Keys.ToArray();
                case TextureType.Item:
                    return itemDict.Keys.ToArray();
                case TextureType.Entity:
                    return entityDict.Keys.ToArray();
                case TextureType.Spell:
                    return spellDict.Keys.ToArray();
                case TextureType.Animation:
                    return animationDict.Keys.ToArray();
                case TextureType.Face:
                    return faceDict.Keys.ToArray();
                case TextureType.Image:
                    return imageDict.Keys.ToArray();
                case TextureType.Fog:
                    return fogDict.Keys.ToArray();
                case TextureType.Resource:
                    return resourceDict.Keys.ToArray();
                case TextureType.Paperdoll:
                    return paperdollDict.Keys.ToArray();
                case TextureType.Gui:
                    return guiDict.Keys.ToArray();
                case TextureType.Misc:
                    return miscDict.Keys.ToArray();
            }
            return null;
        }
        public static string[] GetMusicNames()
        {
            return musicDict.Keys.ToArray();
        }
        public static string[] GetSoundNames()
        {
            return soundDict.Keys.ToArray();
        }
    }

    internal class DummyGraphicsDeviceManager : IGraphicsDeviceService
    {
        public GraphicsDevice GraphicsDevice { get; private set; }

        // Not used:
        public event EventHandler<EventArgs> DeviceCreated;
        public event EventHandler<EventArgs> DeviceDisposing;
        public event EventHandler<EventArgs> DeviceReset;
        public event EventHandler<EventArgs> DeviceResetting;

        public DummyGraphicsDeviceManager(GraphicsDevice graphicsDevice)
        {
            GraphicsDevice = graphicsDevice;
        }
    }
}
