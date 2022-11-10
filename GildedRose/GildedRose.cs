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
            //foreach (var item in Items)
            //{
            //    var itemUpdateriser = Factory.BuildItemUpdateriser(item);

            //    itemUpdateriser.UpdateQuality(item);




            //}



            for (var i = 0; i < Items.Count; i++)
            {
                try
                {
                    Items[i].Update();
                }
                catch (Exception ex)
                {

                    if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Items[i].Quality > 0)
                        {
                            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;

                            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                            {
                                if (Items[i].SellIn < 11)
                                {
                                    if (Items[i].Quality < 50)
                                    {
                                        Items[i].Quality = Items[i].Quality + 1;
                                    }
                                }

                                if (Items[i].SellIn < 6)
                                {
                                    if (Items[i].Quality < 50)
                                    {
                                        Items[i].Quality = Items[i].Quality + 1;
                                    }
                                }
                            }
                        }
                    }

                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[i].SellIn = Items[i].SellIn - 1;
                    }

                    if (Items[i].SellIn < 0)
                    {
                        if (Items[i].Name != "Aged Brie")
                        {
                            if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                            {
                                if (Items[i].Quality > 0)
                                {
                                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                    {
                                        Items[i].Quality = Items[i].Quality - 1;
                                    }
                                }
                            }
                            else
                            {
                                Items[i].Quality = Items[i].Quality - Items[i].Quality;
                            }
                        }
                        else
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }
                    }

                }
            }
        }
    }
}
