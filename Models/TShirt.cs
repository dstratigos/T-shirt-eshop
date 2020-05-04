using Dimitrios_Stratigos_Assignment4.Strategies;


namespace Dimitrios_Stratigos_Assignment4.Models
{
    public class TShirt
    {
        private IPricingStrategy _pricingStrategy;


        public ColorEnum Color { get; set; }
        public SizeEnum Size { get; set; }
        public FabricEnum Fabric { get; set; }
        public int Price { get; set; }


        public void SetPricingStrategy(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }        

        public void GetPriceTag()
        {
            Price = _pricingStrategy.SetPriceTag(this);
        }
    }
}
