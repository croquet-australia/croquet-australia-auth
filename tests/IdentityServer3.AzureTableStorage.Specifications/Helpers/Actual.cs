﻿using IdentityServer3.Core.Models;
using Microsoft.WindowsAzure.Storage.Table;

namespace IdentityServer3.AzureTableStorage.Specifications.Helpers
{
    public class Actual
    {
        public Scope[] Scopes { get; set; }
        public DynamicTableEntity DynamicTableEntity { get; set; }
    }
}