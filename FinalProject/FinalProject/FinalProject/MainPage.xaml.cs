using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;
using System.IO;
using System.Reflection;
using System.Numerics;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace FinalProject
{
    public partial class MainPage : ContentPage
    {
        
        RestService restService;
        Champions champions;
        Color color1 = Color.Gray;
        Color color2 = Color.Blue;
        
        ISimpleAudioPlayer player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        
        List<SummonerProfile> summonerProfileList1 = new List<SummonerProfile>();
        List<SummonerProfile> summonerProfileList2 = new List<SummonerProfile>();
        
        SummonerProfile[] SummonerProfile;
        Unrank ui;
        List<SummonerInfo> summonerList;
        

        
        public MainPage()
        {
            
            InitializeComponent();
            
            restService = new RestService();
           
            logo.Source = ImageSource.FromFile("Logo.png");
            
            Load("search.mp3");          
        }
        private void Load(string file)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            String ns = "FinalProject";
            Stream audioStream = assembly.GetManifestResourceStream(ns + "." + file);
            player.Load(audioStream);
        }
        private async void OnGetButtonClicked(object sender, EventArgs e)
        {
            player.Play();

                if (!string.IsNullOrWhiteSpace(summoner.Text))
                {

                    summonerList = new List<SummonerInfo>();


                    string uriRequest = GenerateUri(Constants.riotSummonerEndPoint, summoner.Text);
                   
                    SummonerInfo SummonerData = await restService.GetInfoData(uriRequest);
                    summonerList.Add(SummonerData);
                    Queue_Save(summonerList);
                    champions = new Champions();
                   // champions.champInfo(summonerList, uriRequest3);

                    lv.ItemsSource = summonerList;
                }
        }

        private async void Queue_Save(List<SummonerInfo> info)
        {
            if (info.Contains(null))
            {
                await App.Current.MainPage.DisplayAlert("Invalid Summoner", "This Summoner does not exist!", "OK");
            }
            string uriRequest2 = GenerateUri2(Constants.riotProfileEndPoint, info[0].EncryptedId);
            SummonerProfile = await restService.GetProfileData(uriRequest2);

            ui = new Unrank
            {
                Tier = "Unrank",
                Rank = "",
                Wins = 0,
                Lose = 0,
                RankImages = "unranked.png"
            };

            if (SummonerProfile.Length == 0)
            {
                DB.DeleteTableContents("unrank");
                DB.conn.Insert(ui);
            }
            else if (SummonerProfile[0].Queue.Equals("RANKED_SOLO_5x5") && SummonerProfile.Length == 1)
            {
                summonerProfileList1.Add(SummonerProfile[0]);
                DB.DeleteTableContents("unrank");
                DB.conn.Insert(ui);
            }
            else if (SummonerProfile[0].Queue.Equals("RANKED_FLEX_SR") && SummonerProfile.Length == 1)
            {
                DB.DeleteTableContents("unrank");
                summonerProfileList2.Add(SummonerProfile[0]);
                DB.conn.Insert(ui);
            }
            else if (SummonerProfile.Length > 1)
            {
                if (SummonerProfile[0].Queue.Equals("RANKED_SOLO_5x5"))
                {   // if index 0 is solo
                    summonerProfileList1.Add(SummonerProfile[0]);
                }
                if (SummonerProfile[0].Queue.Equals("RANKED_FLEX_SR"))
                {   // if index 0 is flex
                    summonerProfileList2.Add(SummonerProfile[0]);
                }
                if (SummonerProfile[1].Queue.Equals("RANKED_SOLO_5x5"))
                {   // if index 1 is solo
                    summonerProfileList1.Add(SummonerProfile[1]);
                }
                if (SummonerProfile[1].Queue.Equals("RANKED_FLEX_SR"))
                {   // if index 1 is flex
                    summonerProfileList2.Add(SummonerProfile[1]);
                }
                if (SummonerProfile.Length == 3 && SummonerProfile[2].Queue.Equals("RANKED_SOLO_5x5"))
                {
                    // if index 2 is solo
                    summonerProfileList1.Add(SummonerProfile[2]);
                }
                if (SummonerProfile.Length == 3 && SummonerProfile[2].Queue.Equals("RANKED_FLEX_SR"))
                {
                    // if index 2 is flex
                    summonerProfileList2.Add(SummonerProfile[2]);
                }
            }
        }

        private void Picker_IndexChange(object sender, EventArgs e)
        {
            if (SummonerProfile.Length == 0)
            {
                lv2.ItemsSource = DB.conn.Table<Unrank>().ToList();
                lv3.ItemsSource = DB.conn.Table<Unrank>().ToList();
            } else if (SummonerProfile[0].Queue.Equals("RANKED_FLEX_SR") && SummonerProfile.Length == 1)
            {
                lv2.ItemsSource = DB.conn.Table<Unrank>().ToList();
                lv3.ItemsSource = summonerProfileList2;
            } else if (SummonerProfile[0].Queue.Equals("RANKED_SOLO_5x5") && SummonerProfile.Length == 1)
            {
                lv2.ItemsSource = summonerProfileList1;
                lv3.ItemsSource = DB.conn.Table<Unrank>().ToList();
            }
            else
            {
                lv2.ItemsSource = summonerProfileList1;
                lv3.ItemsSource = summonerProfileList2;
            }

            if (QueuePicker.SelectedItem.ToString().Equals("Ranked Solo"))
            {
                lv2.IsVisible = true;
                lv3.IsVisible = false;
            } else if(QueuePicker.SelectedItem.ToString().Equals("Ranked Flex"))
            {
                lv2.IsVisible = false;
                lv3.IsVisible = true;
            }
        }
        
        private void Reset_Button(object sender, EventArgs e)
        {
            summoner.Text = "";
            summonerProfileList1.Clear();
            summonerProfileList2.Clear();
            lv.ItemsSource = null;
            lv2.ItemsSource = null;
            lv3.ItemsSource = null;
            DB.conn.DeleteAll<Unrank>();
        }
        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();
            
            SKPaint paint1 = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = color1.ToSKColor(),
                StrokeWidth = 3,
            };
            SKPaint paint2 = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = color2.ToSKColor(),
                StrokeWidth = 3,
            };

            float wR; float percent = 100;
            
            if (QueuePicker.SelectedItem.ToString().Equals("Ranked Solo"))
            {
                // should be 2 or 3 length of summoner profile
                if (summonerProfileList1.Count != 0)
                {
                    if ((SummonerProfile.Length > 1 && summonerProfileList1[0].Queue.Equals("RANKED_SOLO_5x5"))
                        || (SummonerProfile.Length == 1 && summonerProfileList1[0].Queue.Equals("RANKED_SOLO_5x5")))
                    {
                        wR = (float)summonerProfileList1[0].WinRate;
                        canvas.DrawRect(info.Width / 2, info.Height / 2, percent, 50, paint1);
                        canvas.DrawRect(info.Width / 2, info.Height / 2, wR, 50, paint2);
                    }
                }
            }
            else if (QueuePicker.SelectedItem.ToString().Equals("Ranked Flex"))
            {   if (summonerProfileList2.Count != 0) {
                    if ((SummonerProfile.Length > 1 && summonerProfileList2[0].Queue.Equals("RANKED_FLEX_SR"))
                        || (SummonerProfile.Length == 1 && summonerProfileList2[0].Queue.Equals("RANKED_FLEX_SR")))
                    {
                        wR = (float)summonerProfileList2[0].WinRate;
                        canvas.DrawRect(info.Width / 2, info.Height / 2, percent, 50, paint1);
                        canvas.DrawRect(info.Width / 2, info.Height / 2, wR, 50, paint2);
                    }
                }
            }         
        }
        private async void Clicked(object sender, ItemTappedEventArgs e)
        {
            champions = new Champions();
            await Navigation.PushAsync(champions, true);    

        }
       // Mehtods for getting api
        private string GenerateUri2(string endpoint, string id)
        {
            string requestUri = endpoint;
            requestUri += $"{id}";
            requestUri += $"?api_key={Constants.APIKey}";
            return requestUri;
        }

        string GenerateUri(string endpoint, string name)
        {
            string requestUri = endpoint;
            requestUri += $"{name}";
            requestUri += $"?api_key={Constants.APIKey}";
            return requestUri;
        }
        string GenerateChampUri(string endpoint, string id)
        {
            string requestUri = endpoint;
            requestUri += $"{id}";
            requestUri += $"?api_key={Constants.APIKey }";
            return requestUri;
        }

    }
}
