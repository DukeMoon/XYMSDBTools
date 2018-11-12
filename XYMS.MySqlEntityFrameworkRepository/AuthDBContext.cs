using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using XYMS.Auth.Domain;

namespace XYMS.MySqlEntityFrameworkRepository
{
    public class AuthDBContext : DbContext
    {
        public AuthDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// 模型创建
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
