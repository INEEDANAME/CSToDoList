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
            this.todoListHost = new System.Windows.Forms.SplitContainer();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.txtbToDoInput = new System.Windows.Forms.TextBox();
            this.lbToDoList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).BeginInit();
            this.baseSplitContainer.Panel1.SuspendLayout();
            this.baseSplitContainer.Panel2.SuspendLayout();
            this.baseSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoListHost)).BeginInit();
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
            this.baseSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.baseSplitContainer.Panel1.Controls.Add(this.txtbToDoInput);
            this.baseSplitContainer.Panel1.Controls.Add(this.btnAddTodo);
            // 
            // baseSplitContainer.Panel2
            // 
            this.baseSplitContainer.Panel2.Controls.Add(this.todoListHost);
            this.baseSplitContainer.Size = new System.Drawing.Size(624, 441);
            this.baseSplitContainer.SplitterDistance = 97;
            this.baseSplitContainer.TabIndex = 0;
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
            // 
            // todoListHost.Panel2
            // 
            this.todoListHost.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.todoListHost.Panel2.Controls.Add(this.lbToDoList);
            this.todoListHost.Size = new System.Drawing.Size(624, 340);
            this.todoListHost.SplitterDistance = 208;
            this.todoListHost.TabIndex = 0;
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.AccessibleName = "Add To-Do";
            this.btnAddTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTodo.Location = new System.Drawing.Point(552, 12);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(60, 72);
            this.btnAddTodo.TabIndex = 0;
            this.btnAddTodo.Text = "Add To-Do";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            // 
            // txtbToDoInput
            // 
            this.txtbToDoInput.AcceptsReturn = true;
            this.txtbToDoInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbToDoInput.BackColor = System.Drawing.SystemColors.Info;
            this.txtbToDoInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbToDoInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbToDoInput.Location = new System.Drawing.Point(12, 31);
            this.txtbToDoInput.MaxLength = 256;
            this.txtbToDoInput.Name = "txtbToDoInput";
            this.txtbToDoInput.Size = new System.Drawing.Size(534, 29);
            this.txtbToDoInput.TabIndex = 1;
            this.txtbToDoInput.WordWrap = false;
            // 
            // lbToDoList
            // 
            this.lbToDoList.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToDoList.FormattingEnabled = true;
            this.lbToDoList.ItemHeight = 23;
            this.lbToDoList.Location = new System.Drawing.Point(16, 18);
            this.lbToDoList.Name = "lbToDoList";
            this.lbToDoList.Size = new System.Drawing.Size(384, 303);
            this.lbToDoList.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.baseSplitContainer);
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "MainWindow";
            this.Text = "C# To-Do List";
            this.baseSplitContainer.Panel1.ResumeLayout(false);
            this.baseSplitContainer.Panel1.PerformLayout();
            this.baseSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseSplitContainer)).EndInit();
            this.baseSplitContainer.ResumeLayout(false);
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



    }
}

