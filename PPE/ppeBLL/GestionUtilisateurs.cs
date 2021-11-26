using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using ppeBO; // Référence la couche BO
using ppeDAL; // Référence la couche DAL


namespace ppeBLL
{
    public class GestionUtilisateurs
    {

        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        } 
    }
}
