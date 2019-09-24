using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace MultiHolderRecycleApp
{
     public class RecyclerViewHolderOne : RecyclerView.ViewHolder
    {
        public TextView mDate;
        public TextView mSubject;
        public TextView mMessage;
        public CheckBox cbx;
        public Button bottonbutton;
        public int count = 0;
        private Action<object, View.LongClickEventArgs, int> onLongClick;

        public RecyclerViewHolderOne(View itemView) : base(itemView)
        {
            mDate = itemView.FindViewById<TextView>(Resource.Id.tv_date);
            mSubject = itemView.FindViewById<TextView>(Resource.Id.tv_subject);
            mMessage = itemView.FindViewById<TextView>(Resource.Id.tv_msg);
            cbx = itemView.FindViewById<CheckBox>(Resource.Id.checkBox1);
        }
    }
}