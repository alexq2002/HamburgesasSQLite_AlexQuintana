using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburgesasSQLite_AlexQuintana.Models;
using SQLite;

namespace HamburgesasSQLite_AlexQuintana.Data
{
    public class BurgerDatabaseAQ
    {
        string _dbPath;
        private SQLiteConnection conn;

        public BurgerDatabaseAQ(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BurgerAQ>();
        }
        public int AddNewBurger(BurgerAQ burger)
        {
            Init();
            if (burger.Id != 0)
            {
                return conn.Update(burger);
            }
            else
            {
                return conn.Insert(burger);
            }
        }
        public List<BurgerAQ> GetAllBurgers()
        {
            Init();
            List<BurgerAQ> burgers = conn.Table<BurgerAQ>().ToList();
            return burgers;
        }
    }
}
