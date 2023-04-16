
namespace IngEconomicaAPP
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbIS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblvpresente = new System.Windows.Forms.Label();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.txtVF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNPeriodos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 504);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.txtNPeriodos);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTI);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtVF);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtVP);
            this.tabPage1.Controls.Add(this.lblvpresente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbIS);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Interés Simple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Interés Compuesto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(412, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Anualidad";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(412, 533);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gradiente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbIS
            // 
            this.cmbIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIS.FormattingEnabled = true;
            this.cmbIS.Items.AddRange(new object[] {
            "Valor presente",
            "Valor futuro",
            "Tasa de interés",
            "Número de periodos"});
            this.cmbIS.Location = new System.Drawing.Point(171, 63);
            this.cmbIS.Name = "cmbIS";
            this.cmbIS.Size = new System.Drawing.Size(167, 24);
            this.cmbIS.TabIndex = 1;
            this.cmbIS.SelectedIndexChanged += new System.EventHandler(this.cmbIS_SelectedIndexChanged);
            this.cmbIS.SelectedValueChanged += new System.EventHandler(this.cmbIS_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione:";
            // 
            // lblvpresente
            // 
            this.lblvpresente.AutoSize = true;
            this.lblvpresente.Location = new System.Drawing.Point(95, 137);
            this.lblvpresente.Name = "lblvpresente";
            this.lblvpresente.Size = new System.Drawing.Size(105, 17);
            this.lblvpresente.TabIndex = 3;
            this.lblvpresente.Text = "Valor presente:";
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(206, 134);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(107, 22);
            this.txtVP.TabIndex = 4;
            // 
            // txtVF
            // 
            this.txtVF.Location = new System.Drawing.Point(206, 179);
            this.txtVF.Name = "txtVF";
            this.txtVF.Size = new System.Drawing.Size(107, 22);
            this.txtVF.TabIndex = 6;
            this.txtVF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor futuro:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTI
            // 
            this.txtTI.Location = new System.Drawing.Point(206, 225);
            this.txtTI.Name = "txtTI";
            this.txtTI.Size = new System.Drawing.Size(107, 22);
            this.txtTI.TabIndex = 8;
            this.txtTI.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tasa de interés:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNPeriodos
            // 
            this.txtNPeriodos.Location = new System.Drawing.Point(206, 272);
            this.txtNPeriodos.Name = "txtNPeriodos";
            this.txtNPeriodos.Size = new System.Drawing.Size(107, 22);
            this.txtNPeriodos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Número de periodos:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(130, 360);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(158, 32);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(288, 426);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 32);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.Label lblvpresente;
        private System.Windows.Forms.TextBox txtVF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNPeriodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

