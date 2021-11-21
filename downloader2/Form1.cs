 
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
using System.IO.Compression;
using SevenZipExtractor;

namespace downloader2
{
    [Flags]
    public enum ExtractOptions
    {
        None,
        /// <summary>
        /// overwrite target if it exists
        /// </summary>
        Overwrite,
        /// <summary>
        /// extract with internal directory structure
        /// </summary>
        ExtractFullPath,
    }
    public partial class Form1 : Form
    {   
    public static String df = "Output.txt"; // Modifiable
    public static String of = "Output.txt"; // Modifiable
    public static bool etz = false; // Modifiable
    public static bool rtz = false; // Modifiable
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
                        System.IO.Directory.CreateDirectory(endp);
                    }
                    else if (line.StartsWith("SHOWDBAR="))
                    {
                        if (line.Replace("SHOWDBAR=", "") == "True")
                        {
                            progressBar1.Hide();
                        }
                    }
                    else if (line == "extractall")
                    {
                        rtz = true;

                    }
                    else if (line == "extractzip")
                    {
                        etz = true;
                        
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
            of = ul;
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
            if (etz) {
                System.IO.Directory.CreateDirectory(of + "/extract/");

                ZipFile.ExtractToDirectory(df, of + "/extract/");


            } else if (rtz) {


                using (ArchiveFile archiveFile = new ArchiveFile(df))
                {
                    archiveFile.Extract(of + "/extract/"); // extract all
                }



            }
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
