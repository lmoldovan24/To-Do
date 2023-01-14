namespace To_Do
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SubmitTask = new System.Windows.Forms.Button();
            this.btn_DeleteLastElem = new System.Windows.Forms.Button();
            this.lbl_YourTasks = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_1.Location = new System.Drawing.Point(77, 54);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(185, 29);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Add Your Task";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btn_SubmitTask
            // 
            this.btn_SubmitTask.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitTask.Location = new System.Drawing.Point(372, 83);
            this.btn_SubmitTask.Name = "btn_SubmitTask";
            this.btn_SubmitTask.Size = new System.Drawing.Size(92, 38);
            this.btn_SubmitTask.TabIndex = 2;
            this.btn_SubmitTask.Text = "Submit";
            this.btn_SubmitTask.UseVisualStyleBackColor = true;
            this.btn_SubmitTask.Click += new System.EventHandler(this.btn_SubmitTask_Click);
            // 
            // btn_DeleteLastElem
            // 
            this.btn_DeleteLastElem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DeleteLastElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_DeleteLastElem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteLastElem.Location = new System.Drawing.Point(1028, 505);
            this.btn_DeleteLastElem.Name = "btn_DeleteLastElem";
            this.btn_DeleteLastElem.Size = new System.Drawing.Size(86, 37);
            this.btn_DeleteLastElem.TabIndex = 4;
            this.btn_DeleteLastElem.Text = "Delete The Last Element";
            this.btn_DeleteLastElem.UseVisualStyleBackColor = false;
            this.btn_DeleteLastElem.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_YourTasks
            // 
            this.lbl_YourTasks.AutoSize = true;
            this.lbl_YourTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_YourTasks.Location = new System.Drawing.Point(695, 49);
            this.lbl_YourTasks.Name = "lbl_YourTasks";
            this.lbl_YourTasks.Size = new System.Drawing.Size(135, 29);
            this.lbl_YourTasks.TabIndex = 5;
            this.lbl_YourTasks.Text = "Your Tasks";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(698, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 382);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1169, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_YourTasks);
            this.Controls.Add(this.btn_DeleteLastElem);
            this.Controls.Add(this.btn_SubmitTask);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_1);
            this.Name = "Form1";
            this.Text = "To Do App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_SubmitTask;
        private System.Windows.Forms.Button btn_DeleteLastElem;
        private System.Windows.Forms.Label lbl_YourTasks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

