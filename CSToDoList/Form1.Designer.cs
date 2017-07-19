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
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.todoListHost = new System.Windows.Forms.SplitContainer();
            this.lbToDoList = new System.Windows.Forms.ListBox();
            this.txtBToDoInput = new System.Windows.Forms.TextBox();
            this.createList = new System.Windows.Forms.Button();
            this.showListDetailslb = new System.Windows.Forms.ListBox();
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
            this.baseSplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baseSplitContainer.Name = "baseSplitContainer";
            this.baseSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // baseSplitContainer.Panel1
            // 
            this.baseSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.baseSplitContainer.Panel1.Controls.Add(this.createList);
            this.baseSplitContainer.Panel1.Controls.Add(this.txtBToDoInput);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnAddTodo);
            this.baseSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.baseSplitContainer_Panel1_Paint);
            // 
            // baseSplitContainer.Panel2
            // 
            this.baseSplitContainer.Panel2.Controls.Add(this.todoListHost);
            this.baseSplitContainer.Size = new System.Drawing.Size(827, 577);
            this.baseSplitContainer.SplitterDistance = 126;
            this.baseSplitContainer.SplitterWidth = 5;
            this.baseSplitContainer.TabIndex = 0;
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.AccessibleName = "Add To-Do";
            this.btnAddTodo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTodo.Location = new System.Drawing.Point(734, 21);
            this.btnAddTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(80, 76);
            this.btnAddTodo.TabIndex = 0;
            this.btnAddTodo.Text = "Add To-Do";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // todoListHost
            // 
            this.todoListHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoListHost.Location = new System.Drawing.Point(0, 0);
            this.todoListHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.todoListHost.Name = "todoListHost";
            // 
            // todoListHost.Panel1
            // 
            this.todoListHost.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.todoListHost.Panel1.Controls.Add(this.showListDetailslb);
            // 
            // todoListHost.Panel2
            // 
            this.todoListHost.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.todoListHost.Panel2.Controls.Add(this.lbToDoList);
            this.todoListHost.Size = new System.Drawing.Size(827, 446);
            this.todoListHost.SplitterDistance = 187;
            this.todoListHost.SplitterWidth = 5;
            this.todoListHost.TabIndex = 0;
            // 
            // lbToDoList
            // 
            this.lbToDoList.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToDoList.FormattingEnabled = true;
            this.lbToDoList.ItemHeight = 29;
            this.lbToDoList.Location = new System.Drawing.Point(21, 22);
            this.lbToDoList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbToDoList.Name = "lbToDoList";
            this.lbToDoList.Size = new System.Drawing.Size(522, 410);
            this.lbToDoList.TabIndex = 0;
            this.lbToDoList.SelectedIndexChanged += new System.EventHandler(this.lbToDoList_SelectedIndexChanged);
            // 
            // txtBToDoInput
            // 
            this.txtBToDoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBToDoInput.Location = new System.Drawing.Point(213, 41);
            this.txtBToDoInput.Name = "txtBToDoInput";
            this.txtBToDoInput.Size = new System.Drawing.Size(503, 30);
            this.txtBToDoInput.TabIndex = 1;
            this.txtBToDoInput.TextChanged += new System.EventHandler(this.txtBToDoInput_TextChanged);
            // 
            // createList
            // 
            this.createList.AccessibleName = "Create To-Do";
            this.createList.AutoSize = true;
            this.createList.Location = new System.Drawing.Point(46, 31);
            this.createList.Name = "createList";
            this.createList.Size = new System.Drawing.Size(86, 56);
            this.createList.TabIndex = 2;
            this.createList.Text = "Create List";
            this.createList.UseVisualStyleBackColor = true;
            this.createList.Click += new System.EventHandler(this.createList_Click);
            // 
            // showListDetailslb
            // 
            this.showListDetailslb.FormattingEnabled = true;
            this.showListDetailslb.ItemHeight = 16;
            this.showListDetailslb.Location = new System.Drawing.Point(12, 22);
            this.showListDetailslb.Name = "showListDetailslb";
            this.showListDetailslb.Size = new System.Drawing.Size(221, 404);
            this.showListDetailslb.TabIndex = 0;
            this.showListDetailslb.SelectedIndexChanged += new System.EventHandler(this.showListDetailslb_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(827, 577);
            this.Controls.Add(this.baseSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.ListBox lbToDoList;
        private System.Windows.Forms.TextBox txtBToDoInput;
        private System.Windows.Forms.Button createList;
        private System.Windows.Forms.ListBox showListDetailslb;



    }
}

