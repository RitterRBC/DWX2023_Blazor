using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using RCLSample.Comp;
using System.Diagnostics.Metrics;

namespace WinForm
{
    public partial class blazorForm : Form
    {
        public blazorForm()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddBlazorWebViewDeveloperTools();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<RCLSample.Comp.CounterDemo>("#app");
        }
    }
}