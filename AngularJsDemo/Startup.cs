using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(AngularJsDemo.Startup))]
namespace AngularJsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            try
            {
                ConfigureAuth(app);
            }
            catch(Exception ex)
            { }
        }
    }
}
