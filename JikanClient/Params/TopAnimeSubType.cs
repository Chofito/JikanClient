using System.ComponentModel;

namespace JikanClient.Params
{
    public enum TopAnimeSubType
    {
        [Description("airing")] TopAiring,

        [Description("upcoming")] TopUpcoming,

        [Description("tv")] TopTv,

        [Description("movies")] TopMovies,

        [Description("ova")] TopOva,

        [Description("special")] TopSpecial,

        [Description("bypopularity")] TopPopularity,

        [Description("favorite")] TopFavorite
    }
}