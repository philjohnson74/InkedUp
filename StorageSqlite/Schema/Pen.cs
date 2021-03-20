using System;
using SQLite;

namespace StorageSqlite.Schema
{
    public class Pen
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int InkId { get; set; }
    }
}
