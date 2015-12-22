using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;
using System.Text;

namespace HTMLAgilityPackStartUp
{

    public partial class MyScraper : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickMeButton_Click(object sender, EventArgs e)
        {
            List<string> linklist = new List<string>();
            var timeru = DateTime.Now;
            var getHtmlWeb = new HtmlWeb();
            if( !InputTextBox.Text.StartsWith("http://"))
            {
                InputTextBox.Text = "http://" + InputTextBox.Text;
            }
            var document = getHtmlWeb.Load(InputTextBox.Text);
            var aTags = document.DocumentNode.SelectNodes("//a");
            int counter = 1;
            if (aTags != null)
            {
                foreach (var aTag in aTags)
                {
                    if( aTag.Attributes["href"] != null && aTag.Attributes["href"].Value.StartsWith("/web/"))
                        {
                        linklist.Add
                    }
                    string htmlstring = OutputLabel.Text + counter + ". " + " - " + aTag.Attributes["href"]?.Value + "\t" + "<br />";
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(htmlstring.ToCharArray());
                    string s = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                    OutputLabel.Text = s;
                    counter++;
                }
            }
            Timeru.Text = (DateTime.Now - timeru).ToString();

        }

    }
}