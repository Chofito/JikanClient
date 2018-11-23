using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JikanClient.EnumExtensions;
using JikanClient.Exceptions;
using JikanClient.Interfaces;
using JikanClient.Models.AnimeData;
using JikanClient.Models.Character;
using JikanClient.Models.Genres;
using JikanClient.Models.Magazine;
using JikanClient.Models.MangaData;
using JikanClient.Models.Person;
using JikanClient.Models.Producers;
using JikanClient.Models.Schedule;
using JikanClient.Models.Search;
using JikanClient.Models.Seasons;
using JikanClient.Models.Top;
using JikanClient.Params;
using JikanClient.Resource;
using Newtonsoft.Json;

namespace JikanClient
{
    public class Jikan : IJikan
    {
        #region Properties

        private static readonly string _jikanLink = "https://api.jikan.moe";

        private static HttpClient _jikanHttpClient = new HttpClient()
        {
            BaseAddress = new Uri(_jikanLink)
        };

        #endregion

        #region Constructors

        public Jikan()
        {
            _jikanHttpClient.DefaultRequestHeaders.Accept.Clear();
            _jikanHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #endregion

        #region Connection

        private static async Task<T> ExecuteGetRequest<T>(string[] args) where T : class
        {
            T returnedObject;
            var request = string.Join("/", args);

            try
            {
                var response = await _jikanHttpClient.GetAsync(request);

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
            catch (JsonSerializationException e)
            {
                throw new JikanRequestException(Errors.SerializationFailed + Environment.NewLine + "Inner exception message: " + e.Message);

            }

            return returnedObject;
        }

        #endregion

        #region Anime

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
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString(),
                Constants.Videos
            };
            return await ExecuteGetRequest<AnimeVideos>(request);
        }

        public async Task<AnimeStats> GetAnimeStats(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString(),
                Constants.Stats
            };
            return await ExecuteGetRequest<AnimeStats>(request);
        }

        public async Task<AnimeForum> GetAnimeForum(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString(),
                Constants.Forum
            };
            return await ExecuteGetRequest<AnimeForum>(request);
        }

        public async Task<AnimeMoreInfo> GetAnimeMoreInfo(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Anime,
                id.ToString(),
                Constants.MoreInfo
            };
            return await ExecuteGetRequest<AnimeMoreInfo>(request);
        }

        public async Task<TopAnime> GetTopAnime()
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Anime
            };
            return await ExecuteGetRequest<TopAnime>(request);
        }

        public async Task<TopAnime> GetTopAnime(int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Anime,
                page.ToString()
            };
            return await ExecuteGetRequest<TopAnime>(request);
        }

        public async Task<TopAnime> GetTopAnime(TopAnimeSubType subType)
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Anime,
                subType.GetDescription()
            };
            return await ExecuteGetRequest<TopAnime>(request);
        }

        public async Task<TopAnime> GetTopAnime(int page, TopAnimeSubType subType)
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Anime,
                page.ToString(),
                subType.GetDescription()
            };
            return await ExecuteGetRequest<TopAnime>(request);
        }

        public async Task<AnimeByGenre> GetAnimeByGenre(AnimeGenre genre)
        {
            var request = new string[]
            {
                "v3",
                Constants.Genre,
                Constants.Anime,
                genre.GetDescription()
            };
            return await ExecuteGetRequest<AnimeByGenre>(request);
        }

        public async Task<AnimeByGenre> GetAnimeByGenre(AnimeGenre genre, int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Genre,
                Constants.Anime,
                genre.GetDescription(),
                page.ToString()
            };
            return await ExecuteGetRequest<AnimeByGenre>(request);
        }

        public async Task<MangaByGenre> GetMangaByGenre(MangaGenre genre)
        {
            var request = new string[]
            {
                "v3",
                Constants.Genre,
                Constants.Manga,
                genre.GetDescription()
            };
            return await ExecuteGetRequest<MangaByGenre>(request);
        }

        public async Task<MangaByGenre> GetMangaByGenre(MangaGenre genre, int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Genre,
                Constants.Manga,
                genre.GetDescription(),
                page.ToString()
            };
            return await ExecuteGetRequest<MangaByGenre>(request);
        }

        public async Task<AnimeByProducer> GetAnimeByProducer(int producerId)
        {
            var request = new string[]
            {
                "v3",
                Constants.Producer,
                producerId.ToString()
            };
            return await ExecuteGetRequest<AnimeByProducer>(request);
        }

        public async Task<AnimeByProducer> GetAnimeByProducer(int producerId, int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Producer,
                producerId.ToString(),
                page.ToString()
            };
            return await ExecuteGetRequest<AnimeByProducer>(request);
        }

        #endregion

        #region Manga

        public async Task<Manga> GetManga(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Manga,
                id.ToString()
            };
            return await ExecuteGetRequest<Manga>(request);
        }

        public async Task<MangaCharacters> GetMangaCharacters(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Manga,
                id.ToString(),
                Constants.MangaCharacters
            };
            return await ExecuteGetRequest<MangaCharacters>(request);
        }

        public async Task<MangaNews> GetMangaNews(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Manga,
                id.ToString(),
                Constants.News
            };
            return await ExecuteGetRequest<MangaNews>(request);
        }

        public async Task<MangaPictures> GetMangaPictures(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Manga,
                id.ToString(),
                Constants.Pictures
            };
            return await ExecuteGetRequest<MangaPictures>(request);
        }

        public async Task<MangaStats> GetMangaStats(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Manga,
                id.ToString(),
                Constants.Stats
            };
            return await ExecuteGetRequest<MangaStats>(request);
        }

        public async Task<MangaForum> GetMangaForum(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Manga,
                id.ToString(),
                Constants.Forum
            };
            return await ExecuteGetRequest<MangaForum>(request);
        }

        public async Task<MangaMoreInfo> GetMangaMoreInfo(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Manga,
                id.ToString(),
                Constants.MoreInfo
            };
            return await ExecuteGetRequest<MangaMoreInfo>(request);
        }

        public async Task<TopManga> GetTopManga()
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Anime
            };
            return await ExecuteGetRequest<TopManga>(request);
        }

        public async Task<TopManga> GetTopManga(int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Anime,
                page.ToString()
            };
            return await ExecuteGetRequest<TopManga>(request);
        }

        public async Task<TopManga> GetTopManga(TopMangaSubType subType)
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Anime,
                subType.GetDescription()
            };
            return await ExecuteGetRequest<TopManga>(request);
        }

        public async Task<TopManga> GetTopManga(int page, TopMangaSubType subType)
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Anime,
                page.ToString(),
                subType.GetDescription()
            };
            return await ExecuteGetRequest<TopManga>(request);
        }

        public async Task<MangaByMagazine> GetMangaByMagazine(int magazineId)
        {
            var request = new string[]
            {
                "v3",
                Constants.Magazine,
                magazineId.ToString()
            };
            return await ExecuteGetRequest<MangaByMagazine>(request);
        }

        public async Task<MangaByMagazine> GetMangaByMagazine(int magazineId, int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Magazine,
                magazineId.ToString(),
                page.ToString()
            };
            return await ExecuteGetRequest<MangaByMagazine>(request);
        }

        #endregion

        #region Person

        public async Task<Person> GetPerson(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Person,
                id.ToString()
            };
            return await ExecuteGetRequest<Person>(request);
        }

        public async Task<PersonPictures> GetPersonPictures(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Person,
                id.ToString(),
                Constants.Pictures
            };
            return await ExecuteGetRequest<PersonPictures>(request);
        }

        public async Task<TopPeople> GetTopPeople()
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.People
            };
            return await ExecuteGetRequest<TopPeople>(request);
        }

        public async Task<TopPeople> GetTopPeople(int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.People,
                page.ToString()
            };
            return await ExecuteGetRequest<TopPeople>(request);
        }

        #endregion

        #region Character

        public async Task<Character> GetCharacter(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Character,
                id.ToString()
            };
            return await ExecuteGetRequest<Character>(request);
        }

        public async Task<CharacterPictures> GetCharacterPictures(int id)
        {
            var request = new string[]
            {
                "v3",
                Constants.Character,
                id.ToString(),
                Constants.Pictures
            };
            return await ExecuteGetRequest<CharacterPictures>(request);
        }

        public async Task<TopCharacter> GetTopCharacter()
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Character
            };
            return await ExecuteGetRequest<TopCharacter>(request);
        }

        public async Task<TopCharacter> GetTopCharacter(int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Top,
                Constants.Character,
                page.ToString()
            };
            return await ExecuteGetRequest<TopCharacter>(request);
        }

        #endregion

        #region Seasons

        public async Task<Season> GetSeason()
        {
            var request = new string[]
            {
                "v3",
                Constants.Season
            };
            return await ExecuteGetRequest<Season>(request);
        }

        public async Task<Season> GetSeason(int year, AnimeSeason season)
        {
            var request = new string[]
            {
                "v3",
                Constants.Season,
                year.ToString(),
                season.GetDescription()
            };
            return await ExecuteGetRequest<Season>(request);
        }

        public async Task<SeasonArchive> GetSeasonArchive()
        {
            var request = new string[]
            {
                "v3",
                Constants.Season,
                Constants.SeasonArchive
            };
            return await ExecuteGetRequest<SeasonArchive>(request);
        }

        #endregion

        #region Schedule

        public async Task<Schedule> GetSchedule()
        {
            var request = new string[]
            {
                "v3",
                Constants.Schedule
            };
            return await ExecuteGetRequest<Schedule>(request);
        }

        public async Task<Schedule> GetSchedule(ScheduleDay day)
        {
            var request = new string[]
            {
                "v3",
                Constants.Schedule,
                day.GetDescription()
            };
            
            return await ExecuteGetRequest<Schedule>(request);
        }

        #endregion

        #region Searchs

        public async Task<AnimeSearchResult> SearchAnime(string query)
        {
            var request = new string[]
            {
                "v3",
                Constants.Search,
                $"anime?q={query}"
            };
            return await ExecuteGetRequest<AnimeSearchResult>(request);
        }

        public async Task<AnimeSearchResult> SearchAnime(string query, int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Search,
                $"anime?q={query}&page={page}"
            };
            return await ExecuteGetRequest<AnimeSearchResult>(request);
        }

        public async Task<MangaSearchResult> SearchManga(string query)
        {
            var request = new string[]
            {
                "v3",
                Constants.Search,
                $"manga?q={query}"
            };
            return await ExecuteGetRequest<MangaSearchResult>(request);
        }

        public async Task<MangaSearchResult> SearchManga(string query, int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Search,
                $"manga?q={query}&page={page}"
            };
            return await ExecuteGetRequest<MangaSearchResult>(request);
        }

        public async Task<PersonSearchResult> SearchPerson(string query)
        {
            var request = new string[]
            {
                "v3",
                Constants.Search,
                $"person?q={query}"
            };
            return await ExecuteGetRequest<PersonSearchResult>(request);
        }

        public async Task<PersonSearchResult> SearchPerson(string query, int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Search,
                $"person?q={query}&page={page}"
            };
            return await ExecuteGetRequest<PersonSearchResult>(request);
        }

        public async Task<CharacterSearchResult> SearchCharacter(string query)
        {
            var request = new string[]
            {
                "v3",
                Constants.Search,
                $"character?q={query}"
            };
            return await ExecuteGetRequest<CharacterSearchResult>(request);
        }

        public async Task<CharacterSearchResult> SearchCharacter(string query, int page)
        {
            var request = new string[]
            {
                "v3",
                Constants.Search,
                $"character?q={query}&page={page}"
            };
            return await ExecuteGetRequest<CharacterSearchResult>(request);
        }

        #endregion
    }
}