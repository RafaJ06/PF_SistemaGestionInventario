namespace Windows_Form_full.Vistas
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            nombreProductoLabel = new Label();
            nombreProductoTxt = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            categoriaProductoLabel = new Label();
            categoriaProductoTxt = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            precioProductoLabel = new Label();
            precioProductoTxt = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            existenciaProductoLabel = new Label();
            existenciaProductoTxt = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            proveedorProductoLabel = new Label();
            proveedorProductoTxt = new TextBox();
            button1 = new Button();
            lbOpciones = new Label();
            lkCat = new LinkLabel();
            groupBox1 = new GroupBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            lkProv = new LinkLabel();
            lkProd = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(144, 11);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(813, 156);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(nombreProductoLabel);
            flowLayoutPanel2.Controls.Add(nombreProductoTxt);
            flowLayoutPanel2.Font = new Font("Segoe UI", 9F);
            flowLayoutPanel2.Location = new Point(5, 40);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(448, 56);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Location = new Point(2, 0);
            nombreProductoLabel.Margin = new Padding(2, 0, 2, 0);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new Size(82, 25);
            nombreProductoLabel.TabIndex = 0;
            nombreProductoLabel.Text = "Nombre:";
            nombreProductoLabel.Click += nombreProductoLabel_Click;
            // 
            // nombreProductoTxt
            // 
            nombreProductoTxt.BorderStyle = BorderStyle.None;
            nombreProductoTxt.Dock = DockStyle.Left;
            nombreProductoTxt.Location = new Point(88, 2);
            nombreProductoTxt.Margin = new Padding(2);
            nombreProductoTxt.Name = "nombreProductoTxt";
            nombreProductoTxt.Size = new Size(155, 24);
            nombreProductoTxt.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(categoriaProductoLabel);
            flowLayoutPanel3.Controls.Add(categoriaProductoTxt);
            flowLayoutPanel3.Font = new Font("Segoe UI", 9F);
            flowLayoutPanel3.Location = new Point(5, 100);
            flowLayoutPanel3.Margin = new Padding(2);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(448, 56);
            flowLayoutPanel3.TabIndex = 5;
            // 
            // categoriaProductoLabel
            // 
            categoriaProductoLabel.AutoSize = true;
            categoriaProductoLabel.Location = new Point(2, 0);
            categoriaProductoLabel.Margin = new Padding(2, 0, 2, 0);
            categoriaProductoLabel.Name = "categoriaProductoLabel";
            categoriaProductoLabel.Size = new Size(92, 25);
            categoriaProductoLabel.TabIndex = 0;
            categoriaProductoLabel.Text = "Categoria:";
            // 
            // categoriaProductoTxt
            // 
            categoriaProductoTxt.BorderStyle = BorderStyle.None;
            categoriaProductoTxt.Location = new Point(98, 2);
            categoriaProductoTxt.Margin = new Padding(2);
            categoriaProductoTxt.Name = "categoriaProductoTxt";
            categoriaProductoTxt.Size = new Size(145, 24);
            categoriaProductoTxt.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(precioProductoLabel);
            flowLayoutPanel4.Controls.Add(precioProductoTxt);
            flowLayoutPanel4.Font = new Font("Segoe UI", 9F);
            flowLayoutPanel4.Location = new Point(5, 220);
            flowLayoutPanel4.Margin = new Padding(2);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(448, 56);
            flowLayoutPanel4.TabIndex = 6;
            // 
            // precioProductoLabel
            // 
            precioProductoLabel.AutoSize = true;
            precioProductoLabel.Location = new Point(2, 0);
            precioProductoLabel.Margin = new Padding(2, 0, 2, 0);
            precioProductoLabel.Name = "precioProductoLabel";
            precioProductoLabel.Size = new Size(64, 25);
            precioProductoLabel.TabIndex = 0;
            precioProductoLabel.Text = "Precio:";
            // 
            // precioProductoTxt
            // 
            precioProductoTxt.BorderStyle = BorderStyle.None;
            precioProductoTxt.Location = new Point(70, 2);
            precioProductoTxt.Margin = new Padding(2);
            precioProductoTxt.Name = "precioProductoTxt";
            precioProductoTxt.Size = new Size(173, 24);
            precioProductoTxt.TabIndex = 5;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(existenciaProductoLabel);
            flowLayoutPanel5.Controls.Add(existenciaProductoTxt);
            flowLayoutPanel5.Font = new Font("Segoe UI", 9F);
            flowLayoutPanel5.Location = new Point(5, 160);
            flowLayoutPanel5.Margin = new Padding(2);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(448, 56);
            flowLayoutPanel5.TabIndex = 7;
            // 
            // existenciaProductoLabel
            // 
            existenciaProductoLabel.AutoSize = true;
            existenciaProductoLabel.Location = new Point(2, 0);
            existenciaProductoLabel.Margin = new Padding(2, 0, 2, 0);
            existenciaProductoLabel.Name = "existenciaProductoLabel";
            existenciaProductoLabel.Size = new Size(91, 25);
            existenciaProductoLabel.TabIndex = 0;
            existenciaProductoLabel.Text = "Existencia:";
            // 
            // existenciaProductoTxt
            // 
            existenciaProductoTxt.BorderStyle = BorderStyle.None;
            existenciaProductoTxt.Location = new Point(97, 2);
            existenciaProductoTxt.Margin = new Padding(2);
            existenciaProductoTxt.Name = "existenciaProductoTxt";
            existenciaProductoTxt.Size = new Size(146, 24);
            existenciaProductoTxt.TabIndex = 5;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(proveedorProductoLabel);
            flowLayoutPanel6.Controls.Add(proveedorProductoTxt);
            flowLayoutPanel6.Font = new Font("Segoe UI", 9F);
            flowLayoutPanel6.Location = new Point(5, 280);
            flowLayoutPanel6.Margin = new Padding(2);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(448, 56);
            flowLayoutPanel6.TabIndex = 8;
            flowLayoutPanel6.Paint += flowLayoutPanel6_Paint;
            // 
            // proveedorProductoLabel
            // 
            proveedorProductoLabel.AutoSize = true;
            proveedorProductoLabel.Location = new Point(2, 0);
            proveedorProductoLabel.Margin = new Padding(2, 0, 2, 0);
            proveedorProductoLabel.Name = "proveedorProductoLabel";
            proveedorProductoLabel.Size = new Size(98, 25);
            proveedorProductoLabel.TabIndex = 0;
            proveedorProductoLabel.Text = "Proveedor:";
            // 
            // proveedorProductoTxt
            // 
            proveedorProductoTxt.BorderStyle = BorderStyle.None;
            proveedorProductoTxt.Location = new Point(104, 2);
            proveedorProductoTxt.Margin = new Padding(2);
            proveedorProductoTxt.Name = "proveedorProductoTxt";
            proveedorProductoTxt.Size = new Size(155, 24);
            proveedorProductoTxt.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(7, 340);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(115, 36);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lbOpciones
            // 
            lbOpciones.AutoSize = true;
            lbOpciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            lbOpciones.Location = new Point(641, 201);
            lbOpciones.Name = "lbOpciones";
            lbOpciones.Size = new Size(136, 25);
            lbOpciones.TabIndex = 2;
            lbOpciones.Text = "Más Opciones:";
            // 
            // lkCat
            // 
            lkCat.AutoSize = true;
            lkCat.Location = new Point(641, 243);
            lkCat.Name = "lkCat";
            lkCat.Size = new Size(96, 25);
            lkCat.TabIndex = 3;
            lkCat.TabStop = true;
            lkCat.Text = "Categorías";
            lkCat.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Controls.Add(flowLayoutPanel6);
            groupBox1.Controls.Add(flowLayoutPanel4);
            groupBox1.Controls.Add(flowLayoutPanel5);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            groupBox1.Location = new Point(144, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 399);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Nuevo Producto";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9F);
            btnEditar.Location = new Point(253, 342);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.ImageAlign = ContentAlignment.BottomCenter;
            btnEliminar.Location = new Point(127, 341);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 34);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lkProv
            // 
            lkProv.AutoSize = true;
            lkProv.Location = new Point(743, 243);
            lkProv.Name = "lkProv";
            lkProv.Size = new Size(111, 25);
            lkProv.TabIndex = 5;
            lkProv.TabStop = true;
            lkProv.Text = "Proveedores";
            // 
            // lkProd
            // 
            lkProd.AutoSize = true;
            lkProd.Location = new Point(860, 243);
            lkProd.Name = "lkProd";
            lkProd.Size = new Size(93, 25);
            lkProd.TabIndex = 6;
            lkProd.TabStop = true;
            lkProd.Text = "Productos";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 741);
            Controls.Add(lkProd);
            Controls.Add(lkProv);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(lkCat);
            Controls.Add(lbOpciones);
            Margin = new Padding(2);
            Name = "FormProductos";
            Text = "Productos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label nombreProductoLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox nombreProductoTxt;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label categoriaProductoLabel;
        private TextBox categoriaProductoTxt;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label precioProductoLabel;
        private TextBox precioProductoTxt;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label existenciaProductoLabel;
        private TextBox existenciaProductoTxt;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label proveedorProductoLabel;
        private TextBox proveedorProductoTxt;
        private Button button1;
        private Label lbOpciones;
        private LinkLabel lkCat;
        private GroupBox groupBox1;
        private LinkLabel lkProv;
        private LinkLabel lkProd;
        private Button btnEliminar;
        private Button btnEditar;
    }
}