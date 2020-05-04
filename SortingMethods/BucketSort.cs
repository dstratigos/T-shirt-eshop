using Dimitrios_Stratigos_Assignment4.Models;
using System.Collections.Generic;


namespace Dimitrios_Stratigos_Assignment4.SortingMethods
{
    public class BucketSort
    {
        public static List<TShirt> BucketFabricSort(List<TShirt> tshirts, bool ascending)
        {
            List<TShirt> sortedList = new List<TShirt>();

            int numOfBuckets = tshirts.Count / 10;

            // create buckets
            List<TShirt>[] buckets = new List<TShirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<TShirt>();
            }

            // Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < tshirts.Count; i++)
            {
                int bucket = (int)tshirts[i].Fabric;
                if (bucket == 0 || bucket == 1)
                    bucket = 0;
                else if (bucket == 2 || bucket == 3)
                    bucket = 1;
                else if (bucket == 4 || bucket == 5)
                    bucket = 2;
                else
                    bucket = 3;

                buckets[bucket].Add(tshirts[i]);
            }

            // sort each bucket, add it to the result

            if (ascending)
            {
                for (int i = 0; i < numOfBuckets; i++)
                {
                    List<TShirt> temp = InsertionSortBucketAsc(buckets[i]);
                    sortedList.AddRange(temp);
                }
            }
            else
            {
                for (int i = numOfBuckets - 1; i >= 0; i--)
                {
                    List<TShirt> temp = InsertionSortBucketDesc(buckets[i]);
                    sortedList.AddRange(temp);
                }
            }

            return sortedList;
        }

        private static List<TShirt> InsertionSortBucketAsc(List<TShirt> tshirts)
        {
            TShirt temp;
            for (int i = 1; i < tshirts.Count; i++)
            {
                // store current value in a var
                int currentValue = (int)tshirts[i].Fabric;
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue < (int)tshirts[pointer].Fabric)
                    {
                        temp = tshirts[pointer + 1];
                        tshirts[pointer + 1] = tshirts[pointer];
                        tshirts[pointer] = temp;
                        pointer--;
                    }
                    else break;
                }
            }

            return tshirts;
        }

        private static List<TShirt> InsertionSortBucketDesc(List<TShirt> tshirts)
        {
            TShirt temp;
            for (int i = 1; i < tshirts.Count; i++)
            {
                // store current value in a var
                int currentValue = (int)tshirts[i].Fabric;
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue > (int)tshirts[pointer].Fabric)
                    {
                        temp = tshirts[pointer + 1];
                        tshirts[pointer + 1] = tshirts[pointer];
                        tshirts[pointer] = temp;
                        pointer--;
                    }
                    else break;
                }
            }

            return tshirts;
        }
    }
}
