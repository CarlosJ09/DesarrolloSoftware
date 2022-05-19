namespace Deducciones_Intec
{
    partial class Deducciones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_AFP = new System.Windows.Forms.TextBox();
            this.txt_ISR = new System.Windows.Forms.TextBox();
            this.txt_SFS = new System.Windows.Forms.TextBox();
            this.txt_SueldoN = new System.Windows.Forms.TextBox();
            this.txt_SueldoB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_DiaHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_AFP
            // 
            this.txt_AFP.Enabled = false;
            this.txt_AFP.Location = new System.Drawing.Point(460, 139);
            this.txt_AFP.Name = "txt_AFP";
            this.txt_AFP.Size = new System.Drawing.Size(100, 23);
            this.txt_AFP.TabIndex = 0;
            // 
            // txt_ISR
            // 
            this.txt_ISR.Enabled = false;
            this.txt_ISR.Location = new System.Drawing.Point(460, 237);
            this.txt_ISR.Name = "txt_ISR";
            this.txt_ISR.Size = new System.Drawing.Size(100, 23);
            this.txt_ISR.TabIndex = 1;
            this.txt_ISR.TextChanged += new System.EventHandler(this.txt_ISR_TextChanged);
            // 
            // txt_SFS
            // 
            this.txt_SFS.Enabled = false;
            this.txt_SFS.Location = new System.Drawing.Point(460, 188);
            this.txt_SFS.Name = "txt_SFS";
            this.txt_SFS.Size = new System.Drawing.Size(100, 23);
            this.txt_SFS.TabIndex = 3;
            // 
            // txt_SueldoN
            // 
            this.txt_SueldoN.Enabled = false;
            this.txt_SueldoN.Location = new System.Drawing.Point(183, 238);
            this.txt_SueldoN.Name = "txt_SueldoN";
            this.txt_SueldoN.Size = new System.Drawing.Size(100, 23);
            this.txt_SueldoN.TabIndex = 4;
            // 
            // txt_SueldoB
            // 
            this.txt_SueldoB.Location = new System.Drawing.Point(183, 188);
            this.txt_SueldoB.Name = "txt_SueldoB";
            this.txt_SueldoB.Size = new System.Drawing.Size(100, 23);
            this.txt_SueldoB.TabIndex = 5;
            this.txt_SueldoB.TextChanged += new System.EventHandler(this.txt_SueldoB_TextChanged);
            this.txt_SueldoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SueldoB_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(231, 297);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(175, 58);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(212, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistema Saldo";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sueldo Neto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sueldo Bruto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(388, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "ISR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(388, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "SFS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(388, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "AFP: ";
            // 
            // lbl_DiaHora
            // 
            this.lbl_DiaHora.AutoSize = true;
            this.lbl_DiaHora.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DiaHora.Location = new System.Drawing.Point(49, 143);
            this.lbl_DiaHora.Name = "lbl_DiaHora";
            this.lbl_DiaHora.Size = new System.Drawing.Size(67, 13);
            this.lbl_DiaHora.TabIndex = 14;
            this.lbl_DiaHora.Text = "Hora/Fecha";
            // 
            // Deducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 379);
            this.Controls.Add(this.lbl_DiaHora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txt_SueldoB);
            this.Controls.Add(this.txt_SueldoN);
            this.Controls.Add(this.txt_SFS);
            this.Controls.Add(this.txt_ISR);
            this.Controls.Add(this.txt_AFP);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Deducciones";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Deducciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_AFP;
        private TextBox txt_ISR;
        private TextBox txt_SFS;
        private TextBox txt_SueldoN;
        private TextBox txt_SueldoB;
        private Button btnCalcular;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbl_DiaHora;
    }
}