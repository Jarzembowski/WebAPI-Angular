using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webAPI.Models
{
    public class Subscriber
    {
        
        public int Id { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public DateTime SubscribeDate { get; set; }
    
    }
}