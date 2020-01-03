namespace DELME_CustomTabControl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabInfoPanel = new System.Windows.Forms.Panel();
            this.Tools1 = new System.Windows.Forms.Button();
            this.Tools2 = new System.Windows.Forms.Button();
            this.ClockTab = new System.Windows.Forms.Button();
            this.ComboBoxBut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxBut)).BeginInit();
            this.SuspendLayout();
            // 
            // TabInfoPanel
            // 
            this.TabInfoPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TabInfoPanel.Location = new System.Drawing.Point(12, 79);
            this.TabInfoPanel.Name = "TabInfoPanel";
            this.TabInfoPanel.Size = new System.Drawing.Size(409, 293);
            this.TabInfoPanel.TabIndex = 0;
            // 
            // Tools1
            // 
            this.Tools1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.Tools1.FlatAppearance.BorderSize = 0;
            this.Tools1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tools1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tools1.Location = new System.Drawing.Point(15, 45);
            this.Tools1.Name = "Tools1";
            this.Tools1.Size = new System.Drawing.Size(75, 34);
            this.Tools1.TabIndex = 1;
            this.Tools1.TabStop = false;
            this.Tools1.Text = "Tools 1";
            this.Tools1.UseVisualStyleBackColor = false;
            this.Tools1.Click += new System.EventHandler(this.Tools1_Click);
            // 
            // Tools2
            // 
            this.Tools2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.Tools2.FlatAppearance.BorderSize = 0;
            this.Tools2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tools2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tools2.Location = new System.Drawing.Point(89, 45);
            this.Tools2.Name = "Tools2";
            this.Tools2.Size = new System.Drawing.Size(75, 34);
            this.Tools2.TabIndex = 2;
            this.Tools2.TabStop = false;
            this.Tools2.Text = "Tools 2";
            this.Tools2.UseVisualStyleBackColor = false;
            this.Tools2.Click += new System.EventHandler(this.Tools2_Click);
            // 
            // ClockTab
            // 
            this.ClockTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.ClockTab.FlatAppearance.BorderSize = 0;
            this.ClockTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClockTab.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClockTab.Location = new System.Drawing.Point(164, 45);
            this.ClockTab.Name = "ClockTab";
            this.ClockTab.Size = new System.Drawing.Size(75, 34);
            this.ClockTab.TabIndex = 3;
            this.ClockTab.TabStop = false;
            this.ClockTab.Text = "Clock";
            this.ClockTab.UseVisualStyleBackColor = false;
            this.ClockTab.Click += new System.EventHandler(this.ClockTab_Click);
            // 
            // ComboBoxBut
            // 
            this.ComboBoxBut.Image = global::DELME_CustomTabControl.Properties.Resources.ArrowUp;
            this.ComboBoxBut.Location = new System.Drawing.Point(390, 47);
            this.ComboBoxBut.Name = "ComboBoxBut";
            this.ComboBoxBut.Size = new System.Drawing.Size(30, 30);
            this.ComboBoxBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComboBoxBut.TabIndex = 4;
            this.ComboBoxBut.TabStop = false;
            this.ComboBoxBut.Click += new System.EventHandler(this.ComboBoxBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 384);
            this.Controls.Add(this.ComboBoxBut);
            this.Controls.Add(this.TabInfoPanel);
            this.Controls.Add(this.Tools1);
            this.Controls.Add(this.Tools2);
            this.Controls.Add(this.ClockTab);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxBut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TabInfoPanel;
        private System.Windows.Forms.Button Tools1;
        private System.Windows.Forms.Button Tools2;
        private System.Windows.Forms.Button ClockTab;
        private System.Windows.Forms.PictureBox ComboBoxBut;
    }
}

