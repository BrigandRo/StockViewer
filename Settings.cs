using System.IO;
using Newtonsoft.Json;

namespace StockViewer
{
    class Settings : AppSettings<Settings>
    {
        public int fontSize;
        public int nrSpaces;
        public int opacity;
        public int speed;
        public int monitor;
        public string companies;
    }

    class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "settings.json";

        public void Save(string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(this));
        }

        public static void Save(T pSettings, string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(pSettings));
        }

        public static T Load(string fileName = DEFAULT_FILENAME)
        {
            T t = new T();
            if (File.Exists(fileName))
                t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
            return t;
        }
    }
}
