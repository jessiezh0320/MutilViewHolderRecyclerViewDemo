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

namespace MultiHolderRecycleApp
{
    public class Email
    {
        public string date { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public int Type { get; set; }//the type of email
    }
}