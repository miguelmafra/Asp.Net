using System.Data.Entity;

namespace Aula2205_Entity.Models.DAL
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {
            //<DropCreateDatabaseAlways>
            //<DropCreateDatabaseIfModelChanges>
            //<MigrateDatabaseToLatestVersion>
            Database.SetInitializer<MeuContexto>(new DropCreateDatabaseIfModelChanges<MeuContexto>());
            
        }
       
    }
}