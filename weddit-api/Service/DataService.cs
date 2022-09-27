
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Data;
using Model;
using System;

namespace weddit_api.Service
{
    public class DataService
    {
        private PostContext db { get; }

        public DataService(PostContext db)
        {
            this.db = db;
        }
        
    }
}

