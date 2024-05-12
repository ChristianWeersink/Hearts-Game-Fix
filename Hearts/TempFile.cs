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
    public partial class TempFile : Form
    {
        public string filePathTemp {  get; set; }

        public TempFile()
        {
            InitializeComponent();
        }

        private void TempFile_Load(object sender, EventArgs e)
        {
            if (filePathTemp != null && File.Exists(filePathTemp))
            {
                rtbTemp.Text += File.ReadAllText(filePathTemp);
            }
            else
            {
                rtbTemp.Text = "No file found";
            }
        }
    }
}
