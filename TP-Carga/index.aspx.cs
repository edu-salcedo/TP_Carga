using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negosio;
using Dominio;

namespace TP_Carga
{
    public partial class index : System.Web.UI.Page
    {
        CarreraNegosio listaNeg = new CarreraNegosio();
        List<Carrera> lista;
        string strFileName;
        string strFilePath;
        string strFolder;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (oFile.Value != "")
            {
                strFolder = Server.MapPath("./");
                strFileName = oFile.PostedFile.FileName;
                strFileName = Path.GetFileName(strFileName);

                strFilePath = strFolder + strFileName;
            
                tbRuta.Text= strFilePath; 
            }
            lista = listaNeg.list();
            if (!IsPostBack)
            {
                DCarrera.DataSource = lista;
                DCarrera.DataValueField = "Id";
                DCarrera.DataTextField = "Descripcion";
                DCarrera.SelectedIndex = -1;
                DCarrera.DataBind();
            }

        }

        protected void DCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAltaCarrera.ClearSelection();

            lista = listaNeg.listAlta(DCarrera.SelectedValue);
            DAltaCarrera.DataSource = lista;
            DAltaCarrera.DataValueField = "Id";
            DAltaCarrera.DataTextField = "Descripcion";
            DAltaCarrera.SelectedIndex = -1;
            DAltaCarrera.DataBind();
        }
    }
}