namespace Hearts
{
    partial class PermFile
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
            this.rtbPerm = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbPerm
            // 
            this.rtbPerm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPerm.Location = new System.Drawing.Point(13, 13);
            this.rtbPerm.Name = "rtbPerm";
            this.rtbPerm.ReadOnly = true;
            this.rtbPerm.Size = new System.Drawing.Size(775, 425);
            this.rtbPerm.TabIndex = 0;
            this.rtbPerm.Text = "";
            // 
            // PermFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbPerm);
            this.Name = "PermFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermFile";
            this.Load += new System.EventHandler(this.PermFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPerm;
    }
}