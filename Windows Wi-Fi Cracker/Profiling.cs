using System.Collections.Generic;

namespace Windows_Wi_Fi_Cracker {
    static class Profiling {

        public static List<string> GetProfiles() {
            List<string> profiles = new List<string>();
            string profilesRaw = CMD.Execute("netsh wlan show profiles");

            // Remove heading dross
            int profileLocation = profilesRaw.IndexOf("User profiles");
            profilesRaw = profilesRaw.Substring(profileLocation + 28);

            // Extract profiles from response
            bool searching = true;
            while (searching) {
                string profile = "";
                profileLocation = profilesRaw.IndexOf(" : ");
                if (profileLocation == -1) { // If not found
                    searching = false;
                } else { // If found
                    int alpha = profileLocation + 3;
                    profilesRaw = profilesRaw.Substring(alpha);
                    int omega = profilesRaw.IndexOf("\n") - 1;
                    profile = profilesRaw.Substring(0, omega);
                    profilesRaw = profilesRaw.Substring(omega);
                    profiles.Add(profile);
                }
            }

            return profiles;
        }


        public static string GetProfileKey(this string profile) {
            string keyRaw = CMD.Execute("netsh wlan show profile name=" + profile + " key=clear");
            string key = "";

            // Find key
            int keyLocation = keyRaw.IndexOf("Key Content            :");
            if (keyLocation != -1) { // If key found
                keyRaw = keyRaw.Substring(keyLocation);
                int omega = keyRaw.IndexOf("\r") - 25;
                key = keyRaw.Substring(25, omega);
            }

            return key;
        }

    }
}


