namespace Account.Delete
{
    internal sealed class Request
    {
        public String username { get; set; }
        public String password { get; set; }


    }

    internal sealed class Validator : Validator<Request>
    {
        public Validator()
        {

        }
    }

    internal sealed class Response
    {
        public string Message => "This endpoint hasn't been implemented yet!";
    }
}
