namespace WinFormsApp6
{
    partial class User_Panel
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightYellow;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 12);
            label2.Name = "label2";
            label2.Size = new Size(194, 15);
            label2.TabIndex = 5;
            label2.Text = "Список Автомобилей в \"корзине\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 12);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 4;
            label1.Text = "Список Автомобилей в наличии";
            // 
            // button2
            // 
            button2.Location = new Point(444, 292);
            button2.Name = "button2";
            button2.Size = new Size(75, 66);
            button2.TabIndex = 3;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(444, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 65);
            button1.TabIndex = 2;
            button1.Text = "Дабавить в корзину";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(315, 33);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(277, 169);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(277, 424);
            listBox1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(697, 373);
            button3.Name = "button3";
            button3.Size = new Size(103, 74);
            button3.TabIndex = 6;
            button3.Text = "Выйти на панель авторизации ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // User_Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "User_Panel";
            Text = "User_Panel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}