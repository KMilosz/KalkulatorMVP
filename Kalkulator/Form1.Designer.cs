namespace Kalkulator
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMno = new Button();
            buttonDzie = new Button();
            buttonRow = new Button();
            buttonClear = new Button();
            textBox1 = new TextBox();
            buttonKropka = new Button();
            buttonZnak = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(101, 137);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(182, 137);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(263, 137);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(101, 218);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(182, 218);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(263, 218);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(101, 299);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(182, 299);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(263, 299);
            button9.Name = "button9";
            button9.Size = new Size(75, 75);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // button10
            // 
            button10.Location = new Point(101, 380);
            button10.Name = "button10";
            button10.Size = new Size(156, 75);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button1_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(344, 299);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 75);
            buttonPlus.TabIndex = 10;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(344, 218);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 75);
            buttonMinus.TabIndex = 11;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonPlus_Click;
            // 
            // buttonMno
            // 
            buttonMno.Location = new Point(344, 138);
            buttonMno.Name = "buttonMno";
            buttonMno.Size = new Size(75, 75);
            buttonMno.TabIndex = 12;
            buttonMno.Text = "x";
            buttonMno.UseVisualStyleBackColor = true;
            buttonMno.Click += buttonPlus_Click;
            // 
            // buttonDzie
            // 
            buttonDzie.Location = new Point(344, 57);
            buttonDzie.Name = "buttonDzie";
            buttonDzie.Size = new Size(75, 75);
            buttonDzie.TabIndex = 13;
            buttonDzie.Text = ":";
            buttonDzie.UseVisualStyleBackColor = true;
            buttonDzie.Click += buttonPlus_Click;
            // 
            // buttonRow
            // 
            buttonRow.Location = new Point(344, 380);
            buttonRow.Name = "buttonRow";
            buttonRow.Size = new Size(75, 75);
            buttonRow.TabIndex = 14;
            buttonRow.Text = "=";
            buttonRow.UseVisualStyleBackColor = true;
            buttonRow.Click += buttonRow_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(101, 57);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(156, 75);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(101, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 27);
            textBox1.TabIndex = 16;
            textBox1.Text = "0";
            // 
            // buttonKropka
            // 
            buttonKropka.Location = new Point(263, 380);
            buttonKropka.Name = "buttonKropka";
            buttonKropka.Size = new Size(75, 75);
            buttonKropka.TabIndex = 17;
            buttonKropka.Text = ",";
            buttonKropka.UseVisualStyleBackColor = true;
            buttonKropka.Click += button1_Click;
            // 
            // buttonZnak
            // 
            buttonZnak.Location = new Point(263, 57);
            buttonZnak.Name = "buttonZnak";
            buttonZnak.Size = new Size(75, 75);
            buttonZnak.TabIndex = 18;
            buttonZnak.Text = "+/-";
            buttonZnak.UseVisualStyleBackColor = true;
            buttonZnak.Click += buttonZnak_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 507);
            Controls.Add(buttonZnak);
            Controls.Add(buttonKropka);
            Controls.Add(textBox1);
            Controls.Add(buttonClear);
            Controls.Add(buttonRow);
            Controls.Add(buttonDzie);
            Controls.Add(buttonMno);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMno;
        private Button buttonDzie;
        private Button buttonRow;
        private Button buttonClear;
        private TextBox textBox1;
        private Button buttonKropka;
        private Button buttonZnak;
        private ErrorProvider errorProvider1;
    }
}