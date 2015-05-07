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
            this.pbox = new System.Windows.Forms.PictureBox();
            this.bBuild = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.Color.Gainsboro;
            this.pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox.Location = new System.Drawing.Point(12, 12);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(1000, 300);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox.TabIndex = 2;
            this.pbox.TabStop = false;
            // 
            // bBuild
            // 
            this.bBuild.Location = new System.Drawing.Point(920, 443);
            this.bBuild.Name = "bBuild";
            this.bBuild.Size = new System.Drawing.Size(75, 23);
            this.bBuild.TabIndex = 3;
            this.bBuild.Text = "Build";
            this.bBuild.UseVisualStyleBackColor = true;
            this.bBuild.Click += new System.EventHandler(this.bBuild_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1040, 498);
            this.Controls.Add(this.bBuild);
            this.Controls.Add(this.pbox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Button bBuild;
    }
}

