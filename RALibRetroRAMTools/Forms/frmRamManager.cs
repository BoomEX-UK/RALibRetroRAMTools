using System.Diagnostics;
using System.Windows.Forms;

namespace RALibRetroRAMTools
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
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
            if( dialogAddFile.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            dialogAddFolder.ShowDialog();
        }
    }
}