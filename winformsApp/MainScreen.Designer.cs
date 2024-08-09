namespace PhoneBook
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            menuStrip = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuEdit = new ToolStripMenuItem();
            menuCut = new ToolStripMenuItem();
            menuCopy = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuPaste = new ToolStripMenuItem();
            menuOperation = new ToolStripMenuItem();
            menuNewItem = new ToolStripMenuItem();
            menuEditItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuDeleteItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuUpdate = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            menuMoreInformation = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            lblTime = new ToolStripStatusLabel();
            lblItemCount = new ToolStripStatusLabel();
            lblLastOperationInfo = new ToolStripStatusLabel();
            dataGridView = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAddFile = new ToolStripButton();
            btnEditFile = new ToolStripButton();
            btnNewFile = new ToolStripButton();
            btnSaveFile = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            btnCut = new ToolStripButton();
            btnCopy = new ToolStripButton();
            btnPaste = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            menuStrip.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuFile, menuEdit, menuOperation, menuAbout });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(116, 26);
            menuExit.Text = "Exit";
            // 
            // menuEdit
            // 
            menuEdit.DropDownItems.AddRange(new ToolStripItem[] { menuCut, menuCopy, toolStripSeparator1, menuPaste });
            menuEdit.Name = "menuEdit";
            menuEdit.Size = new Size(49, 24);
            menuEdit.Text = "Edit";
            // 
            // menuCut
            // 
            menuCut.Name = "menuCut";
            menuCut.Size = new Size(126, 26);
            menuCut.Text = "Cut";
            // 
            // menuCopy
            // 
            menuCopy.Name = "menuCopy";
            menuCopy.Size = new Size(126, 26);
            menuCopy.Text = "Copy";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(123, 6);
            // 
            // menuPaste
            // 
            menuPaste.Name = "menuPaste";
            menuPaste.Size = new Size(126, 26);
            menuPaste.Text = "Paste";
            // 
            // menuOperation
            // 
            menuOperation.DropDownItems.AddRange(new ToolStripItem[] { menuNewItem, menuEditItem, toolStripSeparator2, menuDeleteItem, toolStripSeparator3, menuUpdate });
            menuOperation.Name = "menuOperation";
            menuOperation.Size = new Size(90, 24);
            menuOperation.Text = "Operation";
            // 
            // menuNewItem
            // 
            menuNewItem.Name = "menuNewItem";
            menuNewItem.Size = new Size(170, 26);
            menuNewItem.Text = "New Item";
            // 
            // menuEditItem
            // 
            menuEditItem.Name = "menuEditItem";
            menuEditItem.Size = new Size(170, 26);
            menuEditItem.Text = "Edit Item";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(167, 6);
            // 
            // menuDeleteItem
            // 
            menuDeleteItem.Name = "menuDeleteItem";
            menuDeleteItem.Size = new Size(170, 26);
            menuDeleteItem.Text = "Delete Item";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(167, 6);
            // 
            // menuUpdate
            // 
            menuUpdate.Name = "menuUpdate";
            menuUpdate.Size = new Size(170, 26);
            menuUpdate.Text = "Update";
            menuUpdate.Click += listItemsToolStripMenuItem_Click;
            // 
            // menuAbout
            // 
            menuAbout.DropDownItems.AddRange(new ToolStripItem[] { menuHelp, toolStripSeparator4, menuMoreInformation });
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(64, 24);
            menuAbout.Text = "About";
            // 
            // menuHelp
            // 
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(209, 26);
            menuHelp.Text = "Help";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(206, 6);
            // 
            // menuMoreInformation
            // 
            menuMoreInformation.Name = "menuMoreInformation";
            menuMoreInformation.Size = new Size(209, 26);
            menuMoreInformation.Text = "More Information";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(dataGridView);
            toolStripContainer1.ContentPanel.Size = new Size(800, 365);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 28);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 422);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            toolStripContainer1.TopToolStripPanel.Click += toolStripContainer1_TopToolStripPanel_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTime, lblItemCount, lblLastOperationInfo });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 30);
            statusStrip1.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblTime.BorderStyle = Border3DStyle.Sunken;
            lblTime.ForeColor = Color.Gray;
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(46, 24);
            lblTime.Text = "Time";
            // 
            // lblItemCount
            // 
            lblItemCount.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblItemCount.BorderStyle = Border3DStyle.Sunken;
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(86, 24);
            lblItemCount.Text = "Item Count";
            // 
            // lblLastOperationInfo
            // 
            lblLastOperationInfo.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblLastOperationInfo.BorderStyle = Border3DStyle.Sunken;
            lblLastOperationInfo.Name = "lblLastOperationInfo";
            lblLastOperationInfo.Size = new Size(110, 24);
            lblLastOperationInfo.Text = "Last Operation";
            lblLastOperationInfo.Click += lblLastOperationInfo_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(800, 365);
            dataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddFile, btnEditFile, btnNewFile, btnSaveFile, toolStripSeparator, btnCut, btnCopy, btnPaste, toolStripSeparator5 });
            toolStrip1.Location = new Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(267, 27);
            toolStrip1.TabIndex = 0;
            // 
            // btnAddFile
            // 
            btnAddFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddFile.Image = Properties.Resources.add_file_icon;
            btnAddFile.ImageTransparentColor = Color.Magenta;
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(29, 24);
            btnAddFile.Text = "&New";
            // 
            // btnEditFile
            // 
            btnEditFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditFile.Image = Properties.Resources.edit_file_icon;
            btnEditFile.ImageTransparentColor = Color.Magenta;
            btnEditFile.Name = "btnEditFile";
            btnEditFile.Size = new Size(29, 24);
            btnEditFile.Text = "&New";
            // 
            // btnNewFile
            // 
            btnNewFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNewFile.Image = Properties.Resources.delete_file_icon;
            btnNewFile.ImageTransparentColor = Color.Magenta;
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new Size(29, 24);
            btnNewFile.Text = "&New";
            // 
            // btnSaveFile
            // 
            btnSaveFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveFile.Image = (Image)resources.GetObject("btnSaveFile.Image");
            btnSaveFile.ImageTransparentColor = Color.Magenta;
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(29, 24);
            btnSaveFile.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // btnCut
            // 
            btnCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCut.Image = (Image)resources.GetObject("btnCut.Image");
            btnCut.ImageTransparentColor = Color.Magenta;
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(29, 24);
            btnCut.Text = "C&ut";
            // 
            // btnCopy
            // 
            btnCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopy.Image = (Image)resources.GetObject("btnCopy.Image");
            btnCopy.ImageTransparentColor = Color.Magenta;
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(29, 24);
            btnCopy.Text = "&Copy";
            // 
            // btnPaste
            // 
            btnPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPaste.Image = (Image)resources.GetObject("btnPaste.Image");
            btnPaste.ImageTransparentColor = Color.Magenta;
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(29, 24);
            btnPaste.Text = "&Paste";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Phone Book Application";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuFile;
        private ToolStripContainer toolStripContainer1;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem menuEdit;
        private ToolStripMenuItem menuCut;
        private ToolStripMenuItem menuCopy;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuOperation;
        private ToolStripMenuItem menuAbout;
        private ToolStripMenuItem menuPaste;
        private ToolStripMenuItem menuNewItem;
        private ToolStripMenuItem menuEditItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuDeleteItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menuUpdate;
        private ToolStripMenuItem menuHelp;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem menuMoreInformation;
        private DataGridView dataGridView;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblItemCount;
        private ToolStripStatusLabel lblTime;
        private ToolStripStatusLabel lblLastOperationInfo;
        private ToolStripButton btnNewFile;
        private ToolStripButton btnSaveFile;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton btnCut;
        private ToolStripButton btnCopy;
        private ToolStripButton btnPaste;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnAddFile;
        private ToolStripButton btnEditFile;
    }
}
