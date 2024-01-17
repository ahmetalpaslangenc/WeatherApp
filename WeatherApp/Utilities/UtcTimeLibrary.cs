using System;

namespace WeatherApp.Utilities
{
    public static class UtcTimeLibrary
    {
        public static DateTime ConvertToUtc(int unixTimeStamp)
        {
            // UNIX tarih damgasýný tarih ve saat nesnesine dönüþtür
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return unixEpoch.AddSeconds(unixTimeStamp).ToLocalTime();
        }
    }
}
