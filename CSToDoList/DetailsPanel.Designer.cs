namespace CSToDoList
{
    partial class DetailsPanel
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
            this.txtToDoNotes = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReminderDate = new System.Windows.Forms.Button();
            this.btnDueDate = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtToDoNotes
            // 
            this.txtToDoNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToDoNotes.Location = new System.Drawing.Point(12, 165);
            this.txtToDoNotes.Multiline = true;
            this.txtToDoNotes.Name = "txtToDoNotes";
            this.txtToDoNotes.Size = new System.Drawing.Size(362, 144);
            this.txtToDoNotes.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(175, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnReminderDate
            // 
            this.btnReminderDate.Location = new System.Drawing.Point(12, 102);
            this.btnReminderDate.Name = "btnReminderDate";
            this.btnReminderDate.Size = new System.Drawing.Size(118, 23);
            this.btnReminderDate.TabIndex = 11;
            this.btnReminderDate.Text = "Reminder Date";
            this.btnReminderDate.UseVisualStyleBackColor = true;
            // 
            // btnDueDate
            // 
            this.btnDueDate.Location = new System.Drawing.Point(12, 47);
            this.btnDueDate.Name = "btnDueDate";
            this.btnDueDate.Size = new System.Drawing.Size(118, 23);
            this.btnDueDate.TabIndex = 10;
            this.btnDueDate.Text = "Assign Due Date";
            this.btnDueDate.UseVisualStyleBackColor = true;
            this.btnDueDate.Click += new System.EventHandler(this.btnDueDate_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(13, 146);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(83, 13);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "To-Do Notes:";
            // 
            // DetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 321);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtToDoNotes);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnReminderDate);
            this.Controls.Add(this.btnDueDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetailsPanel";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "To-Do Details: ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToDoNotes;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnReminderDate;
        private System.Windows.Forms.Button btnDueDate;
        private System.Windows.Forms.Label lblNotes;

    }
}