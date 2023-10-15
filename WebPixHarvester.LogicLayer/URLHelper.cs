using System.Text.RegularExpressions;

namespace WebPixHarvester.LogicLayer
{
    public static class URLHelper
    {
        public static bool IsUrlValid(string input)
        {
            string urlPattern = @"^(https?|ftp):\/\/[^\s\/$.?#].[^\s]*$";
            Regex regex = new Regex(urlPattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(input);
        }
    }
}