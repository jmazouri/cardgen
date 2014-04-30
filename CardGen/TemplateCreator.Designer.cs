namespace CardGen
{
    partial class TemplateCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateCreator));
            this.CardPreview = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTitleFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDescriptionFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ArtPosX = new System.Windows.Forms.NumericUpDown();
            this.ArtPosY = new System.Windows.Forms.NumericUpDown();
            this.ImageScale = new System.Windows.Forms.NumericUpDown();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ArtPositionSelector = new CardGen.PositionSelector();
            this.listView1 = new System.Windows.Forms.ListView();
            this.propertyGridEx1 = new PropertyGridEx.PropertyGridEx();
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScale)).BeginInit();
            this.SuspendLayout();
            // 
            // CardPreview
            // 
            this.CardPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CardPreview.Location = new System.Drawing.Point(252, 27);
            this.CardPreview.Name = "CardPreview";
            this.CardPreview.Size = new System.Drawing.Size(180, 250);
            this.CardPreview.TabIndex = 0;
            this.CardPreview.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setTitleFontToolStripMenuItem,
            this.setDescriptionFontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // setTitleFontToolStripMenuItem
            // 
            this.setTitleFontToolStripMenuItem.Name = "setTitleFontToolStripMenuItem";
            this.setTitleFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setTitleFontToolStripMenuItem.Text = "Set Name Font";
            this.setTitleFontToolStripMenuItem.Click += new System.EventHandler(this.setTitleFontToolStripMenuItem_Click_1);
            // 
            // setDescriptionFontToolStripMenuItem
            // 
            this.setDescriptionFontToolStripMenuItem.Name = "setDescriptionFontToolStripMenuItem";
            this.setDescriptionFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDescriptionFontToolStripMenuItem.Text = "Set Description Font";
            this.setDescriptionFontToolStripMenuItem.Click += new System.EventHandler(this.setDescriptionFontToolStripMenuItem_Click_1);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batchToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.batchToolStripMenuItem.Text = "Batch";
            this.batchToolStripMenuItem.Click += new System.EventHandler(this.batchToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Bitmap files|*.bmp|Jpeg Files|*.jpg,*.jpeg|PNG Files|*.png|All files|*.*";
            this.openFileDialog1.FilterIndex = 4;
            // 
            // ArtPosX
            // 
            this.ArtPosX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtPosX.Location = new System.Drawing.Point(378, 312);
            this.ArtPosX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ArtPosX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ArtPosX.Name = "ArtPosX";
            this.ArtPosX.Size = new System.Drawing.Size(54, 20);
            this.ArtPosX.TabIndex = 13;
            this.ArtPosX.ValueChanged += new System.EventHandler(this.ArtPosX_ValueChanged);
            // 
            // ArtPosY
            // 
            this.ArtPosY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtPosY.Location = new System.Drawing.Point(378, 286);
            this.ArtPosY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ArtPosY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ArtPosY.Name = "ArtPosY";
            this.ArtPosY.Size = new System.Drawing.Size(54, 20);
            this.ArtPosY.TabIndex = 14;
            this.ArtPosY.ValueChanged += new System.EventHandler(this.ArtPosY_ValueChanged);
            // 
            // ImageScale
            // 
            this.ImageScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageScale.DecimalPlaces = 2;
            this.ImageScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ImageScale.Location = new System.Drawing.Point(378, 338);
            this.ImageScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ImageScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ImageScale.Name = "ImageScale";
            this.ImageScale.Size = new System.Drawing.Size(54, 20);
            this.ImageScale.TabIndex = 15;
            this.ImageScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ImageScale.ValueChanged += new System.EventHandler(this.ImageScale_ValueChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG files|*.png|All Files|*.*";
            // 
            // ArtPositionSelector
            // 
            this.ArtPositionSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtPositionSelector.ExactPosition = new System.Drawing.Point(100, 50);
            this.ArtPositionSelector.ImageSize = 1D;
            this.ArtPositionSelector.Location = new System.Drawing.Point(252, 283);
            this.ArtPositionSelector.Name = "ArtPositionSelector";
            this.ArtPositionSelector.Size = new System.Drawing.Size(120, 167);
            this.ArtPositionSelector.TabIndex = 12;
            this.ArtPositionSelector.OnChange += new CardGen.PositionSelector.myDataChangedDelegate(this.ArtPositionSelector_OnChange);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(234, 250);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // propertyGridEx1
            // 
            this.propertyGridEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.propertyGridEx1.DocCommentDescription.AccessibleName = "";
            this.propertyGridEx1.DocCommentDescription.AutoEllipsis = true;
            this.propertyGridEx1.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridEx1.DocCommentDescription.Location = new System.Drawing.Point(3, 18);
            this.propertyGridEx1.DocCommentDescription.Name = "";
            this.propertyGridEx1.DocCommentDescription.Size = new System.Drawing.Size(228, 37);
            this.propertyGridEx1.DocCommentDescription.TabIndex = 1;
            this.propertyGridEx1.DocCommentImage = null;
            // 
            // 
            // 
            this.propertyGridEx1.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridEx1.DocCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.propertyGridEx1.DocCommentTitle.Location = new System.Drawing.Point(3, 3);
            this.propertyGridEx1.DocCommentTitle.Name = "";
            this.propertyGridEx1.DocCommentTitle.Size = new System.Drawing.Size(228, 15);
            this.propertyGridEx1.DocCommentTitle.TabIndex = 0;
            this.propertyGridEx1.DocCommentTitle.UseMnemonic = false;
            this.propertyGridEx1.Location = new System.Drawing.Point(12, 283);
            this.propertyGridEx1.Name = "propertyGridEx1";
            this.propertyGridEx1.SelectedObject = ((object)(resources.GetObject("propertyGridEx1.SelectedObject")));
            this.propertyGridEx1.ShowCustomProperties = true;
            this.propertyGridEx1.Size = new System.Drawing.Size(234, 249);
            this.propertyGridEx1.TabIndex = 17;
            this.propertyGridEx1.ToolbarVisible = false;
            // 
            // 
            // 
            this.propertyGridEx1.ToolStrip.AccessibleName = "ToolBar";
            this.propertyGridEx1.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.propertyGridEx1.ToolStrip.AllowMerge = false;
            this.propertyGridEx1.ToolStrip.AutoSize = false;
            this.propertyGridEx1.ToolStrip.CanOverflow = false;
            this.propertyGridEx1.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.propertyGridEx1.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.propertyGridEx1.ToolStrip.Location = new System.Drawing.Point(0, 1);
            this.propertyGridEx1.ToolStrip.Name = "";
            this.propertyGridEx1.ToolStrip.Padding = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.propertyGridEx1.ToolStrip.Size = new System.Drawing.Size(234, 25);
            this.propertyGridEx1.ToolStrip.TabIndex = 1;
            this.propertyGridEx1.ToolStrip.TabStop = true;
            this.propertyGridEx1.ToolStrip.Text = "PropertyGridToolBar";
            this.propertyGridEx1.ToolStrip.Visible = false;
            // 
            // TemplateCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 546);
            this.Controls.Add(this.propertyGridEx1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ImageScale);
            this.Controls.Add(this.ArtPosY);
            this.Controls.Add(this.ArtPosX);
            this.Controls.Add(this.ArtPositionSelector);
            this.Controls.Add(this.CardPreview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TemplateCreator";
            this.Text = "Template Creator";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CardPreview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private PositionSelector ArtPositionSelector;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown ArtPosX;
        private System.Windows.Forms.NumericUpDown ArtPosY;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTitleFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDescriptionFontToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown ImageScale;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private PropertyGridEx.PropertyGridEx propertyGridEx1;
    }
}

