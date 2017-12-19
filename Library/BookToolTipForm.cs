using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class BookToolTipForm : Form
    {
        public BookToolTipForm(string rowId, string infoCellValue, int positionX, int positionY)
        {
            this.rowId = rowId;
            this.infoCellValue = infoCellValue;
            this.positionX = positionX;
            this.positionY = positionY;
            InitializeComponent();
        }

        #region FIELDS

        private readonly SqlQueries sqlQueries = new SqlQueries();
        private readonly int positionX;
        private readonly int positionY;

        private readonly string rowId;
        private readonly string infoCellValue;

        #endregion

        private void LibraryToolTip_Load(object sender, EventArgs e)
        {
            // define form position within the screen
            var workingRectangle = Screen.PrimaryScreen.WorkingArea;
            
            if (positionX + Width >= workingRectangle.Right)
            {
                if (positionY + Height >= workingRectangle.Bottom)
                {
                    SetDesktopLocation(positionX - Width, positionY - Height);
                }
                else
                {
                    SetDesktopLocation(positionX - Width, positionY);
                }
            }

            else if (positionY + Height >= workingRectangle.Bottom)
            {
                SetDesktopLocation(positionX, positionY - Height);
            }
            else
            {
                SetDesktopLocation(positionX, positionY);
            }

            // display image in the picture box if it is present in db
            var data = sqlQueries.ReadBlobCell(pictureBox, rowId);

            // display default image in the picture box if no picture is present in db
            if (data == null)
            {
                pictureBox.Image = pictureBox.InitialImage;
            }

            // display default text in text box if no info is present in db
            if (infoCellValue == string.Empty)
            {
                lblInfo.Text = @"No information about this book";
                lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            }
            // display info if it is present in db
            else
            {
                lblInfo.Text = infoCellValue;
            }
        }
    }
}
