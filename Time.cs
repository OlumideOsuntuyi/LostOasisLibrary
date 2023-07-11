namespace LostOasisLibrary
{
    namespace UnityEngine
    {
        namespace Time
        {
            public static class Time
            {
                public static bool IsDateTimeFormat(string input)
                {
                    DateTime result;
                    return DateTime.TryParse(input, out result);
                }
                public static float ConvertDateTimeToFloat(DateTime dateTime)
                {
                    return (float)dateTime.Ticks / TimeSpan.TicksPerSecond;
                }

                public static DateTime AddSecondsToDateTime(DateTime dateTime, float seconds)
                {
                    return dateTime.AddSeconds(seconds);
                }

                public static float SubtractDateTimes(DateTime dateTime1, DateTime dateTime2)
                {
                    TimeSpan timeSpan = dateTime2 - dateTime1;
                    return (float)timeSpan.TotalSeconds;
                }

                public static string GetDateComponent(DateTime dateTime)
                {
                    return dateTime.ToString("MM dd yy");
                }

                public static string GetTimeComponent(DateTime dateTime)
                {
                    return dateTime.ToString("HH:mm");
                }

                public static string GetPhoneMessagingFormat(DateTime dateTime)
                {
                    return dateTime.ToString("MMM dd, yyyy h:mm tt");
                }

                public static string DateTimeToString(DateTime dateTime)
                {
                    return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                }

                public static DateTime StringToDateTime(string dateTimeString)
                {
                    if (dateTimeString is null or "")
                    {
                        return System.DateTime.UtcNow;
                    }
                    return DateTime.ParseExact(dateTimeString, "yyyy-MM-dd HH:mm:ss", null);
                }
                public static string GetTimeDifferenceAsString(DateTime dateTime1, DateTime dateTime2)
                {
                    TimeSpan timeSpan = dateTime2 - dateTime1;
                    if (timeSpan.TotalSeconds < 60)
                    {
                        return $"{timeSpan.Seconds} seconds ago";
                    }
                    else if (timeSpan.TotalMinutes < 60)
                    {
                        return $"{timeSpan.Minutes} minutes ago";
                    }
                    else if (timeSpan.TotalHours < 24)
                    {
                        return $"{timeSpan.Hours} hours ago";
                    }
                    else
                    {
                        int days = (int)timeSpan.TotalDays;
                        if (days == 1)
                        {
                            return "Yesterday";
                        }
                        else if (days < 7)
                        {
                            return $"{days} days ago";
                        }
                        else
                        {
                            int weeks = days / 7;
                            if (weeks < 52)
                            {
                                return $"{weeks} weeks ago";
                            }
                            else
                            {
                                int years = weeks / 52;
                                return $"{years} years ago";
                            }
                        }
                    }
                }
                public static bool IsTimeAfter(DateTime currentTime, int targetHour, int targetMinute)
                {
                    // Create a DateTime object for the target time
                    DateTime targetTime = currentTime.Date.AddHours(targetHour).AddMinutes(targetMinute);

                    // Compare the current time with the target time
                    return currentTime > targetTime;
                }
            }
        }
    }
}