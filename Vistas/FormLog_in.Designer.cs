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
            label1 = new Label();
            user_input = new TextBox();
            pass_input = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(306, 54);
            label1.Name = "label1";
            label1.Size = new Size(133, 54);
            label1.TabIndex = 3;
            label1.Text = "Log in";
            // 
            // user_input
            // 
            user_input.Location = new Point(256, 164);
            user_input.Name = "user_input";
            user_input.Size = new Size(200, 39);
            user_input.TabIndex = 4;
            // 
            // pass_input
            // 
            pass_input.Location = new Point(256, 230);
            pass_input.Name = "pass_input";
            pass_input.Size = new Size(200, 39);
            pass_input.TabIndex = 5;
            // 
            // button
            // 
            button.Location = new Point(289, 308);
            button.Name = "button";
            button.Size = new Size(150, 46);
            button.TabIndex = 6;
            button.Text = "Log in";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click_1;
            // 
            // FormLog_in
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button);
            Controls.Add(pass_input);
            Controls.Add(user_input);
            Controls.Add(label1);
            Name = "FormLog_in";
            Text = "Log_in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox user_input;
        private TextBox pass_input;
        private Button button;
    }
}