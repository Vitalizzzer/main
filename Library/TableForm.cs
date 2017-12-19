using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        #region FIELDS

        private readonly SqlQueries sqlQueries = new SqlQueries();
        private BookToolTipForm libraryToolTip;
        //private LibraryEdit _libraryEdit;
        private int rowId;
        private int currentMouseOverRow;

        #endregion

        #region PROPERTIES

        public DataTable DataTableLibrary { get; set; }

        public DataGridView DataGridViewLibrary
        {
            get { return dataGridViewLibrary; }
            set { dataGridViewLibrary = value; }
        }


        #endregion


        /// <summary>
        /// populate filtered data table
        /// </summary>
        /// <param name="genre">genre of the book</param>
 
        public void PopulateDataTable(string genre)
        {
            if (genre == "")
            {
                sqlQueries.ShowAll(DataGridViewLibrary);
                Text = @"All Books";
            }
            else
            {
                sqlQueries.FilterDbByGenre(genre, DataGridViewLibrary);
                Text = genre; 

            }

            DataGridViewLibrary.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            DataGridViewLibrary.Columns[0].Visible = false;
            DataGridViewLibrary.Columns[3].Visible = false;
            DataGridViewLibrary.Columns[5].Visible = false;
            DataGridViewLibrary.Columns[6].Visible = false;
            DataGridViewLibrary.Columns[4].ReadOnly = true;

            Show();
            sqlQueries.SetRowNumber(DataGridViewLibrary);
        }

        #region CONTROLS
        private void LibraryFormTable_Sorted(object sender, EventArgs e)
        {
            sqlQueries.SetRowNumber(DataGridViewLibrary);
        }

        private void Row_Delete(object sender, DataGridViewRowCancelEventArgs e)
        {
            var cellAuthorValue = DataGridViewLibrary[1, currentMouseOverRow].Value.ToString();
            var cellTitleValue = DataGridViewLibrary[2, currentMouseOverRow].Value.ToString();
            var message = string.Format("Do you want to delete {0} written by {1}?", cellTitleValue, cellAuthorValue);
            var result = MessageBox.Show(message, @"Press Yes to confirm deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            if (result != DialogResult.Yes) return;
            rowId = int.Parse(DataGridViewLibrary[0, currentMouseOverRow].Value.ToString());
            sqlQueries.DeleteRows(rowId);
            DataGridViewLibrary.Rows.Remove(DataGridViewLibrary.Rows[currentMouseOverRow]);
        }

        private void LibraryFormTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            sqlQueries.SetRowNumber(DataGridViewLibrary);
        }

        private void DataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CloseToolTip();
                rowId = int.Parse(DataGridViewLibrary[0, e.RowIndex].Value.ToString());
                var infoCellValue = DataGridViewLibrary[5, e.RowIndex].Value.ToString();
                libraryToolTip = new BookToolTipForm(rowId.ToString(), infoCellValue, Cursor.Position.X, Cursor.Position.Y);
                libraryToolTip.Show();
                DataGridViewLibrary.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
            }
            else
            {
                CloseToolTip();
            }
        }

        private void DataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            CloseToolTip();
            DataGridViewLibrary.Rows[e.RowIndex].DefaultCellStyle.BackColor = e.RowIndex%2 == 0 ? Color.Honeydew : Color.White;
        }

        private void DataGridView_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void DataGridView_MouseRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            currentMouseOverRow = DataGridViewLibrary.HitTest(e.X, e.Y).RowIndex;

            if (currentMouseOverRow < 0) return;
            contextMenuStrip.Show(DataGridViewLibrary, new Point(e.X, e.Y));

            DataGridViewLibrary.ClearSelection();
            DataGridViewLibrary.Rows[currentMouseOverRow].Selected = true;
        }

        private void EditMenu_click(object sender, EventArgs e)
        {
            rowId = int.Parse(DataGridViewLibrary[0, currentMouseOverRow].Value.ToString());
            string cellAuthorValue = DataGridViewLibrary[1, currentMouseOverRow].Value.ToString();
            string cellTitleValue = DataGridViewLibrary[2, currentMouseOverRow].Value.ToString();
            string cellGenreValue = DataGridViewLibrary[3, currentMouseOverRow].Value.ToString();
            string cellDateValue = DataGridViewLibrary[4, currentMouseOverRow].Value.ToString();
            string cellInfoValue = DataGridViewLibrary[5, currentMouseOverRow].Value.ToString();

            var libraryEdit = new EditBookForm(rowId, cellAuthorValue, cellTitleValue, cellGenreValue, cellDateValue,
                cellInfoValue);
            libraryEdit.Activate();
            libraryEdit.Show();
        }

        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            Row_Delete(this, new DataGridViewRowCancelEventArgs(DataGridViewLibrary.Rows[currentMouseOverRow]));
        }

        private void CloseToolTip()
        {
           if (libraryToolTip == null) return;
            libraryToolTip.Close();
            libraryToolTip.Dispose();
        }

        #endregion

    }
}
