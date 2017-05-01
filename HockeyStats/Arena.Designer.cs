using System;

namespace HockeyStats
{
    partial class Arena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arena));
            this.RinkBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RinkBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // RinkBackground
            // 
            this.RinkBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RinkBackground.Image = ((System.Drawing.Image)(resources.GetObject("RinkBackground.Image")));
            this.RinkBackground.Location = new System.Drawing.Point(0, 0);
            this.RinkBackground.Name = "RinkBackground";
            this.RinkBackground.Size = new System.Drawing.Size(1222, 630);
            this.RinkBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RinkBackground.TabIndex = 0;
            this.RinkBackground.TabStop = false;
            this.RinkBackground.Click += new System.EventHandler(this.RinkBackground_Click);
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 628);
            this.Controls.Add(this.RinkBackground);
            this.Name = "Arena";
            this.Text = "HockeyStats";
            this.Load += new System.EventHandler(this.Arena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RinkBackground)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox RinkBackground;
    }
}

