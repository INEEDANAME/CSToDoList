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
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.txtToDoInput = new System.Windows.Forms.TextBox();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.todoListHost = new System.Windows.Forms.SplitContainer();
            this.btnNewList = new System.Windows.Forms.Button();
            this.lbCategoryList = new System.Windows.Forms.ListBox();
            this.listsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoDataSet = new CSToDoList.TodoDataSet();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listsTableAdapter = new CSToDoList.TodoDataSetTableAdapters.ListsTableAdapter();
            this.tasksTableAdapter = new CSToDoList.TodoDataSetTableAdapters.TasksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).BeginInit();
            this.baseSplitContainer.Panel1.SuspendLayout();
            this.baseSplitContainer.Panel2.SuspendLayout();
            this.baseSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoListHost)).BeginInit();
            this.todoListHost.Panel1.SuspendLayout();
            this.todoListHost.Panel2.SuspendLayout();
            this.todoListHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseSplitContainer
            // 
            this.baseSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseSplitContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baseSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.baseSplitContainer.IsSplitterFixed = true;
            this.baseSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.baseSplitContainer.Name = "baseSplitContainer";
            this.baseSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // baseSplitContainer.Panel1
            // 
            this.baseSplitContainer.Panel1.BackColor = System.Drawing.Color.Azure;
            this.baseSplitContainer.Panel1.Controls.Add(this.btnCompleteTask);
            this.baseSplitContainer.Panel1.Controls.Add(this.txtToDoInput);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnAddTodo);
            // 
            // baseSplitContainer.Panel2
            // 
            this.baseSplitContainer.Panel2.Controls.Add(this.todoListHost);
            this.baseSplitContainer.Size = new System.Drawing.Size(624, 441);
            this.baseSplitContainer.SplitterDistance = 55;
            this.baseSplitContainer.TabIndex = 0;
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteTask.Location = new System.Drawing.Point(11, 11);
            this.btnCompleteTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(26, 28);
            this.btnCompleteTask.TabIndex = 2;
            this.btnCompleteTask.Text = "✔";
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // txtToDoInput
            // 
            this.txtToDoInput.AcceptsReturn = true;
            this.txtToDoInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToDoInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtToDoInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToDoInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDoInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtToDoInput.Location = new System.Drawing.Point(42, 11);
            this.txtToDoInput.MaxLength = 256;
            this.txtToDoInput.Name = "txtToDoInput";
            this.txtToDoInput.Size = new System.Drawing.Size(453, 29);
            this.txtToDoInput.TabIndex = 1;
            this.txtToDoInput.WordWrap = false;
            this.txtToDoInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddToDo);
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.AccessibleName = "Add To-Do";
            this.btnAddTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTodo.AutoSize = true;
            this.btnAddTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTodo.Location = new System.Drawing.Point(501, 15);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(107, 23);
            this.btnAddTodo.TabIndex = 0;
            this.btnAddTodo.Text = "Add To-Do";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // todoListHost
            // 
            this.todoListHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoListHost.Location = new System.Drawing.Point(0, 0);
            this.todoListHost.Name = "todoListHost";
            // 
            // todoListHost.Panel1
            // 
            this.todoListHost.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.todoListHost.Panel1.Controls.Add(this.btnNewList);
            this.todoListHost.Panel1.Controls.Add(this.lbCategoryList);
            // 
            // todoListHost.Panel2
            // 
            this.todoListHost.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.todoListHost.Panel2.Controls.Add(this.lbTasks);
            this.todoListHost.Size = new System.Drawing.Size(620, 378);
            this.todoListHost.SplitterDistance = 205;
            this.todoListHost.TabIndex = 0;
            // 
            // btnNewList
            // 
            this.btnNewList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewList.Location = new System.Drawing.Point(0, 352);
            this.btnNewList.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(205, 26);
            this.btnNewList.TabIndex = 2;
            this.btnNewList.Text = "Create List";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // lbCategoryList
            // 
            this.lbCategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCategoryList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbCategoryList.DataSource = this.listsBindingSource;
            this.lbCategoryList.DisplayMember = "ListName";
            this.lbCategoryList.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryList.FormattingEnabled = true;
            this.lbCategoryList.ItemHeight = 19;
            this.lbCategoryList.Location = new System.Drawing.Point(0, 0);
            this.lbCategoryList.Name = "lbCategoryList";
            this.lbCategoryList.Size = new System.Drawing.Size(205, 365);
            this.lbCategoryList.TabIndex = 1;
            this.lbCategoryList.ValueMember = "ListName";
            // 
            // listsBindingSource
            // 
            this.listsBindingSource.DataMember = "Lists";
            this.listsBindingSource.DataSource = this.todoDataSet;
            // 
            // todoDataSet
            // 
            this.todoDataSet.DataSetName = "TodoDataSet";
            this.todoDataSet.EnforceConstraints = false;
            this.todoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbTasks
            // 
            this.lbTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTasks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbTasks.DataSource = this.tasksBindingSource;
            this.lbTasks.DisplayMember = "taskName";
            this.lbTasks.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 16;
            this.lbTasks.Location = new System.Drawing.Point(0, 0);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(411, 372);
            this.lbTasks.TabIndex = 0;
            this.lbTasks.ValueMember = "taskName";
            this.lbTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowTaskDetails);
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.todoDataSet;
            // 
            // listsTableAdapter
            // 
            this.listsTableAdapter.ClearBeforeFill = true;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
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
            this.Activated += new System.EventHandler(this.RefreshDataSet);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.baseSplitContainer.Panel1.ResumeLayout(false);
            this.baseSplitContainer.Panel1.PerformLayout();
            this.baseSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).EndInit();
            this.baseSplitContainer.ResumeLayout(false);
            this.todoListHost.Panel1.ResumeLayout(false);
            this.todoListHost.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todoListHost)).EndInit();
            this.todoListHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer baseSplitContainer;
        private System.Windows.Forms.SplitContainer todoListHost;
        private System.Windows.Forms.TextBox txtToDoInput;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.ListBox lbCategoryList;
        private System.Windows.Forms.Button btnNewList;
        private TodoDataSet todoDataSet;
        private System.Windows.Forms.BindingSource listsBindingSource;
        private TodoDataSetTableAdapters.ListsTableAdapter listsTableAdapter;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private TodoDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;



    }
}

