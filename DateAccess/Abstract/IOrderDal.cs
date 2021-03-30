using Core.DateAccess;
using DateAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccess.Abstract
{
   public interface IOrderDal:IEntityRepository<Order>
    {
    }
}
