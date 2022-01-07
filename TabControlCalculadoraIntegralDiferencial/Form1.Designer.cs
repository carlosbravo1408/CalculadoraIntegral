namespace TabControlCalculadoraIntegralDiferencial
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcl_Calculadora = new System.Windows.Forms.TabControl();
            this.tbp_Entrada = new System.Windows.Forms.TabPage();
            this.dgv_funcion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_prueba = new System.Windows.Forms.TextBox();
            this.lbl_prueba = new System.Windows.Forms.Label();
            this.rtb_ingreso = new System.Windows.Forms.RichTextBox();
            this.tbp_Integral = new System.Windows.Forms.TabPage();
            this.pnl_area = new System.Windows.Forms.Panel();
            this.dgv_area = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_derivada = new System.Windows.Forms.Button();
            this.btn_Funcion = new System.Windows.Forms.Button();
            this.rtb_integral = new System.Windows.Forms.RichTextBox();
            this.tbp_diferencial = new System.Windows.Forms.TabPage();
            this.pnl_derivada = new System.Windows.Forms.Panel();
            this.dgv_derivada = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_integral = new System.Windows.Forms.Button();
            this.rtb_diferencial = new System.Windows.Forms.RichTextBox();
            this.Ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_coordenadas = new System.Windows.Forms.Label();
            this.tcl_Calculadora.SuspendLayout();
            this.tbp_Entrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcion)).BeginInit();
            this.tbp_Integral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_area)).BeginInit();
            this.tbp_diferencial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_derivada)).BeginInit();
            this.SuspendLayout();
            // 
            // tcl_Calculadora
            // 
            this.tcl_Calculadora.Controls.Add(this.tbp_Entrada);
            this.tcl_Calculadora.Controls.Add(this.tbp_Integral);
            this.tcl_Calculadora.Controls.Add(this.tbp_diferencial);
            this.tcl_Calculadora.Location = new System.Drawing.Point(13, 13);
            this.tcl_Calculadora.Name = "tcl_Calculadora";
            this.tcl_Calculadora.SelectedIndex = 0;
            this.tcl_Calculadora.Size = new System.Drawing.Size(860, 490);
            this.tcl_Calculadora.TabIndex = 0;
            this.tcl_Calculadora.SelectedIndexChanged += new System.EventHandler(this.tcl_Calculadora_SelectedIndexChanged);
            // 
            // tbp_Entrada
            // 
            this.tbp_Entrada.Controls.Add(this.dgv_funcion);
            this.tbp_Entrada.Controls.Add(this.btn_calcular);
            this.tbp_Entrada.Controls.Add(this.txt_prueba);
            this.tbp_Entrada.Controls.Add(this.lbl_prueba);
            this.tbp_Entrada.Controls.Add(this.rtb_ingreso);
            this.tbp_Entrada.Location = new System.Drawing.Point(4, 34);
            this.tbp_Entrada.Name = "tbp_Entrada";
            this.tbp_Entrada.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Entrada.Size = new System.Drawing.Size(852, 452);
            this.tbp_Entrada.TabIndex = 0;
            this.tbp_Entrada.Text = "Funcion";
            this.Ayuda.SetToolTip(this.tbp_Entrada, resources.GetString("tbp_Entrada.ToolTip"));
            this.tbp_Entrada.UseVisualStyleBackColor = true;
            // 
            // dgv_funcion
            // 
            this.dgv_funcion.AllowUserToAddRows = false;
            this.dgv_funcion.AllowUserToDeleteRows = false;
            this.dgv_funcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_funcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_funcion.Location = new System.Drawing.Point(459, 6);
            this.dgv_funcion.Name = "dgv_funcion";
            this.dgv_funcion.ReadOnly = true;
            this.dgv_funcion.Size = new System.Drawing.Size(390, 392);
            this.dgv_funcion.TabIndex = 4;
            this.Ayuda.SetToolTip(this.dgv_funcion, "Visualizacion de los datos :v\r\n\r\nEs mucho mas fácil importar elementos del\r\nporta" +
        "papeles al RichTextBox, que al DataGridView\r\npor eso únicamente está el DataGrid" +
        "View para\r\nvisualizar los datos :v");
            // 
            // Column1
            // 
            this.Column1.HeaderText = "x";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 48;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "f(x)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 68;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(7, 408);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(839, 38);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_prueba
            // 
            this.txt_prueba.Location = new System.Drawing.Point(396, 36);
            this.txt_prueba.Multiline = true;
            this.txt_prueba.Name = "txt_prueba";
            this.txt_prueba.Size = new System.Drawing.Size(65, 95);
            this.txt_prueba.TabIndex = 2;
            this.txt_prueba.Visible = false;
            // 
            // lbl_prueba
            // 
            this.lbl_prueba.AutoSize = true;
            this.lbl_prueba.Location = new System.Drawing.Point(396, 8);
            this.lbl_prueba.Name = "lbl_prueba";
            this.lbl_prueba.Size = new System.Drawing.Size(70, 26);
            this.lbl_prueba.TabIndex = 1;
            this.lbl_prueba.Text = "label1";
            this.lbl_prueba.Visible = false;
            // 
            // rtb_ingreso
            // 
            this.rtb_ingreso.Location = new System.Drawing.Point(3, 6);
            this.rtb_ingreso.Name = "rtb_ingreso";
            this.rtb_ingreso.Size = new System.Drawing.Size(390, 395);
            this.rtb_ingreso.TabIndex = 0;
            this.rtb_ingreso.Text = "";
            this.Ayuda.SetToolTip(this.rtb_ingreso, resources.GetString("rtb_ingreso.ToolTip"));
            this.rtb_ingreso.TextChanged += new System.EventHandler(this.rtb_ingreso_TextChanged);
            // 
            // tbp_Integral
            // 
            this.tbp_Integral.Controls.Add(this.pnl_area);
            this.tbp_Integral.Controls.Add(this.dgv_area);
            this.tbp_Integral.Controls.Add(this.btn_derivada);
            this.tbp_Integral.Controls.Add(this.btn_Funcion);
            this.tbp_Integral.Controls.Add(this.rtb_integral);
            this.tbp_Integral.Location = new System.Drawing.Point(4, 34);
            this.tbp_Integral.Name = "tbp_Integral";
            this.tbp_Integral.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Integral.Size = new System.Drawing.Size(852, 452);
            this.tbp_Integral.TabIndex = 1;
            this.tbp_Integral.Text = "Area Bajo la Curva";
            this.tbp_Integral.UseVisualStyleBackColor = true;
            // 
            // pnl_area
            // 
            this.pnl_area.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnl_area.Location = new System.Drawing.Point(242, 7);
            this.pnl_area.Name = "pnl_area";
            this.pnl_area.Size = new System.Drawing.Size(604, 394);
            this.pnl_area.TabIndex = 4;
            this.Ayuda.SetToolTip(this.pnl_area, resources.GetString("pnl_area.ToolTip"));
            this.pnl_area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_area_MouseMove);
            // 
            // dgv_area
            // 
            this.dgv_area.AllowUserToAddRows = false;
            this.dgv_area.AllowUserToDeleteRows = false;
            this.dgv_area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_area.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgv_area.Location = new System.Drawing.Point(7, 121);
            this.dgv_area.Name = "dgv_area";
            this.dgv_area.ReadOnly = true;
            this.dgv_area.Size = new System.Drawing.Size(229, 280);
            this.dgv_area.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Sub-Areas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // btn_derivada
            // 
            this.btn_derivada.Location = new System.Drawing.Point(436, 407);
            this.btn_derivada.Name = "btn_derivada";
            this.btn_derivada.Size = new System.Drawing.Size(410, 39);
            this.btn_derivada.TabIndex = 1;
            this.btn_derivada.Text = "Ver derivada";
            this.btn_derivada.UseVisualStyleBackColor = true;
            this.btn_derivada.Click += new System.EventHandler(this.btn_derivada_Click);
            // 
            // btn_Funcion
            // 
            this.btn_Funcion.Location = new System.Drawing.Point(7, 407);
            this.btn_Funcion.Name = "btn_Funcion";
            this.btn_Funcion.Size = new System.Drawing.Size(423, 39);
            this.btn_Funcion.TabIndex = 1;
            this.btn_Funcion.Text = "Volver";
            this.btn_Funcion.UseVisualStyleBackColor = true;
            this.btn_Funcion.Click += new System.EventHandler(this.btn_Funcion_Click);
            // 
            // rtb_integral
            // 
            this.rtb_integral.Location = new System.Drawing.Point(7, 7);
            this.rtb_integral.Name = "rtb_integral";
            this.rtb_integral.Size = new System.Drawing.Size(229, 107);
            this.rtb_integral.TabIndex = 0;
            this.rtb_integral.Text = "";
            // 
            // tbp_diferencial
            // 
            this.tbp_diferencial.Controls.Add(this.pnl_derivada);
            this.tbp_diferencial.Controls.Add(this.dgv_derivada);
            this.tbp_diferencial.Controls.Add(this.btn_inicio);
            this.tbp_diferencial.Controls.Add(this.btn_integral);
            this.tbp_diferencial.Controls.Add(this.rtb_diferencial);
            this.tbp_diferencial.Location = new System.Drawing.Point(4, 34);
            this.tbp_diferencial.Name = "tbp_diferencial";
            this.tbp_diferencial.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_diferencial.Size = new System.Drawing.Size(852, 452);
            this.tbp_diferencial.TabIndex = 2;
            this.tbp_diferencial.Text = "Derivada";
            this.tbp_diferencial.UseVisualStyleBackColor = true;
            // 
            // pnl_derivada
            // 
            this.pnl_derivada.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnl_derivada.Location = new System.Drawing.Point(289, 7);
            this.pnl_derivada.Name = "pnl_derivada";
            this.pnl_derivada.Size = new System.Drawing.Size(560, 395);
            this.pnl_derivada.TabIndex = 3;
            this.Ayuda.SetToolTip(this.pnl_derivada, "f(x) Azul\r\nf\'(x) Verde");
            this.pnl_derivada.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_derivada_MouseMove);
            // 
            // dgv_derivada
            // 
            this.dgv_derivada.AllowUserToAddRows = false;
            this.dgv_derivada.AllowUserToDeleteRows = false;
            this.dgv_derivada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_derivada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_derivada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_derivada.Location = new System.Drawing.Point(7, 81);
            this.dgv_derivada.Name = "dgv_derivada";
            this.dgv_derivada.ReadOnly = true;
            this.dgv_derivada.Size = new System.Drawing.Size(275, 321);
            this.dgv_derivada.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "x";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 48;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "f\'(x)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 72;
            // 
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(448, 408);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(398, 38);
            this.btn_inicio.TabIndex = 1;
            this.btn_inicio.Text = "Volver a Funcion";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_integral
            // 
            this.btn_integral.Location = new System.Drawing.Point(7, 408);
            this.btn_integral.Name = "btn_integral";
            this.btn_integral.Size = new System.Drawing.Size(398, 38);
            this.btn_integral.TabIndex = 1;
            this.btn_integral.Text = "Ver Integral";
            this.btn_integral.UseVisualStyleBackColor = true;
            this.btn_integral.Click += new System.EventHandler(this.btn_integral_Click);
            // 
            // rtb_diferencial
            // 
            this.rtb_diferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_diferencial.Location = new System.Drawing.Point(7, 7);
            this.rtb_diferencial.Name = "rtb_diferencial";
            this.rtb_diferencial.Size = new System.Drawing.Size(275, 67);
            this.rtb_diferencial.TabIndex = 0;
            this.rtb_diferencial.Text = "";
            // 
            // Ayuda
            // 
            this.Ayuda.AutoPopDelay = 10000;
            this.Ayuda.InitialDelay = 500;
            this.Ayuda.IsBalloon = true;
            this.Ayuda.ReshowDelay = 100;
            // 
            // lbl_coordenadas
            // 
            this.lbl_coordenadas.AutoSize = true;
            this.lbl_coordenadas.Location = new System.Drawing.Point(398, 9);
            this.lbl_coordenadas.Name = "lbl_coordenadas";
            this.lbl_coordenadas.Size = new System.Drawing.Size(115, 26);
            this.lbl_coordenadas.TabIndex = 1;
            this.lbl_coordenadas.Text = "X: --- Y: ---";
            this.lbl_coordenadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 508);
            this.Controls.Add(this.lbl_coordenadas);
            this.Controls.Add(this.tcl_Calculadora);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcl_Calculadora.ResumeLayout(false);
            this.tbp_Entrada.ResumeLayout(false);
            this.tbp_Entrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcion)).EndInit();
            this.tbp_Integral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_area)).EndInit();
            this.tbp_diferencial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_derivada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcl_Calculadora;
        private System.Windows.Forms.TabPage tbp_Entrada;
        private System.Windows.Forms.TabPage tbp_Integral;
        private System.Windows.Forms.TabPage tbp_diferencial;
        private System.Windows.Forms.TextBox txt_prueba;
        private System.Windows.Forms.Label lbl_prueba;
        private System.Windows.Forms.RichTextBox rtb_ingreso;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_derivada;
        private System.Windows.Forms.Button btn_Funcion;
        private System.Windows.Forms.RichTextBox rtb_integral;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_integral;
        private System.Windows.Forms.RichTextBox rtb_diferencial;
        private System.Windows.Forms.DataGridView dgv_funcion;
        private System.Windows.Forms.ToolTip Ayuda;
        private System.Windows.Forms.DataGridView dgv_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgv_derivada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel pnl_area;
        private System.Windows.Forms.Panel pnl_derivada;
        private System.Windows.Forms.Label lbl_coordenadas;
    }
}

