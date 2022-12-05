using System.Collections.Generic;
using GildedRose;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        private readonly IUpdateFunctionMapper _updateFunctionMapper;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            _updateFunctionMapper = new UpdateFunctionMapper();
        }

        public void UpdateQuality()
        {
            //https://www.linkedin.com/pulse/template-vs-strategy-pattern-ishmeet-singh/
            //https://stackoverflow.com/questions/669271/what-is-the-difference-between-the-template-method-and-the-strategy-patterns

            foreach (var item in Items)
            {
                var updateItemFunction = _updateFunctionMapper.Map(item);

                updateItemFunction(item);
            }


        }
    }
}
