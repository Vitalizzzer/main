using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryToolTip : Form
    {
        public LibraryToolTip(string rowId, string infoCellValue, int positionX, int positionY)
        {
            _rowId = rowId;
            _infoCellValue = infoCellValue;
            _positionX = positionX;
            _positionY = positionY;
            InitializeComponent();
        }

        #region FIELDS

        private readonly int _positionX;
        private readonly int _positionY;

        private readonly string _rowId;
        private readonly string _infoCellValue;

        private readonly SqlQueries _sqlQueries = new SqlQueries();

        #endregion

        private void LibraryToolTip_Load(object sender, EventArgs e)
        {
            // define form position within the screen
            var workingRectangle = Screen.PrimaryScreen.WorkingArea;
            
            if (_positionX + Width >= workingRectangle.Right)
            {
                if (_positionY + Height >= workingRectangle.Bottom)
                {
                    SetDesktopLocation(_positionX - Width, _positionY - Height);
                }
                else
                {
                    SetDesktopLocation(_positionX - Width, _positionY);
                }
            }

            else if (_positionY + Height >= workingRectangle.Bottom)
            {
                SetDesktopLocation(_positionX, _positionY - Height);
            }
            else
            {
                SetDesktopLocation(_positionX, _positionY);
            }

            // display image in the picture box if it is present in db
            var data = _sqlQueries.ReadBlobCell(pictureBox, _rowId);

            // display default image in the picture box if no picture is present in db
            if (data == null)
            {
                pictureBox.Image = pictureBox.InitialImage;
            }

            // display default text in text box if no info is present in db
            if (_infoCellValue == string.Empty)
            {
                lblInfo.Text = @"No information about this book";
                lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            }
            // display info if it is present in db
            else
            {
                lblInfo.Text = _infoCellValue;
            }
        }
    }
}
