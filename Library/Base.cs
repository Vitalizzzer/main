using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using MessageBox = System.Windows.Forms.MessageBox;


namespace Library
{
    public class Base
    {
        /// <summary>
        /// set data grid view rows numeration
        /// </summary>
        /// <param name="dataGridView">Data Grid View table</param>
        public void SetRowNumber(DataGridView dataGridView)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.Equals(null))
                    {
                        row.HeaderCell.Value = row.HeaderCell.Value = (row.Index + 1).ToString();
                    }
                }
                dataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// write text notes into file
        /// </summary>
        /// <param name="note">text entered into text field</param>
        /// <param name="noteFile">name of the file</param>
        public void WriteNotes(string note, string noteFile)
        {
            try
            {
                using (var fs = File.Open(noteFile, FileMode.Create))
                using (var sw = new StreamWriter(fs))
                {
                    sw.Write(note);
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// read text notes from file
        /// </summary>
        /// <param name="noteFile">name of the text file</param>
        /// <returns>text notes</returns>
        public string ReadNotes(string noteFile)
        {
            string text = "";
            if (!File.Exists(noteFile))
            {
                try
                {
                    using (File.Create(noteFile))
                    {
                    }
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

            try
            {
                using (var reader = new StreamReader(noteFile))
                {
                    text = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return text;
        }

        /// <summary>
        /// open an image from file system into a picture box
        /// </summary>
        /// <param name="picBox">picture box in main form window</param>
        public void OpenImage(PictureBox picBox)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = @"Open picture",
                Filter =
                    @"JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|PNG (*.png)|*.png|Bitmap Image File (*.bmp)|*.bmp|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picBox.Image = new Bitmap(openFileDialog.OpenFile());
                    var fileName = openFileDialog.FileName;

                    picBox.ImageLocation = fileName;
                    picBox.BackgroundImage = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Unable to load file: " + ex.Message);
                }
            }
            else
            {
                picBox.ImageLocation = null;
                picBox.BackgroundImage = Properties.Resources.no_choose_image;
            }
            openFileDialog.Dispose();
        }

        /// <summary>
        /// read image file from picture box into byte[]
        /// </summary>
        /// <param name="picBox">picture box in main form window</param>
        /// <returns>encoded picture in bytes</returns>
        public byte[] ReadImageFromPictureBox(PictureBox picBox)
        {
            byte[] picture = null;

            if (picBox.ImageLocation == null) return null;
            try
            {
                var picPath = picBox.ImageLocation;
                picture = File.ReadAllBytes(picPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return picture;
        }

        /// <summary>
        /// write columns and rows into a file
        /// </summary>
        /// <param name="columns">library columns</param>
        /// <param name="rows">library rows</param>
        public void SaveToExcel(ArrayList columns, DataRowCollection rows)
        {
            var saveAsDialog = new SaveFileDialog()
            {
                Title = @"Save As",
                FileName = "Library.xlsx",
                OverwritePrompt = true,
                Filter = @"Excel Workbook (*.xlsx)|*.xlsx"
            };

            if (saveAsDialog.ShowDialog() == DialogResult.OK)
            {
                XLWorkbook workbook = new XLWorkbook();
                SqlQueries sql = new SqlQueries();
                var dataTable = sql.GetDataTable();
                try
                {
                    var ws = workbook.AddWorksheet(dataTable, "Library");
                    ws.Columns().AdjustToContents();
                    workbook.SaveAs(saveAsDialog.FileName);
                    workbook.Dispose();
                    saveAsDialog.Dispose();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
    }
}
