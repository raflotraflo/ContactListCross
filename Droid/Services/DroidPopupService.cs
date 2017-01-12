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
    public class DroidPopupService : IPopupService
    {
        public void Show(string title, string message, string firstButtonText, Action firstButtonAction, string secondButtonText, Action secondButtonAction)
        {
            var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

            var alert = new AlertDialog.Builder(activity).Create();
            alert.SetTitle(title);
            alert.SetMessage(message);
            alert.SetButton(firstButtonText, delegate
            {
                firstButtonAction();
            });

            alert.SetButton2(secondButtonText, delegate { secondButtonAction(); });

            alert.Show();
        }
    }
}