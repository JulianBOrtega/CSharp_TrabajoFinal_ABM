namespace TP_Final_Julian_B_Ortega
{
    partial class winMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMain));
            this.inputFiltro = new System.Windows.Forms.TextBox();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.lblCasado = new System.Windows.Forms.Label();
            this.inputSalario = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.inputEdad = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.inputDNI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Casado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccionEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AccionEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputFiltro
            // 
            this.inputFiltro.Location = new System.Drawing.Point(17, 57);
            this.inputFiltro.Name = "inputFiltro";
            this.inputFiltro.Size = new System.Drawing.Size(564, 22);
            this.inputFiltro.TabIndex = 0;
            this.inputFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputFiltro_KeyDown);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(9, 9);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(183, 45);
            this.lblEmpleados.TabIndex = 1;
            this.lblEmpleados.Text = "Empleados";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFiltrar.Location = new System.Drawing.Point(587, 57);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(173, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.AllowUserToAddRows = false;
            this.dgEmpleados.AllowUserToDeleteRows = false;
            this.dgEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Edad,
            this.Casado,
            this.Salario,
            this.AccionEditar,
            this.AccionEliminar});
            this.dgEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmpleados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgEmpleados.EnableHeadersVisualStyles = false;
            this.dgEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgEmpleados.Location = new System.Drawing.Point(17, 85);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.ReadOnly = true;
            this.dgEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgEmpleados.RowHeadersVisible = false;
            this.dgEmpleados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmpleados.Size = new System.Drawing.Size(743, 251);
            this.dgEmpleados.TabIndex = 3;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAgregar.Location = new System.Drawing.Point(596, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar empleado";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.ForeColor = System.Drawing.Color.White;
            this.chkCasado.Location = new System.Drawing.Point(596, 27);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(64, 17);
            this.chkCasado.TabIndex = 21;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // lblCasado
            // 
            this.lblCasado.AutoSize = true;
            this.lblCasado.ForeColor = System.Drawing.Color.White;
            this.lblCasado.Location = new System.Drawing.Point(327, 55);
            this.lblCasado.Name = "lblCasado";
            this.lblCasado.Size = new System.Drawing.Size(42, 13);
            this.lblCasado.TabIndex = 20;
            this.lblCasado.Text = "Salario";
            // 
            // inputSalario
            // 
            this.inputSalario.Location = new System.Drawing.Point(378, 52);
            this.inputSalario.Name = "inputSalario";
            this.inputSalario.Size = new System.Drawing.Size(173, 22);
            this.inputSalario.TabIndex = 19;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.ForeColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(339, 27);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 13);
            this.lblEdad.TabIndex = 18;
            this.lblEdad.Text = "Edad";
            // 
            // inputEdad
            // 
            this.inputEdad.Location = new System.Drawing.Point(378, 24);
            this.inputEdad.Name = "inputEdad";
            this.inputEdad.Size = new System.Drawing.Size(173, 22);
            this.inputEdad.TabIndex = 17;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(91, 55);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 16;
            this.lblDNI.Text = "DNI";
            // 
            // inputDNI
            // 
            this.inputDNI.Location = new System.Drawing.Point(123, 52);
            this.inputDNI.Name = "inputDNI";
            this.inputDNI.Size = new System.Drawing.Size(182, 22);
            this.inputDNI.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(18, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre completo";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(123, 24);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(182, 22);
            this.inputNombre.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputNombre);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.chkCasado);
            this.groupBox1.Controls.Add(this.inputDNI);
            this.groupBox1.Controls.Add(this.lblCasado);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.inputSalario);
            this.groupBox1.Controls.Add(this.inputEdad);
            this.groupBox1.Controls.Add(this.lblEdad);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 90);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar empleado";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(198, 34);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 24;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 143;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Casado
            // 
            this.Casado.DataPropertyName = "Casado";
            dataGridViewCellStyle2.NullValue = null;
            this.Casado.DefaultCellStyle = dataGridViewCellStyle2;
            this.Casado.HeaderText = "Casado";
            this.Casado.Name = "Casado";
            this.Casado.ReadOnly = true;
            this.Casado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Salario.DefaultCellStyle = dataGridViewCellStyle3;
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AccionEditar
            // 
            this.AccionEditar.DataPropertyName = "Editar";
            this.AccionEditar.HeaderText = "Acción 1";
            this.AccionEditar.Name = "AccionEditar";
            this.AccionEditar.ReadOnly = true;
            this.AccionEditar.Text = "Editar";
            this.AccionEditar.UseColumnTextForButtonValue = true;
            // 
            // AccionEliminar
            // 
            this.AccionEliminar.DataPropertyName = "Eliminar";
            this.AccionEliminar.HeaderText = "Acción 2";
            this.AccionEliminar.Name = "AccionEliminar";
            this.AccionEliminar.ReadOnly = true;
            this.AccionEliminar.Text = "Eliminar";
            this.AccionEliminar.UseColumnTextForButtonValue = true;
            // 
            // winMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(774, 442);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.inputFiltro);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 481);
            this.MinimumSize = new System.Drawing.Size(790, 481);
            this.Name = "winMain";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFiltro;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.Label lblCasado;
        private System.Windows.Forms.TextBox inputSalario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox inputEdad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox inputDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Casado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewButtonColumn AccionEditar;
        private System.Windows.Forms.DataGridViewButtonColumn AccionEliminar;
    }
}

