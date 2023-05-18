namespace CalcularQuadrado
{
    partial class FormQuadrado
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_calcular = new System.Windows.Forms.Label();
            this.lbl_resul = new System.Windows.Forms.Label();
            this.txBox_calcular = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(133, 47);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(515, 36);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Calculando o valor quadrado";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_calcular
            // 
            this.lbl_calcular.AutoSize = true;
            this.lbl_calcular.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_calcular.Location = new System.Drawing.Point(81, 99);
            this.lbl_calcular.Name = "lbl_calcular";
            this.lbl_calcular.Size = new System.Drawing.Size(149, 25);
            this.lbl_calcular.TabIndex = 1;
            this.lbl_calcular.Text = "Digite o número";
            // 
            // lbl_resul
            // 
            this.lbl_resul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_resul.Location = new System.Drawing.Point(81, 199);
            this.lbl_resul.Name = "lbl_resul";
            this.lbl_resul.Size = new System.Drawing.Size(688, 231);
            this.lbl_resul.TabIndex = 2;
            this.lbl_resul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txBox_calcular
            // 
            this.txBox_calcular.Location = new System.Drawing.Point(81, 140);
            this.txBox_calcular.Name = "txBox_calcular";
            this.txBox_calcular.Size = new System.Drawing.Size(335, 23);
            this.txBox_calcular.TabIndex = 3;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(422, 139);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(87, 24);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // FormQuadrado
            // 
            this.AcceptButton = this.btn_calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txBox_calcular);
            this.Controls.Add(this.lbl_resul);
            this.Controls.Add(this.lbl_calcular);
            this.Controls.Add(this.lbl_titulo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormQuadrado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Quadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_calcular;
        private Label lbl_resul;
        private TextBox txBox_calcular;
        private Button btn_calcular;
    }
}