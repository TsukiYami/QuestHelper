namespace Model.Models
{
    // All the code in this file is included in all platforms.
    public class LoginModel
    {
        public long nID { get; private set; }
        public string sUsername { get; private set; }
        public string sEMail { get; private set; }
        public string sPassword { get; private set; }

        public LoginModel (long nID, string sUsername, string sEMail, string sPassword)
        {
            this.nID = nID;
            this.sUsername = sUsername;
            this.sEMail = sEMail;
            this.sPassword = sPassword;
        }
    }
}
