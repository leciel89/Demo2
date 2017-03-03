using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

 class Class1
{
    
    public static void Main(string[] arg)
    {
        JObject LoginForm = JObject.Parse(File.ReadAllText(@"D:\New folder\DemoProject\DemoProject\DemoProject\AdminSite\InterFace\LoginPage.json"));
        using (StreamReader file = File.OpenText(@"D:\New folder\DemoProject\DemoProject\DemoProject\AdminSite\InterFace\LoginPage.json"))
        using (JsonTextReader reader = new JsonTextReader(file))

        {
            JObject DtLoginFrom = (JObject)JToken.ReadFrom(reader);


            // get JSON result objects into a list
            IList<JToken> Results = DtLoginFrom["name"]["type"]["description"].Children().ToList();

            // serialize JSON results into .NET objects
            IList<Object> DtLoginForm = new List<Object>();
            foreach (JToken result in Results)
            {
                Object LoginFrom = JsonConvert.DeserializeObject<Object>(result.ToString());
                LoginForm.Add(LoginForm);
            }

            // List the properties of the searchResults IList
            foreach (Object item in LoginForm)
            {
                Console.WriteLine(item);
                Console.WriteLine(item);
                Console.WriteLine(item);
            }
        }
    }
}
