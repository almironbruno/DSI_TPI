namespace TPI_DSI
{
    partial class InterfazReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Gril_RecursosTecnologicos = new System.Windows.Forms.DataGridView();
            this.Gril_Turnos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_numeroRT = new System.Windows.Forms.TextBox();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.Txt_Modelo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_FechaHoraInicio = new System.Windows.Forms.TextBox();
            this.Txt_FechaHoraFin = new System.Windows.Forms.TextBox();
            this.Txt_DiaSemana = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Cmb_TipoRecurso = new System.Windows.Forms.ComboBox();
            this.Gril_DetalleTurnos = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmb_Centro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gril_RecursosTecnologicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gril_Turnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gril_DetalleTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reserva de Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Recurso";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(461, 59);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(78, 28);
            this.Btn_Aceptar.TabIndex = 3;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Gril_RecursosTecnologicos
            // 
            this.Gril_RecursosTecnologicos.AllowUserToAddRows = false;
            this.Gril_RecursosTecnologicos.AllowUserToDeleteRows = false;
            this.Gril_RecursosTecnologicos.AllowUserToResizeColumns = false;
            this.Gril_RecursosTecnologicos.AllowUserToResizeRows = false;
            this.Gril_RecursosTecnologicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gril_RecursosTecnologicos.Location = new System.Drawing.Point(12, 93);
            this.Gril_RecursosTecnologicos.MultiSelect = false;
            this.Gril_RecursosTecnologicos.Name = "Gril_RecursosTecnologicos";
            this.Gril_RecursosTecnologicos.ReadOnly = true;
            this.Gril_RecursosTecnologicos.RowHeadersVisible = false;
            this.Gril_RecursosTecnologicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gril_RecursosTecnologicos.Size = new System.Drawing.Size(410, 240);
            this.Gril_RecursosTecnologicos.TabIndex = 4;
            this.Gril_RecursosTecnologicos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gril_RecursosTecnologicos_CellContentDoubleClick);
            // 
            // Gril_Turnos
            // 
            this.Gril_Turnos.AllowUserToAddRows = false;
            this.Gril_Turnos.AllowUserToDeleteRows = false;
            this.Gril_Turnos.AllowUserToResizeColumns = false;
            this.Gril_Turnos.AllowUserToResizeRows = false;
            this.Gril_Turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gril_Turnos.Location = new System.Drawing.Point(438, 93);
            this.Gril_Turnos.Name = "Gril_Turnos";
            this.Gril_Turnos.ReadOnly = true;
            this.Gril_Turnos.RowHeadersVisible = false;
            this.Gril_Turnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Gril_Turnos.Size = new System.Drawing.Size(410, 240);
            this.Gril_Turnos.TabIndex = 5;
            this.Gril_Turnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gril_Turnos_CellContentClick);
            this.Gril_Turnos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gril_Turnos_CellContentDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recurso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero";
            // 
            // Txt_numeroRT
            // 
            this.Txt_numeroRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numeroRT.Location = new System.Drawing.Point(144, 368);
            this.Txt_numeroRT.Name = "Txt_numeroRT";
            this.Txt_numeroRT.ReadOnly = true;
            this.Txt_numeroRT.Size = new System.Drawing.Size(100, 26);
            this.Txt_numeroRT.TabIndex = 8;
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Marca.Location = new System.Drawing.Point(144, 400);
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.ReadOnly = true;
            this.Txt_Marca.Size = new System.Drawing.Size(100, 26);
            this.Txt_Marca.TabIndex = 8;
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Modelo.Location = new System.Drawing.Point(144, 432);
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.ReadOnly = true;
            this.Txt_Modelo.Size = new System.Drawing.Size(100, 26);
            this.Txt_Modelo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Turno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(304, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dia de Semana";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(334, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = " Hora Inicio";
            // 
            // Txt_FechaHoraInicio
            // 
            this.Txt_FechaHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaHoraInicio.Location = new System.Drawing.Point(449, 400);
            this.Txt_FechaHoraInicio.Name = "Txt_FechaHoraInicio";
            this.Txt_FechaHoraInicio.ReadOnly = true;
            this.Txt_FechaHoraInicio.Size = new System.Drawing.Size(100, 26);
            this.Txt_FechaHoraInicio.TabIndex = 8;
            // 
            // Txt_FechaHoraFin
            // 
            this.Txt_FechaHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaHoraFin.Location = new System.Drawing.Point(449, 432);
            this.Txt_FechaHoraFin.Name = "Txt_FechaHoraFin";
            this.Txt_FechaHoraFin.ReadOnly = true;
            this.Txt_FechaHoraFin.Size = new System.Drawing.Size(100, 26);
            this.Txt_FechaHoraFin.TabIndex = 8;
            // 
            // Txt_DiaSemana
            // 
            this.Txt_DiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DiaSemana.Location = new System.Drawing.Point(449, 464);
            this.Txt_DiaSemana.Name = "Txt_DiaSemana";
            this.Txt_DiaSemana.ReadOnly = true;
            this.Txt_DiaSemana.Size = new System.Drawing.Size(100, 26);
            this.Txt_DiaSemana.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(352, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Hora Fin";
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Enabled = false;
            this.Btn_Confirmar.Location = new System.Drawing.Point(13, 491);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(94, 32);
            this.Btn_Confirmar.TabIndex = 9;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(113, 491);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(94, 32);
            this.Btn_Cancelar.TabIndex = 9;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Cmb_TipoRecurso
            // 
            this.Cmb_TipoRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoRecurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_TipoRecurso.FormattingEnabled = true;
            this.Cmb_TipoRecurso.Location = new System.Drawing.Point(144, 59);
            this.Cmb_TipoRecurso.Name = "Cmb_TipoRecurso";
            this.Cmb_TipoRecurso.Size = new System.Drawing.Size(121, 28);
            this.Cmb_TipoRecurso.TabIndex = 11;
            this.Cmb_TipoRecurso.SelectionChangeCommitted += new System.EventHandler(this.Cmb_TipoRecurso_SelectionChangeCommitted);
            // 
            // Gril_DetalleTurnos
            // 
            this.Gril_DetalleTurnos.AllowUserToAddRows = false;
            this.Gril_DetalleTurnos.AllowUserToDeleteRows = false;
            this.Gril_DetalleTurnos.AllowUserToResizeColumns = false;
            this.Gril_DetalleTurnos.AllowUserToResizeRows = false;
            this.Gril_DetalleTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gril_DetalleTurnos.Location = new System.Drawing.Point(866, 93);
            this.Gril_DetalleTurnos.Name = "Gril_DetalleTurnos";
            this.Gril_DetalleTurnos.ReadOnly = true;
            this.Gril_DetalleTurnos.RowHeadersVisible = false;
            this.Gril_DetalleTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gril_DetalleTurnos.Size = new System.Drawing.Size(393, 240);
            this.Gril_DetalleTurnos.TabIndex = 12;
            this.Gril_DetalleTurnos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gril_DetalleTurnos_CellContentDoubleClick);
            // 
            // cmb_Centro
            // 
            this.cmb_Centro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_Centro.FormattingEnabled = true;
            this.cmb_Centro.Location = new System.Drawing.Point(334, 59);
            this.cmb_Centro.Name = "cmb_Centro";
            this.cmb_Centro.Size = new System.Drawing.Size(121, 28);
            this.cmb_Centro.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(363, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha";
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_fecha.Location = new System.Drawing.Point(449, 368);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.ReadOnly = true;
            this.Txt_fecha.Size = new System.Drawing.Size(100, 26);
            this.Txt_fecha.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox1.Location = new System.Drawing.Point(694, 370);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Mail";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox2.Location = new System.Drawing.Point(694, 402);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Whatsapp";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox3.Location = new System.Drawing.Point(694, 432);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(131, 24);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Mensaje Texto";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(271, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Centro";
            // 
            // InterfazReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 573);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Centro);
            this.Controls.Add(this.Gril_DetalleTurnos);
            this.Controls.Add(this.Cmb_TipoRecurso);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.Txt_DiaSemana);
            this.Controls.Add(this.Txt_FechaHoraFin);
            this.Controls.Add(this.Txt_Modelo);
            this.Controls.Add(this.Txt_FechaHoraInicio);
            this.Controls.Add(this.Txt_Marca);
            this.Controls.Add(this.Txt_numeroRT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gril_Turnos);
            this.Controls.Add(this.Gril_RecursosTecnologicos);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InterfazReserva";
            this.Text = "Reserva de Turno";
            this.Load += new System.EventHandler(this.InterfazReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gril_RecursosTecnologicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gril_Turnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gril_DetalleTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.DataGridView Gril_RecursosTecnologicos;
        private System.Windows.Forms.DataGridView Gril_Turnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_numeroRT;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.TextBox Txt_Modelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_FechaHoraInicio;
        private System.Windows.Forms.TextBox Txt_FechaHoraFin;
        private System.Windows.Forms.TextBox Txt_DiaSemana;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.DataGridView Gril_DetalleTurnos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmb_Centro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox Cmb_TipoRecurso;

        private void Gril_Turnos_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void Cmb_TipoRecurso_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            Gril_RecursosTecnologicos.Rows.Clear();
            Btn_Aceptar.Enabled = true;
            cmb_Centro.Items.Clear();
            cmb_Centro.Items.Add("Todos");
            cmb_Centro.SelectedIndex=0;
            //gestorRecursos.tomarSeleccion(Cmb_TipoRecurso.Text.ToString());
            
        }

        private System.Windows.Forms.Label label13;
    }
}

