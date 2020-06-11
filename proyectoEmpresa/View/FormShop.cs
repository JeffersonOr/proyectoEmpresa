﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace proyectoEmpresa.View
{
    public partial class FormShop : Form
    {
        int chk, am, prc;
        public FormShop()
        {
            InitializeComponent();
        }

        private void btSearchProduct_Click(object sender, EventArgs e)
        {
            string name = tbSearchProduct.Text;
            string query = "SELECT idproducto, Nombre, Precio, Categoria, Descripcion FROM productos WHERE nombre ='"+name+"'";

            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                DataSet data = new DataSet();
                adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                dgvProducts.DataSource = data;         //Define de donde sacará la info
                dgvProducts.DataMember = "productos"; //Define la tabla que aparecerá
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            try
            {
               // cbSelectCategory.Text = "Categorias";
                string consulta = "SELECT distinct Categoria FROM productos";

                MySqlConnection conection = new MySqlConnection("server=127.0.0.1; user=root; password=; database=datos_proyecto");
                cbSelectCategory.Items.Clear();

                conection.Open();
                MySqlCommand command = new MySqlCommand(consulta, conection);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cbSelectCategory.Refresh();
                    cbSelectCategory.Items.Add(dr.GetValue(0).ToString());
                }
                conection.Close();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void btShowProducts_Click(object sender, EventArgs e)
        {

            string category = cbSelectCategory.Text;
            string query = "SELECT Nombre, Precio, Descripcion FROM productos WHERE Categoria = '"+category+"'";

            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                DataSet data = new DataSet();
                adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                dgvProducts.DataSource = data;         //Define de donde sacará la info
                dgvProducts.DataMember = "productos"; //Define la tabla que aparecerá

                if (dgvProducts.Columns.Count < 5)
                {
                    DataGridViewTextBoxColumn tbc = new DataGridViewTextBoxColumn();
                    dgvProducts.Columns.Add(tbc);
                    tbc.HeaderText = "Cantidad";
             
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    dgvProducts.Columns.Add(chk);
                    chk.HeaderText = "Comprar";
                    dgvProducts.AllowUserToAddRows = false;
                }
                
               // lbColumnas.Text = "" + dgvProducts.Columns.Count;

            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void btAddToCar_Click(object sender, EventArgs e)
        {
            bool check;
            double amount, price, tot=0;
            int i;

            foreach (DataGridViewColumn column in dgvProducts.Columns)
            {
                if (column.HeaderText.Equals("Comprar"))
                {
                    chk = column.Index;
                }
                if (column.HeaderText.Equals("Cantidad"))
                {
                    am = column.Index;
                }
                if (column.HeaderText.Equals("Precio"))
                {
                    prc = column.Index;
                }
            }

                    for (i = 0; i < dgvProducts.Rows.Count; i++)
                    {
                        check = Convert.ToBoolean(dgvProducts.Rows[i].Cells[chk].Value);
                        if (check == true)
                        {
                            amount = Convert.ToDouble(dgvProducts.Rows[i].Cells[am].Value);
                            price = Convert.ToDouble(dgvProducts.Rows[i].Cells[prc].Value);

                            tot += amount * price;
                        }
                    }
            lbpruebaTotal.Text = "" + tot;
        }

        private void cbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Contar cantidad de filas y columnas(desde 1) comenzando desde cero
            // lbPruebaPrecio.Text = ""+dgvProducts.Rows.GetLastRow(DataGridViewElementStates.Displayed);
            //lbpruebaCantidad.Text = ""+dgvProducts.Columns.Count;
            //Obtiene el contenido de la celda pero comienza las columnas desde cero
            //lbpruebaEstado.Text = "" + dgvProducts.Rows[0].Cells[2].Value;
            //lbContenidoCheckBox.Text = "" + Convert.ToBoolean(dgvProducts.Rows[2].Cells[4].Value);
            //lbPruebaContenido.Text = "" + dgvProducts.Rows[2].Cells[3].Value;
            //Casillas de prueba
            //lbpruebaEstado.Text = ""+ Convert.ToString(dgvProducts.Rows[0].Cells[4].Value);
            /*lbPruebaPrecio.Text = "" + dgvProducts.Rows[1].Cells[1].Value;
            lbpruebaCantidad.Text = "" + dgvProducts.Rows[1].Cells[3].Value;
            */
        }

    }
}
