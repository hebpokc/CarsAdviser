using System.Collections.Generic;

namespace CarsAdviser.Database
{
    internal class UserPreferencesStorage
    {
        private static List<Cars> userPreferences = new List<Cars>();
        public static void UpdateUserPreferences(List<Cars> preferences)
        {
            userPreferences = preferences;
        }

        public static List<Cars> GetUserPreferences()
        {
            return userPreferences;
        }
    }
}
