using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Championship.Infra.Data.Config
{
    public class FireBaseConnectConfig
    {
        private string AuthString { get; set; }
        private string BasePath { get; set; }
        IFirebaseClient client;

        public FireBaseConnectConfig ()
        {
            this.AuthString = "KS1lJRbCy186SbVKHBrSdggOVGQSebuEDFR3jon3";
            this.BasePath = "https://championshipdb.firebaseio.com/";
        }

        public IFirebaseClient Connect()
        {
            IFirebaseConfig config = new FirebaseConfig {
                AuthSecret = this.AuthString,
                BasePath = this.BasePath
            };
            
            client = new FirebaseClient(config);
            if (client != null)
            {
                return client;
            }
            else
            {
                return client;
            }
        }
    }
}
