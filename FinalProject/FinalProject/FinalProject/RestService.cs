using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace FinalProject
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<SummonerInfo> GetInfoData(string query)
        {
            SummonerInfo summonerInfo = null;
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    summonerInfo = JsonConvert.DeserializeObject<SummonerInfo>(content);
                    JObject d = JObject.Parse(content);
                   
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return summonerInfo;
        }
        public async Task<SummonerProfile[]> GetProfileData(string query)
        {
            
            SummonerProfile[] summonerProfiles = null;
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    
                    
                        summonerProfiles = JsonConvert.DeserializeObject<SummonerProfile[]>(content);
                    

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return summonerProfiles;
        }
        public async Task<Root> GetChampData(string query)
        {
            Root champion = null;

            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                     var content = await response.Content.ReadAsStringAsync();


                    champion = JsonConvert.DeserializeObject<Root>(content);


                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return champion;
           
        }

        public async Task<UserChamp[]> GetUserChampData(string query)
        {

            UserChamp[] userChamps = null;
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();


                    userChamps = JsonConvert.DeserializeObject<UserChamp[]>(content);


                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return userChamps;
        }
    }
}

