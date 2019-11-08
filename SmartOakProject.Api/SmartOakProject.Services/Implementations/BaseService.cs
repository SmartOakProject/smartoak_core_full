using Microsoft.Extensions.Configuration;
using SmartOakProject.Commands;
using SmartOakProject.Db;
using SmartOakProject.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartOakProject.Services.Implementations
{
    public abstract class BaseService
    {
        private readonly IConfiguration configuration;
        private readonly IContext context;

        public BaseService(IConfiguration configuration, IContext context)
        {
            this.configuration = configuration;
            this.context = context;
        }

        protected Task<TResult> ExecuteQuery<TResult>(IQuery<TResult> query)
        {
            return query.ExecuteAsync(configuration, context);
        }

        protected Task ExecuteCommand(ICommand command)
        {
            return command.ExecuteAsync(configuration, context);
        }
    }
}
