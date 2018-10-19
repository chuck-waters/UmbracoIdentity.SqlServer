using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalLoginsConversion
{
    public class ConvertData
    {
        private List<ExternalLoginsDTO> externalLoginList = new List<ExternalLoginsDTO>();

        public void GetSQLCEData(string filePath)
        {
            externalLoginList.Clear();

            using (SqlCeConnection ceConn = new SqlCeConnection($"Data Source={filePath};"))
            {
                ceConn.Open();
                var ceCmd = new SqlCeCommand("SELECT UserId, ProviderKey, LoginProvider FROM ExternalLogins", ceConn);

                using (var ceRdr = ceCmd.ExecuteReader())
                {
                    while (ceRdr.Read())
                    {
                        externalLoginList.Add(new ExternalLoginsDTO()
                        {
                            UserId = ceRdr.GetInt32(0),
                            ProviderKey = ceRdr.GetString(1),
                            LoginProvider = ceRdr.GetString(2)
                        });
                    }
                    ceRdr.Close();
                }

                ceConn.Close();
            }
        }

        internal void LoadDataIntoSqlServer(string server, string database, string username, string password)
        {
            using (SqlConnection sqlConn = new SqlConnection($"server={server};database={database};user id={username};password={password};"))
            {
                try
                {
                    sqlConn.Open();
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Failed to Connect to database. Recheck values", "SQL Connection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
                using (var sqlTransaction = sqlConn.BeginTransaction())
                {
                    try
                    {
                        var userIdSelectParam = new SqlParameter("@userId", System.Data.SqlDbType.Int);
                        var userIdParam = new SqlParameter("@userId", System.Data.SqlDbType.Int);
                        var loginProviderParam = new SqlParameter("@loginProvider", System.Data.SqlDbType.NVarChar, 4000);
                        var providerKeyParam = new SqlParameter("@providerKey", System.Data.SqlDbType.NVarChar, 4000);

                        var selectCmd = new SqlCommand("SELECT Count(UserId) FROM ExternalLogins WHERE UserId = @userId", sqlConn, sqlTransaction);
                        var insertCmd = new SqlCommand("INSERT INTO ExternalLogins (UserId, LoginProvider, ProviderKey) Values (@userId, @loginProvider, @providerKey)", sqlConn, sqlTransaction);

                        selectCmd.Parameters.Add(userIdSelectParam);

                        insertCmd.Parameters.Add(userIdParam);
                        insertCmd.Parameters.Add(loginProviderParam);
                        insertCmd.Parameters.Add(providerKeyParam);

                        foreach (var login in this.externalLoginList)
                        {
                            userIdSelectParam.Value = login.UserId;
                            userIdParam.Value = login.UserId;
                            loginProviderParam.Value = login.LoginProvider;
                            providerKeyParam.Value = login.ProviderKey;

                            var count = (int)selectCmd.ExecuteScalar();
                            if (count == 0)
                            {
                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        sqlTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        System.Windows.Forms.MessageBox.Show(ex.Message, "SQL Error", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    finally
                    {
                        sqlConn.Close();
                    }
                    System.Windows.Forms.MessageBox.Show("Converted all records.", "Conversion Complete", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
        }
    }
}
