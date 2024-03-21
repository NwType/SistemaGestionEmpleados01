namespace SistemaGestionEmpleados.VISTA.EmpleadosVista
{
    partial class EditarPersonaVista
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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(341, 165);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(202, 23);
            textBox5.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(341, 128);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 23);
            textBox4.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 165);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 26;
            label6.Text = "APELLIDO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 128);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 25;
            label5.Text = "NOMBRE";
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.Cancel;
            button3.Location = new Point(521, 332);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 24;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(244, 332);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 23;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(341, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 281);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 19;
            label4.Text = "FECHA DE CONTRATACION";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(343, 281);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 252);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 17;
            label3.Text = "SALARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 204);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 16;
            label2.Text = "Puesto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 95);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 15;
            label1.Text = "IDPERSONA";
            // 
            // EditarPersonaVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditarPersonaVista";
            Text = "EditarPersonaVista";
            Load += EditarPersonaVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
        private Label label5;
        private Button button3;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}