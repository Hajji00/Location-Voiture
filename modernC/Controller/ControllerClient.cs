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
    public class ControllerClient
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        public Boolean ADD(Clients client)
        {
            Boolean saved;
            cnx.Open();
            cmd = new SqlCommand("select * from Clients where Cin=" + client.CIN, cnx);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                saved = false;
                cmd.Dispose();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into Clients values(@Cin,@Nom,@Prenom,@DateNaissance,@Telephone,@Email)", cnx);
                cmd.Parameters.Add(new SqlParameter("@Cin", client.CIN));
                cmd.Parameters.Add(new SqlParameter("@Nom", client.NOM));
                cmd.Parameters.Add(new SqlParameter("@Prenom", client.PRENOM));
                cmd.Parameters.Add(new SqlParameter("@DateNaissance", client.DATE_NAISSANCE));
                cmd.Parameters.Add(new SqlParameter("@Telephone", client.TELEPHONE));
                cmd.Parameters.Add(new SqlParameter("@Email", client.EMAIL));
                cmd.ExecuteNonQuery();
                saved = true;

            }
            cnx.Close();
            return saved;

        }
        public void Delet(string cin)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from Clients where Cin=@Cin", cnx);
            cmd.Parameters.Add(new SqlParameter("@Cin", cin));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void Updat(Clients clients)
        {
            cnx.Open();
            cmd = new SqlCommand("update Clients set Nom=@Nom,Prenom=@Prenom,DateNaissance=@DateNaissance,Telephone=@Telephone,Email=@Email where Cin=@Cin", cnx);
            cmd.Parameters.Add(new SqlParameter("@Cin", clients.CIN));
            cmd.Parameters.Add(new SqlParameter("@Nom", clients.NOM));
            cmd.Parameters.Add(new SqlParameter("@Prenom", clients.PRENOM));
            cmd.Parameters.Add(new SqlParameter("@DateNaissance", clients.DATE_NAISSANCE));
            cmd.Parameters.Add(new SqlParameter("@Telephone", clients.TELEPHONE));
            cmd.Parameters.Add(new SqlParameter("@Email", clients.EMAIL));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable GetAll()
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Clients", cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
        public DataTable GetById(string cin)
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Clients where Cin=" + cin, cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
    }
}
