﻿
namespace WindowsFormsApp1
{
    partial class SalonDeClasesForm
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
            this.listVEstud = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarEstudiantes = new System.Windows.Forms.Button();
            this.txtEstud = new System.Windows.Forms.TextBox();
            this.txtNotasEst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "promedio";
            // 
            // listVEstud
            // 
            this.listVEstud.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listVEstud.HideSelection = false;
            this.listVEstud.Location = new System.Drawing.Point(118, 15);
            this.listVEstud.Name = "listVEstud";
            this.listVEstud.Size = new System.Drawing.Size(444, 246);
            this.listVEstud.TabIndex = 1;
            this.listVEstud.UseCompatibleStateImageBehavior = false;
            this.listVEstud.View = System.Windows.Forms.View.Details;
            this.listVEstud.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listVEstud_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOMBRE";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOTAS";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ordenar▲";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ordenar▼";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // btnAgregarEstudiantes
            // 
            this.btnAgregarEstudiantes.Location = new System.Drawing.Point(12, 153);
            this.btnAgregarEstudiantes.Name = "btnAgregarEstudiantes";
            this.btnAgregarEstudiantes.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEstudiantes.TabIndex = 2;
            this.btnAgregarEstudiantes.Text = "agregar";
            this.btnAgregarEstudiantes.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiantes.Click += new System.EventHandler(this.btnAgregarEstudiantes_Click);
            // 
            // txtEstud
            // 
            this.txtEstud.Location = new System.Drawing.Point(3, 65);
            this.txtEstud.Name = "txtEstud";
            this.txtEstud.Size = new System.Drawing.Size(100, 20);
            this.txtEstud.TabIndex = 3;
            // 
            // txtNotasEst
            // 
            this.txtNotasEst.Location = new System.Drawing.Point(3, 104);
            this.txtNotasEst.Name = "txtNotasEst";
            this.txtNotasEst.Size = new System.Drawing.Size(100, 20);
            this.txtNotasEst.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notas";
            // 
            // SalonDeClasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(574, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotasEst);
            this.Controls.Add(this.txtEstud);
            this.Controls.Add(this.btnAgregarEstudiantes);
            this.Controls.Add(this.listVEstud);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalonDeClasesForm";
            this.Text = "SalonDeClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listVEstud;
        private System.Windows.Forms.Button btnAgregarEstudiantes;
        private System.Windows.Forms.TextBox txtEstud;
        private System.Windows.Forms.TextBox txtNotasEst;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}