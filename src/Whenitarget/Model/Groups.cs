namespace Moniker.Model
{
    public static class Groups
    {
        public static Group ParseGroup(string value)
        {
            string s = value.Replace('_', '.');
            Group result;
            if (Group.TryParse(s, out result))
            {
                return result;
            }
            else
            {
                return Group.Unknown;
            }
        }
    }
}