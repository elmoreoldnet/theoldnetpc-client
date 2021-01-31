
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Navigator = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lol = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.Navigator.SuspendLayout();
            this.lol.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "Oldnet home";
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.Navigator);
            this.tabControl1.Controls.Add(this.lol);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(69, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // Navigator
            // 
            this.Navigator.Controls.Add(this.webBrowser1);
            this.Navigator.Controls.Add(this.label1);
            this.Navigator.Location = new System.Drawing.Point(4, 22);
            this.Navigator.Name = "Navigator";
            this.Navigator.Padding = new System.Windows.Forms.Padding(3);
            this.Navigator.Size = new System.Drawing.Size(957, 587);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "Oldnet Navigator";
            this.Navigator.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Need help? contact me at htosh@gorupmail.com";
            // 
            // lol
            // 
            this.lol.CausesValidation = false;
            this.lol.Controls.Add(this.webBrowser2);
            this.lol.Location = new System.Drawing.Point(4, 22);
            this.lol.Name = "lol";
            this.lol.Padding = new System.Windows.Forms.Padding(3);
            this.lol.Size = new System.Drawing.Size(957, 587);
            this.lol.TabIndex = 1;
            this.lol.Text = "theoldnet.com";
            this.lol.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(951, 581);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("https://theoldnet.com/", System.UriKind.Absolute);
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(957, 587);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Newgrounds.com ";
            // 
            // webBrowser4
            // 
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4.Location = new System.Drawing.Point(0, 0);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(957, 587);
            this.webBrowser4.TabIndex = 0;
            this.webBrowser4.Url = new System.Uri("https://theoldnet.com/navbar?url=http%3A%2F%2Fnewgrounds.com&year=2002&decode=tru" +
        "e&scripts=true", System.UriKind.Absolute);
            this.webBrowser4.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser4_DocumentCompleted);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(957, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Steampowered.com";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser5
            // 
            this.webBrowser5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser5.Location = new System.Drawing.Point(0, 0);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.Size = new System.Drawing.Size(957, 587);
            this.webBrowser5.TabIndex = 0;
            this.webBrowser5.Url = new System.Uri("https://theoldnet.com/navbar?url=http%3A%2F%2Fsteampowered.com&year=2005&decode=t" +
        "rue&scripts=true", System.UriKind.Absolute);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(951, 581);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("https://theoldnet.com/navbar?url=http%3A%2F%2Fyahoo.com&year=2003&decode=true&scr" +
        "ipts=true", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1133, 637);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "TheoldnetPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            this.lol.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Navigator;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TabPage lol;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser5;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

