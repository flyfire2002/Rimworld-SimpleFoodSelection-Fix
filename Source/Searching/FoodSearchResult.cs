using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace SimpleFoodSelection.Searching
{
    public class FoodSearchResult
    {
        /// <summary>Whether the vanilla search result should be replaced with this one</summary>
        public bool ShouldIntercept;
        
        /// <summary>A reference to the the food search result</summary>
        public Thing Thing;
        
        /// <summary>The type definition of the food search result</summary>
        public ThingDef Def;

        public FoodSearchResult() { }

        public FoodSearchResult(FoodSearchItem foodSearchItem)
        {
            Thing = foodSearchItem.Thing;
            Def = foodSearchItem.Def;
            ShouldIntercept = true;
        }
    }
}
