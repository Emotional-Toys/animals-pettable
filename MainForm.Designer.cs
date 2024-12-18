namespace Cartheur.Animals.Pettable
{
    partial class MainForm
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
            this.PetDetectedAntennaOneButton = new Cartheur.Animals.Pettable.FlashButton();
            this.CloseBUtton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PetDetectedAntennaTwoButton = new Cartheur.Animals.Pettable.FlashButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PettedDetectedAntennaOneButton
            // 
            this.PetDetectedAntennaOneButton.FlasherButtonColorOff = System.Drawing.SystemColors.Control;
            this.PetDetectedAntennaOneButton.FlasherButtonColorOn = System.Drawing.Color.LightGreen;
            this.PetDetectedAntennaOneButton.FlashNumber = 0;
            this.PetDetectedAntennaOneButton.Location = new System.Drawing.Point(26, 55);
            this.PetDetectedAntennaOneButton.Name = "PettedDetectedAntennaOneButton";
            this.PetDetectedAntennaOneButton.Size = new System.Drawing.Size(153, 89);
            this.PetDetectedAntennaOneButton.TabIndex = 0;
            this.PetDetectedAntennaOneButton.Text = "Petted";
            this.PetDetectedAntennaOneButton.UseVisualStyleBackColor = true;
            this.PetDetectedAntennaOneButton.Click += new System.EventHandler(this.PettedDetectedAntennaOneButtonClick);
            // 
            // CloseBUtton
            // 
            this.CloseBUtton.Location = new System.Drawing.Point(528, 139);
            this.CloseBUtton.Name = "CloseBUtton";
            this.CloseBUtton.Size = new System.Drawing.Size(139, 77);
            this.CloseBUtton.TabIndex = 1;
            this.CloseBUtton.Text = "Close";
            this.CloseBUtton.UseVisualStyleBackColor = true;
            this.CloseBUtton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PetDetectedAntennaOneButton);
            this.groupBox1.Location = new System.Drawing.Point(49, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antenna One";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PetDetectedAntennaTwoButton);
            this.groupBox2.Location = new System.Drawing.Point(269, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 197);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Antenna Two";
            // 
            // PetDetectedAntennaTwoButton
            // 
            this.PetDetectedAntennaTwoButton.FlasherButtonColorOff = System.Drawing.SystemColors.Control;
            this.PetDetectedAntennaTwoButton.FlasherButtonColorOn = System.Drawing.Color.LightGreen;
            this.PetDetectedAntennaTwoButton.FlashNumber = 0;
            this.PetDetectedAntennaTwoButton.Location = new System.Drawing.Point(26, 55);
            this.PetDetectedAntennaTwoButton.Name = "PetDetectedAntennaTwoButton";
            this.PetDetectedAntennaTwoButton.Size = new System.Drawing.Size(153, 89);
            this.PetDetectedAntennaTwoButton.TabIndex = 0;
            this.PetDetectedAntennaTwoButton.Text = "Petted";
            this.PetDetectedAntennaTwoButton.UseVisualStyleBackColor = true;
            this.PetDetectedAntennaTwoButton.Click += new System.EventHandler(this.PetDetectedAntennaTwoButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 291);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseBUtton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 355);
            this.MinimumSize = new System.Drawing.Size(740, 355);
            this.Name = "MainForm";
            this.Text = "Pet Detector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlashButton PetDetectedAntennaOneButton;
        private System.Windows.Forms.Button CloseBUtton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FlashButton PetDetectedAntennaTwoButton;
    }
}

