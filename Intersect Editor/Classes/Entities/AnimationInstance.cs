﻿using System;
using System.Drawing;
using Intersect_Editor.Classes.Core;
using Intersect_Library.GameObjects;
using Microsoft.Xna.Framework.Graphics;

namespace Intersect_Editor.Classes.Entities
{
    public class AnimationInstance
    {
        public AnimationBase myBase;
        private float _renderX = 0;
        private float _renderY = 0;
        private int _renderDir = 0;
        private int lowerFrame;
        private int upperFrame;
        private int lowerLoop;
        private int upperLoop;
        private long lowerTimer;
        private long upperTimer;
        private bool infiniteLoop = false;
        private bool showLower = true;
        private bool showUpper = true;
        public AnimationInstance(AnimationBase animBase, bool loopForever)
        {
            myBase = animBase;
            lowerLoop = animBase.LowerAnimLoopCount;
            upperLoop = animBase.UpperAnimLoopCount;
            lowerTimer = Globals.System.GetTimeMs() + animBase.LowerAnimFrameSpeed;
            upperTimer = Globals.System.GetTimeMs() + animBase.UpperAnimFrameSpeed;
            infiniteLoop = loopForever;
        }

        public void Draw(RenderTarget2D target, bool upper = false)
        {
            if (!upper)
            {
                //Draw Lower
                Texture2D tex = GameContentManager.GetTexture(GameContentManager.TextureType.Animation,
                    myBase.LowerAnimSprite);
                if (showLower && tex != null)
                {
                    if (myBase.LowerAnimXFrames > 0 && myBase.LowerAnimYFrames > 0)
                    {
                        int frameWidth = (int)tex.Width / myBase.LowerAnimXFrames;
                        int frameHeight = (int)tex.Height / myBase.LowerAnimYFrames;
                        EditorGraphics.DrawTexture(tex,
                            new RectangleF((lowerFrame % myBase.LowerAnimXFrames) * frameWidth,
                                (float)Math.Floor((double)lowerFrame / myBase.LowerAnimXFrames) * frameHeight, frameWidth,
                                frameHeight),
                            new RectangleF(_renderX - frameWidth / 2, _renderY - frameHeight / 2, frameWidth, frameHeight),
                             Color.White, target, BlendState.AlphaBlend);
                        EditorGraphics.AddLight((int)_renderX + myBase.LowerLights[lowerFrame].OffsetX,
                            (int)_renderY + myBase.LowerLights[lowerFrame].OffsetY, myBase.LowerLights[lowerFrame]);

                    }
                }
            }
            else
            {
                //Draw Upper
                Texture2D tex = GameContentManager.GetTexture(GameContentManager.TextureType.Animation,
                    myBase.UpperAnimSprite);
                if (showUpper && tex != null)
                {
                    if (myBase.UpperAnimXFrames > 0 && myBase.UpperAnimYFrames > 0)
                    {
                        int frameWidth = (int)tex.Width / myBase.UpperAnimXFrames;
                        int frameHeight = (int)tex.Height / myBase.UpperAnimYFrames;
                        EditorGraphics.DrawTexture(tex,
                            new RectangleF((upperFrame % myBase.UpperAnimXFrames) * frameWidth,
                                (float)Math.Floor((double)upperFrame / myBase.UpperAnimXFrames) * frameHeight, frameWidth,
                                frameHeight),
                            new RectangleF(_renderX - frameWidth / 2, _renderY - frameHeight / 2, frameWidth, frameHeight),
                            Color.White, target, BlendState.AlphaBlend);
                    }
                }
            }
        }

        public void SetPosition(float x, float y, int dir)
        {
            _renderX = x;
            _renderY = y;
            _renderDir = dir;
        }

        public void Update()
        {
            if (lowerTimer < Globals.System.GetTimeMs() && showLower)
            {
                lowerFrame++;
                if (lowerFrame >= myBase.LowerAnimFrameCount)
                {
                    lowerLoop--;
                    lowerFrame = 0;
                    if (lowerLoop < 0)
                    {
                        if (infiniteLoop)
                        {
                            lowerLoop = myBase.LowerAnimLoopCount;
                        }
                        else
                        {
                            showLower = false;
                        }
                    }
                }
                lowerTimer = Globals.System.GetTimeMs() + myBase.LowerAnimFrameSpeed;
            }
            if (upperTimer < Globals.System.GetTimeMs() && showUpper)
            {
                upperFrame++;
                if (upperFrame >= myBase.UpperAnimFrameCount)
                {
                    upperLoop--;
                    upperFrame = 0;
                    if (upperLoop < 0)
                    {
                        if (infiniteLoop)
                        {
                            upperLoop = myBase.UpperAnimLoopCount;

                        }
                        else
                        {
                            showUpper = false;
                        }
                    }
                }
                upperTimer = Globals.System.GetTimeMs() + myBase.UpperAnimFrameSpeed;
            }
        }
    }
}