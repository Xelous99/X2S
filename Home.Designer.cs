namespace X2S_IDE
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BTN_openProj = new System.Windows.Forms.Button();
            this.BTN_newProj = new System.Windows.Forms.Button();
            this.codeWindow = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.consoleWindow = new System.Windows.Forms.RichTextBox();
            this.fileBrowser = new System.Windows.Forms.TreeView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // BTN_openProj
            // 
            this.BTN_openProj.Location = new System.Drawing.Point(12, 12);
            this.BTN_openProj.Name = "BTN_openProj";
            this.BTN_openProj.Size = new System.Drawing.Size(89, 35);
            this.BTN_openProj.TabIndex = 0;
            this.BTN_openProj.Text = "Open";
            this.BTN_openProj.UseVisualStyleBackColor = true;
            this.BTN_openProj.Click += new System.EventHandler(this.BTN_openProj_Click);
            // 
            // BTN_newProj
            // 
            this.BTN_newProj.Location = new System.Drawing.Point(107, 12);
            this.BTN_newProj.Name = "BTN_newProj";
            this.BTN_newProj.Size = new System.Drawing.Size(94, 35);
            this.BTN_newProj.TabIndex = 1;
            this.BTN_newProj.Text = "New";
            this.BTN_newProj.UseVisualStyleBackColor = true;
            this.BTN_newProj.Click += new System.EventHandler(this.BTN_newProj_Click);
            // 
            // codeWindow
            // 
            this.codeWindow.Location = new System.Drawing.Point(12, 53);
            this.codeWindow.Name = "codeWindow";
            this.codeWindow.Size = new System.Drawing.Size(914, 395);
            this.codeWindow.TabIndex = 2;
            this.codeWindow.Text = "";
            this.codeWindow.TextChanged += new System.EventHandler(this.codeWindow_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 764);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // consoleWindow
            // 
            this.consoleWindow.Location = new System.Drawing.Point(12, 454);
            this.consoleWindow.Name = "consoleWindow";
            this.consoleWindow.Size = new System.Drawing.Size(914, 125);
            this.consoleWindow.TabIndex = 4;
            this.consoleWindow.Text = "";
            this.consoleWindow.TextChanged += new System.EventHandler(this.consoleWindow_TextChanged);
            // 
            // fileBrowser
            // 
            this.fileBrowser.Location = new System.Drawing.Point(958, 53);
            this.fileBrowser.Name = "fileBrowser";
            this.fileBrowser.Size = new System.Drawing.Size(234, 395);
            this.fileBrowser.TabIndex = 5;
            this.fileBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.fileBrowser_AfterSelect);
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "icon_Folder.png");
            this.iconList.Images.SetKeyName(1, "Icon_file.png");
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 635);
            this.Controls.Add(this.fileBrowser);
            this.Controls.Add(this.consoleWindow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.codeWindow);
            this.Controls.Add(this.BTN_newProj);
            this.Controls.Add(this.BTN_openProj);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_openProj;
        private System.Windows.Forms.Button BTN_newProj;
        private System.Windows.Forms.RichTextBox codeWindow;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox consoleWindow;
        private System.Windows.Forms.TreeView fileBrowser;
        private System.Windows.Forms.ImageList iconList;
    }
}