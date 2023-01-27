
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace S7JohnnyPruna
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();
    }
}
