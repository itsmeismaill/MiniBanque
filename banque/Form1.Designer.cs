namespace banque
{
    partial class Form1
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
            this.grd = new System.Windows.Forms.DataGridView();
            this.comboBoxComptes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AllButton = new System.Windows.Forms.RadioButton();
            this.CreditButton = new System.Windows.Forms.RadioButton();
            this.DebitButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(77, 191);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(558, 151);
            this.grd.TabIndex = 0;
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            // 
            // comboBoxComptes
            // 
            this.comboBoxComptes.FormattingEnabled = true;
            this.comboBoxComptes.Location = new System.Drawing.Point(147, 46);
            this.comboBoxComptes.Name = "comboBoxComptes";
            this.comboBoxComptes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComptes.TabIndex = 1;
            this.comboBoxComptes.SelectedIndexChanged += new System.EventHandler(this.comboBoxComptes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comptes:";
            // 
            // AllButton
            // 
            this.AllButton.AutoSize = true;
            this.AllButton.Location = new System.Drawing.Point(152, 144);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(36, 17);
            this.AllButton.TabIndex = 3;
            this.AllButton.TabStop = true;
            this.AllButton.Text = "All";
            this.AllButton.UseVisualStyleBackColor = true;
            this.AllButton.CheckedChanged += new System.EventHandler(this.AllButton_CheckedChanged);
            // 
            // CreditButton
            // 
            this.CreditButton.AutoSize = true;
            this.CreditButton.Location = new System.Drawing.Point(231, 143);
            this.CreditButton.Name = "CreditButton";
            this.CreditButton.Size = new System.Drawing.Size(52, 17);
            this.CreditButton.TabIndex = 4;
            this.CreditButton.TabStop = true;
            this.CreditButton.Text = "Credit";
            this.CreditButton.UseVisualStyleBackColor = true;
            this.CreditButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // DebitButton
            // 
            this.DebitButton.AutoSize = true;
            this.DebitButton.Location = new System.Drawing.Point(310, 143);
            this.DebitButton.Name = "DebitButton";
            this.DebitButton.Size = new System.Drawing.Size(50, 17);
            this.DebitButton.TabIndex = 5;
            this.DebitButton.TabStop = true;
            this.DebitButton.Text = "Debit";
            this.DebitButton.UseVisualStyleBackColor = true;
            this.DebitButton.CheckedChanged += new System.EventHandler(this.DebitButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Solde:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Location = new System.Drawing.Point(434, 49);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(13, 13);
            this.lblSolde.TabIndex = 8;
            this.lblSolde.Text = "..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DebitButton);
            this.Controls.Add(this.CreditButton);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxComptes);
            this.Controls.Add(this.grd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.ComboBox comboBoxComptes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton AllButton;
        private System.Windows.Forms.RadioButton CreditButton;
        private System.Windows.Forms.RadioButton DebitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSolde;
    }
}

