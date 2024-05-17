

using Data.models;
using FastEndpoints;

namespace Features.Account.Create
{
    public class CreateAccountEndpoint(UserDbContext context)
        : Endpoint<CreateAccountRequest, CreateAccountResponse, CreateAccountMapper>
    {
        public override void Configure()
        {
            Post("/author/signup");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateAccountRequest r, CancellationToken c)
        {
            User user = Map.ToEntity(r);
            context.Add(user);
            await context.SaveChangesAsync();
            var response = new CreateAccountResponse(user.UserId, "user created!");
            await SendAsync(response);
        }
    }
}