using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_API {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://data.taipei/");

            HttpResponseMessage resp = client.GetAsync(
                "opendata/datalist/apiAccess?scope=resourceAquire&rid=e7cdaca3-e9da-46f9-b857-395e6e8e06a6").Result;

            if (resp.IsSuccessStatusCode) {
                Label1.Text = resp.Content.ReadAsStringAsync().Result;
            }
            //Response.Write(
            //"<div>" +
            //"<h1 style='background-color:red'>11111<h1>" +
            //"</div>");
        }
    }
}