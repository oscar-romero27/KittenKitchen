using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenKitten
{
    public partial class VideoReceta : Form
    {
        String url;
        public VideoReceta(String url)
        {
            InitializeComponent();
            this.url = url;
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"790\" heigth=\"300\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            //var url = "https://www.youtube.com/embed/L6ZgzJKfERM";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
