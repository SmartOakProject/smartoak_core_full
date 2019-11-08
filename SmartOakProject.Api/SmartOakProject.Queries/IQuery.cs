using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SmartOakProject.Db;

namespace SmartOakProject.Queries
{
    public interface IQuery<TResult>
    {
        Task<TResult> ExecuteAsync(IConfiguration configuration, IContext context);
    }
}
