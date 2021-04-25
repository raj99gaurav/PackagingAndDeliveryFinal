using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagingAndDelivery.Models
{
    public class ChargeRepo
    {
        public List<GetPackagingDeliveryCharge> charges;

        public ChargeRepo()
        {
            charges = new List<GetPackagingDeliveryCharge>();
        }

        public int PackagingDeliveryCharge(GetPackagingDeliveryCharge charges)
        {
            int Pcharge = 0;//Packaging charges
            int Dcharge = 0;//Delivery charges 
            int tcharge = 0;//total charge
            if (UpperCaseFirst(charges.Item) == "Integral")
            {
                Pcharge = charges.Count * 100;
                Dcharge = 200;
                tcharge = Pcharge + Dcharge + (50* charges.Count); //50* charges.Count is for Protective sheath
            }
            if (UpperCaseFirst(charges.Item) == "Accessory")
            {
                Pcharge = charges.Count * 50;
                Dcharge = 100;
                tcharge = Pcharge + Dcharge + (50 * charges.Count);
            }
            return tcharge;
        }
        /*To change first letter to upper case*/
        public static string UpperCaseFirst(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
