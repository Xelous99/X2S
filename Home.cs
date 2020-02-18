using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace X2S_IDE
{
    public partial class Home : Form
    {
        string baseUri = "C:\\X2S";
        public Home()
        {
            InitializeComponent();
            setupIde();
        }

            //Sets up the absolute base files needed for the IDE to run or be used. 
        public void setupIde() {
            DirectoryInfo dir = new DirectoryInfo(baseUri);
            //Checks to see if the needed base Directory exist and if not creates it. 
            if (!Directory.Exists("C:\\X2S"))
            {
                DirectoryInfo _dir = Directory.CreateDirectory(baseUri);
            }
        }

        /****** BUTTONS ******/

            //For opening existing projects/imported projects
        private void BTN_openProj_Click(object sender, EventArgs e)
        {

        }
            
            //For generating new projects
        private void BTN_newProj_Click(object sender, EventArgs e)
        {

        }

        /****** TEXT WINDOWS ******/

            //Where the user codes and creates scripts
        private void codeWindow_TextChanged(object sender, EventArgs e)
        {

        }

            //Where debugging lines and error code is put. 
        private void consoleWindow_TextChanged(object sender, EventArgs e)
        {

        }

        /****** BROWSERS/TREE VIEWS ******/

            //Where the user will alter and browse files related to the project
        private void fileBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
