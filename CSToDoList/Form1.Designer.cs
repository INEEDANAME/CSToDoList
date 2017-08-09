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
            this.btnShowSettings = new System.Windows.Forms.Button();
            this.txtToDoInput = new System.Windows.Forms.TextBox();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.todoListHost = new System.Windows.Forms.SplitContainer();
            this.lbCategoryList = new System.Windows.Forms.ListBox();
            this.btnNewList = new System.Windows.Forms.Button();
            this.lbToDoList = new System.Windows.Forms.ListBox();
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
            this.btnAddTodo.Size = new System.Drawing.Size(107, 28);
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
            this.todoListHost.Size = new System.Drawing.Size(624, 387);
            this.todoListHost.SplitterDistance = 207;
            this.todoListHost.TabIndex = 0;
            // 
            // lbCategoryList
            // 
            this.lbCategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategoryList.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryList.FormattingEnabled = true;
            this.lbCategoryList.ItemHeight = 19;
            this.lbCategoryList.Location = new System.Drawing.Point(0, 0);
            this.lbCategoryList.Name = "lbCategoryList";
            this.lbCategoryList.Size = new System.Drawing.Size(207, 368);
            this.lbCategoryList.TabIndex = 1;
            this.lbCategoryList.ValueMember = "ListName";
            this.lbCategoryList.SelectedValueChanged += new System.EventHandler(this.ShowTasks);
            // 
            // btnNewList
            // 
            this.btnNewList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewList.Location = new System.Drawing.Point(0, 368);
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
            this.lbToDoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbToDoList.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToDoList.FormattingEnabled = true;
            this.lbToDoList.ItemHeight = 23;
            this.lbToDoList.Location = new System.Drawing.Point(0, 0);
            this.lbToDoList.Name = "lbToDoList";
            this.lbToDoList.Size = new System.Drawing.Size(413, 387);
            this.lbToDoList.TabIndex = 0;
            this.lbToDoList.ValueMember = "taskName";
            this.lbToDoList.SelectedIndexChanged += new System.EventHandler(this.lbToDoList_SelectedIndexChanged);
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
            this.todoListHost.Panel1.ResumeLayout(false);
            this.todoListHost.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todoListHost)).EndInit();
            this.todoListHost.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lbCategoryList;



    }
}

