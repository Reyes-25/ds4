namespace Laboratorio12._1
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
            this.b_veloc = new System.Windows.Forms.Button();
            this.b_limp = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_veloc = new System.Windows.Forms.Label();
            this.tb_veloc = new System.Windows.Forms.TextBox();
            this.lbl_tiemp = new System.Windows.Forms.Label();
            this.tb_tiemp = new System.Windows.Forms.TextBox();
            this.l_distan = new System.Windows.Forms.Label();
            this.tb_distan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_veloc
            // 
            this.b_veloc.Location = new System.Drawing.Point(58, 139);
            this.b_veloc.Name = "b_veloc";
            this.b_veloc.Size = new System.Drawing.Size(75, 23);
            this.b_veloc.TabIndex = 0;
            this.b_veloc.Text = "Calcular";
            this.b_veloc.UseVisualStyleBackColor = true;
            this.b_veloc.Click += new System.EventHandler(this.b_veloc_Click);
            // 
            // b_limp
            // 
            this.b_limp.Location = new System.Drawing.Point(139, 139);
            this.b_limp.Name = "b_limp";
            this.b_limp.Size = new System.Drawing.Size(75, 23);
            this.b_limp.TabIndex = 1;
            this.b_limp.Text = "Limpiar";
            this.b_limp.UseVisualStyleBackColor = true;
            this.b_limp.Click += new System.EventHandler(this.b_limp_Click);
            // 
            // b_salir
            // 
            this.b_salir.Location = new System.Drawing.Point(220, 139);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(75, 23);
            this.b_salir.TabIndex = 2;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velocidad de un Móvil";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_veloc
            // 
            this.lbl_veloc.AutoSize = true;
            this.lbl_veloc.Location = new System.Drawing.Point(65, 68);
            this.lbl_veloc.Name = "lbl_veloc";
            this.lbl_veloc.Size = new System.Drawing.Size(54, 13);
            this.lbl_veloc.TabIndex = 4;
            this.lbl_veloc.Text = "Velocidad";
            // 
            // tb_veloc
            // 
            this.tb_veloc.Location = new System.Drawing.Point(195, 65);
            this.tb_veloc.Name = "tb_veloc";
            this.tb_veloc.Size = new System.Drawing.Size(100, 20);
            this.tb_veloc.TabIndex = 5;
            // 
            // lbl_tiemp
            // 
            this.lbl_tiemp.AutoSize = true;
            this.lbl_tiemp.Location = new System.Drawing.Point(65, 104);
            this.lbl_tiemp.Name = "lbl_tiemp";
            this.lbl_tiemp.Size = new System.Drawing.Size(70, 13);
            this.lbl_tiemp.TabIndex = 6;
            this.lbl_tiemp.Text = "Tiempo (Uso)";
            // 
            // tb_tiemp
            // 
            this.tb_tiemp.Location = new System.Drawing.Point(195, 101);
            this.tb_tiemp.Name = "tb_tiemp";
            this.tb_tiemp.Size = new System.Drawing.Size(100, 20);
            this.tb_tiemp.TabIndex = 7;
            // 
            // l_distan
            // 
            this.l_distan.AutoSize = true;
            this.l_distan.Location = new System.Drawing.Point(65, 184);
            this.l_distan.Name = "l_distan";
            this.l_distan.Size = new System.Drawing.Size(100, 13);
            this.l_distan.TabIndex = 8;
            this.l_distan.Text = "Distancia Recorrida";
            // 
            // tb_distan
            // 
            this.tb_distan.Location = new System.Drawing.Point(195, 181);
            this.tb_distan.Name = "tb_distan";
            this.tb_distan.Size = new System.Drawing.Size(100, 20);
            this.tb_distan.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.tb_distan);
            this.Controls.Add(this.l_distan);
            this.Controls.Add(this.tb_tiemp);
            this.Controls.Add(this.lbl_tiemp);
            this.Controls.Add(this.tb_veloc);
            this.Controls.Add(this.lbl_veloc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_limp);
            this.Controls.Add(this.b_veloc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_veloc;
        private System.Windows.Forms.Button b_limp;
        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_veloc;
        private System.Windows.Forms.TextBox tb_veloc;
        private System.Windows.Forms.Label lbl_tiemp;
        private System.Windows.Forms.TextBox tb_tiemp;
        private System.Windows.Forms.Label l_distan;
        private System.Windows.Forms.TextBox tb_distan;
    }
}

