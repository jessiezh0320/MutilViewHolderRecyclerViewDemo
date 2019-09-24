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
     public class RecyclerAdapter : RecyclerView.Adapter
    {

        private Activity mActivity;
        private List<Email> mEmails;
        private Context context;

        private const int LAYOUT_ONE = 0;
        private const int LAYOUT_TWO = 1;


        public RecyclerAdapter(List<Email> emails, Context context)
        {
            mEmails = emails;
            this.context = context;
        }

        public RecyclerAdapter(List<Email> emails, Activity activity)
        {
            mEmails = emails;
            mActivity = activity;
        }

        public override int ItemCount
        {
            get { return mEmails.Count; }
        }

        public override int GetItemViewType(int position)
        {
            if (mEmails[position].Type == 0)
                return LAYOUT_ONE;
            else
                return LAYOUT_TWO;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = null;

            if (viewType == LAYOUT_ONE) {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.row_type1, parent, false);
                return new RecyclerViewHolderOne(view);
            }
            else {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.row_type2, parent, false);
                return new RecyclerViewHolderSecond(view);
            }
        }
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            int type = GetItemViewType(position);

            switch (type)
            {
                case LAYOUT_ONE:
                    RecyclerViewHolderOne vh1 = holder as RecyclerViewHolderOne;
                    vh1.mSubject.Text = mEmails[position].Subject;
                    vh1.mDate.Text= mEmails[position].date;
                    vh1.mMessage.Text = mEmails[position].Message;
                    break;

                case LAYOUT_TWO:
                    RecyclerViewHolderSecond vh2 = holder as RecyclerViewHolderSecond;
                    vh2.mSubject.Text = mEmails[position].Subject;
                    vh2.mDate.Text = mEmails[position].date;
                    vh2.mMessage.Text = mEmails[position].Message;
                    break;

                default:
                    break;
            }
        }
    }
}