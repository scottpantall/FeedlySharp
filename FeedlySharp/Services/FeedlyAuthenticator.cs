using System.Threading.Tasks;
using FeedlySharp.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace FeedlySharp.Services
{
    public class FeedlyAuthenticator : IAuthenticator
    {
        private readonly FeedlyOptions feedlyOptions;

        public FeedlyAuthenticator(FeedlyOptions feedlyOptions)
        {
            this.feedlyOptions = feedlyOptions;
        }

        public ValueTask Authenticate(RestClient client, RestRequest request)
        {
            request.AddHeader("Authorization", $"Bearer {feedlyOptions.AccessToken}");
            return new ValueTask();
        }

        public FeedlyOptions Options { get => feedlyOptions; }
    }
}
