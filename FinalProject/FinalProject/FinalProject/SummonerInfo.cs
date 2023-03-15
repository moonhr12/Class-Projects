using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FinalProject
{
    public class SummonerInfo
    {
        [JsonProperty("id")]
        public string EncryptedId { get; set; }
        [JsonProperty("name")]
        public string SummonerId { get; set; }
        [JsonProperty("profileiconId")]
        public int ProfileId { get; set; }
        [JsonProperty("summonerLevel")]
        public long SummonerLvl { get; set; }
        [JsonProperty("rank")]
        public string Rank { get; set; }

        public string Logo { get { return "Logo.png"; } }
        public string Icon
        {
            get { return "http://ddragon.leagueoflegends.com/cdn/12.22.1/img/profileicon/" + ProfileId + ".png"; }
        }
    }
}
