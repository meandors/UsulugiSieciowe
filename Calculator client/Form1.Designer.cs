namespace Calculator_client
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.Standartowych = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bMultiComplex = new System.Windows.Forms.Button();
            this.tbAReal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bDivComplex = new System.Windows.Forms.Button();
            this.bAddComplex = new System.Windows.Forms.Button();
            this.bSubComplex = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResultComplex = new System.Windows.Forms.TextBox();
            this.tbAImagine = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBReal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBImagine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Standartowych.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wynik:";
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbResult.Location = new System.Drawing.Point(70, 170);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 23);
            this.tbResult.TabIndex = 3;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbA.Location = new System.Drawing.Point(26, 6);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 23);
            this.tbA.TabIndex = 4;
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbB.Location = new System.Drawing.Point(152, 6);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 23);
            this.tbB.TabIndex = 5;
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.Location = new System.Drawing.Point(39, 52);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(60, 40);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSub
            // 
            this.bSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSub.Location = new System.Drawing.Point(162, 52);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(60, 40);
            this.bSub.TabIndex = 7;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // bMulti
            // 
            this.bMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMulti.Location = new System.Drawing.Point(39, 98);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(60, 40);
            this.bMulti.TabIndex = 8;
            this.bMulti.Text = "*";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDiv.Location = new System.Drawing.Point(162, 98);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(60, 40);
            this.bDiv.TabIndex = 9;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // Standartowych
            // 
            this.Standartowych.Controls.Add(this.tabPage1);
            this.Standartowych.Controls.Add(this.tabPage2);
            this.Standartowych.Location = new System.Drawing.Point(12, 12);
            this.Standartowych.Name = "Standartowych";
            this.Standartowych.SelectedIndex = 0;
            this.Standartowych.Size = new System.Drawing.Size(347, 244);
            this.Standartowych.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bMulti);
            this.tabPage1.Controls.Add(this.tbA);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bDiv);
            this.tabPage1.Controls.Add(this.bAdd);
            this.tabPage1.Controls.Add(this.bSub);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbResult);
            this.tabPage1.Controls.Add(this.tbB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standartowych";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbBReal);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbBImagine);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.bMultiComplex);
            this.tabPage2.Controls.Add(this.tbAReal);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bDivComplex);
            this.tabPage2.Controls.Add(this.bAddComplex);
            this.tabPage2.Controls.Add(this.bSubComplex);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbResultComplex);
            this.tabPage2.Controls.Add(this.tbAImagine);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(339, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zespolonych";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bMultiComplex
            // 
            this.bMultiComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMultiComplex.Location = new System.Drawing.Point(44, 143);
            this.bMultiComplex.Name = "bMultiComplex";
            this.bMultiComplex.Size = new System.Drawing.Size(60, 40);
            this.bMultiComplex.TabIndex = 18;
            this.bMultiComplex.Text = "*";
            this.bMultiComplex.UseVisualStyleBackColor = true;
            this.bMultiComplex.Click += new System.EventHandler(this.bMultiComplex_Click);
            // 
            // tbAReal
            // 
            this.tbAReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAReal.Location = new System.Drawing.Point(25, 30);
            this.tbAReal.Name = "tbAReal";
            this.tbAReal.Size = new System.Drawing.Size(100, 23);
            this.tbAReal.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Wynik:";
            // 
            // bDivComplex
            // 
            this.bDivComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDivComplex.Location = new System.Drawing.Point(167, 143);
            this.bDivComplex.Name = "bDivComplex";
            this.bDivComplex.Size = new System.Drawing.Size(60, 40);
            this.bDivComplex.TabIndex = 19;
            this.bDivComplex.Text = "/";
            this.bDivComplex.UseVisualStyleBackColor = true;
            this.bDivComplex.Click += new System.EventHandler(this.bDivComplex_Click);
            // 
            // bAddComplex
            // 
            this.bAddComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddComplex.Location = new System.Drawing.Point(44, 97);
            this.bAddComplex.Name = "bAddComplex";
            this.bAddComplex.Size = new System.Drawing.Size(60, 40);
            this.bAddComplex.TabIndex = 16;
            this.bAddComplex.Text = "+";
            this.bAddComplex.UseVisualStyleBackColor = true;
            this.bAddComplex.Click += new System.EventHandler(this.bAddComplex_Click);
            // 
            // bSubComplex
            // 
            this.bSubComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSubComplex.Location = new System.Drawing.Point(167, 97);
            this.bSubComplex.Name = "bSubComplex";
            this.bSubComplex.Size = new System.Drawing.Size(60, 40);
            this.bSubComplex.TabIndex = 17;
            this.bSubComplex.Text = "-";
            this.bSubComplex.UseVisualStyleBackColor = true;
            this.bSubComplex.Click += new System.EventHandler(this.bSubComplex_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "A";
            // 
            // tbResultComplex
            // 
            this.tbResultComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbResultComplex.Location = new System.Drawing.Point(70, 189);
            this.tbResultComplex.Name = "tbResultComplex";
            this.tbResultComplex.Size = new System.Drawing.Size(100, 23);
            this.tbResultComplex.TabIndex = 13;
            // 
            // tbAImagine
            // 
            this.tbAImagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAImagine.Location = new System.Drawing.Point(151, 30);
            this.tbAImagine.Name = "tbAImagine";
            this.tbAImagine.Size = new System.Drawing.Size(100, 23);
            this.tbAImagine.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(131, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "B";
            // 
            // tbBReal
            // 
            this.tbBReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBReal.Location = new System.Drawing.Point(25, 64);
            this.tbBReal.Name = "tbBReal";
            this.tbBReal.Size = new System.Drawing.Size(100, 23);
            this.tbBReal.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(7, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "A";
            // 
            // tbBImagine
            // 
            this.tbBImagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBImagine.Location = new System.Drawing.Point(151, 64);
            this.tbBImagine.Name = "tbBImagine";
            this.tbBImagine.Size = new System.Drawing.Size(100, 23);
            this.tbBImagine.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(131, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(52, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Real";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(164, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Imagine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 259);
            this.Controls.Add(this.Standartowych);
            this.Name = "Form1";
            this.Text = "Calculator Client";
            this.Standartowych.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.TabControl Standartowych;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bMultiComplex;
        private System.Windows.Forms.TextBox tbAReal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bDivComplex;
        private System.Windows.Forms.Button bAddComplex;
        private System.Windows.Forms.Button bSubComplex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResultComplex;
        private System.Windows.Forms.TextBox tbAImagine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBReal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBImagine;
        private System.Windows.Forms.Label label8;
    }
}

