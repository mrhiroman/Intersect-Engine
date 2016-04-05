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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Intersect_Editor.Classes;
using Intersect_Editor.Classes.Core;

namespace Intersect_Editor.Forms.Editors.Event_Commands
{
    public partial class EventCommand_Options : UserControl
    {
        private EventCommand _myCommand;
        private EventPage _currentPage;
        private readonly FrmEvent _eventEditor;
        public EventCommand_Options(EventCommand refCommand, EventPage refPage, FrmEvent editor)
        {
            InitializeComponent();
            _myCommand = refCommand;
            _eventEditor = editor;
            _currentPage = refPage;
            txtShowOptions.Text = _myCommand.Strs[0];
            txtShowOptionsOpt1.Text = _myCommand.Strs[1];
            txtShowOptionsOpt2.Text = _myCommand.Strs[2];
            txtShowOptionsOpt3.Text = _myCommand.Strs[3];
            txtShowOptionsOpt4.Text = _myCommand.Strs[4];
            cmbFace.Items.Clear();
            cmbFace.Items.Add("None");
            cmbFace.Items.AddRange(GameContentManager.GetTextureNames(GameContentManager.TextureType.Face));
            if (cmbFace.Items.IndexOf(_myCommand.Strs[5]) > -1)
            {
                cmbFace.SelectedIndex = cmbFace.Items.IndexOf(_myCommand.Strs[5]);
            }
            else
            {
                cmbFace.SelectedIndex = 0;
            }
            UpdateFacePreview();
        }

        private void UpdateFacePreview()
        {
            if (File.Exists("resources/faces/" + cmbFace.Text))
            {
                pnlFace.BackgroundImage = new Bitmap("resources/faces/" + cmbFace.Text);
            }
            else
            {
                pnlFace.BackgroundImage = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _myCommand.Strs[0] = txtShowOptions.Text;
            _myCommand.Strs[1] = txtShowOptionsOpt1.Text;
            _myCommand.Strs[2] = txtShowOptionsOpt2.Text;
            _myCommand.Strs[3] = txtShowOptionsOpt3.Text;
            _myCommand.Strs[4] = txtShowOptionsOpt4.Text;
            _myCommand.Strs[5] = cmbFace.Text;
            if (_myCommand.Ints[0] == 0)
            {
                for (var i = 0; i < 4; i++)
                {
                    _currentPage.CommandLists.Add(new CommandList());
                    _myCommand.Ints[i] = _currentPage.CommandLists.Count - 1;
                }
            }
            _eventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _eventEditor.CancelCommandEdit();
        }

        private void cmbFace_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFacePreview();
        }
    }
}
