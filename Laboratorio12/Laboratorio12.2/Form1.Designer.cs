namespace Laboratorio12._2
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
            this.btn_promedio = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txb_nota1 = new System.Windows.Forms.TextBox();
            this.txb_nota2 = new System.Windows.Forms.TextBox();
            this.txb_nota3 = new System.Windows.Forms.TextBox();
            this.lbl_nota1 = new System.Windows.Forms.Label();
            this.lbl_nota2 = new System.Windows.Forms.Label();
            this.lbl_nota3 = new System.Windows.Forms.Label();
            this.txb_promedio = new System.Windows.Forms.TextBox();
            this.lbl_promedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_promedio
            // 
            this.btn_promedio.Location = new System.Drawing.Point(73, 201);
            this.btn_promedio.Name = "btn_promedio";
            this.btn_promedio.Size = new System.Drawing.Size(75, 23);
            this.btn_promedio.TabIndex = 0;
            this.btn_promedio.Text = "Promedio";
            this.btn_promedio.UseVisualStyleBackColor = true;
            this.btn_promedio.Click += new System.EventHandler(this.btn_promedio_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(154, 201);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(235, 201);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(152, 32);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(90, 13);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Nota Promedio";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_nota1
            // 
            this.txb_nota1.Location = new System.Drawing.Point(210, 82);
            this.txb_nota1.Name = "txb_nota1";
            this.txb_nota1.Size = new System.Drawing.Size(100, 20);
            this.txb_nota1.TabIndex = 4;
            // 
            // txb_nota2
            // 
            this.txb_nota2.Location = new System.Drawing.Point(210, 124);
            this.txb_nota2.Name = "txb_nota2";
            this.txb_nota2.Size = new System.Drawing.Size(100, 20);
            this.txb_nota2.TabIndex = 5;
            // 
            // txb_nota3
            // 
            this.txb_nota3.Location = new System.Drawing.Point(210, 164);
            this.txb_nota3.Name = "txb_nota3";
            this.txb_nota3.Size = new System.Drawing.Size(100, 20);
            this.txb_nota3.TabIndex = 6;
            // 
            // lbl_nota1
            // 
            this.lbl_nota1.AutoSize = true;
            this.lbl_nota1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_nota1.Location = new System.Drawing.Point(82, 85);
            this.lbl_nota1.Name = "lbl_nota1";
            this.lbl_nota1.Size = new System.Drawing.Size(66, 13);
            this.lbl_nota1.TabIndex = 7;
            this.lbl_nota1.Text = "NOTA No. 1";
            this.lbl_nota1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_nota2
            // 
            this.lbl_nota2.AutoSize = true;
            this.lbl_nota2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_nota2.Location = new System.Drawing.Point(82, 127);
            this.lbl_nota2.Name = "lbl_nota2";
            this.lbl_nota2.Size = new System.Drawing.Size(66, 13);
            this.lbl_nota2.TabIndex = 8;
            this.lbl_nota2.Text = "NOTA No. 2";
            this.lbl_nota2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_nota3
            // 
            this.lbl_nota3.AutoSize = true;
            this.lbl_nota3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_nota3.Location = new System.Drawing.Point(82, 167);
            this.lbl_nota3.Name = "lbl_nota3";
            this.lbl_nota3.Size = new System.Drawing.Size(66, 13);
            this.lbl_nota3.TabIndex = 9;
            this.lbl_nota3.Text = "NOTA No. 3";
            this.lbl_nota3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_promedio
            // 
            this.txb_promedio.Location = new System.Drawing.Point(210, 249);
            this.txb_promedio.Name = "txb_promedio";
            this.txb_promedio.Size = new System.Drawing.Size(100, 20);
            this.txb_promedio.TabIndex = 10;
            // 
            // lbl_promedio
            // 
            this.lbl_promedio.AutoSize = true;
            this.lbl_promedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_promedio.Location = new System.Drawing.Point(82, 252);
            this.lbl_promedio.Name = "lbl_promedio";
            this.lbl_promedio.Size = new System.Drawing.Size(77, 13);
            this.lbl_promedio.TabIndex = 11;
            this.lbl_promedio.Text = "Nota Promedio";
            this.lbl_promedio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.lbl_promedio);
            this.Controls.Add(this.txb_promedio);
            this.Controls.Add(this.lbl_nota3);
            this.Controls.Add(this.lbl_nota2);
            this.Controls.Add(this.lbl_nota1);
            this.Controls.Add(this.txb_nota3);
            this.Controls.Add(this.txb_nota2);
            this.Controls.Add(this.txb_nota1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_promedio);
            this.Name = "Form1";
            this.Text = "Calcular Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_promedio;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txb_nota1;
        private System.Windows.Forms.TextBox txb_nota2;
        private System.Windows.Forms.TextBox txb_nota3;
        private System.Windows.Forms.Label lbl_nota1;
        private System.Windows.Forms.Label lbl_nota2;
        private System.Windows.Forms.Label lbl_nota3;
        private System.Windows.Forms.TextBox txb_promedio;
        private System.Windows.Forms.Label lbl_promedio;
    }
}

