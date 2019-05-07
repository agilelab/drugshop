using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EAS.Modularization;

namespace DrugShop.Res
{
	partial class AboutForm :Form
	{
        string LicenceText
        {
            get
            {
                return "<P style=\"FONT-SIZE: 12px\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;警告：本计算机程序受著作权法和国际公约的保护，未经授权擅自复制或散布本程序的部分或全部，将承受严厉的民事和刑事处罚，对已知的违反者将给予法律范围内的全面制裁。</P>";
            }
        }

		public AboutForm()
		{
			InitializeComponent();		
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad (e);
            this.webBrowser.Navigate("about:blank");
		}

        private void llDeveloper_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.agilelab.cn");
            }
            catch
            {
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument html = this.webBrowser.Document;
            html.Body.InnerHtml = this.LicenceText;
        }
	}
}
