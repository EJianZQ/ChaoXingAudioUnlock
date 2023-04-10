using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace 学习通音频解锁助手
{
    public partial class MediaForm : Form
    {
        public MediaForm(string Url)
        {
            InitializeComponent();
            this.TopLevel = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            ChromiumWebBrowser webview = new ChromiumWebBrowser(Url);
            webview.Dock = DockStyle.Fill;
            this.Controls.Add(webview);
        }
    }
}
