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
using SQLite;
using ShoppingList.Droid;
using System.IO;
[assembly: Xamarin.Forms.Dependency(typeof(DBCon_Android))]

namespace ShoppingList.Droid
{
    public class DBCon_Android : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "ShoppingListDb.db3";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}