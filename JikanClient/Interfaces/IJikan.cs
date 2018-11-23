using System.Threading.Tasks;
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

namespace JikanClient.Interfaces
{
    public interface IJikan
    {
        Task<Anime> GetAnime(int id);

        Task<AnimeCharactersAndStaff> GetAnimeCharactersAndStaff(int id);

        Task<AnimeEpisodes> GetAnimeEpisodes(int id);

        Task<AnimeEpisodes> GetAnimeEpisodes(int id, int page);

        Task<AnimeNews> GetAnimeNews(int id);

        Task<AnimePictures> GetAnimePictures(int id);

        Task<AnimeVideos> GetAnimeVideos(int id);

        Task<AnimeStats> GetAnimeStats(int id);

        Task<AnimeForum> GetAnimeForum(int id);

        Task<AnimeMoreInfo> GetAnimeMoreInfo(int id);

        Task<Manga> GetManga(int id);

        Task<MangaCharacters> GetMangaCharacters(int id);

        Task<MangaNews> GetMangaNews(int id);

        Task<MangaPictures> GetMangaPictures(int id);

        Task<MangaStats> GetMangaStats(int id);

        Task<MangaForum> GetMangaForum(int id);

        Task<MangaMoreInfo> GetMangaMoreInfo(int id);

        Task<Person> GetPerson(int id);

        Task<PersonPictures> GetPersonPictures(int id);

        Task<Character> GetCharacter(int id);

        Task<CharacterPictures> GetCharacterPictures(int id);

        Task<Season> GetSeason();

        Task<Season> GetSeason(int year, AnimeSeason season);

        Task<SeasonArchive> GetSeasonArchive();

        Task<Schedule> GetSchedule();

        Task<Schedule> GetSchedule(ScheduleDay day);

        Task<TopAnime> GetTopAnime();

        Task<TopAnime> GetTopAnime(int page);

        Task<TopAnime> GetTopAnime(TopAnimeSubType subType);

        Task<TopAnime> GetTopAnime(int page, TopAnimeSubType subType);

        Task<TopManga> GetTopManga();

        Task<TopManga> GetTopManga(int page);

        Task<TopManga> GetTopManga(TopMangaSubType subType);

        Task<TopManga> GetTopManga(int page, TopMangaSubType subType);

        Task<TopCharacter> GetTopCharacter();

        Task<TopCharacter> GetTopCharacter(int page);

        Task<TopPeople> GetTopPeople();

        Task<TopPeople> GetTopPeople(int page);

        Task<AnimeByGenre> GetAnimeByGenre(AnimeGenre genre);

        Task<AnimeByGenre> GetAnimeByGenre(AnimeGenre genre, int id);

        Task<MangaByGenre> GetMangaByGenre(MangaGenre genre);

        Task<MangaByGenre> GetMangaByGenre(MangaGenre genre, int id);

        Task<AnimeByProducer> GetAnimeByProducer(int producerId);

        Task<AnimeByProducer> GetAnimeByProducer(int producerId, int page);

        Task<MangaByMagazine> GetMangaByMagazine(int magazineId);

        Task<MangaByMagazine> GetMangaByMagazine(int magazineId, int page);

        Task<AnimeSearchResult> SearchAnime(string query);

        Task<AnimeSearchResult> SearchAnime(string query, int page);

        Task<MangaSearchResult> SearchManga(string query);
                                     
        Task<MangaSearchResult> SearchManga(string query, int page);

        Task<PersonSearchResult> SearchPerson(string query);
                                      
        Task<PersonSearchResult> SearchPerson(string query, int page);

        Task<CharacterSearchResult> SearchCharacter(string query);
                                     
        Task<CharacterSearchResult> SearchCharacter(string query, int page);
    }
}