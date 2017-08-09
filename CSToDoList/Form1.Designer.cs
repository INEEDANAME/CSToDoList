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
            this.components = new System.ComponentModel.Container();
            this.baseSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dtRemindDate = new System.Windows.Forms.DateTimePicker();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtTaskNotes = new System.Windows.Forms.TextBox();
            this.btnRemindDate = new System.Windows.Forms.Button();
            this.btnAssignTaskDue = new System.Windows.Forms.Button();
            this.btnShowSettings = new System.Windows.Forms.Button();
            this.txtToDoInput = new System.Windows.Forms.TextBox();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskStorageDataSet = new CSToDoList.TaskStorageDataSet();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.todoListHost = new System.Windows.Forms.SplitContainer();
            this.lbCategoryList = new System.Windows.Forms.ListBox();
            this.listsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskStorageDataSet1 = new CSToDoList.TaskStorageDataSet1();
            this.btnNewList = new System.Windows.Forms.Button();
            this.lbToDoList = new System.Windows.Forms.ListBox();
            this.tasksTableAdapter = new CSToDoList.TaskStorageDataSetTableAdapters.TasksTableAdapter();
            this.listsTableAdapter = new CSToDoList.TaskStorageDataSet1TableAdapters.ListsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).BeginInit();
            this.baseSplitContainer.Panel1.SuspendLayout();
            this.baseSplitContainer.Panel2.SuspendLayout();
            this.baseSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStorageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListHost)).BeginInit();
            this.todoListHost.Panel1.SuspendLayout();
            this.todoListHost.Panel2.SuspendLayout();
            this.todoListHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStorageDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // baseSplitContainer
            // 
            this.baseSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.baseSplitContainer.Name = "baseSplitContainer";
            this.baseSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // baseSplitContainer.Panel1
            // 
            this.baseSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.baseSplitContainer.Panel1.Controls.Add(this.dtRemindDate);
            this.baseSplitContainer.Panel1.Controls.Add(this.dtDueDate);
            this.baseSplitContainer.Panel1.Controls.Add(this.lblNotes);
            this.baseSplitContainer.Panel1.Controls.Add(this.txtTaskNotes);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnRemindDate);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnAssignTaskDue);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnShowSettings);
            this.baseSplitContainer.Panel1.Controls.Add(this.txtToDoInput);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnAddTodo);
            this.baseSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.baseSplitContainer_Panel1_Paint);
            // 
            // baseSplitContainer.Panel2
            // 
            this.baseSplitContainer.Panel2.Controls.Add(this.todoListHost);
            this.baseSplitContainer.Size = new System.Drawing.Size(624, 441);
            this.baseSplitContainer.SplitterDistance = 62;
            this.baseSplitContainer.TabIndex = 0;
            // 
            // dtRemindDate
            // 
            this.dtRemindDate.Location = new System.Drawing.Point(70, 173);
            this.dtRemindDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtRemindDate.Name = "dtRemindDate";
            this.dtRemindDate.Size = new System.Drawing.Size(151, 20);
            this.dtRemindDate.TabIndex = 8;
            // 
            // dtDueDate
            // 
            this.dtDueDate.Location = new System.Drawing.Point(70, 98);
            this.dtDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(138, 20);
            this.dtDueDate.TabIndex = 1;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(354, 71);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(68, 13);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Task Notes :";
            // 
            // txtTaskNotes
            // 
            this.txtTaskNotes.Location = new System.Drawing.Point(354, 89);
            this.txtTaskNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskNotes.Multiline = true;
            this.txtTaskNotes.Name = "txtTaskNotes";
            this.txtTaskNotes.Size = new System.Drawing.Size(251, 130);
            this.txtTaskNotes.TabIndex = 6;
            // 
            // btnRemindDate
            // 
            this.btnRemindDate.Location = new System.Drawing.Point(255, 181);
            this.btnRemindDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemindDate.Name = "btnRemindDate";
            this.btnRemindDate.Size = new System.Drawing.Size(78, 37);
            this.btnRemindDate.TabIndex = 5;
            this.btnRemindDate.Text = "Remind Date";
            this.btnRemindDate.UseVisualStyleBackColor = true;
            // 
            // btnAssignTaskDue
            // 
            this.btnAssignTaskDue.Location = new System.Drawing.Point(255, 89);
            this.btnAssignTaskDue.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignTaskDue.Name = "btnAssignTaskDue";
            this.btnAssignTaskDue.Size = new System.Drawing.Size(78, 40);
            this.btnAssignTaskDue.TabIndex = 4;
            this.btnAssignTaskDue.Text = "Assign Due Date";
            this.btnAssignTaskDue.UseVisualStyleBackColor = true;
            // 
            // btnShowSettings
            // 
            this.btnShowSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSettings.Location = new System.Drawing.Point(10, 20);
            this.btnShowSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowSettings.Name = "btnShowSettings";
            this.btnShowSettings.Size = new System.Drawing.Size(26, 28);
            this.btnShowSettings.TabIndex = 2;
            this.btnShowSettings.Text = "V";
            this.btnShowSettings.UseVisualStyleBackColor = true;
            this.btnShowSettings.Click += new System.EventHandler(this.btnShowSettings_Click);
            // 
            // txtToDoInput
            // 
            this.txtToDoInput.AcceptsReturn = true;
            this.txtToDoInput.BackColor = System.Drawing.SystemColors.Info;
            this.txtToDoInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToDoInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "taskName", true));
            this.txtToDoInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDoInput.Location = new System.Drawing.Point(70, 20);
            this.txtToDoInput.MaxLength = 256;
            this.txtToDoInput.Name = "txtToDoInput";
            this.txtToDoInput.Size = new System.Drawing.Size(457, 29);
            this.txtToDoInput.TabIndex = 1;
            this.txtToDoInput.WordWrap = false;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.taskStorageDataSet;
            // 
            // taskStorageDataSet
            // 
            this.taskStorageDataSet.DataSetName = "TaskStorageDataSet";
            this.taskStorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.AccessibleName = "Add To-Do";
            this.btnAddTodo.Location = new System.Drawing.Point(544, 11);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(60, 44);
            this.btnAddTodo.TabIndex = 0;
            this.btnAddTodo.Text = "Add To-Do";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // todoListHost
            // 
            this.todoListHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoListHost.Location = new System.Drawing.Point(0, 0);
            this.todoListHost.Name = "todoListHost";
            // 
            // todoListHost.Panel1
            // 
            this.todoListHost.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.todoListHost.Panel1.Controls.Add(this.lbCategoryList);
            this.todoListHost.Panel1.Controls.Add(this.btnNewList);
            // 
            // todoListHost.Panel2
            // 
            this.todoListHost.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.todoListHost.Panel2.Controls.Add(this.lbToDoList);
            this.todoListHost.Size = new System.Drawing.Size(624, 375);
            this.todoListHost.SplitterDistance = 207;
            this.todoListHost.TabIndex = 0;
            // 
            // lbCategoryList
            // 
            this.lbCategoryList.DataSource = this.listsBindingSource;
            this.lbCategoryList.DisplayMember = "ListName";
            this.lbCategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategoryList.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryList.FormattingEnabled = true;
            this.lbCategoryList.ItemHeight = 19;
            this.lbCategoryList.Location = new System.Drawing.Point(0, 0);
            this.lbCategoryList.Name = "lbCategoryList";
            this.lbCategoryList.Size = new System.Drawing.Size(207, 356);
            this.lbCategoryList.TabIndex = 1;
            this.lbCategoryList.ValueMember = "ListName";
            this.lbCategoryList.SelectedValueChanged += new System.EventHandler(this.ShowTasks);
            // 
            // listsBindingSource
            // 
            this.listsBindingSource.DataMember = "Lists";
            this.listsBindingSource.DataSource = this.taskStorageDataSet1;
            // 
            // taskStorageDataSet1
            // 
            this.taskStorageDataSet1.DataSetName = "TaskStorageDataSet1";
            this.taskStorageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNewList
            // 
            this.btnNewList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewList.Location = new System.Drawing.Point(0, 356);
            this.btnNewList.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(207, 19);
            this.btnNewList.TabIndex = 0;
            this.btnNewList.Text = "Create List";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // lbToDoList
            // 
            this.lbToDoList.DataSource = this.tasksBindingSource;
            this.lbToDoList.DisplayMember = "taskName";
            this.lbToDoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbToDoList.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToDoList.FormattingEnabled = true;
            this.lbToDoList.ItemHeight = 23;
            this.lbToDoList.Location = new System.Drawing.Point(0, 0);
            this.lbToDoList.Name = "lbToDoList";
            this.lbToDoList.Size = new System.Drawing.Size(413, 375);
            this.lbToDoList.TabIndex = 0;
            this.lbToDoList.ValueMember = "taskName";
            this.lbToDoList.SelectedIndexChanged += new System.EventHandler(this.lbToDoList_SelectedIndexChanged);
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // listsTableAdapter
            // 
            this.listsTableAdapter.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.baseSplitContainer);
            this.MinimumSize = new System.Drawing.Size(320, 237);
            this.Name = "MainWindow";
            this.Text = "C# To-Do List";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.baseSplitContainer.Panel1.ResumeLayout(false);
            this.baseSplitContainer.Panel1.PerformLayout();
            this.baseSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).EndInit();
            this.baseSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStorageDataSet)).EndInit();
            this.todoListHost.Panel1.ResumeLayout(false);
            this.todoListHost.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todoListHost)).EndInit();
            this.todoListHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStorageDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer baseSplitContainer;
        private System.Windows.Forms.SplitContainer todoListHost;
        private System.Windows.Forms.TextBox txtToDoInput;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.ListBox lbToDoList;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.Button btnShowSettings;
        private System.Windows.Forms.TextBox txtTaskNotes;
        private System.Windows.Forms.Button btnRemindDate;
        private System.Windows.Forms.Button btnAssignTaskDue;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DateTimePicker dtRemindDate;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.ListBox lbCategoryList;
        private TaskStorageDataSet taskStorageDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private TaskStorageDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private TaskStorageDataSet1 taskStorageDataSet1;
        private System.Windows.Forms.BindingSource listsBindingSource;
        private TaskStorageDataSet1TableAdapters.ListsTableAdapter listsTableAdapter;



    }
}

