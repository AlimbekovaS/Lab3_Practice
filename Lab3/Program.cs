﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Model;
using Newtonsoft.Json;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceUser serviceUser = new ServiceUser("https://randomuser.me/api?results=1");
           string json =  serviceUser.GetJsonString();

           //Console.WriteLine(json);
            var user = JsonConvert.DeserializeObject<Users>(json);
        }
    }
}
