using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
