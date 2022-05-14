namespace Homework_3_form_
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.coordA = new System.Windows.Forms.TextBox();
            this.coordB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cubes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.range = new System.Windows.Forms.Label();
            this.polindrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 125);
            this.button1.TabIndex = 0;
            this.button1.Text = "Жмяк";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(587, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // coordA
            // 
            this.coordA.Location = new System.Drawing.Point(315, 40);
            this.coordA.Name = "coordA";
            this.coordA.Size = new System.Drawing.Size(100, 20);
            this.coordA.TabIndex = 1;
            this.coordA.TextChanged += new System.EventHandler(this.coordA_TextChanged);
            // 
            // coordB
            // 
            this.coordB.Location = new System.Drawing.Point(315, 102);
            this.coordB.Name = "coordB";
            this.coordB.Size = new System.Drawing.Size(100, 20);
            this.coordB.TabIndex = 1;
            this.coordB.TextChanged += new System.EventHandler(this.coordB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Куб предыдущих чисел";
            // 
            // cubes
            // 
            this.cubes.AutoSize = true;
            this.cubes.Location = new System.Drawing.Point(613, 84);
            this.cubes.Name = "cubes";
            this.cubes.Size = new System.Drawing.Size(37, 13);
            this.cubes.TabIndex = 2;
            this.cubes.Text = "Ответ";
            this.cubes.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите координаты А";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Введите координаты В";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // range
            // 
            this.range.AutoSize = true;
            this.range.Location = new System.Drawing.Point(341, 138);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(37, 13);
            this.range.TabIndex = 2;
            this.range.Text = "Ответ";
            this.range.Click += new System.EventHandler(this.label4_Click);
            // 
            // polindrom
            // 
            this.polindrom.Location = new System.Drawing.Point(56, 40);
            this.polindrom.Name = "polindrom";
            this.polindrom.Size = new System.Drawing.Size(100, 20);
            this.polindrom.TabIndex = 3;
            this.polindrom.TextChanged += new System.EventHandler(this.polindrom_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Полиндром?";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(65, 84);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(37, 13);
            this.answer.TabIndex = 4;
            this.answer.Text = "Ответ";
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.polindrom);
            this.Controls.Add(this.range);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cubes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coordB);
            this.Controls.Add(this.coordA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox coordA;
        private System.Windows.Forms.TextBox coordB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cubes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label range;
        private System.Windows.Forms.TextBox polindrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label answer;
    }
}

