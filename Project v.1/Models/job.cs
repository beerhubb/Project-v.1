﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_v._1.Models
{
    public class job
    {
        [BsonId]
        public string _id { get; set; }

        [Display(Name = "รูปภาพงานที่ 1")]
        public string pictruejob1 { get; set; }

        [Display(Name = "รูปภาพงานที่ 2")]
        public string pictruejob2 { get; set; }

        [Display(Name = "รูปภาพงานที่ 3")]
        public string pictruejob3 { get; set; }

        [Display(Name = "ชื่องาน")]
        [StringLength(150)]
        public string namejob { get; set; }

        [Display(Name = "รายละเอียดงาน")]
        [StringLength(250)]
        public string detail { get; set; }

        [Display(Name = "เบอร์โทรศัพท์")]
        public string phone { get; set; }

        [Display(Name = "ID line")]
        public string line {get; set;}

        [Display(Name = "สถานที่")]
        public string location { get; set; }

        [Display(Name = "ราคางาน")]
        public string price { get; set; }
    }
}
