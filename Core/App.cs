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

            Mvx.RegisterType<IContactRepository>(() => new ContactDbRepository());
        }
    }
}
