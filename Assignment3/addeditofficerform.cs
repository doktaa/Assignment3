using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class addeditofficerform : Form
    {
        private string ambulanceid;
        private string firstname;
        private int officerid;
        private string skill;
        private string surname;

        public addeditofficerform()
        {
            InitializeComponent();

            //add valid ambulances to combo box
            List<string> ambucomboitems = new List<string>();

            using (TableContext db = new TableContext())
            {
                foreach (var record in db.AmbulanceTable)
                {
                    
                    ambucomboitems.Add(record.ambulance_id);
                    
                }
            }
            foreach(var item in ambucomboitems)
            {
                if (item != null)
                {
                    ambulancecombobox.Items.Add(item);
                }
            }



        }

        //Constructor for a row click add edit officer form
        public addeditofficerform(int officerid, string firstname, string surname, string skill, string ambulanceid)
        {
            InitializeComponent();

            this.officerid = officerid;
            this.firstname = firstname;
            this.surname = surname;
            this.skill = skill;
            this.ambulanceid = ambulanceid;
            if (ambulanceid == null)
            {
                ambulanceid = "None";
            }

            
            //add valid ambulances to combo box
            List<string> ambucomboitems = new List<string>();

            using (TableContext db = new TableContext())
            {
                foreach (var record in db.AmbulanceTable)
                {

                    ambucomboitems.Add(record.ambulance_id);

                }
            }
            foreach (var item in ambucomboitems)
            {
                if (item != null)
                {
                    ambulancecombobox.Items.Add(item);
                }
            }

            //declaring strings and int for data to be put as default values
            firstnametextbox.Text = firstname;
            surnametextbox.Text = surname;
            officeridtextbox.Text = officerid.ToString();
            skillcombobox.SelectedItem = skill;
            ambulancecombobox.SelectedItem = ambulanceid;
        }

        private void addeditofficercancelbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            officerform a = new officerform();
            a.Closed += (s, args) => this.Close();
            a.ShowDialog();
        }

        private void addeditofficersavebutton_Click(object sender, EventArgs e)
        {
            //START VALIDATING ALL THE VALUES
            int offidvalue;
            StaffMember stafftosave = new StaffMember();
            List<string> validofficers = new List<string>();
            //vaidate first name
            if (firstnametextbox.Text.Length == 0)
            {
                MessageBox.Show("'First Names' is a required field");
            }
            else if (surnametextbox.Text.Length == 0)
            {
                MessageBox.Show("'Surname' is a required field");
            }
            else if (!int.TryParse(officeridtextbox.Text, out offidvalue) && (officeridtextbox.Text.Length == 6))
            {
                MessageBox.Show("Officer ID must be a six digit number");
            }
            else if (skillcombobox.SelectedItem == null)
            {
                MessageBox.Show("A skill level must be selected");
            }
            else if (ambulancecombobox.SelectedItem == null)
            {
                MessageBox.Show("An ambulance must be selected");
            }
            else
            {
                using (TableContext db = new TableContext())
                {
                    foreach(var record in db.StaffTable)
                    {
                        if (record.officer_id == offidvalue){
                            stafftosave = record;
                        }
                    }

                    if (stafftosave == null)
                    {
                        //Add a new record
                        StaffMember a = new StaffMember { officer_id = offidvalue, first_names = firstnametextbox.Text, surname = surnametextbox.Text, skill_level = skillcombobox.SelectedItem.ToString(), ambulance_id = ambulancecombobox.SelectedItem.ToString() };
                        db.StaffTable.Add(a);
                    }
                    else
                    {
                        //Update a record

                        stafftosave.officer_id = offidvalue;
                        stafftosave.first_names = firstnametextbox.Text;
                        stafftosave.surname = surnametextbox.Text;
                        stafftosave.skill_level = skillcombobox.SelectedItem.ToString();
                        stafftosave.ambulance_id = ambulancecombobox.SelectedItem.ToString();

                    }

                    
                    db.SaveChanges();

                    this.Hide();
                    officerform form = new officerform();
                    form.Closed += (s, args) => this.Close();
                    form.ShowDialog();
                }
            }
        }
    }
}
