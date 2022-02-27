using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Odbc;
using DBConnection;

namespace Negosio
{
    public class CarreraNegosio
    {
        public List<Carrera> list()
        {
            List<Carrera> lista = new List<Carrera>();

            try
            {
                DBConnection.DBConnection.getInstance().setComand("select cacu_idcarrcurs,cacu_descripcion from carrerascursos");             //  OdbcDataAdapter dat = new OdbcDataAdapter("select *from carrerascursos",DbConnection);
                DBConnection.DBConnection.getInstance().ExecuteReader();
                OdbcDataReader readed = DBConnection.DBConnection.getInstance().getReaded();

                lista = new List<Carrera>();
                while (readed.Read())
                {
                    lista.Add(new Carrera((int)Convert.ToInt32(readed["cacu_idcarrcurs"]), (string)readed["cacu_descripcion"]));

                }
                readed.Close();
             }
             catch
             {
           
             }

              return lista;
        }

        public List<Carrera> listAlta(string id)
        {
            List<Carrera> lista = new List<Carrera>();

            try
            {
                DBConnection.DBConnection.getInstance().setComand("select ccal_idccalta,ccal_descripcion from carrerascursosalta where ccal_idcarrcurs ='"+id+"'");             //  OdbcDataAdapter dat = new OdbcDataAdapter("select *from carrerascursos",DbConnection);
                DBConnection.DBConnection.getInstance().ExecuteReader();
                OdbcDataReader reader = DBConnection.DBConnection.getInstance().getReaded();

                lista = new List<Carrera>();
                while (reader.Read())
                {
                    lista.Add(new Carrera((int)Convert.ToInt32(reader["ccal_idccalta"]), (string)reader["ccal_descripcion"]));

                }
                reader.Close();
            }
            catch
            {

            }

            return lista;
        }
    }
}
