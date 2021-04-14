using System;

namespace SalesWeb.Services.Exceptions
{
    public class DbConcurrencyExcepition : ApplicationException
    {
        public DbConcurrencyExcepition(string message) : base(message)
        {

        }
    }
}
