namespace Calcular_frete.View
{
    partial class FormFrete
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
            this.lbl_result = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cBuf = new System.Windows.Forms.ComboBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(245, 253);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 15);
            this.lbl_result.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 23);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Nome";
            // 
            // cBuf
            // 
            this.cBuf.DisplayMember = "SP";
            this.cBuf.FormattingEnabled = true;
            this.cBuf.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "BA",
            "PE",
            "PA",
            "RS",
            "MG"});
            this.cBuf.Location = new System.Drawing.Point(434, 194);
            this.cBuf.Name = "cBuf";
            this.cBuf.Size = new System.Drawing.Size(121, 23);
            this.cBuf.TabIndex = 7;
            this.cBuf.Tag = "";
            this.cBuf.Text = "UF";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(245, 194);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 23);
            this.txt_Valor.TabIndex = 6;
            this.txt_Valor.Text = "Valor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cBuf);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.button1);
            this.Name = "FormFrete";
            this.Text = "FormFrete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_result;
        private TextBox textBox2;
        private ComboBox cBuf;
        private TextBox txt_Valor;
        private Button button1;
    }
}