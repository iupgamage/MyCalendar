﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calendar.ASP.NET.MVC5.Startup))]
namespace Calendar.ASP.NET.MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
