namespace StockViewer
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.companiesValue = new System.Windows.Forms.TextBox();
            this.fontValue = new System.Windows.Forms.NumericUpDown();
            this.spaceingValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opacityValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.monitorValue = new System.Windows.Forms.NumericUpDown();
            this.speedValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fontValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceingValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedValue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(14, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(248, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // companiesValue
            // 
            this.companiesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companiesValue.Location = new System.Drawing.Point(14, 22);
            this.companiesValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.companiesValue.Name = "companiesValue";
            this.companiesValue.Size = new System.Drawing.Size(296, 20);
            this.companiesValue.TabIndex = 2;
            this.companiesValue.Text = "TSLA, NIO, XPEV";
            // 
            // fontValue
            // 
            this.fontValue.Location = new System.Drawing.Point(14, 65);
            this.fontValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fontValue.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.fontValue.Name = "fontValue";
            this.fontValue.Size = new System.Drawing.Size(51, 23);
            this.fontValue.TabIndex = 3;
            this.fontValue.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // spaceingValue
            // 
            this.spaceingValue.Location = new System.Drawing.Point(135, 65);
            this.spaceingValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.spaceingValue.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spaceingValue.Name = "spaceingValue";
            this.spaceingValue.Size = new System.Drawing.Size(51, 23);
            this.spaceingValue.TabIndex = 4;
            this.spaceingValue.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Companies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Font Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spaceing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opacity";
            // 
            // opacityValue
            // 
            this.opacityValue.Location = new System.Drawing.Point(77, 65);
            this.opacityValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.opacityValue.Name = "opacityValue";
            this.opacityValue.Size = new System.Drawing.Size(51, 23);
            this.opacityValue.TabIndex = 8;
            this.opacityValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monitor";
            // 
            // monitorValue
            // 
            this.monitorValue.Location = new System.Drawing.Point(259, 65);
            this.monitorValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.monitorValue.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.monitorValue.Name = "monitorValue";
            this.monitorValue.Size = new System.Drawing.Size(51, 23);
            this.monitorValue.TabIndex = 12;
            this.monitorValue.ValueChanged += new System.EventHandler(this.monitorValue_ValueChanged);
            // 
            // speedValue
            // 
            this.speedValue.Location = new System.Drawing.Point(196, 65);
            this.speedValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.speedValue.Name = "speedValue";
            this.speedValue.Size = new System.Drawing.Size(51, 23);
            this.speedValue.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Speed";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 130);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speedValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monitorValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.opacityValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spaceingValue);
            this.Controls.Add(this.fontValue);
            this.Controls.Add(this.companiesValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.fontValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceingValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox companiesValue;
        private System.Windows.Forms.NumericUpDown fontValue;
        private System.Windows.Forms.NumericUpDown spaceingValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown opacityValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown monitorValue;
        private System.Windows.Forms.NumericUpDown speedValue;
        private System.Windows.Forms.Label label5;
    }
}