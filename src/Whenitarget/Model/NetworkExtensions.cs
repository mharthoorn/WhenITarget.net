using System;
using System.Collections.Generic;
using System.Linq;

namespace Moniker.Model
{
    public static class NetworkExtensions
    {
        public static void Add(this Network network, Group group, Key key, string caption, Kind kind)
        {
            var item = new Item(group, key, caption);
            network.Add(item);
        }

        public static IEnumerable<Item> FindAll(this Network network,IEnumerable<Key> idlist)
        {
            return network.Items.Where(item => idlist.Contains(item.Key));
        }

        public static IEnumerable<Item> FindAll(this Network network, params Key[] idlist)
        {
            return network.Items.Where(item => idlist.Contains(item.Key));
        }

        public static void Link(this Item source, Relation relation, Item target)
        {
            var link = new Link { Source = source, Relation = relation, Target = target };
            source.Links.Add(link);
            target.Links.Add(link);

        }

        public static void Link(this Item source, Relation relation, IEnumerable<Item> targets)
        {
            foreach (Item target in targets)
            {
                source.Link(relation, target);
            }
        }

        public static void Link(this Network network, Key key, Relation relation, params Key[] targets)
        {
            var source = network.Find(key);
            if (source != null)
            {
                var _targets = network.FindAll(targets);
                source.Link(relation, _targets);
            }
        }

        public static void Upgrade(this Network network, params Key[] keys)
        {
            Item source = null, target = null;
            foreach (var key in keys)
            {
                target = network.Find(key);
                if (source != null)
                {
                    source.Link(Relation.Upgrade, target);
                }
                source = target;
            }
        }

        public static void RunsOn(this Network network, Key source, params Key[] targets)
        {
            network.Link(source, Relation.RunsOn, targets);
        }

        private static Key[] ParsePortableToKeys(string s)
        {
            var keys = new List<Key>();

            s = s.Remove(0, 9);
            string[] targets = s.Split('+');
            foreach (string target in targets)
            {
                Key key;
                if (Enum.TryParse(target, out key))
                {
                    keys.Add(key);
                }
            }
            return keys.ToArray();
        }

        public static IEnumerable<Item> WherePortable(this IEnumerable<Item> items)
        {
            return items.Where(i => i.Caption.StartsWith("portable-"));
        }

        public static void AutolinkProfiles(this Network network)
        {
            foreach(var item in network.Items.WherePortable())
            {
                var keys = ParsePortableToKeys(item.Caption);
                var targets = network.FindAll(keys);
                item.Link(Relation.RunsOn, targets);
            }
        }

        public static IEnumerable<Item> OfKind(this IEnumerable<Item> items, params Kind[] kind)
        {
            return items.Where(item => kind.Contains(item.Kind));
        }

        public static IEnumerable<Link> WhereSource(this Item item)
        {
            return item.Links.Where(i => i.Source == item);
        }

        public static bool IsSource(this Item item, Link link)
        {
            return link.Source == item;
        }

        public static bool IsTarget(this Item item, Link link)
        {
            return link.Target == item;
        }
    }
}
