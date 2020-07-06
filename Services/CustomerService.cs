namespace customer_ratr.Services
{
    public class CustomerService
    {
        public CustomerService(CustomerRepository repo)
        {
            _repo = repo
        }
    }
}