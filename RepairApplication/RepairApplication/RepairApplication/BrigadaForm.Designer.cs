namespace RepairApplication
{
    partial class BrigadaForm
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
            this.brigadadataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.brigadadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // brigadadataGridView
            // 
            this.brigadadataGridView.AllowUserToAddRows = false;
            this.brigadadataGridView.AllowUserToDeleteRows = false;
            this.brigadadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brigadadataGridView.Location = new System.Drawing.Point(12, 12);
            this.brigadadataGridView.Name = "brigadadataGridView";
            this.brigadadataGridView.Size = new System.Drawing.Size(535, 213);
            this.brigadadataGridView.TabIndex = 0;
            // 
            // BrigadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 237);
            this.Controls.Add(this.brigadadataGridView);
            this.Name = "BrigadaForm";
            this.Text = "Бригады";
            ((System.ComponentModel.ISupportInitialize)(this.brigadadataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView brigadadataGridView;
    }
}