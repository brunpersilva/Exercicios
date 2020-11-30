namespace Veterinary
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
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBreed = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBreed = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCarregar = new System.Windows.Forms.Button();
            this.labelCarregar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(139, 220);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(28, 13);
            this.labelBirth.TabIndex = 0;
            this.labelBirth.Text = "Birth";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(139, 187);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelBreed
            // 
            this.labelBreed.AutoSize = true;
            this.labelBreed.Location = new System.Drawing.Point(139, 246);
            this.labelBreed.Name = "labelBreed";
            this.labelBreed.Size = new System.Drawing.Size(35, 13);
            this.labelBreed.TabIndex = 2;
            this.labelBreed.Text = "Breed";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(152, 339);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(189, 220);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBirth.TabIndex = 7;
            // 
            // comboBoxBreed
            // 
            this.comboBoxBreed.FormattingEnabled = true;
            this.comboBoxBreed.Items.AddRange(new object[] {
            "Pinsher",
            "Pug",
            "Shepherd"});
            this.comboBoxBreed.Location = new System.Drawing.Point(189, 246);
            this.comboBoxBreed.Name = "comboBoxBreed";
            this.comboBoxBreed.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBreed.TabIndex = 8;
            this.comboBoxBreed.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(189, 187);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dog Registration";
            // 
            // buttonCarregar
            // 
            this.buttonCarregar.Location = new System.Drawing.Point(536, 339);
            this.buttonCarregar.Name = "buttonCarregar";
            this.buttonCarregar.Size = new System.Drawing.Size(75, 23);
            this.buttonCarregar.TabIndex = 11;
            this.buttonCarregar.Text = "Carregar Banco";
            this.buttonCarregar.UseVisualStyleBackColor = true;
            this.buttonCarregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCarregar
            // 
            this.labelCarregar.AutoSize = true;
            this.labelCarregar.Location = new System.Drawing.Point(533, 286);
            this.labelCarregar.Name = "labelCarregar";
            this.labelCarregar.Size = new System.Drawing.Size(69, 13);
            this.labelCarregar.TabIndex = 12;
            this.labelCarregar.Text = "labelCarregar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCarregar);
            this.Controls.Add(this.buttonCarregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxBreed);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelBreed);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelBirth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBreed;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.ComboBox comboBoxBreed;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCarregar;
        private System.Windows.Forms.Label labelCarregar;
    }
}

