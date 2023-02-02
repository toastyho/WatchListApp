using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchList.WatchListClasses
{
    internal class WatchlistClass
    {
        // getter and setter functions for each attribute in WatchList database table
        public string showTitle { get; set; }
        public string mainGenre { get; set; }
        public string subGenre { get; set; }
        public int season { get; set; }
        public int episode { get; set; }
        public string status { get; set; }

        // string value for connection to WatchList database
        static string connectionString = ConfigurationManager.ConnectionStrings["connectString"].ConnectionString;

        // database connection
        SqlConnection con = new SqlConnection(connectionString);

        // database object to contain updated values
        DataTable dt;

        // SQL adapter and command builder object for filling/updating database
        public static string sql = "";
        SqlDataAdapter adapter;
        SqlCommandBuilder cmdbl;

        // function for selecting data from database
        public DataTable select(string place) 
        {
            dt = new DataTable();

            try
            {
                // formulate 'select' query 
                switch (place)
                {
                    case "watch":
                        sql = "SELECT Show_Title AS 'Show', Season, Episode, Status  FROM WatchListAppTable WHERE Status = 'Watching'";
                        break;
                    case "centre":
                        sql = "SELECT Show_Title AS 'Show', Main_Genre AS 'Main Genre', Sub_Genre AS 'Sub Genre', Status  FROM WatchListAppTable WHERE Status = 'Curious'";
                        break;
                    case "palace":
                        sql = "SELECT Show_Title AS 'Show', Season, Status  FROM WatchListAppTable WHERE Status = 'Waiting'";
                        break;
                    case "hall":
                        sql = "SELECT Show_Title AS 'Show', Main_Genre AS 'Main Genre', Sub_Genre AS 'Sub Genre'  FROM WatchListAppTable WHERE Status = 'Finished'";
                        break;
                    default:
                        sql = "SELECT * FROM WatchListAppTable";
                        break;
                }
                SqlCommand cmd = new SqlCommand(sql, con);

                // open bridge between dataset and sql server for retrieving/saving data
                adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);   
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        // function for inserting data into database
        public bool insert(WatchlistClass w)
        {
            // boolean value to indicate if inserting process was successful
            bool inserted = false;

            try
            {
                // formulate 'insert' query
                sql = "INSERT INTO WatchListAppTable (Show_Title, Main_Genre, Sub_Genre, Season, Episode, Status) VALUES (@Show_Title, @Main_Genre, @Sub_Genre, @Season, @Episode, @Status)";
                SqlCommand cmd = new SqlCommand(sql, con);

                // create parameters to add the data inputs
                cmd.Parameters.AddWithValue("@Show_Title", w.showTitle);
                cmd.Parameters.AddWithValue("@Main_Genre", w.mainGenre);
                cmd.Parameters.AddWithValue("@Sub_Genre", w.subGenre);
                cmd.Parameters.AddWithValue("@Season", w.season);
                cmd.Parameters.AddWithValue("@Episode", w.episode);
                cmd.Parameters.AddWithValue("@Status", w.status);

                // open sql server connection
                con.Open();

                // for some reason, could not 'condense' this segment of code :(
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0) { inserted = true; }
                else { inserted = false; }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return inserted;
        }

        // funtion to update database from the application
        public void update(WatchlistClass w) 
        {
            try
            { 
                // formulate 'update' query
                cmdbl = new SqlCommandBuilder(adapter);
                adapter.Update(dt);
                
                // open sql server connection
                con.Open();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable search(string text)
        {
            dt = new DataTable();

            try
            {
                // create query for seach functionality EVERY time the text changes
                sql = "SELECT * FROM WatchListAppTable WHERE Show_Title LIKE '%" + text + "%'";
                SqlCommand cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
