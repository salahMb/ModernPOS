using Core;
using DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.POS_BL
{
    public interface IPOSHelper
    {
        bool GetAll(string name);
    }
    public class POSHelper : IPOSHelper
    {
        public bool GetAll(string name)
        {
            bool ret = false;
            try
            {
                using (IUnitOfWork unitOfWork = new POSUnitOfWork())
                {

                    //User IsuserExist = unitOfWork.UsersRepository.SingleOrDefault(x => x.UserName.Equals(UserName));
                    //if (IsuserExist == null)
                    //    ret = true;
                    //else
                    //    ret = false;
                }

            }
            catch
            {
                ret = false;
            }
            return ret;
        }
    }
}
