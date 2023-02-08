using Microsoft.EntityFrameworkCore;
using System.Configuration;
using VisitorManagementSystem.Database;
using VisitorManagementSystem.Models.VisitorForm;

namespace VisitorManagementSystem.BusinessLogic
{
    public class VisitorsBL : IVisitorsBL
    {
      
        public readonly CatalogDBContext _context;
        public VisitorsBL(CatalogDBContext context)
        {
            _context = context;
        }

        public async Task<List<Visitor>> GetAllVisitor()
        {
            return _context.Visitor.ToList();
        }

        public async Task<bool> AddVisitor(Visitor visitor)
        {
            bool value = false;
            Visitor values = new Visitor();
            if (visitor != null)
            {
                values.RoleId = 1;
                values.VisitorName = visitor.VisitorName;
                values.Email = visitor.Email;
                values.MobileNumber= visitor.MobileNumber;
                values.VisitType= visitor.VisitType;
                values.WhomToMeet= visitor.WhomToMeet;
                values.CheckInTime= DateTime.UtcNow; ;
                values.CheckOutTime= DateTime.UtcNow;
                values.SecurityInCharge= visitor.SecurityInCharge;
                values.VisitorId = visitor.VisitorId;
                values.createdBy = values.RoleId == 1 ?  visitor.VisitorName : visitor.SecurityInCharge;
                values.createdOn = DateTime.UtcNow;
                values.modifiedBy = visitor.SecurityInCharge;
                values.modifiedOn = DateTime.UtcNow;
                _context.Visitor.Add(values);
                _context.SaveChanges();
                value= true;
            }  
            return value;
        }

        public async Task<bool> UpdateVisitor(Visitor visitor)
        {
            bool value = false;
            if (visitor != null)
            {
                var data = _context.Visitor.FirstOrDefault(x => x.UserId == visitor.UserId);
                Visitor result = new Visitor();
                if (data != null)
                {                    
                    result.VisitorName = data.VisitorName;
                    result.Email = data.Email;
                    result.MobileNumber = data.MobileNumber;
                    result.VisitType = data.VisitType;
                    result.WhomToMeet = data.WhomToMeet;
                    result.VisitorId = data.VisitorId;
                    _context.Visitor.Update(result);
                    _context.SaveChanges();
                    value = true;
                }
            }
            return value;
        }

    }
}




