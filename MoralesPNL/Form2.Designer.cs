namespace MoralesPNL
{
    partial class Form2
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
            this.NoPregunta = new System.Windows.Forms.Label();
            this.Pregunta = new System.Windows.Forms.Label();
            this.OpcionA = new System.Windows.Forms.RadioButton();
            this.OpcionB = new System.Windows.Forms.RadioButton();
            this.OpcionC = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoPregunta
            // 
            this.NoPregunta.AutoSize = true;
            this.NoPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoPregunta.Location = new System.Drawing.Point(42, 37);
            this.NoPregunta.Name = "NoPregunta";
            this.NoPregunta.Size = new System.Drawing.Size(167, 38);
            this.NoPregunta.TabIndex = 0;
            this.NoPregunta.Text = "Pregunta:";
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSize = true;
            this.Pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregunta.Location = new System.Drawing.Point(45, 101);
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.Size = new System.Drawing.Size(59, 20);
            this.Pregunta.TabIndex = 1;
            this.Pregunta.Text = "label2";
            // 
            // OpcionA
            // 
            this.OpcionA.AutoSize = true;
            this.OpcionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionA.Location = new System.Drawing.Point(92, 187);
            this.OpcionA.Name = "OpcionA";
            this.OpcionA.Size = new System.Drawing.Size(137, 24);
            this.OpcionA.TabIndex = 2;
            this.OpcionA.TabStop = true;
            this.OpcionA.Text = "radioButton1";
            this.OpcionA.UseVisualStyleBackColor = true;
            // 
            // OpcionB
            // 
            this.OpcionB.AutoSize = true;
            this.OpcionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionB.Location = new System.Drawing.Point(92, 265);
            this.OpcionB.Name = "OpcionB";
            this.OpcionB.Size = new System.Drawing.Size(137, 24);
            this.OpcionB.TabIndex = 3;
            this.OpcionB.TabStop = true;
            this.OpcionB.Text = "radioButton2";
            this.OpcionB.UseVisualStyleBackColor = true;
            // 
            // OpcionC
            // 
            this.OpcionC.AutoSize = true;
            this.OpcionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionC.Location = new System.Drawing.Point(92, 342);
            this.OpcionC.Name = "OpcionC";
            this.OpcionC.Size = new System.Drawing.Size(137, 24);
            this.OpcionC.TabIndex = 4;
            this.OpcionC.TabStop = true;
            this.OpcionC.Text = "radioButton3";
            this.OpcionC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "a)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "b)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "c)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpcionC);
            this.Controls.Add(this.OpcionB);
            this.Controls.Add(this.OpcionA);
            this.Controls.Add(this.Pregunta);
            this.Controls.Add(this.NoPregunta);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoPregunta;
        private System.Windows.Forms.Label Pregunta;
        private System.Windows.Forms.RadioButton OpcionA;
        private System.Windows.Forms.RadioButton OpcionB;
        private System.Windows.Forms.RadioButton OpcionC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}