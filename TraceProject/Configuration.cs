using System.Text.Json;
using System.IO;

namespace TraceProject
{
    public class Configuration
    {
        public int[] GetArrayRange()
        {
            Settings settings = new Settings();

            string appsettingsPath = Path.GetFullPath(@"..\..\..\") + "appsettings.json";

            if (File.Exists(appsettingsPath))
            {
                settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText(appsettingsPath));
            }

            int[] arrayRange = settings.ArrayRange;

            if (arrayRange == null)
            {
                arrayRange = new int[] { 0, 1 };
            }

            return arrayRange;
        }
    }
}
