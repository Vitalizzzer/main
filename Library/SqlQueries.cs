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

        // create db file if it does not exist
        public void DbFileCreation()
        {
            if (!File.Exists(LibraryDb))
            {
                SQLiteConnection.CreateFile(LibraryDb);
            }
        }

        // create db table
        public void DbTableCreation()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    SQLiteCommand cmd = new SQLiteCommand(CreateTable, connection);

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

        // add a book into database
        public void AddBookToDb(string author, string title, string genre, string date, string info, byte[] pic)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    SQLiteCommand cmd = new SQLiteCommand(Insert, connection);
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

        // show all books
        public void ShowAll(DataGridView dataGridViewLibrary)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    connection.Open();
                    DataTable dataTableLibrary = new DataTable();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(SelectAll, connection);
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

        // populate data table with rows filtered by genre
        public void FilterDbByGenre(string genre, DataGridView dataGridViewLibrary)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    connection.Open();
                    DataTable dataTableLibrary = new DataTable();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(FilterGenre, connection);
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

        // update table with data enetered into cell
        public void UpdateRows(int id, string author, string title, string genre, string date, string info, byte[] pic)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    SQLiteCommand cmd = new SQLiteCommand(UpdateRow, connection);
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

        // delete selected rows from table
        public void DeleteRows(int id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    SQLiteCommand cmd = new SQLiteCommand(DeleteRow, connection);
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

        // export rows from database
        public DataRowCollection ExtractRowsFromDb()
        {
            DataRowCollection rows = null;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(SelectAll, connection);
                    DataSet dataSet = new DataSet();
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

        // export column names from database 
        public ArrayList ExtractColumnsNames()
        {
            ArrayList columnsArray = null;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(SelectAll, connection))
                    {
                        using (SQLiteDataReader dataReader = cmd.ExecuteReader())
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

        // read data from BLOB cell
        public byte[] ReadBlobCell(PictureBox pictureBox, string id)
        {
            byte[] data = null;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", LibraryDb)))
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(SelectBlobCell, connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    DBNull dbNull = DBNull.Value;

                    // execule only if image exists in database
                    if (!cmd.ExecuteScalar().Equals(dbNull))
                    {
                        data = (byte[]) cmd.ExecuteScalar();
                    }

                    // display image in picture box
                    if (data != null)
                    {
                        MemoryStream ms = new MemoryStream(data);
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
