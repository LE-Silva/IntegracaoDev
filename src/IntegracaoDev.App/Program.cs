using Dataplace.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using static dpLibrary05.mGenerico;

namespace IntegracaoDev.App
{
    static partial class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var assembliesMediator = new Assembly[] {
                        typeof(MainView).Assembly
            };

            var builder = Dataplace.Core.DataplaceApplication.CreateBuilder(args)
                .UseAppName("IntegracaoDevApp")
                .UseLayout(AppLayoutEnum.Basic)
                .UseMediatR(assembliesMediator)
                .OnLoadApp((loadData) =>
                {

                })
                .OnCloseApp((closeData) =>
                {
                    SymphonyApp.MainForm.Close();
                });


            ConfigureServices(builder.Services);
            RegisterTypes();

            var app = builder.Build();
            app.Run<MainView>();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainView>();
        }

        static void RegisterTypes()
        {
            Dataplace.Core.win.BootStrapper.Bootstrap(dpLibrary05.BootStrapper.Container);
        }
    }
}
