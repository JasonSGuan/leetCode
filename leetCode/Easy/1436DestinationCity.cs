using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _1436DestinationCity
    {
        public static string DestCity(IList<IList<string>> paths)
        {
            Dictionary<string, bool> dicCity = new Dictionary<string, bool>();
            foreach (IList<string> path in paths)
            {
                if (dicCity.ContainsKey(path[0]))
                {
                    dicCity[path[0]] = true;
                    if (!dicCity.ContainsKey(path[1]))
                    {
                        dicCity.Add(path[1], false);
                    }
                }
                else
                {
                    dicCity.Add(path[0], true);
                    if (!dicCity.ContainsKey(path[1]))
                    {
                        dicCity.Add(path[1], false);
                    }
                }
            }
            foreach (string key in dicCity.Keys)
            {
                if (!dicCity[key])
                {
                    return key;
                }
            }
            return null;
        }
    }
}
