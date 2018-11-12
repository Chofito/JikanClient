using System.ComponentModel;

namespace JikanClient.Params
{
    public enum UserData
    {
        [Description("profile")] Profile,
        [Description("history")] History,
        [Description("friends")] Friends,
        [Description("animelist")] AnimeList,
        [Description("mangalist")] MangaList
    }
}