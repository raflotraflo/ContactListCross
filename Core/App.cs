using Core.Services;
using DataAccess.Entities;
using DataAccess.Repositories.ContactRepository;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.MainViewModel>();

            var databaseService = Mvx.Resolve<IDatabaseService>();

            databaseService.Connection.CreateTable<ContactEntity>();

            Mvx.RegisterType<IContactRepository>(() => new ContactDbRepository(databaseService.Connection));
        }
    }
}
