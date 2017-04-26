namespace Геодезия
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
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.XTtextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.SecondsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPointBtn = new System.Windows.Forms.Button();
            this.WritePointsToFileBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.Location = new System.Drawing.Point(221, 206);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(122, 108);
            this.ChooseFileBtn.TabIndex = 0;
            this.ChooseFileBtn.Text = "Загрузить файл с измерениями для дальнейших расчётов";
            this.ChooseFileBtn.UseVisualStyleBackColor = true;
            this.ChooseFileBtn.Click += new System.EventHandler(this.ChooseFileBtn_Click);
            // 
            // XTtextBox
            // 
            this.XTtextBox.Location = new System.Drawing.Point(67, 76);
            this.XTtextBox.Name = "XTtextBox";
            this.XTtextBox.Size = new System.Drawing.Size(100, 22);
            this.XTtextBox.TabIndex = 1;
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(187, 76);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 22);
            this.YTextBox.TabIndex = 2;
            // 
            // SecondsTextBox
            // 
            this.SecondsTextBox.Location = new System.Drawing.Point(306, 76);
            this.SecondsTextBox.Name = "SecondsTextBox";
            this.SecondsTextBox.Size = new System.Drawing.Size(100, 22);
            this.SecondsTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seconds";
            // 
            // AddPointBtn
            // 
            this.AddPointBtn.Location = new System.Drawing.Point(306, 113);
            this.AddPointBtn.Name = "AddPointBtn";
            this.AddPointBtn.Size = new System.Drawing.Size(104, 55);
            this.AddPointBtn.TabIndex = 7;
            this.AddPointBtn.Text = "Добавить точку";
            this.AddPointBtn.UseVisualStyleBackColor = true;
            this.AddPointBtn.Click += new System.EventHandler(this.AddPointBtn_Click);
            // 
            // WritePointsToFileBtn
            // 
            this.WritePointsToFileBtn.Enabled = false;
            this.WritePointsToFileBtn.Location = new System.Drawing.Point(67, 206);
            this.WritePointsToFileBtn.Name = "WritePointsToFileBtn";
            this.WritePointsToFileBtn.Size = new System.Drawing.Size(120, 108);
            this.WritePointsToFileBtn.TabIndex = 8;
            this.WritePointsToFileBtn.Text = "Сохранить измерения в файл";
            this.WritePointsToFileBtn.UseVisualStyleBackColor = true;
            this.WritePointsToFileBtn.Click += new System.EventHandler(this.WritePointsToFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Points added:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Найти скважину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(495, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WritePointsToFileBtn);
            this.Controls.Add(this.AddPointBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondsTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTtextBox);
            this.Controls.Add(this.ChooseFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.TextBox XTtextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox SecondsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddPointBtn;
        private System.Windows.Forms.Button WritePointsToFileBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

