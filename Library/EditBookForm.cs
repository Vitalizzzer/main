using System;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class EditBookForm : Form
    {
        public EditBookForm(int rowId, string author, string title, string genre, string date, string info)
        {
            this.rowId = rowId;
            this.author = author;
            this.title = title;
            this.genre = genre;
            this.date = date;
            this.info = info;
            InitializeComponent();
        }

        //public LibraryEdit()
        //{
        //    InitializeComponent();
        //}

        #region FIELDS

        private readonly int rowId;
        private readonly string author;
        private readonly string title;
        private readonly string genre;
        private readonly string date;
        private readonly string info;
        private byte[] pic;

        private readonly SqlQueries sqlQueries = new SqlQueries();
        //private readonly LibraryInfra libraryInfra = new LibraryInfra();

        #endregion

        #region CONTROLS

        private void LibraryEdit_Load(object sender, EventArgs e)
        {
            txtEditAuthor.Text = author;
            txtEditTitle.Text = title;
            cmbEditGenre.Items.Insert(0, genre);
            cmbEditGenre.SelectedIndex = 0;
            dateTimeEdit.Text = date;
            txtEditInfo.Text = info;

            // display image in the picture box if it is present in db
            pic = sqlQueries.ReadBlobCell(pbxPicEdit, rowId.ToString());

            // display default image in the picture box if no picture is present in db
            if (pic == null)
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
            cmbEditGenre.DataSource = Genres.GenresList();
        }

        private void pbxPicEdit_Click(object sender, EventArgs e)
        {
            sqlQueries.OpenImage(pbxPicEdit);
        }

        private void lblSaveChangesEdit_Click(object sender, EventArgs e)
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


            var image = sqlQueries.ReadImageFromPictureBox(pbxPicEdit);

            if (image == null)
            {
                var data = sqlQueries.ReadBlobCell(pbxPicEdit, rowId.ToString());
                image = data;
            }

            sqlQueries.UpdateRows(rowId, txtEditAuthor.Text, txtEditTitle.Text, cmbEditGenre.Text, dateTimeEdit.Text,
                txtEditInfo.Text, image);

            var openForms = Application.OpenForms.Cast<Form>().ToList();

            foreach (var f in openForms)
            {
                if (f.Name == "LibraryFormTable")
                    f.Close();
            }

            var libraryFormTable = new TableForm();
            libraryFormTable.PopulateDataTable(cmbEditGenre.Text);
            Close();
        }

        #endregion

        #region BUTTON EFFECTS

        private void LblSaveChanges_MouseHover(object sender, EventArgs e)
        {
            lblSaveChangesEdit.Image = Properties.Resources.AddBook1;
        }

        private void BtnSaveChanges_MouseLeave(object sender, EventArgs e)
        {
            lblSaveChangesEdit.Image = Properties.Resources.AddBook0;
        }

        private void BtnSaveChanges_MouseDown(object sender, MouseEventArgs e)
        {
            lblSaveChangesEdit.Image = Properties.Resources.AddBook2;
        }

        #endregion
    }
}
