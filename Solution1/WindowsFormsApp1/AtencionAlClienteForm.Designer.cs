
namespace WindowsFormsApp1
{
    partial class AtencionAlClienteForm
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
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.LvClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TbCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCliente.Location = new System.Drawing.Point(12, 51);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(100, 50);
            this.BtnAgregarCliente.TabIndex = 0;
            this.BtnAgregarCliente.Text = "Agregar clientes";
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // LvClientes
            // 
            this.LvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LvClientes.HideSelection = false;
            this.LvClientes.Location = new System.Drawing.Point(152, 51);
            this.LvClientes.Name = "LvClientes";
            this.LvClientes.Size = new System.Drawing.Size(422, 272);
            this.LvClientes.TabIndex = 2;
            this.LvClientes.UseCompatibleStateImageBehavior = false;
            this.LvClientes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cola de clientes";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Atendiendo Cliente";
            this.columnHeader2.Width = 120;
            // 
            // TbCliente
            // 
            this.TbCliente.Location = new System.Drawing.Point(12, 119);
            this.TbCliente.Name = "TbCliente";
            this.TbCliente.Size = new System.Drawing.Size(100, 20);
            this.TbCliente.TabIndex = 3;
            // 
            // AtencionAlClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(629, 350);
            this.Controls.Add(this.TbCliente);
            this.Controls.Add(this.LvClientes);
            this.Controls.Add(this.BtnAgregarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AtencionAlClienteForm";
            this.Text = "AtencionAlClienteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.ListView LvClientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox TbCliente;
    }
}