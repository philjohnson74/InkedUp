using System.Collections.Generic;
using SQLite;
using StorageSqlite.Schema;
using UseCasesShared.Interfaces.Storage;

namespace StorageSqlite
{ 
    public class SqliteRepository : IStorage
    {
        string _databaseLocation;

        public SqliteRepository(string databaseLocation)
        {
            _databaseLocation = databaseLocation;
        }

        public bool CreateInk(UseCasesShared.DTOs.Ink useCaseInk)
        {
            bool isSuccessful;
            Ink ink = UseCaseDtoToSchemaConverter.Convert(useCaseInk);

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Ink>();
                int rows = conn.Insert(ink);
                isSuccessful = rows > 0;
            }

            return isSuccessful;
        }

        public bool CreatePen(UseCasesShared.DTOs.Pen useCasePen)
        {
            bool isSuccessful;
            Pen pen = UseCaseDtoToSchemaConverter.Convert(useCasePen);

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Pen>();
                int rows = conn.Insert(pen);
                isSuccessful = rows > 0;
            }

            return isSuccessful;
        }

        public bool DeleteInk(UseCasesShared.DTOs.Ink useCaseInk)
        {
            bool isSuccessful;
            Ink ink = UseCaseDtoToSchemaConverter.Convert(useCaseInk);

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Ink>();
                int rows = conn.Delete(ink);
                isSuccessful = rows > 0;
            }

            return isSuccessful;
        }

        public bool DeletePen(UseCasesShared.DTOs.Pen useCasePen)
        {
            bool isSuccessful;
            Pen pen = UseCaseDtoToSchemaConverter.Convert(useCasePen);

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Pen>();
                int rows = conn.Delete(pen);
                isSuccessful = rows > 0;
            }

            return isSuccessful;
        }

        public List<UseCasesShared.DTOs.Ink> RetrieveInks()
        {
            var useCaseInks = new List<UseCasesShared.DTOs.Ink>();

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Ink>();
                List<Ink> inks = conn.Table<Ink>().ToList();
                foreach(Ink ink in inks)
                {
                    useCaseInks.Add(SchemaToUseCaseDtoConverter.Convert(ink));
                }
            }

            return useCaseInks;
        }

        public List<UseCasesShared.DTOs.Pen> RetrievePens()
        {
            var useCasePens = new List<UseCasesShared.DTOs.Pen>();

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Pen>();
                List<Pen> pens = conn.Table<Pen>().ToList();
                foreach (Pen pen in pens)
                {
                    useCasePens.Add(SchemaToUseCaseDtoConverter.Convert(pen,
                        RetrieveInk(pen.InkId)));
                }
            }

            return useCasePens;
        }

        private UseCasesShared.DTOs.Ink RetrieveInk(int inkId)
        {
            UseCasesShared.DTOs.Ink useCaseInk = null;

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Ink>();
                Ink ink = conn.Table<Ink>().ToList().Find(ink => ink.Id == inkId);

                if (ink != null)
                {
                    useCaseInk = SchemaToUseCaseDtoConverter.Convert(ink);
                }
            }

            return useCaseInk;
        }

        public bool UpdateInk(UseCasesShared.DTOs.Ink useCaseInk)
        {
            bool isSuccessful;
            Ink ink = UseCaseDtoToSchemaConverter.Convert(useCaseInk);

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Ink>();
                int rows = conn.Update(ink);
                isSuccessful = rows > 0;
            }

            return isSuccessful;
        }

        public bool UpdatePen(UseCasesShared.DTOs.Pen useCasePen)
        {
            bool isSuccessful;
            Pen pen = UseCaseDtoToSchemaConverter.Convert(useCasePen);

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Pen>();
                int rows = conn.Update(pen);
                isSuccessful = rows > 0;
            }

            return isSuccessful;
        }
    }
}
