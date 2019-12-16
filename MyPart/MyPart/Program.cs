using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json.Serialization;



namespace MyPart
{
    public class test {
        

        public void init()
        {
            Hatch hatch = new Hatch
            {
                isDrawed = true,
                toDelete = false,
                description = "abcbcb",
                location =  new GPSLocation
                {
                    latitude = 124f,
                    longitude = 12f
                },
                position = new Vector3
                {
                    x = 1f,
                    y = 2f,
                    z = 0f
                },
                model = "Hatch"
            };

            string abc = @"C:\abc\file.json";
            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var json = JsonConvert.SerializeObject(hatch, serializerSettings);
            File.WriteAllText(abc, json);
        }
        public void des()
        {
            
           
            string abc = @"C:\abc\file.json";
            string jsonString = File.ReadAllText(abc);

            Hatch jobject = JsonConvert.DeserializeObject<Hatch>(jsonString);
            Console.WriteLine(jobject.position.x);
        }
        
    }
    



}
