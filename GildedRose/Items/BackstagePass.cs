namespace GildedRose.Items;

public class BackstagePass : IItem
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
    public void Update()
    {
        if (Quality < 50)
        {
            Quality += 1;

            if (SellIn < 11)
            {
                if (Quality < 50)
                {
                    Quality += 1;
                }
            }

            if (SellIn < 6)
            {
                if (Quality < 50)
                {
                    Quality += 1;
                }
            }
        }

        SellIn -= 1;

        if (SellIn < 0)
        {
            Quality = 0;
        }
    }
}