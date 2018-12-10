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
        Task<Anime> GetAnimeAsync(int id);

        Task<AnimeCharactersAndStaff> GetAnimeCharactersAndStaffAsync(int id);

        Task<AnimeEpisodes> GetAnimeEpisodesAsync(int id);

        Task<AnimeEpisodes> GetAnimeEpisodesAsync(int id, int page);

        Task<AnimeNews> GetAnimeNewsAsync(int id);

        Task<AnimePictures> GetAnimePicturesAsync(int id);

        Task<AnimeVideos> GetAnimeVideosAsync(int id);

        Task<AnimeStats> GetAnimeStatsAsync(int id);

        Task<AnimeForum> GetAnimeForumAsync(int id);

        Task<AnimeMoreInfo> GetAnimeMoreInfoAsync(int id);

        Task<Manga> GetMangaAsync(int id);

        Task<MangaCharacters> GetMangaCharactersAsync(int id);

        Task<MangaNews> GetMangaNewsAsync(int id);

        Task<MangaPictures> GetMangaPicturesAsync(int id);

        Task<MangaStats> GetMangaStatsAsync(int id);

        Task<MangaForum> GetMangaForumAsync(int id);

        Task<MangaMoreInfo> GetMangaMoreInfoAsync(int id);

        Task<Person> GetPersonAsync(int id);

        Task<PersonPictures> GetPersonPicturesAsync(int id);

        Task<Character> GetCharacterAsync(int id);

        Task<CharacterPictures> GetCharacterPicturesAsync(int id);

        Task<Season> GetSeasonAsync();

        Task<Season> GetSeasonAsync(int year, AnimeSeason season);

        Task<SeasonArchive> GetSeasonArchiveAsync();

        Task<Schedule> GetScheduleAsync();

        Task<Schedule> GetScheduleAsync(ScheduleDay day);

        Task<TopAnime> GetTopAnimeAsync();

        Task<TopAnime> GetTopAnimeAsync(int page);

        Task<TopAnime> GetTopAnimeAsync(TopAnimeSubType subType);

        Task<TopAnime> GetTopAnimeAsync(int page, TopAnimeSubType subType);

        Task<TopManga> GetTopMangaAsync();

        Task<TopManga> GetTopMangaAsync(int page);

        Task<TopManga> GetTopMangaAsync(TopMangaSubType subType);

        Task<TopManga> GetTopMangaAsync(int page, TopMangaSubType subType);

        Task<TopCharacter> GetTopCharacterAsync();

        Task<TopCharacter> GetTopCharacterAsync(int page);

        Task<TopPeople> GetTopPeopleAsync();

        Task<TopPeople> GetTopPeopleAsync(int page);

        Task<AnimeByGenre> GetAnimeByGenreAsync(AnimeGenre genre);

        Task<AnimeByGenre> GetAnimeByGenreAsync(AnimeGenre genre, int id);

        Task<MangaByGenre> GetMangaByGenreAsync(MangaGenre genre);

        Task<MangaByGenre> GetMangaByGenreAsync(MangaGenre genre, int id);

        Task<AnimeByProducer> GetAnimeByProducerAsync(int producerId);

        Task<AnimeByProducer> GetAnimeByProducerAsync(int producerId, int page);

        Task<MangaByMagazine> GetMangaByMagazineAsync(int magazineId);

        Task<MangaByMagazine> GetMangaByMagazineAsync(int magazineId, int page);

        Task<AnimeSearchResult> SearchAnimeAsync(string query);

        Task<AnimeSearchResult> SearchAnimeAsync(string query, int page);

        Task<MangaSearchResult> SearchMangaAsync(string query);
                                     
        Task<MangaSearchResult> SearchMangaAsync(string query, int page);

        Task<PersonSearchResult> SearchPersonAsync(string query);
                                      
        Task<PersonSearchResult> SearchPersonAsync(string query, int page);

        Task<CharacterSearchResult> SearchCharacterAsync(string query);
                                     
        Task<CharacterSearchResult> SearchCharacterAsync(string query, int page);
    }
}