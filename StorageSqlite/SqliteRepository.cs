using System;
using System.Collections.Generic;
using SQLite;
using StorageSqlite.Schema;
using UseCasesShared.Interfaces.DTOs;
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

        public bool CreateInk(IInk useCaseInk)
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

        public bool CreatePen(IPen useCasePen)
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

        public bool DeleteInk(IInk useCaseInk)
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

        public bool DeletePen(IPen useCasePen)
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

        public List<IInk> RetrieveInks()
        {
            List<IInk> useCaseInks = new List<IInk>();

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

        public List<IPen> RetrievePens()
        {
            List<IPen> useCasePens = new List<IPen>();

            using (SQLiteConnection conn = new SQLiteConnection(_databaseLocation))
            {
                conn.CreateTable<Pen>();
                List<Pen> pens = conn.Table<Pen>().ToList();
                foreach (Pen pen in pens)
                {
                    useCasePens.Add(SchemaToUseCaseDtoConverter.Convert(pen, RetrieveInk(pen.InkId)));
                }
            }

            return useCasePens;
        }

        private IInk RetrieveInk(int inkId)
        {
            IInk useCaseInk = null;

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

        public bool UpdateInk(IInk useCaseInk)
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

        public bool UpdatePen(IPen useCasePen)
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
