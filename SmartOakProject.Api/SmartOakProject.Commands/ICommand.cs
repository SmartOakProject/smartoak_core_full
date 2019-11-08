using Microsoft.Extensions.Configuration;
using SmartOakProject.Db;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartOakProject.Commands
{
    public interface ICommand
    {
        Task ExecuteAsync(IConfiguration configuration, IContext context); 
    }
}
