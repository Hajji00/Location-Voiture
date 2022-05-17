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
    public class ControllerVoiture
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Boolean ADD(Voitures voitures)
        {
            Boolean saved;
            cnx.Open();
            cmd = new SqlCommand("select * from Voitures where Matriculation=" + voitures.MATRIQULE, cnx);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                saved = false;
                cmd.Dispose();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into Voitures values(@Matriculation,@Color,@Prix,@Km)", cnx);
                cmd.Parameters.Add(new SqlParameter("@Matriculation", voitures.MATRIQULE));
                cmd.Parameters.Add(new SqlParameter("@Color", voitures.COLOR));
                cmd.Parameters.Add(new SqlParameter("@Prix", voitures.PRIX));
                cmd.Parameters.Add(new SqlParameter("@Km", voitures.KM));
                cmd.ExecuteNonQuery();
                saved = true;

            }
            cnx.Close();
            return saved;

        }
        public void Delet(string Matriculation)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from Voitures where =@Matriculation", cnx);
            cmd.Parameters.Add(new SqlParameter("@Matriculation", Matriculation));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void Updat(Voitures voitures)
        {
            cnx.Open();
            cmd = new SqlCommand("update Voitures set Color=@Color,Prix=@Prix,Km=@Km where Matriculation=@Matriculation", cnx);
            cmd.Parameters.Add(new SqlParameter("@Matriculation", voitures.MATRIQULE));
            cmd.Parameters.Add(new SqlParameter("@Color", voitures.COLOR));
            cmd.Parameters.Add(new SqlParameter("@Prix", voitures.PRIX));
            cmd.Parameters.Add(new SqlParameter("@Km", voitures.KM));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable GetAll()
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Voitures", cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
        public DataTable GetById(string Matriculation)
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Voitures where Matriculation=" + Matriculation, cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
    }
}
