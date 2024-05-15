namespace Account.Delete
{
    internal sealed class Endpoint : Endpoint<Request, Response, Mapper>
    {
        public override void Configure()
        {
            Delete("/author/delete");
            AllowAnonymous();
        }

        public override async Task HandleAsync(Request r, CancellationToken c)
        {
            await SendAsync(new Response());
        }
    }
}