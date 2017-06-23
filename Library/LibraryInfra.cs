using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;


namespace Library
{
    public class LibraryInfra
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
                    row.HeaderCell.Value = (row.Index + 1).ToString();
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
                using (FileStream fs = File.Open(noteFile, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
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
 
        public void SaveToFile(ArrayList columns, DataRowCollection rows)
        {
            var saveAsDialog = new SaveFileDialog()
            {
                Title = @"Save As",
                FileName = "Library.csv",
                OverwritePrompt = true,
                Filter = @"Comma-Separated Values (*.csv)|*.csv|Text Documents (*.txt)|*.txt|MS Word Document (*.docs)|*.doc"
            };

            if (saveAsDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (var streamWriter = new StreamWriter(saveAsDialog.FileName))
                {
                    foreach (var column in columns)
                    {
                        streamWriter.Write(column + ",");
                    }

                    streamWriter.WriteLine();

                    for (var i = 0; i < rows.Count; i++)
                    {
                        for (var j = 1; j <= columns.Count; j++)
                        {
                            if (rows[i][j] != null)
                            {
                                streamWriter.Write(Convert.ToString(rows[i][j]) + ",");
                            }
                            else
                            {
                                streamWriter.Write(",");
                            }
                        }
                        streamWriter.WriteLine();
                    }
                    streamWriter.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
