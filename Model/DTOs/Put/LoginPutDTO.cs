namespace Model.DTOs.Put
{
    public class LoginPutDTO
    {
        public long nID { get; set; }
        public string sUsername { get; set; }
        public string sEMail { get; set; }
        public string sPassword { get; set; }

        public LoginPutDTO (long nID, string sUsername, string sEMail, string sPassword)
        {
            this.nID = nID;
            this.sUsername = sUsername;
            this.sEMail = sEMail;
            this.sPassword = sPassword;
        }
    }
}
