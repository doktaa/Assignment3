namespace Assignment3
{
    partial class officerform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.officertitle = new System.Windows.Forms.Label();
            this.officerdatagridview = new System.Windows.Forms.DataGridView();
            this.officerbackbutton = new System.Windows.Forms.Button();
            this.officeraddbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.officerdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // officertitle
            // 
            this.officertitle.BackColor = System.Drawing.Color.Transparent;
            this.officertitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.officertitle.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officertitle.Location = new System.Drawing.Point(0, 0);
            this.officertitle.Name = "officertitle";
            this.officertitle.Size = new System.Drawing.Size(684, 100);
            this.officertitle.TabIndex = 2;
            this.officertitle.Text = "Ambulance Officers";
            this.officertitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.officertitle.Click += new System.EventHandler(this.officertitle_Click);
            // 
            // officerdatagridview
            // 
            this.officerdatagridview.AllowUserToAddRows = false;
            this.officerdatagridview.AllowUserToDeleteRows = false;
            this.officerdatagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.officerdatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.officerdatagridview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.officerdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.officerdatagridview.BackgroundColor = System.Drawing.Color.White;
            this.officerdatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.officerdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officerdatagridview.GridColor = System.Drawing.Color.White;
            this.officerdatagridview.Location = new System.Drawing.Point(46, 103);
            this.officerdatagridview.MultiSelect = false;
            this.officerdatagridview.Name = "officerdatagridview";
            this.officerdatagridview.ReadOnly = true;
            this.officerdatagridview.RowHeadersVisible = false;
            this.officerdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.officerdatagridview.Size = new System.Drawing.Size(593, 170);
            this.officerdatagridview.TabIndex = 3;
            this.officerdatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.officerdatagridview_CellClick);
            this.officerdatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.officerdatagridview_CellContentClick);
            // 
            // officerbackbutton
            // 
            this.officerbackbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.officerbackbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.officerbackbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.officerbackbutton.FlatAppearance.BorderSize = 2;
            this.officerbackbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officerbackbutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officerbackbutton.Location = new System.Drawing.Point(46, 308);
            this.officerbackbutton.Name = "officerbackbutton";
            this.officerbackbutton.Size = new System.Drawing.Size(284, 50);
            this.officerbackbutton.TabIndex = 4;
            this.officerbackbutton.Text = "Back";
            this.officerbackbutton.UseVisualStyleBackColor = false;
            this.officerbackbutton.Click += new System.EventHandler(this.officerbackbutton_Click);
            // 
            // officeraddbutton
            // 
            this.officeraddbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.officeraddbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.officeraddbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.officeraddbutton.FlatAppearance.BorderSize = 2;
            this.officeraddbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officeraddbutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeraddbutton.Location = new System.Drawing.Point(355, 308);
            this.officeraddbutton.Name = "officeraddbutton";
            this.officeraddbutton.Size = new System.Drawing.Size(284, 50);
            this.officeraddbutton.TabIndex = 5;
            this.officeraddbutton.Text = "Add New";
            this.officeraddbutton.UseVisualStyleBackColor = false;
            this.officeraddbutton.Click += new System.EventHandler(this.officeraddbutton_Click);
            // 
            // officerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.officeraddbutton);
            this.Controls.Add(this.officerbackbutton);
            this.Controls.Add(this.officerdatagridview);
            this.Controls.Add(this.officertitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "officerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ambulance Staff Rostering System";
            this.Load += new System.EventHandler(this.officerform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officerdatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label officertitle;
        private System.Windows.Forms.DataGridView officerdatagridview;
        private System.Windows.Forms.Button officerbackbutton;
        private System.Windows.Forms.Button officeraddbutton;
    }
}