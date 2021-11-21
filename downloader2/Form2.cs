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

namespace downloader2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3, "the drive must exist on the clients pc");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            ENDPATHB.Text = folderBrowserDialog1.SelectedPath;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "downloader file (*.dl)|*.dl|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false)) //// true to append data to the file
                {
                    writer.WriteLine("URL=" + URLB.Text);
                    writer.WriteLine("ENDPATH=" + ENDPATHB.Text);
                    writer.WriteLine("SHOWDBAR=" + SHOWDBAR.Checked.ToString());
                    writer.WriteLine(comboBox1.Text.Replace("None",""));
                    writer.WriteLine("start");
                }
            }
            else {
                MessageBox.Show("error save path empty", "error", MessageBoxButtons.OK);
            }
        }
    }
}
