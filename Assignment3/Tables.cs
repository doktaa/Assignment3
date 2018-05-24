using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment3
{
    public class TableContext : DbContext
    {
        public TableContext() : base("MySqlConnection") { }
        public DbSet<StaffMember> StaffTable { get; set; }
        public DbSet<Ambulance> AmbulanceTable { get; set; }
    }

    [Table("staffmember")]
    public class StaffMember
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int officer_id { get; set; }
        public string first_names { get; set; }
        public string surname { get; set; }
        public string skill_level { get; set; }
        public string ambulance_id { get; set; }
    }

    [Table("ambulance")]
    public class Ambulance
    {
        [Key]
        public string ambulance_id { get; set; }
        public string station { get; set; }
    }
}