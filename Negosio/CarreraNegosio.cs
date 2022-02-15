using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Odbc;

namespace Negosio
{
    public class CarreraNegosio
    {

        public List<Carrera> list()
        {
            List<Carrera> lista = new List<Carrera>();
            OdbcConnection DbConnection = new OdbcConnection("DSN=DATA");

            try
            {
                DbConnection.Open();
                OdbcCommand comand = new OdbcCommand("select cacu_idcarrcurs,cacu_descripcion from carrerascursos", DbConnection);             //  OdbcDataAdapter dat = new OdbcDataAdapter("select *from carrerascursos",DbConnection);
                OdbcDataReader reader;
                reader = comand.ExecuteReader();

                lista = new List<Carrera>();
                while (reader.Read())
                {
                    lista.Add(new Carrera((int)Convert.ToInt32(reader["cacu_idcarrcurs"]), (string)reader["cacu_descripcion"]));

                }
                reader.Close();
             }
             catch
             {
           
             }

              return lista;
        }

        public List<Carrera> listAlta(string id)
        {
            List<Carrera> lista = new List<Carrera>();
            OdbcConnection DbConnection = new OdbcConnection("DSN=DATA");

            try
            {
                DbConnection.Open();
                OdbcCommand comand = new OdbcCommand("select ccal_idccalta,ccal_descripcion from carrerascursosalta where ccal_idcarrcurs ='"+id+"'", DbConnection);             //  OdbcDataAdapter dat = new OdbcDataAdapter("select *from carrerascursos",DbConnection);
               
                //comand.Parameters.AddWithValue("@id", id);
                OdbcDataReader reader;
                reader = comand.ExecuteReader();

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
