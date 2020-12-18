using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sprint10.Part2.Task5
{
    class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                //code to export data from files to database.  
            }
            catch (IOException ex)
            {
                new ExceptionLogger(new DbLogger()).LogIntoDataBase(ex);
            }
            catch (Exception ex)
            {
                new ExceptionLogger().LogIntoFile(ex);
            }
        }
    }
}
