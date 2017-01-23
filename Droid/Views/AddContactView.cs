using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Droid.Views
{
    [Activity]
    public class AddContactView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AddContactView);
        }
    }
}
