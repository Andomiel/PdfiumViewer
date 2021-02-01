using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PdfiumViewer
{
    public partial class FileTreeView : UserControl
    {
        public FileTreeView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the default document name used when saving the document.
        /// </summary>
        [DefaultValue(null)]
        public string SelectedPdfFile { get; set; }

        private void FileTreeView_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width < 116)
            {
                this.toolStripLabel1.Width = 16;
                this.toolStripLabel1.Text = "...";
            }
            else if (this.Size.Width < 300)
                this.toolStripLabel1.Width = this.Size.Width - 100;
            else
            {
                //do nothing
            }
        }


    }
}
