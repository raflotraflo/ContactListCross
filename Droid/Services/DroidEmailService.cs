using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core.Services;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;

namespace Droid.Services
{
    public class DroidEmailService : IEmailService
    {
        public void OpenClient(string email)
        {
            var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

            var intent = new Intent(Intent.ActionSend);
            intent.SetType("text/plain");
            intent.PutExtra(Intent.ExtraEmail, new string[] { email });

            activity.StartActivity(Intent.CreateChooser(intent, "Send Email Using: "));
        }
    }
}