namespace InternetRadio
{
    partial class Ebout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ebout));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lVersion = new System.Windows.Forms.Label();
            this.bVersion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Простой и удобный проигрываетль Онлайн радио";
            this.label1.UseMnemonic = false;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.BackColor = System.Drawing.Color.Transparent;
            this.lDate.Location = new System.Drawing.Point(13, 72);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(61, 13);
            this.lDate.TabIndex = 2;
            this.lDate.Text = "22.03.2012";
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo.Location = new System.Drawing.Point(9, 179);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(245, 108);
            this.tbInfo.TabIndex = 3;
            this.tbInfo.Text = "Версия: 1.0.0.0 Дата: 01.01.2012\r\nИзменения:";
            this.tbInfo.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.BackColor = System.Drawing.Color.Transparent;
            this.lVersion.Location = new System.Drawing.Point(13, 44);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(40, 13);
            this.lVersion.TabIndex = 4;
            this.lVersion.Text = "1.0.0.0";
            // 
            // bVersion
            // 
            this.bVersion.Location = new System.Drawing.Point(260, 264);
            this.bVersion.Name = "bVersion";
            this.bVersion.Size = new System.Drawing.Size(75, 23);
            this.bVersion.TabIndex = 5;
            this.bVersion.Text = "Ред. версии";
            this.bVersion.UseVisualStyleBackColor = true;
            this.bVersion.Click += new System.EventHandler(this.BVersionClick);
            // 
            // Ebout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIr.Properties.Resources.MIR;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(455, 294);
            this.ControlBox = false;
            this.Controls.Add(this.bVersion);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ebout";
            this.Text = "О . ..";
            this.Load += new System.EventHandler(this.EboutLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Button bVersion;
    }
}