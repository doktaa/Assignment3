namespace Assignment3
{
    partial class ambulanceform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ambulanceaddbutton = new System.Windows.Forms.Button();
            this.ambulancebackbutton = new System.Windows.Forms.Button();
            this.ambulancedatagridview = new System.Windows.Forms.DataGridView();
            this.ambulancetitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ambulancedatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ambulanceaddbutton
            // 
            this.ambulanceaddbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ambulanceaddbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.ambulanceaddbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ambulanceaddbutton.FlatAppearance.BorderSize = 2;
            this.ambulanceaddbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ambulanceaddbutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulanceaddbutton.Location = new System.Drawing.Point(355, 308);
            this.ambulanceaddbutton.Name = "ambulanceaddbutton";
            this.ambulanceaddbutton.Size = new System.Drawing.Size(284, 50);
            this.ambulanceaddbutton.TabIndex = 9;
            this.ambulanceaddbutton.Text = "Add New";
            this.ambulanceaddbutton.UseVisualStyleBackColor = false;
            // 
            // ambulancebackbutton
            // 
            this.ambulancebackbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ambulancebackbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.ambulancebackbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ambulancebackbutton.FlatAppearance.BorderSize = 2;
            this.ambulancebackbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ambulancebackbutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulancebackbutton.Location = new System.Drawing.Point(46, 308);
            this.ambulancebackbutton.Name = "ambulancebackbutton";
            this.ambulancebackbutton.Size = new System.Drawing.Size(284, 50);
            this.ambulancebackbutton.TabIndex = 8;
            this.ambulancebackbutton.Text = "Back";
            this.ambulancebackbutton.UseVisualStyleBackColor = false;
            // 
            // ambulancedatagridview
            // 
            this.ambulancedatagridview.AllowUserToAddRows = false;
            this.ambulancedatagridview.AllowUserToDeleteRows = false;
            this.ambulancedatagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ambulancedatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ambulancedatagridview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ambulancedatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ambulancedatagridview.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ambulancedatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ambulancedatagridview.Location = new System.Drawing.Point(46, 103);
            this.ambulancedatagridview.Name = "ambulancedatagridview";
            this.ambulancedatagridview.RowHeadersVisible = false;
            this.ambulancedatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ambulancedatagridview.Size = new System.Drawing.Size(593, 170);
            this.ambulancedatagridview.TabIndex = 7;
            // 
            // ambulancetitle
            // 
            this.ambulancetitle.BackColor = System.Drawing.Color.Transparent;
            this.ambulancetitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ambulancetitle.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulancetitle.Location = new System.Drawing.Point(0, 0);
            this.ambulancetitle.Name = "ambulancetitle";
            this.ambulancetitle.Size = new System.Drawing.Size(684, 100);
            this.ambulancetitle.TabIndex = 6;
            this.ambulancetitle.Text = "Ambulances";
            this.ambulancetitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ambulanceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.ambulanceaddbutton);
            this.Controls.Add(this.ambulancebackbutton);
            this.Controls.Add(this.ambulancedatagridview);
            this.Controls.Add(this.ambulancetitle);
            this.Name = "ambulanceform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ambulanceform";
            ((System.ComponentModel.ISupportInitialize)(this.ambulancedatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ambulanceaddbutton;
        private System.Windows.Forms.Button ambulancebackbutton;
        private System.Windows.Forms.DataGridView ambulancedatagridview;
        private System.Windows.Forms.Label ambulancetitle;
    }
}