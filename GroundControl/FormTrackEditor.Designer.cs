namespace GroundControl
{
    partial class FormTrackEditor
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
            this.listTracks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewGroups = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTracks
            // 
            this.listTracks.AllowColumnReorder = true;
            this.listTracks.AllowDrop = true;
            this.listTracks.CheckBoxes = true;
            this.listTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listTracks.Dock = System.Windows.Forms.DockStyle.Top;
            this.listTracks.FullRowSelect = true;
            this.listTracks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listTracks.HideSelection = false;
            this.listTracks.LabelEdit = true;
            this.listTracks.Location = new System.Drawing.Point(0, 0);
            this.listTracks.Name = "listTracks";
            this.listTracks.Size = new System.Drawing.Size(283, 209);
            this.listTracks.TabIndex = 0;
            this.listTracks.UseCompatibleStateImageBehavior = false;
            this.listTracks.View = System.Windows.Forms.View.Details;
            this.listTracks.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listTracks_AfterLabelEdit);
            this.listTracks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listTracks_ItemCheck);
            this.listTracks.DragDrop += new System.Windows.Forms.DragEventHandler(this.listTracks_DragDrop);
            this.listTracks.DragOver += new System.Windows.Forms.DragEventHandler(this.listTracks_DragOver);
            this.listTracks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listTracks_KeyDown);
            this.listTracks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listTracks_MouseMove);
            this.listTracks.Resize += new System.EventHandler(this.listTracks_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 174;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonChangeColor);
            this.panel1.Controls.Add(this.listViewGroups);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 185);
            this.panel1.TabIndex = 4;
            // 
            // listViewGroups
            // 
            this.listViewGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewGroups.CheckBoxes = true;
            this.listViewGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewGroups.FullRowSelect = true;
            this.listViewGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewGroups.HideSelection = false;
            this.listViewGroups.Location = new System.Drawing.Point(12, 26);
            this.listViewGroups.Name = "listViewGroups";
            this.listViewGroups.Size = new System.Drawing.Size(259, 118);
            this.listViewGroups.TabIndex = 3;
            this.listViewGroups.UseCompatibleStateImageBehavior = false;
            this.listViewGroups.View = System.Windows.Forms.View.Details;
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeColor.Location = new System.Drawing.Point(11, 150);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(260, 23);
            this.buttonChangeColor.TabIndex = 4;
            this.buttonChangeColor.Text = "Color";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 209);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(283, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Groups";
            // 
            // FormTrackEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 394);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listTracks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTrackEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tracks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrackEditor_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listTracks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.ListView listViewGroups;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
    }
}