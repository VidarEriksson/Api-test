using Data.models;



namespace Features.Account.Create
{
    public sealed class CreateAccountMapper : Mapper<CreateAccountRequest, CreateAccountResponse, User>
    {
        public override User ToEntity(CreateAccountRequest r)
        {
            return new User()
            {
                Email = r.Email,
                Username = r.Username,
                Password = r.Password,
                Phone = r.Phone,
                City = r.City,
                Firstname = r.Firstname,
                Lastname = r.Lastname

            };
        }

    }
}