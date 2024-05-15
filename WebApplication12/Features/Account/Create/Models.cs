namespace Account.Create
{
    public class Request
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; } 
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string password { get; set; }


    }

   

    public class Response
    {
        public string Message {  get; set; }
    }
}
