using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartOakProject.Db
{
    public class Context : DbContext, IContext
    {
        //TODO: EF Context
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
