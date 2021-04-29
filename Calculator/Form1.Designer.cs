
namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(12, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(123, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatAppearance.BorderSize = 10;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button3.Location = new System.Drawing.Point(234, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.clearClicked);
            this.button3.MouseLeave += new System.EventHandler(this.button_MouseLeaveToGray);
            this.button3.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 10;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button4.Location = new System.Drawing.Point(346, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.delete_last_char);
            this.button4.MouseLeave += new System.EventHandler(this.button_MouseLeaveToGray);
            this.button4.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 10;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button5.Location = new System.Drawing.Point(346, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "÷";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.operatorClicked);
            this.button5.MouseLeave += new System.EventHandler(this.button_MouseLeaveToGray);
            this.button5.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.button6.FlatAppearance.BorderSize = 10;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button6.Location = new System.Drawing.Point(235, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 48);
            this.button6.TabIndex = 6;
            this.button6.Text = "√x";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.button7.FlatAppearance.BorderSize = 10;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button7.Location = new System.Drawing.Point(124, 229);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 48);
            this.button7.TabIndex = 5;
            this.button7.Text = "x^2";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.button8.FlatAppearance.BorderSize = 10;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button8.Location = new System.Drawing.Point(13, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 48);
            this.button8.TabIndex = 4;
            this.button8.Text = "1/x";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatAppearance.BorderSize = 10;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button9.Location = new System.Drawing.Point(345, 283);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 48);
            this.button9.TabIndex = 11;
            this.button9.Text = "x";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.operatorClicked);
            this.button9.MouseLeave += new System.EventHandler(this.button_MouseLeaveToGray);
            this.button9.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.FlatAppearance.BorderSize = 10;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(234, 283);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 48);
            this.button10.TabIndex = 10;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.number_clicked);
            this.button10.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button10.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.FlatAppearance.BorderSize = 10;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(123, 283);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 48);
            this.button11.TabIndex = 9;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.number_clicked);
            this.button11.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button11.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.FlatAppearance.BorderSize = 10;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(12, 283);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(105, 48);
            this.button12.TabIndex = 8;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.number_clicked);
            this.button12.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button12.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button13.FlatAppearance.BorderSize = 10;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button13.Location = new System.Drawing.Point(346, 337);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(105, 48);
            this.button13.TabIndex = 15;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.operatorClicked);
            this.button13.MouseLeave += new System.EventHandler(this.button_MouseLeaveToGray);
            this.button13.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.FlatAppearance.BorderSize = 10;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(235, 337);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(105, 48);
            this.button14.TabIndex = 14;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.number_clicked);
            this.button14.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button14.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button15.FlatAppearance.BorderSize = 10;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(124, 337);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(105, 48);
            this.button15.TabIndex = 13;
            this.button15.Text = "5";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.number_clicked);
            this.button15.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button15.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.FlatAppearance.BorderSize = 10;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(13, 337);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(105, 48);
            this.button16.TabIndex = 12;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.number_clicked);
            this.button16.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button16.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button17.FlatAppearance.BorderSize = 10;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button17.Location = new System.Drawing.Point(346, 391);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(105, 48);
            this.button17.TabIndex = 19;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.operatorClicked);
            this.button17.MouseLeave += new System.EventHandler(this.button_MouseLeaveToGray);
            this.button17.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button18.FlatAppearance.BorderSize = 10;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(235, 391);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(105, 48);
            this.button18.TabIndex = 18;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.number_clicked);
            this.button18.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button18.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button19.FlatAppearance.BorderSize = 10;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(124, 391);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(105, 48);
            this.button19.TabIndex = 17;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.number_clicked);
            this.button19.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button19.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button20.FlatAppearance.BorderSize = 10;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(13, 391);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(105, 48);
            this.button20.TabIndex = 16;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.number_clicked);
            this.button20.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button20.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(199)))));
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button21.FlatAppearance.BorderSize = 10;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button21.Location = new System.Drawing.Point(346, 445);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(105, 48);
            this.button21.TabIndex = 23;
            this.button21.Text = "=";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.equalClicked);
            this.button21.MouseHover += new System.EventHandler(this.buttonEqual_MouseHover);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button22.FlatAppearance.BorderSize = 10;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button22.Location = new System.Drawing.Point(235, 445);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(105, 48);
            this.button22.TabIndex = 22;
            this.button22.Text = ".";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.MouseLeave += new System.EventHandler(this.button_MouseLeaveToGray);
            this.button22.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button23.FlatAppearance.BorderSize = 10;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(124, 445);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(105, 48);
            this.button23.TabIndex = 21;
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.number_clicked);
            this.button23.MouseLeave += new System.EventHandler(this.button_MouseLeaveToBlack);
            this.button23.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(34)))), ((int)(((byte)(23)))));
            this.button24.FlatAppearance.BorderSize = 10;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button24.Location = new System.Drawing.Point(13, 445);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(105, 48);
            this.button24.TabIndex = 20;
            this.button24.Text = "+/-";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // screen
            // 
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.screen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.screen.Location = new System.Drawing.Point(10, 26);
            this.screen.Multiline = true;
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(440, 121);
            this.screen.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(464, 507);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox screen;
    }
}

