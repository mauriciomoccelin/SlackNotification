using System.Threading.Tasks;
using System.Net.Http;

namespace SlackNotification
{
    public class SlackNotification : ISlackNotification
    {
        private static string _token;
        private static string _channel;

        public SlackNotification()
        {
            _token = string.Empty;
            _channel = string.Empty;
        }

        public void Register(string token, string channel)
        {
            _token = token;
            _channel = channel;
        }

        public async Task SendNotificationAsync(string userName, string text)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync($"https://slack.com/api/chat.postMessage?" +
                    $"token={ _token }" +
                    $"&channel={ _channel }" +
                    $"&username={ userName }" +
                    $"&text={ text }" +
                    $"&pretty=1", null);
            }
        }
    }
}
