namespace Assignment3
{
    partial class addeditofficerform
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
            this.addeditofficertitle = new System.Windows.Forms.Label();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.surnamelabel = new System.Windows.Forms.Label();
            this.officeridlabel = new System.Windows.Forms.Label();
            this.skilllabel = new System.Windows.Forms.Label();
            this.ambulanceidlabel = new System.Windows.Forms.Label();
            this.skillcombobox = new System.Windows.Forms.ComboBox();
            this.ambulancecombobox = new System.Windows.Forms.ComboBox();
            this.firstnametextbox = new System.Windows.Forms.TextBox();
            this.surnametextbox = new System.Windows.Forms.TextBox();
            this.officeridtextbox = new System.Windows.Forms.TextBox();
            this.addeditofficercancelbutton = new System.Windows.Forms.Button();
            this.addeditofficersavebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addeditofficertitle
            // 
            this.addeditofficertitle.BackColor = System.Drawing.Color.Transparent;
            this.addeditofficertitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.addeditofficertitle.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addeditofficertitle.Location = new System.Drawing.Point(0, 0);
            this.addeditofficertitle.Name = "addeditofficertitle";
            this.addeditofficertitle.Size = new System.Drawing.Size(684, 100);
            this.addeditofficertitle.TabIndex = 3;
            this.addeditofficertitle.Text = "Placeholder";
            this.addeditofficertitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel.Location = new System.Drawing.Point(104, 100);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(117, 24);
            this.firstnamelabel.TabIndex = 4;
            this.firstnamelabel.Text = "First Names:";
            // 
            // surnamelabel
            // 
            this.surnamelabel.AutoSize = true;
            this.surnamelabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamelabel.Location = new System.Drawing.Point(104, 147);
            this.surnamelabel.Name = "surnamelabel";
            this.surnamelabel.Size = new System.Drawing.Size(90, 24);
            this.surnamelabel.TabIndex = 5;
            this.surnamelabel.Text = "Surname:";
            // 
            // officeridlabel
            // 
            this.officeridlabel.AutoSize = true;
            this.officeridlabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeridlabel.Location = new System.Drawing.Point(104, 191);
            this.officeridlabel.Name = "officeridlabel";
            this.officeridlabel.Size = new System.Drawing.Size(98, 24);
            this.officeridlabel.TabIndex = 6;
            this.officeridlabel.Text = "Officer ID:";
            // 
            // skilllabel
            // 
            this.skilllabel.AutoSize = true;
            this.skilllabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skilllabel.Location = new System.Drawing.Point(104, 236);
            this.skilllabel.Name = "skilllabel";
            this.skilllabel.Size = new System.Drawing.Size(105, 24);
            this.skilllabel.TabIndex = 7;
            this.skilllabel.Text = "Skill Level:";
            // 
            // ambulanceidlabel
            // 
            this.ambulanceidlabel.AutoSize = true;
            this.ambulanceidlabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulanceidlabel.Location = new System.Drawing.Point(104, 281);
            this.ambulanceidlabel.Name = "ambulanceidlabel";
            this.ambulanceidlabel.Size = new System.Drawing.Size(110, 24);
            this.ambulanceidlabel.TabIndex = 8;
            this.ambulanceidlabel.Text = "Ambulance:";
            // 
            // skillcombobox
            // 
            this.skillcombobox.BackColor = System.Drawing.SystemColors.Window;
            this.skillcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillcombobox.FormattingEnabled = true;
            this.skillcombobox.Items.AddRange(new object[] {
            "Basic",
            "Intermediate",
            "Advanced"});
            this.skillcombobox.Location = new System.Drawing.Point(224, 239);
            this.skillcombobox.Name = "skillcombobox";
            this.skillcombobox.Size = new System.Drawing.Size(352, 21);
            this.skillcombobox.TabIndex = 9;
            // 
            // ambulancecombobox
            // 
            this.ambulancecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ambulancecombobox.FormattingEnabled = true;
            this.ambulancecombobox.Items.AddRange(new object[] {
            "None"});
            this.ambulancecombobox.Location = new System.Drawing.Point(224, 284);
            this.ambulancecombobox.Name = "ambulancecombobox";
            this.ambulancecombobox.Size = new System.Drawing.Size(352, 21);
            this.ambulancecombobox.TabIndex = 10;
            // 
            // firstnametextbox
            // 
            this.firstnametextbox.Location = new System.Drawing.Point(224, 103);
            this.firstnametextbox.Name = "firstnametextbox";
            this.firstnametextbox.Size = new System.Drawing.Size(352, 20);
            this.firstnametextbox.TabIndex = 11;
            // 
            // surnametextbox
            // 
            this.surnametextbox.Location = new System.Drawing.Point(224, 150);
            this.surnametextbox.Name = "surnametextbox";
            this.surnametextbox.Size = new System.Drawing.Size(352, 20);
            this.surnametextbox.TabIndex = 12;
            // 
            // officeridtextbox
            // 
            this.officeridtextbox.Location = new System.Drawing.Point(224, 194);
            this.officeridtextbox.Name = "officeridtextbox";
            this.officeridtextbox.Size = new System.Drawing.Size(352, 20);
            this.officeridtextbox.TabIndex = 13;
            // 
            // addeditofficercancelbutton
            // 
            this.addeditofficercancelbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addeditofficercancelbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.addeditofficercancelbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addeditofficercancelbutton.FlatAppearance.BorderSize = 2;
            this.addeditofficercancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addeditofficercancelbutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addeditofficercancelbutton.Location = new System.Drawing.Point(108, 337);
            this.addeditofficercancelbutton.Name = "addeditofficercancelbutton";
            this.addeditofficercancelbutton.Size = new System.Drawing.Size(237, 50);
            this.addeditofficercancelbutton.TabIndex = 14;
            this.addeditofficercancelbutton.Text = "Cancel";
            this.addeditofficercancelbutton.UseVisualStyleBackColor = false;
            this.addeditofficercancelbutton.Click += new System.EventHandler(this.addeditofficercancelbutton_Click);
            // 
            // addeditofficersavebutton
            // 
            this.addeditofficersavebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addeditofficersavebutton.BackColor = System.Drawing.Color.AliceBlue;
            this.addeditofficersavebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addeditofficersavebutton.FlatAppearance.BorderSize = 2;
            this.addeditofficersavebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addeditofficersavebutton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addeditofficersavebutton.Location = new System.Drawing.Point(351, 337);
            this.addeditofficersavebutton.Name = "addeditofficersavebutton";
            this.addeditofficersavebutton.Size = new System.Drawing.Size(225, 50);
            this.addeditofficersavebutton.TabIndex = 15;
            this.addeditofficersavebutton.Text = "Save";
            this.addeditofficersavebutton.UseVisualStyleBackColor = false;
            this.addeditofficersavebutton.Click += new System.EventHandler(this.addeditofficersavebutton_Click);
            // 
            // addeditofficerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.addeditofficersavebutton);
            this.Controls.Add(this.addeditofficercancelbutton);
            this.Controls.Add(this.officeridtextbox);
            this.Controls.Add(this.surnametextbox);
            this.Controls.Add(this.firstnametextbox);
            this.Controls.Add(this.ambulancecombobox);
            this.Controls.Add(this.skillcombobox);
            this.Controls.Add(this.ambulanceidlabel);
            this.Controls.Add(this.skilllabel);
            this.Controls.Add(this.officeridlabel);
            this.Controls.Add(this.surnamelabel);
            this.Controls.Add(this.firstnamelabel);
            this.Controls.Add(this.addeditofficertitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addeditofficerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ambulance Staff Rostering System";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addeditofficertitle;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.Label surnamelabel;
        private System.Windows.Forms.Label officeridlabel;
        private System.Windows.Forms.Label skilllabel;
        private System.Windows.Forms.Label ambulanceidlabel;
        private System.Windows.Forms.ComboBox skillcombobox;
        private System.Windows.Forms.ComboBox ambulancecombobox;
        private System.Windows.Forms.TextBox firstnametextbox;
        private System.Windows.Forms.TextBox surnametextbox;
        private System.Windows.Forms.TextBox officeridtextbox;
        private System.Windows.Forms.Button addeditofficercancelbutton;
        private System.Windows.Forms.Button addeditofficersavebutton;
    }
}