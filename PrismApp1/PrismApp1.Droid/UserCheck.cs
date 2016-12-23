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

namespace PrismApp1.Droid
{
    public class UserCheck : IUserCheck
    {
        public string Check()
        {
            return "in android";
        }
    }
}