using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.RawSQL
{
	public class DatabaseManager
	{
        // Gets Connectionstring from local folder on Desktop
        protected static string GetConnectionString()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullName = Path.Combine(desktopPath, "RecipeAppConnectionString.txt");
            return File.ReadAllText(fullName);
        }
    }
}
