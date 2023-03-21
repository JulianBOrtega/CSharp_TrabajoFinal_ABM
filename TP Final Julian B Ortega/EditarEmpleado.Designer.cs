namespace TP_Final_Julian_B_Ortega
{
    partial class winEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winEditar));
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.inputDNI = new System.Windows.Forms.TextBox();
            this.lblCasado = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.inputSalario = new System.Windows.Forms.TextBox();
            this.inputEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(12, 9);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(266, 45);
            this.lblEmpleados.TabIndex = 2;
            this.lblEmpleados.Text = "Editar empleado";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(272, 34);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(232, 13);
            this.lblNombreEmpleado.TabIndex = 3;
            this.lblNombreEmpleado.Text = "Ahora mismo editando a [Nombre del empleado]";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(126, 69);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(182, 20);
            this.inputNombre.TabIndex = 23;
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnActualizar.Location = new System.Drawing.Point(599, 95);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(124, 23);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Actualizar empleado";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(21, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre completo";
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.ForeColor = System.Drawing.Color.White;
            this.chkCasado.Location = new System.Drawing.Point(599, 72);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(62, 17);
            this.chkCasado.TabIndex = 31;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // inputDNI
            // 
            this.inputDNI.Location = new System.Drawing.Point(126, 97);
            this.inputDNI.Name = "inputDNI";
            this.inputDNI.Size = new System.Drawing.Size(182, 20);
            this.inputDNI.TabIndex = 25;
            // 
            // lblCasado
            // 
            this.lblCasado.AutoSize = true;
            this.lblCasado.ForeColor = System.Drawing.Color.White;
            this.lblCasado.Location = new System.Drawing.Point(330, 100);
            this.lblCasado.Name = "lblCasado";
            this.lblCasado.Size = new System.Drawing.Size(39, 13);
            this.lblCasado.TabIndex = 30;
            this.lblCasado.Text = "Salario";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(94, 100);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 26;
            this.lblDNI.Text = "DNI";
            // 
            // inputSalario
            // 
            this.inputSalario.Location = new System.Drawing.Point(381, 97);
            this.inputSalario.Name = "inputSalario";
            this.inputSalario.Size = new System.Drawing.Size(173, 20);
            this.inputSalario.TabIndex = 29;
            // 
            // inputEdad
            // 
            this.inputEdad.Location = new System.Drawing.Point(381, 69);
            this.inputEdad.Name = "inputEdad";
            this.inputEdad.Size = new System.Drawing.Size(173, 20);
            this.inputEdad.TabIndex = 27;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.ForeColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(342, 72);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 28;
            this.lblEdad.Text = "Edad";
            // 
            // winEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(752, 140);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.inputDNI);
            this.Controls.Add(this.lblCasado);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.inputSalario);
            this.Controls.Add(this.inputEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.lblEmpleados);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(768, 179);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(768, 179);
            this.Name = "winEditar";
            this.Text = "EditarEmpleado";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.TextBox inputDNI;
        private System.Windows.Forms.Label lblCasado;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox inputSalario;
        private System.Windows.Forms.TextBox inputEdad;
        private System.Windows.Forms.Label lblEdad;
    }
}