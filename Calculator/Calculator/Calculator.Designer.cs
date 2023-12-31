namespace Calculator
{
    partial class Calculator
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
            Zero = new Button();
            multiplication = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            substation = new Button();
            sum = new Button();
            division = new Button();
            total = new Button();
            comma = new Button();
            textBox = new TextBox();
            label = new Label();
            reset = new Button();
            SuspendLayout();
            // 
            // Zero
            // 
            Zero.Location = new Point(105, 373);
            Zero.Name = "Zero";
            Zero.Size = new Size(72, 67);
            Zero.TabIndex = 0;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // multiplication
            // 
            multiplication.Location = new Point(261, 227);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(72, 67);
            multiplication.TabIndex = 1;
            multiplication.Text = "x";
            multiplication.UseVisualStyleBackColor = true;
            multiplication.Click += multiplication_Click;
            // 
            // nine
            // 
            nine.Location = new Point(183, 154);
            nine.Name = "nine";
            nine.Size = new Size(72, 67);
            nine.TabIndex = 2;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // eight
            // 
            eight.Location = new Point(105, 154);
            eight.Name = "eight";
            eight.Size = new Size(72, 67);
            eight.TabIndex = 3;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.Location = new Point(27, 154);
            seven.Name = "seven";
            seven.Size = new Size(72, 67);
            seven.TabIndex = 4;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // six
            // 
            six.Location = new Point(183, 227);
            six.Name = "six";
            six.Size = new Size(72, 67);
            six.TabIndex = 6;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // five
            // 
            five.Location = new Point(105, 227);
            five.Name = "five";
            five.Size = new Size(72, 67);
            five.TabIndex = 6;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // four
            // 
            four.Location = new Point(27, 227);
            four.Name = "four";
            four.Size = new Size(72, 67);
            four.TabIndex = 7;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // three
            // 
            three.Location = new Point(183, 300);
            three.Name = "three";
            three.Size = new Size(72, 67);
            three.TabIndex = 8;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // two
            // 
            two.Location = new Point(105, 300);
            two.Name = "two";
            two.Size = new Size(72, 67);
            two.TabIndex = 9;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // one
            // 
            one.Location = new Point(27, 300);
            one.Name = "one";
            one.Size = new Size(72, 67);
            one.TabIndex = 10;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // substation
            // 
            substation.Location = new Point(261, 300);
            substation.Name = "substation";
            substation.Size = new Size(72, 67);
            substation.TabIndex = 11;
            substation.Text = "-";
            substation.UseVisualStyleBackColor = true;
            substation.Click += substation_Click;
            // 
            // sum
            // 
            sum.Location = new Point(261, 373);
            sum.Name = "sum";
            sum.Size = new Size(72, 67);
            sum.TabIndex = 12;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = true;
            sum.Click += sum_Click;
            // 
            // division
            // 
            division.Location = new Point(261, 154);
            division.Name = "division";
            division.Size = new Size(72, 67);
            division.TabIndex = 13;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // total
            // 
            total.Location = new Point(183, 373);
            total.Name = "total";
            total.Size = new Size(72, 67);
            total.TabIndex = 14;
            total.Text = "=";
            total.UseVisualStyleBackColor = true;
            total.Click += total_Click;
            // 
            // comma
            // 
            comma.Location = new Point(27, 373);
            comma.Name = "comma";
            comma.Size = new Size(72, 67);
            comma.TabIndex = 15;
            comma.Text = ",";
            comma.UseVisualStyleBackColor = true;
            comma.Click += comma_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(28, 27);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(305, 35);
            textBox.TabIndex = 16;
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(31, 30);
            label.Name = "label";
            label.Size = new Size(0, 30);
            label.TabIndex = 17;
            // 
            // reset
            // 
            reset.Location = new Point(339, 154);
            reset.Name = "reset";
            reset.Size = new Size(72, 67);
            reset.TabIndex = 18;
            reset.Text = "C";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 499);
            Controls.Add(reset);
            Controls.Add(label);
            Controls.Add(textBox);
            Controls.Add(comma);
            Controls.Add(total);
            Controls.Add(division);
            Controls.Add(sum);
            Controls.Add(substation);
            Controls.Add(one);
            Controls.Add(two);
            Controls.Add(three);
            Controls.Add(four);
            Controls.Add(five);
            Controls.Add(six);
            Controls.Add(seven);
            Controls.Add(eight);
            Controls.Add(nine);
            Controls.Add(multiplication);
            Controls.Add(Zero);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Zero;
        private Button multiplication;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button six;
        private Button five;
        private Button four;
        private Button three;
        private Button two;
        private Button one;
        private Button substation;
        private Button sum;
        private Button division;
        private Button total;
        private Button comma;
        private TextBox textBox;
        private Label label;
        private Button reset;
    }
}