using System.Collections;
using Appliances.Models;

namespace Appliances.Helpers
{
    public class ApplianceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var appliance1 = x as Appliance;
            var appliance2 = y as Appliance;
            if (x != null && y != null)
            {
                if (appliance1.Price > appliance2.Price)
                {
                    return 1;
                }
                else if (appliance1.Price < appliance2.Price)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
