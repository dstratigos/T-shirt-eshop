using Dimitrios_Stratigos_Assignment4.Models;


namespace Dimitrios_Stratigos_Assignment4.SortingMethods
{
    public class QuickSort
    {
        public static void QuickSortMain(TShirt[] arr, int low, int high, bool ascending, string prop)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = 0;

                switch (prop)
                {
                    case "size":
                        if (ascending)
                            pi = QuickSizeSortPartitionAsc(arr, low, high);
                        else
                            pi = QuickSizeSortPartitionDesc(arr, low, high);
                        break;
                    case "price":
                        if (ascending)
                            pi = QuickPriceSortPartitionAsc(arr, low, high);
                        else
                            pi = QuickPriceSortPartitionDesc(arr, low, high);
                        break;
                }

                // Recursively sort elements before
                // partition and after partition
                QuickSortMain(arr, low, pi - 1, ascending, prop);
                QuickSortMain(arr, pi + 1, high, ascending, prop);
            }
        }

        private static int QuickSizeSortPartitionAsc(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot
                if (arr[j].Size < pivot.Size)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        private static int QuickSizeSortPartitionDesc(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot
                if (arr[j].Size > pivot.Size)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }


        private static int QuickPriceSortPartitionAsc(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot
                if (arr[j].Price < pivot.Price)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }


        private static int QuickPriceSortPartitionDesc(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            // index of smaller element
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot
                if (arr[j].Price > pivot.Price)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
