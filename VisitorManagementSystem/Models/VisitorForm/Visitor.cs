using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitorManagementSystem.Models.VisitorForm
{
    public class Visitor
    {
        [Key]
        [Column("Id", Order = 0)]
        public int UserId { get; set; }

        [Column("RoleId", Order = 1)]
        public int RoleId { get; set; }

        [Column("VisitorName", Order = 2)]
        public string VisitorName { get; set; }

        [Column("Email", Order = 3)]
        public string Email { get; set; }

        [Column("MobileNumber", Order = 4)]
        public string MobileNumber { get; set; }

        [Column("VisitType", Order = 5)]
        public string VisitType { get; set; }

        [Column("WhomToMeet", Order = 6)]
        public string WhomToMeet { get; set; }

        [Column("CheckInTime", Order = 7)]
        public DateTime CheckInTime { get; set; }

        [Column("CheckOutTime", Order = 8)]
        public DateTime  CheckOutTime { get; set; }

        [Column("SecurityInCharge", Order = 9)]
        public string SecurityInCharge { get; set; }

        [Column("VisitorId", Order = 10)]
        public string VisitorId { get; set; }

        public DateTime modifiedOn { get; set; }
        public DateTime createdOn { get; set; }
        public string modifiedBy { get; set; }
        public string createdBy { get; set; }
    }
}
