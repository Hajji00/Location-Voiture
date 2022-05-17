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
    public class ControllerContrat
    {
        SqlConnection cnx = new DalSqlSeveur().ConexionBD;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Boolean ADD(Contrats contrat)
        {
            Boolean saved;
            cnx.Open();
            cmd = new SqlCommand("select * from Contrat where Id_Contrat=" + contrat.ID_CONTRAT, cnx);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                saved = false;
                cmd.Dispose();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into Contrat values(@Id_Contrat,@Date_Depart,@Date_Routoure,@Km_Departe,@Km_retour)", cnx);
                cmd.Parameters.Add(new SqlParameter("@Id_Contrat", contrat.ID_CONTRAT));
                cmd.Parameters.Add(new SqlParameter("@Date_Depart", contrat.DATE_DEPART));
                cmd.Parameters.Add(new SqlParameter("@Date_Routoure", contrat.DATE_RETOUR));
                cmd.Parameters.Add(new SqlParameter("@Km_Departe", contrat.KM_DEPART));
                cmd.Parameters.Add(new SqlParameter("@Km_retour", contrat.KM_RETOUR));
                cmd.ExecuteNonQuery();
                saved = true;

            }
            cnx.Close();
            return saved;

        }
        public void Delet(int id)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from Contrat where =@Id_Contrat", cnx);
            cmd.Parameters.Add(new SqlParameter("@Id_Contrat", id));
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void Updat(Contrats contrat)
        {
            cnx.Open();
            cmd = new SqlCommand("update Contrat set Date_Depart=@Date_Depart,Date_Routoure=@Date_Routoure,Km_Departe=@Km_Departe,Km_retour=@Km_retour where Id_Contrat=@Id_Contrat", cnx);
            cmd.Parameters.Add(new SqlParameter("@Id_Contrat", contrat.ID_CONTRAT));
            cmd.Parameters.Add(new SqlParameter("@Date_Depart", contrat.DATE_DEPART));
            cmd.Parameters.Add(new SqlParameter("@Date_Routoure", contrat.DATE_RETOUR));
            cmd.Parameters.Add(new SqlParameter("@Km_Departe", contrat.KM_DEPART));
            cmd.Parameters.Add(new SqlParameter("@Km_retour", contrat.KM_RETOUR));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable GetAll()
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Contrat", cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
        public DataTable GetById(int id)
        {
            DataTable list = new DataTable();
            cnx.Open();
            da = new SqlDataAdapter("select * from Contrat where Id_Contrat=" + id, cnx);
            da.Fill(list);
            cnx.Close();
            return list;
        }
    }
}
