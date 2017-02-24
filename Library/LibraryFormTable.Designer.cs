namespace Library
{
    partial class LibraryFormTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryFormTable));
            this.dataGridViewLibrary = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrary)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLibrary
            // 
            this.dataGridViewLibrary.AllowUserToAddRows = false;
            this.dataGridViewLibrary.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLibrary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLibrary.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewLibrary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLibrary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Calligraphy", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Calligraphy", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLibrary.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLibrary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewLibrary.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLibrary.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataGridViewLibrary.Name = "dataGridViewLibrary";
            this.dataGridViewLibrary.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Calligraphy", 13F);
            this.dataGridViewLibrary.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLibrary.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Calligraphy", 13F);
            this.dataGridViewLibrary.RowTemplate.Height = 30;
            this.dataGridViewLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLibrary.Size = new System.Drawing.Size(1370, 630);
            this.dataGridViewLibrary.TabIndex = 0;
            this.dataGridViewLibrary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellMouseLeave);
            this.dataGridViewLibrary.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellMouseEnter);
            this.dataGridViewLibrary.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellMouseLeave);
            this.dataGridViewLibrary.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.LibraryFormTable_RowsRemoved);
            this.dataGridViewLibrary.Sorted += new System.EventHandler(this.LibraryFormTable_Sorted);
            this.dataGridViewLibrary.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Row_Delete);
            this.dataGridViewLibrary.Leave += new System.EventHandler(this.DataGridView_MouseLeave);
            this.dataGridViewLibrary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseRightClick);
            this.dataGridViewLibrary.MouseLeave += new System.EventHandler(this.DataGridView_MouseLeave);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.PaleGreen;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(120, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10F);
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditMenu_click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // LibraryFormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 630);
            this.Controls.Add(this.dataGridViewLibrary);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "LibraryFormTable";
            this.Text = "Books by Genre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrary)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibrary;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}