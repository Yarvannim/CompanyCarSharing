namespace CompanyCarSharing
{
    partial class EmployeeTrips
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
            lbTrips = new ListBox();
            lbTotalPerCar = new ListBox();
            SuspendLayout();
            // 
            // lbTrips
            // 
            lbTrips.FormattingEnabled = true;
            lbTrips.ItemHeight = 15;
            lbTrips.Location = new Point(3, 4);
            lbTrips.Name = "lbTrips";
            lbTrips.Size = new Size(587, 274);
            lbTrips.TabIndex = 0;
            // 
            // lbTotalPerCar
            // 
            lbTotalPerCar.FormattingEnabled = true;
            lbTotalPerCar.ItemHeight = 15;
            lbTotalPerCar.Location = new Point(3, 295);
            lbTotalPerCar.Name = "lbTotalPerCar";
            lbTotalPerCar.Size = new Size(587, 154);
            lbTotalPerCar.TabIndex = 1;
            // 
            // EmployeeTrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(lbTotalPerCar);
            Controls.Add(lbTrips);
            Name = "EmployeeTrips";
            Text = "EmployeeTrips";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbTrips;
        private ListBox lbTotalPerCar;
    }
}