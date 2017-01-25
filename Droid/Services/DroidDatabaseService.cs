using System;
using System.IO;
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
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;

namespace Droid.Services
{
    public class DroidDatabaseService : IDatabaseService
    {
        public SQLiteConnection Connection
        {
            get
            {
                var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "contacts.sqlite");
                return new SQLiteConnection(new SQLitePlatformAndroid(), path);
            }
        }
    }
}