using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace App13.Resources.layout
{
    [Activity(Label = "LiveStream")]
    public class LiveStream : Activity
    {
        WebView webView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.stream);

            webView = FindViewById<WebView>(Resource.Id.webview);

            //string url = "http://129.65.49220:8080";
            string url = "www.google.com";
            webView.SetWebViewClient(new WebViewClient());
            webView.Settings.JavaScriptEnabled = true;
            webView.Settings.LoadWithOverviewMode = true;
            webView.Settings.UseWideViewPort = true;
            webView.Settings.SetPluginState(WebSettings.PluginState.On);
            webView.LoadUrl(url);
        }
    }
}