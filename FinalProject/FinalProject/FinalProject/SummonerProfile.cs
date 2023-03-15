using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{

    public class SummonerProfile
    {
        string result = "";

        [JsonProperty("queueType")]
        public string Queue { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
        [JsonProperty("rank")]
        public string Rank { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
        [JsonProperty("losses")]
        public int Lose { get; set; }

        public double WinRate
        {
            get { return Math.Round(((double)Wins / (double)(Wins + Lose)) * 100); }


        }


        public string RankImages
        {

            get
            { 
                if (Tier.Equals("Unrank"))
                {
                    result = "unranked.png";
                }
                if (Tier.Equals("IRON"))
                {
                    result = "Emblem_Iron.png";
                }
                if (Tier.Equals("BRONZE"))
                {
                    result = "Emblem_Bronze.png";
                }
                if (Tier.Equals("SILVER"))
                {
                    result = "Emblem_Silver.png";
                }
                if (Tier.Equals("GOLD"))
                {
                    result = "Emblem_Gold.png";
                }
                if (Tier.Equals("PLATINUM"))
                {
                    result = "Emblem_Platinum.png";
                }
                if (Tier.Equals("DIAMOND"))
                {
                    result = "Emblem_Diamond.png";
                }

                return result;
            }
        }
    }
}
     

