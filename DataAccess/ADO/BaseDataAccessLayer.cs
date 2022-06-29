using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataAccess.ADO
{
    public class BaseDataAccessLayer
    {
        protected MyStoreDataProvider? DataProvider { get; set; }
        protected SqlConnection? Connection;

        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["connectionStrings:MyStoreDb"];
        }

        public MemberObject GetDefaultAdminAccount()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
            string email = configuration["defaultAdminAccount:email"];
            string password = configuration["defaultAdminAccount:password"];
            return new MemberObject()
            {
                MemberId = 0,
                Email = email,
                Password = password,
                City = String.Empty,
                Country = String.Empty
            };
        }

        protected BaseDataAccessLayer()
        {
            DataProvider = new MyStoreDataProvider(GetConnectionString());
        }

        protected void CloseConnection() => DataProvider?.CloseConnection(Connection);
    }
}
