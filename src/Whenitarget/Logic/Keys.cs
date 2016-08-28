using System.Collections.Generic;
using System.Linq;

namespace Moniker.Model
{

    public static class Keys
    {

        public static Key ParseKey(string value)
        {
            string s = value.Replace('_', '.');
            Key result;
            if (Key.TryParse(s, out result))
            {
                return result;
            }
            else
            {
                return Key.Unknown;
            }
        }

        public static IEnumerable<Key> ParseKeys(string input)
        {
            if (string.IsNullOrEmpty(input)) return Enumerable.Empty<Key>();

            var values = input.Split(',', ' ');
            return ParseKeys(values);
        }

        public static IEnumerable<Key> ParseKeys(this string[] values)
        {
            foreach (var value in values)
            {
                Key result;
                if (Key.TryParse(value, out result))
                {
                    yield return result;
                }
            }
        }

        public static string AsReadableString(this Key key)
        {
            string s = key.ToString();
            s = s.Replace('_', '.');
            return s;
        }

        public static string AsQueryString(this IEnumerable<Key> keys)
        {
            IEnumerable<string> values = keys.Select(k => k.ToString());
            return string.Join(",", values);
        }

        public static string AsReadableString(this IEnumerable<Key> keys)
        {
            if (keys.Count() > 0)
            {
                return string.Join(", ", keys.Select(AsReadableString));
            }
            else
            {
                return null;
            }
        }
        
        public static IList<Key> Toggle(this IList<Key> keys, Key key)
        {
            List<Key> result = new List<Key>();
            result.AddRange(keys);

            if (key == Key.Unknown) return result;

            if (result.Contains(key))
            {
                result.Remove(key);
            }
            else
            {
                result.Add(key);
            }
            return result;
        }
    }


}