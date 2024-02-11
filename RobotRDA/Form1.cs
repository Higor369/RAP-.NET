using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotRDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_quotes_Click(object sender, EventArgs e)
        {
            var web = new ChromiumWebBrowser();
            web.LoadUrl("https://quotes.toscrape.com/login");
            web.FrameLoadEnd += (send, args) =>
            {
                var scriptAddEmail = $"document.getElementById(\"username\").value = '{ENV.EMAIL}';";
                args.Frame.ExecuteJavaScriptAsync(scriptAddEmail);

                var scriptAddPassword = $"document.getElementById(\"password\").value = '{ENV.PASSWORD}';";
                args.Frame.ExecuteJavaScriptAsync(scriptAddPassword);

                var scriptClickLogin = $"document.querySelector(\"body > div > form > input.btn.btn-primary\").click();";
                args.Frame.ExecuteJavaScriptAsync(scriptClickLogin);
            };

            web.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            AddTabPage("Quotes", web);
        }


        private void AddTabPage(string name, ChromiumWebBrowser web)
        {
            TabPage tab = new TabPage();
            tab.Text = name;
            tab.Controls.Add(web);

            tabs.TabPages.Add(tab);
            tabs.SelectTab(tabs.TabPages.Count - 1);
        }

        private void btn_facebook_Click(object sender, EventArgs e)
        {
            var web = new ChromiumWebBrowser();
            web.LoadUrl("https://www.facebook.com/");
            web.FrameLoadEnd += (send, args) =>
            {
                var scriptAddEmail = $"document.getElementById(\"email\").value = '{ENV.EMAIL}';";
                args.Frame.ExecuteJavaScriptAsync(scriptAddEmail);

                var scriptAddPassword = $"document.getElementById(\"pass\").value = '{ENV.PASSWORD}';";
                args.Frame.ExecuteJavaScriptAsync(scriptAddPassword);

                var scriptClickLogin = $"document.getElementsByName('login')[0].click();";
                args.Frame.ExecuteJavaScriptAsync(scriptClickLogin);
            };

            web.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            AddTabPage("Facebook", web);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(tabs.SelectedTab);
        }

        private void btn_dolar_Click(object sender, EventArgs e)
        {
            SearchCotacao("Cotação Dolar");
        }

        private void btn_euro_Click(object sender, EventArgs e)
        {
            SearchCotacao("Cotação Euro");
        }

        private void SearchCotacao(string cotacao)
        {
            var web = new ChromiumWebBrowser();
            web.LoadUrl("https://www.google.com.br/");
            web.FrameLoadEnd += (send, args) =>
            {
                var scriptAddEmail = $"document.getElementsByName('q')[0].value = '{cotacao}';";
                args.Frame.ExecuteJavaScriptAsync(scriptAddEmail);

                var scriptAddClick = $"document.querySelector('body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.FPdoLc.lJ9FBc > center > input.gNO89b').click();";
                args.Frame.ExecuteJavaScriptAsync(scriptAddClick);
            };

            web.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            AddTabPage(cotacao, web);
        }
    }
}
