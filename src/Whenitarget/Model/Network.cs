using System.Collections.Generic;

namespace Moniker.Model
{
    public class Network
    {
        public Dictionary<Key, Item> map;
        public IList<Item> Items;

        public Network()
        {
            map = new Dictionary<Key, Item>();
            Items = new List<Item>();
        }

        public void Add(Item item)
        {
            map.Add(item.Key, item);
            Items.Add(item);
        }

        public Item Find(Key key)
        {
            Item item = null;
            map.TryGetValue(key, out item);
            return item;
        }
    }

    public static class StateBuilder
    {
        
        public static void Build(List<Item> items, IEnumerable<Key> selected)
        {

        }
    }
}