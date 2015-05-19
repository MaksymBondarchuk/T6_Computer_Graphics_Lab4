namespace Computer_Graphics_Lab4
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
            this.bBuild = new System.Windows.Forms.Button();
            this.rbKoch = new System.Windows.Forms.RadioButton();
            this.rbSerpinsli = new System.Windows.Forms.RadioButton();
            this.rbMandelbrot = new System.Windows.Forms.RadioButton();
            this.rank = new System.Windows.Forms.NumericUpDown();
            this.bClear = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.warning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lRank = new System.Windows.Forms.Label();
            this.pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // bBuild
            // 
            this.bBuild.Location = new System.Drawing.Point(10, 137);
            this.bBuild.Name = "bBuild";
            this.bBuild.Size = new System.Drawing.Size(75, 23);
            this.bBuild.TabIndex = 3;
            this.bBuild.Text = "Build";
            this.bBuild.UseVisualStyleBackColor = true;
            this.bBuild.Click += new System.EventHandler(this.bBuild_Click);
            // 
            // rbKoch
            // 
            this.rbKoch.AutoSize = true;
            this.rbKoch.Location = new System.Drawing.Point(10, 33);
            this.rbKoch.Name = "rbKoch";
            this.rbKoch.Size = new System.Drawing.Size(50, 17);
            this.rbKoch.TabIndex = 4;
            this.rbKoch.Text = "Koch";
            this.rbKoch.UseVisualStyleBackColor = true;
            this.rbKoch.CheckedChanged += new System.EventHandler(this.rbKoch_CheckedChanged);
            // 
            // rbSerpinsli
            // 
            this.rbSerpinsli.AutoSize = true;
            this.rbSerpinsli.Location = new System.Drawing.Point(150, 33);
            this.rbSerpinsli.Name = "rbSerpinsli";
            this.rbSerpinsli.Size = new System.Drawing.Size(64, 17);
            this.rbSerpinsli.TabIndex = 5;
            this.rbSerpinsli.Text = "Serpinsli";
            this.rbSerpinsli.UseVisualStyleBackColor = true;
            this.rbSerpinsli.CheckedChanged += new System.EventHandler(this.rbKoch_CheckedChanged);
            // 
            // rbMandelbrot
            // 
            this.rbMandelbrot.AutoSize = true;
            this.rbMandelbrot.Checked = true;
            this.rbMandelbrot.Location = new System.Drawing.Point(66, 33);
            this.rbMandelbrot.Name = "rbMandelbrot";
            this.rbMandelbrot.Size = new System.Drawing.Size(78, 17);
            this.rbMandelbrot.TabIndex = 6;
            this.rbMandelbrot.TabStop = true;
            this.rbMandelbrot.Text = "Mandelbrot";
            this.rbMandelbrot.UseVisualStyleBackColor = true;
            this.rbMandelbrot.CheckedChanged += new System.EventHandler(this.rbMandelbrot_CheckedChanged);
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(10, 89);
            this.rank.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(120, 20);
            this.rank.TabIndex = 7;
            this.rank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rank.ValueChanged += new System.EventHandler(this.rank_ValueChanged);
            // 
            // bClear
            // 
            this.bClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClear.Location = new System.Drawing.Point(91, 137);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(172, 137);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "BitMap files (*.bmp)|*.*";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(7, 112);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(401, 13);
            this.warning.TabIndex = 10;
            this.warning.Text = "Build time may be very long. Your computer may freeze. May be stack overflow erro" +
    "r";
            this.warning.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Algorithm";
            // 
            // lRank
            // 
            this.lRank.AutoSize = true;
            this.lRank.Location = new System.Drawing.Point(7, 72);
            this.lRank.Name = "lRank";
            this.lRank.Size = new System.Drawing.Size(70, 13);
            this.lRank.TabIndex = 12;
            this.lRank.Text = "Fractal\'s rank";
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.Color.Transparent;
            this.pbox.Location = new System.Drawing.Point(0, 0);
            this.pbox.Margin = new System.Windows.Forms.Padding(0);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(50, 50);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox.TabIndex = 2;
            this.pbox.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.bBuild;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.bClear;
            this.ClientSize = new System.Drawing.Size(1568, 781);
            this.Controls.Add(this.lRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.rbMandelbrot);
            this.Controls.Add(this.rbSerpinsli);
            this.Controls.Add(this.rbKoch);
            this.Controls.Add(this.bBuild);
            this.Controls.Add(this.pbox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Graphics Lab4. Fractals";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuild;
        private System.Windows.Forms.RadioButton rbKoch;
        private System.Windows.Forms.RadioButton rbSerpinsli;
        private System.Windows.Forms.RadioButton rbMandelbrot;
        private System.Windows.Forms.NumericUpDown rank;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lRank;
        private System.Windows.Forms.PictureBox pbox;
    }
}

