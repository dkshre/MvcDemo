using Microsoft.Owin;
using Owin;
using System.Collections.Generic;
using System.Threading.Tasks;

[assembly: OwinStartupAttribute(typeof(MVC5Demo.Web.Startup))]
namespace MVC5Demo.Web
{
    public partial class Startup
    {
        public  void Configuration(IAppBuilder app)
        {

            app.Use(async (environment, next) =>
            {
                System.Diagnostics.Debug.WriteLine("Configuration Begin Curren Thread :" + System.Threading.Thread.CurrentThread.ManagedThreadId);

                foreach (var item in environment.Environment)
                {
                    System.Diagnostics.Debug.WriteLine("{0}  *******  {1}", item.Key, item.Value);

                }


                System.Diagnostics.Debug.WriteLine("Configuration Ended 1 Curren Thread :" + System.Threading.Thread.CurrentThread.ManagedThreadId);
               

                await next();

                System.Diagnostics.Debug.WriteLine("Configuration Ended 2 Curren Thread :" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            });

            //app.Use(async (environment, next) =>
            //{

            //    System.Diagnostics.Debug.WriteLine("Requesting " + environment.Request.Path);

            //    await next();

            //    System.Diagnostics.Debug.WriteLine("Response " + environment.Response.StatusCode);

            //});

            System.Diagnostics.Debug.WriteLine("Startup Curren Thread :" + System.Threading.Thread.CurrentThread.ManagedThreadId);

           ConfigureAuth(app);

           // app.Use<HelloWorldComponent>();
          
          //  app.Use
        }


    }

    class HelloWorldComponent
    {
        public HelloWorldComponent(IDictionary<string, object> environment)
        {

        }

        public Task Invoke(IDictionary<string, object> environment)
        {

            return null;
        }
    }

}
