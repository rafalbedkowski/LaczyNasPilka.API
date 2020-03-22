using System;
using Microsoft.AspNetCore.Mvc;
using SoccerPlayer.Api.IRepository;

namespace SoccerPlayer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerApi : ControllerBase
    {
        private readonly IPlayerRepository _repo;
        public PlayerApi(IPlayerRepository repo)
        {
            _repo = repo;
        }

        [Route("[action]")]
        [HttpGet("getplayerdata/{userUrl}")]
        public IActionResult GetPlayerData(string userUrl)
        {
            if (userUrl != null)
            {
                try
                {
                    var player = _repo.GetData(userUrl);
                    if (player != null)
                        return Ok(player);
                }
                catch (Exception e)
                {
                    return BadRequest("Error : " + e.Message);
                }
            }
            return BadRequest("Nie ma takiego zawodnika");
        }
    }
}