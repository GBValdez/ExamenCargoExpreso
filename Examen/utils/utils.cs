//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using AutoMapper;
//using AvionesBackNet.utils.dto;
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using project.utils.dto;

//namespace AvionesBackNet.utils
//{
//    public class Utils
//    {
//        public static bool indexValid<T>(List<T> list, int index)
//        {
//            return index >= 0 && index < list.Count;
//        }



//        public static TTEntity CreateDeepCopy<TTEntity>(TTEntity obj) where TTEntity : class
//        {
//            if (obj == null)
//            {
//                return null;
//            }

//            var jsonSettings = new JsonSerializerSettings()
//            {
//                NullValueHandling = NullValueHandling.Ignore,
//                Formatting = Formatting.None,
//            };
//            jsonSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

//            var serialized = JsonConvert.SerializeObject(obj, jsonSettings);

//            return System.Text.Json.JsonSerializer.Deserialize<TTEntity>(serialized);
//        }

//    }
//}