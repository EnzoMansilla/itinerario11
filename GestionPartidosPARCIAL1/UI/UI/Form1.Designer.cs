namespace UI
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
            txtEquipoLocal = new TextBox();
            txtEquipoVisitante = new TextBox();
            txtMarcadorVisitante = new TextBox();
            txtMarcadorLocal = new TextBox();
            tpFechaPartido = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            cmbDeporte = new ComboBox();
            label7 = new Label();
            btnModify = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            txtUpdate = new TextBox();
            txtDelete = new TextBox();
            label8 = new Label();
            btnDelete = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtEquipoLocal
            // 
            txtEquipoLocal.Location = new Point(34, 37);
            txtEquipoLocal.Name = "txtEquipoLocal";
            txtEquipoLocal.Size = new Size(116, 23);
            txtEquipoLocal.TabIndex = 0;
            // 
            // txtEquipoVisitante
            // 
            txtEquipoVisitante.Location = new Point(34, 80);
            txtEquipoVisitante.Name = "txtEquipoVisitante";
            txtEquipoVisitante.Size = new Size(116, 23);
            txtEquipoVisitante.TabIndex = 1;
            // 
            // txtMarcadorVisitante
            // 
            txtMarcadorVisitante.Location = new Point(675, 327);
            txtMarcadorVisitante.Name = "txtMarcadorVisitante";
            txtMarcadorVisitante.Size = new Size(116, 23);
            txtMarcadorVisitante.TabIndex = 2;
            // 
            // txtMarcadorLocal
            // 
            txtMarcadorLocal.Location = new Point(524, 327);
            txtMarcadorLocal.Name = "txtMarcadorLocal";
            txtMarcadorLocal.Size = new Size(116, 23);
            txtMarcadorLocal.TabIndex = 3;
            // 
            // tpFechaPartido
            // 
            tpFechaPartido.Location = new Point(34, 138);
            tpFechaPartido.Name = "tpFechaPartido";
            tpFechaPartido.Size = new Size(200, 23);
            tpFechaPartido.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "Equipo Local";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 63);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 7;
            label2.Text = "Equipo Visitante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 309);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "Marcador Local";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(656, 309);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 9;
            label4.Text = "Marcador Visitante";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 120);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 11;
            label6.Text = "Fecha Partido";
            // 
            // cmbDeporte
            // 
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Location = new Point(34, 199);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(121, 23);
            cmbDeporte.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 181);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 13;
            label7.Text = "Deporte";
            // 
            // btnModify
            // 
            btnModify.Location = new Point(597, 371);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(116, 23);
            btnModify.TabIndex = 14;
            btnModify.Text = "MODIFICAR";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(333, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(458, 203);
            dataGridView1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 254);
            label5.Name = "label5";
            label5.Size = new Size(224, 15);
            label5.TabIndex = 16;
            label5.Text = "Actualizar Marcador Partido, Ingrese el ID";
            // 
            // txtUpdate
            // 
            txtUpdate.Location = new Point(524, 272);
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(267, 23);
            txtUpdate.TabIndex = 17;
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(333, 272);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(149, 23);
            txtDelete.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(333, 254);
            label8.Name = "label8";
            label8.Size = new Size(161, 15);
            label8.TabIndex = 19;
            label8.Text = "Eliminar Partido, Ingrese el ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 309);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 23);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(34, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 23);
            btnSave.TabIndex = 21;
            btnSave.Text = "GUARDAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 450);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(label8);
            Controls.Add(txtDelete);
            Controls.Add(txtUpdate);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnModify);
            Controls.Add(label7);
            Controls.Add(cmbDeporte);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tpFechaPartido);
            Controls.Add(txtMarcadorLocal);
            Controls.Add(txtMarcadorVisitante);
            Controls.Add(txtEquipoVisitante);
            Controls.Add(txtEquipoLocal);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEquipoLocal;
        private TextBox txtEquipoVisitante;
        private TextBox txtMarcadorVisitante;
        private TextBox txtMarcadorLocal;
        private DateTimePicker tpFechaPartido;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox cmbDeporte;
        private Label label7;
        private Button btnModify;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txtUpdate;
        private TextBox txtDelete;
        private Label label8;
        private Button btnDelete;
        private Button btnSave;
    }
}
