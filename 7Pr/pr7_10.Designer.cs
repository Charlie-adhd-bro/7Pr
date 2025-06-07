namespace _7Pr
{
    partial class pr7_10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pr7_10));
            flowLayoutPanel7 = new FlowLayoutPanel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            label2 = new Label();
            textBoxText = new TextBox();
            labelResult = new Label();
            buttonBack = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            buttonResult = new Button();
            buttonReset = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label5 = new Label();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel7.Location = new Point(13, 13);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new Padding(10);
            flowLayoutPanel7.Size = new Size(393, 116);
            flowLayoutPanel7.TabIndex = 21;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.Controls.Add(label2);
            flowLayoutPanel8.Controls.Add(textBoxText);
            flowLayoutPanel8.Location = new Point(13, 13);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Padding = new Padding(10);
            flowLayoutPanel8.Size = new Size(367, 90);
            flowLayoutPanel8.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 10);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(335, 25);
            label2.TabIndex = 15;
            label2.Text = "Введите количество чисел в массиве";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxText
            // 
            textBoxText.Cursor = Cursors.IBeam;
            textBoxText.Location = new Point(16, 41);
            textBoxText.Margin = new Padding(6);
            textBoxText.Name = "textBoxText";
            textBoxText.ScrollBars = ScrollBars.Vertical;
            textBoxText.Size = new Size(74, 33);
            textBoxText.TabIndex = 14;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Dock = DockStyle.Top;
            labelResult.Location = new Point(467, 132);
            labelResult.Margin = new Padding(6, 0, 6, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 11;
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.Cursor = Cursors.Hand;
            buttonBack.Location = new Point(13, 95);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(418, 35);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Вернуться";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(buttonResult);
            flowLayoutPanel5.Controls.Add(buttonReset);
            flowLayoutPanel5.Controls.Add(buttonBack);
            flowLayoutPanel5.Location = new Point(13, 135);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(445, 143);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // buttonResult
            // 
            buttonResult.AutoSize = true;
            buttonResult.Cursor = Cursors.Hand;
            buttonResult.Location = new Point(13, 13);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(419, 35);
            buttonResult.TabIndex = 0;
            buttonResult.Text = "Результат";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonReset
            // 
            buttonReset.AutoSize = true;
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.Location = new Point(13, 54);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(418, 35);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Controls.Add(labelResult);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 67);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(495, 538);
            flowLayoutPanel3.TabIndex = 17;
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
            flowLayoutPanel2.Size = new Size(495, 67);
            flowLayoutPanel2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(25, 21);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(250, 25);
            label5.TabIndex = 3;
            label5.Text = "Среднее значение массива";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pr7_10
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 605);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "pr7_10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pr7_9";
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel7;
        private Label label2;
        private TextBox textBoxText;
        private Label labelResult;
        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button buttonResult;
        private Button buttonReset;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel8;
    }
}