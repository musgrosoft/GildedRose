using System;
using System.Collections.Generic;
using System.Data.Common;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<IItem> Items;
        public GildedRose(IList<IItem> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {

            foreach (var item in Items)
            {
                item.Update();
            }


        }
    }
}
