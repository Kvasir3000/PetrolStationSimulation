namespace PetrolStationSimulation
{
    partial class PumInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PumInfo));
            this.position = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fuel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.unleadedType = new System.Windows.Forms.TextBox();
            this.lpgType = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dieselType = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.vehicles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comission = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(165, 30);
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Size = new System.Drawing.Size(99, 22);
            this.position.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Pump position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 54;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fuel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.unleadedType);
            this.groupBox3.Controls.Add(this.lpgType);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.dieselType);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(-2, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 125);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fuel";
            // 
            // fuel
            // 
            this.fuel.Location = new System.Drawing.Point(167, 32);
            this.fuel.Name = "fuel";
            this.fuel.ReadOnly = true;
            this.fuel.Size = new System.Drawing.Size(134, 22);
            this.fuel.TabIndex = 47;
            this.fuel.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 25);
            this.label11.TabIndex = 48;
            this.label11.Text = "Dispensed fuel: ";
            // 
            // unleadedType
            // 
            this.unleadedType.Location = new System.Drawing.Point(447, 85);
            this.unleadedType.Name = "unleadedType";
            this.unleadedType.ReadOnly = true;
            this.unleadedType.Size = new System.Drawing.Size(78, 22);
            this.unleadedType.TabIndex = 46;
            // 
            // lpgType
            // 
            this.lpgType.Location = new System.Drawing.Point(69, 85);
            this.lpgType.Name = "lpgType";
            this.lpgType.ReadOnly = true;
            this.lpgType.Size = new System.Drawing.Size(78, 22);
            this.lpgType.TabIndex = 45;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(338, 84);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(102, 25);
            this.label31.TabIndex = 8;
            this.label31.Text = "Unleaded:";
            // 
            // dieselType
            // 
            this.dieselType.Location = new System.Drawing.Point(240, 85);
            this.dieselType.Name = "dieselType";
            this.dieselType.ReadOnly = true;
            this.dieselType.Size = new System.Drawing.Size(78, 22);
            this.dieselType.TabIndex = 7;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(162, 83);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 25);
            this.label30.TabIndex = 6;
            this.label30.Text = "Diesel:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(6, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 25);
            this.label21.TabIndex = 4;
            this.label21.Text = "LPG:";
            // 
            // vehicles
            // 
            this.vehicles.Location = new System.Drawing.Point(190, 75);
            this.vehicles.Name = "vehicles";
            this.vehicles.ReadOnly = true;
            this.vehicles.Size = new System.Drawing.Size(89, 22);
            this.vehicles.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Served vehicles:";
            // 
            // comission
            // 
            this.comission.Location = new System.Drawing.Point(434, 31);
            this.comission.Name = "comission";
            this.comission.ReadOnly = true;
            this.comission.Size = new System.Drawing.Size(94, 22);
            this.comission.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(276, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "1% comission:";
            // 
            // PumInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(537, 264);
            this.Controls.Add(this.comission);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vehicles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(555, 311);
            this.MinimumSize = new System.Drawing.Size(555, 311);
            this.Name = "PumInfo";
            this.Text = "Pump info ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox fuel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox unleadedType;
        private System.Windows.Forms.TextBox lpgType;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox dieselType;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox vehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox comission;
        private System.Windows.Forms.Label label4;
    }
}