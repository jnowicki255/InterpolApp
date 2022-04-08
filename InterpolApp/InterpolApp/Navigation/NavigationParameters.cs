using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpolApp.Navigation
{
    public class NavigationParameters
    {
        private readonly Dictionary<string, object> entries = new Dictionary<string, object>();

        public NavigationParameters()
        {

        }

        public NavigationParameters(string query)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                int num = query.Length;
                for (int i = ((query.Length > 0) && (query[0] == '?')) ? 1 : 0; i < num; i++)
                {
                    int startIndex = i;
                    int num4 = -1;
                    while (i < num)
                    {
                        char ch = query[i];
                        if (ch == '=')
                        {
                            if (num4 < 0)
                            {
                                num4 = i;
                            }
                        }
                        else if (ch == '&')
                        {
                            break;
                        }
                        i++;
                    }
                    string key = null;
                    string value;
                    if (num4 >= 0)
                    {
                        key = query.Substring(startIndex, num4 - startIndex);
                        value = query.Substring(num4 + 1, (i - num4) - 1);
                    }
                    else
                    {
                        value = query.Substring(startIndex, i - startIndex);
                    }

                    if (key != null)
                        entries.Add(Uri.UnescapeDataString(key), Uri.UnescapeDataString(value));
                }
            }
        }

        public object this[string key]
        {
            get
            {
                foreach (var entry in entries)
                {
                    if (string.Compare(entry.Key, key, StringComparison.Ordinal) == 0)
                    {
                        return entry.Value;
                    }
                }

                return null;
            }
        }

        public int Count => entries.Count;

        public IEnumerable<string> Keys => entries.Select(x => x.Key);

        public void Add(string key, object value) => entries.Add(key, value);

        public bool ContainsKey(string key) => entries.ContainsKey(key);


    }
}
