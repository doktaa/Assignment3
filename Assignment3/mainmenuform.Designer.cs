namespace Assignment3
{
    partial class mainmenuform
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
            this.mainmenutitle = new System.Windows.Forms.Label();
            this.officerbutton = new System.Windows.Forms.Button();
            this.ambulancebutton = new System.Windows.Forms.Button();
            this.checkrosterbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainmenutitle
            // 
            this.mainmenutitle.BackColor = System.Drawing.Color.Transparent;
            this.mainmenutitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainmenutitle.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenutitle.ForeColor = System.Drawing.Color.Black;
            this.mainmenutitle.Location = new System.Drawing.Point(0, 0);
            this.mainmenutitle.Name = "mainmenutitle";
            this.mainmenutitle.Size = new System.Drawing.Size(684, 112);
            this.mainmenutitle.TabIndex = 1;
            this.mainmenutitle.Text = "Ambulance Staff Rostering System";
            this.mainmenutitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainmenutitle.Click += new System.EventHandler(this.mainmenutitle_Click);
            // 
            // officerbutton
            // 
            this.officerbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.officerbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.officerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.officerbutton.FlatAppearance.BorderSize = 2;
            this.officerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.officerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officerbutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officerbutton.Location = new System.Drawing.Point(192, 126);
            this.officerbutton.Name = "officerbutton";
            this.officerbutton.Size = new System.Drawing.Size(300, 50);
            this.officerbutton.TabIndex = 2;
            this.officerbutton.Text = "Officers";
            this.officerbutton.UseVisualStyleBackColor = false;
            this.officerbutton.Click += new System.EventHandler(this.officerbutton_Click);
            // 
            // ambulancebutton
            // 
            this.ambulancebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ambulancebutton.BackColor = System.Drawing.Color.AliceBlue;
            this.ambulancebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ambulancebutton.FlatAppearance.BorderSize = 2;
            this.ambulancebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ambulancebutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulancebutton.Location = new System.Drawing.Point(192, 192);
            this.ambulancebutton.Name = "ambulancebutton";
            this.ambulancebutton.Size = new System.Drawing.Size(300, 50);
            this.ambulancebutton.TabIndex = 3;
            this.ambulancebutton.Text = "Ambulances";
            this.ambulancebutton.UseVisualStyleBackColor = false;
            this.ambulancebutton.Click += new System.EventHandler(this.ambulancebutton_Click);
            // 
            // checkrosterbutton
            // 
            this.checkrosterbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkrosterbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.checkrosterbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkrosterbutton.FlatAppearance.BorderSize = 2;
            this.checkrosterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkrosterbutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkrosterbutton.Location = new System.Drawing.Point(192, 258);
            this.checkrosterbutton.Name = "checkrosterbutton";
            this.checkrosterbutton.Size = new System.Drawing.Size(300, 50);
            this.checkrosterbutton.TabIndex = 4;
            this.checkrosterbutton.Text = "Check Rosters";
            this.checkrosterbutton.UseVisualStyleBackColor = false;
            this.checkrosterbutton.Click += new System.EventHandler(this.checkrosterbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.exitbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitbutton.FlatAppearance.BorderSize = 2;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(192, 324);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(300, 50);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // mainmenuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.checkrosterbutton);
            this.Controls.Add(this.ambulancebutton);
            this.Controls.Add(this.officerbutton);
            this.Controls.Add(this.mainmenutitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainmenuform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambulance Staff Rostering System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label mainmenutitle;
        private System.Windows.Forms.Button officerbutton;
        private System.Windows.Forms.Button ambulancebutton;
        private System.Windows.Forms.Button checkrosterbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

