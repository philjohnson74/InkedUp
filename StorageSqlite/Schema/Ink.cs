using System;
using SQLite;

namespace StorageSqlite.Schema
{
    public class Ink
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Colour { get; set; }
    }
}
