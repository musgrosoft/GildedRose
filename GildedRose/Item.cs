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

    public class Ordinary : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            if (Quality > 0)
            {
                Quality = Quality - 1;
            }

            SellIn = SellIn - 1;
            
            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality = Quality - 1;
                }
            }
        }
    }

    public class Conjured : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            if (Quality > 0)
            {
                Quality = Quality - 2;
            }

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality = Quality - 2;
                }
            }
        }
    }

    public class Sulfuras : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public void Update()
        {
            return;
        }
    }

    public class BackstagePass : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public void Update()
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;

                if (Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (SellIn < 11)
                    {
                        if (Quality < 50)
                        {
                            Quality = Quality + 1;
                        }
                    }

                    if (SellIn < 6)
                    {
                        if (Quality < 50)
                        {
                            Quality = Quality + 1;
                        }
                    }
                }
            }

           
                SellIn = SellIn - 1;
            

            if (SellIn < 0)
            {
                Quality = Quality - Quality;

                //if (Quality < 50)
                //{
                //    Quality = Quality + 1;
                //}
            }
        }
    }

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
