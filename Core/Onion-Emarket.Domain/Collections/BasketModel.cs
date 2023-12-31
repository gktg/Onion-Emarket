﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Onion_Emarket.Domain.Entities.Common;
using Onion_Emarket.Domain.ViewModels;

namespace Onion_Emarket.Domain.Collections
{

    [DataContract]
    [BsonIgnoreExtraElements]
    public class BasketModel
    {

        public BasketModel() => CreatedDate = DateTime.Now;

        [DataMember]
        public string Id { get; set; } = String.Empty;

        [BsonElement("productList")]
        public List<ProductVM> ProductList { get; set; }
        public string userId { get; set; } = String.Empty;


        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CreatedDate { get; set; }

    }
}
