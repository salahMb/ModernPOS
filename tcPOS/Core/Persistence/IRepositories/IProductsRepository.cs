using DAL.Core;
using DAL.Data;
using System.Collections.Generic;

namespace Core.Persistence.Repositories
{
    public interface IProductsRepository : IRepository<Product>
    {
        //all sould return IEnumerable OR void
        //Custom function add it here

        //User GetUserDetails(string userName);
        //IEnumerable<User> GetPagedResultForQuery(int pageIndex, int pageSize);
        //int GetNumberOfPages();
        //bool IsActiveDirectoryUser(string UserName);
    }
}