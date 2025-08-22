namespace Ejercicio1
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
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbAñoCalcular = new System.Windows.Forms.Label();
            this.lbValorFabrica = new System.Windows.Forms.Label();
            this.lbTasaDepresion = new System.Windows.Forms.Label();
            this.lbVidaUtil = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFabrica = new System.Windows.Forms.TextBox();
            this.tbTasadepresion = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.nudModelo = new System.Windows.Forms.NumericUpDown();
            this.nudAñoCalcular = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoCalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(82, 37);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(68, 25);
            this.lbMarca.TabIndex = 0;
            this.lbMarca.Text = "Marca";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.Location = new System.Drawing.Point(82, 148);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(139, 25);
            this.lbModelo.TabIndex = 1;
            this.lbModelo.Text = "Modelo (Año)";
            // 
            // lbAñoCalcular
            // 
            this.lbAñoCalcular.AutoSize = true;
            this.lbAñoCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAñoCalcular.Location = new System.Drawing.Point(82, 283);
            this.lbAñoCalcular.Name = "lbAñoCalcular";
            this.lbAñoCalcular.Size = new System.Drawing.Size(138, 25);
            this.lbAñoCalcular.TabIndex = 2;
            this.lbAñoCalcular.Text = "Año a calcular";
            // 
            // lbValorFabrica
            // 
            this.lbValorFabrica.AutoSize = true;
            this.lbValorFabrica.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorFabrica.Location = new System.Drawing.Point(429, 43);
            this.lbValorFabrica.Name = "lbValorFabrica";
            this.lbValorFabrica.Size = new System.Drawing.Size(207, 25);
            this.lbValorFabrica.TabIndex = 3;
            this.lbValorFabrica.Text = "Valor de fabricación $";
            // 
            // lbTasaDepresion
            // 
            this.lbTasaDepresion.AutoSize = true;
            this.lbTasaDepresion.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTasaDepresion.Location = new System.Drawing.Point(429, 167);
            this.lbTasaDepresion.Name = "lbTasaDepresion";
            this.lbTasaDepresion.Size = new System.Drawing.Size(198, 25);
            this.lbTasaDepresion.TabIndex = 4;
            this.lbTasaDepresion.Text = "Tasa de depreciacion";
            // 
            // lbVidaUtil
            // 
            this.lbVidaUtil.AutoSize = true;
            this.lbVidaUtil.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVidaUtil.Location = new System.Drawing.Point(439, 268);
            this.lbVidaUtil.Name = "lbVidaUtil";
            this.lbVidaUtil.Size = new System.Drawing.Size(152, 25);
            this.lbVidaUtil.TabIndex = 5;
            this.lbVidaUtil.Text = "Vida util (Años)";
            // 
            // tbMarca
            // 
            this.tbMarca.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarca.Location = new System.Drawing.Point(256, 37);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 31);
            this.tbMarca.TabIndex = 6;
            // 
            // tbValorFabrica
            // 
            this.tbValorFabrica.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorFabrica.Location = new System.Drawing.Point(666, 43);
            this.tbValorFabrica.Name = "tbValorFabrica";
            this.tbValorFabrica.Size = new System.Drawing.Size(100, 31);
            this.tbValorFabrica.TabIndex = 9;
            // 
            // tbTasadepresion
            // 
            this.tbTasadepresion.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTasadepresion.Location = new System.Drawing.Point(666, 167);
            this.tbTasadepresion.Name = "tbTasadepresion";
            this.tbTasadepresion.Size = new System.Drawing.Size(100, 31);
            this.tbTasadepresion.TabIndex = 10;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVidaUtil.Location = new System.Drawing.Point(666, 268);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 31);
            this.tbVidaUtil.TabIndex = 11;
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCosto.Location = new System.Drawing.Point(239, 374);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(172, 56);
            this.btnCalcularCosto.TabIndex = 12;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(524, 374);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(144, 56);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // nudModelo
            // 
            this.nudModelo.Location = new System.Drawing.Point(256, 152);
            this.nudModelo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudModelo.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudModelo.Name = "nudModelo";
            this.nudModelo.Size = new System.Drawing.Size(100, 22);
            this.nudModelo.TabIndex = 16;
            this.nudModelo.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // nudAñoCalcular
            // 
            this.nudAñoCalcular.Location = new System.Drawing.Point(256, 287);
            this.nudAñoCalcular.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAñoCalcular.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAñoCalcular.Name = "nudAñoCalcular";
            this.nudAñoCalcular.Size = new System.Drawing.Size(100, 22);
            this.nudAñoCalcular.TabIndex = 17;
            this.nudAñoCalcular.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(888, 469);
            this.Controls.Add(this.nudAñoCalcular);
            this.Controls.Add(this.nudModelo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbTasadepresion);
            this.Controls.Add(this.tbValorFabrica);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lbVidaUtil);
            this.Controls.Add(this.lbTasaDepresion);
            this.Controls.Add(this.lbValorFabrica);
            this.Controls.Add(this.lbAñoCalcular);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.lbMarca);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasacion de motos";
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoCalcular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbAñoCalcular;
        private System.Windows.Forms.Label lbValorFabrica;
        private System.Windows.Forms.Label lbTasaDepresion;
        private System.Windows.Forms.Label lbVidaUtil;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbValorFabrica;
        private System.Windows.Forms.TextBox tbTasadepresion;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.NumericUpDown nudModelo;
        private System.Windows.Forms.NumericUpDown nudAñoCalcular;
    }
}

