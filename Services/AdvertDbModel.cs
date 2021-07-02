using AdvertApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;

namespace AdvertApi.Services
{
    [DynamoDBTable("Advert")]
    public class AdvertDbModel
    {
        [DynamoDBHashKey]
        public String Id { get; set; }
        [DynamoDBProperty]
        public String Title { get; set; }
        [DynamoDBProperty]
        public String Description { get; set; }
        [DynamoDBProperty]
        public Double Price { get; set; }
        [DynamoDBProperty]
        public DateTime CreationDateTime { get; set; }
        [DynamoDBProperty]
        public AdvertStatus Status { get; set; }
    }
}
