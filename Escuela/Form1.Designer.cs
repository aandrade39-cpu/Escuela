namespace Escuela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Matricula = new Label();
            txtMatricula = new TextBox();
            Nombre = new Label();
            txtNombre = new TextBox();
            Semestre = new Label();
            nudSemestre = new NumericUpDown();
            label4 = new Label();
            txtGrupo = new TextBox();
            label5 = new Label();
            txtEspecialidad = new TextBox();
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            dgvAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudSemestre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // Matricula
            // 
            Matricula.AutoSize = true;
            Matricula.Location = new Point(80, 38);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(60, 15);
            Matricula.TabIndex = 0;
            Matricula.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(146, 35);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(80, 116);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(54, 15);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre:";
            Nombre.Click += Nombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // Semestre
            // 
            Semestre.AutoSize = true;
            Semestre.Location = new Point(367, 38);
            Semestre.Name = "Semestre";
            Semestre.Size = new Size(58, 15);
            Semestre.TabIndex = 4;
            Semestre.Text = "Semestre:";
            // 
            // nudSemestre
            // 
            nudSemestre.Location = new Point(428, 35);
            nudSemestre.Name = "nudSemestre";
            nudSemestre.Size = new Size(120, 23);
            nudSemestre.TabIndex = 5;
            nudSemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 116);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Grupo:";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(428, 113);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(100, 23);
            txtGrupo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 197);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 8;
            label5.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(448, 189);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(100, 23);
            txtEspecialidad.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(649, 35);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(649, 113);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(649, 194);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(16, 241);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(886, 322);
            dgvAlumnos.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 575);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEspecialidad);
            Controls.Add(label5);
            Controls.Add(txtGrupo);
            Controls.Add(label4);
            Controls.Add(nudSemestre);
            Controls.Add(Semestre);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Controls.Add(txtMatricula);
            Controls.Add(Matricula);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSemestre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Matricula;
        private TextBox txtMatricula;
        private Label Nombre;
        private TextBox txtNombre;
        private Label Semestre;
        private NumericUpDown nudSemestre;
        private Label label4;
        private TextBox txtGrupo;
        private Label label5;
        private TextBox txtEspecialidad;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnLimpiar;
        private DataGridView dgvAlumnos;
    }
}
