using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Campus.Modal
{
    public class Blogs
    {
        string id;
        string title;
        string field;
        string owner;
        string dtime;
        string content;
        bool done;
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "title")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        [JsonProperty(PropertyName = "owner")]
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        [JsonProperty(PropertyName = "field")]
        public string Field
        {
            get { return field; }
            set { field = value; }
        }
        [JsonProperty(PropertyName = "dtime")]
        public string Dtime
        {
            get { return dtime; }
            set { dtime = value; }
        }

        [JsonProperty(PropertyName = "content")]
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        [JsonProperty(PropertyName = "active")]
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
