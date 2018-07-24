using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1CPW213.Models
{
    public class AutoInformation
    {
        public static void AddLink(Information I) { 
            // Create instance of DBContext class
            var context = new AutoLinkContext();

        // Prepare insert statement
            context.info.Add(I);

            // Execute pending insert
            context.SaveChanges();
        
        }

        public static bool AddInfo(Information info)
        {
            return true;
        }

    }
}