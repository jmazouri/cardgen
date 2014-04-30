namespace CardGen
{
    partial class BatchProcessor
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
            this.CardList = new System.Windows.Forms.ListView();
            this.CardPreview = new System.Windows.Forms.PictureBox();
            this.ImporterSelector = new System.Windows.Forms.ComboBox();
            this.ImporterSettings = new System.Windows.Forms.PropertyGrid();
            this.DoGenerate = new System.Windows.Forms.Button();
            this.OutputDirBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DoImport = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNameFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDescriptionFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FrontArtBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardList
            // 
            this.CardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.DescColumn});
            this.CardList.Location = new System.Drawing.Point(12, 27);
            this.CardList.MultiSelect = false;
            this.CardList.Name = "CardList";
            this.CardList.Size = new System.Drawing.Size(242, 434);
            this.CardList.TabIndex = 0;
            this.CardList.UseCompatibleStateImageBehavior = false;
            this.CardList.View = System.Windows.Forms.View.Details;
            this.CardList.SelectedIndexChanged += new System.EventHandler(this.CardList_SelectedIndexChanged);
            // 
            // CardPreview
            // 
            this.CardPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CardPreview.Location = new System.Drawing.Point(291, 27);
            this.CardPreview.Name = "CardPreview";
            this.CardPreview.Size = new System.Drawing.Size(180, 250);
            this.CardPreview.TabIndex = 1;
            this.CardPreview.TabStop = false;
            // 
            // ImporterSelector
            // 
            this.ImporterSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImporterSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImporterSelector.FormattingEnabled = true;
            this.ImporterSelector.Items.AddRange(new object[] {
            "Google Spreadsheet"});
            this.ImporterSelector.Location = new System.Drawing.Point(260, 283);
            this.ImporterSelector.Name = "ImporterSelector";
            this.ImporterSelector.Size = new System.Drawing.Size(242, 21);
            this.ImporterSelector.TabIndex = 2;
            this.ImporterSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ImporterSettings
            // 
            this.ImporterSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImporterSettings.Location = new System.Drawing.Point(260, 310);
            this.ImporterSettings.Name = "ImporterSettings";
            this.ImporterSettings.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.ImporterSettings.Size = new System.Drawing.Size(242, 186);
            this.ImporterSettings.TabIndex = 3;
            this.ImporterSettings.ToolbarVisible = false;
            // 
            // DoGenerate
            // 
            this.DoGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoGenerate.Location = new System.Drawing.Point(340, 502);
            this.DoGenerate.Name = "DoGenerate";
            this.DoGenerate.Size = new System.Drawing.Size(83, 37);
            this.DoGenerate.TabIndex = 4;
            this.DoGenerate.Text = "Batch Generate";
            this.DoGenerate.UseVisualStyleBackColor = true;
            // 
            // OutputDirBox
            // 
            this.OutputDirBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDirBox.Location = new System.Drawing.Point(12, 480);
            this.OutputDirBox.Name = "OutputDirBox";
            this.OutputDirBox.Size = new System.Drawing.Size(201, 20);
            this.OutputDirBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output Directory";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(219, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoImport
            // 
            this.DoImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoImport.Location = new System.Drawing.Point(260, 502);
            this.DoImport.Name = "DoImport";
            this.DoImport.Size = new System.Drawing.Size(74, 37);
            this.DoImport.TabIndex = 8;
            this.DoImport.Text = "Import";
            this.DoImport.UseVisualStyleBackColor = true;
            this.DoImport.Click += new System.EventHandler(this.DoImport_Click);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            // 
            // DescColumn
            // 
            this.DescColumn.Text = "Description";
            this.DescColumn.Width = 160;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setNameFontToolStripMenuItem,
            this.setDescriptionFontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // setNameFontToolStripMenuItem
            // 
            this.setNameFontToolStripMenuItem.Name = "setNameFontToolStripMenuItem";
            this.setNameFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setNameFontToolStripMenuItem.Text = "Set Name Font";
            this.setNameFontToolStripMenuItem.Click += new System.EventHandler(this.setNameFontToolStripMenuItem_Click);
            // 
            // setDescriptionFontToolStripMenuItem
            // 
            this.setDescriptionFontToolStripMenuItem.Name = "setDescriptionFontToolStripMenuItem";
            this.setDescriptionFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDescriptionFontToolStripMenuItem.Text = "Set Description Font";
            this.setDescriptionFontToolStripMenuItem.Click += new System.EventHandler(this.setDescriptionFontToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(429, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generate Sheet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(219, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 20);
            this.button3.TabIndex = 13;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Front Border";
            // 
            // FrontArtBox
            // 
            this.FrontArtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrontArtBox.Location = new System.Drawing.Point(12, 519);
            this.FrontArtBox.Name = "FrontArtBox";
            this.FrontArtBox.Size = new System.Drawing.Size(201, 20);
            this.FrontArtBox.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|All Files|*.*";
            this.openFileDialog1.FilterIndex = 3;
            // 
            // BatchProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 551);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FrontArtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoImport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputDirBox);
            this.Controls.Add(this.DoGenerate);
            this.Controls.Add(this.ImporterSettings);
            this.Controls.Add(this.ImporterSelector);
            this.Controls.Add(this.CardPreview);
            this.Controls.Add(this.CardList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(530, 581);
            this.Name = "BatchProcessor";
            this.Text = "Batch Processor";
            this.Load += new System.EventHandler(this.BatchProcessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CardList;
        private System.Windows.Forms.PictureBox CardPreview;
        private System.Windows.Forms.ComboBox ImporterSelector;
        private System.Windows.Forms.PropertyGrid ImporterSettings;
        private System.Windows.Forms.Button DoGenerate;
        private System.Windows.Forms.TextBox OutputDirBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DoImport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader DescColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNameFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDescriptionFontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FrontArtBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}