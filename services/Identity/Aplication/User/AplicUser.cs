using Identity.Service.User;

namespace Identity.Aplication.User
{
    public class AplicUser : IAplicUser
    {
        private readonly IServUser _servUser;
        public AplicUser(IServUser servUser)
        {
            _servUser = servUser;
        }
    }
}
