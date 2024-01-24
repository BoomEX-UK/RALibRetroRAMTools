namespace RALibRetroRAMTools
{
    partial class frmManager
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
            pnlMainButtons = new Panel();
            button2 = new Button();
            button1 = new Button();
            pnlBrowser = new Panel();
            lstStates = new ListView();
            cFullPath = new ColumnHeader();
            cSectors = new ColumnHeader();
            cSize = new ColumnHeader();
            cFileName = new ColumnHeader();
            menuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addFileToolStripMenuItem = new ToolStripMenuItem();
            addFolderToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            clearListToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            selectionToolStripMenuItem = new ToolStripMenuItem();
            inspectSelectedToolStripMenuItem = new ToolStripMenuItem();
            sendToPointerSearcherToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            removeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            dialogAddFile = new OpenFileDialog();
            dialogAddFolder = new FolderBrowserDialog();
            pnlMainButtons.SuspendLayout();
            pnlBrowser.SuspendLayout();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainButtons
            // 
            pnlMainButtons.Controls.Add(button2);
            pnlMainButtons.Controls.Add(button1);
            pnlMainButtons.Dock = DockStyle.Bottom;
            pnlMainButtons.Location = new Point(0, 342);
            pnlMainButtons.Name = "pnlMainButtons";
            pnlMainButtons.Size = new Size(514, 47);
            pnlMainButtons.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(87, 6);
            button2.Name = "button2";
            button2.Size = new Size(93, 35);
            button2.TabIndex = 1;
            button2.Text = "Add Folder..";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAddFolder_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 0;
            button1.Text = "Add File..";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddFile_Click;
            // 
            // pnlBrowser
            // 
            pnlBrowser.Controls.Add(lstStates);
            pnlBrowser.Dock = DockStyle.Fill;
            pnlBrowser.Location = new Point(0, 24);
            pnlBrowser.Name = "pnlBrowser";
            pnlBrowser.Padding = new Padding(6, 0, 6, 0);
            pnlBrowser.Size = new Size(514, 318);
            pnlBrowser.TabIndex = 1;
            // 
            // lstStates
            // 
            lstStates.Columns.AddRange(new ColumnHeader[] { cFullPath, cSectors, cSize, cFileName });
            lstStates.Dock = DockStyle.Fill;
            lstStates.FullRowSelect = true;
            lstStates.Location = new Point(6, 0);
            lstStates.Name = "lstStates";
            lstStates.Size = new Size(502, 318);
            lstStates.TabIndex = 0;
            lstStates.UseCompatibleStateImageBehavior = false;
            lstStates.View = View.Details;
            // 
            // cFullPath
            // 
            cFullPath.DisplayIndex = 3;
            cFullPath.Text = "Full Path";
            cFullPath.Width = 400;
            // 
            // cSectors
            // 
            cSectors.Text = "Sectors";
            cSectors.Width = 50;
            // 
            // cSize
            // 
            cSize.Text = "Size";
            cSize.Width = 75;
            // 
            // cFileName
            // 
            cFileName.DisplayIndex = 0;
            cFileName.Text = "File Name";
            cFileName.Width = 200;
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, selectionToolStripMenuItem, aboutToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(514, 24);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addFileToolStripMenuItem, addFolderToolStripMenuItem, toolStripSeparator1, clearListToolStripMenuItem, toolStripSeparator2, toolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(43, 20);
            fileToolStripMenuItem.Text = "File..";
            // 
            // addFileToolStripMenuItem
            // 
            addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            addFileToolStripMenuItem.Size = new Size(138, 22);
            addFileToolStripMenuItem.Text = "Add File..";
            addFileToolStripMenuItem.Click += btnAddFile_Click;
            // 
            // addFolderToolStripMenuItem
            // 
            addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            addFolderToolStripMenuItem.Size = new Size(138, 22);
            addFolderToolStripMenuItem.Text = "Add Folder..";
            addFolderToolStripMenuItem.Click += btnAddFolder_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(135, 6);
            // 
            // clearListToolStripMenuItem
            // 
            clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            clearListToolStripMenuItem.Size = new Size(138, 22);
            clearListToolStripMenuItem.Text = "Clear List";
            clearListToolStripMenuItem.Click += clearListToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(135, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(138, 22);
            toolStripMenuItem1.Text = "Exit";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // selectionToolStripMenuItem
            // 
            selectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inspectSelectedToolStripMenuItem, sendToPointerSearcherToolStripMenuItem, toolStripSeparator3, removeToolStripMenuItem });
            selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            selectionToolStripMenuItem.Size = new Size(67, 20);
            selectionToolStripMenuItem.Text = "Selection";
            // 
            // inspectSelectedToolStripMenuItem
            // 
            inspectSelectedToolStripMenuItem.Name = "inspectSelectedToolStripMenuItem";
            inspectSelectedToolStripMenuItem.Size = new Size(180, 22);
            inspectSelectedToolStripMenuItem.Text = "Inspect";
            inspectSelectedToolStripMenuItem.Click += inspectSelectedToolStripMenuItem_Click;
            // 
            // sendToPointerSearcherToolStripMenuItem
            // 
            sendToPointerSearcherToolStripMenuItem.Name = "sendToPointerSearcherToolStripMenuItem";
            sendToPointerSearcherToolStripMenuItem.Size = new Size(180, 22);
            sendToPointerSearcherToolStripMenuItem.Text = "Pointer Search";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(180, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { githubToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new Size(110, 22);
            githubToolStripMenuItem.Text = "Github";
            githubToolStripMenuItem.Click += btnWebsite_Click;
            // 
            // dialogAddFile
            // 
            dialogAddFile.Filter = "states|*.state*|All files|*.*";
            dialogAddFile.Multiselect = true;
            // 
            // frmManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 389);
            Controls.Add(pnlBrowser);
            Controls.Add(menuMain);
            Controls.Add(pnlMainButtons);
            MainMenuStrip = menuMain;
            Name = "frmManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RAM Manager";
            pnlMainButtons.ResumeLayout(false);
            pnlBrowser.ResumeLayout(false);
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMainButtons;
        private Panel pnlBrowser;
        private MenuStrip menuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addFileToolStripMenuItem;
        private ToolStripMenuItem addFolderToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private Button button2;
        private Button button1;
        private OpenFileDialog dialogAddFile;
        private FolderBrowserDialog dialogAddFolder;
        private ListView lstStates;
        private ColumnHeader cFileName;
        private ColumnHeader cSectors;
        private ColumnHeader cSize;
        private ColumnHeader cFullPath;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem clearListToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem selectionToolStripMenuItem;
        private ToolStripMenuItem inspectSelectedToolStripMenuItem;
        private ToolStripMenuItem sendToPointerSearcherToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}