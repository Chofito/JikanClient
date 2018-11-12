using System;
using System.Net.Http;
using System.Threading.Tasks;
using JikanClient.Connection;
using JikanClient.Exceptions;
using JikanClient.Interfaces;
using JikanClient.Models.Anime;
using JikanClient.Models.Character;
using JikanClient.Models.Genres;
using JikanClient.Models.Manga;
using JikanClient.Models.Person;
using JikanClient.Models.Producers;
using JikanClient.Models.Schedule;
using JikanClient.Models.Seasons;
using JikanClient.Models.Top;
using JikanClient.Params;
using JikanClient.Resource;
using Newtonsoft.Json;

namespace JikanClient
{
    public class Jikan : IJikan
    {
        private readonly HttpClient _jikanHttpClient;

        public Jikan()
        {
            _jikanHttpClient = HttpProvider.GetJikanHttpClient();
        }

        public async Task<T> ExecuteGetRequest<T>(string[] args) where T : class
        {
            T returnedObject;
            var requestUrl = String.Join("/", args);

            try
            {
                using (HttpResponseMessage response = await _jikanHttpClient.GetAsync(requestUrl))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        returnedObject = JsonConvert.DeserializeObject<T>(json);
                    }
                    else
                    {
                        throw new JikanRequestException(string.Format(Errors.FailedRequest, response.Content), response.StatusCode);
                    }  
                }
            }
            catch (JsonSerializationException e)
            {
                throw new JikanRequestException(Errors.SerializationFailed + Environment.NewLine + "Inner exception message: " + e.Message);
            }

            return returnedObject;
        }
        
        public async Task<Anime> GetAnime(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString()
            };
            return await ExecuteGetRequest<Anime>(request);
        }

        public async Task<AnimeCharactersAndStaff> GetAnimeCharactersAndStaff(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString(),
                Constants.AnimeCharactersStaff
            };
            return await ExecuteGetRequest<AnimeCharactersAndStaff>(request);
        }

        public async Task<AnimeEpisodes> GetAnimeEpisodes(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString(),
                Constants.Episodes
            };
            return await ExecuteGetRequest<AnimeEpisodes>(request);
        }

        public async Task<AnimeEpisodes> GetAnimeEpisodes(int id, int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString(),
                Constants.Episodes,
                page.ToString()
            };
            return await ExecuteGetRequest<AnimeEpisodes>(request);
        }

        public async Task<AnimeNews> GetAnimeNews(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString(),
                Constants.News
            };
            return await ExecuteGetRequest<AnimeNews>(request);
        }

        public async Task<AnimePictures> GetAnimePictures(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString(),
                Constants.Pictures
            };
            return await ExecuteGetRequest<AnimePictures>(request);
        }

        public async Task<AnimeVideos> GetAnimeVideos(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnimeStats> GetAnimeStats(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnimeForum> GetAnimeForum(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnimeMoreInfo> GetAnimeMoreInfo(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Manga> GetManga(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MangaCharacters> GetMangaCharacters(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MangaNews> GetMangaNews(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MangaPictures> GetMangaPictures(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MangaStats> GetMangaStats(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MangaForum> GetMangaForum(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MangaMoreInfo> GetMangaMoreInfo(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Person> GetPerson(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PersonPictures> GetPersonPictures(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Character> GetCharacter(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CharacterPictures> GetCharacterPictures(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Season> GetSeason()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Season> GetSeason(int year, AnimeSeason season)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SeasonArchive> GetSeasonArchive()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Schedule> GetSchedule()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Schedule> GetSchedule(ScheduleDay day)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopAnime> GetTopAnime()
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopAnime> GetTopAnime(int page)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopAnime> GetTopAnime(TopAnimeSubType subType)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopAnime> GetTopAnime(int page, TopAnimeSubType subType)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopManga> GetTopManga()
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopManga> GetTopManga(int page)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopManga> GetTopManga(TopMangaSubType subType)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopManga> GetTopManga(int page, TopMangaSubType subType)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopCharacter> GetTopCharacter()
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopCharacter> GetTopCharacter(int page)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopPeople> GetTopPeople()
        {
            throw new System.NotImplementedException();
        }

        public async Task<TopPeople> GetTopPeople(int page)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnimeByGenre> GetAnimeByGenre(AnimeGenre genre)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnimeByGenre> GetAnimeByGenre(AnimeGenre genre, int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MangaByGenre> GetMangaByGenre(MangaGenre genre)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MangaByGenre> GetMangaByGenre(MangaGenre genre, int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnimeByProducer> GetAnimeByProducer(int producerId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnimeByProducer> GetAnimeByProducer(int producerId, int page)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnimeByProducer> GetMangaByMagazine(int magazineId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnimeByProducer> GetMangaByMagazine(int magazineId, int page)
        {
            throw new System.NotImplementedException();
        }
    }
}