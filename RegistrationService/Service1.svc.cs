using System;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace RegistrationService
{
    public class Service1 : IService
    {
        string connectionString = "Data Source=SQL5080.site4now.net;Initial Catalog=db_a79439_regdb;User Id=db_a79439_regdb_admin;Password=qwerty009";
        public string Registrate(User new_user)
        {
            string result = string.Empty;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "EXEC [AddUser] @login, @name, @pass_hash";
                        var values = new
                        {
                            login = new_user.Login,
                            name = new_user.Name,
                            pass_hash = new_user.Password.GetHashCode()
                        };
                        db.Query(sqlQuery, values, transaction);
                        transaction.Commit();
                        result = "Done!";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        result = ex.Message;
                    }
                }
            }
            return result;
        }

        public string SingIn(string login, string pass)
        {
            string result = string.Empty;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "EXEC [SingIn] @login, @pass_hash";
                        var values = new
                        {
                            login = login,
                            pass_hash = pass.GetHashCode()
                        };
                        int count = db.Query<int>(sqlQuery, values, transaction).ToList()[0];
                        transaction.Commit();
                        if (count == 1)
                            result = "Done!";
                        else
                            result = "Priceduare not found!";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        result = ex.Message;
                    }
                }
            }
            return result;
        }
    }
}
