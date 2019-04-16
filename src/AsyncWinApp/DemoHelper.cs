using System.Threading.Tasks;
using AsyncLibs;

namespace AsyncWinApp
{
    public class DemoHelper
    {
        private string entryUri = "https://github.com";

        public string GetInfo()
        {
            using (var client = new MyWebClient())
            {
                return client.DownloadString(entryUri);
            }
        }

        public async Task<string> GetInfoAsync()
        {
            using (var client = new MyWebClient())
            {
                return await client.DownloadStringTaskAsync(entryUri);
            }
        }
    }
}
