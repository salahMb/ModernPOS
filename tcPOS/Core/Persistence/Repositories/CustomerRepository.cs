using DAL.Core;
using DAL.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;

namespace Core.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(POSEntities context)
            : base(context)
        {
        }
        //public bool IsActiveDirectoryUser(string UserName)
        //{
        //    bool ret = false;

        //    using (var context = new PrincipalContext(ContextType.Domain, "dammam.gov.sa"))
        //    {
        //        using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
        //        {
        //            UserPrincipal user = new UserPrincipal(context);
        //            user.EmailAddress = UserName;
        //            PrincipalSearcher pS = new PrincipalSearcher();
        //            pS.QueryFilter = user;
        //            Principal result = pS.FindOne();
        //            if (result != null)
        //            {
        //                ret = true;
        //            }
        //            else
        //                ret = false;
        //        }
        //    }

        //    return ret;
        //}

        //public User GetUserDetails(string userName)
        //{
        //    return dbContext.Users.FirstOrDefault(x => x.UserName == userName);

        //}
        //public IEnumerable<User> GetPagedResultForQuery(int pageIndex, int pageSize)
        //{
        //    //var result = new PagedResult<User>();
        //    //result.CurrentPage = page;
        //    // result.PageSize = pageSize;
        //    //var result = dbContext.Users;
        //    //var pageCount = (double)result.Count() / pageSize;
        //    //Count = (int)Math.Ceiling(pageCount);
        //    var skip = (pageIndex - 1) * pageSize;
        //    return dbContext.Users.OrderByDescending(r => r.UserId).Skip(skip).Take(pageSize);


        //    // return result;
        //}

        //public int GetNumberOfPages()
        //{
        //    var result = dbContext.Users;
        //    var pageCount = (double)result.Count() / 10;
        //    int Count = (int)Math.Ceiling(pageCount);
        //    return Count;
        //}

        public POSEntities dbContext
        {
            get { return Context as POSEntities; }
        }
    }
}