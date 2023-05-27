
namespace IngEconomicaAPP
{
    partial class InteresSimple
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPeriodos = new System.Windows.Forms.ComboBox();
            this.cmbTI = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNPeriodos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.lblvpresente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIS = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(226, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "INTERES SIMPLE ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodos.FormattingEnabled = true;
            this.cmbPeriodos.Items.AddRange(new object[] {
            "Mensual",
            "Bimensual",
            "Trimestral",
            "Semestral",
            "Anual"});
            this.cmbPeriodos.Location = new System.Drawing.Point(510, 230);
            this.cmbPeriodos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Size = new System.Drawing.Size(116, 21);
            this.cmbPeriodos.TabIndex = 52;
            // 
            // cmbTI
            // 
            this.cmbTI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTI.FormattingEnabled = true;
            this.cmbTI.Items.AddRange(new object[] {
            "Mensual",
            "Bimensual",
            "Trimestral",
            "Semestral",
            "Anual"});
            this.cmbTI.Location = new System.Drawing.Point(510, 190);
            this.cmbTI.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTI.Name = "cmbTI";
            this.cmbTI.Size = new System.Drawing.Size(116, 21);
            this.cmbTI.TabIndex = 51;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label23.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(484, 192);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 19);
            this.label23.TabIndex = 50;
            this.label23.Text = "%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label19.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(342, 154);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 19);
            this.label19.TabIndex = 49;
            this.label19.Text = "$";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label18.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(342, 115);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 19);
            this.label18.TabIndex = 48;
            this.label18.Text = "$";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Snow;
            this.btnLimpiar.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpiar.Location = new System.Drawing.Point(668, 412);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 47);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Red;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Location = new System.Drawing.Point(332, 338);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(140, 47);
            this.btnCalcular.TabIndex = 46;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNPeriodos
            // 
            this.txtNPeriodos.Location = new System.Drawing.Point(361, 230);
            this.txtNPeriodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNPeriodos.Name = "txtNPeriodos";
            this.txtNPeriodos.Size = new System.Drawing.Size(111, 20);
            this.txtNPeriodos.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(165, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Número de periodos:";
            // 
            // txtTI
            // 
            this.txtTI.Location = new System.Drawing.Point(361, 191);
            this.txtTI.Margin = new System.Windows.Forms.Padding(2);
            this.txtTI.Name = "txtTI";
            this.txtTI.Size = new System.Drawing.Size(111, 20);
            this.txtTI.TabIndex = 43;
            this.txtTI.TextChanged += new System.EventHandler(this.txtTI_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(206, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tasa de interés:";
            // 
            // txtVF
            // 
            this.txtVF.Location = new System.Drawing.Point(361, 155);
            this.txtVF.Margin = new System.Windows.Forms.Padding(2);
            this.txtVF.Name = "txtVF";
            this.txtVF.Size = new System.Drawing.Size(111, 20);
            this.txtVF.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(223, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Valor futuro:";
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(361, 115);
            this.txtVP.Margin = new System.Windows.Forms.Padding(2);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(111, 20);
            this.txtVP.TabIndex = 39;
            // 
            // lblvpresente
            // 
            this.lblvpresente.AutoSize = true;
            this.lblvpresente.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblvpresente.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvpresente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblvpresente.Location = new System.Drawing.Point(207, 115);
            this.lblvpresente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvpresente.Name = "lblvpresente";
            this.lblvpresente.Size = new System.Drawing.Size(135, 19);
            this.lblvpresente.TabIndex = 38;
            this.lblvpresente.Text = "Valor presente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(240, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Seleccione:";
            // 
            // cmbIS
            // 
            this.cmbIS.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cmbIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIS.FormattingEnabled = true;
            this.cmbIS.Items.AddRange(new object[] {
            "Valor presente",
            "Valor futuro",
            "Tasa de interés",
            "Número de periodos"});
            this.cmbIS.Location = new System.Drawing.Point(346, 57);
            this.cmbIS.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIS.Name = "cmbIS";
            this.cmbIS.Size = new System.Drawing.Size(152, 21);
            this.cmbIS.TabIndex = 36;
            this.cmbIS.SelectedIndexChanged += new System.EventHandler(this.cmbIS_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbPeriodos);
            this.panel1.Controls.Add(this.cmbTI);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtNPeriodos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTI);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtVF);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtVP);
            this.panel1.Controls.Add(this.lblvpresente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbIS);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(113, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 489);
            this.panel1.TabIndex = 53;
            // 
            // InteresSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InteresSimple";
            this.Text = "InteresSimple";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPeriodos;
        private System.Windows.Forms.ComboBox cmbTI;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNPeriodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.Label lblvpresente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIS;
        private System.Windows.Forms.Panel panel1;
    }
}