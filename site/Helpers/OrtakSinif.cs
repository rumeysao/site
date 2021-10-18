using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using site.Models;


namespace site.Helpers
{
    public class OrtakSinif
    {
        veriEntities db = new veriEntities();
        public static bool IzinYetkiVarmi(int id,Kullanici user)
        {
            if (user.Kullanici_ID == id)
            {
                return true;
            }
            else if (user.YetkiID == 2)
            {
                return true;
            }
            return false;
        }

    
    }
}