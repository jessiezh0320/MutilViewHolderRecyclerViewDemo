using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V7.Widget;
using System.Collections.Generic;

namespace MultiHolderRecycleApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public static RecyclerView.LayoutManager mLayoutManager;
        public RecyclerView.ViewHolder holder;

        private RecyclerView mRecyclerView;

        public static RecyclerView.Adapter mAdapter;
        public static List<Email> mEmails;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.mRecycleView);
            mRecyclerView.AddItemDecoration(new DividerItemDecoration(mRecyclerView.Context, DividerItemDecoration.Vertical));
            mRecyclerView.HasFixedSize = true;

            SetupList();

            //Create our layout Manager
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);
            RecyclerAdapter mAdapter = new RecyclerAdapter(mEmails, this);
            mRecyclerView.SetAdapter(mAdapter);


        }

        private void SetupList()
        {
            for (int i = 1; i <= 2; i++)
            {
                mEmails = new List<Email>();
                mEmails.Add(new Email() { date = "9/19/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!" ,Type=0});
                mEmails.Add(new Email() { date = "9/18/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 1 });
                mEmails.Add(new Email() { date = "8/19/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 1 });
                mEmails.Add(new Email() { date = "8/18/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 0 });
                mEmails.Add(new Email() { date = "7/19/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 0 });
                mEmails.Add(new Email() { date = "7/18/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 1 });
                mEmails.Add(new Email() { date = "6/19/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 0 });
                mEmails.Add(new Email() { date = "6/18/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 1 });
                mEmails.Add(new Email() { date = "5/19/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!" , Type = 1 });
                mEmails.Add(new Email() { date = "5/18/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!" , Type = 0 });
                mEmails.Add(new Email() { date = "4/19/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 0 });
                mEmails.Add(new Email() { date = "4/18/2019", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 0 });
                mEmails.Add(new Email() { date = "9/19/2018", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 1 });
                mEmails.Add(new Email() { date = "9/18/2018", Subject = "Wanna Hang Out?", Message = "I ' ll   be around  tomorrow!!", Type = 0 });

            }
        }
    }
}