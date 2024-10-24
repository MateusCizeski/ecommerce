using Identity.Repository.User;

namespace Identity.Service.User
{
    public class ServUser : IServUser
    {
        private readonly IRepUser _repUser;
        public ServUser(IRepUser repUser)
        {
            _repUser = repUser;
        }
    }
}
