namespace GildedRoseKata
{
    public interface IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update();
    }

    public  class Item : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }

    // public abstract class Item
    // {
    //     public string Name { get; set; }
    //     public int SellIn { get; set; }
    //     public int Quality { get; set; }
    //
    //     public abstract void Update();
    // }


    public class AgedBrie : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            SellIn = SellIn - 1;

            if (Quality < 50)
            {
                Quality = Quality + 1;
            }

            if (SellIn < 0 && Quality < 50)
            {
                Quality = Quality + 1;
            }
        }

    }
}
