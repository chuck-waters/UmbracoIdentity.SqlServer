using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.AspNet.Identity;
using Umbraco.Core;
using UmbracoIdentity.Models;

namespace UmbracoIdentity.SqlServer
{
    public class SqlServerExternalLoginStore : DisposableObject, IExternalLoginStore
    {
        private readonly ExternalLoginsContext dbContext;

        public SqlServerExternalLoginStore()
        {
            this.dbContext = new ExternalLoginsContext();
        }

        public void DeleteUserLogins(int memberId)
        {
            using (var dbTransaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    dbContext.Database.ExecuteSqlCommand("DELETE FROM ExternalLogins WHERE UserId=@userId", new SqlParameter("@userId", memberId));
                    dbContext.SaveChanges();
                    dbTransaction.Commit();
                }
                catch (Exception)
                {
                    dbTransaction.Rollback();
                }                
            }
        }

        public IEnumerable<int> Find(UserLoginInfo login)
        {
            var userId = dbContext.ExternalLogins
                            .Where(e => e.LoginProvider == login.LoginProvider
                                && e.ProviderKey == login.ProviderKey)
                            .Select(e => e.UserId).ToList();

            return userId;
        }

        public IEnumerable<IdentityMemberLogin<int>> GetAll(int userId)
        {
            var users = dbContext.ExternalLogins
                            .Where(e => e.UserId == userId)
                            .Select(e => new IdentityMemberLogin<int>
                            {
                                LoginProvider = e.LoginProvider,
                                ProviderKey = e.ProviderKey,
                                UserId = e.UserId                                
                            });

            return users.ToList();
        }

        public void SaveUserLogins(int memberId, IEnumerable<UserLoginInfo> logins)
        {
            using (var dbTransaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    dbContext.Database.ExecuteSqlCommand("DELETE FROM ExternalLogins WHERE UserId=@userId", new SqlParameter("@userId", memberId));
                    foreach (var login in logins)
                    {
                        dbContext.ExternalLogins.Add(new Models.ExternalLogin()
                        {
                            LoginProvider = login.LoginProvider,
                            ProviderKey = login.ProviderKey,
                            UserId = memberId
                        });
                    }
                    dbContext.SaveChanges();
                    dbTransaction.Commit();
                }
                catch (Exception)
                {
                    dbTransaction.Rollback();
                    throw;
                }
            }
        }

        protected override void DisposeResources()
        {
            this.dbContext.Dispose();
        }
    }
}
