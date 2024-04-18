using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2.Parser
{
    public class JsonStringParser : BaseStringParser
    {
        public JsonStringParser(string input)
        {
            this.StringToParse = input;
        }
        public override string GetTextVersionFromHeader()
        {
            var data = JsonConvert.DeserializeObject<JObject>(this.StringToParse);

            JToken versionToken = data.GetValue("version", StringComparison.OrdinalIgnoreCase);

            if (versionToken != null)
            {
                return versionToken.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public override string HasCorrectHeader()
        {
            throw new NotImplementedException();
        }

        private bool PropertyExists(dynamic obj, string name)
        {
            // 嘗試訪問屬性並捕捉任何異常
            try
            {
                //未考慮到大小寫
                var value = obj[name];
                return true;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                return false;
            }
        }
    }
}
