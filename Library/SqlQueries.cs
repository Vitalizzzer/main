using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    public class SqlQueries
    {
        #region FIELDS AND QUERIES

        private const string LibraryDb = "LibraryDB.db";

        private const string Insert =
            @"INSERT INTO tblBook (Author, Title, Genre, Date, Info, Pic) VALUES (@author, @title, @genre, @date, @info, @pic);";

        private const string CreateTable =
            @"CREATE TABLE IF NOT EXISTS tblBook (Id INTEGER PRIMARY KEY AUTOINCREMENT, Author TEXT ASC, Title TEXT, Genre TEXT, Date TEXT, Info TEXT, Pic BLOB);";

        private const string FilterGenre = @"SELECT * FROM tblBook WHERE Genre = @genre";

        private const string UpdateRow =
            @"UPDATE tblBook SET Author=@author, Title=@title, Genre=@genre, Date=@date, Info=@info, Pic=@pic WHERE Id=@id";

        private const string DeleteRow = @"DELETE FROM tblBook WHERE Id=@id";
        private const string SelectAll = @"SELECT * FROM tblBook";
        private const string SelectBlobCell = @"SELECT Pic FROM tblBook WHERE Id=@id";

        #endregion

        /// <summary>
        /// create SQLite database file if it does not exist
        /// </summary>
        public void DbFileCreation()
        {
            if (!File.Exists(LibraryDb))
            {
                SQLiteConnection.CreateFile(LibraryDb);
            }
        }

        /// <summary>
        /// create SQLite database table
        /// </summary>
 
        public void DbTableCreation()
        {
            try
            {
                using (var connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    var cmd = new SQLiteCommand(CreateTable, connection);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Data source doesn't exist or inaccessible. Please, set correct connection string.");
            }
        }

        /// <summary>
        /// add a book into database
        /// </summary>
        /// <param name="author">author of the book</param>
        /// <param name="title">title of the book</param>
        /// <param name="genre">genre of the book</param>
        /// <param name="date">date when the book was purchased</param>
        /// <param name="info">information about the book</param>
        /// <param name="pic">book's cover</param>
 
        public void AddBookToDb(string author, string title, string genre, string date, string info, byte[] pic)
        {
            try
            {
                using (var connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    var cmd = new SQLiteCommand(Insert, connection);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@info", info);
                    if (pic != null)
                    {
                        cmd.Parameters.Add("@pic", DbType.Binary, pic.Length);
                        cmd.Parameters["@pic"].Value = pic;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@pic", null);
                    }

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// show all books in data grid view table
        /// </summary>
        /// <param name="dataGridViewLibrary">data grid view table</param>
 
        public void ShowAll(DataGridView dataGridViewLibrary)
        {
            try
            {
                using (var connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    connection.Open();
                    var dataTableLibrary = new DataTable();
                    var dataAdapter = new SQLiteDataAdapter(SelectAll, connection);
                    dataAdapter.Fill(dataTableLibrary);
                    dataGridViewLibrary.DataSource = dataTableLibrary;
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Data source doesn't exist or inaccessible. Please, set correct connection string.");
            }
        }

        /// <summary>
        /// populate data table with rows filtered by genre
        /// </summary>
        /// <param name="genre">genre of the books</param>
        /// <param name="dataGridViewLibrary">data grid view table</param>
 
        public void FilterDbByGenre(string genre, DataGridView dataGridViewLibrary)
        {
            try
            {
                using (var connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    connection.Open();
                    var dataTableLibrary = new DataTable();
                    var dataAdapter = new SQLiteDataAdapter(FilterGenre, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@genre", genre);
                    dataAdapter.Fill(dataTableLibrary);
                    dataGridViewLibrary.DataSource = dataTableLibrary;
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Data source doesn't exist or inaccessible. Please, set correct connection string.");
            }
        }

        /// <summary>
        /// update table with data enetered into cell
        /// </summary>
        /// <param name="id">id of the row</param>
        /// <param name="author">author of the book</param>
        /// <param name="title">title of the book</param>
        /// <param name="genre">genre of the book</param>
        /// <param name="date">date when the book was purchased</param>
        /// <param name="info">information about the book</param>
        /// <param name="pic">book's cover</param>
 
        public void UpdateRows(int id, string author, string title, string genre, string date, string info, byte[] pic)
        {
            try
            {
                using (var connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    var cmd = new SQLiteCommand(UpdateRow, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@info", info);

                    if (pic != null)
                    {
                        cmd.Parameters.Add("@pic", DbType.Binary, pic.Length);
                        cmd.Parameters["@pic"].Value = pic;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@pic", null);
                    }

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Data source doesn't exist or inaccessible. Please, set correct connection string.");
            }
        }

        /// <summary>
        /// delete selected rows from table
        /// </summary>
        /// <param name="id">id of the row</param>
 
        public void DeleteRows(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    var cmd = new SQLiteCommand(DeleteRow, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Data source doesn't exist or inaccessible. Please, set correct connection string.");
            }
        }

        /// <summary>
        /// export rows from database
        /// </summary>
        /// <returns>collection of rows</returns>
 
        public DataRowCollection ExtractRowsFromDb()
        {
            DataRowCollection rows = null;

            try
            {
                using (var connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    var dataAdapter = new SQLiteDataAdapter(SelectAll, connection);
                    var dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    rows = dataSet.Tables[0].Rows;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return rows;
        }

        /// <summary>
        /// export column names from database
        /// </summary>
        /// <returns>array list of columns' names</returns>
  
        public ArrayList ExtractColumnsNames()
        {
            ArrayList columnsArray = null;
            try
            {
                using (var connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(SelectAll, connection))
                    {
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            columnsArray = new ArrayList
                            {
                                dataReader.GetName(1),
                                dataReader.GetName(2),
                                dataReader.GetName(3),
                                dataReader.GetName(4),
                                dataReader.GetName(5)
                            };
                            dataReader.Close();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception e)

            {
                MessageBox.Show(e.ToString());
            }
            return columnsArray;
        }

        /// <summary>
        /// read data from BLOB cell
        /// </summary>
        /// <param name="pictureBox">picture box in main form window</param>
        /// <param name="id">id of the row</param>
        /// <returns>encoded picture in bytes</returns>
 
        public byte[] ReadBlobCell(PictureBox pictureBox, string id)
        {
            byte[] data = null;
            try
            {
                using (var connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    connection.Open();
                    var cmd = new SQLiteCommand(SelectBlobCell, connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    var dbNull = DBNull.Value;

                    // execule only if image exists in database
                    if (!cmd.ExecuteScalar().Equals(dbNull))
                    {
                        data = (byte[]) cmd.ExecuteScalar();
                    }

                    // display image in picture box
                    if (data != null)
                    {
                        var ms = new MemoryStream(data);
                        pictureBox.Image = Image.FromStream(ms, true);
                    }

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return data;
        }
    }
}
