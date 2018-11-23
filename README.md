# Jikan Wrapper for DotNet

*Based in Ervie/Jikan.Net*

JikanClient is a .NET wrapper for [Jikan](https://jikan.moe/) RESTful API for parsing data from [MyAnimeList](https://myanimelist.com/). Main objective of the wrapper is to simplify utilization of Jikan API.

**Dependencies**
-Newtonsoft Json

# Features

- [X] Anime
	- [x] Basic info
	- [x] Characters and Staff
	- [x] Episodes
	- [x] Pictures
	- [x] News
	- [x] Forum
	- [X] Videos 
	- [X] Stats
	- [X] Mote Info
- [X] Manga
	- [X] Basic info
	- [X] Characters
	- [X] Pictures
	- [X] News
	- [X] Forum
	- [X] Stats
	- [X] More Info
- [X] Seasons
- [X] Schedule
- [X] Top Anime
- [X] Top Manga
- [X] Top Characters
- [X] Top People
- [X] Characters
	- [X] Episodes
- [X] Person
	- [X] Pictures
- [X] Users
- [ ] Search ~~Partial Support~~

# Usage
***C#***
```csharp
// Initialize
IJikan Jikan = new Jikan();

// Get Anime by ID --Fate/Zero
Anime fateZero = Jikan.GetAnime(10087).Result

// Get Manga by ID --Horimiya
Manga horimiya = Jikan.GetManga(42451).Result

// Get Person by ID --Hanazawa, Kana
Person hanazawaKana = Jikan.GetPeron(185).Result

// Get Character by ID --Shiraishi, Urara
Character shiraishiUrara = Jikan.GetCharacter(57491).Result

// Get data from a specified season
Season summer = Jikan.GetSeason(2018, AnimeSeason.Summer).Result

// Or get general season data
Season summer = Jikan.GetSeason(2018).Result

// Get Schedule for an specific day
Schedule monday = Jikan.GetSchedule(ScheduleDay.Monday).Result

// Or get the week schedule
Schedule week = Jikan.GetShecule().Result

// You can make simple search (Advanced search coming soon)
var query = "your search"
AnimeSearchResult search = Jikan.SearchAnime(query).Result
MangaSearchResult search = Jikan.SearchManga(query).Result
PersonSearchResult search = Jikan.SearchPerson(query).Result
CharacterSearchResult search = Jikan.SearchCharacter(query).Result

// You can get data like
var japaneseTitle = fateZero.TitleJapanese
var endingThemes = fateZero.EndingThemes // Collection
var volumes = horimiya.Volumes
var synopsis = horimiya.Synopsis
// and more, explore it
```
***VB***
```vbnet
' Initialize
Dim Jikan As IJikan = New Jikan()

' Get Anime by ID --Fate/Zero
Dim fateZero As Anime = Jikan.GetAnime(10087).Result

' Get Manga by ID --Horimiya
Dim horimiya As Manga = Jikan.GetManga(42451).Result

' Get Person by ID --Hanazawa, Kana
Dim hanazawaKana As Person = Jikan.GetPeron(185).Result

' Get Character by ID --Shiraishi, Urara
Dim shiraishiUrara As Character = Jikan.GetCharacter(57491).Result

' Get data from a specified season
Dim summer As Season = Jikan.GetSeason(2018, AnimeSeason.Summer).Result

' Or get general season data
Dim summer As Season = Jikan.GetSeason(2018).Result

' Get Schedule for an specific day
Dim monday As Schedule = Jikan.GetSchedule(ScheduleDay.Monday).Result

' Or get the week schedule
Dim week As Schedule = Jikan.GetShecule().Result

' You can make simple search (Advanced search coming soon)
Dim query = "your search"
Dim search As AnimeSearchResult = Jikan.SearchAnime(query).Result
Dim search As MangaSearchResult = Jikan.SearchManga(query).Result
Dim search As PersonSearchResult = Jikan.SearchPerson(query).Result
Dim search As CharacterSearchResult = Jikan.SearchCharacter(query).Result

' You can get data like
Dim japaneseTitle = fateZero.TitleJapanese
Dim endingThemes = fateZero.EndingThemes ' Collection
Dim volumes = horimiya.Volumes
Dim synopsis = horimiya.Synopsis
' and more, explore it
```