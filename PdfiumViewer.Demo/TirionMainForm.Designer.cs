using System;
using System.Collections.Generic;
using System.Text;

namespace PdfiumViewer.Demo
{
    partial class TirionMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TirionMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.openProfessionFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMultiplePagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.renderToBitmapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMarginsWhenPrintingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkToMarginsWhenPrintingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteCurrentPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCurrentPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showRangeOfPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this._page = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this._zoom = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._pageToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this._coordinatesToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this._fitWidth = new System.Windows.Forms.ToolStripButton();
            this._fitHeight = new System.Windows.Forms.ToolStripButton();
            this._fitBest = new System.Windows.Forms.ToolStripButton();
            this._rotateLeft = new System.Windows.Forms.ToolStripButton();
            this._rotateRight = new System.Windows.Forms.ToolStripButton();
            this._showToolbar = new System.Windows.Forms.ToolStripButton();
            this._showBookmarks = new System.Windows.Forms.ToolStripButton();
            this._getTextFromPage = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem8,
            this.openProfessionFolder,
            this.toolStripMenuItem1,
            this.printPreviewToolStripMenuItem,
            this.printMultiplePagesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "&文件";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openToolStripMenuItem.Text = "&打开文件";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem8.Text = "&打开文件夹";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // openProfessionFolder
            // 
            this.openProfessionFolder.Name = "openProfessionFolder";
            this.openProfessionFolder.Size = new System.Drawing.Size(171, 22);
            this.openProfessionFolder.Text = "打开专业";
            this.openProfessionFolder.Click += new System.EventHandler(this.openProfessionFolder_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.printPreviewToolStripMenuItem.Text = "打印预览";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printMultiplePagesToolStripMenuItem
            // 
            this.printMultiplePagesToolStripMenuItem.Name = "printMultiplePagesToolStripMenuItem";
            this.printMultiplePagesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.printMultiplePagesToolStripMenuItem.Text = "打印多页";
            this.printMultiplePagesToolStripMenuItem.Click += new System.EventHandler(this.printMultiplePagesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(168, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.toolStripMenuItem7,
            this.renderToBitmapsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cutMarginsWhenPrintingToolStripMenuItem,
            this.shrinkToMarginsWhenPrintingToolStripMenuItem,
            this.toolStripMenuItem4,
            this.deleteCurrentPageToolStripMenuItem,
            this.rotateCurrentPageToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showRangeOfPagesToolStripMenuItem,
            this.toolStripMenuItem6,
            this.informationToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.toolsToolStripMenuItem.Text = "&工具";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.findToolStripMenuItem.Text = "&查找";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(157, 6);
            // 
            // renderToBitmapsToolStripMenuItem
            // 
            this.renderToBitmapsToolStripMenuItem.Name = "renderToBitmapsToolStripMenuItem";
            this.renderToBitmapsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.renderToBitmapsToolStripMenuItem.Text = "显示为图片";
            this.renderToBitmapsToolStripMenuItem.Click += new System.EventHandler(this.renderToBitmapsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // cutMarginsWhenPrintingToolStripMenuItem
            // 
            this.cutMarginsWhenPrintingToolStripMenuItem.Name = "cutMarginsWhenPrintingToolStripMenuItem";
            this.cutMarginsWhenPrintingToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cutMarginsWhenPrintingToolStripMenuItem.Text = "打印时去除边框";
            this.cutMarginsWhenPrintingToolStripMenuItem.Click += new System.EventHandler(this.cutMarginsWhenPrintingToolStripMenuItem_Click);
            // 
            // shrinkToMarginsWhenPrintingToolStripMenuItem
            // 
            this.shrinkToMarginsWhenPrintingToolStripMenuItem.Name = "shrinkToMarginsWhenPrintingToolStripMenuItem";
            this.shrinkToMarginsWhenPrintingToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.shrinkToMarginsWhenPrintingToolStripMenuItem.Text = "打印时缩小边距";
            this.shrinkToMarginsWhenPrintingToolStripMenuItem.Click += new System.EventHandler(this.shrinkToMarginsWhenPrintingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(157, 6);
            // 
            // deleteCurrentPageToolStripMenuItem
            // 
            this.deleteCurrentPageToolStripMenuItem.Name = "deleteCurrentPageToolStripMenuItem";
            this.deleteCurrentPageToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteCurrentPageToolStripMenuItem.Text = "删除当前页";
            this.deleteCurrentPageToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentPageToolStripMenuItem_Click);
            // 
            // rotateCurrentPageToolStripMenuItem
            // 
            this.rotateCurrentPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotate0ToolStripMenuItem,
            this.rotate90ToolStripMenuItem,
            this.rotate180ToolStripMenuItem,
            this.rotate270ToolStripMenuItem});
            this.rotateCurrentPageToolStripMenuItem.Name = "rotateCurrentPageToolStripMenuItem";
            this.rotateCurrentPageToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.rotateCurrentPageToolStripMenuItem.Text = "旋转当前页";
            // 
            // rotate0ToolStripMenuItem
            // 
            this.rotate0ToolStripMenuItem.Name = "rotate0ToolStripMenuItem";
            this.rotate0ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rotate0ToolStripMenuItem.Text = "Rotate 0°";
            this.rotate0ToolStripMenuItem.Click += new System.EventHandler(this.rotate0ToolStripMenuItem_Click);
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rotate90ToolStripMenuItem.Text = "Rotate 90°";
            this.rotate90ToolStripMenuItem.Click += new System.EventHandler(this.rotate90ToolStripMenuItem_Click);
            // 
            // rotate180ToolStripMenuItem
            // 
            this.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            this.rotate180ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rotate180ToolStripMenuItem.Text = "Rotate 180°";
            this.rotate180ToolStripMenuItem.Click += new System.EventHandler(this.rotate180ToolStripMenuItem_Click);
            // 
            // rotate270ToolStripMenuItem
            // 
            this.rotate270ToolStripMenuItem.Name = "rotate270ToolStripMenuItem";
            this.rotate270ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rotate270ToolStripMenuItem.Text = "Rotate 270°";
            this.rotate270ToolStripMenuItem.Click += new System.EventHandler(this.rotate270ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(157, 6);
            // 
            // showRangeOfPagesToolStripMenuItem
            // 
            this.showRangeOfPagesToolStripMenuItem.Name = "showRangeOfPagesToolStripMenuItem";
            this.showRangeOfPagesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.showRangeOfPagesToolStripMenuItem.Text = "显示页码";
            this.showRangeOfPagesToolStripMenuItem.Click += new System.EventHandler(this.showRangeOfPagesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(157, 6);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.informationToolStripMenuItem.Text = "关于";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this._page,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this._zoom,
            this.toolStripSeparator7,
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this._fitWidth,
            this._fitHeight,
            this._fitBest,
            this.toolStripSeparator5,
            this._rotateLeft,
            this._rotateRight,
            this.toolStripSeparator6,
            this._showToolbar,
            this._showBookmarks,
            this._getTextFromPage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "页码:";
            // 
            // _page
            // 
            this._page.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this._page.Name = "_page";
            this._page.Size = new System.Drawing.Size(100, 25);
            this._page.KeyDown += new System.Windows.Forms.KeyEventHandler(this._page_KeyDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "缩放:";
            // 
            // _zoom
            // 
            this._zoom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this._zoom.Name = "_zoom";
            this._zoom.Size = new System.Drawing.Size(100, 25);
            this._zoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this._zoom_KeyDown);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this._pageToolStripLabel,
            this.toolStripStatusLabel2,
            this._coordinatesToolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "当前页:";
            // 
            // _pageToolStripLabel
            // 
            this._pageToolStripLabel.Name = "_pageToolStripLabel";
            this._pageToolStripLabel.Size = new System.Drawing.Size(46, 17);
            this._pageToolStripLabel.Text = "(page)";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel2.Text = "光标:";
            // 
            // _coordinatesToolStripLabel
            // 
            this._coordinatesToolStripLabel.Name = "_coordinatesToolStripLabel";
            this._coordinatesToolStripLabel.Size = new System.Drawing.Size(85, 17);
            this._coordinatesToolStripLabel.Text = "(coordinates)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pdfViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 657);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 657);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(334, 24);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件清单";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(924, 657);
            this.pdfViewer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PdfiumViewer.Demo.Properties.Resources.export;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(254, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 24);
            this.button1.TabIndex = 99;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "<";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = ">";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "+";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "-";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // _fitWidth
            // 
            this._fitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._fitWidth.Image = ((System.Drawing.Image)(resources.GetObject("_fitWidth.Image")));
            this._fitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._fitWidth.Name = "_fitWidth";
            this._fitWidth.Size = new System.Drawing.Size(72, 22);
            this._fitWidth.Text = "自适应宽度";
            this._fitWidth.Click += new System.EventHandler(this._fitWidth_Click);
            // 
            // _fitHeight
            // 
            this._fitHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._fitHeight.Image = ((System.Drawing.Image)(resources.GetObject("_fitHeight.Image")));
            this._fitHeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._fitHeight.Name = "_fitHeight";
            this._fitHeight.Size = new System.Drawing.Size(72, 22);
            this._fitHeight.Text = "自适应高度";
            this._fitHeight.Click += new System.EventHandler(this._fitHeight_Click);
            // 
            // _fitBest
            // 
            this._fitBest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._fitBest.Image = ((System.Drawing.Image)(resources.GetObject("_fitBest.Image")));
            this._fitBest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._fitBest.Name = "_fitBest";
            this._fitBest.Size = new System.Drawing.Size(48, 22);
            this._fitBest.Text = "自适应";
            this._fitBest.Click += new System.EventHandler(this._fitBest_Click);
            // 
            // _rotateLeft
            // 
            this._rotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._rotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("_rotateLeft.Image")));
            this._rotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rotateLeft.Name = "_rotateLeft";
            this._rotateLeft.Size = new System.Drawing.Size(36, 22);
            this._rotateLeft.Text = "左转";
            this._rotateLeft.Click += new System.EventHandler(this._rotateLeft_Click);
            // 
            // _rotateRight
            // 
            this._rotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._rotateRight.Image = ((System.Drawing.Image)(resources.GetObject("_rotateRight.Image")));
            this._rotateRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rotateRight.Name = "_rotateRight";
            this._rotateRight.Size = new System.Drawing.Size(36, 22);
            this._rotateRight.Text = "右转";
            this._rotateRight.Click += new System.EventHandler(this._rotateRight_Click);
            // 
            // _showToolbar
            // 
            this._showToolbar.CheckOnClick = true;
            this._showToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._showToolbar.Image = ((System.Drawing.Image)(resources.GetObject("_showToolbar.Image")));
            this._showToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showToolbar.Name = "_showToolbar";
            this._showToolbar.Size = new System.Drawing.Size(72, 22);
            this._showToolbar.Text = "显示工具栏";
            this._showToolbar.Click += new System.EventHandler(this._hideToolbar_Click);
            // 
            // _showBookmarks
            // 
            this._showBookmarks.CheckOnClick = true;
            this._showBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._showBookmarks.Image = ((System.Drawing.Image)(resources.GetObject("_showBookmarks.Image")));
            this._showBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showBookmarks.Name = "_showBookmarks";
            this._showBookmarks.Size = new System.Drawing.Size(60, 22);
            this._showBookmarks.Text = "显示书签";
            this._showBookmarks.Click += new System.EventHandler(this._hideBookmarks_Click);
            // 
            // _getTextFromPage
            // 
            this._getTextFromPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._getTextFromPage.Image = ((System.Drawing.Image)(resources.GetObject("_getTextFromPage.Image")));
            this._getTextFromPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._getTextFromPage.Name = "_getTextFromPage";
            this._getTextFromPage.Size = new System.Drawing.Size(60, 22);
            this._getTextFromPage.Text = "获取文本";
            this._getTextFromPage.ToolTipText = "Get Text From Current Page";
            this._getTextFromPage.Click += new System.EventHandler(this._getTextFromPage_Click);
            // 
            // TirionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TirionMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderToBitmapsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox _page;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutMarginsWhenPrintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkToMarginsWhenPrintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _fitWidth;
        private System.Windows.Forms.ToolStripButton _fitHeight;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox _zoom;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton _rotateLeft;
        private System.Windows.Forms.ToolStripButton _rotateRight;
        private System.Windows.Forms.ToolStripButton _fitBest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton _showToolbar;
        private System.Windows.Forms.ToolStripButton _showBookmarks;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCurrentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel _pageToolStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel _coordinatesToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showRangeOfPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton _getTextFromPage;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem printMultiplePagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private PdfViewer pdfViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem openProfessionFolder;
    }
}

