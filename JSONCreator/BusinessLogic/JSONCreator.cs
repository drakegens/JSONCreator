using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONCreator.BusinessLogic
{
    class JSONObjectCreator
    {
        public string createJSONObject(Dictionary<string, string> jsonObject)
        {
            string result = JsonConvert.SerializeObject(jsonObject);
            Console.WriteLine("JSON object: " + result);
            return result;
        }

    }
}
