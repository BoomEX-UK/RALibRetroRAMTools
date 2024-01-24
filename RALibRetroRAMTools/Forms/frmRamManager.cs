using RALibRetroRAMTools.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace RALibRetroRAMTools
{
    public partial class frmManager : Form
    {
        public List<RALibState> stateCollection = new List<RALibState>();
        public List<string> logger = new List<string>();
        public frmManager()
        {
            InitializeComponent();
            addToLog("Application Start");
        }

        public void addToLog(string text)
        {
            logger.Add("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] " + text);
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/BoomEX-UK/RALibRetroRAMTools",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (dialogAddFile.ShowDialog() == DialogResult.OK)
            {
                addToLog("Adding " + dialogAddFile.FileNames.Length.ToString() + " files");
                foreach (string fdpath in dialogAddFile.FileNames)
                {
                    Boolean skip = false;
                    foreach (RALibState state in stateCollection)
                    {
                        if (state.filepath == fdpath) skip = true;
                    }
                    if (!skip)
                    {
                        RALibState ras = new RALibState(fdpath);
                        if (ras.valid)
                        {
                            stateCollection.Add(ras);
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = fdpath;
                            lvi.SubItems.Add(ras.sectors.Count.ToString());
                            lvi.SubItems.Add(ras.filesizeText);
                            lvi.SubItems.Add(Path.GetFileName(fdpath));
                            lstStates.Items.Add(lvi);
                        }
                        else
                        {
                            addToLog(ras.valid_reason + " (" + fdpath + ")");
                        }
                    }
                    else
                    {
                        addToLog("Duplicate File: " + fdpath);
                    }
                }
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            dialogAddFolder.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "This will remove all states from the list. Continue?", "Clear File List",
                MessageBoxButtons.YesNo
            );
            if (confirmResult == DialogResult.Yes)
            {
                lstStates.Items.Clear();
                stateCollection.Clear();
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstStates.SelectedItems)
            {
                lstStates.Items.Remove(lvi);
                List<RALibState> list = new List<RALibState>();
                foreach (RALibState state in stateCollection)
                {
                    if (state.filepath == lvi.Text) list.Add(state);
                }
                foreach (RALibState state in list) stateCollection.Remove(state);
            }
        }

        private void inspectSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lstStates.SelectedItems)
            {
                frmInspector insp = new frmInspector();
                foreach(RALibState state in stateCollection)
                {
                    if (lvi.Text == state.filepath) insp.load(state);
                }
                
            }
        }
    }
}