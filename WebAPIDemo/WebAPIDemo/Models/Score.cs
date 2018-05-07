using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class Score
    {
        public int ScoreId { get; set; }
        public int StudentId { get; set; }
        public int CSharp { get; set; }
        public int DB { get; set; }
    }
}