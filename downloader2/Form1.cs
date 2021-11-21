 
using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace downloader2
{

    public partial class Form1 : Form
    {   
    public static String df = "Output.txt"; // Modifiable
    public static Form2 f = new Form2();
        public Form1(string file)
        {
            InitializeComponent();

            if (System.IO.File.Exists(file))
            {
                var url = "";
                var surl = "";
                var endp = "";
                var sdb = true;
                foreach (string line in System.IO.File.ReadLines(file))
                {
                    if (line.StartsWith("URL="))
                    {
                        url = line.Replace("URL=", "");

                    }
                    else if (line.StartsWith("ENDPATH="))
                    {
                        endp = line.Replace("ENDPATH=", "");
                    }
                    else if (line.StartsWith("SHOWDBAR="))
                    {
                        sdb = line.Replace("SHOWDBAR=", "") == "true";

                    }
                    else if (line == "start")
                    {

                        downloadFile(url, endp);
                    }
                }
            }
            else {
                progressBar1.Hide();
                pictureBox1.Hide();
            
            }
            
        }

        private void downloadFile(string ur2l, string ul)
        {
            string desktopPath = ul;
            // This will download a large image from the web, you can change the value
            // i.e a textbox : textBox1.Text
            string urll = ur2l;
            string filename = Path.GetFileName(urll);

            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                wc.DownloadFileAsync(new Uri(urll), desktopPath + "/" + filename);
                df = desktopPath + "/" + filename;
            }
        }
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // In case you don't have a progressBar Log the value instead 
            // Console.WriteLine(e.ProgressPercentage);
            progressBar1.Value = e.ProgressPercentage;
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Value = 0;

            if (e.Cancelled)
            {
                MessageBox.Show("The download has been cancelled");
                return;
            }

            if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                MessageBox.Show("An error ocurred while trying to download file");

                return;
            }
            
            MessageBox.Show("File succesfully downloaded");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void geckoWebBrowser1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
        }
    }
}
