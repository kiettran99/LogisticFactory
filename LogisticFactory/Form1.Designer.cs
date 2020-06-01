namespace LogisticFactory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbShip = new System.Windows.Forms.CheckBox();
            this.cbTruck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.Truck1 = new System.Windows.Forms.Label();
            this.Truck2 = new System.Windows.Forms.Label();
            this.Truck3 = new System.Windows.Forms.Label();
            this.Truck4 = new System.Windows.Forms.Label();
            this.Ship1 = new System.Windows.Forms.Label();
            this.Ship2 = new System.Windows.Forms.Label();
            this.Ship3 = new System.Windows.Forms.Label();
            this.Ship4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 414);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 90);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.cbShip);
            this.panel1.Controls.Add(this.cbTruck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(737, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 222);
            this.panel1.TabIndex = 3;
            // 
            // cbShip
            // 
            this.cbShip.AutoSize = true;
            this.cbShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShip.Location = new System.Drawing.Point(195, 61);
            this.cbShip.Name = "cbShip";
            this.cbShip.Size = new System.Drawing.Size(56, 22);
            this.cbShip.TabIndex = 2;
            this.cbShip.Text = "Ship";
            this.cbShip.UseVisualStyleBackColor = true;
            // 
            // cbTruck
            // 
            this.cbTruck.AutoSize = true;
            this.cbTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTruck.Location = new System.Drawing.Point(27, 61);
            this.cbTruck.Name = "cbTruck";
            this.cbTruck.Size = new System.Drawing.Size(65, 22);
            this.cbTruck.TabIndex = 1;
            this.cbTruck.Text = "Truck";
            this.cbTruck.UseVisualStyleBackColor = true;
            this.cbTruck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Transport";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(599, 414);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::LogisticFactory.Properties.Resources.Truck;
            this.pictureBox3.Location = new System.Drawing.Point(12, 420);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogisticFactory.Properties.Resources.FactoryMEthod;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 407);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(764, 282);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(215, 228);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(27, 172);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(224, 38);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Truck1
            // 
            this.Truck1.AutoSize = true;
            this.Truck1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Truck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Truck1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Truck1.Location = new System.Drawing.Point(200, 301);
            this.Truck1.Name = "Truck1";
            this.Truck1.Size = new System.Drawing.Size(18, 16);
            this.Truck1.TabIndex = 7;
            this.Truck1.Text = "V";
            this.Truck1.Visible = false;
            // 
            // Truck2
            // 
            this.Truck2.AutoSize = true;
            this.Truck2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Truck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Truck2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Truck2.Location = new System.Drawing.Point(66, 267);
            this.Truck2.Name = "Truck2";
            this.Truck2.Size = new System.Drawing.Size(18, 16);
            this.Truck2.TabIndex = 8;
            this.Truck2.Text = "V";
            this.Truck2.Visible = false;
            // 
            // Truck3
            // 
            this.Truck3.AutoSize = true;
            this.Truck3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Truck3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Truck3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Truck3.Location = new System.Drawing.Point(122, 159);
            this.Truck3.Name = "Truck3";
            this.Truck3.Size = new System.Drawing.Size(18, 16);
            this.Truck3.TabIndex = 9;
            this.Truck3.Text = "V";
            this.Truck3.Visible = false;
            // 
            // Truck4
            // 
            this.Truck4.AutoSize = true;
            this.Truck4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Truck4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Truck4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Truck4.Location = new System.Drawing.Point(99, 13);
            this.Truck4.Name = "Truck4";
            this.Truck4.Size = new System.Drawing.Size(18, 16);
            this.Truck4.TabIndex = 10;
            this.Truck4.Text = "V";
            this.Truck4.Visible = false;
            // 
            // Ship1
            // 
            this.Ship1.AutoSize = true;
            this.Ship1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ship1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ship1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ship1.Location = new System.Drawing.Point(497, 301);
            this.Ship1.Name = "Ship1";
            this.Ship1.Size = new System.Drawing.Size(18, 16);
            this.Ship1.TabIndex = 11;
            this.Ship1.Text = "V";
            this.Ship1.Visible = false;
            // 
            // Ship2
            // 
            this.Ship2.AutoSize = true;
            this.Ship2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ship2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ship2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ship2.Location = new System.Drawing.Point(596, 246);
            this.Ship2.Name = "Ship2";
            this.Ship2.Size = new System.Drawing.Size(18, 16);
            this.Ship2.TabIndex = 12;
            this.Ship2.Text = "V";
            this.Ship2.Visible = false;
            // 
            // Ship3
            // 
            this.Ship3.AutoSize = true;
            this.Ship3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ship3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ship3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ship3.Location = new System.Drawing.Point(561, 159);
            this.Ship3.Name = "Ship3";
            this.Ship3.Size = new System.Drawing.Size(18, 16);
            this.Ship3.TabIndex = 13;
            this.Ship3.Text = "V";
            this.Ship3.Visible = false;
            // 
            // Ship4
            // 
            this.Ship4.AutoSize = true;
            this.Ship4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ship4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ship4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ship4.Location = new System.Drawing.Point(524, 62);
            this.Ship4.Name = "Ship4";
            this.Ship4.Size = new System.Drawing.Size(18, 16);
            this.Ship4.TabIndex = 14;
            this.Ship4.Text = "V";
            this.Ship4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.Ship4);
            this.Controls.Add(this.Ship3);
            this.Controls.Add(this.Ship2);
            this.Controls.Add(this.Ship1);
            this.Controls.Add(this.Truck4);
            this.Controls.Add(this.Truck3);
            this.Controls.Add(this.Truck2);
            this.Controls.Add(this.Truck1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbShip;
        private System.Windows.Forms.CheckBox cbTruck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label Truck1;
        private System.Windows.Forms.Label Truck2;
        private System.Windows.Forms.Label Truck3;
        private System.Windows.Forms.Label Truck4;
        private System.Windows.Forms.Label Ship1;
        private System.Windows.Forms.Label Ship2;
        private System.Windows.Forms.Label Ship3;
        private System.Windows.Forms.Label Ship4;
    }
}

