﻿namespace Breeze
{
		partial class Breeze
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
			private void InitializeComponent()
			{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Breeze));
			this.TitleBar = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.minimiseButton = new System.Windows.Forms.Panel();
			this.expandButton = new System.Windows.Forms.Panel();
			this.exitButton = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.treeView = new System.Windows.Forms.TreeView();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.mainEditorBox = new System.Windows.Forms.RichTextBox();
			this.editorBoxFocusLabel = new System.Windows.Forms.Label();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.numberLineLable = new System.Windows.Forms.Label();
			this.lineNumberBox = new System.Windows.Forms.RichTextBox();
			this.documentTreeSplitter = new System.Windows.Forms.SplitContainer();
			this.openFolderLabel = new System.Windows.Forms.Label();
			this.listView = new System.Windows.Forms.ListView();
			this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.currentFileLabel = new System.Windows.Forms.Label();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.documentTreeSplitter)).BeginInit();
			this.documentTreeSplitter.Panel1.SuspendLayout();
			this.documentTreeSplitter.Panel2.SuspendLayout();
			this.documentTreeSplitter.SuspendLayout();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleBar
			// 
			this.TitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
			this.TitleBar.Controls.Add(this.currentFileLabel);
			this.TitleBar.Controls.Add(this.titleLabel);
			this.TitleBar.Controls.Add(this.minimiseButton);
			this.TitleBar.Controls.Add(this.expandButton);
			this.TitleBar.Controls.Add(this.exitButton);
			this.TitleBar.Controls.Add(this.pictureBox1);
			this.TitleBar.Location = new System.Drawing.Point(4, 4);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(992, 35);
			this.TitleBar.TabIndex = 1;
			this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
			// 
			// titleLabel
			// 
			this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("rainyhearts", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.Color.GhostWhite;
			this.titleLabel.Location = new System.Drawing.Point(63, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(63, 18);
			this.titleLabel.TabIndex = 5;
			this.titleLabel.Text = "Breeze";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// minimiseButton
			// 
			this.minimiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.minimiseButton.BackgroundImage = global::Breeze.Properties.Resources.minimiseIcon;
			this.minimiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.minimiseButton.Location = new System.Drawing.Point(858, 0);
			this.minimiseButton.Name = "minimiseButton";
			this.minimiseButton.Size = new System.Drawing.Size(45, 35);
			this.minimiseButton.TabIndex = 4;
			this.minimiseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimiseButton_MouseDown);
			this.minimiseButton.MouseEnter += new System.EventHandler(this.MinimiseButton_MouseEnter);
			this.minimiseButton.MouseLeave += new System.EventHandler(this.MinimiseButton_MouseExit);
			// 
			// expandButton
			// 
			this.expandButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.expandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
			this.expandButton.BackgroundImage = global::Breeze.Properties.Resources.expandIcon;
			this.expandButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.expandButton.ForeColor = System.Drawing.Color.White;
			this.expandButton.Location = new System.Drawing.Point(902, 0);
			this.expandButton.Name = "expandButton";
			this.expandButton.Size = new System.Drawing.Size(46, 35);
			this.expandButton.TabIndex = 3;
			this.expandButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExpandButton_MouseDown);
			this.expandButton.MouseEnter += new System.EventHandler(this.ExpandButton_MouseEnter);
			this.expandButton.MouseLeave += new System.EventHandler(this.ExpandButton_MouseExit);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.BackgroundImage = global::Breeze.Properties.Resources.exitIcon;
			this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.exitButton.Location = new System.Drawing.Point(947, 0);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(45, 35);
			this.exitButton.TabIndex = 2;
			this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseDown);
			this.exitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
			this.exitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Breeze.Properties.Resources.icon;
			this.pictureBox1.Location = new System.Drawing.Point(4, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(52, 35);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// treeView
			// 
			this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(13)))), ((int)(((byte)(33)))));
			this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeView.ForeColor = System.Drawing.Color.Gainsboro;
			this.treeView.ImageIndex = 0;
			this.treeView.ImageList = this.imageList;
			this.treeView.Indent = 8;
			this.treeView.ItemHeight = 16;
			this.treeView.LineColor = System.Drawing.Color.White;
			this.treeView.Location = new System.Drawing.Point(0, 0);
			this.treeView.Name = "treeView";
			this.treeView.SelectedImageIndex = 0;
			this.treeView.Size = new System.Drawing.Size(205, 97);
			this.treeView.StateImageList = this.imageList;
			this.treeView.TabIndex = 2;
			this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "folderIcon.png");
			this.imageList.Images.SetKeyName(1, "docIcon.png");
			// 
			// mainEditorBox
			// 
			this.mainEditorBox.AcceptsTab = true;
			this.mainEditorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainEditorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(51)))));
			this.mainEditorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mainEditorBox.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainEditorBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.mainEditorBox.Location = new System.Drawing.Point(-1, -1);
			this.mainEditorBox.Name = "mainEditorBox";
			this.mainEditorBox.Size = new System.Drawing.Size(747, 577);
			this.mainEditorBox.TabIndex = 3;
			this.mainEditorBox.Text = "";
			this.mainEditorBox.WordWrap = false;
			this.mainEditorBox.VScroll += new System.EventHandler(this.MainEditor_VerticalChanged);
			this.mainEditorBox.TextChanged += new System.EventHandler(this.MainEditorBox_TextChanged);
			this.mainEditorBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Editor_RightDown);
			// 
			// editorBoxFocusLabel
			// 
			this.editorBoxFocusLabel.AutoSize = true;
			this.editorBoxFocusLabel.Location = new System.Drawing.Point(192, 581);
			this.editorBoxFocusLabel.Name = "editorBoxFocusLabel";
			this.editorBoxFocusLabel.Size = new System.Drawing.Size(0, 13);
			this.editorBoxFocusLabel.TabIndex = 4;
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(211, 42);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.AutoScroll = true;
			this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(51)))));
			this.splitContainer.Panel1.Controls.Add(this.numberLineLable);
			this.splitContainer.Panel1.Controls.Add(this.lineNumberBox);
			this.splitContainer.Panel1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.AutoScroll = true;
			this.splitContainer.Panel2.Controls.Add(this.mainEditorBox);
			this.splitContainer.Panel2.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitContainer.Panel2.ForeColor = System.Drawing.Color.White;
			this.splitContainer.Size = new System.Drawing.Size(781, 573);
			this.splitContainer.SplitterDistance = 35;
			this.splitContainer.TabIndex = 5;
			// 
			// numberLineLable
			// 
			this.numberLineLable.AutoSize = true;
			this.numberLineLable.ForeColor = System.Drawing.Color.Gray;
			this.numberLineLable.Location = new System.Drawing.Point(13, 0);
			this.numberLineLable.Name = "numberLineLable";
			this.numberLineLable.Size = new System.Drawing.Size(0, 16);
			this.numberLineLable.TabIndex = 1;
			this.numberLineLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lineNumberBox
			// 
			this.lineNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lineNumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(51)))));
			this.lineNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lineNumberBox.ForeColor = System.Drawing.Color.Gray;
			this.lineNumberBox.Location = new System.Drawing.Point(-2, 0);
			this.lineNumberBox.Name = "lineNumberBox";
			this.lineNumberBox.ReadOnly = true;
			this.lineNumberBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lineNumberBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.lineNumberBox.Size = new System.Drawing.Size(34, 576);
			this.lineNumberBox.TabIndex = 6;
			this.lineNumberBox.Text = "1";
			this.lineNumberBox.WordWrap = false;
			// 
			// documentTreeSplitter
			// 
			this.documentTreeSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.documentTreeSplitter.Location = new System.Drawing.Point(4, 39);
			this.documentTreeSplitter.Name = "documentTreeSplitter";
			this.documentTreeSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// documentTreeSplitter.Panel1
			// 
			this.documentTreeSplitter.Panel1.Controls.Add(this.openFolderLabel);
			this.documentTreeSplitter.Panel1.Controls.Add(this.treeView);
			// 
			// documentTreeSplitter.Panel2
			// 
			this.documentTreeSplitter.Panel2.Controls.Add(this.listView);
			this.documentTreeSplitter.Size = new System.Drawing.Size(205, 581);
			this.documentTreeSplitter.SplitterDistance = 97;
			this.documentTreeSplitter.TabIndex = 6;
			// 
			// openFolderLabel
			// 
			this.openFolderLabel.AutoSize = true;
			this.openFolderLabel.ForeColor = System.Drawing.Color.GhostWhite;
			this.openFolderLabel.Location = new System.Drawing.Point(17, 15);
			this.openFolderLabel.Name = "openFolderLabel";
			this.openFolderLabel.Size = new System.Drawing.Size(62, 13);
			this.openFolderLabel.TabIndex = 3;
			this.openFolderLabel.Text = "Open folder";
			this.openFolderLabel.Click += new System.EventHandler(this.OpenFolderLabel_Click);
			// 
			// listView
			// 
			this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView.AutoArrange = false;
			this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(13)))), ((int)(((byte)(33)))));
			this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.type});
			this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView.ForeColor = System.Drawing.Color.Gainsboro;
			this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView.HideSelection = false;
			this.listView.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.listView.LabelWrap = false;
			this.listView.Location = new System.Drawing.Point(0, 2);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(205, 478);
			this.listView.SmallImageList = this.imageList;
			this.listView.TabIndex = 0;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.List;
			this.listView.ItemActivate += new System.EventHandler(this.ListView_ItemChosen);
			// 
			// name
			// 
			this.name.Text = "Name";
			this.name.Width = 150;
			// 
			// type
			// 
			this.type.Text = "Type";
			this.type.Width = 59;
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(181, 92);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem2,
            this.saveToolStripMenuItem1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem1.Text = "Open File";
			// 
			// saveToolStripMenuItem2
			// 
			this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
			this.saveToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem2.Text = "Open Folder";
			this.saveToolStripMenuItem2.Click += new System.EventHandler(this.ContextMenu_FolderClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// currentFileLabel
			// 
			this.currentFileLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.currentFileLabel.AutoSize = true;
			this.currentFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentFileLabel.ForeColor = System.Drawing.Color.Gray;
			this.currentFileLabel.Location = new System.Drawing.Point(166, 12);
			this.currentFileLabel.Name = "currentFileLabel";
			this.currentFileLabel.Size = new System.Drawing.Size(45, 13);
			this.currentFileLabel.TabIndex = 6;
			this.currentFileLabel.Text = "Editing: ";
			this.currentFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.closeToolStripMenuItem.Text = "Close";
			// 
			// Breeze
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1000, 624);
			this.ControlBox = false;
			this.Controls.Add(this.documentTreeSplitter);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.editorBoxFocusLabel);
			this.Controls.Add(this.TitleBar);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.Name = "Breeze";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TitleBar.ResumeLayout(false);
			this.TitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.documentTreeSplitter.Panel1.ResumeLayout(false);
			this.documentTreeSplitter.Panel1.PerformLayout();
			this.documentTreeSplitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.documentTreeSplitter)).EndInit();
			this.documentTreeSplitter.ResumeLayout(false);
			this.contextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion
		private System.Windows.Forms.Panel TitleBar;
		    private System.Windows.Forms.Panel expandButton;
		    private System.Windows.Forms.Panel exitButton;
		    private System.Windows.Forms.Panel minimiseButton;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.RichTextBox mainEditorBox;
		private System.Windows.Forms.Label editorBoxFocusLabel;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Label numberLineLable;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.RichTextBox lineNumberBox;
		private System.Windows.Forms.SplitContainer documentTreeSplitter;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.ColumnHeader type;
		private System.Windows.Forms.Label openFolderLabel;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
		private System.Windows.Forms.Label currentFileLabel;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
	}
}

