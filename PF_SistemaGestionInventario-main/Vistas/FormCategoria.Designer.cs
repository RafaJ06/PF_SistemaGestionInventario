namespace Windows_Form_full.Vistas
{
    partial class FormCategoria
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
            lkProd = new LinkLabel();
            lkProv = new LinkLabel();
            lkCat = new LinkLabel();
            lbOpciones = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            nombreProductoLabel = new Label();
            nombreProductoTxt = new TextBox();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lkProd
            // 
            lkProd.AutoSize = true;
            lkProd.Location = new Point(913, 250);
            lkProd.Name = "lkProd";
            lkProd.Size = new Size(93, 25);
            lkProd.TabIndex = 10;
            lkProd.TabStop = true;
            lkProd.Text = "Productos";
            // 
            // lkProv
            // 
            lkProv.AutoSize = true;
            lkProv.Location = new Point(796, 250);
            lkProv.Name = "lkProv";
            lkProv.Size = new Size(111, 25);
            lkProv.TabIndex = 9;
            lkProv.TabStop = true;
            lkProv.Text = "Proveedores";
            // 
            // lkCat
            // 
            lkCat.AutoSize = true;
            lkCat.Location = new Point(694, 250);
            lkCat.Name = "lkCat";
            lkCat.Size = new Size(96, 25);
            lkCat.TabIndex = 8;
            lkCat.TabStop = true;
            lkCat.Text = "Categorías";
            lkCat.LinkClicked += this.lkCat_LinkClicked;
            // 
            // lbOpciones
            // 
            lbOpciones.AutoSize = true;
            lbOpciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            lbOpciones.Location = new Point(694, 208);
            lbOpciones.Name = "lbOpciones";
            lbOpciones.Size = new Size(136, 25);
            lbOpciones.TabIndex = 7;
            lbOpciones.Text = "Más Opciones:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(135, 11);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(871, 163);
            dataGridView1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            groupBox1.Location = new Point(135, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 189);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Nueva Categoría";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9F);
            btnAgregar.Location = new Point(18, 112);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 36);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += this.button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.ImageAlign = ContentAlignment.BottomCenter;
            btnEliminar.Location = new Point(140, 114);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 34);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += this.btnProducto_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(nombreProductoLabel);
            flowLayoutPanel2.Controls.Add(nombreProductoTxt);
            flowLayoutPanel2.Location = new Point(18, 53);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(448, 56);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Font = new Font("Segoe UI", 9F);
            nombreProductoLabel.Location = new Point(2, 0);
            nombreProductoLabel.Margin = new Padding(2, 0, 2, 0);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new Size(82, 25);
            nombreProductoLabel.TabIndex = 0;
            nombreProductoLabel.Text = "Nombre:";
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
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9F);
            btnEditar.Location = new Point(266, 113);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 741);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(lkProd);
            Controls.Add(lkProv);
            Controls.Add(lkCat);
            Controls.Add(lbOpciones);
            Name = "FormCategoria";
            Text = "Categorías";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lkProd;
        private LinkLabel lkProv;
        private LinkLabel lkCat;
        private Label lbOpciones;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private Button btnEliminar;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label nombreProductoLabel;
        private TextBox nombreProductoTxt;
        private Button btnEditar;
    }
}