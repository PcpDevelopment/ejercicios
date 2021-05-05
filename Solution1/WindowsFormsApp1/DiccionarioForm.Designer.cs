
namespace WindowsFormsApp1
{
    partial class DiccionarioForm
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
            this.Lbdic = new System.Windows.Forms.ListBox();
            this.TBdef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbdic
            // 
            this.Lbdic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbdic.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Lbdic.FormattingEnabled = true;
            this.Lbdic.ItemHeight = 20;
            this.Lbdic.Location = new System.Drawing.Point(12, 39);
            this.Lbdic.Name = "Lbdic";
            this.Lbdic.Size = new System.Drawing.Size(118, 204);
            this.Lbdic.TabIndex = 0;
            this.Lbdic.SelectedIndexChanged += new System.EventHandler(this.Lbdic_SelectedIndexChanged);
            // 
            // TBdef
            // 
            this.TBdef.Enabled = false;
            this.TBdef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdef.Location = new System.Drawing.Point(136, 39);
            this.TBdef.Multiline = true;
            this.TBdef.Name = "TBdef";
            this.TBdef.Size = new System.Drawing.Size(350, 204);
            this.TBdef.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Definicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Palabras";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DiccionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(509, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBdef);
            this.Controls.Add(this.Lbdic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiccionarioForm";
            this.Text = "Diccionario";
            this.Load += new System.EventHandler(this.DiccionarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lbdic;
        private System.Windows.Forms.TextBox TBdef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}