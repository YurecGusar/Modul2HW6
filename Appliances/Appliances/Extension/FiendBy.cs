using Appliances.Exceptions;
using Appliances.Models;
using Appliances.Enums;

namespace Appliances.Extension
{
    public static class FiendBy
    {
        public static Appliance GetByModel(this Appliance[] appliance, string model)
        {
            foreach (var item in appliance)
            {
                if (item != null)
                {
                    if (item.Model == model)
                    {
                        return item;
                    }
                }
            }

            throw new FiendException("Не найдено такой модели");
        }

        public static Appliance[] GetAllWithColor(this Appliance[] appliances, Color color)
        {
            var counter = 0;
            foreach (var item in appliances)
            {
                if (item.Color == color)
                {
                    counter++;
                }
            }

            var newAppliances = new Appliance[counter];
            counter = 0;
            foreach (var item in appliances)
            {
                if (item.Color == color)
                {
                    newAppliances[counter] = item;
                    counter++;
                }
            }

            return newAppliances;
        }
    }
}
