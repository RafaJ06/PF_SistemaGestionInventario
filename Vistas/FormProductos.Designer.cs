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
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(480, 300);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(29, 348);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(638, 466);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(nombreProductoLabel);
            flowLayoutPanel2.Controls.Add(nombreProductoTxt);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(582, 72);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Location = new Point(3, 0);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new Size(107, 32);
            nombreProductoLabel.TabIndex = 0;
            nombreProductoLabel.Text = "Nombre:";
            // 
            // nombreProductoTxt
            // 
            nombreProductoTxt.Location = new Point(116, 3);
            nombreProductoTxt.Name = "nombreProductoTxt";
            nombreProductoTxt.Size = new Size(200, 39);
            nombreProductoTxt.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(categoriaProductoLabel);
            flowLayoutPanel3.Controls.Add(categoriaProductoTxt);
            flowLayoutPanel3.Location = new Point(3, 81);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(606, 72);
            flowLayoutPanel3.TabIndex = 5;
            // 
            // categoriaProductoLabel
            // 
            categoriaProductoLabel.AutoSize = true;
            categoriaProductoLabel.Location = new Point(3, 0);
            categoriaProductoLabel.Name = "categoriaProductoLabel";
            categoriaProductoLabel.Size = new Size(121, 32);
            categoriaProductoLabel.TabIndex = 0;
            categoriaProductoLabel.Text = "Categoria:";
            // 
            // categoriaProductoTxt
            // 
            categoriaProductoTxt.Location = new Point(130, 3);
            categoriaProductoTxt.Name = "categoriaProductoTxt";
            categoriaProductoTxt.Size = new Size(200, 39);
            categoriaProductoTxt.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(precioProductoLabel);
            flowLayoutPanel4.Controls.Add(precioProductoTxt);
            flowLayoutPanel4.Location = new Point(3, 159);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(582, 72);
            flowLayoutPanel4.TabIndex = 6;
            // 
            // precioProductoLabel
            // 
            precioProductoLabel.AutoSize = true;
            precioProductoLabel.Location = new Point(3, 0);
            precioProductoLabel.Name = "precioProductoLabel";
            precioProductoLabel.Size = new Size(84, 32);
            precioProductoLabel.TabIndex = 0;
            precioProductoLabel.Text = "Precio:";
            // 
            // precioProductoTxt
            // 
            precioProductoTxt.Location = new Point(93, 3);
            precioProductoTxt.Name = "precioProductoTxt";
            precioProductoTxt.Size = new Size(200, 39);
            precioProductoTxt.TabIndex = 5;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(existenciaProductoLabel);
            flowLayoutPanel5.Controls.Add(existenciaProductoTxt);
            flowLayoutPanel5.Location = new Point(3, 237);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(582, 72);
            flowLayoutPanel5.TabIndex = 7;
            // 
            // existenciaProductoLabel
            // 
            existenciaProductoLabel.AutoSize = true;
            existenciaProductoLabel.Location = new Point(3, 0);
            existenciaProductoLabel.Name = "existenciaProductoLabel";
            existenciaProductoLabel.Size = new Size(122, 32);
            existenciaProductoLabel.TabIndex = 0;
            existenciaProductoLabel.Text = "Existencia:";
            // 
            // existenciaProductoTxt
            // 
            existenciaProductoTxt.Location = new Point(131, 3);
            existenciaProductoTxt.Name = "existenciaProductoTxt";
            existenciaProductoTxt.Size = new Size(200, 39);
            existenciaProductoTxt.TabIndex = 5;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(proveedorProductoLabel);
            flowLayoutPanel6.Controls.Add(proveedorProductoTxt);
            flowLayoutPanel6.Location = new Point(3, 315);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(582, 72);
            flowLayoutPanel6.TabIndex = 8;
            // 
            // proveedorProductoLabel
            // 
            proveedorProductoLabel.AutoSize = true;
            proveedorProductoLabel.Location = new Point(3, 0);
            proveedorProductoLabel.Name = "proveedorProductoLabel";
            proveedorProductoLabel.Size = new Size(128, 32);
            proveedorProductoLabel.TabIndex = 0;
            proveedorProductoLabel.Text = "Proveedor:";
            // 
            // proveedorProductoTxt
            // 
            proveedorProductoTxt.Location = new Point(137, 3);
            proveedorProductoTxt.Name = "proveedorProductoTxt";
            proveedorProductoTxt.Size = new Size(200, 39);
            proveedorProductoTxt.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(3, 393);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 886);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "FormProductos";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private GroupBox groupBox1;
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
    }
}