namespace UnitOfShop.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
         void Commit();
         void RollBack();
    }
    
}