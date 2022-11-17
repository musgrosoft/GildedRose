namespace GildedRose.Items;

public class AgedBrie : IItem
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void Update()
    {
        SellIn -= 1;

        if (Quality >= 50) return;

        Quality += 1;

        if (SellIn < 0)
        {
            Quality += 1;
        }


    }

}