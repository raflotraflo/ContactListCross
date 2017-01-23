using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Droid.Views
{
    [Activity]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}
