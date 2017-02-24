using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Library
{
    public class LibraryInfra
    {
        // set data grid view rows numeration
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

        // write text into file
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

        // read text from file
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
                using (StreamReader reader = new StreamReader(noteFile))
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

        // open an image from file system into a picture box
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
            openFileDialog.Dispose();
        }

        // read image file from picture box into byte[]
        public byte[] ReadImageFromPictureBox(PictureBox picBox)
        {
            byte[] picture = null;

            if (picBox.ImageLocation != null)
            {
                try
                {
                    string picPath = picBox.ImageLocation;
                    picture = File.ReadAllBytes(picPath);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return picture;
        }

        // write columns and rows into excel
        public void SaveToExcel(ArrayList columns, DataRowCollection rows)
        {
            var saveAsDialog = new SaveFileDialog()
            {
                Title = @"Save As",
                FileName = "Library.xls",
                OverwritePrompt = true,
                Filter = @"Excel Workbook (*.xls)|*.xls|Text Documents (*.txt)|*.txt|MS Word Document (*.docs)|*.doc"
            };
            
            if (saveAsDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveAsDialog.FileName);

                    foreach (var column in columns)
                    {
                        streamWriter.Write(column + "\t");
                    }

                    streamWriter.WriteLine();

                    for (int i = 0; i < rows.Count; i++)
                    {
                        for (int j = 1; j <= columns.Count; j++)
                        {
                            if (rows[i][j] != null)
                            {
                                streamWriter.Write(Convert.ToString(rows[i][j]) + "\t");
                            }
                            else
                            {
                                streamWriter.Write("\t");
                            }
                        }
                        streamWriter.WriteLine();
                    }
                    streamWriter.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
    }
}
