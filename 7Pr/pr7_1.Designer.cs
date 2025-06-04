namespace _7Pr
{
    partial class pr7_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pr7_1));
            buttonResult = new Button();
            buttonReset = new Button();
            textBoxInput = new TextBox();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
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
            // textBoxInput
            // 
            textBoxInput.Location = new Point(16, 16);
            textBoxInput.Margin = new Padding(6);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(328, 89);
            textBoxInput.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(25, 21);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 3;
            label5.Text = "Введите текст\r\n";
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
            flowLayoutPanel2.Size = new Size(360, 67);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(textBoxInput);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Controls.Add(labelResult);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 67);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(360, 401);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(buttonResult);
            flowLayoutPanel5.Controls.Add(buttonReset);
            flowLayoutPanel5.Controls.Add(buttonBack);
            flowLayoutPanel5.Location = new Point(13, 114);
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
            labelResult.Location = new Point(16, 178);
            labelResult.Margin = new Padding(6, 0, 6, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 11;
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pr7_1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 468);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "pr7_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pr7_1";
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
        private TextBox textBoxInput;
        //private Label label4;
        //private TextBox textBoxEnd;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label labelResult;
    }
}