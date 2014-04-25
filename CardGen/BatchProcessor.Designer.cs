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
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // CardList
            // 
            this.CardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardList.Location = new System.Drawing.Point(12, 12);
            this.CardList.Name = "CardList";
            this.CardList.Size = new System.Drawing.Size(242, 475);
            this.CardList.TabIndex = 0;
            this.CardList.UseCompatibleStateImageBehavior = false;
            this.CardList.View = System.Windows.Forms.View.Details;
            // 
            // CardPreview
            // 
            this.CardPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CardPreview.Location = new System.Drawing.Point(291, 12);
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
            this.ImporterSelector.Location = new System.Drawing.Point(260, 268);
            this.ImporterSelector.Name = "ImporterSelector";
            this.ImporterSelector.Size = new System.Drawing.Size(242, 21);
            this.ImporterSelector.TabIndex = 2;
            this.ImporterSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ImporterSettings
            // 
            this.ImporterSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImporterSettings.Location = new System.Drawing.Point(260, 295);
            this.ImporterSettings.Name = "ImporterSettings";
            this.ImporterSettings.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.ImporterSettings.Size = new System.Drawing.Size(242, 192);
            this.ImporterSettings.TabIndex = 3;
            this.ImporterSettings.ToolbarVisible = false;
            // 
            // DoGenerate
            // 
            this.DoGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoGenerate.Location = new System.Drawing.Point(382, 493);
            this.DoGenerate.Name = "DoGenerate";
            this.DoGenerate.Size = new System.Drawing.Size(120, 37);
            this.DoGenerate.TabIndex = 4;
            this.DoGenerate.Text = "Batch Generate";
            this.DoGenerate.UseVisualStyleBackColor = true;
            // 
            // OutputDirBox
            // 
            this.OutputDirBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDirBox.Location = new System.Drawing.Point(12, 506);
            this.OutputDirBox.Name = "OutputDirBox";
            this.OutputDirBox.Size = new System.Drawing.Size(201, 20);
            this.OutputDirBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output Directory";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(219, 506);
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
            this.DoImport.Location = new System.Drawing.Point(260, 493);
            this.DoImport.Name = "DoImport";
            this.DoImport.Size = new System.Drawing.Size(116, 37);
            this.DoImport.TabIndex = 8;
            this.DoImport.Text = "Import";
            this.DoImport.UseVisualStyleBackColor = true;
            this.DoImport.Click += new System.EventHandler(this.DoImport_Click);
            // 
            // BatchProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 542);
            this.Controls.Add(this.DoImport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputDirBox);
            this.Controls.Add(this.DoGenerate);
            this.Controls.Add(this.ImporterSettings);
            this.Controls.Add(this.ImporterSelector);
            this.Controls.Add(this.CardPreview);
            this.Controls.Add(this.CardList);
            this.MinimumSize = new System.Drawing.Size(530, 581);
            this.Name = "BatchProcessor";
            this.Text = "Batch Processor";
            this.Load += new System.EventHandler(this.BatchProcessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).EndInit();
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
    }
}