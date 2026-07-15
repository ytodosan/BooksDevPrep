namespace Terrasoft.Configuration.UsrLibrary
{
    public static class UsrBookCategorizer
    {
        public const int ClassicThreshold = 1950;

        public static bool IsClassic(int year)
        {
            return year > 0 && year < ClassicThreshold;
        }
        public static bool IsAncient(int year)
        {
            return year > 0 && year < 1500;
        }
    }
}