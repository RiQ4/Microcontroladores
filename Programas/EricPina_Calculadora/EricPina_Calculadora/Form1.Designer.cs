namespace EricPina_Calculadora
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
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.num6Btn = new System.Windows.Forms.Button();
            this.num5Btn = new System.Windows.Forms.Button();
            this.num4Btn = new System.Windows.Forms.Button();
            this.num9Btn = new System.Windows.Forms.Button();
            this.num8Btn = new System.Windows.Forms.Button();
            this.num7Btn = new System.Windows.Forms.Button();
            this.num0Btn = new System.Windows.Forms.Button();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.signBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.clearEBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.num1Btn = new System.Windows.Forms.Button();
            this.num2Btn = new System.Windows.Forms.Button();
            this.num3Btn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.sqrBtn = new System.Windows.Forms.Button();
            this.powBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(12, 12);
            this.ResultBox.MaxLength = 18;
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(345, 51);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.Text = "0";
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ResultBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num6Btn
            // 
            this.num6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6Btn.Location = new System.Drawing.Point(144, 213);
            this.num6Btn.Name = "num6Btn";
            this.num6Btn.Size = new System.Drawing.Size(60, 60);
            this.num6Btn.TabIndex = 6;
            this.num6Btn.Text = "6";
            this.num6Btn.UseVisualStyleBackColor = true;
            this.num6Btn.Click += new System.EventHandler(this.addNum);
            // 
            // num5Btn
            // 
            this.num5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5Btn.Location = new System.Drawing.Point(78, 213);
            this.num5Btn.Name = "num5Btn";
            this.num5Btn.Size = new System.Drawing.Size(60, 60);
            this.num5Btn.TabIndex = 5;
            this.num5Btn.Text = "5";
            this.num5Btn.UseVisualStyleBackColor = true;
            this.num5Btn.Click += new System.EventHandler(this.addNum);
            // 
            // num4Btn
            // 
            this.num4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4Btn.Location = new System.Drawing.Point(12, 213);
            this.num4Btn.Name = "num4Btn";
            this.num4Btn.Size = new System.Drawing.Size(60, 60);
            this.num4Btn.TabIndex = 4;
            this.num4Btn.Text = "4";
            this.num4Btn.UseVisualStyleBackColor = true;
            this.num4Btn.Click += new System.EventHandler(this.addNum);
            // 
            // num9Btn
            // 
            this.num9Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9Btn.Location = new System.Drawing.Point(144, 147);
            this.num9Btn.Name = "num9Btn";
            this.num9Btn.Size = new System.Drawing.Size(60, 60);
            this.num9Btn.TabIndex = 9;
            this.num9Btn.Text = "9";
            this.num9Btn.UseVisualStyleBackColor = true;
            this.num9Btn.Click += new System.EventHandler(this.addNum);
            // 
            // num8Btn
            // 
            this.num8Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8Btn.Location = new System.Drawing.Point(78, 147);
            this.num8Btn.Name = "num8Btn";
            this.num8Btn.Size = new System.Drawing.Size(60, 60);
            this.num8Btn.TabIndex = 8;
            this.num8Btn.Text = "8";
            this.num8Btn.UseVisualStyleBackColor = true;
            this.num8Btn.Click += new System.EventHandler(this.addNum);
            // 
            // num7Btn
            // 
            this.num7Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7Btn.Location = new System.Drawing.Point(12, 147);
            this.num7Btn.Name = "num7Btn";
            this.num7Btn.Size = new System.Drawing.Size(60, 60);
            this.num7Btn.TabIndex = 7;
            this.num7Btn.Text = "7";
            this.num7Btn.UseVisualStyleBackColor = true;
            this.num7Btn.Click += new System.EventHandler(this.addNum);
            // 
            // num0Btn
            // 
            this.num0Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0Btn.Location = new System.Drawing.Point(78, 345);
            this.num0Btn.Name = "num0Btn";
            this.num0Btn.Size = new System.Drawing.Size(60, 60);
            this.num0Btn.TabIndex = 10;
            this.num0Btn.Text = "0";
            this.num0Btn.UseVisualStyleBackColor = true;
            this.num0Btn.Click += new System.EventHandler(this.addNum);
            // 
            // decimalBtn
            // 
            this.decimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalBtn.Location = new System.Drawing.Point(144, 345);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(60, 60);
            this.decimalBtn.TabIndex = 11;
            this.decimalBtn.Text = ".";
            this.decimalBtn.UseVisualStyleBackColor = true;
            this.decimalBtn.Click += new System.EventHandler(this.decimalBtn_Click);
            // 
            // signBtn
            // 
            this.signBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signBtn.Location = new System.Drawing.Point(12, 345);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(60, 60);
            this.signBtn.TabIndex = 12;
            this.signBtn.Text = "+/-";
            this.signBtn.UseVisualStyleBackColor = true;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(78, 81);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(60, 60);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // clearEBtn
            // 
            this.clearEBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEBtn.Location = new System.Drawing.Point(12, 81);
            this.clearEBtn.Name = "clearEBtn";
            this.clearEBtn.Size = new System.Drawing.Size(60, 60);
            this.clearEBtn.TabIndex = 17;
            this.clearEBtn.Text = "CE";
            this.clearEBtn.UseVisualStyleBackColor = true;
            this.clearEBtn.Click += new System.EventHandler(this.clearEBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(144, 81);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(60, 60);
            this.delBtn.TabIndex = 24;
            this.delBtn.Text = "del";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // num1Btn
            // 
            this.num1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Btn.Location = new System.Drawing.Point(12, 279);
            this.num1Btn.Name = "num1Btn";
            this.num1Btn.Size = new System.Drawing.Size(60, 60);
            this.num1Btn.TabIndex = 25;
            this.num1Btn.Text = "1";
            this.num1Btn.UseVisualStyleBackColor = true;
            this.num1Btn.Click += new System.EventHandler(this.addNum);
            // 
            // num2Btn
            // 
            this.num2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Btn.Location = new System.Drawing.Point(78, 279);
            this.num2Btn.Name = "num2Btn";
            this.num2Btn.Size = new System.Drawing.Size(60, 60);
            this.num2Btn.TabIndex = 26;
            this.num2Btn.Text = "2";
            this.num2Btn.UseVisualStyleBackColor = true;
            this.num2Btn.Click += new System.EventHandler(this.addNum);
            // 
            // num3Btn
            // 
            this.num3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3Btn.Location = new System.Drawing.Point(144, 279);
            this.num3Btn.Name = "num3Btn";
            this.num3Btn.Size = new System.Drawing.Size(60, 60);
            this.num3Btn.TabIndex = 27;
            this.num3Btn.Text = "3";
            this.num3Btn.UseVisualStyleBackColor = true;
            this.num3Btn.Click += new System.EventHandler(this.addNum);
            // 
            // divideBtn
            // 
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(297, 81);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(60, 60);
            this.divideBtn.TabIndex = 36;
            this.divideBtn.Tag = "÷";
            this.divideBtn.Text = "÷";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.OpEvent);
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(231, 345);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(126, 60);
            this.equalBtn.TabIndex = 35;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multBtn.Location = new System.Drawing.Point(297, 147);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(60, 60);
            this.multBtn.TabIndex = 34;
            this.multBtn.Tag = "×";
            this.multBtn.Text = "×";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.OpEvent);
            // 
            // subtractBtn
            // 
            this.subtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractBtn.Location = new System.Drawing.Point(231, 213);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(126, 60);
            this.subtractBtn.TabIndex = 33;
            this.subtractBtn.Tag = "-";
            this.subtractBtn.Text = "-";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.OpEvent);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(231, 279);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(126, 60);
            this.addBtn.TabIndex = 32;
            this.addBtn.Tag = "+";
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.OpEvent);
            // 
            // sqrBtn
            // 
            this.sqrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrBtn.Location = new System.Drawing.Point(231, 81);
            this.sqrBtn.Name = "sqrBtn";
            this.sqrBtn.Size = new System.Drawing.Size(60, 60);
            this.sqrBtn.TabIndex = 30;
            this.sqrBtn.Tag = "√";
            this.sqrBtn.Text = "²√x";
            this.sqrBtn.UseVisualStyleBackColor = true;
            this.sqrBtn.Click += new System.EventHandler(this.OpEvent);
            // 
            // powBtn
            // 
            this.powBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powBtn.Location = new System.Drawing.Point(231, 147);
            this.powBtn.Name = "powBtn";
            this.powBtn.Size = new System.Drawing.Size(60, 60);
            this.powBtn.TabIndex = 29;
            this.powBtn.Tag = "²";
            this.powBtn.Text = "x²";
            this.powBtn.UseVisualStyleBackColor = true;
            this.powBtn.Click += new System.EventHandler(this.OpEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(369, 409);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.multBtn);
            this.Controls.Add(this.subtractBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.sqrBtn);
            this.Controls.Add(this.powBtn);
            this.Controls.Add(this.num3Btn);
            this.Controls.Add(this.num2Btn);
            this.Controls.Add(this.num1Btn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.clearEBtn);
            this.Controls.Add(this.signBtn);
            this.Controls.Add(this.decimalBtn);
            this.Controls.Add(this.num0Btn);
            this.Controls.Add(this.num9Btn);
            this.Controls.Add(this.num8Btn);
            this.Controls.Add(this.num7Btn);
            this.Controls.Add(this.num6Btn);
            this.Controls.Add(this.num5Btn);
            this.Controls.Add(this.num4Btn);
            this.Controls.Add(this.ResultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Eric Pina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button num6Btn;
        private System.Windows.Forms.Button num5Btn;
        private System.Windows.Forms.Button num4Btn;
        private System.Windows.Forms.Button num9Btn;
        private System.Windows.Forms.Button num8Btn;
        private System.Windows.Forms.Button num7Btn;
        private System.Windows.Forms.Button num0Btn;
        private System.Windows.Forms.Button decimalBtn;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button clearEBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button num1Btn;
        private System.Windows.Forms.Button num2Btn;
        private System.Windows.Forms.Button num3Btn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button sqrBtn;
        private System.Windows.Forms.Button powBtn;
    }
}

