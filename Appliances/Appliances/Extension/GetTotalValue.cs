using Appliances.Models;

namespace Appliances.Extension
{
    public static class GetTotalValue
    {
        public static double GetTotalPower(this Appliance[] appliance)
        {
            var totalPower = 0.0;
            foreach (var item in appliance)
            {
                if (item != null)
                {
                    totalPower += item.Power;
                }
            }

            return totalPower;
        }
    }
}
