﻿namespace PagoAgilFrba.Rendicion
{
    partial class ABMRendicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMRendicion));
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTImp = new System.Windows.Forms.Label();
            this.labelTCom = new System.Windows.Forms.Label();
            this.labelTCant = new System.Windows.Forms.Label();
            this.labelImp = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.labelCant = new System.Windows.Forms.Label();
            this.labelTitRend = new System.Windows.Forms.Label();
            this.cbPorcComision = new System.Windows.Forms.ComboBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.btnRendir = new System.Windows.Forms.Button();
            this.lblFechaRendicion = new System.Windows.Forms.Label();
            this.dtRendicion = new System.Windows.Forms.DateTimePicker();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(81, 49);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(174, 23);
            this.cbEmpresa.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTImp);
            this.groupBox1.Controls.Add(this.labelTCom);
            this.groupBox1.Controls.Add(this.labelTCant);
            this.groupBox1.Controls.Add(this.labelImp);
            this.groupBox1.Controls.Add(this.labelCom);
            this.groupBox1.Controls.Add(this.labelCant);
            this.groupBox1.Controls.Add(this.labelTitRend);
            this.groupBox1.Controls.Add(this.cbPorcComision);
            this.groupBox1.Controls.Add(this.lblPorcentaje);
            this.groupBox1.Controls.Add(this.btnRendir);
            this.groupBox1.Controls.Add(this.lblFechaRendicion);
            this.groupBox1.Controls.Add(this.dtRendicion);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Controls.Add(this.cbEmpresa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendición";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelTImp
            // 
            this.labelTImp.AutoSize = true;
            this.labelTImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTImp.Location = new System.Drawing.Point(464, 214);
            this.labelTImp.Name = "labelTImp";
            this.labelTImp.Size = new System.Drawing.Size(11, 16);
            this.labelTImp.TabIndex = 13;
            this.labelTImp.Text = ".";
            // 
            // labelTCom
            // 
            this.labelTCom.AutoSize = true;
            this.labelTCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTCom.Location = new System.Drawing.Point(464, 179);
            this.labelTCom.Name = "labelTCom";
            this.labelTCom.Size = new System.Drawing.Size(11, 16);
            this.labelTCom.TabIndex = 12;
            this.labelTCom.Text = ".";
            // 
            // labelTCant
            // 
            this.labelTCant.AutoSize = true;
            this.labelTCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTCant.Location = new System.Drawing.Point(464, 147);
            this.labelTCant.Name = "labelTCant";
            this.labelTCant.Size = new System.Drawing.Size(11, 16);
            this.labelTCant.TabIndex = 11;
            this.labelTCant.Text = ".";
            // 
            // labelImp
            // 
            this.labelImp.AutoSize = true;
            this.labelImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImp.Location = new System.Drawing.Point(276, 214);
            this.labelImp.Name = "labelImp";
            this.labelImp.Size = new System.Drawing.Size(111, 16);
            this.labelImp.TabIndex = 10;
            this.labelImp.Text = "Importe Rendido:";
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCom.Location = new System.Drawing.Point(276, 179);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(115, 16);
            this.labelCom.TabIndex = 9;
            this.labelCom.Text = "Importe Comisión:";
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCant.Location = new System.Drawing.Point(276, 147);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(182, 16);
            this.labelCant.TabIndex = 8;
            this.labelCant.Text = "Cantidad Facturas Rendidas:";
            // 
            // labelTitRend
            // 
            this.labelTitRend.AutoSize = true;
            this.labelTitRend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitRend.Location = new System.Drawing.Point(276, 115);
            this.labelTitRend.Name = "labelTitRend";
            this.labelTitRend.Size = new System.Drawing.Size(136, 16);
            this.labelTitRend.TabIndex = 7;
            this.labelTitRend.Text = "Rendicion Efectuada:";
            // 
            // cbPorcComision
            // 
            this.cbPorcComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorcComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPorcComision.FormattingEnabled = true;
            this.cbPorcComision.Location = new System.Drawing.Point(683, 46);
            this.cbPorcComision.Name = "cbPorcComision";
            this.cbPorcComision.Size = new System.Drawing.Size(42, 23);
            this.cbPorcComision.TabIndex = 6;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(503, 50);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(176, 20);
            this.lblPorcentaje.TabIndex = 5;
            this.lblPorcentaje.Text = "Porcentaje de Comisión";
            // 
            // btnRendir
            // 
            this.btnRendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendir.Location = new System.Drawing.Point(337, 274);
            this.btnRendir.Name = "btnRendir";
            this.btnRendir.Size = new System.Drawing.Size(75, 23);
            this.btnRendir.TabIndex = 4;
            this.btnRendir.Text = "Rendir";
            this.btnRendir.UseVisualStyleBackColor = true;
            this.btnRendir.Click += new System.EventHandler(this.btnRendir_Click);
            // 
            // lblFechaRendicion
            // 
            this.lblFechaRendicion.AutoSize = true;
            this.lblFechaRendicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRendicion.Location = new System.Drawing.Point(257, 50);
            this.lblFechaRendicion.Name = "lblFechaRendicion";
            this.lblFechaRendicion.Size = new System.Drawing.Size(129, 20);
            this.lblFechaRendicion.TabIndex = 3;
            this.lblFechaRendicion.Text = "Fecha Rendición";
            // 
            // dtRendicion
            // 
            this.dtRendicion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRendicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRendicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRendicion.Location = new System.Drawing.Point(390, 47);
            this.dtRendicion.Name = "dtRendicion";
            this.dtRendicion.Size = new System.Drawing.Size(104, 26);
            this.dtRendicion.TabIndex = 2;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(8, 50);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(73, 20);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Empresa";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(368, 359);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ABMRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 391);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMRendicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendicion";
            this.Load += new System.EventHandler(this.ABMRendicion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRendir;
        private System.Windows.Forms.Label lblFechaRendicion;
        private System.Windows.Forms.DateTimePicker dtRendicion;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cbPorcComision;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label labelTitRend;
        private System.Windows.Forms.Label labelImp;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Label labelTImp;
        private System.Windows.Forms.Label labelTCom;
        private System.Windows.Forms.Label labelTCant;
    }
}