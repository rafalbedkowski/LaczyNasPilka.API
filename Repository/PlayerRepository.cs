using System;
using System.IO;
using System.Linq;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using SoccerPlayer.Api.IRepository;
using SoccerPlayer.Api.Models.Dtos;

namespace SoccerPlayer.Api.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        public PlayerDto GetData(string userUrl)
        {
            const string BaseUri = "https://www.laczynaspilka.pl/zawodnik/";
            var player = new PlayerDto();
            var urlUser = Path.Combine(BaseUri, userUrl);

            HtmlWeb web = new HtmlWeb();
            var doc = web.Load(urlUser);
            var statistics = doc.QuerySelectorAll("section .season__stats .stats--player div .season__stats-item");
            var clubs = doc.QuerySelectorAll("div .player-clubs__item");

            try
            {
                player.FirstName = doc.QuerySelector("section .profile-page a").InnerText.Split(" ").First();
                player.LastName = doc.QuerySelector("section .profile-page a").InnerText.Split(" ").Last();
                player.PlayerAge = Int16.Parse(doc.QuerySelector("div .about-player ").InnerText.Trim().Split('\n').Last().Trim().Split(" ").Last());
                player.CurrentClub = doc.QuerySelector("section .fav-team").InnerText.Trim().Split('\n').Last().Trim();
                player.MatchesPlayed = Int16.Parse(statistics[0].QuerySelectorAll("span").Last().InnerHtml);
                player.MinutesOnThePitch = Int16.Parse(statistics[1].QuerySelectorAll("span").Last().InnerHtml);
                player.Goals = Int16.Parse(statistics[2].QuerySelectorAll("span").Last().InnerHtml);
                player.YellowCards = Int16.Parse(statistics[3].QuerySelectorAll("span")[1].InnerText);
                player.RedCards = Int16.Parse(statistics[3].QuerySelectorAll("span")[2].InnerText);

                foreach (var club in clubs)
                {
                    var c = new ClubDto();
                    c.Season = club.QuerySelector("span .date").InnerText;
                    c.Name = club.QuerySelector("span .club").InnerText;
                    player.Clubs.Add(c);
                }
            }
            catch
            {
                return null;
            }
            return player;
        }
    }
}