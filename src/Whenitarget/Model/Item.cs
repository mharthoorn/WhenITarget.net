using System.Collections.Generic;

namespace Moniker.Model
{
    public class Item
    {
        public Group Group;
        public Key Key;
        public string Caption;
        public Kind Kind;
        public List<Link> Links = new List<Link>();

        public int RunsOn;
        public int Runs;
        public bool Selected;
        public Key Touch;

        public Item(Group group, Key key, string caption)
        {
            this.Group = group;
            this.Key = key;
            this.Caption = caption;
            
        }

        public override string ToString()
        {
            return Key.ToString();
        }
    }

    public enum Relation { RunsOn, Runs, Upgrade }

    public class Link
    {
        public Item Source;
        public Item Target;
        public Relation Relation;
    }
}