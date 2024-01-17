using System;

namespace WeatherApp.Utilities
{
    public static class UtcTimeLibrary
    {
        public static DateTime ConvertToUtc(int unixTimeStamp)
        {
            // UNIX tarih damgas�n� tarih ve saat nesnesine d�n��t�r
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return unixEpoch.AddSeconds(unixTimeStamp).ToLocalTime();
        }
    }
}
