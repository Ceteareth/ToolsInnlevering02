﻿using System;

namespace Innlevering02.Model.Custom_Models
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("Welcome to MVVM Light");
            callback(item, null);
        }
    }
}