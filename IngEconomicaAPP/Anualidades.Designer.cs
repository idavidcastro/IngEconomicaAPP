
namespace IngEconomicaAPP
{
    partial class Anualidades
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
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPeriodos2 = new System.Windows.Forms.ComboBox();
            this.cmbTI2 = new System.Windows.Forms.ComboBox();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.txtNPeriodosA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTIA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTAnualidades = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Chartreuse;
            this.label12.Location = new System.Drawing.Point(280, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(688, 91);
            this.label12.TabIndex = 52;
            this.label12.Text = "ANUALIDADES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbVS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRenta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbPeriodos2);
            this.panel1.Controls.Add(this.cmbTI2);
            this.panel1.Controls.Add(this.btnLimpiar2);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btnCalcular2);
            this.panel1.Controls.Add(this.txtNPeriodosA);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTIA);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtVf);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtVA);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbTAnualidades);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(52, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 574);
            this.panel1.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(357, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Seleccione:";
            // 
            // cmbVS
            // 
            this.cmbVS.BackColor = System.Drawing.SystemColors.Info;
            this.cmbVS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVS.FormattingEnabled = true;
            this.cmbVS.Items.AddRange(new object[] {
            "Valor actual",
            "Valor final",
            "Número de periodos",
            "Renta"});
            this.cmbVS.Location = new System.Drawing.Point(498, 117);
            this.cmbVS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVS.Name = "cmbVS";
            this.cmbVS.Size = new System.Drawing.Size(201, 24);
            this.cmbVS.TabIndex = 60;
            this.cmbVS.SelectedIndexChanged += new System.EventHandler(this.cmbVS_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(509, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "$";
            // 
            // txtRenta
            // 
            this.txtRenta.Location = new System.Drawing.Point(533, 368);
            this.txtRenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.Size = new System.Drawing.Size(147, 22);
            this.txtRenta.TabIndex = 58;
            this.txtRenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRenta_KeyDown);
            this.txtRenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRenta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(318, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Valor de renta:";
            // 
            // cmbPeriodos2
            // 
            this.cmbPeriodos2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodos2.FormattingEnabled = true;
            this.cmbPeriodos2.Items.AddRange(new object[] {
            "Meses",
            "bimeses",
            "Trimestres",
            "Semestres",
            "Años"});
            this.cmbPeriodos2.Location = new System.Drawing.Point(734, 326);
            this.cmbPeriodos2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPeriodos2.Name = "cmbPeriodos2";
            this.cmbPeriodos2.Size = new System.Drawing.Size(153, 24);
            this.cmbPeriodos2.TabIndex = 56;
            // 
            // cmbTI2
            // 
            this.cmbTI2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTI2.FormattingEnabled = true;
            this.cmbTI2.Items.AddRange(new object[] {
            "Mensual",
            "Bimensual",
            "Trimestral",
            "Semestral",
            "Anual"});
            this.cmbTI2.Location = new System.Drawing.Point(734, 277);
            this.cmbTI2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTI2.Name = "cmbTI2";
            this.cmbTI2.Size = new System.Drawing.Size(153, 24);
            this.cmbTI2.TabIndex = 55;
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimpiar2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar2.FlatAppearance.BorderSize = 2;
            this.btnLimpiar2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnLimpiar2.Location = new System.Drawing.Point(1008, 503);
            this.btnLimpiar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(117, 53);
            this.btnLimpiar2.TabIndex = 49;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = false;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(689, 278);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 21);
            this.label22.TabIndex = 54;
            this.label22.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(509, 234);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 21);
            this.label21.TabIndex = 53;
            this.label21.Text = "$";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(509, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 21);
            this.label20.TabIndex = 52;
            this.label20.Text = "$";
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCalcular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular2.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCalcular2.Location = new System.Drawing.Point(533, 443);
            this.btnCalcular2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(157, 58);
            this.btnCalcular2.TabIndex = 48;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = false;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // txtNPeriodosA
            // 
            this.txtNPeriodosA.Location = new System.Drawing.Point(533, 324);
            this.txtNPeriodosA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNPeriodosA.Name = "txtNPeriodosA";
            this.txtNPeriodosA.Size = new System.Drawing.Size(147, 22);
            this.txtNPeriodosA.TabIndex = 47;
            this.txtNPeriodosA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNPeriodosA_KeyDown);
            this.txtNPeriodosA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNPeriodosA_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.Location = new System.Drawing.Point(257, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Número de periodos:";
            // 
            // txtTIA
            // 
            this.txtTIA.Location = new System.Drawing.Point(533, 276);
            this.txtTIA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTIA.Name = "txtTIA";
            this.txtTIA.Size = new System.Drawing.Size(147, 22);
            this.txtTIA.TabIndex = 45;
            this.txtTIA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTIA_KeyDown);
            this.txtTIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTIA_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightYellow;
            this.label8.Location = new System.Drawing.Point(312, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "Tasa de interés:";
            // 
            // txtVf
            // 
            this.txtVf.Location = new System.Drawing.Point(533, 232);
            this.txtVf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVf.Name = "txtVf";
            this.txtVf.Size = new System.Drawing.Size(147, 22);
            this.txtVf.TabIndex = 43;
            this.txtVf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVf_KeyDown);
            this.txtVf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVf_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightYellow;
            this.label9.Location = new System.Drawing.Point(356, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "Valor final:";
            // 
            // txtVA
            // 
            this.txtVA.Location = new System.Drawing.Point(533, 181);
            this.txtVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVA.Name = "txtVA";
            this.txtVA.Size = new System.Drawing.Size(147, 22);
            this.txtVA.TabIndex = 41;
            this.txtVA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVA_KeyDown);
            this.txtVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVA_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightYellow;
            this.label10.Location = new System.Drawing.Point(333, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "Valor Actual:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightYellow;
            this.label11.Location = new System.Drawing.Point(357, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 23);
            this.label11.TabIndex = 39;
            this.label11.Text = "Seleccione:";
            // 
            // cmbTAnualidades
            // 
            this.cmbTAnualidades.BackColor = System.Drawing.SystemColors.Info;
            this.cmbTAnualidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTAnualidades.FormattingEnabled = true;
            this.cmbTAnualidades.Items.AddRange(new object[] {
            "Anticipadas",
            "Vencidas"});
            this.cmbTAnualidades.Location = new System.Drawing.Point(498, 74);
            this.cmbTAnualidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTAnualidades.Name = "cmbTAnualidades";
            this.cmbTAnualidades.Size = new System.Drawing.Size(201, 24);
            this.cmbTAnualidades.TabIndex = 38;
            this.cmbTAnualidades.SelectedIndexChanged += new System.EventHandler(this.cmbIS2_SelectedIndexChanged);
            // 
            // Anualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1248, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Anualidades";
            this.Text = "Anualidades";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbPeriodos2;
        private System.Windows.Forms.ComboBox cmbTI2;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCalcular2;
        private System.Windows.Forms.TextBox txtNPeriodosA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTIA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTAnualidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVS;
    }
}