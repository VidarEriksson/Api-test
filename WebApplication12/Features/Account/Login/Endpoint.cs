namespace Account.Login
{
    internal sealed class Endpoint : Endpoint<Request, Response, Mapper>
    {
        public override void Configure()
        {
            Post("/author/login");
            AllowAnonymous();
        }

        public override async Task HandleAsync(Request r, CancellationToken c)
        {
            await SendAsync(new Response());
        }
    }
}