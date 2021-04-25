using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagingAndDelivery.Models
{
    public interface IRepo<t>
    {
        public int PackagingDeliveryCharge(GetPackagingDeliveryCharge charges);
    }
}
