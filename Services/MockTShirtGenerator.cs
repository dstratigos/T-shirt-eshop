using Dimitrios_Stratigos_Assignment4.Models;
using Dimitrios_Stratigos_Assignment4.Strategies;
using System;
using System.Collections.Generic;


namespace Dimitrios_Stratigos_Assignment4.Services
{
    public class MockTshirtGenerator
    {
        static Random random = new Random();

        public static List<TShirt> GenerateTShirts(int number)
        {
            var tshirts = new List<TShirt>();

            while (tshirts.Count <= number)
            {
                bool exists = false;

                var color = (ColorEnum)(random.Next(0, 7));
                var size = (SizeEnum)(random.Next(0, 7));
                var fabric = (FabricEnum)(random.Next(0, 7));

                var tshirt = new TShirt { Color = color, Size = size, Fabric = fabric };

                tshirt.SetPricingStrategy(new PriceTag(tshirt));
                tshirt.GetPriceTag();

                if (number <= 300)
                {
                    foreach (var shirt in tshirts)
                    {
                        if (tshirt.Color == shirt.Color && tshirt.Size == shirt.Size && tshirt.Fabric == shirt.Fabric)
                        {
                            exists = true;
                        }
                    }

                    if (!exists)
                        tshirts.Add(tshirt);
                }
                else
                {
                    tshirts.Add(tshirt);
                }

            }

            return tshirts;
        }





    }
}
