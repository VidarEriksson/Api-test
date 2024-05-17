using System.Globalization;

namespace Account.Create
{
    public class CreateAccountRequest
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Password { get; set; }


    }

   

    public class CreateAccountResponse
    {
        public CreateAccountResponse(int userId, string message)
        {
            UserId = userId;
            Message = message;
        }

        public string Message {  get; set; }
        public int UserId { get; }
    }
}
