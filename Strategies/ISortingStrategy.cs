using Dimitrios_Stratigos_Assignment4.Models;
using Dimitrios_Stratigos_Assignment4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitrios_Stratigos_Assignment4.Strategies
{
    public interface ISortingStrategy
    {
        List<TShirt> Sort(SortingEnum sortingMethod, List<TShirt> tshirts);
    }
}
