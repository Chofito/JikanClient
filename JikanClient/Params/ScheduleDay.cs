using System.ComponentModel;

namespace JikanClient.Params
{
    public enum ScheduleDay
    {
        [Description("monday")]
        Monday,

        [Description("tuesday")]
        Tuesday,

        [Description("wednesday")]
        Wednesday,

        [Description("thursday")]
        Thursday,

        [Description("friday")]
        Friday,

        [Description("saturday")]
        Saturday,

        [Description("sunday")]
        Sunday,

        [Description("other")]
        Other,

        [Description("unknown")]
        Unknown
    }
}