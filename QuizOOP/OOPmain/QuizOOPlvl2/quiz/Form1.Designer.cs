namespace quiz
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
            NameTextbox = new TextBox();
            ST_ID_Text = new TextBox();
            bindingSource1 = new BindingSource(components);
            comboBox1 = new ComboBox();
            GpxText = new TextBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            ข้อมูลอาจารย์ = new GroupBox();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            ข้อมูลอาจารย์.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(218, 52);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(184, 43);
            button1.TabIndex = 0;
            button1.Text = "ADD_DATA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(156, 45);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(147, 84);
            button2.TabIndex = 1;
            button2.Text = "ShowDataTeacher";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(80, 52);
            NameTextbox.Margin = new Padding(3, 4, 3, 4);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(114, 27);
            NameTextbox.TabIndex = 2;
            NameTextbox.TextChanged += textBox1_TextChanged;
            // 
            // ST_ID_Text
            // 
            ST_ID_Text.Location = new Point(80, 88);
            ST_ID_Text.Margin = new Padding(3, 4, 3, 4);
            ST_ID_Text.Name = "ST_ID_Text";
            ST_ID_Text.Size = new Size(114, 27);
            ST_ID_Text.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Architecture", "Art", "Business", "ComputerScience" });
            comboBox1.Location = new Point(80, 167);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 28);
            comboBox1.TabIndex = 5;
            // 
            // GpxText
            // 
            GpxText.Location = new Point(80, 209);
            GpxText.Margin = new Padding(3, 4, 3, 4);
            GpxText.Name = "GpxText";
            GpxText.Size = new Size(114, 27);
            GpxText.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Dr_bob", "Dr_Pront Johndan", "Dr_Jin", "Dr_Linda" });
            comboBox2.Location = new Point(80, 128);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(114, 28);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 225);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 59);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 95);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 11;
            label4.Text = "Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 216);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 12;
            label5.Text = "Gpx";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 175);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "Major";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 136);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 14;
            label7.Text = "Advisor";
            label7.Click += label7_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Dr_bob", "Dr_Pront Johndan", "Dr_Jin" });
            comboBox3.Location = new Point(24, 74);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(114, 28);
            comboBox3.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 139);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ST_ID_Text);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(NameTextbox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(GpxText);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(429, 351);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลนักเรียน";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // ข้อมูลอาจารย์
            // 
            ข้อมูลอาจารย์.Controls.Add(button2);
            ข้อมูลอาจารย์.Controls.Add(comboBox3);
            ข้อมูลอาจารย์.Controls.Add(label8);
            ข้อมูลอาจารย์.Location = new Point(722, 27);
            ข้อมูลอาจารย์.Margin = new Padding(3, 4, 3, 4);
            ข้อมูลอาจารย์.Name = "ข้อมูลอาจารย์";
            ข้อมูลอาจารย์.Padding = new Padding(3, 4, 3, 4);
            ข้อมูลอาจารย์.Size = new Size(309, 340);
            ข้อมูลอาจารย์.TabIndex = 20;
            ข้อมูลอาจารย์.TabStop = false;
            ข้อมูลอาจารย์.Text = "ข้อมูลอาจารย์";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(467, 43);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(467, 27);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 21;
            label9.Text = "ข้อมูลล่าสูด";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(467, 205);
            label10.Name = "label10";
            label10.Size = new Size(151, 20);
            label10.TabIndex = 22;
            label10.Text = "นักเรียนที่เกรดเฉลี่ยสูงสุด";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 739);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ข้อมูลอาจารย์);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ข้อมูลอาจารย์.ResumeLayout(false);
            ข้อมูลอาจารย์.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox NameTextbox;
        private TextBox ST_ID_Text;
        private BindingSource bindingSource1;
        private ComboBox comboBox1;
        private TextBox GpxText;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox3;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox ข้อมูลอาจารย์;
        private Label label1;
        private Label label9;
        private Label label10;
    }
}
