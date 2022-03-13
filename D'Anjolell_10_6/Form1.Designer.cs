
namespace D_Anjolell_10_6
{
    partial class CalculateTotal
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
            this.comboxDorm = new System.Windows.Forms.ComboBox();
            this.comboxMeal = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDorm = new System.Windows.Forms.Label();
            this.lblMeal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboxDorm
            // 
            this.comboxDorm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboxDorm.FormattingEnabled = true;
            this.comboxDorm.Items.AddRange(new object[] {
            "Allen Hall",
            "Pike Hall",
            "Farthing Hall",
            "University Suites"});
            this.comboxDorm.Location = new System.Drawing.Point(106, 166);
            this.comboxDorm.Name = "comboxDorm";
            this.comboxDorm.Size = new System.Drawing.Size(225, 37);
            this.comboxDorm.TabIndex = 0;
            // 
            // comboxMeal
            // 
            this.comboxMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboxMeal.FormattingEnabled = true;
            this.comboxMeal.Items.AddRange(new object[] {
            "7 meals per week",
            "14 meals per week",
            "Unlimited meals"});
            this.comboxMeal.Location = new System.Drawing.Point(452, 166);
            this.comboxMeal.Name = "comboxMeal";
            this.comboxMeal.Size = new System.Drawing.Size(259, 37);
            this.comboxMeal.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCalc.Location = new System.Drawing.Point(326, 276);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(127, 49);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitle.Location = new System.Drawing.Point(185, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(426, 36);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Dorm and Meal Plan Calculator";
            // 
            // lblDorm
            // 
            this.lblDorm.AutoSize = true;
            this.lblDorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDorm.Location = new System.Drawing.Point(149, 86);
            this.lblDorm.Name = "lblDorm";
            this.lblDorm.Size = new System.Drawing.Size(138, 29);
            this.lblDorm.TabIndex = 4;
            this.lblDorm.Text = "Dormitories";
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMeal.Location = new System.Drawing.Point(513, 86);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(132, 29);
            this.lblMeal.TabIndex = 5;
            this.lblMeal.Text = "Meal Plans";
            // 
            // CalculateTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.lblDorm);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.comboxMeal);
            this.Controls.Add(this.comboxDorm);
            this.Name = "CalculateTotal";
            this.Text = "CalculateTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxDorm;
        private System.Windows.Forms.ComboBox comboxMeal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDorm;
        private System.Windows.Forms.Label lblMeal;
    }
}

