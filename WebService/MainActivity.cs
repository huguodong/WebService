using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Java.Lang;
using Java.Interop;

namespace WebService
{
    [Activity(Label = "WebService", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, Button.IOnClickListener
    {
        int count = 1;
        public WebView webview;
        public TextView msgtext;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            webview = FindViewById<WebView>(Resource.Id.webview);
            msgtext = FindViewById<TextView>(Resource.Id.msg);
            Button button = FindViewById<Button>(Resource.Id.button);
            webview.Settings.JavaScriptEnabled = true;
            button.SetOnClickListener(this);
            webview.AddJavascriptInterface(this, "wst");
            // webview.LoadUrl(this.GetString(Resource.String.Hello));
            webview.LoadUrl("file:///android_asset/wst.html");
        }
        public void OnClick(View v)
        {
            // 无参数调用  
            webview.LoadUrl("javascript:javacalljs()");
            // 传递参数调用  
            webview.LoadUrl("javascript:javacalljswithargs(" + "'hello world'" + ")");
        }
        [Export("startFunction")]
        public void startFunction()
        {
            RunOnUiThread(new Runnable(() =>
            {
                msgtext.Text = msgtext.Text + "\njs调用了java函数";
            }));
        }
        [Export("startFunction")]
        public void startFunction(string str)
        {
            Toast.MakeText(this, str, ToastLength.Short).Show();
            RunOnUiThread(new Runnable(() =>
            {
                msgtext.Text = msgtext.Text + "\njs调用了js函数"+str;
            }));
        }
        private class WebPlugin : Java.Lang.Object
        {
            public MainActivity activity;
            public WebPlugin(MainActivity act)
            {
                activity = act;
            }
            public void test()
            {
                Toast.MakeText(activity, "test toast ", ToastLength.Short).Show();

            }
            public string test2()
            {
                return "something";
            }
        }

    }
}

