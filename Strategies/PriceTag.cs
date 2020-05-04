using Dimitrios_Stratigos_Assignment4.Models;


namespace Dimitrios_Stratigos_Assignment4.Strategies
{
    public class PriceTag : IPricingStrategy
    {
        public TShirt TShirt { get; set; }

        public PriceTag(TShirt tshirt)
        {
            TShirt = tshirt;
        }

        public int SetPriceTag(TShirt tshirt)
        {
            var total = 0;

            switch ((int)tshirt.Color)
            {
                case 0:
                case 1:
                    total += 5;
                    break;
                case 2:
                    total += 8;
                    break;
                case 3:
                    total += 6;
                    break;
                case 4:
                    total += 4;
                    break;
                case 5:
                    total += 7;
                    break;
                case 6:
                    total += 3;
                    break;
                default:
                    total += 4;
                    break;
            }

            switch ((int)tshirt.Size)
            {
                case 0:
                    total += 7;
                    break;
                case 1:
                    total += 8;
                    break;
                case 2:
                    total += 10;
                    break;
                case 3:
                    total += 12;
                    break;
                case 4:
                    total += 13;
                    break;
                case 5:
                    total += 14;
                    break;
                case 6:
                    total += 17;
                    break;
                default:
                    total += 12;
                    break;
            }

            switch ((int)tshirt.Fabric)
            {
                case 0:
                    total += 27;
                    break;
                case 1:
                    total += 18;
                    break;
                case 2:
                    total += 20;
                    break;
                case 3:
                    total += 9;
                    break;
                case 4:
                    total += 13;
                    break;
                case 5:
                    total += 22;
                    break;
                case 6:
                    total += 20;
                    break;
                default:
                    total += 18;
                    break;
            }

            return total;
        }
    }
}
