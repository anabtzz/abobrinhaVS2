namespace abobrinha2._0
{
    partial class Form3
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
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.txtnumtab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrepita = new System.Windows.Forms.Button();
            this.btnpara = new System.Windows.Forms.Button();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(355, 109);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(22, 150);
            this.txtresultado.TabIndex = 8;
            // 
            // txtnumtab
            // 
            this.txtnumtab.Location = new System.Drawing.Point(343, 75);
            this.txtnumtab.Name = "txtnumtab";
            this.txtnumtab.Size = new System.Drawing.Size(53, 20);
            this.txtnumtab.TabIndex = 7;
            this.txtnumtab.TextChanged += new System.EventHandler(this.txtnumtab_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero:";
            // 
            // btnrepita
            // 
            this.btnrepita.Location = new System.Drawing.Point(455, 304);
            this.btnrepita.Name = "btnrepita";
            this.btnrepita.Size = new System.Drawing.Size(75, 23);
            this.btnrepita.TabIndex = 11;
            this.btnrepita.Text = "REPITA";
            this.btnrepita.UseVisualStyleBackColor = true;
            this.btnrepita.Click += new System.EventHandler(this.btnrepita_Click);
            // 
            // btnpara
            // 
            this.btnpara.Location = new System.Drawing.Point(355, 304);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(75, 23);
            this.btnpara.TabIndex = 10;
            this.btnpara.Text = "PARA";
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // btnenquanto
            // 
            this.btnenquanto.Location = new System.Drawing.Point(259, 304);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(78, 23);
            this.btnenquanto.TabIndex = 9;
            this.btnenquanto.Text = "ENQUANTO";
            this.btnenquanto.UseVisualStyleBackColor = true;
            this.btnenquanto.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnrepita);
            this.Controls.Add(this.btnpara);
            this.Controls.Add(this.btnenquanto);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnumtab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.TextBox txtnumtab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrepita;
        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}