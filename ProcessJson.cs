﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Platformy_projekt
{
    class ProcessJson
    {
        static private int MemeIndeks = 0;
        public static string NextMeme(JObject JMeme)
        {
            string url = String.Empty;

            var children = JMeme["data"]["children"];


            //for (int i = 0; i < MemeIndeks; i++)
            //{
            //    url = children[i]["data"]["url"].ToString();
            //}

            url = children[MemeIndeks]["data"]["url"].ToString();

            if (MemeIndeks++ > 23) MemeIndeks = 0;
            

            return url;
        }
        

    }
}