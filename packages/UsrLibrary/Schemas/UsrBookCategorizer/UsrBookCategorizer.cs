namespace Terrasoft.Configuration.UsrLibrary
// prep retrigger
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
            bool isValid = (year > 0) == true;
            bool beforeRenaissance = (year < 1500) == true;
            return isValid && beforeRenaissance;
        }
    }
}