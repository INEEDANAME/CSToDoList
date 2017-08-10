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
            this.btnShowSettings = new System.Windows.Forms.Button();
            this.txtToDoInput = new System.Windows.Forms.TextBox();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.todoListHost = new System.Windows.Forms.SplitContainer();
            this.btnNewList = new System.Windows.Forms.Button();
            this.lbCategoryList = new System.Windows.Forms.ListBox();
            this.listsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoDataSet = new CSToDoList.TodoDataSet();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.listTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listsTableAdapter = new CSToDoList.TodoDataSetTableAdapters.ListsTableAdapter();
            this.tasksTableAdapter = new CSToDoList.TodoDataSetTableAdapters.TasksTableAdapter();
            this.listTasksTableAdapter = new CSToDoList.TodoDataSetTableAdapters.ListTasksTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.listTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
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
            this.baseSplitContainer.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.baseSplitContainer.Panel1.Controls.Add(this.btnShowSettings);
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
            // btnShowSettings
            // 
            this.btnShowSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSettings.Location = new System.Drawing.Point(11, 11);
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
            this.txtToDoInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDoInput.Location = new System.Drawing.Point(42, 11);
            this.txtToDoInput.MaxLength = 256;
            this.txtToDoInput.Name = "txtToDoInput";
            this.txtToDoInput.Size = new System.Drawing.Size(457, 29);
            this.txtToDoInput.TabIndex = 1;
            this.txtToDoInput.WordWrap = false;
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.AccessibleName = "Add To-Do";
            this.btnAddTodo.Location = new System.Drawing.Point(505, 13);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(107, 26);
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
            this.todoListHost.Panel1.Controls.Add(this.btnNewList);
            this.todoListHost.Panel1.Controls.Add(this.lbCategoryList);
            // 
            // todoListHost.Panel2
            // 
            this.todoListHost.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.todoListHost.Panel2.Controls.Add(this.lbTasks);
            this.todoListHost.Size = new System.Drawing.Size(624, 382);
            this.todoListHost.SplitterDistance = 207;
            this.todoListHost.TabIndex = 0;
            // 
            // btnNewList
            // 
            this.btnNewList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewList.Location = new System.Drawing.Point(0, 356);
            this.btnNewList.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(207, 26);
            this.btnNewList.TabIndex = 2;
            this.btnNewList.Text = "Create List";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
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
            this.lbCategoryList.Size = new System.Drawing.Size(207, 382);
            this.lbCategoryList.TabIndex = 1;
            this.lbCategoryList.ValueMember = "ListName";
            this.lbCategoryList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowTasks);
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
            this.lbTasks.DataSource = this.listTasksBindingSource;
            this.lbTasks.DisplayMember = "taskName";
            this.lbTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTasks.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 23;
            this.lbTasks.Location = new System.Drawing.Point(0, 0);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(413, 382);
            this.lbTasks.TabIndex = 0;
            this.lbTasks.ValueMember = "taskName";
            this.lbTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowTaskDetails);
            // 
            // listTasksBindingSource
            // 
            this.listTasksBindingSource.DataMember = "ListTasks";
            this.listTasksBindingSource.DataSource = this.todoDataSet;
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
            // listTasksTableAdapter
            // 
            this.listTasksTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.listTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer baseSplitContainer;
        private System.Windows.Forms.SplitContainer todoListHost;
        private System.Windows.Forms.TextBox txtToDoInput;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.Button btnShowSettings;
        private System.Windows.Forms.ListBox lbCategoryList;
        private System.Windows.Forms.Button btnNewList;
        private TodoDataSet todoDataSet;
        private System.Windows.Forms.BindingSource listsBindingSource;
        private TodoDataSetTableAdapters.ListsTableAdapter listsTableAdapter;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private TodoDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.BindingSource listTasksBindingSource;
        private TodoDataSetTableAdapters.ListTasksTableAdapter listTasksTableAdapter;



    }
}

