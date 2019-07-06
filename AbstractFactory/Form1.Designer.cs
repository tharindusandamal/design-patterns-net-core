namespace AbstractFactory
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
            this.radioButton_SqlSrver = new System.Windows.Forms.RadioButton();
            this.radioButton_OleDb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton_SqlSrver
            // 
            this.radioButton_SqlSrver.AutoSize = true;
            this.radioButton_SqlSrver.Location = new System.Drawing.Point(66, 47);
            this.radioButton_SqlSrver.Name = "radioButton_SqlSrver";
            this.radioButton_SqlSrver.Size = new System.Drawing.Size(74, 17);
            this.radioButton_SqlSrver.TabIndex = 0;
            this.radioButton_SqlSrver.TabStop = true;
            this.radioButton_SqlSrver.Text = "Sql Server";
            this.radioButton_SqlSrver.UseVisualStyleBackColor = true;
            // 
            // radioButton_OleDb
            // 
            this.radioButton_OleDb.AutoSize = true;
            this.radioButton_OleDb.Location = new System.Drawing.Point(66, 70);
            this.radioButton_OleDb.Name = "radioButton_OleDb";
            this.radioButton_OleDb.Size = new System.Drawing.Size(58, 17);
            this.radioButton_OleDb.TabIndex = 1;
            this.radioButton_OleDb.TabStop = true;
            this.radioButton_OleDb.Text = "Ole Db";
            this.radioButton_OleDb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Database:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Display
            // 
            this.textBox_Display.Location = new System.Drawing.Point(31, 146);
            this.textBox_Display.Multiline = true;
            this.textBox_Display.Name = "textBox_Display";
            this.textBox_Display.Size = new System.Drawing.Size(204, 113);
            this.textBox_Display.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 271);
            this.Controls.Add(this.textBox_Display);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_OleDb);
            this.Controls.Add(this.radioButton_SqlSrver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_SqlSrver;
        private System.Windows.Forms.RadioButton radioButton_OleDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Display;
    }
}

