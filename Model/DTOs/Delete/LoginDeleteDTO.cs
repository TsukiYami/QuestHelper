namespace Model.DTOs.Delete
{
    public class LoginDeleteDTO
    {
        public long nID { get; set; }

        public LoginDeleteDTO(long nID)
        {
            this.nID = nID;
        }
    }
}
