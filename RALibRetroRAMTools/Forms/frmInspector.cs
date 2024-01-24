using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RALibRetroRAMTools.Forms
{
    public partial class frmInspector : Form
    {
        public RALibState state;
        public frmInspector()
        {
            InitializeComponent();
        }

        public void load(RALibState tstate)
        {
            state = tstate;
            txtFilepath.Text = state.filepath;
            this.Show();
        }
    }
}
