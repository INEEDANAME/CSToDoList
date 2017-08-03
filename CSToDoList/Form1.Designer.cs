namespace CSToDoList
{
    partial class MainWindow
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
            this.baseSplitContainer = new System.Windows.Forms.SplitContainer();
            this.lblNotes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRemindDate = new System.Windows.Forms.Button();
            this.btnAssignTaskDue = new System.Windows.Forms.Button();
            this.btnShowSettings = new System.Windows.Forms.Button();
            this.txtbToDoInput = new System.Windows.Forms.TextBox();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.todoListHost = new System.Windows.Forms.SplitContainer();
            this.btnNewList = new System.Windows.Forms.Button();
            this.lbToDoList = new System.Windows.Forms.ListBox();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtRemindDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).BeginInit();
            this.baseSplitContainer.Panel1.SuspendLayout();
            this.baseSplitContainer.Panel2.SuspendLayout();
            this.baseSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoListHost)).BeginInit();
            this.todoListHost.Panel1.SuspendLayout();
            this.todoListHost.Panel2.SuspendLayout();
            this.todoListHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseSplitContainer
            // 
            this.baseSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.baseSplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.baseSplitContainer.Name = "baseSplitContainer";
            this.baseSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // baseSplitContainer.Panel1
            // 
            this.baseSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.baseSplitContainer.Panel1.Controls.Add(this.dtRemindDate);
            this.baseSplitContainer.Panel1.Controls.Add(this.dtDueDate);
            this.baseSplitContainer.Panel1.Controls.Add(this.lblNotes);
            this.baseSplitContainer.Panel1.Controls.Add(this.textBox1);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnRemindDate);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnAssignTaskDue);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnShowSettings);
            this.baseSplitContainer.Panel1.Controls.Add(this.txtbToDoInput);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnAddTodo);
            this.baseSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.baseSplitContainer_Panel1_Paint);
            // 
            // baseSplitContainer.Panel2
            // 
            this.baseSplitContainer.Panel2.Controls.Add(this.todoListHost);
            this.baseSplitContainer.Size = new System.Drawing.Size(832, 543);
            this.baseSplitContainer.SplitterDistance = 237;
            this.baseSplitContainer.SplitterWidth = 5;
            this.baseSplitContainer.TabIndex = 0;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(472, 87);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(88, 17);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Task Notes :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 159);
            this.textBox1.TabIndex = 6;
            // 
            // btnRemindDate
            // 
            this.btnRemindDate.Location = new System.Drawing.Point(340, 223);
            this.btnRemindDate.Name = "btnRemindDate";
            this.btnRemindDate.Size = new System.Drawing.Size(104, 46);
            this.btnRemindDate.TabIndex = 5;
            this.btnRemindDate.Text = "Remind Date";
            this.btnRemindDate.UseVisualStyleBackColor = true;
            // 
            // btnAssignTaskDue
            // 
            this.btnAssignTaskDue.Location = new System.Drawing.Point(340, 110);
            this.btnAssignTaskDue.Name = "btnAssignTaskDue";
            this.btnAssignTaskDue.Size = new System.Drawing.Size(104, 49);
            this.btnAssignTaskDue.TabIndex = 4;
            this.btnAssignTaskDue.Text = "Assign Due Date";
            this.btnAssignTaskDue.UseVisualStyleBackColor = true;
            // 
            // btnShowSettings
            // 
            this.btnShowSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSettings.Location = new System.Drawing.Point(13, 24);
            this.btnShowSettings.Name = "btnShowSettings";
            this.btnShowSettings.Size = new System.Drawing.Size(35, 35);
            this.btnShowSettings.TabIndex = 2;
            this.btnShowSettings.Text = "V";
            this.btnShowSettings.UseVisualStyleBackColor = true;
            this.btnShowSettings.Click += new System.EventHandler(this.btnShowSettings_Click);
            // 
            // txtbToDoInput
            // 
            this.txtbToDoInput.AcceptsReturn = true;
            this.txtbToDoInput.BackColor = System.Drawing.SystemColors.Info;
            this.txtbToDoInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbToDoInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbToDoInput.Location = new System.Drawing.Point(94, 24);
            this.txtbToDoInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtbToDoInput.MaxLength = 256;
            this.txtbToDoInput.Name = "txtbToDoInput";
            this.txtbToDoInput.Size = new System.Drawing.Size(609, 35);
            this.txtbToDoInput.TabIndex = 1;
            this.txtbToDoInput.WordWrap = false;
            this.txtbToDoInput.TextChanged += new System.EventHandler(this.txtbToDoInput_TextChanged);
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.AccessibleName = "Add To-Do";
            this.btnAddTodo.Location = new System.Drawing.Point(725, 13);
            this.btnAddTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(80, 54);
            this.btnAddTodo.TabIndex = 0;
            this.btnAddTodo.Text = "Add To-Do";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // todoListHost
            // 
            this.todoListHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoListHost.Location = new System.Drawing.Point(0, 0);
            this.todoListHost.Margin = new System.Windows.Forms.Padding(4);
            this.todoListHost.Name = "todoListHost";
            // 
            // todoListHost.Panel1
            // 
            this.todoListHost.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.todoListHost.Panel1.Controls.Add(this.btnNewList);
            // 
            // todoListHost.Panel2
            // 
            this.todoListHost.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.todoListHost.Panel2.Controls.Add(this.lbToDoList);
            this.todoListHost.Size = new System.Drawing.Size(832, 301);
            this.todoListHost.SplitterDistance = 277;
            this.todoListHost.SplitterWidth = 5;
            this.todoListHost.TabIndex = 0;
            // 
            // btnNewList
            // 
            this.btnNewList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewList.Location = new System.Drawing.Point(0, 278);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(277, 23);
            this.btnNewList.TabIndex = 0;
            this.btnNewList.Text = "Create List";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // lbToDoList
            // 
            this.lbToDoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbToDoList.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToDoList.FormattingEnabled = true;
            this.lbToDoList.ItemHeight = 29;
            this.lbToDoList.Location = new System.Drawing.Point(0, 0);
            this.lbToDoList.Margin = new System.Windows.Forms.Padding(4);
            this.lbToDoList.Name = "lbToDoList";
            this.lbToDoList.Size = new System.Drawing.Size(550, 301);
            this.lbToDoList.TabIndex = 0;
            this.lbToDoList.SelectedIndexChanged += new System.EventHandler(this.lbToDoList_SelectedIndexChanged);
            // 
            // dtDueDate
            // 
            this.dtDueDate.Location = new System.Drawing.Point(94, 121);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(183, 22);
            this.dtDueDate.TabIndex = 1;
            // 
            // dtRemindDate
            // 
            this.dtRemindDate.Location = new System.Drawing.Point(94, 213);
            this.dtRemindDate.Name = "dtRemindDate";
            this.dtRemindDate.Size = new System.Drawing.Size(200, 22);
            this.dtRemindDate.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.baseSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(421, 285);
            this.Name = "MainWindow";
            this.Text = "C# To-Do List";
            this.baseSplitContainer.Panel1.ResumeLayout(false);
            this.baseSplitContainer.Panel1.PerformLayout();
            this.baseSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).EndInit();
            this.baseSplitContainer.ResumeLayout(false);
            this.todoListHost.Panel1.ResumeLayout(false);
            this.todoListHost.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todoListHost)).EndInit();
            this.todoListHost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer baseSplitContainer;
        private System.Windows.Forms.SplitContainer todoListHost;
        private System.Windows.Forms.TextBox txtbToDoInput;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.ListBox lbToDoList;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.Button btnShowSettings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRemindDate;
        private System.Windows.Forms.Button btnAssignTaskDue;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DateTimePicker dtRemindDate;
        private System.Windows.Forms.DateTimePicker dtDueDate;



    }
}

