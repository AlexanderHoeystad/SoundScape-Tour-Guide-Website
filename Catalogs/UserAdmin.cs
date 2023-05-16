using SoundScape_Tour_Guide_Website.Pages.Account;

namespace SoundScape_Tour_Guide_Website.Catalogs
{
    public class UserAdmin
    {
        private Dictionary<int, Credential> credential {  get; }

        public UserAdmin()
        {
            credential = new Dictionary<int, Credential>();
        }
        public Dictionary<int,Credential?> AllCrendential()
        {
            return credential;
        }
    }
}
