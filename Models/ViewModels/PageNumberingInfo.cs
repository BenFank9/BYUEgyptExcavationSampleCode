﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUEgyptExcavation.Models.ViewModels
{
    //page numbering information
    public class PageNumberingInfo
    {
        public int NumItemsPerPage { get; set;}
        public int CurrentPage { get; set; }
        public int TotalNumItems { get; set; }

        //calculate the Number of Pager
        public int NumPages => (int)(Math.Ceiling((decimal)TotalNumItems / NumItemsPerPage));

    }
}
