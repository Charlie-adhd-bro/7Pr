﻿namespace _7Pr
{
    partial class pr7_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pr7_8));
            flowLayoutPanel8 = new FlowLayoutPanel();
            label2 = new Label();
            textBoxText = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label1 = new Label();
            textBoxSubstring = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label6 = new Label();
            textBoxPosition = new TextBox();
            labelResult = new Label();
            buttonBack = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            buttonResult = new Button();
            buttonReset = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label5 = new Label();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.Controls.Add(label2);
            flowLayoutPanel8.Controls.Add(textBoxText);
            flowLayoutPanel8.Location = new Point(13, 13);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Padding = new Padding(10);
            flowLayoutPanel8.Size = new Size(478, 121);
            flowLayoutPanel8.TabIndex = 22;
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
            textBoxText.Cursor = Cursors.IBeam;
            textBoxText.Location = new Point(159, 16);
            textBoxText.Margin = new Padding(6);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.ScrollBars = ScrollBars.Vertical;
            textBoxText.Size = new Size(303, 89);
            textBoxText.TabIndex = 14;
            textBoxText.Text = "Мама мыла раму";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(13, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(1238, 147);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.Controls.Add(label1);
            flowLayoutPanel6.Controls.Add(textBoxSubstring);
            flowLayoutPanel6.Location = new Point(497, 13);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(10);
            flowLayoutPanel6.Size = new Size(419, 108);
            flowLayoutPanel6.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(176, 50);
            label1.TabIndex = 19;
            label1.Text = "Введите подстроку\r\nдля вставки";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxSubstring
            // 
            textBoxSubstring.Location = new Point(192, 16);
            textBoxSubstring.Margin = new Padding(6);
            textBoxSubstring.Multiline = true;
            textBoxSubstring.Name = "textBoxSubstring";
            textBoxSubstring.ScrollBars = ScrollBars.Vertical;
            textBoxSubstring.Size = new Size(211, 76);
            textBoxSubstring.TabIndex = 16;
            textBoxSubstring.Text = " смотрела, а ее дочь";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(label6);
            flowLayoutPanel4.Controls.Add(textBoxPosition);
            flowLayoutPanel4.Location = new Point(922, 13);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(10);
            flowLayoutPanel4.Size = new Size(303, 65);
            flowLayoutPanel4.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 10);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(165, 25);
            label6.TabIndex = 17;
            label6.Text = "Введите позицию\r\n";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(181, 16);
            textBoxPosition.Margin = new Padding(6);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.ScrollBars = ScrollBars.Vertical;
            textBoxPosition.Size = new Size(106, 33);
            textBoxPosition.TabIndex = 18;
            textBoxPosition.Text = "4";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Dock = DockStyle.Top;
            labelResult.Location = new Point(1273, 163);
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
            buttonBack.Location = new Point(862, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(376, 35);
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
            flowLayoutPanel5.Dock = DockStyle.Bottom;
            flowLayoutPanel5.Location = new Point(13, 166);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(1251, 61);
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
            buttonReset.Location = new Point(438, 13);
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
            flowLayoutPanel3.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Controls.Add(labelResult);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 67);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(1309, 538);
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
            flowLayoutPanel2.Size = new Size(1309, 67);
            flowLayoutPanel2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(25, 21);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(445, 25);
            label5.TabIndex = 3;
            label5.Text = "Класс с текстовым полем и изменение этого поля";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pr7_8
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 605);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "pr7_8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pr7_8";
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label1;
        private TextBox textBoxSubstring;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label6;
        private TextBox textBoxPosition;
        private FlowLayoutPanel flowLayoutPanel8;
    }
}