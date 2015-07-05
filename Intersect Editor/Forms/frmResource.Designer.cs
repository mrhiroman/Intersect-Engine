﻿namespace Intersect_Editor.Forms
{
    partial class frmResource
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstResources = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.scrlSpawnDuration = new System.Windows.Forms.HScrollBar();
            this.lblSpawnDuration = new System.Windows.Forms.Label();
            this.chkWalkableAfter = new System.Windows.Forms.CheckBox();
            this.chkWalkableBefore = new System.Windows.Forms.CheckBox();
            this.cmbToolType = new System.Windows.Forms.ComboBox();
            this.lblToolType = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpEndTileset = new System.Windows.Forms.GroupBox();
            this.picEndResource = new System.Windows.Forms.PictureBox();
            this.grpInitialTileset = new System.Windows.Forms.GroupBox();
            this.picInitialResource = new System.Windows.Forms.PictureBox();
            this.hScrollEndTileset = new System.Windows.Forms.HScrollBar();
            this.vScrollEndTileset = new System.Windows.Forms.VScrollBar();
            this.hScrollStartTileset = new System.Windows.Forms.HScrollBar();
            this.vScrollStartTileset = new System.Windows.Forms.VScrollBar();
            this.cmbEndSprite = new System.Windows.Forms.ComboBox();
            this.lblPic2 = new System.Windows.Forms.Label();
            this.cmbInitialSprite = new System.Windows.Forms.ComboBox();
            this.lblPic = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDropAmount = new System.Windows.Forms.TextBox();
            this.lblDropAmount = new System.Windows.Forms.Label();
            this.scrlDropChance = new System.Windows.Forms.HScrollBar();
            this.lblDropChance = new System.Windows.Forms.Label();
            this.scrlDropItem = new System.Windows.Forms.HScrollBar();
            this.lblDropItem = new System.Windows.Forms.Label();
            this.scrlDropIndex = new System.Windows.Forms.HScrollBar();
            this.lblDropIndex = new System.Windows.Forms.Label();
            this.txtMaxHp = new System.Windows.Forms.TextBox();
            this.lblMaxHp = new System.Windows.Forms.Label();
            this.scrlAnimation = new System.Windows.Forms.HScrollBar();
            this.lblAnimation = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpEndTileset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEndResource)).BeginInit();
            this.grpInitialTileset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInitialResource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lstResources);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 437);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(7, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Location = new System.Drawing.Point(7, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 27);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstResources
            // 
            this.lstResources.FormattingEnabled = true;
            this.lstResources.Location = new System.Drawing.Point(6, 19);
            this.lstResources.Name = "lstResources";
            this.lstResources.Size = new System.Drawing.Size(191, 303);
            this.lstResources.TabIndex = 1;
            this.lstResources.Click += new System.EventHandler(this.lstResources_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.scrlAnimation);
            this.groupBox2.Controls.Add(this.lblAnimation);
            this.groupBox2.Controls.Add(this.txtMaxHp);
            this.groupBox2.Controls.Add(this.lblMaxHp);
            this.groupBox2.Controls.Add(this.scrlSpawnDuration);
            this.groupBox2.Controls.Add(this.lblSpawnDuration);
            this.groupBox2.Controls.Add(this.chkWalkableAfter);
            this.groupBox2.Controls.Add(this.chkWalkableBefore);
            this.groupBox2.Controls.Add(this.cmbToolType);
            this.groupBox2.Controls.Add(this.lblToolType);
            this.groupBox2.Controls.Add(this.txtHP);
            this.groupBox2.Controls.Add(this.lblHP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(221, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 264);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // scrlSpawnDuration
            // 
            this.scrlSpawnDuration.Location = new System.Drawing.Point(9, 151);
            this.scrlSpawnDuration.Maximum = 3600;
            this.scrlSpawnDuration.Name = "scrlSpawnDuration";
            this.scrlSpawnDuration.Size = new System.Drawing.Size(201, 18);
            this.scrlSpawnDuration.TabIndex = 33;
            this.scrlSpawnDuration.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlSpawnDuration_Scroll);
            // 
            // lblSpawnDuration
            // 
            this.lblSpawnDuration.AutoSize = true;
            this.lblSpawnDuration.Location = new System.Drawing.Point(6, 138);
            this.lblSpawnDuration.Name = "lblSpawnDuration";
            this.lblSpawnDuration.Size = new System.Drawing.Size(95, 13);
            this.lblSpawnDuration.TabIndex = 32;
            this.lblSpawnDuration.Text = "Spawn Duration: 0";
            // 
            // chkWalkableAfter
            // 
            this.chkWalkableAfter.AutoSize = true;
            this.chkWalkableAfter.Location = new System.Drawing.Point(6, 240);
            this.chkWalkableAfter.Name = "chkWalkableAfter";
            this.chkWalkableAfter.Size = new System.Drawing.Size(185, 17);
            this.chkWalkableAfter.TabIndex = 31;
            this.chkWalkableAfter.Text = "Walkable after resource removal?";
            this.chkWalkableAfter.UseVisualStyleBackColor = true;
            this.chkWalkableAfter.CheckedChanged += new System.EventHandler(this.chkWalkableAfter_CheckedChanged);
            // 
            // chkWalkableBefore
            // 
            this.chkWalkableBefore.AutoSize = true;
            this.chkWalkableBefore.Location = new System.Drawing.Point(6, 217);
            this.chkWalkableBefore.Name = "chkWalkableBefore";
            this.chkWalkableBefore.Size = new System.Drawing.Size(194, 17);
            this.chkWalkableBefore.TabIndex = 30;
            this.chkWalkableBefore.Text = "Walkable before resource removal?";
            this.chkWalkableBefore.UseVisualStyleBackColor = true;
            this.chkWalkableBefore.CheckedChanged += new System.EventHandler(this.chkWalkableBefore_CheckedChanged);
            // 
            // cmbToolType
            // 
            this.cmbToolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToolType.FormattingEnabled = true;
            this.cmbToolType.Location = new System.Drawing.Point(75, 46);
            this.cmbToolType.Name = "cmbToolType";
            this.cmbToolType.Size = new System.Drawing.Size(135, 21);
            this.cmbToolType.TabIndex = 29;
            this.cmbToolType.SelectedIndexChanged += new System.EventHandler(this.cmbToolType_SelectedIndexChanged);
            // 
            // lblToolType
            // 
            this.lblToolType.AutoSize = true;
            this.lblToolType.Location = new System.Drawing.Point(6, 49);
            this.lblToolType.Name = "lblToolType";
            this.lblToolType.Size = new System.Drawing.Size(58, 13);
            this.lblToolType.TabIndex = 28;
            this.lblToolType.Text = "Tool Type:";
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(75, 77);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(135, 20);
            this.txtHP.TabIndex = 15;
            this.txtHP.TextChanged += new System.EventHandler(this.txtHP_TextChanged);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(6, 80);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(45, 13);
            this.lblHP.TabIndex = 16;
            this.lblHP.Text = "Min HP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grpEndTileset);
            this.groupBox3.Controls.Add(this.grpInitialTileset);
            this.groupBox3.Controls.Add(this.hScrollEndTileset);
            this.groupBox3.Controls.Add(this.vScrollEndTileset);
            this.groupBox3.Controls.Add(this.hScrollStartTileset);
            this.groupBox3.Controls.Add(this.vScrollStartTileset);
            this.groupBox3.Controls.Add(this.cmbEndSprite);
            this.groupBox3.Controls.Add(this.lblPic2);
            this.groupBox3.Controls.Add(this.cmbInitialSprite);
            this.groupBox3.Controls.Add(this.lblPic);
            this.groupBox3.Location = new System.Drawing.Point(450, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 437);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphics";
            // 
            // grpEndTileset
            // 
            this.grpEndTileset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpEndTileset.Controls.Add(this.picEndResource);
            this.grpEndTileset.Location = new System.Drawing.Point(248, 62);
            this.grpEndTileset.Name = "grpEndTileset";
            this.grpEndTileset.Size = new System.Drawing.Size(195, 341);
            this.grpEndTileset.TabIndex = 23;
            this.grpEndTileset.TabStop = false;
            // 
            // picEndResource
            // 
            this.picEndResource.Location = new System.Drawing.Point(0, 0);
            this.picEndResource.Name = "picEndResource";
            this.picEndResource.Size = new System.Drawing.Size(1024, 1024);
            this.picEndResource.TabIndex = 2;
            this.picEndResource.TabStop = false;
            // 
            // grpInitialTileset
            // 
            this.grpInitialTileset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpInitialTileset.Controls.Add(this.picInitialResource);
            this.grpInitialTileset.Location = new System.Drawing.Point(13, 62);
            this.grpInitialTileset.Name = "grpInitialTileset";
            this.grpInitialTileset.Size = new System.Drawing.Size(195, 341);
            this.grpInitialTileset.TabIndex = 22;
            this.grpInitialTileset.TabStop = false;
            // 
            // picInitialResource
            // 
            this.picInitialResource.Location = new System.Drawing.Point(0, 0);
            this.picInitialResource.Name = "picInitialResource";
            this.picInitialResource.Size = new System.Drawing.Size(1024, 1024);
            this.picInitialResource.TabIndex = 2;
            this.picInitialResource.TabStop = false;
            // 
            // hScrollEndTileset
            // 
            this.hScrollEndTileset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollEndTileset.LargeChange = 1;
            this.hScrollEndTileset.Location = new System.Drawing.Point(248, 406);
            this.hScrollEndTileset.MaximumSize = new System.Drawing.Size(960, 17);
            this.hScrollEndTileset.Name = "hScrollEndTileset";
            this.hScrollEndTileset.Size = new System.Drawing.Size(199, 17);
            this.hScrollEndTileset.TabIndex = 21;
            this.hScrollEndTileset.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollEndTileset_Scroll);
            // 
            // vScrollEndTileset
            // 
            this.vScrollEndTileset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollEndTileset.LargeChange = 1;
            this.vScrollEndTileset.Location = new System.Drawing.Point(451, 59);
            this.vScrollEndTileset.MaximumSize = new System.Drawing.Size(17, 960);
            this.vScrollEndTileset.Name = "vScrollEndTileset";
            this.vScrollEndTileset.Size = new System.Drawing.Size(17, 344);
            this.vScrollEndTileset.TabIndex = 20;
            this.vScrollEndTileset.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollEndTileset_Scroll);
            // 
            // hScrollStartTileset
            // 
            this.hScrollStartTileset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollStartTileset.LargeChange = 1;
            this.hScrollStartTileset.Location = new System.Drawing.Point(13, 406);
            this.hScrollStartTileset.MaximumSize = new System.Drawing.Size(960, 17);
            this.hScrollStartTileset.Name = "hScrollStartTileset";
            this.hScrollStartTileset.Size = new System.Drawing.Size(199, 17);
            this.hScrollStartTileset.TabIndex = 19;
            this.hScrollStartTileset.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollStartTileset_Scroll);
            // 
            // vScrollStartTileset
            // 
            this.vScrollStartTileset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollStartTileset.LargeChange = 1;
            this.vScrollStartTileset.Location = new System.Drawing.Point(216, 59);
            this.vScrollStartTileset.MaximumSize = new System.Drawing.Size(17, 960);
            this.vScrollStartTileset.Name = "vScrollStartTileset";
            this.vScrollStartTileset.Size = new System.Drawing.Size(17, 344);
            this.vScrollStartTileset.TabIndex = 18;
            this.vScrollStartTileset.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollStartTileset_Scroll);
            // 
            // cmbEndSprite
            // 
            this.cmbEndSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndSprite.FormattingEnabled = true;
            this.cmbEndSprite.Items.AddRange(new object[] {
            "None"});
            this.cmbEndSprite.Location = new System.Drawing.Point(248, 32);
            this.cmbEndSprite.Name = "cmbEndSprite";
            this.cmbEndSprite.Size = new System.Drawing.Size(196, 21);
            this.cmbEndSprite.TabIndex = 16;
            this.cmbEndSprite.SelectedIndexChanged += new System.EventHandler(this.cmbEndSprite_SelectedIndexChanged);
            // 
            // lblPic2
            // 
            this.lblPic2.AutoSize = true;
            this.lblPic2.Location = new System.Drawing.Point(245, 16);
            this.lblPic2.Name = "lblPic2";
            this.lblPic2.Size = new System.Drawing.Size(96, 13);
            this.lblPic2.TabIndex = 15;
            this.lblPic2.Text = "Removed Graphic:";
            // 
            // cmbInitialSprite
            // 
            this.cmbInitialSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInitialSprite.FormattingEnabled = true;
            this.cmbInitialSprite.Items.AddRange(new object[] {
            "None"});
            this.cmbInitialSprite.Location = new System.Drawing.Point(13, 32);
            this.cmbInitialSprite.Name = "cmbInitialSprite";
            this.cmbInitialSprite.Size = new System.Drawing.Size(195, 21);
            this.cmbInitialSprite.TabIndex = 14;
            this.cmbInitialSprite.SelectedIndexChanged += new System.EventHandler(this.cmbInitialSprite_SelectedIndexChanged);
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(10, 16);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(74, 13);
            this.lblPic.TabIndex = 13;
            this.lblPic.Text = "Initial Graphic:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.txtDropAmount);
            this.groupBox4.Controls.Add(this.lblDropAmount);
            this.groupBox4.Controls.Add(this.scrlDropChance);
            this.groupBox4.Controls.Add(this.lblDropChance);
            this.groupBox4.Controls.Add(this.scrlDropItem);
            this.groupBox4.Controls.Add(this.lblDropItem);
            this.groupBox4.Controls.Add(this.scrlDropIndex);
            this.groupBox4.Controls.Add(this.lblDropIndex);
            this.groupBox4.Location = new System.Drawing.Point(224, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 167);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Drops";
            // 
            // txtDropAmount
            // 
            this.txtDropAmount.Location = new System.Drawing.Point(9, 99);
            this.txtDropAmount.Name = "txtDropAmount";
            this.txtDropAmount.Size = new System.Drawing.Size(197, 20);
            this.txtDropAmount.TabIndex = 16;
            this.txtDropAmount.TextChanged += new System.EventHandler(this.txtDropAmount_TextChanged);
            // 
            // lblDropAmount
            // 
            this.lblDropAmount.AutoSize = true;
            this.lblDropAmount.Location = new System.Drawing.Point(6, 82);
            this.lblDropAmount.Name = "lblDropAmount";
            this.lblDropAmount.Size = new System.Drawing.Size(46, 13);
            this.lblDropAmount.TabIndex = 15;
            this.lblDropAmount.Text = "Amount:";
            // 
            // scrlDropChance
            // 
            this.scrlDropChance.LargeChange = 1;
            this.scrlDropChance.Location = new System.Drawing.Point(6, 135);
            this.scrlDropChance.Name = "scrlDropChance";
            this.scrlDropChance.Size = new System.Drawing.Size(200, 18);
            this.scrlDropChance.TabIndex = 14;
            this.scrlDropChance.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlDropChance_Scroll);
            // 
            // lblDropChance
            // 
            this.lblDropChance.AutoSize = true;
            this.lblDropChance.Location = new System.Drawing.Point(6, 120);
            this.lblDropChance.Name = "lblDropChance";
            this.lblDropChance.Size = new System.Drawing.Size(85, 13);
            this.lblDropChance.TabIndex = 13;
            this.lblDropChance.Text = "Chance (0/100):";
            // 
            // scrlDropItem
            // 
            this.scrlDropItem.LargeChange = 1;
            this.scrlDropItem.Location = new System.Drawing.Point(6, 64);
            this.scrlDropItem.Maximum = 3600;
            this.scrlDropItem.Name = "scrlDropItem";
            this.scrlDropItem.Size = new System.Drawing.Size(201, 18);
            this.scrlDropItem.TabIndex = 12;
            this.scrlDropItem.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlDropItem_Scroll);
            // 
            // lblDropItem
            // 
            this.lblDropItem.AutoSize = true;
            this.lblDropItem.Location = new System.Drawing.Point(6, 49);
            this.lblDropItem.Name = "lblDropItem";
            this.lblDropItem.Size = new System.Drawing.Size(39, 13);
            this.lblDropItem.TabIndex = 11;
            this.lblDropItem.Text = "Item: 1";
            // 
            // scrlDropIndex
            // 
            this.scrlDropIndex.LargeChange = 1;
            this.scrlDropIndex.Location = new System.Drawing.Point(6, 31);
            this.scrlDropIndex.Maximum = 10;
            this.scrlDropIndex.Minimum = 1;
            this.scrlDropIndex.Name = "scrlDropIndex";
            this.scrlDropIndex.Size = new System.Drawing.Size(200, 18);
            this.scrlDropIndex.TabIndex = 10;
            this.scrlDropIndex.Value = 1;
            this.scrlDropIndex.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlDropIndex_Scroll);
            // 
            // lblDropIndex
            // 
            this.lblDropIndex.AutoSize = true;
            this.lblDropIndex.Location = new System.Drawing.Point(6, 16);
            this.lblDropIndex.Name = "lblDropIndex";
            this.lblDropIndex.Size = new System.Drawing.Size(71, 13);
            this.lblDropIndex.TabIndex = 9;
            this.lblDropIndex.Text = "Drop Index: 1";
            // 
            // txtMaxHp
            // 
            this.txtMaxHp.Location = new System.Drawing.Point(75, 103);
            this.txtMaxHp.Name = "txtMaxHp";
            this.txtMaxHp.Size = new System.Drawing.Size(135, 20);
            this.txtMaxHp.TabIndex = 34;
            this.txtMaxHp.TextChanged += new System.EventHandler(this.txtMaxHp_TextChanged);
            // 
            // lblMaxHp
            // 
            this.lblMaxHp.AutoSize = true;
            this.lblMaxHp.Location = new System.Drawing.Point(6, 106);
            this.lblMaxHp.Name = "lblMaxHp";
            this.lblMaxHp.Size = new System.Drawing.Size(48, 13);
            this.lblMaxHp.TabIndex = 35;
            this.lblMaxHp.Text = "Max HP:";
            // 
            // scrlAnimation
            // 
            this.scrlAnimation.LargeChange = 1;
            this.scrlAnimation.Location = new System.Drawing.Point(9, 186);
            this.scrlAnimation.Maximum = 3600;
            this.scrlAnimation.Minimum = -1;
            this.scrlAnimation.Name = "scrlAnimation";
            this.scrlAnimation.Size = new System.Drawing.Size(201, 18);
            this.scrlAnimation.TabIndex = 37;
            this.scrlAnimation.Value = -1;
            this.scrlAnimation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlAnimation_Scroll);
            // 
            // lblAnimation
            // 
            this.lblAnimation.AutoSize = true;
            this.lblAnimation.Location = new System.Drawing.Point(6, 173);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.Size = new System.Drawing.Size(94, 13);
            this.lblAnimation.TabIndex = 36;
            this.lblAnimation.Text = "Animation: 0 None";
            // 
            // frmResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 460);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmResource";
            this.Text = "Resource Editor";
            this.Load += new System.EventHandler(this.frmResource_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpEndTileset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEndResource)).EndInit();
            this.grpInitialTileset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInitialResource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstResources;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.CheckBox chkWalkableAfter;
        private System.Windows.Forms.CheckBox chkWalkableBefore;
        private System.Windows.Forms.ComboBox cmbToolType;
        private System.Windows.Forms.Label lblToolType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDropAmount;
        private System.Windows.Forms.Label lblDropAmount;
        private System.Windows.Forms.HScrollBar scrlDropChance;
        private System.Windows.Forms.Label lblDropChance;
        private System.Windows.Forms.HScrollBar scrlDropItem;
        private System.Windows.Forms.Label lblDropItem;
        private System.Windows.Forms.HScrollBar scrlDropIndex;
        private System.Windows.Forms.Label lblDropIndex;
        private System.Windows.Forms.ComboBox cmbEndSprite;
        private System.Windows.Forms.Label lblPic2;
        private System.Windows.Forms.ComboBox cmbInitialSprite;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.HScrollBar scrlSpawnDuration;
        private System.Windows.Forms.Label lblSpawnDuration;
        private System.Windows.Forms.HScrollBar hScrollEndTileset;
        private System.Windows.Forms.VScrollBar vScrollEndTileset;
        private System.Windows.Forms.HScrollBar hScrollStartTileset;
        private System.Windows.Forms.VScrollBar vScrollStartTileset;
        private System.Windows.Forms.GroupBox grpEndTileset;
        public System.Windows.Forms.PictureBox picEndResource;
        private System.Windows.Forms.GroupBox grpInitialTileset;
        public System.Windows.Forms.PictureBox picInitialResource;
        private System.Windows.Forms.TextBox txtMaxHp;
        private System.Windows.Forms.Label lblMaxHp;
        private System.Windows.Forms.HScrollBar scrlAnimation;
        private System.Windows.Forms.Label lblAnimation;
    }
}