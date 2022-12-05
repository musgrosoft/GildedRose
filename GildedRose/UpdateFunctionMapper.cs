using System;
using GildedRose;

namespace GildedRoseKata;

public class UpdateFunctionMapper : IUpdateFunctionMapper
{
    public Func<Item, Item> Map(Item item)
    {
        return item.Name switch
        {
            { } x when x.Contains("Brie") => UpdateAgedBrie,
            { } x when x.Contains("Sulfuras") => UpdateSulfuras,
            { } x when x.Contains("Backstage") => UpdateBackstagePasses,
            { } x when x.Contains("Conjured") => UpdateConjured,
            _ => UpdateOrdinary
        };
    }

    private static Item UpdateConjured(Item i)
    {
        if (i.Quality > 0)
        {
            i.Quality -= 2;
        }

        i.SellIn -= 1;

        if (i.SellIn >= 0) return i;

        if (i.Quality > 0)
        {
            i.Quality -= 2;
        }

        return i;
    }

    private static Item UpdateBackstagePasses(Item i)
    {
        if (i.Quality < 50)
        {
            i.Quality += 1;

            if (i.SellIn < 11)
            {
                if (i.Quality < 50)
                {
                    i.Quality += 1;
                }
            }

            if (i.SellIn < 6)
            {
                if (i.Quality < 50)
                {
                    i.Quality += 1;
                }
            }
        }

        i.SellIn -= 1;

        if (i.SellIn < 0)
        {
            i.Quality = 0;
        }

        return i;
    }

    private static Item UpdateSulfuras(Item item)
    {
        return item;
    }

    private static Item UpdateOrdinary(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality -= 1;
        }

        item.SellIn -= 1;

        if (item.SellIn < 0 && item.Quality > 0)
        {
            item.Quality -= 1;
        }

        return item;
    }

    private static Item UpdateAgedBrie(Item item)
    {
        item.SellIn -= 1;

        if (item.Quality >= 50) return item;
        
        item.Quality += 1;

        if (item.SellIn < 0)
        {
            item.Quality += 1;
        }

        return item;
    }
}