using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

public class InfantCareCenter {

    public string CREATE_DATE { get; set; }
    public string DIVISION { get; set; }
    public string REGISTERED { get; set; }
    public string LON { get; set; }
    public string POST_DATE { get; set; }
    public string ORG_TYPE { get; set; }
    public string FAX { get; set; }
    public string ZONE_CODE { get; set; }
    public string PHONE { get; set; }
    public string ORG_INTRODUCTION { get; set; }
    public string CONTACT_NAME { get; set; }
    public string BEDNO_TITLE { get; set; }
    public string ORG_NAME { get; set; }
    public string DEPT_NAME { get; set; }
    public string L1_NAME { get; set; }
    public string WEB_HOMEPAGE { get; set; }
    public string L1_CODE { get; set; }
    public string CITY { get; set; }
    public string ADDRESS_CODE { get; set; }
    public string ORG_GROUP_NAME { get; set; }
    public string PERSON_IN_CHARGE { get; set; }
    public string PROP { get; set; }
    public string BEDNO { get; set; }
    public string ADDRESS { get; set; }
    public string LAT { get; set; }
    public string _id { get; set; }
    public string PROP_TITLE { get; set; }
}


public class InfantCareCenterUtility {

    public List<InfantCareCenter> GetAllCenters() {

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://data.taipei/");

        HttpResponseMessage resp = client.GetAsync(
            "opendata/datalist/apiAccess?scope=resourceAquire&rid=e7cdaca3-e9da-46f9-b857-395e6e8e06a6").Result;

        if (resp.IsSuccessStatusCode) {
            string jsonString = resp.Content.ReadAsStringAsync().Result;

            JObject obj = JsonConvert.DeserializeObject<JObject>(jsonString);

            //Label1.Text = obj["result"]["results"].ToString();

            string schoolsString = obj["result"]["results"].ToString();

            return JsonConvert.DeserializeObject<List<InfantCareCenter>>(schoolsString);
        } else {
            return null;
        }
    }

    //public List<School> GetAllSchools() {
    //    HttpClient client = new HttpClient();
    //    client.BaseAddress = new Uri("https://data.taipei/");

    //    HttpResponseMessage resp = client.GetAsync(
    //        "opendata/datalist/apiAccess?scope=resourceAquire&rid=e7cdaca3-e9da-46f9-b857-395e6e8e06a6").Result;

    //    if (resp.IsSuccessStatusCode) {
    //        Label1.Text = resp.Content.ReadAsStringAsync().Result;
    //    } else {
    //        return null;
    //    }

    //    //Response.Write(
    //    //"<div>" +
    //    //"<h1 style='background-color:red'>11111<h1>" +
    //    //"</div>");
    //}
}