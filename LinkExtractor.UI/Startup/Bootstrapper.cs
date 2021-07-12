﻿using Autofac;
using LinkExtractor.DAL;
using LinkExtractor.UI.DataServices;
using LinkExtractor.UI.DataServices.Lookups;
using LinkExtractor.UI.DataServices.Repositories;
using LinkExtractor.UI.View.Services;
using LinkExtractor.UI.ViewModel;
using Prism.Events;

namespace LinkExtractor.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            builder.RegisterType<LinkExtractorDbContext>().AsSelf();

            builder.RegisterType<MessageDialogService>().As<IMessageDialogService>();

            builder.RegisterType<MainWindow>().AsSelf();

            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<EmployeeDetailViewModel>().Keyed<IDetailViewModel>(nameof(EmployeeDetailViewModel));
            builder.RegisterType<WorkshiftDetailViewModel>().Keyed<IDetailViewModel>(nameof(WorkshiftDetailViewModel));

            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();
            builder.RegisterType<WorkshiftRepository>().As<IWorkshiftRepository>();

            return builder.Build();
        }
    }
}
