using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Global arrays to save song names

        string[] Songs, paths;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to select the songs 
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true; 

                if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Songs = ofd.SafeFileNames; // save name of track into Song array
                paths = ofd.FileNames; // save path of track in path Array
                // Display music titles in for loop  
                for (int i = 0; i < Songs.Length; i++)
                {
                    listboxSongs.Items.Add(Songs[i]); 
                }

            }

            
        }

        private void listboxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //from listbox to player

            WMPmusic.URL = paths[listboxSongs.SelectedIndex]; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
