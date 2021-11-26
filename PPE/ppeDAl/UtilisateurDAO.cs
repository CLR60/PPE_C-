using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using ppeBO; // Référence la couche BO
using System.Data.SqlClient;



namespace ppeDAL
{
    public class UtilisateurDAO
    {
        public bool isAuthGood(string username, string password)
        {
            return true;
        }
    }
}
