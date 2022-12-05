// using Xunit;
// using System.Collections.Generic;
// using GildedRose.Items;
// using GildedRoseKata;
//
// namespace GildedRoseTests
// {
//     public class GildedRoseTest
//     {
//         //[Fact]
//         //public void foo()
//         //{
//         //    IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
//         //    GildedRose app = new GildedRose(Items);
//         //    app.UpdateQuality();
//         //    Assert.Equal("fixme", Items[0].Name);
//         //}
//
//         [Fact]
//         public void ConjuredItemsShouldDEcreaseInQualityBy2PerDay()
//         {
//             var conjuredItem = new Conjured
//             {
//                 Name = "magic",
//                 Quality = 123,
//                 SellIn = 100
//             };
//
//             conjuredItem.Update();
//
//             Assert.Equal(121,conjuredItem.Quality);
//         }
//
//         [Fact]
//         public void ConjuredItemsShouldDEcreaseInQualityBy4PerDayWhenPassedSellInDate()
//         {
//             var conjuredItem = new Conjured
//             {
//                 Name = "magic",
//                 Quality = 123,
//                 SellIn = 0
//             };
//
//             conjuredItem.Update();
//
//             Assert.Equal(119, conjuredItem.Quality);
//         }
//
//         //tests to compare ratio of ordinary to conjured
//     }
// }
