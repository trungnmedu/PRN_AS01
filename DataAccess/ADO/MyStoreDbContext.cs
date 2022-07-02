using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess.ADO
{
    public class MyStoreDbContext : BaseDataAccessLayer
    {
        private static MyStoreDbContext? _instance;
        private static readonly object InstanceLock = new();
        private MyStoreDbContext() { }
        public static MyStoreDbContext GetDbContext
        {
            get
            {
                lock (InstanceLock)
                {
                    return _instance ??= new MyStoreDbContext();
                }
            }
        }

        public IEnumerable<MemberObject>? GetListMembers()
        {
            if (DataProvider == null)
            {
                return null;
            }
            IDataReader? reader = null;
            string selectQuery = "SELECT id, full_name, password, email, city, country FROM members";
            var members = new List<MemberObject>();
            try
            {
                reader = DataProvider.GetDataReader(selectQuery, CommandType.Text, out Connection);
                while (reader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberId = reader.GetInt32(0),
                        MemberName = reader.GetString(1),
                        Password = reader.GetString(2),
                        Email = reader.GetString(3),
                        City = reader.GetString(4),
                        Country = reader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader?.Close();
                CloseConnection();
            }
            return members;
        }

        public MemberObject? FindAccountMemberById(int accountId)
        {
            if (DataProvider == null)
            {
                return null;
            }
            MemberObject? account = null;
            IDataReader? dataReader = null;
            string SQLSelect = "SELECT id, full_name, password, email, city, country FROM members WHERE id = @MemberId";
            try
            {
                var param = DataProvider.CreateParameter("@MemberId", 4, accountId, DbType.Int32);
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out Connection, param);
                if (dataReader.Read())
                {
                    account = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        Email = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader?.Close();
                CloseConnection();
            }
            return account;
        }

        public MemberObject? FindAccountMemberByIdOrEmail(int accountId, string email)
        {
            if (DataProvider == null)
            {
                return null;
            }
            MemberObject? account = null;
            IDataReader? dataReader = null;
            string SQLSelect = "SELECT id, full_name, password, email, city, country FROM members WHERE id = @MemberId OR email LIKE @Email";
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    DataProvider.CreateParameter("@MemberId", 4, accountId, DbType.Int32),
                    DataProvider.CreateParameter("@Email", 50, email.ToLower(), DbType.String)
                };
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out Connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    account = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        Email = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader?.Close();
                CloseConnection();
            }
            return account;
        }

        public bool CreateMember(MemberObject account)
        {
            try
            {
                if (DataProvider == null)
                {
                    return false;
                }
                MemberObject? existAccount = FindAccountMemberByIdOrEmail(account.MemberId, account.Email);
                if (existAccount == null)
                {
                    string SQLInsert = "INSERT INTO MemberDB.dbo.members (id, full_name, password, email, city, country) VALUES (@Id, @FullName, @Password, @Email, @City, @Country)";
                    var parameters = new List<SqlParameter>
                    {
                        DataProvider.CreateParameter("@Id", 4, account.MemberId, DbType.Int32),
                        DataProvider.CreateParameter("@FullName", 50, account.MemberName, DbType.String),
                        DataProvider.CreateParameter("@Password", 50, account.Password, DbType.String),
                        DataProvider.CreateParameter("@Email", 50, account.Email, DbType.String),
                        DataProvider.CreateParameter("@City", 50, account.City, DbType.String),
                        DataProvider.CreateParameter("@Country", 50, account.Country, DbType.String)
                    };
                    return DataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray()) == 1;
                }
                else if (existAccount.MemberId == account.MemberId)
                {
                    throw new Exception("Member ID already used by another account.");
                }
                else if (existAccount.Email.ToLower().Equals(account.Email.ToLower()))
                {
                    throw new Exception("Email is already used by another account.");
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool UpdateMember(MemberObject account)
        {
            try
            {
                if (DataProvider == null )
                {
                    return false;
                }
                MemberObject? existAccount = FindAccountMemberByIdOrEmail(account.MemberId, account.Email);

                if (existAccount == null)
                {
                    throw new Exception("This account not exist.");
                }
                else if (account != null && existAccount.MemberId != account.MemberId)
                {
                    throw new Exception("Email already used by another account.");
                }


                if (account == null)
                {
                    return false;
                }
                string SQLUpdate = "UPDATE members SET full_name=@FullName, password=@Password, email=@Email, city=@City, country=@Country WHERE id=@Id";
                var parameters = new List<SqlParameter>
                {
                    DataProvider.CreateParameter("@Id", 4, account.MemberId, DbType.Int32),
                    DataProvider.CreateParameter("@FullName", 50, account.MemberName, DbType.String),
                    DataProvider.CreateParameter("@Password", 50, account.Password, DbType.String),
                    DataProvider.CreateParameter("@Email", 50, account.Email, DbType.String),
                    DataProvider.CreateParameter("@City", 50, account.City, DbType.String),
                    DataProvider.CreateParameter("@Country", 50, account.Country, DbType.String)
                };
                return DataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray()) == 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool RemoveMember(int memberId)
        {
            if (DataProvider == null)
            {
                return false;
            }
            try
            {
                MemberObject? memberExist = FindAccountMemberById(memberId);
                if (memberExist != null)
                {
                    String SQLDelete = "DELETE members WHERE id = @MemberId";
                    var parameter = DataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                    return DataProvider.Delete(SQLDelete, CommandType.Text, parameter);
                }
                else
                {
                    throw new Exception("The account does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
