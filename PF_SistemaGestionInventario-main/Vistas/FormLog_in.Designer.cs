namespace Windows_Form_full.Vistas
{
    partial class FormLog_in
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
            lbInicio = new Label();
            inUsuario = new TextBox();
            pIPassword = new TextBox();
            btnInicio = new Button();
            SuspendLayout();
            // 
            // lbInicio
            // 
            lbInicio.AutoSize = true;
            lbInicio.Font = new Font("Segoe UI", 15F);
            lbInicio.Location = new Point(168, 46);
            lbInicio.Margin = new Padding(2, 0, 2, 0);
            lbInicio.Name = "lbInicio";
            lbInicio.Size = new Size(226, 41);
            lbInicio.TabIndex = 3;
            lbInicio.Text = "Inicio de Sesión";
            lbInicio.Click += label1_Click;
            // 
            // inUsuario
            // 
            inUsuario.Location = new Point(197, 129);
            inUsuario.Margin = new Padding(2, 2, 2, 2);
            inUsuario.Name = "inUsuario";
            inUsuario.Size = new Size(155, 31);
            inUsuario.TabIndex = 4;
            // 
            // pIPassword
            // 
            pIPassword.Location = new Point(197, 180);
            pIPassword.Margin = new Padding(2, 2, 2, 2);
            pIPassword.Name = "pIPassword";
            pIPassword.Size = new Size(155, 31);
            pIPassword.TabIndex = 5;
            pIPassword.TextChanged += pIPassword_TextChanged;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(222, 241);
            btnInicio.Margin = new Padding(2, 2, 2, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(115, 36);
            btnInicio.TabIndex = 6;
            btnInicio.Text = "Iniciar sesión";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += button_Click_1;
            // 
            // FormLog_in
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 352);
            Controls.Add(btnInicio);
            Controls.Add(pIPassword);
            Controls.Add(inUsuario);
            Controls.Add(lbInicio);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormLog_in";
            Text = "Log_in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbInicio;
        private TextBox inUsuario;
        private TextBox pIPassword;
        private Button btnInicio;
    }
}