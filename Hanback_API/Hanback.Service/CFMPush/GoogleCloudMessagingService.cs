using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using System.Threading.Tasks;

namespace Hanback.Service.CFMPush
{
    public class GoogleCloudMessagingService
    {
        public async Task<string> SendMessage(string registrationToken, string title, string body)
        {
            var message = new Message()
            {

                Notification = new Notification()
                {
                    Title = title,
                    Body = body,
                },
                
                Token = registrationToken,
                Android = new AndroidConfig()
                {
                    Notification = new AndroidNotification()
                    {
                        Sound = "default",
                    }
                }

            };
            return await FirebaseMessaging.DefaultInstance.SendAsync(message);
        }
        public async Task<string> SendTopicMessage(string topic, string title, string body)
        {
            var message = new Message()
            {
                Notification = new Notification()
                {
                    Title = title,
                    Body = body,
                },
                
                Topic = topic,
                Android = new AndroidConfig()
                {
                    Notification = new AndroidNotification()
                    {
                        Sound = "default",
                    }
                }
            };
            return await FirebaseMessaging.DefaultInstance.SendAsync(message);
        }
    }
}