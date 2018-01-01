﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceLayer.JsonModels
{
    public class CombinedUsersModel
    {
        public string Url { get; set; }
        public string UserName { get; set; }
        public string UserLocation { get; set; }
        public int? UserAge { get; set; }
        public DateTime UserCreationDate { get; set; }
    }
}
