namespace Ejercicio6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IngVal = new System.Windows.Forms.Label();
            this.txt_LosNumSon = new System.Windows.Forms.Label();
            this.IngresarNumero = new System.Windows.Forms.TextBox();
            this.comboBox_Opcion = new System.Windows.Forms.ComboBox();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROGRAMA";
            // 
            // txt_IngVal
            // 
            this.txt_IngVal.AutoSize = true;
            this.txt_IngVal.BackColor = System.Drawing.Color.Transparent;
            this.txt_IngVal.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IngVal.Location = new System.Drawing.Point(47, 130);
            this.txt_IngVal.Name = "txt_IngVal";
            this.txt_IngVal.Size = new System.Drawing.Size(145, 24);
            this.txt_IngVal.TabIndex = 2;
            this.txt_IngVal.Text = "Ingresar Valor :";
            // 
            // txt_LosNumSon
            // 
            this.txt_LosNumSon.AutoSize = true;
            this.txt_LosNumSon.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LosNumSon.Location = new System.Drawing.Point(47, 229);
            this.txt_LosNumSon.Name = "txt_LosNumSon";
            this.txt_LosNumSon.Size = new System.Drawing.Size(164, 24);
            this.txt_LosNumSon.TabIndex = 3;
            this.txt_LosNumSon.Text = "Los numeros Son :";
            // 
            // IngresarNumero
            // 
            this.IngresarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarNumero.Location = new System.Drawing.Point(230, 127);
            this.IngresarNumero.Name = "IngresarNumero";
            this.IngresarNumero.Size = new System.Drawing.Size(114, 29);
            this.IngresarNumero.TabIndex = 4;
            // 
            // comboBox_Opcion
            // 
            this.comboBox_Opcion.Cursor = System.Windows.Forms.Cursors.Help;
            this.comboBox_Opcion.FormattingEnabled = true;
            this.comboBox_Opcion.Items.AddRange(new object[] {
            "Numeros Primos",
            "Numeros Perfectos",
            "Serie Fibonacci"});
            this.comboBox_Opcion.Location = new System.Drawing.Point(419, 127);
            this.comboBox_Opcion.Name = "comboBox_Opcion";
            this.comboBox_Opcion.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Opcion.TabIndex = 8;
            this.comboBox_Opcion.Text = "Seleccione...";
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(51, 277);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(431, 212);
            this.listBoxNumeros.TabIndex = 9;
            // 
            // btn_Generar
            // 
            this.btn_Generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Generar.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generar.Location = new System.Drawing.Point(596, 111);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(128, 57);
            this.btn_Generar.TabIndex = 10;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(633, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.listBoxNumeros);
            this.Controls.Add(this.comboBox_Opcion);
            this.Controls.Add(this.IngresarNumero);
            this.Controls.Add(this.txt_LosNumSon);
            this.Controls.Add(this.txt_IngVal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ivan_Flores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_IngVal;
        private System.Windows.Forms.Label txt_LosNumSon;
        private System.Windows.Forms.TextBox IngresarNumero;
        private System.Windows.Forms.ComboBox comboBox_Opcion;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

