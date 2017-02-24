using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryEdit : Form
    {
        public LibraryEdit(int rowId, string author, string title, string genre, string date, string info)
        {
            _rowId = rowId;
            _author = author;
            _title = title;
            _genre = genre;
            _date = date;
            _info = info;
            Load += LibraryEdit_Load;
            InitializeComponent();
        }

        #region FIELDS

        private readonly int _rowId;
        private readonly string _author;
        private readonly string _title;
        private readonly string _genre;
        private readonly string _date;
        private readonly string _info;
        private byte[] _pic;

        private readonly SqlQueries _sqlQueries = new SqlQueries();
        private readonly LibraryForm _libraryForm = new LibraryForm();
        private readonly LibraryInfra _libraryInfra = new LibraryInfra();

        #endregion

        #region CONTROLS

        private void LibraryEdit_Load(object sender, EventArgs e)
        {
            txtEditAuthor.Text = _author;
            txtEditTitle.Text = _title;
            cmbEditGenre.Items.Insert(0, _genre);
            cmbEditGenre.SelectedIndex = 0;
            dateTimeEdit.Text = _date;
            txtEditInfo.Text = _info;

            // display image in the picture box if it is present in db
            _pic = _sqlQueries.ReadBlobCell(pbxPicEdit, _rowId.ToString());

            // display default image in the picture box if no picture is present in db
            if (_pic == null)
            {
                pbxPicEdit.Image = pbxPicEdit.InitialImage;
            }
            else
            {
                pbxPicEdit.BackgroundImage = null;
            }
        }

        private void CmbGenre_Click(object sender, EventArgs e)
        {
            cmbEditGenre.Items.Clear();
            cmbEditGenre.Items.AddRange(_libraryForm.GenresArray());
        }

        private void pbxPicEdit_Click(object sender, EventArgs e)
        {
            _libraryInfra.OpenImage(pbxPicEdit);
        }

        private void btnSaveChangesEdit_Click(object sender, EventArgs e)
        {
            var b = (txtEditAuthor.Text == string.Empty) || (txtEditTitle.Text == string.Empty) ||
                    (cmbEditGenre.Text == string.Empty);
            if (b)
            {
                MessageBox.Show(@"Please fill in all cells.");
                return;
            }
            if (txtEditAuthor.Text.StartsWith(" ") || txtEditTitle.Text.StartsWith(" "))
            {
                MessageBox.Show(@"One or a few fields have space at the beginning. The changes won't be saved!");
                return;
            }

            var image = _libraryInfra.ReadImageFromPictureBox(pbxPicEdit);

            if (image == null)
            {
                var data = _sqlQueries.ReadBlobCell(pbxPicEdit, _rowId.ToString());
                image = data;
            }

            _sqlQueries.UpdateRows(_rowId, txtEditAuthor.Text, txtEditTitle.Text, cmbEditGenre.Text, dateTimeEdit.Text,
                txtEditInfo.Text, image);

            var openForms = Application.OpenForms.Cast<Form>().ToList();

            foreach (var f in openForms)
            {
                if (f.Name == "LibraryFormTable")
                    f.Close();
            }

            var libraryFormTable = new LibraryFormTable();
            libraryFormTable.PopulateDataTable(cmbEditGenre.Text);
        }

        #endregion

        #region BUTTON EFFECTS

        private void BtnSaveChanges_MouseHover(object sender, EventArgs e)
        {
            btnSaveChangesEdit.BackgroundImage = Properties.Resources.AddBook1;
        }

        private void BtnSaveChanges_MouseLeave(object sender, EventArgs e)
        {
            btnSaveChangesEdit.BackgroundImage = Properties.Resources.AddBook0;
        }

        private void BtnSaveChanges_MouseDown(object sender, MouseEventArgs e)
        {
            btnSaveChangesEdit.BackgroundImage = Properties.Resources.AddBook2;
        }

        #endregion
    }
}
