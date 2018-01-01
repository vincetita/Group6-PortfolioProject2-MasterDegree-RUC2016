using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class History
    {
        [Key]
        public int HistoryId { get; set; }
        public string Keyword { get; set; }
        public DateTime SearchDate { get; set; }
    }
}
