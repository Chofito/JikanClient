using System;
using Xunit;
using JikanClient;
using JikanClient.Interfaces;
using JikanClient.Params;
using Newtonsoft.Json;

namespace JikanTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IJikan Jikan = new Jikan();

            var data = Jikan.GetSchedule(ScheduleDay.Friday).Result;
            //var data = Jikan.GetManga(1).Result;

            var json = JsonConvert.SerializeObject(data, Formatting.Indented);

            System.IO.File.WriteAllText(@"C:\Users\DesarrolloLS04\Desktop\data.txt", json);
        }
    }
}
