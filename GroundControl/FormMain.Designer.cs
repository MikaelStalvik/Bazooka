namespace GroundControl
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStripBookmarks = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.remoteExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.trackManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insert10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBm0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBm5 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.pnlDraw = new System.Windows.Forms.PanelEx();
            this.textEdit = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlAudioView = new System.Windows.Forms.PanelEx();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlVScroll = new System.Windows.Forms.PanelEx();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCurrentRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpmToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelColumnName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripInterpolation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCurrentValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrUpdateUI = new System.Windows.Forms.Timer(this.components);
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBookmarks.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            this.pnlEditor.SuspendLayout();
            this.pnlDraw.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(3, 437);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(937, 17);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(945, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 439);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
            // 
            // menuStripBookmarks
            // 
            this.menuStripBookmarks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.bookmarksToolStripMenuItem});
            this.menuStripBookmarks.Location = new System.Drawing.Point(0, 0);
            this.menuStripBookmarks.Name = "menuStripBookmarks";
            this.menuStripBookmarks.Size = new System.Drawing.Size(962, 24);
            this.menuStripBookmarks.TabIndex = 1;
            this.menuStripBookmarks.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.remoteExportToolStripMenuItem,
            this.toolStripSeparator1,
            this.recentToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.loadToolStripMenuItem.Text = "&Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveAsToolStripMenuItem.Text = "S&ave As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // remoteExportToolStripMenuItem
            // 
            this.remoteExportToolStripMenuItem.Name = "remoteExportToolStripMenuItem";
            this.remoteExportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.remoteExportToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.remoteExportToolStripMenuItem.Text = "&Remote Export";
            this.remoteExportToolStripMenuItem.Click += new System.EventHandler(this.remoteExportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.trackManagerToolStripMenuItem,
            this.insert10ToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // trackManagerToolStripMenuItem
            // 
            this.trackManagerToolStripMenuItem.Name = "trackManagerToolStripMenuItem";
            this.trackManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trackManagerToolStripMenuItem.Text = "Track Manager";
            this.trackManagerToolStripMenuItem.Click += new System.EventHandler(this.trackManagerToolStripMenuItem_Click);
            // 
            // insert10ToolStripMenuItem
            // 
            this.insert10ToolStripMenuItem.Name = "insert10ToolStripMenuItem";
            this.insert10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insert10ToolStripMenuItem.Text = "Insert 8 rows";
            this.insert10ToolStripMenuItem.Click += new System.EventHandler(this.insert8ToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBm0,
            this.toolStripMenuItemBm1,
            this.toolStripMenuItemBm2,
            this.toolStripMenuItemBm3,
            this.toolStripMenuItemBm4,
            this.toolStripMenuItemBm5,
            this.manageToolStripMenuItem});
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.bookmarksToolStripMenuItem.Text = "Bookmarks";
            this.bookmarksToolStripMenuItem.Click += new System.EventHandler(this.bookmarksToolStripMenuItem_Click);
            // 
            // toolStripMenuItemBm0
            // 
            this.toolStripMenuItemBm0.Name = "toolStripMenuItemBm0";
            this.toolStripMenuItemBm0.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBm0.Tag = "0";
            this.toolStripMenuItemBm0.Text = "0";
            this.toolStripMenuItemBm0.Click += new System.EventHandler(this.toolStripMenuItemBookmark_Click);
            // 
            // toolStripMenuItemBm1
            // 
            this.toolStripMenuItemBm1.Name = "toolStripMenuItemBm1";
            this.toolStripMenuItemBm1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBm1.Tag = "1";
            this.toolStripMenuItemBm1.Text = "1";
            this.toolStripMenuItemBm1.Click += new System.EventHandler(this.toolStripMenuItemBookmark_Click);
            // 
            // toolStripMenuItemBm2
            // 
            this.toolStripMenuItemBm2.Name = "toolStripMenuItemBm2";
            this.toolStripMenuItemBm2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBm2.Tag = "2";
            this.toolStripMenuItemBm2.Text = "2";
            this.toolStripMenuItemBm2.Click += new System.EventHandler(this.toolStripMenuItemBookmark_Click);
            // 
            // toolStripMenuItemBm3
            // 
            this.toolStripMenuItemBm3.Name = "toolStripMenuItemBm3";
            this.toolStripMenuItemBm3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBm3.Tag = "3";
            this.toolStripMenuItemBm3.Text = "3";
            this.toolStripMenuItemBm3.Click += new System.EventHandler(this.toolStripMenuItemBookmark_Click);
            // 
            // toolStripMenuItemBm4
            // 
            this.toolStripMenuItemBm4.Name = "toolStripMenuItemBm4";
            this.toolStripMenuItemBm4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBm4.Tag = "4";
            this.toolStripMenuItemBm4.Text = "4";
            this.toolStripMenuItemBm4.Click += new System.EventHandler(this.toolStripMenuItemBookmark_Click);
            // 
            // toolStripMenuItemBm5
            // 
            this.toolStripMenuItemBm5.Name = "toolStripMenuItemBm5";
            this.toolStripMenuItemBm5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBm5.Tag = "5";
            this.toolStripMenuItemBm5.Text = "5";
            this.toolStripMenuItemBm5.Click += new System.EventHandler(this.toolStripMenuItemBookmark_Click);
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.Controls.Add(this.hScrollBar1);
            this.pnlMainArea.Controls.Add(this.vScrollBar1);
            this.pnlMainArea.Controls.Add(this.pnlEditor);
            this.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainArea.Location = new System.Drawing.Point(0, 24);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(962, 455);
            this.pnlMainArea.TabIndex = 2;
            // 
            // pnlEditor
            // 
            this.pnlEditor.Controls.Add(this.pnlDraw);
            this.pnlEditor.Controls.Add(this.splitter2);
            this.pnlEditor.Controls.Add(this.pnlAudioView);
            this.pnlEditor.Controls.Add(this.splitter1);
            this.pnlEditor.Controls.Add(this.pnlVScroll);
            this.pnlEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(811, 375);
            this.pnlEditor.TabIndex = 3;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.Black;
            this.pnlDraw.Controls.Add(this.textEdit);
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(0, 0);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(499, 375);
            this.pnlDraw.TabIndex = 2;
            this.pnlDraw.TabStop = true;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDown);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
            this.pnlDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseUp);
            // 
            // textEdit
            // 
            this.textEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEdit.Location = new System.Drawing.Point(322, 105);
            this.textEdit.Name = "textEdit";
            this.textEdit.Size = new System.Drawing.Size(100, 13);
            this.textEdit.TabIndex = 0;
            this.textEdit.Visible = false;
            this.textEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit_KeyDown);
            this.textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_KeyPress);
            this.textEdit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textEdit_PreviewKeyDown);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(499, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(4, 375);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // pnlAudioView
            // 
            this.pnlAudioView.BackColor = System.Drawing.Color.Black;
            this.pnlAudioView.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAudioView.Location = new System.Drawing.Point(503, 0);
            this.pnlAudioView.Name = "pnlAudioView";
            this.pnlAudioView.Size = new System.Drawing.Size(219, 375);
            this.pnlAudioView.TabIndex = 4;
            this.pnlAudioView.TabStop = true;
            this.pnlAudioView.SizeChanged += new System.EventHandler(this.pnlAudioView_SizeChanged);
            this.pnlAudioView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAudioView_Paint);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(722, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 375);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // pnlVScroll
            // 
            this.pnlVScroll.BackColor = System.Drawing.Color.Black;
            this.pnlVScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVScroll.Location = new System.Drawing.Point(726, 0);
            this.pnlVScroll.Name = "pnlVScroll";
            this.pnlVScroll.Size = new System.Drawing.Size(85, 375);
            this.pnlVScroll.TabIndex = 0;
            this.pnlVScroll.TabStop = true;
            this.pnlVScroll.SizeChanged += new System.EventHandler(this.panelVScroll_SizeChanged);
            this.pnlVScroll.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVScroll_Paint);
            this.pnlVScroll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlVScroll_MouseMove);
            this.pnlVScroll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlVScroll_MouseMove);
            this.pnlVScroll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlVScroll_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConnectionStatus,
            this.toolStripCurrentRow,
            this.timeToolStripStatusLabel,
            this.bpmToolStripStatusLabel,
            this.toolStripStatusLabelColumnName,
            this.toolStripSpacer,
            this.toolStripInterpolation,
            this.toolStripCurrentValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(962, 24);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripConnectionStatus
            // 
            this.toolStripConnectionStatus.AutoSize = false;
            this.toolStripConnectionStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripConnectionStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripConnectionStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripConnectionStatus.Name = "toolStripConnectionStatus";
            this.toolStripConnectionStatus.Size = new System.Drawing.Size(100, 19);
            this.toolStripConnectionStatus.Text = "Disconnected";
            this.toolStripConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripCurrentRow
            // 
            this.toolStripCurrentRow.AutoSize = false;
            this.toolStripCurrentRow.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripCurrentRow.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripCurrentRow.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.toolStripCurrentRow.Name = "toolStripCurrentRow";
            this.toolStripCurrentRow.Size = new System.Drawing.Size(100, 19);
            this.toolStripCurrentRow.Text = "Row: 0";
            this.toolStripCurrentRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeToolStripStatusLabel
            // 
            this.timeToolStripStatusLabel.Name = "timeToolStripStatusLabel";
            this.timeToolStripStatusLabel.Size = new System.Drawing.Size(47, 19);
            this.timeToolStripStatusLabel.Text = "Elapsed";
            // 
            // bpmToolStripStatusLabel
            // 
            this.bpmToolStripStatusLabel.Name = "bpmToolStripStatusLabel";
            this.bpmToolStripStatusLabel.Size = new System.Drawing.Size(32, 19);
            this.bpmToolStripStatusLabel.Text = "BPM";
            // 
            // toolStripStatusLabelColumnName
            // 
            this.toolStripStatusLabelColumnName.Name = "toolStripStatusLabelColumnName";
            this.toolStripStatusLabelColumnName.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStripSpacer
            // 
            this.toolStripSpacer.Name = "toolStripSpacer";
            this.toolStripSpacer.Size = new System.Drawing.Size(468, 19);
            this.toolStripSpacer.Spring = true;
            // 
            // toolStripInterpolation
            // 
            this.toolStripInterpolation.AutoSize = false;
            this.toolStripInterpolation.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripInterpolation.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripInterpolation.Name = "toolStripInterpolation";
            this.toolStripInterpolation.Size = new System.Drawing.Size(100, 19);
            this.toolStripInterpolation.Text = "Step";
            this.toolStripInterpolation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripCurrentValue
            // 
            this.toolStripCurrentValue.AutoSize = false;
            this.toolStripCurrentValue.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripCurrentValue.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripCurrentValue.Name = "toolStripCurrentValue";
            this.toolStripCurrentValue.Size = new System.Drawing.Size(100, 19);
            this.toolStripCurrentValue.Text = "0.00";
            this.toolStripCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrUpdateUI
            // 
            this.tmrUpdateUI.Enabled = true;
            this.tmrUpdateUI.Tick += new System.EventHandler(this.tmrUpdateUI_Tick);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 503);
            this.Controls.Add(this.pnlMainArea);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripBookmarks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripBookmarks;
            this.Name = "MainForm";
            this.Text = "Bitbendaz Bazooka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStripBookmarks.ResumeLayout(false);
            this.menuStripBookmarks.PerformLayout();
            this.pnlMainArea.ResumeLayout(false);
            this.pnlEditor.ResumeLayout(false);
            this.pnlDraw.ResumeLayout(false);
            this.pnlDraw.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox textEdit;
        private System.Windows.Forms.PanelEx pnlDraw;
        private System.Windows.Forms.MenuStrip menuStripBookmarks;
        private System.Windows.Forms.Panel pnlMainArea;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PanelEx pnlAudioView;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem trackManagerToolStripMenuItem;
        private System.Windows.Forms.Timer tmrUpdateUI;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCurrentRow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSpacer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripInterpolation;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCurrentValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripConnectionStatus;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem remoteExportToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.PanelEx pnlVScroll;
        private System.Windows.Forms.ToolStripMenuItem insert10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel timeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel bpmToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelColumnName;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBm0;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBm1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBm2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBm3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBm4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBm5;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
    }
}

