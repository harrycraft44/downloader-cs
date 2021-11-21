
namespace downloader2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.Label();
            this.URLB = new System.Windows.Forms.TextBox();
            this.ENDPATHB = new System.Windows.Forms.TextBox();
            this.ENDPATH = new System.Windows.Forms.Label();
            this.SHOWDBAR = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(10, 20);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(29, 13);
            this.URL.TabIndex = 2;
            this.URL.Text = "URL";
            // 
            // URLB
            // 
            this.URLB.Location = new System.Drawing.Point(45, 17);
            this.URLB.Name = "URLB";
            this.URLB.Size = new System.Drawing.Size(100, 20);
            this.URLB.TabIndex = 3;
            // 
            // ENDPATHB
            // 
            this.ENDPATHB.Location = new System.Drawing.Point(75, 43);
            this.ENDPATHB.Name = "ENDPATHB";
            this.ENDPATHB.Size = new System.Drawing.Size(100, 20);
            this.ENDPATHB.TabIndex = 5;
            // 
            // ENDPATH
            // 
            this.ENDPATH.AutoSize = true;
            this.ENDPATH.Location = new System.Drawing.Point(10, 46);
            this.ENDPATH.Name = "ENDPATH";
            this.ENDPATH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ENDPATH.Size = new System.Drawing.Size(59, 13);
            this.ENDPATH.TabIndex = 4;
            this.ENDPATH.Text = "ENDPATH";
            // 
            // SHOWDBAR
            // 
            this.SHOWDBAR.AutoSize = true;
            this.SHOWDBAR.Location = new System.Drawing.Point(13, 69);
            this.SHOWDBAR.Name = "SHOWDBAR";
            this.SHOWDBAR.Size = new System.Drawing.Size(118, 17);
            this.SHOWDBAR.TabIndex = 7;
            this.SHOWDBAR.Text = "show download bar";
            this.SHOWDBAR.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "extractzip",
            "extractall"});
            this.comboBox1.Location = new System.Drawing.Point(12, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "None";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 155);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SHOWDBAR);
            this.Controls.Add(this.ENDPATHB);
            this.Controls.Add(this.ENDPATH);
            this.Controls.Add(this.URLB);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "dl wizard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.TextBox URLB;
        private System.Windows.Forms.TextBox ENDPATHB;
        private System.Windows.Forms.Label ENDPATH;
        private System.Windows.Forms.CheckBox SHOWDBAR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}