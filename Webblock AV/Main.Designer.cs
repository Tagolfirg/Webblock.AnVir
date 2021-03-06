﻿using System.Drawing;
namespace Webblock_AV
{

    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("This PC");
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnTabFullScan = new MaterialFramework.HButton();
            this.BtnTabQuickScan = new MaterialFramework.HButton();
            this.BtnTabSelective = new MaterialFramework.HButton();
            this.BtnDashBoard = new MaterialFramework.HButton();
            this.BtnUpdates = new MaterialFramework.HButton();
            this.BtnAbout = new MaterialFramework.HButton();
            this.PanelSelector = new System.Windows.Forms.Panel();
            this.BtnSettings = new MaterialFramework.HButton();
            this.BtnScanner = new MaterialFramework.HButton();
            this.BtnProtection = new MaterialFramework.HButton();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button1 = new System.Windows.Forms.Button();
            this.treePath = new System.Windows.Forms.TreeView();
            this.ShellImageList = new System.Windows.Forms.ImageList(this.components);
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabDashboard = new System.Windows.Forms.TabPage();
            this.TabProtection = new System.Windows.Forms.TabPage();
            this.TabSelective = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnScan = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TabUpdates = new System.Windows.Forms.TabPage();
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.TabScanner = new System.Windows.Forms.TabPage();
            this.materialPanel2 = new MaterialFramework.MaterialPanel();
            this.BtnStop = new System.Windows.Forms.Button();
            this.LblDetected = new System.Windows.Forms.Label();
            this.LblTotalScan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblCurrent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.TabQuickScan = new System.Windows.Forms.TabPage();
            this.TabFullScan = new System.Windows.Forms.TabPage();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelSide.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabSelective.SuspendLayout();
            this.TabScanner.SuspendLayout();
            this.materialPanel2.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PanelSide
            // 
            this.PanelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PanelSide.Controls.Add(this.label4);
            this.PanelSide.Controls.Add(this.BtnTabFullScan);
            this.PanelSide.Controls.Add(this.BtnTabQuickScan);
            this.PanelSide.Controls.Add(this.BtnTabSelective);
            this.PanelSide.Controls.Add(this.BtnDashBoard);
            this.PanelSide.Controls.Add(this.BtnUpdates);
            this.PanelSide.Controls.Add(this.BtnAbout);
            this.PanelSide.Controls.Add(this.PanelSelector);
            this.PanelSide.Controls.Add(this.BtnSettings);
            this.PanelSide.Controls.Add(this.BtnScanner);
            this.PanelSide.Controls.Add(this.BtnProtection);
            this.PanelSide.Controls.Add(this.shapeContainer2);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSide.Location = new System.Drawing.Point(0, 0);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(262, 609);
            this.PanelSide.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Webblock AnVir";
            // 
            // BtnTabFullScan
            // 
            this.BtnTabFullScan.BackColor = System.Drawing.Color.Transparent;
            this.BtnTabFullScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTabFullScan.FlatAppearance.BorderSize = 0;
            this.BtnTabFullScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabFullScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabFullScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTabFullScan.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTabFullScan.ForeColor = System.Drawing.Color.White;
            this.BtnTabFullScan.Image = global::Webblock_AV.Properties.Resources.baseline_search_white_24dp;
            this.BtnTabFullScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabFullScan.Location = new System.Drawing.Point(3, 230);
            this.BtnTabFullScan.Name = "BtnTabFullScan";
            this.BtnTabFullScan.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnTabFullScan.Size = new System.Drawing.Size(259, 44);
            this.BtnTabFullScan.TabIndex = 16;
            this.BtnTabFullScan.Text = "               Full Scan";
            this.BtnTabFullScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabFullScan.UseVisualStyleBackColor = false;
            this.BtnTabFullScan.Click += new System.EventHandler(this.BtnFullScan_Click);
            // 
            // BtnTabQuickScan
            // 
            this.BtnTabQuickScan.BackColor = System.Drawing.Color.Transparent;
            this.BtnTabQuickScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTabQuickScan.FlatAppearance.BorderSize = 0;
            this.BtnTabQuickScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabQuickScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabQuickScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTabQuickScan.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTabQuickScan.ForeColor = System.Drawing.Color.White;
            this.BtnTabQuickScan.Image = ((System.Drawing.Image)(resources.GetObject("BtnTabQuickScan.Image")));
            this.BtnTabQuickScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabQuickScan.Location = new System.Drawing.Point(3, 280);
            this.BtnTabQuickScan.Name = "BtnTabQuickScan";
            this.BtnTabQuickScan.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnTabQuickScan.Size = new System.Drawing.Size(259, 44);
            this.BtnTabQuickScan.TabIndex = 15;
            this.BtnTabQuickScan.Text = "               Quick Scan";
            this.BtnTabQuickScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabQuickScan.UseVisualStyleBackColor = false;
            this.BtnTabQuickScan.Click += new System.EventHandler(this.BtnTabQuickScan_Click);
            // 
            // BtnTabSelective
            // 
            this.BtnTabSelective.BackColor = System.Drawing.Color.Transparent;
            this.BtnTabSelective.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTabSelective.FlatAppearance.BorderSize = 0;
            this.BtnTabSelective.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabSelective.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnTabSelective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTabSelective.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTabSelective.ForeColor = System.Drawing.Color.White;
            this.BtnTabSelective.Image = global::Webblock_AV.Properties.Resources.Cursor_hand_white_24px;
            this.BtnTabSelective.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabSelective.Location = new System.Drawing.Point(3, 330);
            this.BtnTabSelective.Name = "BtnTabSelective";
            this.BtnTabSelective.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnTabSelective.Size = new System.Drawing.Size(259, 44);
            this.BtnTabSelective.TabIndex = 13;
            this.BtnTabSelective.Text = "               Selective Scan";
            this.BtnTabSelective.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabSelective.UseVisualStyleBackColor = false;
            this.BtnTabSelective.Click += new System.EventHandler(this.BtnTabSelective_Click);
            // 
            // BtnDashBoard
            // 
            this.BtnDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.BtnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDashBoard.FlatAppearance.BorderSize = 0;
            this.BtnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashBoard.ForeColor = System.Drawing.Color.White;
            this.BtnDashBoard.Image = global::Webblock_AV.Properties.Resources.baseline_home_white_24dp;
            this.BtnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashBoard.Location = new System.Drawing.Point(3, 64);
            this.BtnDashBoard.Name = "BtnDashBoard";
            this.BtnDashBoard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnDashBoard.Size = new System.Drawing.Size(259, 50);
            this.BtnDashBoard.TabIndex = 12;
            this.BtnDashBoard.Text = "                    Dashboard";
            this.BtnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashBoard.UseVisualStyleBackColor = false;
            this.BtnDashBoard.Click += new System.EventHandler(this.BtnDashBoard_Click);
            // 
            // BtnUpdates
            // 
            this.BtnUpdates.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdates.FlatAppearance.BorderSize = 0;
            this.BtnUpdates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnUpdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdates.ForeColor = System.Drawing.Color.White;
            this.BtnUpdates.Image = global::Webblock_AV.Properties.Resources.baseline_refresh_white_24dp;
            this.BtnUpdates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdates.Location = new System.Drawing.Point(3, 381);
            this.BtnUpdates.Name = "BtnUpdates";
            this.BtnUpdates.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnUpdates.Size = new System.Drawing.Size(259, 50);
            this.BtnUpdates.TabIndex = 11;
            this.BtnUpdates.Text = "                    Updates";
            this.BtnUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdates.UseVisualStyleBackColor = false;
            this.BtnUpdates.Click += new System.EventHandler(this.BtnUpdates_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbout.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.White;
            this.BtnAbout.Image = global::Webblock_AV.Properties.Resources.baseline_help_white_24dp;
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.Location = new System.Drawing.Point(3, 538);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAbout.Size = new System.Drawing.Size(259, 50);
            this.BtnAbout.TabIndex = 9;
            this.BtnAbout.Text = "                    About";
            this.BtnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.UseMnemonic = false;
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // PanelSelector
            // 
            this.PanelSelector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelSelector.Location = new System.Drawing.Point(0, 64);
            this.PanelSelector.Name = "PanelSelector";
            this.PanelSelector.Size = new System.Drawing.Size(3, 50);
            this.PanelSelector.TabIndex = 7;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Image = global::Webblock_AV.Properties.Resources.baseline_settings_white_24dp;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.Location = new System.Drawing.Point(3, 482);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSettings.Size = new System.Drawing.Size(259, 50);
            this.BtnSettings.TabIndex = 8;
            this.BtnSettings.Text = "                    Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.UseMnemonic = false;
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnScanner
            // 
            this.BtnScanner.BackColor = System.Drawing.Color.Transparent;
            this.BtnScanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnScanner.FlatAppearance.BorderSize = 0;
            this.BtnScanner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnScanner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScanner.ForeColor = System.Drawing.Color.White;
            this.BtnScanner.Image = global::Webblock_AV.Properties.Resources.baseline_search_white_24dp;
            this.BtnScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScanner.Location = new System.Drawing.Point(3, 176);
            this.BtnScanner.Name = "BtnScanner";
            this.BtnScanner.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnScanner.Size = new System.Drawing.Size(259, 50);
            this.BtnScanner.TabIndex = 7;
            this.BtnScanner.Text = "                    Scanner";
            this.BtnScanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScanner.UseVisualStyleBackColor = false;
            this.BtnScanner.Click += new System.EventHandler(this.BtnScanner_Click);
            // 
            // BtnProtection
            // 
            this.BtnProtection.BackColor = System.Drawing.Color.Transparent;
            this.BtnProtection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProtection.FlatAppearance.BorderSize = 0;
            this.BtnProtection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnProtection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BtnProtection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProtection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProtection.ForeColor = System.Drawing.Color.White;
            this.BtnProtection.Image = global::Webblock_AV.Properties.Resources.shield_outline_24px;
            this.BtnProtection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProtection.Location = new System.Drawing.Point(3, 120);
            this.BtnProtection.Name = "BtnProtection";
            this.BtnProtection.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnProtection.Size = new System.Drawing.Size(259, 50);
            this.BtnProtection.TabIndex = 5;
            this.BtnProtection.Text = "                    Protection";
            this.BtnProtection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProtection.UseVisualStyleBackColor = false;
            this.BtnProtection.Click += new System.EventHandler(this.BtnProtection_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(262, 609);
            this.shapeContainer2.TabIndex = 10;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 9;
            this.lineShape1.X2 = 244;
            this.lineShape1.Y1 = 465;
            this.lineShape1.Y2 = 465;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // treePath
            // 
            this.treePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePath.CheckBoxes = true;
            this.treePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treePath.HideSelection = false;
            this.treePath.ImageIndex = 0;
            this.treePath.ImageList = this.ShellImageList;
            this.treePath.Location = new System.Drawing.Point(29, 126);
            this.treePath.Name = "treePath";
            treeNode2.Name = "Node0";
            treeNode2.Text = "This PC";
            this.treePath.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treePath.SelectedImageIndex = 0;
            this.treePath.Size = new System.Drawing.Size(705, 402);
            this.treePath.TabIndex = 0;
            this.treePath.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treePath_AfterCheck);
            this.treePath.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // ShellImageList
            // 
            this.ShellImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ShellImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ShellImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TabMain
            // 
            this.TabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabMain.Controls.Add(this.TabDashboard);
            this.TabMain.Controls.Add(this.TabProtection);
            this.TabMain.Controls.Add(this.TabSelective);
            this.TabMain.Controls.Add(this.TabUpdates);
            this.TabMain.Controls.Add(this.TabSettings);
            this.TabMain.Controls.Add(this.TabAbout);
            this.TabMain.Controls.Add(this.TabScanner);
            this.TabMain.Controls.Add(this.TabQuickScan);
            this.TabMain.Controls.Add(this.TabFullScan);
            this.TabMain.Location = new System.Drawing.Point(229, -13);
            this.TabMain.Multiline = true;
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(793, 630);
            this.TabMain.TabIndex = 6;
            // 
            // TabDashboard
            // 
            this.TabDashboard.BackColor = System.Drawing.Color.DimGray;
            this.TabDashboard.Location = new System.Drawing.Point(23, 4);
            this.TabDashboard.Name = "TabDashboard";
            this.TabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.TabDashboard.Size = new System.Drawing.Size(766, 622);
            this.TabDashboard.TabIndex = 0;
            this.TabDashboard.Text = "tabPage1";
            // 
            // TabProtection
            // 
            this.TabProtection.Location = new System.Drawing.Point(23, 4);
            this.TabProtection.Name = "TabProtection";
            this.TabProtection.Padding = new System.Windows.Forms.Padding(3);
            this.TabProtection.Size = new System.Drawing.Size(766, 622);
            this.TabProtection.TabIndex = 1;
            this.TabProtection.Text = "tabPage2";
            this.TabProtection.UseVisualStyleBackColor = true;
            // 
            // TabSelective
            // 
            this.TabSelective.BackColor = System.Drawing.Color.DimGray;
            this.TabSelective.Controls.Add(this.button1);
            this.TabSelective.Controls.Add(this.treePath);
            this.TabSelective.Controls.Add(this.label1);
            this.TabSelective.Controls.Add(this.label2);
            this.TabSelective.Controls.Add(this.label3);
            this.TabSelective.Controls.Add(this.BtnScan);
            this.TabSelective.Controls.Add(this.shapeContainer1);
            this.TabSelective.Location = new System.Drawing.Point(23, 4);
            this.TabSelective.Name = "TabSelective";
            this.TabSelective.Size = new System.Drawing.Size(766, 622);
            this.TabSelective.TabIndex = 2;
            this.TabSelective.Text = "TabSelective";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selective Scan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose what you want to scan";
            // 
            // BtnScan
            // 
            this.BtnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnScan.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnScan.FlatAppearance.BorderSize = 0;
            this.BtnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnScan.Image = global::Webblock_AV.Properties.Resources.baseline_play_circle_outline_white_24dp;
            this.BtnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnScan.Location = new System.Drawing.Point(29, 554);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnScan.Size = new System.Drawing.Size(114, 36);
            this.BtnScan.TabIndex = 3;
            this.BtnScan.Text = "  Scan Now!";
            this.BtnScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScan.UseVisualStyleBackColor = false;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(766, 622);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 27;
            this.lineShape3.X2 = 732;
            this.lineShape3.Y1 = 90;
            this.lineShape3.Y2 = 90;
            // 
            // TabUpdates
            // 
            this.TabUpdates.Location = new System.Drawing.Point(23, 4);
            this.TabUpdates.Name = "TabUpdates";
            this.TabUpdates.Size = new System.Drawing.Size(766, 622);
            this.TabUpdates.TabIndex = 3;
            this.TabUpdates.Text = "TabUpdates";
            this.TabUpdates.UseVisualStyleBackColor = true;
            // 
            // TabSettings
            // 
            this.TabSettings.Location = new System.Drawing.Point(23, 4);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Size = new System.Drawing.Size(766, 622);
            this.TabSettings.TabIndex = 4;
            this.TabSettings.Text = "tabPage3";
            this.TabSettings.UseVisualStyleBackColor = true;
            // 
            // TabAbout
            // 
            this.TabAbout.Location = new System.Drawing.Point(23, 4);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Size = new System.Drawing.Size(766, 622);
            this.TabAbout.TabIndex = 5;
            this.TabAbout.Text = "tabPage1";
            this.TabAbout.UseVisualStyleBackColor = true;
            // 
            // TabScanner
            // 
            this.TabScanner.BackColor = System.Drawing.Color.DimGray;
            this.TabScanner.Controls.Add(this.materialPanel2);
            this.TabScanner.Location = new System.Drawing.Point(23, 4);
            this.TabScanner.Name = "TabScanner";
            this.TabScanner.Size = new System.Drawing.Size(766, 622);
            this.TabScanner.TabIndex = 6;
            this.TabScanner.Text = "tabPage1";
            // 
            // materialPanel2
            // 
            this.materialPanel2.Controls.Add(this.BtnStop);
            this.materialPanel2.Controls.Add(this.LblDetected);
            this.materialPanel2.Controls.Add(this.LblTotalScan);
            this.materialPanel2.Controls.Add(this.label10);
            this.materialPanel2.Controls.Add(this.label9);
            this.materialPanel2.Controls.Add(this.label8);
            this.materialPanel2.Controls.Add(this.LblCurrent);
            this.materialPanel2.Controls.Add(this.label6);
            this.materialPanel2.Controls.Add(this.progressBar1);
            this.materialPanel2.Controls.Add(this.label5);
            this.materialPanel2.DarkTheme = true;
            this.materialPanel2.Location = new System.Drawing.Point(48, 146);
            this.materialPanel2.Name = "materialPanel2";
            this.materialPanel2.Size = new System.Drawing.Size(651, 329);
            this.materialPanel2.TabIndex = 5;
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnStop.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnStop.FlatAppearance.BorderSize = 0;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnStop.Image = global::Webblock_AV.Properties.Resources.baseline_stop_white_24dp;
            this.BtnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStop.Location = new System.Drawing.Point(24, 130);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnStop.Size = new System.Drawing.Size(106, 32);
            this.BtnStop.TabIndex = 10;
            this.BtnStop.Text = "    Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Visible = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // LblDetected
            // 
            this.LblDetected.AutoEllipsis = true;
            this.LblDetected.BackColor = System.Drawing.Color.Transparent;
            this.LblDetected.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetected.ForeColor = System.Drawing.Color.Red;
            this.LblDetected.Location = new System.Drawing.Point(101, 249);
            this.LblDetected.Name = "LblDetected";
            this.LblDetected.Size = new System.Drawing.Size(54, 15);
            this.LblDetected.TabIndex = 8;
            this.LblDetected.Text = "0";
            // 
            // LblTotalScan
            // 
            this.LblTotalScan.AutoEllipsis = true;
            this.LblTotalScan.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalScan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalScan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTotalScan.Location = new System.Drawing.Point(164, 220);
            this.LblTotalScan.Name = "LblTotalScan";
            this.LblTotalScan.Size = new System.Drawing.Size(54, 15);
            this.LblTotalScan.TabIndex = 7;
            this.LblTotalScan.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(21, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Total file yang di scan :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(21, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Terdeteksi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(19, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Laporan Scan";
            // 
            // LblCurrent
            // 
            this.LblCurrent.AutoEllipsis = true;
            this.LblCurrent.BackColor = System.Drawing.Color.Transparent;
            this.LblCurrent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCurrent.Location = new System.Drawing.Point(89, 66);
            this.LblCurrent.Name = "LblCurrent";
            this.LblCurrent.Size = new System.Drawing.Size(528, 17);
            this.LblCurrent.TabIndex = 3;
            this.LblCurrent.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(21, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Scanning :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 93);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(593, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(18, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Proses Scan";
            // 
            // TabQuickScan
            // 
            this.TabQuickScan.Location = new System.Drawing.Point(23, 4);
            this.TabQuickScan.Name = "TabQuickScan";
            this.TabQuickScan.Size = new System.Drawing.Size(766, 622);
            this.TabQuickScan.TabIndex = 7;
            this.TabQuickScan.Text = "tabPage1";
            this.TabQuickScan.UseVisualStyleBackColor = true;
            // 
            // TabFullScan
            // 
            this.TabFullScan.Location = new System.Drawing.Point(23, 4);
            this.TabFullScan.Name = "TabFullScan";
            this.TabFullScan.Size = new System.Drawing.Size(766, 622);
            this.TabFullScan.TabIndex = 8;
            this.TabFullScan.Text = "tabPage1";
            this.TabFullScan.UseVisualStyleBackColor = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.directoryToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1014, 609);
            this.Controls.Add(this.PanelSide);
            this.Controls.Add(this.TabMain);
            this.MinimumSize = new System.Drawing.Size(1030, 648);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webblock AnVir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.PanelSide.ResumeLayout(false);
            this.PanelSide.PerformLayout();
            this.TabMain.ResumeLayout(false);
            this.TabSelective.ResumeLayout(false);
            this.TabSelective.PerformLayout();
            this.TabScanner.ResumeLayout(false);
            this.materialPanel2.ResumeLayout(false);
            this.materialPanel2.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelSide;
        private MaterialFramework.HButton BtnProtection;
        private MaterialFramework.HButton BtnScanner;
        private MaterialFramework.HButton BtnSettings;
        private System.Windows.Forms.Panel PanelSelector;
        private MaterialFramework.HButton BtnAbout;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MaterialFramework.HButton BtnDashBoard;
        private MaterialFramework.HButton BtnUpdates;
        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage TabProtection;
        private System.Windows.Forms.TabPage TabDashboard;
        private System.Windows.Forms.TabPage TabSelective;
        private System.Windows.Forms.TabPage TabUpdates;
        private System.Windows.Forms.TabPage TabSettings;
        private System.Windows.Forms.TabPage TabAbout;
        private System.Windows.Forms.TreeView treePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ShellImageList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Button BtnScan;
        private MaterialFramework.HButton BtnTabSelective;
        private MaterialFramework.HButton BtnTabFullScan;
        private MaterialFramework.HButton BtnTabQuickScan;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TabPage TabScanner;
        private System.Windows.Forms.TabPage TabQuickScan;
        private System.Windows.Forms.TabPage TabFullScan;
        private MaterialFramework.MaterialPanel materialPanel2;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblCurrent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LblDetected;
        private System.Windows.Forms.Label LblTotalScan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnStop;
    }
}

