﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_full.Vistas
{
    public partial class FormProductos : Form
    {
        ProductosControlador productosControlador = new ProductosControlador();
        public FormProductos()
        {
            InitializeComponent();
            CargarProductos();
        }
        private void CargarProductos()
        {
            dataGridView1.DataSource = productosControlador.ObtenerProductos();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Agregar Producto nuevo
            Producto nuevoProducto = new Producto();
            nuevoProducto.nombreProducto = nombreProductoTxt.Text;
            nuevoProducto.idCategoria = int.Parse(categoriaProductoTxt.Text);
            nuevoProducto.precioProducto = double.Parse(precioProductoTxt.Text);
            nuevoProducto.cantidadProducto = int.Parse(existenciaProductoTxt.Text);
            nuevoProducto.idProveedor = int.Parse(proveedorProductoTxt.Text);
            productosControlador.AgregarProducto(nuevoProducto);
            MessageBox.Show("Producto agregado satisfactoriamente");
            CargarProductos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nombreProductoLabel_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria();
            this.Hide();
            formCategoria.Show();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }
    }

}
