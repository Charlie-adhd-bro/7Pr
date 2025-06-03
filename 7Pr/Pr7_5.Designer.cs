namespace _7Pr
{
    partial class pr7_5
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
            buttonResult = new Button();
            buttonReset = new Button();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            textBoxText = new TextBox();
            label6 = new Label();
            textBoxSymbol = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            buttonBack = new Button();
            labelResult = new Label();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // buttonResult
            // 
            buttonResult.AutoSize = true;
            buttonResult.Location = new Point(13, 13);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(106, 35);
            buttonResult.TabIndex = 0;
            buttonResult.Text = "Результат";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonReset
            // 
            buttonReset.AutoSize = true;
            buttonReset.Location = new Point(125, 13);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(76, 35);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(25, 21);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(303, 50);
            label5.TabIndex = 3;
            label5.Text = "Определение позиции символа в тексте";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(6);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(19, 21, 19, 21);
            flowLayoutPanel2.Size = new Size(362, 92);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(textBoxText);
            flowLayoutPanel3.Controls.Add(label6);
            flowLayoutPanel3.Controls.Add(textBoxSymbol);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Controls.Add(labelResult);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 92);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(362, 402);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 10);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 15;
            label2.Text = "Введите текст";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(16, 41);
            textBoxText.Margin = new Padding(6);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.ScrollBars = ScrollBars.Vertical;
            textBoxText.Size = new Size(328, 89);
            textBoxText.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 136);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 17;
            label6.Text = "Введите символ";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxSymbol
            // 
            textBoxSymbol.Location = new Point(179, 142);
            textBoxSymbol.Margin = new Padding(6);
            textBoxSymbol.MaxLength = 1;
            textBoxSymbol.Name = "textBoxSymbol";
            textBoxSymbol.ScrollBars = ScrollBars.Vertical;
            textBoxSymbol.Size = new Size(165, 33);
            textBoxSymbol.TabIndex = 16;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(buttonResult);
            flowLayoutPanel5.Controls.Add(buttonReset);
            flowLayoutPanel5.Controls.Add(buttonBack);
            flowLayoutPanel5.Location = new Point(13, 184);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(331, 61);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.Location = new Point(207, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(111, 35);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Вернуться";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Dock = DockStyle.Top;
            labelResult.Location = new Point(16, 248);
            labelResult.Margin = new Padding(6, 0, 6, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 11;
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pr7_5
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 494);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "pr7_5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pr7_5";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonResult;
        private Button buttonReset;
        //private Label label3;
        //private TextBox textBoxSecond;
        //private Label label4;
        //private TextBox textBoxEnd;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label labelResult;
        //private Label label1;
        private Label label2;
        private TextBox textBoxText;
        private Label label6;
        private TextBox textBoxSymbol;
    }
}