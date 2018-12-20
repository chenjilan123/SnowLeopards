using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SnowLeopard.Util
{
    public class JsonSerializer
    {
        public static string Serialize<T>(T obj)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }
        public static T Deserialize<T>(string input)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(input);
        }
    }
}
