using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modernC.DalServeur;
using modernC.Model;
using System.Data.SqlClient;
using System.Data;

namespace modernC.Controller
{
    public class ControllerCarburant
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
    }
}
