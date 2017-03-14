using System;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryForm : Form
    {
        // constructor
        public LibraryForm()
        {
            InitializeComponent();
            string note = _libraryInfra.ReadNotes(NoteFile);
            txtNote.Text = note;
        }

        #region FIELDS

        private readonly SqlQueries _sqlQueries = new SqlQueries();
        private readonly LibraryInfra _libraryInfra = new LibraryInfra();
        private LibraryFormTable _libraryFormTable = new LibraryFormTable();
        private const string NoteFile = "Note.txt";
        private int _clickCounter;

        #endregion

        #region METHODS

        // define array of books genres
        public object[] GenresArray()
        {
            object[] genreArray =
            {
                lblDrama.Text, lblAdventures.Text, lblSciFi.Text, lblBiography.Text,
                lblChild.Text, lblReference.Text, lblEducational.Text, lblReligious.Text, 
                lblMilitary.Text,lblPoetry.Text
            };

            return genreArray;
        }

        // verify if author, title, genre and date fields are not empty and without spaces at the beginning 
        private bool FieldsVerification()
        {
            // empty field verification
            var b = (txtAuthor.Text == string.Empty) || (txtTitle.Text == string.Empty) ||
                    (cmbGenre.Text == string.Empty) ||
                    (dateTime.Text == string.Empty);
            if (b)
            {
                MessageBox.Show(@"Please fill in all fields!");
                return true;
            }

            // spaces in fields verification
            if (txtAuthor.Text.StartsWith(" ") || txtTitle.Text.StartsWith(" ") || dateTime.Text.StartsWith(" ") ||
                cmbGenre.Text.StartsWith(" "))
            {
                MessageBox.Show(@"One or a few fields have space at the beginning!");
                return true;
            }
            return false;
        }

        // implement functionality of "Open Table" check box
        private void OpenTableCheckBox()
        {
            // open datagridview genre table with an added book
            if (checkBoxOpenTable.Checked)
            {
                string item = cmbGenre.Text;
                switch (item)
                {
                    case "Drama":
                        lblDrama_Click(this, new EventArgs());
                        break;
                    case "Adventures":
                        lblAdventures_Click(this, new EventArgs());
                        break;
                    case "Biography /Historic":
                        lblBiography_Click(this, new EventArgs());
                        break;
                    case "Reference /Guides":
                        lblReference_Click(this, new EventArgs());
                        break;
                    case "Science Fiction":
                        lblSciFi_Click(this, new EventArgs());
                        break;
                    case "For Children":
                        lblChild_Click(this, new EventArgs());
                        break;
                    case "Educational":
                        lblEducational_Click(this, new EventArgs());
                        break;
                    case "Religious":
                        lblReligious_Click(this, new EventArgs());
                        break;
                    case "Military Literature":
                        lblMilitary_Click(this, new EventArgs());
                        break;
                    case "Poetry":
                        lblPoetry_Click(this, new EventArgs());
                        break;
                }
            }
            else
            {
                MessageBox.Show(@"Book is added");
            }
        }

        // read image from file system into bytes array
        private Byte[] ReadImageData()
        {
            byte[] picData = null;
            if (pbxPic.ImageLocation != null)
            {
                // read image from its location
                string picPath = pbxPic.ImageLocation;
                picData = File.ReadAllBytes(picPath);
            }
            return picData;
        }

        #endregion

        #region ADD BOOK

        private void lblAddBook_Click(object sender, EventArgs e)
        {
            if (FieldsVerification())
            {
                return;
            }

            var picData = ReadImageData();

            // add book to the library db
            _sqlQueries.AddBookToDb(txtAuthor.Text, txtTitle.Text, cmbGenre.Text, dateTime.Text, txtInfo.Text, picData);

            OpenTableCheckBox();

            // clear the text fields
            txtAuthor.ResetText();
            txtTitle.ResetText();
            cmbGenre.Items.Clear();
            dateTime.ResetText();
            txtInfo.ResetText();

            // clear picture box
            if (picData != null)
            {
                pbxPic.Image.Dispose();
                pbxPic.ImageLocation = null;
            }

            pbxPic.Image = Properties.Resources.no_choose_image;
        }

        #endregion

        #region GENERES

        public void lblDrama_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[0].ToString());
        }

        private void lblAdventures_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[1].ToString());
        }

        private void lblSciFi_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[2].ToString());
        }

        private void lblBiography_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[3].ToString());
        }

        private void lblChild_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[4].ToString());
        }

        private void lblReference_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[5].ToString());
        }

        private void lblEducational_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[6].ToString());
        }

        private void lblReligious_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[7].ToString());
        }

        private void lblMilitary_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[8].ToString());
        }

        private void lblPoetry_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable(GenresArray()[9].ToString());
        }
        

        #endregion

        private void cmbGenre_DropDown(object sender, MouseEventArgs e)
        {
            cmbGenre.Items.Clear();
            cmbGenre.Items.AddRange(GenresArray());
        }

        private void lblExport_Click(object sender, EventArgs e)
        {
            _libraryInfra.SaveToExcel(_sqlQueries.ExtractColumnsNames(), _sqlQueries.ExtractRowsFromDb());
        }

        private void lblShowAll_Click(object sender, EventArgs e)
        {
            _libraryFormTable = new LibraryFormTable();
            _libraryFormTable.PopulateDataTable("");
            _libraryFormTable.DataGridViewLibrary.Columns[3].Visible = true;
            _libraryFormTable.DataGridViewLibrary.Columns[3].ReadOnly = true;
        }

        public void pbxPic_Click(object sender, EventArgs e)
        {
            _libraryInfra.OpenImage(pbxPic);
        }

        private void lblWishList_Click(object sender, EventArgs e)
        {
            _clickCounter++;
            if (_clickCounter%2 == 0)
            {
                txtNote.Hide();
            }
            else
            {
                txtNote.Show();
            }
        }

        private void CheckBoxOpenTable_MouseHover(object sender, EventArgs e)
        {
            toolTipOpenTable.SetToolTip(checkBoxOpenTable, "Open a table with added book");
        }

        #region NOTE

        private void txtNote_WriteToFile(object sender, EventArgs e)
        {
            _libraryInfra.WriteNotes(txtNote.Text, NoteFile);
        }

        #endregion

        #region GREEN BUTTONS EFFECTS

        private void LblAddBook_MouseHover(object sender, EventArgs e)
        {
            lblAddBook.Image = Properties.Resources.AddBook1;
        }

        private void LblAddBook_MouseLeave(object sender, EventArgs e)
        {
            lblAddBook.Image = Properties.Resources.AddBook0;
        }

        private void LblAddBook_MouseDown(object sender, MouseEventArgs e)
        {
            lblAddBook.Image = Properties.Resources.AddBook2;
        }

        private void LblShowAll_MouseHover(object sender, EventArgs e)
        {
            lblShowAll.Image = Properties.Resources.ShowAllHover;
        }

        private void LblShowAll_MouseLeave(object sender, EventArgs e)
        {
            lblShowAll.Image = Properties.Resources.ShowAllOrig;
        }

        private void LblShowAll_MouseDown(object sender, MouseEventArgs e)
        {
            lblShowAll.Image = Properties.Resources.ShowAllPress;
        }

        private void LblWishList_MouseHover(object sender, EventArgs e)
        {
            lblWishList.Image = Properties.Resources.ShowAllHover;
        }

        private void LblWishList_MouseLeave(object sender, EventArgs e)
        {
            lblWishList.Image = Properties.Resources.ShowAllOrig;
        }

        private void LblWishList_MouseDown(object sender, MouseEventArgs e)
        {
            lblWishList.Image = Properties.Resources.ShowAllPress;
        }

        private void LblExport_MouseHover(object sender, EventArgs e)
        {
            lblExport.Image = Properties.Resources.ExportAllBooksHover;
        }

        private void LblExport_MouseLeave(object sender, EventArgs e)
        {
            lblExport.Image = Properties.Resources.ExportAllBooksOrig;
        }

        private void LblExport_MouseDown(object sender, MouseEventArgs e)
        {
            lblExport.Image = Properties.Resources.ExportAllBooksPress;
        }

        #endregion

        #region GENRES BUTTONS EFFECTS

        private void LblDrama_MouseHover(object sender, EventArgs e)
        {
            lblDrama.Image = Properties.Resources.Book1_0;
        }

        private void LblDrama_MouseLeave(object sender, EventArgs e)
        {
            lblDrama.Image = Properties.Resources.Book1_1;
        }

        private void LblDrama_MouseDown(object sender, MouseEventArgs e)
        {
            lblDrama.Image = Properties.Resources.Book1_2;
        }

        private void LblAdventures_MouseHover(object sender, EventArgs e)
        {
            lblAdventures.Image = Properties.Resources.Book6_0;
        }

        private void LblAdventures_MouseLeave(object sender, EventArgs e)
        {
            lblAdventures.Image = Properties.Resources.Book6_1;
        }

        private void LblAdventures_MouseDown(object sender, MouseEventArgs e)
        {
            lblAdventures.Image = Properties.Resources.Book6_2;
        }

        private void LblBiography_MouseHover(object sender, EventArgs e)
        {
            lblBiography.Image = Properties.Resources.Book3_0;
        }

        private void LblBiography_MouseLeave(object sender, EventArgs e)
        {
            lblBiography.Image = Properties.Resources.Book3_1;
        }

        private void LblBiography_MouseDown(object sender, MouseEventArgs e)
        {
            lblBiography.Image = Properties.Resources.Book3_2;
        }

        private void LblReference_MouseHover(object sender, EventArgs e)
        {
            lblReference.Image = Properties.Resources.Book5_0;
        }

        private void LblReference_MouseLeave(object sender, EventArgs e)
        {
            lblReference.Image = Properties.Resources.Book5_1;
        }

        private void LblReference_MouseDown(object sender, MouseEventArgs e)
        {
            lblReference.Image = Properties.Resources.Book5_2;
        }

        private void LblSciFi_MouseHover(object sender, EventArgs e)
        {
            lblSciFi.Image = Properties.Resources.Book4_0;
        }

        private void LblSciFi_MouseLeave(object sender, EventArgs e)
        {
            lblSciFi.Image = Properties.Resources.Book4_1;
        }

        private void LblSciFi_MouseDown(object sender, MouseEventArgs e)
        {
            lblSciFi.Image = Properties.Resources.Book4_2;
        }

        private void LblChild_MouseHover(object sender, EventArgs e)
        {
            lblChild.Image = Properties.Resources.Book0_0;
        }

        private void LblChild_MouseLeave(object sender, EventArgs e)
        {
            lblChild.Image = Properties.Resources.Book0_1;
        }

        private void LblChild_MouseDown(object sender, MouseEventArgs e)
        {
            lblChild.Image = Properties.Resources.Book0_2;
        }

        private void LblEducational_MouseHover(object sender, EventArgs e)
        {
           lblEducational.Image = Properties.Resources.Book2_0;
        }

        private void LblEducational_MouseLeave(object sender, EventArgs e)
        {
            lblEducational.Image = Properties.Resources.Book2_1;
        }

        private void LblEducational_MouseDown(object sender, MouseEventArgs e)
        {
            lblEducational.Image = Properties.Resources.Book2_2;
        }

        private void LblReligious_MouseHover(object sender, EventArgs e)
        {
            lblReligious.Image = Properties.Resources.Book7_0;
        }

        private void LblReligious_MouseLeave(object sender, EventArgs e)
        {
            lblReligious.Image = Properties.Resources.Book7_1;
        }

        private void LblReligious_MouseDown(object sender, MouseEventArgs e)
        {
            lblReligious.Image = Properties.Resources.Book7_2;
        }

        private void LblMilitary_MouseHover(object sender, EventArgs e)
        {
            lblMilitary.Image = Properties.Resources.Book9_0;
        }

        private void LblMilitary_MouseLeave(object sender, EventArgs e)
        {
            lblMilitary.Image = Properties.Resources.Book9_1;
        }

        private void LblMilitary_MouseDown(object sender, MouseEventArgs e)
        {
            lblMilitary.Image = Properties.Resources.Book9_2;
        }

        private void LblPoetry_MouseHover(object sender, EventArgs e)
        {
            lblPoetry.Image = Properties.Resources.Book10_0;
        }

        private void LblPoetry_MouseLeave(object sender, EventArgs e)
        {
            lblPoetry.Image = Properties.Resources.Book10_1;
        }

        private void LblPoetry_MouseDown(object sender, MouseEventArgs e)
        {
            lblPoetry.Image = Properties.Resources.Book10_2;
        }

        #endregion
        
    }
}
