using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace h5dataToGIF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindRawData_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select raw radar image data file";
            fd.Filter = "Txt Files (*.txt)|*.txt";
            
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbRawLocation.Text = fd.FileName;
            }
        }

        private void btnFindPalette_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select img palette file";
            fd.Filter = "Txt Files (*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbPaletteLocation.Text = fd.FileName;
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (radioButton1.Checked)
            {
                sfd.Filter = "Jpg File (*.jpg)|*.jpg";
            }
            else
            {
                sfd.Filter = "Gif File (*.gif)|*.gif";
            }
            
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                RawConverter rc = new RawConverter(700, 765);
                rc.SaveFile = sfd.FileName;
                rc.PaletteLocation = tbPaletteLocation.Text;
                rc.RawDataLocation = tbRawLocation.Text;
                rc.ConvertData();
            }
        }
    }
}
