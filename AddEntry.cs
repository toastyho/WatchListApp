using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchList.WatchListClasses;

namespace WatchList
{
    public partial class AddEntry : Form
    {
        public AddEntry()
        {
            InitializeComponent();
        }

        WatchlistClass c = new WatchlistClass();

        private void button1_Click(object sender, EventArgs e)
        {
            // get values from the input fields (title and genres)
            c.showTitle = showTitleTxt.Text.Trim();
            c.mainGenre = mainGenreTxt.Text.Trim();
            c.subGenre = subGenreTxt.Text.Trim();
            c.season = 1;
            c.episode = 1;
            c.status = statusTxt.Text;

            // inserting data into the database
            bool inserted = c.insert(c);
            if(inserted)
            {
                MessageBox.Show("New Show Added To WatctList");
            }
            else
            {
                MessageBox.Show("Failed To Add New Show To WatchList");
            }
            ClearText();
        }

        public void ClearText()
        {
            showTitleTxt.Text = "";
            mainGenreTxt.Text = "";
            subGenreTxt.Text = "";
            statusTxt.Text = "";
        }
    }
}
