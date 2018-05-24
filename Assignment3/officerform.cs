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
    public partial class officerform : Form
    {
        public officerform()
        {
            InitializeComponent();
        }

        private void officerform_Load(object sender, EventArgs e)
        {
            officerdatagridview.Columns.Add("Officer ID", "ID");
            officerdatagridview.Columns.Add("Officer Name", "Name");
            officerdatagridview.Columns.Add("Officer Skill Level", "Skill");
            officerdatagridview.Columns.Add("Ambulance ID", "Ambulance");
            using (TableContext db = new TableContext())
            {
                foreach (var record in db.StaffTable)
                {
                    officerdatagridview.Rows.Add(record.officer_id, record.first_names + " " + record.surname, record.skill_level, record.ambulance_id ?? "None");
                }
            }
            
        }

        private void officerbackbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenuform a = new mainmenuform();
            a.Closed += (s, args) => this.Close();
            a.ShowDialog();
        }

        private void officeraddbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addeditofficerform a = new addeditofficerform();
            a.Closed += (s, args) => this.Close();
            a.ShowDialog();
        }

        private void officerdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            foreach (DataGridViewCell cell in officerdatagridview.SelectedCells)
            {
                row = officerdatagridview.Rows[cell.RowIndex];
            }
            int officerid = Int32.Parse(row.Cells[0].Value.ToString());
            string fullname = row.Cells[1].Value.ToString();
            string[] fullnamelist = fullname.Split(' ');
            string surname = fullnamelist[fullnamelist.Length - 1];
            string[] firstnamelist = new string[fullnamelist.Length - 1];
            for (int i = 0; i < (fullnamelist.Length - 1); i++)
            {
                firstnamelist[i] += fullnamelist[i];
            }
            string firstname = String.Join(" ", firstnamelist);
            string skill = row.Cells[2].Value.ToString();
            string ambulanceid = row.Cells[3].Value.ToString();



            this.Hide();
            addeditofficerform a = new addeditofficerform(officerid, firstname, surname, skill, ambulanceid);
            a.Closed += (s, args) => this.Close();
            a.ShowDialog();
        }

        private void officertitle_Click(object sender, EventArgs e)
        {

        }

        private void officerdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
