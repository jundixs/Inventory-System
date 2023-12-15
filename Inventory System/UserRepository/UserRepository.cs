using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System.Database;

namespace Dbsys
{

    public class UserRepository
    {
        private DBInventoryEntities1 db;
        public UserRepository()
        {
            db = new DBInventoryEntities1();
        }
        public UserAccount GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new DBInventoryEntities1())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.UserAccount.Where(s => s.username == username).FirstOrDefault();
            }
        }
    }
}
