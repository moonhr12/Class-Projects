using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Champions : ContentPage
    {
        Root championDTO;
        UserChamp[] userChamps;
        RestService restServices;
        List<UserChamp> champList;
        public Champions()
        {
            InitializeComponent();
            restServices = new RestService();
            champList = new List<UserChamp>();
           
        }

        public async void champInfo(List<SummonerInfo> info, string uri)
        {
            //string uriRequest3 = GenerateChampUri(Constants.champEndPoint, info[0].EncryptedId);
            championDTO = await restServices.GetChampData(Constants.champAPi);
            userChamps = await restServices.GetUserChampData(uri);
            

            for (int i = 0; i < userChamps.Length; i++)
            {
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Aatrox.key))
                {
                    UserChamp user = new UserChamp {

                        ChampName = championDTO.data.Aatrox.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Aatrox.png"
                    
                    };
                    
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Ahri.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Ahri.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Ahri.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Akali.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Akali.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Akali.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Akshan.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Akshan.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Akshan.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Alistar.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Alistar.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Alistar.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Amumu.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Amumu.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Amumu.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Anivia.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Anivia.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Anivia.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Annie.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Annie.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Annie.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Aphelios.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Aphelios.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Aphelios.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Ashe.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Ashe.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Ashe.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.AurelionSol.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.AurelionSol.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/AurelionSol.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Azir.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Azir.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Azir.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Bard.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Bard.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Bard.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Belveth.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Belveth.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Belveth.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Blitzcrank.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Blitzcrank.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Blitzcrank.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Brand.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Brand.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Brand.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Braum.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Braum.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Braum.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Caitlyn.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Caitlyn.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Caitlyn.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Camille.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Camille.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Camille.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Cassiopeia.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Cassiopeia.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Cassiopeia.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Chogath.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Chogath.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Chogath.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Corki.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Corki.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Corki.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Darius.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Darius.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Darius.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Diana.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Diana.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Diana.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Draven.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Draven.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Draven.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.DrMundo.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.DrMundo.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/DrMundo.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Ekko.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Ekko.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Ekko.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Elise.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Elise.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Elise.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Evelynn.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Evelynn.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Evelynn.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Ezreal.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Ezreal.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Ezreal.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Fiddlesticks.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Fiddlesticks.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Fiddlesticks.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Fiora.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Fiora.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Fiora.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Fizz.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Fizz.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Fizz.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Galio.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Galio.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Galio.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Gangplank.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Gangplank.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Gangplank.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Garen.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Garen.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Garen.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Gnar.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Gnar.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Gnar.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Gragas.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Gragas.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Gragas.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Graves.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Graves.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Graves.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Gwen.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Gwen.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Gwen.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Hecarim.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Hecarim.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Hecarim.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Heimerdinger.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Heimerdinger.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Heimerdinger.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Illaoi.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Illaoi.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Illaoi.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Irelia.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Irelia.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Irelia.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Ivern.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Ivern.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Ivern.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Janna.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Janna.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Janna.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.JarvanIV.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.JarvanIV.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/JarvanIV.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Jax.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Jax.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Jax.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Jayce.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Jayce.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Jayce.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Jhin.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Jhin.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Jhin.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Jinx.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Jinx.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Jinx.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Kaisa.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Kaisa.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Kaisa.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Kalista.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Kalista.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Kalista.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Karma.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Karma.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Karma.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Karthus.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Karthus.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Karthus.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Kassadin.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Kassadin.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Kassadin.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Katarina.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Katarina.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Katarina.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Kayle.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Kayle.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Kayle.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Kayn.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Kayn.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Kayn.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Kennen.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Kennen.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Kennen.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Khazix.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Khazix.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Khazix.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Kindred.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Kindred.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Kindred.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Kled.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Kled.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Kled.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.KogMaw.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.KogMaw.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/KogMaw.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.KSante.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.KSante.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/KSante.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Leblanc.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Leblanc.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Leblanc.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.LeeSin.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.LeeSin.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/LeeSin.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Leona.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Leona.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Leona.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Lillia.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Lillia.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Lillia.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Lissandra.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Lissandra.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Lissandra.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Lucian.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Lucian.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Lucian.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Lulu.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Lulu.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Lulu.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Lux.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Lux.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Lux.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Malphite.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Malphite.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Malphite.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Malzahar.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Malzahar.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Malzahar.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Maokai.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Maokai.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Maokai.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.MasterYi.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.MasterYi.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/MasterYi.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.MissFortune.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.MissFortune.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/MissFortune.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.MonkeyKing.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = "Wu Kong",
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/MonkeyKing.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Mordekaiser.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Mordekaiser.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Mordekaiser.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Morgana.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Morgana.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Morgana.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Nami.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Nami.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Nami.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Nasus.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Nasus.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Nasus.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Nautilus.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Nautilus.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Nautilus.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Neeko.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Neeko.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Neeko.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Nidalee.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Nidalee.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Nidalee.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Nilah.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Nilah.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Nilah.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Nocturne.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Nocturne.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Nocturne.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Nunu.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Nunu.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Nunu.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Olaf.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Olaf.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Olaf.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Orianna.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Orianna.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Orianna.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Ornn.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Ornn.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Ornn.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Pantheon.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Pantheon.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Pantheon.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Poppy.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Poppy.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Poppy.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Pyke.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Pyke.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Pyke.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Qiyana.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Qiyana.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Qiyana.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Quinn.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Quinn.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Quinn.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Rakan.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Rakan.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Rakan.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Rammus.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Rammus.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Rammus.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.RekSai.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.RekSai.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Reksai.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Rell.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Rell.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Rell.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Renata.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Renata.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Renata.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Renekton.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Renekton.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Renekton.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Rengar.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Rengar.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Rengar.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Riven.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Riven.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Riven.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Rumble.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Rumble.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Rumble.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Ryze.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Ryze.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Ryze.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Samira.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Samira.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Samira.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Sejuani.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Sejuani.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Sejuani.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Senna.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Senna.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Senna.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Seraphine.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Seraphine.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Seraphine.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Sett.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Sett.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Sett.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Shaco.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Shaco.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Shaco.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Shen.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Shen.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Shen.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Shyvana.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Shyvana.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Shyvana.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Singed.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Singed.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Singed.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Sion.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Sion.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Sion.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Sivir.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Sivir.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Sivir.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Skarner.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Skarner.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Skarner.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Sona.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Sona.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Sona.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Soraka.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Soraka.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Soraka.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Swain.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Swain.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Swain.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Sylas.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Sylas.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Sylas.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Syndra.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Syndra.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Syndra.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.TahmKench.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.TahmKench.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/TahmKench.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Taliyah.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Taliyah.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Taliyah.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Talon.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Talon.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Talon.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Taric.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Taric.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Taric.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Teemo.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Teemo.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Teemo.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Thresh.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Thresh.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Thresh.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Tristana.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Tristana.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Tristana.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Trundle.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Trundle.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Trundle.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Tryndamere.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Tryndamere.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Tryndamere.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.TwistedFate.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.TwistedFate.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/TwistedFate.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Twitch.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Twitch.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Twitch.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Udyr.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Udyr.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Udyr.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Urgot.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Urgot.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Urgot.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Varus.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Varus.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Varus.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Vayne.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Vayne.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Vayne.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Veigar.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Veigar.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Veigar.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Velkoz.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Velkoz.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Velkoz.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Vex.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Vex.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Vex.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Vi.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Vi.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Vi.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Viego.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Viego.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Viego.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Viktor.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Viktor.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Viktor.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Vladimir.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Vladimir.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Vladimir.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Volibear.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Volibear.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Volibear.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Warwick.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Warwick.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Warwick.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Xayah.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Xayah.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Xayah.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Xerath.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Xerath.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Xerath.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.XinZhao.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.XinZhao.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/XinZhao.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Yasuo.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Yasuo.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Yasuo.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Yone.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Yone.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Yone.png"

                    }; ;
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Yorick.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Yorick.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Yorick.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Yuumi.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Yuumi.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Yuumi.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Zac.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Zac.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Zac.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Zed.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Zed.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Zed.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Zeri.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Zeri.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Zeri.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Ziggs.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Ziggs.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Ziggs.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Zilean.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Zilean.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Zilean.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Zoe.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Zoe.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Zoe.png"

                    };
                    champList.Add(user);
                }
                if (userChamps[i].champID == Convert.ToInt32(championDTO.data.Zyra.key))
                {
                    UserChamp user = new UserChamp
                    {

                        ChampName = championDTO.data.Zyra.name,
                        ChampImage = "http://ddragon.leagueoflegends.com/cdn/12.23.1/img/champion/Zyra.png"

                    };
                    champList.Add(user);
                }
            }
           
            champLv.ItemsSource = champList;
            

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