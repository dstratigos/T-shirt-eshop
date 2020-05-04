using Dimitrios_Stratigos_Assignment4.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Dimitrios_Stratigos_Assignment4.Services
{
    public class PrintOut
    {
        public static void PrintOutSingle(TShirt tshirt)
        {
            var sb = new StringBuilder();

            sb
              .AppendLine("Price\t\tColor\t\tSize\t\tFabric")
              .Append('-', 60)
              .AppendLine()
              .AppendLine($"{tshirt.Price}\t\t{tshirt.Color}\t\t{tshirt.Size}\t\t{tshirt.Fabric}");

            Console.WriteLine(sb.ToString());
        }

        public static void PrintOutList(List<TShirt> tshirts)
        {
            var counter = 1;
            var sb = new StringBuilder();

            sb
              .AppendLine()
              .AppendLine("Code\tPrice\t\tColor\t\tSize\t\tFabric")
              .Append('-', 70)
              .AppendLine();

            foreach (var tshirt in tshirts)
            {
                sb.Append($"{counter}.\t");
                sb.AppendLine($"{tshirt.Price}\t\t{tshirt.Color}\t\t{tshirt.Size}\t\t{tshirt.Fabric}");
                counter++;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
