using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PdfiumViewer.Demo
{
    public partial class TirionMainForm : Form
    {
        private SearchForm _searchForm;

        public TirionMainForm()
        {
            InitializeComponent();

            renderToBitmapsToolStripMenuItem.Enabled = false;

            pdfViewer1.Renderer.DisplayRectangleChanged += Renderer_DisplayRectangleChanged;
            pdfViewer1.Renderer.ZoomChanged += Renderer_ZoomChanged;

            pdfViewer1.Renderer.MouseMove += Renderer_MouseMove;
            pdfViewer1.Renderer.MouseLeave += Renderer_MouseLeave;
            ShowPdfLocation(PdfPoint.Empty);

            cutMarginsWhenPrintingToolStripMenuItem.PerformClick();

            _zoom.Text = pdfViewer1.Renderer.Zoom.ToString();

            Disposed += (s, e) => pdfViewer1.Document?.Dispose();
        }

        private void Renderer_MouseLeave(object sender, EventArgs e)
        {
            ShowPdfLocation(PdfPoint.Empty);
        }

        private void Renderer_MouseMove(object sender, MouseEventArgs e)
        {
            ShowPdfLocation(pdfViewer1.Renderer.PointToPdf(e.Location));
        }

        private void ShowPdfLocation(PdfPoint point)
        {
            if (!point.IsValid)
            {
                _pageToolStripLabel.Text = null;
                _coordinatesToolStripLabel.Text = null;
            }
            else
            {
                _pageToolStripLabel.Text = (point.Page + 1).ToString();
                _coordinatesToolStripLabel.Text = point.Location.X + "," + point.Location.Y;
            }
        }

        void Renderer_ZoomChanged(object sender, EventArgs e)
        {
            _zoom.Text = pdfViewer1.Renderer.Zoom.ToString();
        }

        void Renderer_DisplayRectangleChanged(object sender, EventArgs e)
        {
            _page.Text = (pdfViewer1.Renderer.Page + 1).ToString();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            var args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                pdfViewer1.Document?.Dispose();
                pdfViewer1.Document = OpenDocument(args[1]);
                renderToBitmapsToolStripMenuItem.Enabled = true;
            }
            else
            {
                //OpenFile();
            }

            _showBookmarks.Checked = pdfViewer1.ShowBookmarks;
            _showToolbar.Checked = pdfViewer1.ShowToolbar;
        }

        private PdfDocument OpenDocument(string fileName)
        {
            try
            {
                return PdfDocument.Load(this, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void OpenFile()
        {
            using (var form = new OpenFileDialog())
            {
                form.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                form.RestoreDirectory = true;
                form.Title = "Open PDF File";

                if (form.ShowDialog(this) != DialogResult.OK)
                {
                    //Dispose();
                    return;
                }

                pdfViewer1.Document?.Dispose();
                pdfViewer1.Document = OpenDocument(form.FileName);
                renderToBitmapsToolStripMenuItem.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void renderToBitmapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int dpiX;
            int dpiY;

            using (var form = new ExportBitmapsForm())
            {
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                dpiX = form.DpiX;
                dpiY = form.DpiY;
            }

            string path;

            using (var form = new FolderBrowserDialog())
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                path = form.SelectedPath;
            }

            var document = pdfViewer1.Document;

            for (int i = 0; i < document.PageCount; i++)
            {
                using (var image = document.Render(i, (int)document.PageSizes[i].Width, (int)document.PageSizes[i].Height, dpiX, dpiY, false))
                {
                    image.Save(Path.Combine(path, "Page " + i + ".png"));
                }
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            pdfViewer1.Renderer.Page--;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pdfViewer1.Renderer.Page++;
        }

        private void cutMarginsWhenPrintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutMarginsWhenPrintingToolStripMenuItem.Checked = true;
            shrinkToMarginsWhenPrintingToolStripMenuItem.Checked = false;

            pdfViewer1.DefaultPrintMode = PdfPrintMode.CutMargin;
        }

        private void shrinkToMarginsWhenPrintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shrinkToMarginsWhenPrintingToolStripMenuItem.Checked = true;
            cutMarginsWhenPrintingToolStripMenuItem.Checked = false;

            pdfViewer1.DefaultPrintMode = PdfPrintMode.ShrinkToMargin;
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new PrintPreviewDialog())
            {
                form.Document = pdfViewer1.Document.CreatePrintDocument(pdfViewer1.DefaultPrintMode);
                form.ShowDialog(this);
            }
        }

        private void _fitWidth_Click(object sender, EventArgs e)
        {
            FitPage(PdfViewerZoomMode.FitWidth);
        }

        private void FitPage(PdfViewerZoomMode zoomMode)
        {
            int page = pdfViewer1.Renderer.Page;
            pdfViewer1.ZoomMode = zoomMode;
            pdfViewer1.Renderer.Zoom = 1;
            pdfViewer1.Renderer.Page = page;
        }

        private void _fitHeight_Click(object sender, EventArgs e)
        {
            FitPage(PdfViewerZoomMode.FitHeight);
        }

        private void _fitBest_Click(object sender, EventArgs e)
        {
            FitPage(PdfViewerZoomMode.FitBest);
        }

        private void _page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                int page;
                if (int.TryParse(_page.Text, out page))
                    pdfViewer1.Renderer.Page = page - 1;
            }
        }

        private void _zoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                float zoom;
                if (float.TryParse(_zoom.Text, out zoom))
                    pdfViewer1.Renderer.Zoom = zoom;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pdfViewer1.Renderer.ZoomIn();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pdfViewer1.Renderer.ZoomOut();
        }

        private void _rotateLeft_Click(object sender, EventArgs e)
        {
            pdfViewer1.Renderer.RotateLeft();
        }

        private void _rotateRight_Click(object sender, EventArgs e)
        {
            pdfViewer1.Renderer.RotateRight();
        }

        private void _hideToolbar_Click(object sender, EventArgs e)
        {
            pdfViewer1.ShowToolbar = _showToolbar.Checked;
        }

        private void _hideBookmarks_Click(object sender, EventArgs e)
        {
            pdfViewer1.ShowBookmarks = _showBookmarks.Checked;
        }

        private void deleteCurrentPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // PdfRenderer does not support changes to the loaded document,
            // so we fake it by reloading the document into the renderer.

            int page = pdfViewer1.Renderer.Page;
            var document = pdfViewer1.Document;
            pdfViewer1.Document = null;
            document.DeletePage(page);
            pdfViewer1.Document = document;
            pdfViewer1.Renderer.Page = page;
        }

        private void rotate0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate(PdfRotation.Rotate0);
        }

        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate(PdfRotation.Rotate90);
        }

        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate(PdfRotation.Rotate180);
        }

        private void rotate270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate(PdfRotation.Rotate270);
        }

        private void Rotate(PdfRotation rotate)
        {
            // PdfRenderer does not support changes to the loaded document,
            // so we fake it by reloading the document into the renderer.

            int page = pdfViewer1.Renderer.Page;
            var document = pdfViewer1.Document;
            pdfViewer1.Document = null;
            document.RotatePage(page, rotate);
            pdfViewer1.Document = document;
            pdfViewer1.Renderer.Page = page;
        }

        private void showRangeOfPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new PageRangeForm(pdfViewer1.Document))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    pdfViewer1.Document = form.Document;
                }
            }
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfInformation info = pdfViewer1.Document.GetInformation();
            StringBuilder sz = new StringBuilder();
            sz.AppendLine($"Author: {info.Author}");
            sz.AppendLine($"Creator: {info.Creator}");
            sz.AppendLine($"Keywords: {info.Keywords}");
            sz.AppendLine($"Producer: {info.Producer}");
            sz.AppendLine($"Subject: {info.Subject}");
            sz.AppendLine($"Title: {info.Title}");
            sz.AppendLine($"Create Date: {info.CreationDate}");
            sz.AppendLine($"Modified Date: {info.ModificationDate}");

            MessageBox.Show(sz.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _getTextFromPage_Click(object sender, EventArgs e)
        {
            int page = pdfViewer1.Renderer.Page;
            string text = pdfViewer1.Document.GetPdfText(page);
            string caption = string.Format("Page {0} contains {1} character(s):", page + 1, text.Length);

            if (text.Length > 128) text = text.Substring(0, 125) + "...\n\n\n\n..." + text.Substring(text.Length - 125);
            MessageBox.Show(this, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_searchForm == null)
            {
                _searchForm = new SearchForm(pdfViewer1.Renderer);
                _searchForm.Disposed += (s, ea) => _searchForm = null;
                _searchForm.Show(this);
            }

            _searchForm.Focus();
        }

        private void printMultiplePagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new PrintMultiplePagesForm(pdfViewer1))
            {
                form.ShowDialog(this);
            }
        }

        private string lastDirectoryPath = string.Empty;

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            using (var form = new FolderBrowserDialog())
            {
                form.Description = "Open Project File Directory";
                if (!string.IsNullOrEmpty(this.lastDirectoryPath))
                {
                    form.SelectedPath = lastDirectoryPath;
                }

                if (form.ShowDialog(this) != DialogResult.OK)
                {
                    //Dispose();
                    return;
                }
                if (this.tableLayoutPanel1.Controls.Count > 1)
                {
                    this.tableLayoutPanel1.Controls.RemoveAt(1);
                }

                string targetPath = form.SelectedPath;
                this.lastDirectoryPath = targetPath;
                //设置上层label文本
                label1.Text = new DirectoryInfo(targetPath).Name;
                // 
                // 添加tab控件
                // 
                var closeableTabControl1 = new CloseableTabControl();
                closeableTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
                closeableTabControl1.Location = new System.Drawing.Point(3, 241);
                closeableTabControl1.Name = "closeableTabControl1";
                closeableTabControl1.SelectedIndex = 0;
                closeableTabControl1.Size = new System.Drawing.Size(332, 233);
                closeableTabControl1.TabCloseShow = true;
                closeableTabControl1.TabIndex = 3;
                closeableTabControl1.TabRadiusLeftTop = 0;
                closeableTabControl1.TabBackNormalColor = Color.LightGreen;
                closeableTabControl1.TabBackSelectedColor = Color.ForestGreen;

                var directories = Directory.GetDirectories(targetPath);
                foreach (var item in directories)
                {
                    AddTabPagesByDirectory(item, closeableTabControl1);
                }
                this.tableLayoutPanel1.Controls.Add(closeableTabControl1, 0, 1);
            }
        }

        private void AddTabPagesByDirectory(string path, CloseableTabControl tabControl)
        {
            var directory = new DirectoryInfo(path);
            var pdfFiles = directory.GetFiles("*.pdf ");
            if (pdfFiles.Length == 0)
            {
                return;
            }
            // 
            // tabPage1
            // 
            var tabPage1 = new TabPage();
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(324, 203);
            tabPage1.TabIndex = 0;
            tabPage1.Text = directory.Name;
            tabPage1.UseVisualStyleBackColor = true;

            AddListViewToTabPage(pdfFiles, tabPage1);

            tabControl.Controls.Add(tabPage1);
        }

        private void AddListViewToTabPage(FileInfo[] files, TabPage page)
        {
            // 
            // listView1
            // 
            var listView1 = new ListView();
            var columnHeader1 = new System.Windows.Forms.ColumnHeader() { Width = 40 };
            var columnHeader2 = new System.Windows.Forms.ColumnHeader();
            var columnHeader3 = new System.Windows.Forms.ColumnHeader() { Width = 0 };
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
           columnHeader2,columnHeader3});
            listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(3, 3);
            listView1.Margin = new System.Windows.Forms.Padding(0);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(318, 410);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.MultiSelect = false;
            listView1.FullRowSelect = true;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Scrollable = false;

            for (int i = 0; i < files.Length; i++)
            {
                var file = files[i];
                listView1.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), file.Name.Replace(file.Extension, string.Empty), file.FullName }));
            }

            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;

            // 第一列宽度 + 第二列宽度 = 工作区宽度
            listView1.Columns[1].Width = listView1.ClientSize.Width - listView1.Columns[0].Width - 5;
            page.Controls.Add(listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = sender as ListView;

            string fileName = listView.FocusedItem.SubItems[2].Text;

            pdfViewer1.Document?.Dispose();
            pdfViewer1.Document = OpenDocument(fileName);
            renderToBitmapsToolStripMenuItem.Enabled = true;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var listView = sender as ListView;

            if (listView.FocusedItem == null)
            {
                return;
            }
            string fileName = listView.FocusedItem.SubItems[2].Text;

            pdfViewer1.Document?.Dispose();
            pdfViewer1.Document = OpenDocument(fileName);
            renderToBitmapsToolStripMenuItem.Enabled = true;
        }
    }
}
