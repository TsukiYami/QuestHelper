namespace Model.DTOs.Post
{
    public class LoginPostDTO
    {
        public string sUsername { get; set; }
        public string sEMail { get; set; }
        public string sPassword { get; set; }

        public LoginPostDTO (string sUsername, string sEMail, string sPassword)
        {
            this.sUsername = sUsername;
            this.sEMail = sEMail;
            this.sPassword = sPassword;
        }
    }
}
