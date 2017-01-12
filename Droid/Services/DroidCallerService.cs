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
    public class DroidCallerService : ICallerService
    {
        public void Call(string phoneNumber)
        {
            var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

            var intent = new Intent(Intent.ActionDial);
            intent.SetData(Android.Net.Uri.Parse(string.Format("tel:{0}", phoneNumber)));
            activity.StartActivity(intent);
        }
    }
}