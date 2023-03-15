using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{ 
   
   public class UserChamp
    {
        
        [JsonProperty("championId")]
        public int champID { get; set; }
        [JsonProperty("championPoints")]
        public int points { get; set; }
        public string ChampName { get; set; }
        public string ChampImage { get; set; }
       
        
    }
}

