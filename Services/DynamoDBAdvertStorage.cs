﻿using AdvertApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertApi.Services
{
    public class DynamoDBAdvertStorage : IAdvertStorageService
    {
        public Task<string> Add(AdvertModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Confirm(ConfirmAdvertModel model)
        {
            throw new NotImplementedException();
        }
    }
}
