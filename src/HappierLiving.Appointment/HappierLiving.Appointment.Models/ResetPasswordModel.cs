using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HappierLiving.Appointment.Model
{
 public class ResetPasswordModel
    {
      
        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        [JsonProperty(PropertyName =  "email")]
        public string Email { get; set; }


        [JsonProperty(PropertyName= "connection")]
        public string Connection => "Username-Password-Authentication";
    }
}
