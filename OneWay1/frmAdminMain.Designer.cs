namespace OneWay1
{
    partial class frmAdminMain
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
            this.pnlLogbook = new System.Windows.Forms.Panel();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlLogbook
            // 
            this.pnlLogbook.Location = new System.Drawing.Point(12, 12);
            this.pnlLogbook.Name = "pnlLogbook";
            this.pnlLogbook.Size = new System.Drawing.Size(548, 585);
            this.pnlLogbook.TabIndex = 1;
            this.pnlLogbook.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogbook_Paint);
            // 
            // pnlRegister
            // 
            this.pnlRegister.Location = new System.Drawing.Point(566, 26);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(402, 537);
            this.pnlRegister.TabIndex = 2;
            this.pnlRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegister_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(864, 569);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(977, 627);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlLogbook);
            this.Name = "frmAdminMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogbook;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Button btnLogout;
    }
}