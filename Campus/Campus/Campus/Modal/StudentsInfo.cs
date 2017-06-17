using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Campus.Modal
{
    public class StudentsInfo
    {
        string id;
        string name;
        string num;
        string department;
        string session;
        string dob;
        string phone;
        string email;
        string password;
        bool done;
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [JsonProperty(PropertyName = "rollno")]
        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        [JsonProperty(PropertyName = "department")]
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        [JsonProperty(PropertyName = "session")]
        public string Session
        {
            get { return session; }
            set { session = value; }
        }

        [JsonProperty(PropertyName = "dob")]
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        [JsonProperty(PropertyName = "phone")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        [JsonProperty(PropertyName = "email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [JsonProperty(PropertyName = "password")]
        public string Password
        {
            get { return password; }
            set { password = value; }
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
