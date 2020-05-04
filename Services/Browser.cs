using Dimitrios_Stratigos_Assignment4.Models;
using Dimitrios_Stratigos_Assignment4.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitrios_Stratigos_Assignment4.Services
{
    public class Browser
    {
        private ISortingStrategy _sortingStrategy;

        public SortingEnum SortingMethod { get; set; }
        public List<TShirt> TShirts { get; set; }

        public void SetSortingStrategy(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public List<TShirt> Sort()
        {
            var sortedList = _sortingStrategy.Sort(SortingMethod, TShirts);

            return sortedList;
        }
    }
}
