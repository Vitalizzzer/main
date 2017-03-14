using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryFormTable : Form
    {
        public LibraryFormTable()
        {
            InitializeComponent();
        }

        #region FIELDS

        private DataTable _dataTable;
        private readonly LibraryInfra _libraryInfra = new LibraryInfra();
        private readonly SqlQueries _sqlQueries = new SqlQueries();
        private LibraryToolTip _libraryToolTip;
        private LibraryEdit _libraryEdit;
        private int _rowId;
        private int _currentMouseOverRow;

        #endregion

        #region PROPERTIES

        public DataTable DataTableLibrary
        {
            get { return _dataTable; }
            set { _dataTable = value; }
        }

        public DataGridView DataGridViewLibrary
        {
            get { return dataGridViewLibrary; }
            set { dataGridViewLibrary = value; }
        }

        #endregion


        // populate filtered data table
        public void PopulateDataTable(string genre)
        {
            if (genre == "")
            {
                _sqlQueries.ShowAll(DataGridViewLibrary);
                Text = @"All Books";
            }
            else
            {
                _sqlQueries.FilterDbByGenre(genre, DataGridViewLibrary);
                Text = genre; 
            }

            dataGridViewLibrary.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            
            dataGridViewLibrary.Columns[0].Visible = false;
            dataGridViewLibrary.Columns[3].Visible = false;
            dataGridViewLibrary.Columns[5].Visible = false;
            dataGridViewLibrary.Columns[6].Visible = false;
            DataGridViewLibrary.Columns[4].ReadOnly = true;

            Show();
            _libraryInfra.SetRowNumber(dataGridViewLibrary);
        }

        #region CONTROLS
        private void LibraryFormTable_Sorted(object sender, EventArgs e)
        {
            _libraryInfra.SetRowNumber(dataGridViewLibrary);
        }

        private void Row_Delete(object sender, DataGridViewRowCancelEventArgs e)
        {
            string cellAuthorValue = DataGridViewLibrary[1, _currentMouseOverRow].Value.ToString();
            string cellTitleValue = DataGridViewLibrary[2, _currentMouseOverRow].Value.ToString();
            string message = String.Format("Do you want to delete {0} written by {1}?", cellTitleValue, cellAuthorValue);
            var result = MessageBox.Show(message, @"Press Yes to confirm deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            if (result == DialogResult.Yes)
            {
                    _rowId = Int32.Parse(DataGridViewLibrary[0, _currentMouseOverRow].Value.ToString());
                   _sqlQueries.DeleteRows(_rowId);
                   DataGridViewLibrary.Rows.Remove(DataGridViewLibrary.Rows[_currentMouseOverRow]);
            }
        }

        private void LibraryFormTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            _libraryInfra.SetRowNumber(DataGridViewLibrary);
        }

        private void DataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (_libraryToolTip != null)
                {
                    _libraryToolTip.Close();
                }
                string rowId = DataGridViewLibrary[0, e.RowIndex].Value.ToString();
                string cellValue = DataGridViewLibrary[5, e.RowIndex].Value.ToString();
                _libraryToolTip = new LibraryToolTip(rowId, cellValue, Cursor.Position.X, Cursor.Position.Y);

                _libraryToolTip.Show();

                DataGridViewLibrary.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
            }
            else
            {
                _libraryToolTip.Close();
            }

        }

        public void DataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (_libraryToolTip != null)
                {
                    _libraryToolTip.Hide();
                    _libraryToolTip.Close();

                    if (e.RowIndex%2 == 0)
                    {
                        DataGridViewLibrary.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Honeydew;
                    }
                    else
                    {
                        DataGridViewLibrary.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void DataGridView_MouseRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _currentMouseOverRow = DataGridViewLibrary.HitTest(e.X, e.Y).RowIndex;

                if (_currentMouseOverRow >= 0)
                {
                    contextMenuStrip.Show(DataGridViewLibrary, new Point(e.X, e.Y));

                    dataGridViewLibrary.ClearSelection();
                    dataGridViewLibrary.Rows[_currentMouseOverRow].Selected = true;

                    int rowId = Int32.Parse(DataGridViewLibrary[0, _currentMouseOverRow].Value.ToString());
                    string cellAuthorValue = DataGridViewLibrary[1, _currentMouseOverRow].Value.ToString();
                    string cellTitleValue = DataGridViewLibrary[2, _currentMouseOverRow].Value.ToString();
                    string cellGenreValue = DataGridViewLibrary[3, _currentMouseOverRow].Value.ToString();
                    string cellDateValue = DataGridViewLibrary[4, _currentMouseOverRow].Value.ToString();
                    string cellInfoValue = DataGridViewLibrary[5, _currentMouseOverRow].Value.ToString();

                    _libraryEdit = new LibraryEdit(rowId, cellAuthorValue, cellTitleValue, cellGenreValue, cellDateValue,
                        cellInfoValue);
                }
            }
        }

        private void EditMenu_click(object sender, EventArgs e)
        {
            _libraryEdit.Show();
        }

        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            Row_Delete(this, new DataGridViewRowCancelEventArgs(DataGridViewLibrary.Rows[_currentMouseOverRow]));
        }

        private void DataGridView_MouseLeave(object sender, EventArgs e)
        {
            if (_libraryToolTip != null)
            {
                _libraryToolTip.Hide();
                _libraryToolTip.Close();
            }
        }

        #endregion

    }
}
