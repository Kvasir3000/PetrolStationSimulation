namespace PetrolStationSimulation
{
    partial class VehicleCharacteristics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleCharacteristics));
            this.vehicle = new System.Windows.Forms.PictureBox();
            this.type = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.fuel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reqFuel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeFuel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.awaitingTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicle
            // 
            this.vehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicle.Location = new System.Drawing.Point(12, 25);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(160, 134);
            this.vehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehicle.TabIndex = 1;
            this.vehicle.TabStop = false;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(325, 70);
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Size = new System.Drawing.Size(109, 22);
            this.type.TabIndex = 45;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(190, 67);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(125, 25);
            this.label28.TabIndex = 44;
            this.label28.Text = "Vehicle type:";
            // 
            // fuel
            // 
            this.fuel.Location = new System.Drawing.Point(325, 112);
            this.fuel.Name = "fuel";
            this.fuel.ReadOnly = true;
            this.fuel.Size = new System.Drawing.Size(109, 22);
            this.fuel.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Fuel type:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(325, 25);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(109, 22);
            this.id.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(190, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Vehicle ID:";
            // 
            // reqFuel
            // 
            this.reqFuel.Location = new System.Drawing.Point(335, 151);
            this.reqFuel.Name = "reqFuel";
            this.reqFuel.ReadOnly = true;
            this.reqFuel.Size = new System.Drawing.Size(109, 22);
            this.reqFuel.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(190, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Required fuel:";
            // 
            // timeFuel
            // 
            this.timeFuel.Location = new System.Drawing.Point(151, 187);
            this.timeFuel.Name = "timeFuel";
            this.timeFuel.ReadOnly = true;
            this.timeFuel.Size = new System.Drawing.Size(109, 22);
            this.timeFuel.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Fuel time:";
            // 
            // awaitingTime
            // 
            this.awaitingTime.Location = new System.Drawing.Point(200, 227);
            this.awaitingTime.Name = "awaitingTime";
            this.awaitingTime.ReadOnly = true;
            this.awaitingTime.Size = new System.Drawing.Size(109, 22);
            this.awaitingTime.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Awaiting time limit:";
            // 
            // VehicleCharacteristics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(460, 272);
            this.Controls.Add(this.awaitingTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeFuel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reqFuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fuel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.vehicle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(478, 319);
            this.MinimumSize = new System.Drawing.Size(478, 319);
            this.Name = "VehicleCharacteristics";
            this.Text = "Vehicle characteristics ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vehicle;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox fuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reqFuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeFuel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox awaitingTime;
        private System.Windows.Forms.Label label5;
    }
}