# Downloading Soccer Player data from www.laczynaspilka.pl

SoccerPlayer.API is webapi used to download basic player data from the website www.laczynaspilka.pl

### Tech

Powered by .net core v 3.1 (C#)

### Installation

SoccerPlayer.API requires [.net core](https://dotnet.microsoft.com/download/dotnet-core/3.1) v3.1 to run.

Install the dependencies and devDependencies and start the server.

```sh
$ cd SoccerPlayer.API
$ dotnet restore
$ dotnet run
```

For publish...

```sh
$ dotnet publish -c Release
```

### Example of use

Visit www.laczynaspiłka.pl.
In the upper right corner click "Wyszukaj".
Enter the player's name and surname and search.
In the selected ones, select the player profile you want.
Copy part of the URL according to the example : https://www.laczynaspilka.pl/zawodnik/<B>jan-kowalski,123857.html</B>
If you listening on http://localhost:5000 you can fetch :

http://localhost:5000/playerapi/getplayerdata/jak-kowalski,123857.html

You will receive back json data:

```
{
    "firstName": "Jan",
    "lastName": "Kowalski",
    "playerAge": 22,
    "currentClub": "Player Team",
    "matchesPlayed": 303,
    "minutesOnThePitch": 8211,
    "goals": 1,
    "yellowCards": 0,
    "redCards": 0,
    "clubs": [
        {
            "season": "2019/2020",
            "name": "Legia Warszawa."
        },
        {
            "season": "2019/2020",
            "name": "Wisła Kraków"
        },
        {
            "season": "2018/2019",
            "name": "ŁKS Łódź"
        },
        {
            "season": "2018/2019",
            "name": "Lech Poznań"
        },
    ]
}
```
