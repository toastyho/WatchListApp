using System.Data;
using WatchList.WatchListClasses;

namespace WatchList
{
    public partial class WatchList : Form
    {
        public WatchList()
        {
            InitializeComponent();
        }

        WatchlistClass c = new WatchlistClass(); // used to call WatchListClass functions
        public static string currentPlace = "watch"; // used to keep track of which 'place' is being visited after the second form closes
        DataTable dt; // datatable used to display on the dataGridView

        private void button5_Click(object sender, EventArgs e) // add new show button
        {
            // prompt the form where you can add a new show
            AddEntry f = new AddEntry();
            f.ShowDialog();

            // after 'add show' form is closed, update the data GridView
            dt = c.select(currentPlace);
            dgvWL.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e) // update button
        {
            c.update(c); // call update function
            dt = c.select(currentPlace);
            dgvWL.DataSource = dt;
        }

        private void WatchList_Load(object sender, EventArgs e) // page load (when the app first opens up)
        {
            dt = c.select(currentPlace);
            dgvWL.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e) // 'Curiosity Centre' button
        {
            currentPlace = "centre";
            
            // display all shows that I'm curious to watch
            dt = c.select(currentPlace);
            dgvWL.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e) // 'Palace of Patience' button
        {
            currentPlace = "palace";

            // display all shows that I'm waiting on a new season for or am unsure if it is continuing
            dt = c.select(currentPlace);
            dgvWL.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e) // 'Hall of Fame' button
        {
            currentPlace = "hall";

            // display all shows that I've finished watching (show is over)
            dt = c.select(currentPlace);
            dgvWL.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e) // 'WatchList' button
        {
            currentPlace = "watch";

            // display all shows that I've finished watching (show is over)
            dt = c.select(currentPlace);
            dgvWL.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e) // 'show all' button
        {
            currentPlace = "";

            // display all shows and all attributes (mostly for troubleshooting any errors in any of the data attributes
            // the constraint functions were not working
            dt = c.select(currentPlace);
            dgvWL.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchBox.Text;
            dt = c.search(keyword);
            dgvWL.DataSource = dt;
        }
    }
}