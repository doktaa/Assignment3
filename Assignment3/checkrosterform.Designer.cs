namespace Assignment3
{
    partial class checkrosterform
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
            this.checkrostertitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkrostertitle
            // 
            this.checkrostertitle.BackColor = System.Drawing.Color.Transparent;
            this.checkrostertitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkrostertitle.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkrostertitle.Location = new System.Drawing.Point(0, 0);
            this.checkrostertitle.Name = "checkrostertitle";
            this.checkrostertitle.Size = new System.Drawing.Size(684, 100);
            this.checkrostertitle.TabIndex = 7;
            this.checkrostertitle.Text = "Check Rosters";
            this.checkrostertitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkrosterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.checkrostertitle);
            this.Name = "checkrosterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "checkrosterform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label checkrostertitle;
    }
}