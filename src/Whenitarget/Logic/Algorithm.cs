using System;
using System.Collections.Generic;
using System.Linq;

namespace Moniker.Model
{

    public static class Algorithm
    {
        
        public static void Project(Network network, IEnumerable<Key> keys)
        {
            foreach(var key in keys)
            {
                var item = network.Find(key);
                Select(item);
            }
            
            // this was the slower method.
            //foreach(var item in network.Items)
            //{
            //    if (keys.Contains(item.Key))
            //    {
            //        Select(item);
            //    }
            //}
        }

        private static void Select(Item item)
        {
            item.Touch = item.Key;
            item.Selected = true;
            BroadcastUp(false, item.Key, item);
            BroadcastDown(false, item.Key, item);
        }

        private static void BroadcastUp(bool check, Key touch, Item item)
        {
            if (check) 
            {
                if (item.Touch != touch)
                {
                    item.Runs += 1;
                    item.Touch = touch;
                }
                else return;
            }



            foreach(var link in item.Links)
            {
                if (item.IsSource(link))
                {
                    BroadcastUp(true, touch, link.Target);
                }
            }
        }

        private static void BroadcastDown(bool check, Key touch, Item item)
        {
            if (check)
            {
                if (item.Touch != touch)
                {
                    item.Touch = touch;
                    item.RunsOn += 1;
                }
                else return;
            }

            foreach (var link in item.Links)
            {
                if (item.IsTarget(link))
                {
                    BroadcastDown(true, touch, link.Source);
                }
            }
        }
    }
}