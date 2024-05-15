namespace Account.Create
{
    internal class Endpoint : Endpoint<Request, Response, Mapper>
    {
        public override void Configure()
        {
            Post("/author/signup");
            AllowAnonymous();
        }

        public override async Task HandleAsync(Request r, CancellationToken c)
        {
            await SendAsync(new Response());
        }
    }
}