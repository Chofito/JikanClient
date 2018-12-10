using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JikanClient.Exceptions;
using JikanClient.Extensions;
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
    /// <summary>
    ///     The main class.
    ///     Contains all methods for get data from MAL.
    /// </summary>
    public class Jikan : IJikan
    {
        #region Constructors

        /// <summary>
        ///     Constructor for JikanClient.
        /// </summary>
        /// <param name="secure">True if you want to use HTTPS, false for HTTP, by default is true.</param>
        public Jikan(bool secure = true)
        {
            JikanHttpClient.BaseAddress = secure ? new Uri(_jikanLinkHttps) : new Uri(_jikanLinkHttp);
            JikanHttpClient.DefaultRequestHeaders.Accept.Clear();
            JikanHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #endregion

        #region Connection

        private static async Task<T> ExecuteGetRequestAsync<T>(string[] args) where T : class
        {
            T returnedObject;
            var request = "v3/" + Uri.EscapeUriString(string.Join("/", args));

            try
            {
                var response = await JikanHttpClient.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    returnedObject = await Task.Run(() => JsonConvert.DeserializeObject<T>(json));
                }
                else
                {
                    throw new JikanRequestException(string.Format(Errors.FailedRequest, response.Content),
                        response.StatusCode);
                }
            }
            catch (JsonSerializationException e)
            {
                throw new JikanRequestException(Errors.SerializationFailed + Environment.NewLine +
                                                "Inner exception message: " + e.Message);
            }

            return returnedObject;
        }

        #endregion

        #region Properties

        private static readonly string _jikanLinkHttps = "https://api.jikan.moe";
        private static readonly string _jikanLinkHttp = "http://api.jikan.moe";

        private static readonly HttpClient JikanHttpClient = new HttpClient();

        #endregion

        #region Anime

        /// <summary>
        ///     Get Anime Information from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <returns>Return Anime Object</returns>
        public async Task<Anime> GetAnimeAsync(int id)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString()
            };
            return await ExecuteGetRequestAsync<Anime>(request);
        }

        /// <summary>
        ///     Get Anime Characters And Staff information from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <returns>Return AnimeCharactersAndStaff Object</returns>
        public async Task<AnimeCharactersAndStaff> GetAnimeCharactersAndStaffAsync(int id)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString(),
                Constants.AnimeCharactersStaff
            };
            return await ExecuteGetRequestAsync<AnimeCharactersAndStaff>(request);
        }

        /// <summary>
        ///     Get Anime Episodes information from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <returns>Return AnimeEpisodes Object</returns>
        public async Task<AnimeEpisodes> GetAnimeEpisodesAsync(int id)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString(),
                Constants.Episodes
            };
            return await ExecuteGetRequestAsync<AnimeEpisodes>(request);
        }

        /// <summary>
        ///     Get Anime Episodes information from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <param name="page">
        ///     The episodes page on MyAnimeList get paginated after 100 episodes.
        ///     If there's an anime with more than 100 episodes, you'll have to use the parameter.
        /// </param>
        /// <returns>Return AnimeEpisodes Object</returns>
        public async Task<AnimeEpisodes> GetAnimeEpisodesAsync(int id, int page)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString(),
                Constants.Episodes,
                page.ToString()
            };
            return await ExecuteGetRequestAsync<AnimeEpisodes>(request);
        }

        /// <summary>
        ///     Get Anime News from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <returns>Return AnimeNews Object</returns>
        public async Task<AnimeNews> GetAnimeNewsAsync(int id)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString(),
                Constants.News
            };
            return await ExecuteGetRequestAsync<AnimeNews>(request);
        }

        /// <summary>
        ///     Get Anime Pictures URL's from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <returns>Return AnimePictures Object</returns>
        public async Task<AnimePictures> GetAnimePicturesAsync(int id)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString(),
                Constants.Pictures
            };
            return await ExecuteGetRequestAsync<AnimePictures>(request);
        }

        /// <summary>
        ///     Get Anime Videos URL's from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <returns>Return AnimeVideos Object</returns>
        public async Task<AnimeVideos> GetAnimeVideosAsync(int id)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString(),
                Constants.Videos
            };
            return await ExecuteGetRequestAsync<AnimeVideos>(request);
        }

        /// <summary>
        ///     Get Anime Statistics from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <returns>Return AnimeStats Object</returns>
        public async Task<AnimeStats> GetAnimeStatsAsync(int id)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString(),
                Constants.Stats
            };
            return await ExecuteGetRequestAsync<AnimeStats>(request);
        }

        /// <summary>
        ///     Get Anime Forum's post from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <returns>Return AnimeForum Object</returns>
        public async Task<AnimeForum> GetAnimeForumAsync(int id)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString(),
                Constants.Forum
            };
            return await ExecuteGetRequestAsync<AnimeForum>(request);
        }

        /// <summary>
        ///     Get Anime extra infromation from MyAnimeList
        /// </summary>
        /// <param name="id">Anime ID from MAL</param>
        /// <returns>Return AnimeMoreInfo Object</returns>
        public async Task<AnimeMoreInfo> GetAnimeMoreInfoAsync(int id)
        {
            var request = new[]
            {
                Constants.Anime,
                id.ToString(),
                Constants.MoreInfo
            };
            return await ExecuteGetRequestAsync<AnimeMoreInfo>(request);
        }

        public async Task<TopAnime> GetTopAnimeAsync()
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Anime
            };
            return await ExecuteGetRequestAsync<TopAnime>(request);
        }

        public async Task<TopAnime> GetTopAnimeAsync(int page)
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Anime,
                page.ToString()
            };
            return await ExecuteGetRequestAsync<TopAnime>(request);
        }

        public async Task<TopAnime> GetTopAnimeAsync(TopAnimeSubType subType)
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Anime,
                subType.GetDescription()
            };
            return await ExecuteGetRequestAsync<TopAnime>(request);
        }

        public async Task<TopAnime> GetTopAnimeAsync(int page, TopAnimeSubType subType)
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Anime,
                page.ToString(),
                subType.GetDescription()
            };
            return await ExecuteGetRequestAsync<TopAnime>(request);
        }

        public async Task<AnimeByGenre> GetAnimeByGenreAsync(AnimeGenre genre)
        {
            var request = new[]
            {
                Constants.Genre,
                Constants.Anime,
                genre.GetDescription()
            };
            return await ExecuteGetRequestAsync<AnimeByGenre>(request);
        }

        public async Task<AnimeByGenre> GetAnimeByGenreAsync(AnimeGenre genre, int page)
        {
            var request = new[]
            {
                Constants.Genre,
                Constants.Anime,
                genre.GetDescription(),
                page.ToString()
            };
            return await ExecuteGetRequestAsync<AnimeByGenre>(request);
        }

        public async Task<MangaByGenre> GetMangaByGenreAsync(MangaGenre genre)
        {
            var request = new[]
            {
                Constants.Genre,
                Constants.Manga,
                genre.GetDescription()
            };
            return await ExecuteGetRequestAsync<MangaByGenre>(request);
        }

        public async Task<MangaByGenre> GetMangaByGenreAsync(MangaGenre genre, int page)
        {
            var request = new[]
            {
                Constants.Genre,
                Constants.Manga,
                genre.GetDescription(),
                page.ToString()
            };
            return await ExecuteGetRequestAsync<MangaByGenre>(request);
        }

        public async Task<AnimeByProducer> GetAnimeByProducerAsync(int producerId)
        {
            var request = new[]
            {
                Constants.Producer,
                producerId.ToString()
            };
            return await ExecuteGetRequestAsync<AnimeByProducer>(request);
        }

        public async Task<AnimeByProducer> GetAnimeByProducerAsync(int producerId, int page)
        {
            var request = new[]
            {
                Constants.Producer,
                producerId.ToString(),
                page.ToString()
            };
            return await ExecuteGetRequestAsync<AnimeByProducer>(request);
        }

        #endregion

        #region Manga

        public async Task<Manga> GetMangaAsync(int id)
        {
            var request = new[]
            {
                Constants.Manga,
                id.ToString()
            };
            return await ExecuteGetRequestAsync<Manga>(request);
        }

        public async Task<MangaCharacters> GetMangaCharactersAsync(int id)
        {
            var request = new[]
            {
                Constants.Manga,
                id.ToString(),
                Constants.MangaCharacters
            };
            return await ExecuteGetRequestAsync<MangaCharacters>(request);
        }

        public async Task<MangaNews> GetMangaNewsAsync(int id)
        {
            var request = new[]
            {
                Constants.Manga,
                id.ToString(),
                Constants.News
            };
            return await ExecuteGetRequestAsync<MangaNews>(request);
        }

        public async Task<MangaPictures> GetMangaPicturesAsync(int id)
        {
            var request = new[]
            {
                Constants.Manga,
                id.ToString(),
                Constants.Pictures
            };
            return await ExecuteGetRequestAsync<MangaPictures>(request);
        }

        public async Task<MangaStats> GetMangaStatsAsync(int id)
        {
            var request = new[]
            {
                Constants.Manga,
                id.ToString(),
                Constants.Stats
            };
            return await ExecuteGetRequestAsync<MangaStats>(request);
        }

        public async Task<MangaForum> GetMangaForumAsync(int id)
        {
            var request = new[]
            {
                Constants.Manga,
                id.ToString(),
                Constants.Forum
            };
            return await ExecuteGetRequestAsync<MangaForum>(request);
        }

        public async Task<MangaMoreInfo> GetMangaMoreInfoAsync(int id)
        {
            var request = new[]
            {
                Constants.Manga,
                id.ToString(),
                Constants.MoreInfo
            };
            return await ExecuteGetRequestAsync<MangaMoreInfo>(request);
        }

        public async Task<TopManga> GetTopMangaAsync()
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Anime
            };
            return await ExecuteGetRequestAsync<TopManga>(request);
        }

        public async Task<TopManga> GetTopMangaAsync(int page)
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Anime,
                page.ToString()
            };
            return await ExecuteGetRequestAsync<TopManga>(request);
        }

        public async Task<TopManga> GetTopMangaAsync(TopMangaSubType subType)
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Anime,
                subType.GetDescription()
            };
            return await ExecuteGetRequestAsync<TopManga>(request);
        }

        public async Task<TopManga> GetTopMangaAsync(int page, TopMangaSubType subType)
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Anime,
                page.ToString(),
                subType.GetDescription()
            };
            return await ExecuteGetRequestAsync<TopManga>(request);
        }

        public async Task<MangaByMagazine> GetMangaByMagazineAsync(int magazineId)
        {
            var request = new[]
            {
                Constants.Magazine,
                magazineId.ToString()
            };
            return await ExecuteGetRequestAsync<MangaByMagazine>(request);
        }

        public async Task<MangaByMagazine> GetMangaByMagazineAsync(int magazineId, int page)
        {
            var request = new[]
            {
                Constants.Magazine,
                magazineId.ToString(),
                page.ToString()
            };
            return await ExecuteGetRequestAsync<MangaByMagazine>(request);
        }

        #endregion

        #region Person/People

        public async Task<Person> GetPersonAsync(int id)
        {
            var request = new[]
            {
                Constants.Person,
                id.ToString()
            };
            return await ExecuteGetRequestAsync<Person>(request);
        }

        public async Task<PersonPictures> GetPersonPicturesAsync(int id)
        {
            var request = new[]
            {
                Constants.Person,
                id.ToString(),
                Constants.Pictures
            };
            return await ExecuteGetRequestAsync<PersonPictures>(request);
        }

        public async Task<TopPeople> GetTopPeopleAsync()
        {
            var request = new[]
            {
                Constants.Top,
                Constants.People
            };
            return await ExecuteGetRequestAsync<TopPeople>(request);
        }

        public async Task<TopPeople> GetTopPeopleAsync(int page)
        {
            var request = new[]
            {
                Constants.Top,
                Constants.People,
                page.ToString()
            };
            return await ExecuteGetRequestAsync<TopPeople>(request);
        }

        #endregion

        #region Character

        public async Task<Character> GetCharacterAsync(int id)
        {
            var request = new[]
            {
                Constants.Character,
                id.ToString()
            };
            return await ExecuteGetRequestAsync<Character>(request);
        }

        public async Task<CharacterPictures> GetCharacterPicturesAsync(int id)
        {
            var request = new[]
            {
                Constants.Character,
                id.ToString(),
                Constants.Pictures
            };
            return await ExecuteGetRequestAsync<CharacterPictures>(request);
        }

        public async Task<TopCharacter> GetTopCharacterAsync()
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Character
            };
            return await ExecuteGetRequestAsync<TopCharacter>(request);
        }

        public async Task<TopCharacter> GetTopCharacterAsync(int page)
        {
            var request = new[]
            {
                Constants.Top,
                Constants.Character,
                page.ToString()
            };
            return await ExecuteGetRequestAsync<TopCharacter>(request);
        }

        #endregion

        #region Seasons

        public async Task<Season> GetSeasonAsync()
        {
            var request = new[]
            {
                Constants.Season
            };
            return await ExecuteGetRequestAsync<Season>(request);
        }

        public async Task<Season> GetSeasonAsync(int year, AnimeSeason season)
        {
            var request = new[]
            {
                Constants.Season,
                year.ToString(),
                season.GetDescription()
            };
            return await ExecuteGetRequestAsync<Season>(request);
        }

        public async Task<SeasonArchive> GetSeasonArchiveAsync()
        {
            var request = new[]
            {
                Constants.Season,
                Constants.SeasonArchive
            };
            return await ExecuteGetRequestAsync<SeasonArchive>(request);
        }

        #endregion

        #region Schedule

        public async Task<Schedule> GetScheduleAsync()
        {
            var request = new[]
            {
                Constants.Schedule
            };
            return await ExecuteGetRequestAsync<Schedule>(request);
        }

        public async Task<Schedule> GetScheduleAsync(ScheduleDay day)
        {
            var request = new[]
            {
                Constants.Schedule,
                day.GetDescription()
            };

            return await ExecuteGetRequestAsync<Schedule>(request);
        }

        #endregion

        #region Searchs

        public async Task<AnimeSearchResult> SearchAnimeAsync(string query)
        {
            var request = new[]
            {
                Constants.Search,
                $"anime?q={query}"
            };
            return await ExecuteGetRequestAsync<AnimeSearchResult>(request);
        }

        public async Task<AnimeSearchResult> SearchAnimeAsync(string query, int page)
        {
            var request = new[]
            {
                Constants.Search,
                $"anime?q={query}&page={page}"
            };
            return await ExecuteGetRequestAsync<AnimeSearchResult>(request);
        }

        public async Task<MangaSearchResult> SearchMangaAsync(string query)
        {
            var request = new[]
            {
                Constants.Search,
                $"manga?q={query}"
            };
            return await ExecuteGetRequestAsync<MangaSearchResult>(request);
        }

        public async Task<MangaSearchResult> SearchMangaAsync(string query, int page)
        {
            var request = new[]
            {
                Constants.Search,
                $"manga?q={query}&page={page}"
            };
            return await ExecuteGetRequestAsync<MangaSearchResult>(request);
        }

        public async Task<PersonSearchResult> SearchPersonAsync(string query)
        {
            var request = new[]
            {
                Constants.Search,
                $"person?q={query}"
            };
            return await ExecuteGetRequestAsync<PersonSearchResult>(request);
        }

        public async Task<PersonSearchResult> SearchPersonAsync(string query, int page)
        {
            var request = new[]
            {
                Constants.Search,
                $"person?q={query}&page={page}"
            };
            return await ExecuteGetRequestAsync<PersonSearchResult>(request);
        }

        public async Task<CharacterSearchResult> SearchCharacterAsync(string query)
        {
            var request = new[]
            {
                Constants.Search,
                $"character?q={query}"
            };
            return await ExecuteGetRequestAsync<CharacterSearchResult>(request);
        }

        public async Task<CharacterSearchResult> SearchCharacterAsync(string query, int page)
        {
            var request = new[]
            {
                Constants.Search,
                $"character?q={query}&page={page}"
            };
            return await ExecuteGetRequestAsync<CharacterSearchResult>(request);
        }

        #endregion
    }
}