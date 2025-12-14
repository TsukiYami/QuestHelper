namespace Model.DTOs.Get
{
    public class LoginGetDTO
    {
        public long nID { get; private set; }
        public string sUsername { get; private set; }
        public string sEMail { get; private set; }
        public string sPassword { get; private set; }

        public LoginGetDTO (long nID, string sUsername, string sEMail, string sPassword)
        {
            this.nID = nID;
            this.sUsername = sUsername;
            this.sEMail = sEMail;
            this.sPassword = sPassword;
        }
    }
}
