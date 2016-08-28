using System.Collections.Generic;
using System.Linq;

namespace Moniker.Model
{
    public class MonikersVm
    {
        public Network Network { get; set; }

        public GroupVm CreateGroupVm(string Title, Kind kind, Group group)
        {
            var model = new GroupVm
            {
                Title = Title,
                Items = Network.Items.Where(item => item.Group == group).ToList(),
                Targets = this.Selected,
                SelectedCount = this.SelectCount
            };
            return model;
        }

        public List<Key> Selected;
        public List<Key> Downstream; 
        public List<Key> Upstream;
        public string ProjectType;
        public int SelectCount;
    }

    public class GroupVm
    {
        public string Title;
        public Group Group;
        public Kind Kind;
        public List<Item> Items;
        public IList<Key> Targets;
        public int SelectedCount;
    }
}