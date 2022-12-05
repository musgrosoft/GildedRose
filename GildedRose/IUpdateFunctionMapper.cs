using System;
using GildedRose;

namespace GildedRoseKata;

public interface IUpdateFunctionMapper
{
    public Func<Item, Item> Map(Item item);
}