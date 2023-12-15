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
            listBox1 = new ListBox();
            menuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addFileToolStripMenuItem = new ToolStripMenuItem();
            addFolderToolStripMenuItem = new ToolStripMenuItem();
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
            pnlBrowser.Controls.Add(listBox1);
            pnlBrowser.Dock = DockStyle.Fill;
            pnlBrowser.Location = new Point(0, 24);
            pnlBrowser.Name = "pnlBrowser";
            pnlBrowser.Padding = new Padding(6, 0, 6, 0);
            pnlBrowser.Size = new Size(514, 318);
            pnlBrowser.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.IntegralHeight = false;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(502, 318);
            listBox1.TabIndex = 1;
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(514, 24);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addFileToolStripMenuItem, addFolderToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(43, 20);
            fileToolStripMenuItem.Text = "File..";
            // 
            // addFileToolStripMenuItem
            // 
            addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            addFileToolStripMenuItem.Size = new Size(180, 22);
            addFileToolStripMenuItem.Text = "Add File..";
            addFileToolStripMenuItem.Click += btnAddFile_Click;
            // 
            // addFolderToolStripMenuItem
            // 
            addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            addFolderToolStripMenuItem.Size = new Size(180, 22);
            addFolderToolStripMenuItem.Text = "Add Folder..";
            addFolderToolStripMenuItem.Click += btnAddFolder_Click;
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
            dialogAddFile.FileName = "*.state*";
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
        private ListBox listBox1;
        private OpenFileDialog dialogAddFile;
        private FolderBrowserDialog dialogAddFolder;
    }
}