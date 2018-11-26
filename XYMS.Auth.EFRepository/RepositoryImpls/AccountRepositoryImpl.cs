using System;
using System.Collections.Generic;
using System.Text;
using Materal.TTA.MySqlRepository;
using Microsoft.EntityFrameworkCore;
using XYMS.Auth.Domain;
using XYMS.Auth.Domain.IRepositorys;

namespace XYMS.Auth.EFRepository.RepositoryImpls
{
    public class AccountRepositoryImpl : MySqlEntityFrameworkRepositoryImpl<Account, int>, IAccountRepository
    {
        public AccountRepositoryImpl(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
