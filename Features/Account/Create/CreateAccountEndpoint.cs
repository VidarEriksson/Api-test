

using Data.models;
using FastEndpoints;

namespace Features.Account.Create
{
    //enpoint 
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
            //creates new user
            User user = Map.ToEntity(r);
            //add user to the db
            context.Add(user);
            //save the changes in the db
            await context.SaveChangesAsync();
            //create answer
            var response = new CreateAccountResponse(user.UserId, "user created!");
            //send the answer
            await SendAsync(response);
        }
    }
}