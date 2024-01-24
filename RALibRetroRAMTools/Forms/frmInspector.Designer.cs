namespace RALibRetroRAMTools.Forms
{
    partial class frmInspector
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
            panel1 = new Panel();
            txtFilepath = new TextBox();
            panel2 = new Panel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFilepath);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(322, 32);
            panel1.TabIndex = 0;
            // 
            // txtFilepath
            // 
            txtFilepath.Dock = DockStyle.Top;
            txtFilepath.Location = new Point(4, 4);
            txtFilepath.Name = "txtFilepath";
            txtFilepath.ReadOnly = true;
            txtFilepath.Size = new Size(314, 23);
            txtFilepath.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listView1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 32);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(322, 192);
            panel2.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Dock = DockStyle.Bottom;
            listView1.Location = new Point(4, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(314, 166);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Size";
            columnHeader2.Width = 75;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(314, 15);
            label1.TabIndex = 1;
            label1.Text = "Sectors";
            // 
            // frmInspector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 388);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmInspector";
            Text = "State Inspector";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtFilepath;
        private Panel panel2;
        private ListView listView1;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}