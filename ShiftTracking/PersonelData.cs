﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ShiftTracking
{
    public static class PersonelData
    {
        public static List<Asci> AsciList = new List<Asci>();

        public static void PersonelleriKaydet()
        {

            string json = JsonConvert.SerializeObject(AsciList, Formatting.Indented);
            File.WriteAllText("personeller.json", json);
        }
            public static void PersonelleriYukle()
            {
            if (File.Exists("personeller.json"))
            {
                string json = File.ReadAllText("personeller.json");
                AsciList = JsonConvert.DeserializeObject<List<Asci>>(json);
            }
        }


    }
}

