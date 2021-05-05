
namespace WindowsFormsApp1
{
    partial class AgendaTelefonicaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LbAgenda = new System.Windows.Forms.ListBox();
            this.TbTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMostrarTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(24, 51);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(100, 20);
            this.TbNombre.TabIndex = 1;
            // 
            // LbAgenda
            // 
            this.LbAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAgenda.ForeColor = System.Drawing.Color.Red;
            this.LbAgenda.FormattingEnabled = true;
            this.LbAgenda.ItemHeight = 20;
            this.LbAgenda.Location = new System.Drawing.Point(160, 19);
            this.LbAgenda.Name = "LbAgenda";
            this.LbAgenda.Size = new System.Drawing.Size(120, 224);
            this.LbAgenda.TabIndex = 2;
            this.LbAgenda.SelectedIndexChanged += new System.EventHandler(this.LbAgenda_SelectedIndexChanged);
            // 
            // TbTel
            // 
            this.TbTel.Location = new System.Drawing.Point(24, 113);
            this.TbTel.Name = "TbTel";
            this.TbTel.Size = new System.Drawing.Size(100, 20);
            this.TbTel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefono";
            // 
            // tbMostrarTel
            // 
            this.tbMostrarTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMostrarTel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbMostrarTel.Location = new System.Drawing.Point(331, 113);
            this.tbMostrarTel.Name = "tbMostrarTel";
            this.tbMostrarTel.ReadOnly = true;
            this.tbMostrarTel.Size = new System.Drawing.Size(100, 24);
            this.tbMostrarTel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(340, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "telefono";
            // 
            // AgendaTelefonicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(512, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMostrarTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbTel);
            this.Controls.Add(this.LbAgenda);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaTelefonicaForm";
            this.Text = "AgendaTelefonicaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.ListBox LbAgenda;
        private System.Windows.Forms.TextBox TbTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMostrarTel;
        private System.Windows.Forms.Label label3;
    }
}