using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceColleciton serviceColleciton)
        {
            serviceColleciton.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
        }
    }
}
