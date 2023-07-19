using System.Collections.Generic;
using System.Linq;

namespace HeadPointTest
{
    public class TestClass
    {
        public static Dictionary<string, List<string>> GetResult(IEnumerable<string> list)
        {
            Dictionary<string, List<string>> result = new();

            if (list != null)
            {
                foreach (string str in list)
                {
                    if (str != null && str != string.Empty)
                    {
                        string key = string.Concat(str.ToLower().OrderBy(c => c));
                        if (result.ContainsKey(key))
                        {
                            result[key].Add(str);
                        }
                        else
                        {
                            result[key] = new List<string> { str };
                        }
                    }
                }
            }

            return result;
        }
    }
}
