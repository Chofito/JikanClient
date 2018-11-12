using System.ComponentModel;

namespace JikanClient.Params
{
    public enum TopMangaSubType
    {
        [Description("manga")]
        TopManga,

        [Description("novel")]
        TopNovel,

        [Description("oneshot")]
        TopOneShot,

        [Description("doujinshi")]
        TopDoujinshi,

        [Description("manhwa")]
        TopManhwa,

        [Description("manhua")]
        TopManhua,

        [Description("bypopularity")]
        TopPopularity,

        [Description("favorite")]
        TopFavorite
    }
}