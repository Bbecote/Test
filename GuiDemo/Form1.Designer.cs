namespace GuiDemo
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
            richTextBox_ParagraphText = new RichTextBox();
            label_ShortText = new Label();
            button_ClickMe = new Button();
            numericUpDown1 = new NumericUpDown();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox_ParagraphText
            // 
            richTextBox_ParagraphText.BorderStyle = BorderStyle.None;
            richTextBox_ParagraphText.Font = new Font("Elephant", 20.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_ParagraphText.Location = new Point(451, 103);
            richTextBox_ParagraphText.Name = "richTextBox_ParagraphText";
            richTextBox_ParagraphText.Size = new Size(612, 71);
            richTextBox_ParagraphText.TabIndex = 0;
            richTextBox_ParagraphText.Text = "This is a rich text box for paragraphs of text";
            richTextBox_ParagraphText.TextChanged += richTextBox1_TextChanged;
            // 
            // label_ShortText
            // 
            label_ShortText.AutoSize = true;
            label_ShortText.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ShortText.Location = new Point(47, 21);
            label_ShortText.Name = "label_ShortText";
            label_ShortText.Size = new Size(313, 47);
            label_ShortText.TabIndex = 1;
            label_ShortText.Text = "Label for short text";
            label_ShortText.Click += label1_Click;
            // 
            // button_ClickMe
            // 
            button_ClickMe.BackColor = Color.DarkSeaGreen;
            button_ClickMe.FlatStyle = FlatStyle.Flat;
            button_ClickMe.Location = new Point(201, 103);
            button_ClickMe.Name = "button_ClickMe";
            button_ClickMe.Size = new Size(175, 75);
            button_ClickMe.TabIndex = 2;
            button_ClickMe.Text = "Click Me!";
            button_ClickMe.UseVisualStyleBackColor = false;
            button_ClickMe.Click += button_ClickMe_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(129, 101);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 40, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_ShortText);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(248, 488);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 184);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1519, 946);
            Controls.Add(panel1);
            Controls.Add(button_ClickMe);
            Controls.Add(richTextBox_ParagraphText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_ParagraphText;
        private Label label_ShortText;
        private Button button_ClickMe;
        private NumericUpDown numericUpDown1;
        private Panel panel1;
    }
}
