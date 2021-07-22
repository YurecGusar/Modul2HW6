namespace Appliances.Models.Appliances
{
    public abstract class KitchenDevice : Appliance
    {
        public virtual double Noise { get; set; }
    }
}
