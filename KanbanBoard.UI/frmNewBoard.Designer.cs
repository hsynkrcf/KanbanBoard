namespace KanbanBoard.UI
{
    partial class frmNewBoard
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBoardName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(201, 64);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(165, 46);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "OLUŞTUR";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBoardName
            // 
            this.txtBoardName.Location = new System.Drawing.Point(130, 23);
            this.txtBoardName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoardName.Name = "txtBoardName";
            this.txtBoardName.Size = new System.Drawing.Size(315, 22);
            this.txtBoardName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tahta Adı :";
            // 
            // frmNewBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 146);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBoardName);
            this.Controls.Add(this.label1);
            this.Name = "frmNewBoard";
            this.Text = "Yeni Tahta";
            this.Load += new System.EventHandler(this.frmNewBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBoardName;
        private System.Windows.Forms.Label label1;
    }
}