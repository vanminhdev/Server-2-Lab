using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Auth.ApplicationService.Common;
using WS.Auth.ApplicationService.UserModule.Abstracts;
using WS.Auth.Infrastructure;
using WS.Shared.ApplicationService.User;

namespace WS.Auth.ApplicationService.UserModule.Implements
{
    public class UserInforService : AuthServiceBase, IUserInforService
    {
        public UserInforService(ILogger<UserInforService> logger, AuthDbContext dbContext) : base(logger, dbContext)
        {
        }
    }
}
