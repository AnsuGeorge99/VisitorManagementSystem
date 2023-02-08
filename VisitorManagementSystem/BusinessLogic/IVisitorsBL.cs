using VisitorManagementSystem.Models.VisitorForm;

namespace VisitorManagementSystem.BusinessLogic
{
    public interface IVisitorsBL
    {
        Task<List<Visitor>> GetAllVisitor();
        Task<bool> AddVisitor(Visitor visitor);
        Task<bool> UpdateVisitor(Visitor visitor);
    }
}
