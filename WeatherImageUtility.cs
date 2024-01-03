using System;
using System.Collections.Generic;

public class WeatherControllerUtility
{
    public static string GetConditionImage(Condition condition, long requestTime)
    {
        string timeDay = GetDayTime(requestTime);
        string conditionType = GetConditionType(condition);
        string imagePath = $"{timeDay}{conditionType}.png";
        return imagePath;
    }

    public static string GetConditionType(Condition condition)
    {
        var clearCodes = new HashSet<int> { 1000, 1009, 1030, 1135, 1147 };
        var rainyCodes = new HashSet<int> { 1063, 1072, 1087, 1150, 1153, 1168, 1171, 1180, 1183, 1186, 1189, 1192, 1195, 1198, 1201, 1240, 1243, 1246, 1273, 1276 };
        var snowyCodes = new HashSet<int> { 1066, 1114, 1117, 1210, 1213, 1216, 1219, 1222, 1225, 1255, 1258, 1279, 1282 };
        var rainSnowCodes = new HashSet<int> { 1069, 1204, 1207, 1237, 1249, 1252, 1261, 1264 };

        int code = condition.Code;

        string category = "";
        if (clearCodes.Contains(code))
            category = "";
        else if (rainyCodes.Contains(code))
            category = "_rain";
        else if (snowyCodes.Contains(code))
            category = "_snow";
        else if (rainSnowCodes.Contains(code))
            category = "_rain_snow";
        return category;
    }
    public static string GetDayTime(long epochTime)
    {
        DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        DateTime dateTime = epoch.AddSeconds(epochTime).ToLocalTime();

        string timeOfDay;
        if (dateTime.Hour >= 6 && dateTime.Hour < 18)
            timeOfDay = "Day";
        else if (dateTime.Hour >= 18 && dateTime.Hour < 22)
            timeOfDay = "Evening";
        else
            timeOfDay = "Night";
        return timeOfDay;
    }
}