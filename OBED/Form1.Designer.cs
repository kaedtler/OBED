namespace OBED
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.latitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.longitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.westRadioButton = new System.Windows.Forms.RadioButton();
            this.southRadioButton = new System.Windows.Forms.RadioButton();
            this.eastRadioButton = new System.Windows.Forms.RadioButton();
            this.northRadioButton = new System.Windows.Forms.RadioButton();
            this.downloadButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.previewButton = new System.Windows.Forms.Button();
            this.delBlackBorderCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.latitudeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longitudeNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude";
            // 
            // latitudeNumericUpDown
            // 
            this.latitudeNumericUpDown.DecimalPlaces = 15;
            this.latitudeNumericUpDown.Location = new System.Drawing.Point(87, 12);
            this.latitudeNumericUpDown.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.latitudeNumericUpDown.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.latitudeNumericUpDown.Name = "latitudeNumericUpDown";
            this.latitudeNumericUpDown.Size = new System.Drawing.Size(140, 20);
            this.latitudeNumericUpDown.TabIndex = 0;
            // 
            // longitudeNumericUpDown
            // 
            this.longitudeNumericUpDown.DecimalPlaces = 15;
            this.longitudeNumericUpDown.Location = new System.Drawing.Point(87, 41);
            this.longitudeNumericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.longitudeNumericUpDown.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.longitudeNumericUpDown.Name = "longitudeNumericUpDown";
            this.longitudeNumericUpDown.Size = new System.Drawing.Size(140, 20);
            this.longitudeNumericUpDown.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.westRadioButton);
            this.groupBox1.Controls.Add(this.southRadioButton);
            this.groupBox1.Controls.Add(this.eastRadioButton);
            this.groupBox1.Controls.Add(this.northRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Richtung";
            // 
            // westRadioButton
            // 
            this.westRadioButton.AutoSize = true;
            this.westRadioButton.Location = new System.Drawing.Point(157, 19);
            this.westRadioButton.Name = "westRadioButton";
            this.westRadioButton.Size = new System.Drawing.Size(50, 17);
            this.westRadioButton.TabIndex = 5;
            this.westRadioButton.Text = "West";
            this.westRadioButton.UseVisualStyleBackColor = true;
            // 
            // southRadioButton
            // 
            this.southRadioButton.AutoSize = true;
            this.southRadioButton.Location = new System.Drawing.Point(107, 19);
            this.southRadioButton.Name = "southRadioButton";
            this.southRadioButton.Size = new System.Drawing.Size(44, 17);
            this.southRadioButton.TabIndex = 4;
            this.southRadioButton.Text = "Süd";
            this.southRadioButton.UseVisualStyleBackColor = true;
            // 
            // eastRadioButton
            // 
            this.eastRadioButton.AutoSize = true;
            this.eastRadioButton.Location = new System.Drawing.Point(60, 19);
            this.eastRadioButton.Name = "eastRadioButton";
            this.eastRadioButton.Size = new System.Drawing.Size(41, 17);
            this.eastRadioButton.TabIndex = 3;
            this.eastRadioButton.Text = "Ost";
            this.eastRadioButton.UseVisualStyleBackColor = true;
            // 
            // northRadioButton
            // 
            this.northRadioButton.AutoSize = true;
            this.northRadioButton.Checked = true;
            this.northRadioButton.Location = new System.Drawing.Point(6, 19);
            this.northRadioButton.Name = "northRadioButton";
            this.northRadioButton.Size = new System.Drawing.Size(48, 17);
            this.northRadioButton.TabIndex = 2;
            this.northRadioButton.TabStop = true;
            this.northRadioButton.Text = "Nord";
            this.northRadioButton.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(93, 146);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(134, 23);
            this.downloadButton.TabIndex = 7;
            this.downloadButton.Text = "Foto herunterladen";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 175);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(12, 146);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 6;
            this.previewButton.Text = "Vorschau";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // delBlackBorderCheckBox
            // 
            this.delBlackBorderCheckBox.AutoSize = true;
            this.delBlackBorderCheckBox.Checked = true;
            this.delBlackBorderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.delBlackBorderCheckBox.Location = new System.Drawing.Point(15, 123);
            this.delBlackBorderCheckBox.Name = "delBlackBorderCheckBox";
            this.delBlackBorderCheckBox.Size = new System.Drawing.Size(165, 17);
            this.delBlackBorderCheckBox.TabIndex = 8;
            this.delBlackBorderCheckBox.Text = "Entferne Schwarzen Rahmen";
            this.delBlackBorderCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 210);
            this.Controls.Add(this.delBlackBorderCheckBox);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.longitudeNumericUpDown);
            this.Controls.Add(this.latitudeNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OBED";
            ((System.ComponentModel.ISupportInitialize)(this.latitudeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longitudeNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown latitudeNumericUpDown;
        private System.Windows.Forms.NumericUpDown longitudeNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton westRadioButton;
        private System.Windows.Forms.RadioButton southRadioButton;
        private System.Windows.Forms.RadioButton eastRadioButton;
        private System.Windows.Forms.RadioButton northRadioButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.CheckBox delBlackBorderCheckBox;
    }
}

