﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PagoAgilFrba.Rendicion
{
    public partial class ABMRendicion : Form
    {
        public ABMRendicion()
        {
            InitializeComponent();
        }

        private void ABMRendicion_Load(object sender, EventArgs e)
        {
            cargarEmpresas();
            cargarComision();
        }

        private void cargarComision() {
            int cant = 0;
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand("SELECT distinct [porc_periodo] FROM [GD2C2017].[GOQ].[Porcentaje_Comision]", PagoAgilFrba.ModuloGlobal.getConexion());

            reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                do
                {
                    cant += 1;
                    cbPorcComision.Items.Add(reader.GetInt32(0).ToString());
                }
                while (reader.Read());
            }
            reader.Close();
        }

        private void cargarEmpresas() {

            int cant = 0;
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT [empresa_nombre] FROM [GD2C2017].[GOQ].[Empresa] WHERE [empresa_habilitado]=1", PagoAgilFrba.ModuloGlobal.getConexion());


            reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                do
                {
                    cant += 1;
                    cbEmpresa.Items.Add(reader.GetString(0));
                }
                while (reader.Read());
            }
            reader.Close();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int idEmpresa(string nombreEmpresa) {

            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT [ID_empresa] FROM [GD2C2017].[GOQ].[Empresa] WHERE [empresa_nombre] =@NOMBREEMPRESA", PagoAgilFrba.ModuloGlobal.getConexion());
            cmd.Parameters.Add("NOMBREEMPRESA", SqlDbType.VarChar).Value = nombreEmpresa;
            
            reader = cmd.ExecuteReader();
            reader.Read();

            return reader.GetInt32(0);
           
        }

        private string dameUltRenId() {
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand("SELECT max([ren_id]) FROM [GD2C2017].[GOQ].[Rendicion]", PagoAgilFrba.ModuloGlobal.getConexion());
            
            reader = cmd.ExecuteReader();
            reader.Read();

            //MessageBox.Show(reader.GetValue(0).ToString());

            return reader.GetValue(0).ToString();
        }


        private int dameElIdDeComision(int Comision) {

            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand("SELECT distinct [porc_comi_id] FROM [GD2C2017].[GOQ].[Porcentaje_Comision] where [porc_periodo]=@COMISION", PagoAgilFrba.ModuloGlobal.getConexion());

            cmd.Parameters.Add("COMISION", SqlDbType.Int).Value = Comision;

            reader = cmd.ExecuteReader();
            reader.Read();

            return reader.GetInt32(0);
        
        
        }

        private void btnRendir_Click(object sender, EventArgs e)
        {
            int maxRenId;
            string queryInsertRendicion = "";
            queryInsertRendicion = "INSERT INTO [GOQ].[Rendicion]([ren_fecha_ren],[ren_cant_fac],[ren_imp_comision],[ren_empresa_id],[ren_porc_comision_id],[ren_imp_total]) select @FECHARENDICION as ren_fecha_ren,COUNT(f.fac_id) as ren_cant_fac,cast((SUM(f.fac_total*@COMISION)/100) as decimal(18,2)) as ren_imp_comision,e.ID_empresa as ren_empresa_id, @COMISION as ren_porc_comision, SUM(f.fac_total) as ren_imp_total from [GOQ].[Factura] f inner join [GOQ].[Empresa]e on(e.ID_empresa=@EMPRESAID) inner join [GOQ].[Pago_Factura] pf on (pf.pago_fac_fac_id=f.fac_id) inner join [GOQ].[Item] i on(i.fac_id=f.fac_id) inner join [GOQ].[Pago] p on(p.pago_id=pf.pago_fac_pago_id) where f.fac_ren_id is null and format (p.pago_fecha_cobro,'yyyyMM') =format (@FECHARENDICION,'yyyyMM') group by e.ID_empresa;";
            
            string queryUpdateEmpresaRen_Id = "";
            queryUpdateEmpresaRen_Id = "UPDATE [GOQ].[Factura] SET [fac_ren_id] = @MAXRENID WHERE [fac_id] in (select distinct f.fac_id from [GOQ].[Factura] f inner join [GOQ].[Empresa]e on(e.ID_empresa=@EMPRESAID) inner join [GOQ].[Pago_Factura] pf on (pf.pago_fac_fac_id=f.fac_id) inner join [GOQ].[Item] i on(i.fac_id=f.fac_id) inner join [GOQ].[Pago] p on(p.pago_id=pf.pago_fac_pago_id) where f.fac_ren_id is null and format (p.pago_fecha_cobro,'yyyyMM') =format (@FECHARENDICION,'yyyyMM'));";



            SqlCommand cmdInsertRendicion = new SqlCommand(queryInsertRendicion, PagoAgilFrba.ModuloGlobal.getConexion());

            cmdInsertRendicion.Parameters.Add("FECHARENDICION", SqlDbType.Date).Value = dtRendicion.Value;

            cmdInsertRendicion.Parameters.Add("EMPRESAID", SqlDbType.Int).Value = idEmpresa(cbEmpresa.SelectedItem.ToString().Trim());

            cmdInsertRendicion.Parameters.Add("COMISION", SqlDbType.Int).Value = dameElIdDeComision(Convert.ToInt32(cbPorcComision.SelectedItem.ToString().Trim()));

            maxRenId = Convert.ToInt32(dameUltRenId());



            int cantidadFilasAfectadas = cmdInsertRendicion.ExecuteNonQuery();

            if (cantidadFilasAfectadas > 0)
            {
                SqlCommand cmdUpdateEmpresaRen_Id = new SqlCommand(queryUpdateEmpresaRen_Id, PagoAgilFrba.ModuloGlobal.getConexion());


                cmdUpdateEmpresaRen_Id.Parameters.Add("FECHARENDICION", SqlDbType.Date).Value = dtRendicion.Value;

                cmdUpdateEmpresaRen_Id.Parameters.Add("EMPRESAID", SqlDbType.Int).Value = idEmpresa(cbEmpresa.SelectedItem.ToString().Trim());

                cmdUpdateEmpresaRen_Id.Parameters.Add("COMISION", SqlDbType.Int).Value = Convert.ToInt32(cbPorcComision.SelectedItem.ToString().Trim());

                cmdUpdateEmpresaRen_Id.Parameters.Add("MAXRENID", SqlDbType.Int).Value = maxRenId;


                int cantidadFilasActualizadas = cmdUpdateEmpresaRen_Id.ExecuteNonQuery();

                if (cantidadFilasActualizadas > 0) {
                    MessageBox.Show("Facturas Rendidas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            else
            {
                MessageBox.Show("No hay facturas para rendir en esta fecha para la empresa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
