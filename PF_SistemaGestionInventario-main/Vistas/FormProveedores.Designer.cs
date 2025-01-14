namespace Windows_Form_full.Vistas
{
    partial class FormProveedores
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
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            nombreProductoLabel = new Label();
            nombreProductoTxt = new TextBox();
            lkProd = new LinkLabel();
            lkProv = new LinkLabel();
            lkCat = new LinkLabel();
            lbOpciones = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(174, 11);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(814, 163);
            dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            groupBox1.Location = new Point(174, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 176);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Nuevo Proveedor";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9F);
            btnAgregar.Location = new Point(7, 118);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 36);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(nombreProductoLabel);
            flowLayoutPanel2.Controls.Add(nombreProductoTxt);
            flowLayoutPanel2.Location = new Point(5, 43);
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
            // lkProd
            // 
            lkProd.AutoSize = true;
            lkProd.Location = new Point(895, 234);
            lkProd.Name = "lkProd";
            lkProd.Size = new Size(93, 25);
            lkProd.TabIndex = 10;
            lkProd.TabStop = true;
            lkProd.Text = "Productos";
            // 
            // lkProv
            // 
            lkProv.AutoSize = true;
            lkProv.Location = new Point(778, 234);
            lkProv.Name = "lkProv";
            lkProv.Size = new Size(111, 25);
            lkProv.TabIndex = 9;
            lkProv.TabStop = true;
            lkProv.Text = "Proveedores";
            // 
            // lkCat
            // 
            lkCat.AutoSize = true;
            lkCat.Location = new Point(676, 234);
            lkCat.Name = "lkCat";
            lkCat.Size = new Size(96, 25);
            lkCat.TabIndex = 8;
            lkCat.TabStop = true;
            lkCat.Text = "Categorías";
            // 
            // lbOpciones
            // 
            lbOpciones.AutoSize = true;
            lbOpciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            lbOpciones.Location = new Point(676, 192);
            lbOpciones.Name = "lbOpciones";
            lbOpciones.Size = new Size(136, 25);
            lbOpciones.TabIndex = 7;
            lbOpciones.Text = "Más Opciones:";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.Location = new Point(127, 118);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9F);
            btnEditar.Location = new Point(245, 120);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 742);
            Controls.Add(lkProd);
            Controls.Add(lkProv);
            Controls.Add(lkCat);
            Controls.Add(lbOpciones);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "FormProveedores";
            Text = "Proveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label nombreProductoLabel;
        private TextBox nombreProductoTxt;
        private LinkLabel lkProd;
        private LinkLabel lkProv;
        private LinkLabel lkCat;
        private Label lbOpciones;
        private Button btnEditar;
        private Button btnEliminar;
    }
}