﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gituhub_test.Startup))]
namespace Gituhub_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
