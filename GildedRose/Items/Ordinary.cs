﻿namespace GildedRose.Items;

public class Ordinary : IItem
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void Update()
    {
        if (Quality > 0)
        {
            Quality -= 1;
        }

        SellIn -= 1;

        if (SellIn >= 0) return;

        if (Quality > 0)
        {
            Quality -= 1;
        }
    }
}