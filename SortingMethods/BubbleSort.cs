using Dimitrios_Stratigos_Assignment4.Models;
using System.Collections.Generic;


namespace Dimitrios_Stratigos_Assignment4.SortingMethods
{
    public class BubbleSort
    {
        public static List<TShirt> Ascending(List<TShirt> tshirts)
        {
            TShirt temp;
            for (int j = 0; j <= tshirts.Count - 2; j++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Color > tshirts[i + 1].Color)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }

            return tshirts;
        }

        public static List<TShirt> Descending(List<TShirt> tshirts)
        {

            TShirt temp;
            for (int j = 0; j <= tshirts.Count - 2; j++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Color < tshirts[i + 1].Color)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }

            return tshirts;
        }

        public static List<TShirt> AllAsc(List<TShirt> shirts)
        {
            TShirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Fabric > shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Size > shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Color > shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }

            return shirts;
        }

        public static List<TShirt> AllDesc(List<TShirt> shirts)
        {
            TShirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (shirts[i].Fabric < shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Size < shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }

                    if (shirts[i].Color < shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }

            return shirts;
        }
    }
}
