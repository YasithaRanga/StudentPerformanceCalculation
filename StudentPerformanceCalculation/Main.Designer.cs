
namespace StudentPerformanceCalculation
{
    partial class Main
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
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.lblMarks = new Guna.UI.WinForms.GunaLabel();
            this.lblModule1 = new Guna.UI.WinForms.GunaLabel();
            this.lblModule2 = new Guna.UI.WinForms.GunaLabel();
            this.lblModule3 = new Guna.UI.WinForms.GunaLabel();
            this.lblModule4 = new Guna.UI.WinForms.GunaLabel();
            this.lblModule5 = new Guna.UI.WinForms.GunaLabel();
            this.txtModule1 = new Guna.UI.WinForms.GunaTextBox();
            this.txtModule2 = new Guna.UI.WinForms.GunaTextBox();
            this.txtModule3 = new Guna.UI.WinForms.GunaTextBox();
            this.txtModule4 = new Guna.UI.WinForms.GunaTextBox();
            this.txtModule5 = new Guna.UI.WinForms.GunaTextBox();
            this.btnCalculate = new Guna.UI.WinForms.GunaButton();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.lblAvg = new Guna.UI.WinForms.GunaLabel();
            this.lblShowAvg = new Guna.UI.WinForms.GunaLabel();
            this.lblClass = new Guna.UI.WinForms.GunaLabel();
            this.lblShowClass = new Guna.UI.WinForms.GunaLabel();
            this.lblTotal = new Guna.UI.WinForms.GunaLabel();
            this.lblShowTotal = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(122, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(427, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Performance Calculator";
            this.lblTitle.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(124, 91);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(96, 37);
            this.lblMarks.TabIndex = 1;
            this.lblMarks.Text = "Marks";
            this.lblMarks.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // lblModule1
            // 
            this.lblModule1.AutoSize = true;
            this.lblModule1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblModule1.Location = new System.Drawing.Point(64, 145);
            this.lblModule1.Name = "lblModule1";
            this.lblModule1.Size = new System.Drawing.Size(131, 32);
            this.lblModule1.TabIndex = 2;
            this.lblModule1.Text = "Module 01";
            this.lblModule1.Click += new System.EventHandler(this.lblModule1_Click);
            // 
            // lblModule2
            // 
            this.lblModule2.AutoSize = true;
            this.lblModule2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblModule2.Location = new System.Drawing.Point(64, 202);
            this.lblModule2.Name = "lblModule2";
            this.lblModule2.Size = new System.Drawing.Size(131, 32);
            this.lblModule2.TabIndex = 3;
            this.lblModule2.Text = "Module 02";
            // 
            // lblModule3
            // 
            this.lblModule3.AutoSize = true;
            this.lblModule3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblModule3.Location = new System.Drawing.Point(64, 259);
            this.lblModule3.Name = "lblModule3";
            this.lblModule3.Size = new System.Drawing.Size(131, 32);
            this.lblModule3.TabIndex = 4;
            this.lblModule3.Text = "Module 03";
            // 
            // lblModule4
            // 
            this.lblModule4.AutoSize = true;
            this.lblModule4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblModule4.Location = new System.Drawing.Point(64, 316);
            this.lblModule4.Name = "lblModule4";
            this.lblModule4.Size = new System.Drawing.Size(131, 32);
            this.lblModule4.TabIndex = 4;
            this.lblModule4.Text = "Module 04";
            // 
            // lblModule5
            // 
            this.lblModule5.AutoSize = true;
            this.lblModule5.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblModule5.Location = new System.Drawing.Point(64, 373);
            this.lblModule5.Name = "lblModule5";
            this.lblModule5.Size = new System.Drawing.Size(131, 32);
            this.lblModule5.TabIndex = 4;
            this.lblModule5.Text = "Module 05";
            // 
            // txtModule1
            // 
            this.txtModule1.BaseColor = System.Drawing.Color.White;
            this.txtModule1.BorderColor = System.Drawing.Color.Silver;
            this.txtModule1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModule1.FocusedBaseColor = System.Drawing.Color.White;
            this.txtModule1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtModule1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtModule1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtModule1.Location = new System.Drawing.Point(219, 143);
            this.txtModule1.Name = "txtModule1";
            this.txtModule1.PasswordChar = '\0';
            this.txtModule1.SelectedText = "";
            this.txtModule1.Size = new System.Drawing.Size(77, 39);
            this.txtModule1.TabIndex = 5;
            this.txtModule1.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // txtModule2
            // 
            this.txtModule2.BaseColor = System.Drawing.Color.White;
            this.txtModule2.BorderColor = System.Drawing.Color.Silver;
            this.txtModule2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModule2.FocusedBaseColor = System.Drawing.Color.White;
            this.txtModule2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtModule2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtModule2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtModule2.Location = new System.Drawing.Point(219, 200);
            this.txtModule2.Name = "txtModule2";
            this.txtModule2.PasswordChar = '\0';
            this.txtModule2.SelectedText = "";
            this.txtModule2.Size = new System.Drawing.Size(77, 39);
            this.txtModule2.TabIndex = 5;
            // 
            // txtModule3
            // 
            this.txtModule3.BaseColor = System.Drawing.Color.White;
            this.txtModule3.BorderColor = System.Drawing.Color.Silver;
            this.txtModule3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModule3.FocusedBaseColor = System.Drawing.Color.White;
            this.txtModule3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtModule3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtModule3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtModule3.Location = new System.Drawing.Point(219, 257);
            this.txtModule3.Name = "txtModule3";
            this.txtModule3.PasswordChar = '\0';
            this.txtModule3.SelectedText = "";
            this.txtModule3.Size = new System.Drawing.Size(77, 39);
            this.txtModule3.TabIndex = 5;
            // 
            // txtModule4
            // 
            this.txtModule4.BaseColor = System.Drawing.Color.White;
            this.txtModule4.BorderColor = System.Drawing.Color.Silver;
            this.txtModule4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModule4.FocusedBaseColor = System.Drawing.Color.White;
            this.txtModule4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtModule4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtModule4.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtModule4.Location = new System.Drawing.Point(219, 314);
            this.txtModule4.Name = "txtModule4";
            this.txtModule4.PasswordChar = '\0';
            this.txtModule4.SelectedText = "";
            this.txtModule4.Size = new System.Drawing.Size(77, 39);
            this.txtModule4.TabIndex = 5;
            // 
            // txtModule5
            // 
            this.txtModule5.BaseColor = System.Drawing.Color.White;
            this.txtModule5.BorderColor = System.Drawing.Color.Silver;
            this.txtModule5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModule5.FocusedBaseColor = System.Drawing.Color.White;
            this.txtModule5.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtModule5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtModule5.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtModule5.Location = new System.Drawing.Point(219, 371);
            this.txtModule5.Name = "txtModule5";
            this.txtModule5.PasswordChar = '\0';
            this.txtModule5.SelectedText = "";
            this.txtModule5.Size = new System.Drawing.Size(77, 39);
            this.txtModule5.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AnimationHoverSpeed = 0.07F;
            this.btnCalculate.AnimationSpeed = 0.03F;
            this.btnCalculate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCalculate.BorderColor = System.Drawing.Color.Black;
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCalculate.FocusedColor = System.Drawing.Color.Empty;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Image = null;
            this.btnCalculate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCalculate.Location = new System.Drawing.Point(450, 173);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCalculate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCalculate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCalculate.OnHoverImage = null;
            this.btnCalculate.OnPressedColor = System.Drawing.Color.Black;
            this.btnCalculate.Size = new System.Drawing.Size(191, 66);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = null;
            this.btnReset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset.Location = new System.Drawing.Point(450, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Size = new System.Drawing.Size(191, 66);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblAvg.Location = new System.Drawing.Point(64, 547);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(291, 32);
            this.lblAvg.TabIndex = 7;
            this.lblAvg.Text = "Average of the Semester: ";
            this.lblAvg.Click += new System.EventHandler(this.gunaLabel1_Click_1);
            // 
            // lblShowAvg
            // 
            this.lblShowAvg.AutoSize = true;
            this.lblShowAvg.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblShowAvg.Location = new System.Drawing.Point(361, 547);
            this.lblShowAvg.Name = "lblShowAvg";
            this.lblShowAvg.Size = new System.Drawing.Size(0, 32);
            this.lblShowAvg.TabIndex = 7;
            this.lblShowAvg.Click += new System.EventHandler(this.gunaLabel1_Click_1);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblClass.Location = new System.Drawing.Point(64, 503);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(257, 32);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Class of the Semester: ";
            this.lblClass.Click += new System.EventHandler(this.gunaLabel1_Click_1);
            // 
            // lblShowClass
            // 
            this.lblShowClass.AutoSize = true;
            this.lblShowClass.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblShowClass.Location = new System.Drawing.Point(361, 503);
            this.lblShowClass.Name = "lblShowClass";
            this.lblShowClass.Size = new System.Drawing.Size(0, 32);
            this.lblShowClass.TabIndex = 7;
            this.lblShowClass.Click += new System.EventHandler(this.gunaLabel1_Click_1);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTotal.Location = new System.Drawing.Point(64, 459);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(255, 32);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total of the Semester: ";
            this.lblTotal.Click += new System.EventHandler(this.gunaLabel1_Click_1);
            // 
            // lblShowTotal
            // 
            this.lblShowTotal.AutoSize = true;
            this.lblShowTotal.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblShowTotal.Location = new System.Drawing.Point(361, 459);
            this.lblShowTotal.Name = "lblShowTotal";
            this.lblShowTotal.Size = new System.Drawing.Size(0, 32);
            this.lblShowTotal.TabIndex = 7;
            this.lblShowTotal.Click += new System.EventHandler(this.gunaLabel1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 614);
            this.Controls.Add(this.lblShowTotal);
            this.Controls.Add(this.lblShowClass);
            this.Controls.Add(this.lblShowAvg);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtModule5);
            this.Controls.Add(this.txtModule4);
            this.Controls.Add(this.txtModule3);
            this.Controls.Add(this.txtModule2);
            this.Controls.Add(this.txtModule1);
            this.Controls.Add(this.lblModule5);
            this.Controls.Add(this.lblModule4);
            this.Controls.Add(this.lblModule3);
            this.Controls.Add(this.lblModule2);
            this.Controls.Add(this.lblModule1);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblTitle);
            this.Name = "Main";
            this.Text = "Student Performance Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaLabel lblMarks;
        private Guna.UI.WinForms.GunaLabel lblModule1;
        private Guna.UI.WinForms.GunaLabel lblModule2;
        private Guna.UI.WinForms.GunaLabel lblModule3;
        private Guna.UI.WinForms.GunaLabel lblModule4;
        private Guna.UI.WinForms.GunaLabel lblModule5;
        private Guna.UI.WinForms.GunaTextBox txtModule1;
        private Guna.UI.WinForms.GunaTextBox txtModule2;
        private Guna.UI.WinForms.GunaTextBox txtModule3;
        private Guna.UI.WinForms.GunaTextBox txtModule4;
        private Guna.UI.WinForms.GunaTextBox txtModule5;
        private Guna.UI.WinForms.GunaButton btnCalculate;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaLabel lblAvg;
        private Guna.UI.WinForms.GunaLabel lblShowAvg;
        private Guna.UI.WinForms.GunaLabel lblClass;
        private Guna.UI.WinForms.GunaLabel lblShowClass;
        private Guna.UI.WinForms.GunaLabel lblTotal;
        private Guna.UI.WinForms.GunaLabel lblShowTotal;
    }
}

