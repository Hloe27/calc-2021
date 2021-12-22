
namespace calc_2021
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
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnce = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnocho = new System.Windows.Forms.Button();
            this.btnnueve = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnsiete = new System.Windows.Forms.Button();
            this.btncinco = new System.Windows.Forms.Button();
            this.btnseis = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btncuatro = new System.Windows.Forms.Button();
            this.btndos = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnuno = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.Btnigual = new System.Windows.Forms.Button();
            this.Btnporcentaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(21, 37);
            this.txtresultado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtresultado.MaxLength = 17;
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(170, 30);
            this.txtresultado.TabIndex = 0;
            this.txtresultado.Text = "0";
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtresultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresultado_KeyPress);
            // 
            // btnce
            // 
            this.btnce.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnce.Location = new System.Drawing.Point(21, 88);
            this.btnce.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(38, 39);
            this.btnce.TabIndex = 2;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btndivision
            // 
            this.btndivision.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.Location = new System.Drawing.Point(153, 88);
            this.btndivision.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(38, 39);
            this.btndivision.TabIndex = 3;
            this.btndivision.Tag = "÷";
            this.btndivision.Text = "÷";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.tipoOperador);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(108, 88);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(38, 39);
            this.btnborrar.TabIndex = 4;
            this.btnborrar.Text = "←";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnc
            // 
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc.Location = new System.Drawing.Point(65, 88);
            this.btnc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(38, 39);
            this.btnc.TabIndex = 5;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnocho
            // 
            this.btnocho.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnocho.Location = new System.Drawing.Point(65, 133);
            this.btnocho.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnocho.Name = "btnocho";
            this.btnocho.Size = new System.Drawing.Size(38, 39);
            this.btnocho.TabIndex = 9;
            this.btnocho.Text = "8";
            this.btnocho.UseVisualStyleBackColor = true;
            this.btnocho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnnueve
            // 
            this.btnnueve.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnueve.Location = new System.Drawing.Point(108, 133);
            this.btnnueve.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnnueve.Name = "btnnueve";
            this.btnnueve.Size = new System.Drawing.Size(38, 39);
            this.btnnueve.TabIndex = 8;
            this.btnnueve.Text = "9";
            this.btnnueve.UseVisualStyleBackColor = true;
            this.btnnueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicar.Location = new System.Drawing.Point(153, 133);
            this.btnmultiplicar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(38, 39);
            this.btnmultiplicar.TabIndex = 7;
            this.btnmultiplicar.Tag = "*";
            this.btnmultiplicar.Text = "X";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.tipoOperador);
            // 
            // btnsiete
            // 
            this.btnsiete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiete.Location = new System.Drawing.Point(21, 133);
            this.btnsiete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsiete.Name = "btnsiete";
            this.btnsiete.Size = new System.Drawing.Size(38, 39);
            this.btnsiete.TabIndex = 6;
            this.btnsiete.Text = "7";
            this.btnsiete.UseVisualStyleBackColor = true;
            this.btnsiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btncinco
            // 
            this.btncinco.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncinco.Location = new System.Drawing.Point(65, 178);
            this.btncinco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(38, 39);
            this.btncinco.TabIndex = 13;
            this.btncinco.Text = "5";
            this.btncinco.UseVisualStyleBackColor = true;
            this.btncinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnseis
            // 
            this.btnseis.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseis.Location = new System.Drawing.Point(108, 178);
            this.btnseis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnseis.Name = "btnseis";
            this.btnseis.Size = new System.Drawing.Size(38, 39);
            this.btnseis.TabIndex = 12;
            this.btnseis.Text = "6";
            this.btnseis.UseVisualStyleBackColor = true;
            this.btnseis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(153, 178);
            this.btnresta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(38, 39);
            this.btnresta.TabIndex = 11;
            this.btnresta.Tag = "-";
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.tipoOperador);
            // 
            // btncuatro
            // 
            this.btncuatro.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuatro.Location = new System.Drawing.Point(21, 178);
            this.btncuatro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(38, 39);
            this.btncuatro.TabIndex = 10;
            this.btncuatro.Text = "4";
            this.btncuatro.UseVisualStyleBackColor = true;
            this.btncuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btndos
            // 
            this.btndos.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndos.Location = new System.Drawing.Point(65, 223);
            this.btndos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndos.Name = "btndos";
            this.btndos.Size = new System.Drawing.Size(38, 39);
            this.btndos.TabIndex = 17;
            this.btndos.Text = "2";
            this.btndos.UseVisualStyleBackColor = true;
            this.btndos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btntres
            // 
            this.btntres.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntres.Location = new System.Drawing.Point(108, 223);
            this.btntres.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(38, 39);
            this.btntres.TabIndex = 16;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(153, 223);
            this.btnsuma.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(38, 39);
            this.btnsuma.TabIndex = 15;
            this.btnsuma.Tag = "+";
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.tipoOperador);
            // 
            // btnuno
            // 
            this.btnuno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuno.Location = new System.Drawing.Point(21, 223);
            this.btnuno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnuno.Name = "btnuno";
            this.btnuno.Size = new System.Drawing.Size(38, 39);
            this.btnuno.TabIndex = 14;
            this.btnuno.Text = "1";
            this.btnuno.UseVisualStyleBackColor = true;
            this.btnuno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btncero
            // 
            this.btncero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncero.Location = new System.Drawing.Point(65, 268);
            this.btncero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(38, 39);
            this.btncero.TabIndex = 21;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = true;
            this.btncero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(108, 268);
            this.btnpunto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(38, 39);
            this.btnpunto.TabIndex = 20;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click_1);
            // 
            // Btnigual
            // 
            this.Btnigual.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnigual.Location = new System.Drawing.Point(153, 268);
            this.Btnigual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btnigual.Name = "Btnigual";
            this.Btnigual.Size = new System.Drawing.Size(38, 39);
            this.Btnigual.TabIndex = 19;
            this.Btnigual.Text = "=";
            this.Btnigual.UseVisualStyleBackColor = true;
            this.Btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // Btnporcentaje
            // 
            this.Btnporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnporcentaje.Location = new System.Drawing.Point(21, 268);
            this.Btnporcentaje.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btnporcentaje.Name = "Btnporcentaje";
            this.Btnporcentaje.Size = new System.Drawing.Size(38, 39);
            this.Btnporcentaje.TabIndex = 18;
            this.Btnporcentaje.Text = "%";
            this.Btnporcentaje.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 320);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.Btnigual);
            this.Controls.Add(this.Btnporcentaje);
            this.Controls.Add(this.btndos);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnuno);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.btnseis);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btncuatro);
            this.Controls.Add(this.btnocho);
            this.Controls.Add(this.btnnueve);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsiete);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.txtresultado);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = " Calculadora-JR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnocho;
        private System.Windows.Forms.Button btnnueve;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnsiete;
        private System.Windows.Forms.Button btncinco;
        private System.Windows.Forms.Button btnseis;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btncuatro;
        private System.Windows.Forms.Button btndos;
        private System.Windows.Forms.Button btntres;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnuno;
        private System.Windows.Forms.Button btncero;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button Btnigual;
        private System.Windows.Forms.Button Btnporcentaje;
    }
}

