namespace KanbanBoard.UI
{
    partial class frmBoard
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
            this.pnlDone = new System.Windows.Forms.Panel();
            this.pnlDoing = new System.Windows.Forms.Panel();
            this.pnlToDo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDone
            // 
            this.pnlDone.AllowDrop = true;
            this.pnlDone.Location = new System.Drawing.Point(685, 103);
            this.pnlDone.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(232, 478);
            this.pnlDone.TabIndex = 19;
            this.pnlDone.Tag = "3";
            this.pnlDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragDrop);
            this.pnlDone.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragOver);
            // 
            // pnlDoing
            // 
            this.pnlDoing.AllowDrop = true;
            this.pnlDoing.Location = new System.Drawing.Point(359, 103);
            this.pnlDoing.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDoing.Name = "pnlDoing";
            this.pnlDoing.Size = new System.Drawing.Size(232, 478);
            this.pnlDoing.TabIndex = 20;
            this.pnlDoing.Tag = "2";
            this.pnlDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragDrop);
            this.pnlDoing.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragOver);
            // 
            // pnlToDo
            // 
            this.pnlToDo.AllowDrop = true;
            this.pnlToDo.Location = new System.Drawing.Point(51, 103);
            this.pnlToDo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlToDo.Name = "pnlToDo";
            this.pnlToDo.Size = new System.Drawing.Size(232, 478);
            this.pnlToDo.TabIndex = 21;
            this.pnlToDo.Tag = "1";
            this.pnlToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragDrop);
            this.pnlToDo.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragOver);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "DONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "DOING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "TO DO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(619, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 571);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(309, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 571);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(37, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 16);
            this.panel1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.updateBoardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(989, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newTaskToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.newTaskToolStripMenuItem.Text = "Yeni Görev";
            this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.newTaskToolStripMenuItem_Click);
            // 
            // updateBoardToolStripMenuItem
            // 
            this.updateBoardToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateBoardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateBoardToolStripMenuItem.Name = "updateBoardToolStripMenuItem";
            this.updateBoardToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.updateBoardToolStripMenuItem.Text = "Tahta İsmini Değiştir";
            this.updateBoardToolStripMenuItem.Click += new System.EventHandler(this.updateBoardToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 52);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(989, 603);
            this.Controls.Add(this.pnlDone);
            this.Controls.Add(this.pnlDoing);
            this.Controls.Add(this.pnlToDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBoard";
            this.Text = "TAHTA";
            this.Load += new System.EventHandler(this.frmBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.Panel pnlDoing;
        private System.Windows.Forms.Panel pnlToDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBoardToolStripMenuItem;
    }
}