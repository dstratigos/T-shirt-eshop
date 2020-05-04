using Dimitrios_Stratigos_Assignment4.Models;
using Dimitrios_Stratigos_Assignment4.SortingMethods;
using Dimitrios_Stratigos_Assignment4.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitrios_Stratigos_Assignment4.Services
{
    public class Sorter : ISortingStrategy
    {
        public List<TShirt> Sort(SortingEnum sortingMethod, List<TShirt> tshirts)
        {

            switch ((int)sortingMethod)
            {
                case 1:
                    var tshirtsArr = tshirts.ToArray();
                    QuickSort.QuickSortMain(tshirtsArr, 0, tshirtsArr.Length - 1, true, "price");
                    var sorted = tshirtsArr.ToList();
                    return sorted;
                case 2:
                    tshirtsArr = tshirts.ToArray();
                    QuickSort.QuickSortMain(tshirtsArr, 0, tshirtsArr.Length - 1, false, "price");
                    sorted = tshirtsArr.ToList();
                    return sorted;
                case 3:
                    return BubbleSort.Ascending(tshirts);
                case 4:
                    return BubbleSort.Descending(tshirts);
                case 5:
                    tshirtsArr = tshirts.ToArray();
                    QuickSort.QuickSortMain(tshirtsArr, 0, tshirtsArr.Length - 1, true, "size");
                    sorted = tshirtsArr.ToList();
                    return sorted;
                case 6:
                    tshirtsArr = tshirts.ToArray();
                    QuickSort.QuickSortMain(tshirtsArr, 0, tshirtsArr.Length - 1, false, "size");
                    sorted = tshirtsArr.ToList();
                    return sorted;
                case 7:
                    return BucketSort.BucketFabricSort(tshirts, true);
                case 8:
                    return BucketSort.BucketFabricSort(tshirts, false);
                case 9:
                    return BubbleSort.AllAsc(tshirts);
                case 10:
                    return BubbleSort.AllDesc(tshirts);
                default:
                    return tshirts;
            }
        }
    }
}
