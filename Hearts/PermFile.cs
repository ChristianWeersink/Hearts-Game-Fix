using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearts
{
    public partial class PermFile : Form
    {

        public string filePathPerm { get; set; }

        public PermFile()
        {
            InitializeComponent();
        }

        private void PermFile_Load(object sender, EventArgs e)
        {
            if (filePathPerm != null && File.Exists(filePathPerm) )
            {
                rtbPerm.Text += File.ReadAllText(filePathPerm);
            }
            else
            {
                rtbPerm.Text = "No file found";
            }
        }
    }
}
