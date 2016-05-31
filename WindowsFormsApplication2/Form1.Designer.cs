namespace WindowsFormsApplication2
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
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ThreadsNum = new System.Windows.Forms.TextBox();
            this.Error1 = new System.Windows.Forms.Label();
            this.Step1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ThreadList = new System.Windows.Forms.ListView();
            this.ThreadID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThreadString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Įveskite Thread\'ų kiekį:";
            // 
            // ThreadsNum
            // 
            this.ThreadsNum.Location = new System.Drawing.Point(217, 39);
            this.ThreadsNum.Name = "ThreadsNum";
            this.ThreadsNum.Size = new System.Drawing.Size(39, 22);
            this.ThreadsNum.TabIndex = 1;
            // 
            // Error1
            // 
            this.Error1.AutoSize = true;
            this.Error1.BackColor = System.Drawing.Color.White;
            this.Error1.ForeColor = System.Drawing.Color.Red;
            this.Error1.Location = new System.Drawing.Point(396, 42);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(73, 17);
            this.Error1.TabIndex = 2;
            this.Error1.Text = "Riba 2-15!";
            this.Error1.Visible = false;
            // 
            // Step1
            // 
            this.Step1.Location = new System.Drawing.Point(282, 35);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(75, 30);
            this.Step1.TabIndex = 3;
            this.Step1.Text = "Start";
            this.Step1.UseVisualStyleBackColor = true;
            this.Step1.Click += new System.EventHandler(this.Step1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThreadList
            // 
            this.ThreadList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ThreadID,
            this.ThreadString});
            this.ThreadList.FullRowSelect = true;
            this.ThreadList.GridLines = true;
            this.ThreadList.Location = new System.Drawing.Point(49, 92);
            this.ThreadList.Name = "ThreadList";
            this.ThreadList.Size = new System.Drawing.Size(308, 327);
            this.ThreadList.TabIndex = 6;
            this.ThreadList.UseCompatibleStateImageBehavior = false;
            this.ThreadList.View = System.Windows.Forms.View.Details;
            // 
            // ThreadID
            // 
            this.ThreadID.Text = "ID";
            // 
            // ThreadString
            // 
            this.ThreadString.Text = "String";
            this.ThreadString.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 441);
            this.Controls.Add(this.ThreadList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Step1);
            this.Controls.Add(this.Error1);
            this.Controls.Add(this.ThreadsNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ThreadsNum;
        private System.Windows.Forms.Label Error1;
        private System.Windows.Forms.Button Step1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView ThreadList;
        private System.Windows.Forms.ColumnHeader ThreadID;
        private System.Windows.Forms.ColumnHeader ThreadString;
    }
}

