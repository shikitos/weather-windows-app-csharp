using System;
using System.Collections.Generic;

public static class WeatherControllerUtility
{
    public static string GetConditionImage(Condition condition, string requestTime)
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
        if (clearCodes.Contains(code)) category = "";
        else if (rainyCodes.Contains(code)) category = "_rain";
        else if (snowyCodes.Contains(code)) category = "_snow";
        else if (rainSnowCodes.Contains(code)) category = "_rain_snow";
        return category;
    }
    public static string GetDayTime(string time)
    {
        if (DateTime.TryParse(time, out DateTime dateTime))
        {
            if (dateTime.Hour >= 6 && dateTime.Hour < 18)
                return "Day";
            else if (dateTime.Hour >= 18 && dateTime.Hour < 22)
                return "Evening";
            else
                return "Night";
        }
        else
        {
            return null;
        }
    }

}