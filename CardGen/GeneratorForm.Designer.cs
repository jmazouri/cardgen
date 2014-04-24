namespace CardGen
{
    partial class GeneratorForm
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
            this.CardPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CardName = new System.Windows.Forms.TextBox();
            this.CardDesc = new System.Windows.Forms.TextBox();
            this.ArtPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowseArt = new System.Windows.Forms.Button();
            this.BrowseOverlay = new System.Windows.Forms.Button();
            this.OverlayPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTitleFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDescriptionFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ArtPosX = new System.Windows.Forms.NumericUpDown();
            this.ArtPosY = new System.Windows.Forms.NumericUpDown();
            this.ImageScale = new System.Windows.Forms.NumericUpDown();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ArtPositionSelector = new CardGen.PositionSelector();
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScale)).BeginInit();
            this.SuspendLayout();
            // 
            // CardPreview
            // 
            this.CardPreview.Location = new System.Drawing.Point(346, 67);
            this.CardPreview.Name = "CardPreview";
            this.CardPreview.Size = new System.Drawing.Size(180, 250);
            this.CardPreview.TabIndex = 0;
            this.CardPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description Text";
            // 
            // CardName
            // 
            this.CardName.Location = new System.Drawing.Point(15, 43);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(285, 20);
            this.CardName.TabIndex = 3;
            this.CardName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CardDesc
            // 
            this.CardDesc.Location = new System.Drawing.Point(12, 160);
            this.CardDesc.Multiline = true;
            this.CardDesc.Name = "CardDesc";
            this.CardDesc.Size = new System.Drawing.Size(198, 167);
            this.CardDesc.TabIndex = 4;
            this.CardDesc.TextChanged += new System.EventHandler(this.CardDesc_TextChanged);
            // 
            // ArtPath
            // 
            this.ArtPath.Location = new System.Drawing.Point(15, 82);
            this.ArtPath.Name = "ArtPath";
            this.ArtPath.Size = new System.Drawing.Size(285, 20);
            this.ArtPath.TabIndex = 6;
            this.ArtPath.TextChanged += new System.EventHandler(this.ArtPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Art";
            // 
            // BrowseArt
            // 
            this.BrowseArt.Location = new System.Drawing.Point(306, 82);
            this.BrowseArt.Name = "BrowseArt";
            this.BrowseArt.Size = new System.Drawing.Size(30, 20);
            this.BrowseArt.TabIndex = 7;
            this.BrowseArt.Text = "...";
            this.BrowseArt.UseVisualStyleBackColor = true;
            this.BrowseArt.Click += new System.EventHandler(this.BrowseArt_Click);
            // 
            // BrowseOverlay
            // 
            this.BrowseOverlay.Location = new System.Drawing.Point(306, 121);
            this.BrowseOverlay.Name = "BrowseOverlay";
            this.BrowseOverlay.Size = new System.Drawing.Size(30, 20);
            this.BrowseOverlay.TabIndex = 10;
            this.BrowseOverlay.Text = "...";
            this.BrowseOverlay.UseVisualStyleBackColor = true;
            this.BrowseOverlay.Click += new System.EventHandler(this.BrowseOverlay_Click);
            // 
            // OverlayPath
            // 
            this.OverlayPath.Location = new System.Drawing.Point(15, 121);
            this.OverlayPath.Name = "OverlayPath";
            this.OverlayPath.Size = new System.Drawing.Size(285, 20);
            this.OverlayPath.TabIndex = 9;
            this.OverlayPath.TextChanged += new System.EventHandler(this.OverlayPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Front Overlay";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
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
            this.setTitleFontToolStripMenuItem.Text = "Set Title Font";
            this.setTitleFontToolStripMenuItem.Click += new System.EventHandler(this.setTitleFontToolStripMenuItem_Click);
            // 
            // setDescriptionFontToolStripMenuItem
            // 
            this.setDescriptionFontToolStripMenuItem.Name = "setDescriptionFontToolStripMenuItem";
            this.setDescriptionFontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDescriptionFontToolStripMenuItem.Text = "Set Description Font";
            this.setDescriptionFontToolStripMenuItem.Click += new System.EventHandler(this.setDescriptionFontToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Bitmap files|*.bmp|Jpeg Files|*.jpg,*.jpeg|PNG Files|*.png|All files|*.*";
            this.openFileDialog1.FilterIndex = 4;
            // 
            // ArtPosX
            // 
            this.ArtPosX.Location = new System.Drawing.Point(198, 333);
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
            this.ArtPosX.Size = new System.Drawing.Size(40, 20);
            this.ArtPosX.TabIndex = 13;
            this.ArtPosX.ValueChanged += new System.EventHandler(this.ArtPosX_ValueChanged);
            // 
            // ArtPosY
            // 
            this.ArtPosY.Location = new System.Drawing.Point(249, 333);
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
            this.ArtPosY.Size = new System.Drawing.Size(40, 20);
            this.ArtPosY.TabIndex = 14;
            this.ArtPosY.ValueChanged += new System.EventHandler(this.ArtPosY_ValueChanged);
            // 
            // ImageScale
            // 
            this.ImageScale.DecimalPlaces = 2;
            this.ImageScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ImageScale.Location = new System.Drawing.Point(303, 333);
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
            this.ImageScale.Size = new System.Drawing.Size(52, 20);
            this.ImageScale.TabIndex = 15;
            this.ImageScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ImageScale.ValueChanged += new System.EventHandler(this.ImageScale_ValueChanged);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG File|*.png|All files|*.*";
            // 
            // ArtPositionSelector
            // 
            this.ArtPositionSelector.ExactPosition = new System.Drawing.Point(55, 70);
            this.ArtPositionSelector.ImageSize = 1D;
            this.ArtPositionSelector.Location = new System.Drawing.Point(216, 160);
            this.ArtPositionSelector.Name = "ArtPositionSelector";
            this.ArtPositionSelector.Size = new System.Drawing.Size(120, 167);
            this.ArtPositionSelector.TabIndex = 12;
            this.ArtPositionSelector.OnChange += new CardGen.PositionSelector.myDataChangedDelegate(this.ArtPositionSelector_OnChange);
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 367);
            this.Controls.Add(this.ImageScale);
            this.Controls.Add(this.ArtPosY);
            this.Controls.Add(this.ArtPosX);
            this.Controls.Add(this.ArtPositionSelector);
            this.Controls.Add(this.BrowseOverlay);
            this.Controls.Add(this.OverlayPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BrowseArt);
            this.Controls.Add(this.ArtPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CardDesc);
            this.Controls.Add(this.CardName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardPreview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeneratorForm";
            this.Text = "C9TD Card Generator";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.TextBox CardDesc;
        private System.Windows.Forms.TextBox ArtPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowseArt;
        private System.Windows.Forms.Button BrowseOverlay;
        private System.Windows.Forms.TextBox OverlayPath;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

