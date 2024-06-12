namespace zKitap2Pdf
{
    partial class CoordinatePicker
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
            L_Instruction = new Label();
            SuspendLayout();
            // 
            // L_Instruction
            // 
            L_Instruction.AutoSize = true;
            L_Instruction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_Instruction.Location = new Point(12, 9);
            L_Instruction.Name = "L_Instruction";
            L_Instruction.Size = new Size(115, 21);
            L_Instruction.TabIndex = 0;
            L_Instruction.Text = "Click to pick XY";
            // 
            // CoordinatePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(L_Instruction);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CoordinatePicker";
            Opacity = 0.25D;
            Text = "CoordinatePicker";
            Load += CoordinatePicker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L_Instruction;
    }
}