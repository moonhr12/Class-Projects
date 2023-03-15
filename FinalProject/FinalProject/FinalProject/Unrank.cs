using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    [Table("unrank")]
    public class Unrank
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Queue { get; set; }
        public string Tier { get; set; }
        public int Wins { get; set; }
        public int Lose { get; set; }
        public string Rank { get; set; }
        public string RankImages { get; set; }
    }
}
