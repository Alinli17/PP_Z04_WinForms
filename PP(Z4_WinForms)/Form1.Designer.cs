namespace PP_Z4_WinForms_
{
    partial class Practica_4
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Zadanie_1 = new System.Windows.Forms.GroupBox();
            this.Zadanie_2 = new System.Windows.Forms.GroupBox();
            this.fun = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.Label();
            this.manually = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Button();
            this.vopros = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.Label();
            this.Transfer = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formula = new System.Windows.Forms.PictureBox();
            this.enter_N = new System.Windows.Forms.TextBox();
            this.function_call = new System.Windows.Forms.Label();
            this.Zadanie_1.SuspendLayout();
            this.Zadanie_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formula)).BeginInit();
            this.SuspendLayout();
            // 
            // Zadanie_1
            // 
            this.Zadanie_1.Controls.Add(this.function_call);
            this.Zadanie_1.Controls.Add(this.enter_N);
            this.Zadanie_1.Controls.Add(this.formula);
            this.Zadanie_1.Controls.Add(this.label1);
            this.Zadanie_1.Controls.Add(this.Result);
            this.Zadanie_1.Controls.Add(this.manually);
            this.Zadanie_1.Controls.Add(this.function);
            this.Zadanie_1.Controls.Add(this.fun);
            this.Zadanie_1.Location = new System.Drawing.Point(0, 0);
            this.Zadanie_1.Name = "Zadanie_1";
            this.Zadanie_1.Size = new System.Drawing.Size(396, 298);
            this.Zadanie_1.TabIndex = 0;
            this.Zadanie_1.TabStop = false;
            this.Zadanie_1.Text = "Задание 1";
            // 
            // Zadanie_2
            // 
            this.Zadanie_2.Controls.Add(this.rez);
            this.Zadanie_2.Controls.Add(this.cc);
            this.Zadanie_2.Controls.Add(this.number);
            this.Zadanie_2.Controls.Add(this.Transfer);
            this.Zadanie_2.Controls.Add(this.n);
            this.Zadanie_2.Controls.Add(this.num);
            this.Zadanie_2.Controls.Add(this.vopros);
            this.Zadanie_2.Location = new System.Drawing.Point(402, 0);
            this.Zadanie_2.Name = "Zadanie_2";
            this.Zadanie_2.Size = new System.Drawing.Size(396, 298);
            this.Zadanie_2.TabIndex = 0;
            this.Zadanie_2.TabStop = false;
            this.Zadanie_2.Text = "Задание 2";
            // 
            // fun
            // 
            this.fun.AutoSize = true;
            this.fun.Location = new System.Drawing.Point(12, 73);
            this.fun.Name = "fun";
            this.fun.Size = new System.Drawing.Size(97, 17);
            this.fun.TabIndex = 0;
            this.fun.Text = "Вызов ф-ции:";
            // 
            // function
            // 
            this.function.AutoSize = true;
            this.function.Location = new System.Drawing.Point(160, 44);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(0, 17);
            this.function.TabIndex = 2;
            // 
            // manually
            // 
            this.manually.AutoSize = true;
            this.manually.Location = new System.Drawing.Point(160, 79);
            this.manually.Name = "manually";
            this.manually.Size = new System.Drawing.Size(0, 17);
            this.manually.TabIndex = 3;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(125, 220);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(134, 52);
            this.Result.TabIndex = 4;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // vopros
            // 
            this.vopros.AutoSize = true;
            this.vopros.Location = new System.Drawing.Point(19, 44);
            this.vopros.Name = "vopros";
            this.vopros.Size = new System.Drawing.Size(220, 17);
            this.vopros.TabIndex = 0;
            this.vopros.Text = "Какое число хотите перевести?";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(245, 41);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(100, 22);
            this.num.TabIndex = 1;
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(19, 195);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(49, 17);
            this.n.TabIndex = 2;
            this.n.Text = "Число";
            // 
            // Transfer
            // 
            this.Transfer.Location = new System.Drawing.Point(126, 105);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(134, 52);
            this.Transfer.TabIndex = 3;
            this.Transfer.Text = "Перевести";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(83, 195);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(0, 17);
            this.number.TabIndex = 4;
            this.number.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(141, 195);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(136, 17);
            this.cc.TabIndex = 5;
            this.cc.Text = "в двоичной сс      = ";
            // 
            // rez
            // 
            this.rez.AutoSize = true;
            this.rez.Location = new System.Drawing.Point(285, 195);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(0, 17);
            this.rez.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите N:";
            // 
            // formula
            // 
            this.formula.BackgroundImage = global::PP_Z4_WinForms_.Properties.Resources.Снимок;
            this.formula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formula.Location = new System.Drawing.Point(51, 105);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(291, 97);
            this.formula.TabIndex = 6;
            this.formula.TabStop = false;
            // 
            // enter_N
            // 
            this.enter_N.Location = new System.Drawing.Point(159, 38);
            this.enter_N.Name = "enter_N";
            this.enter_N.Size = new System.Drawing.Size(100, 22);
            this.enter_N.TabIndex = 7;
            // 
            // function_call
            // 
            this.function_call.AutoSize = true;
            this.function_call.Location = new System.Drawing.Point(156, 73);
            this.function_call.Name = "function_call";
            this.function_call.Size = new System.Drawing.Size(0, 17);
            this.function_call.TabIndex = 7;
            // 
            // Practica_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.Zadanie_2);
            this.Controls.Add(this.Zadanie_1);
            this.Name = "Practica_4";
            this.Text = "Практика 4";
            this.Zadanie_1.ResumeLayout(false);
            this.Zadanie_1.PerformLayout();
            this.Zadanie_2.ResumeLayout(false);
            this.Zadanie_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie_1;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label manually;
        private System.Windows.Forms.Label function;
        private System.Windows.Forms.Label fun;
        private System.Windows.Forms.GroupBox Zadanie_2;
        private System.Windows.Forms.Label rez;
        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label vopros;
        private System.Windows.Forms.PictureBox formula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label function_call;
        private System.Windows.Forms.TextBox enter_N;
    }
}

