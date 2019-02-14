using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUser.Model
{
    public class GenerateUser
    {
      public static results GetUser()
        {
            ServiceUser serviceUser = new ServiceUser("https://randomuser.me/api?results=1");
            string json = serviceUser.GetJsonString();

            //Console.WriteLine(json);
            var user = JsonConvert.DeserializeObject<Users>(json);
            return user.results[0];

        }
    }
}
