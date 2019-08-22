using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONCreator.BusinessLogic
{
    public static class JSONObjectCreator
    {
        public static string CreateJsonObject(Dictionary<string, string> jsonObject)
        {
            string result = JsonConvert.SerializeObject(jsonObject);
            return result;
        }

    }
}
