using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Campus.Modal
{
    public class TodoItem
    {
        string id;
        string name;
        string area;
        string type;
        string department;
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

        [JsonProperty(PropertyName = "text")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty(PropertyName = "area")]
        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        [JsonProperty(PropertyName = "type")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        [JsonProperty(PropertyName = "department")]
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        [JsonProperty(PropertyName = "owner")]
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
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

        [JsonProperty(PropertyName = "complete")]
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
