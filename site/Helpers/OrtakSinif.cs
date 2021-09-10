using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using site.Models;


namespace site.Helpers
{
    public class OrtakSinif
    {
        data db = new data();
        public static bool EditIzinYetkiVarmi(int id,Kullanici user)
        {
            if (user.U_ID == id)
            {
                return true;
            }
            else if (user.YetkiID > 2)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteIzinYetkiVarmi(int id, Kullanici user)
        {
            if (user.U_ID == id)
            {
                return true;
            }
            else if (user.YetkiID > 3)
            {
                return true;
            }
            return false;
        }
    }
}