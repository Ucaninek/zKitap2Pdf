﻿namespace zKitap2Pdf
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
            L_Title = new Label();
            GB_Options = new GroupBox();
            L_FastAlert = new Label();
            PB = new ProgressBar();
            B_Start = new Button();
            NUD_Delay = new NumericUpDown();
            NUD_PageCount = new NumericUpDown();
            L_Delay = new Label();
            L_PageCount = new Label();
            GB_Coordinates = new GroupBox();
            L_Picker = new Label();
            B_PickAll = new Button();
            TB_NextPageXY = new TextBox();
            TB_BottomRightXY = new TextBox();
            TB_TopLeftXY = new TextBox();
            L_NextPageXY = new Label();
            L_BottomRightXY = new Label();
            L_TopLeftXY = new Label();
            CB_TopMost = new CheckBox();
            LL_SelfAd = new LinkLabel();
            B_TmpFolder = new Button();
            label1 = new Label();
            GB_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Delay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_PageCount).BeginInit();
            GB_Coordinates.SuspendLayout();
            SuspendLayout();
            // 
            // L_Title
            // 
            L_Title.AutoSize = true;
            L_Title.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            L_Title.Location = new Point(12, 9);
            L_Title.Name = "L_Title";
            L_Title.Size = new Size(144, 37);
            L_Title.TabIndex = 0;
            L_Title.Text = "zKitap2Pdf";
            // 
            // GB_Options
            // 
            GB_Options.Controls.Add(L_FastAlert);
            GB_Options.Controls.Add(PB);
            GB_Options.Controls.Add(B_Start);
            GB_Options.Controls.Add(NUD_Delay);
            GB_Options.Controls.Add(NUD_PageCount);
            GB_Options.Controls.Add(L_Delay);
            GB_Options.Controls.Add(L_PageCount);
            GB_Options.Controls.Add(GB_Coordinates);
            GB_Options.Location = new Point(12, 49);
            GB_Options.Name = "GB_Options";
            GB_Options.Size = new Size(538, 226);
            GB_Options.TabIndex = 1;
            GB_Options.TabStop = false;
            GB_Options.Text = "Options";
            // 
            // L_FastAlert
            // 
            L_FastAlert.AutoSize = true;
            L_FastAlert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_FastAlert.Location = new Point(12, 189);
            L_FastAlert.Name = "L_FastAlert";
            L_FastAlert.Size = new Size(54, 21);
            L_FastAlert.TabIndex = 7;
            L_FastAlert.Text = "(owo')";
            // 
            // PB
            // 
            PB.Location = new Point(304, 89);
            PB.Name = "PB";
            PB.Size = new Size(228, 28);
            PB.TabIndex = 6;
            // 
            // B_Start
            // 
            B_Start.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            B_Start.Location = new Point(304, 123);
            B_Start.Name = "B_Start";
            B_Start.Size = new Size(228, 53);
            B_Start.TabIndex = 5;
            B_Start.Text = "Start";
            B_Start.UseVisualStyleBackColor = true;
            B_Start.Click += B_Start_Click;
            // 
            // NUD_Delay
            // 
            NUD_Delay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NUD_Delay.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            NUD_Delay.Location = new Point(434, 54);
            NUD_Delay.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            NUD_Delay.Name = "NUD_Delay";
            NUD_Delay.Size = new Size(83, 29);
            NUD_Delay.TabIndex = 4;
            NUD_Delay.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // NUD_PageCount
            // 
            NUD_PageCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NUD_PageCount.Location = new Point(434, 20);
            NUD_PageCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NUD_PageCount.Name = "NUD_PageCount";
            NUD_PageCount.Size = new Size(83, 29);
            NUD_PageCount.TabIndex = 3;
            // 
            // L_Delay
            // 
            L_Delay.AutoSize = true;
            L_Delay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_Delay.Location = new Point(304, 56);
            L_Delay.Name = "L_Delay";
            L_Delay.Size = new Size(49, 21);
            L_Delay.TabIndex = 2;
            L_Delay.Text = "Delay";
            // 
            // L_PageCount
            // 
            L_PageCount.AutoSize = true;
            L_PageCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_PageCount.Location = new Point(304, 22);
            L_PageCount.Name = "L_PageCount";
            L_PageCount.Size = new Size(124, 21);
            L_PageCount.TabIndex = 0;
            L_PageCount.Text = "Page Count (ms)";
            // 
            // GB_Coordinates
            // 
            GB_Coordinates.Controls.Add(L_Picker);
            GB_Coordinates.Controls.Add(B_PickAll);
            GB_Coordinates.Controls.Add(TB_NextPageXY);
            GB_Coordinates.Controls.Add(TB_BottomRightXY);
            GB_Coordinates.Controls.Add(TB_TopLeftXY);
            GB_Coordinates.Controls.Add(L_NextPageXY);
            GB_Coordinates.Controls.Add(L_BottomRightXY);
            GB_Coordinates.Controls.Add(L_TopLeftXY);
            GB_Coordinates.Location = new Point(6, 22);
            GB_Coordinates.Name = "GB_Coordinates";
            GB_Coordinates.Size = new Size(292, 154);
            GB_Coordinates.TabIndex = 0;
            GB_Coordinates.TabStop = false;
            GB_Coordinates.Text = "Coordinates (click to pick)";
            // 
            // L_Picker
            // 
            L_Picker.AutoSize = true;
            L_Picker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_Picker.ForeColor = Color.Red;
            L_Picker.Location = new Point(7, 122);
            L_Picker.Name = "L_Picker";
            L_Picker.Size = new Size(0, 21);
            L_Picker.TabIndex = 10;
            // 
            // B_PickAll
            // 
            B_PickAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            B_PickAll.Location = new Point(214, 117);
            B_PickAll.Name = "B_PickAll";
            B_PickAll.Size = new Size(72, 31);
            B_PickAll.TabIndex = 9;
            B_PickAll.Text = "Pick All";
            B_PickAll.UseVisualStyleBackColor = true;
            B_PickAll.Click += B_PickAll_Click;
            // 
            // TB_NextPageXY
            // 
            TB_NextPageXY.Cursor = Cursors.Hand;
            TB_NextPageXY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_NextPageXY.Location = new Point(164, 81);
            TB_NextPageXY.Name = "TB_NextPageXY";
            TB_NextPageXY.ReadOnly = true;
            TB_NextPageXY.Size = new Size(122, 29);
            TB_NextPageXY.TabIndex = 8;
            TB_NextPageXY.Text = "X: ??? Y: ???";
            TB_NextPageXY.DoubleClick += TB_NextPageXY_DoubleClick;
            // 
            // TB_BottomRightXY
            // 
            TB_BottomRightXY.Cursor = Cursors.Hand;
            TB_BottomRightXY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_BottomRightXY.Location = new Point(164, 48);
            TB_BottomRightXY.Name = "TB_BottomRightXY";
            TB_BottomRightXY.ReadOnly = true;
            TB_BottomRightXY.Size = new Size(122, 29);
            TB_BottomRightXY.TabIndex = 7;
            TB_BottomRightXY.Text = "X: ??? Y: ???";
            TB_BottomRightXY.DoubleClick += TB_BottomRightXY_DoubleClick;
            // 
            // TB_TopLeftXY
            // 
            TB_TopLeftXY.Cursor = Cursors.Hand;
            TB_TopLeftXY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_TopLeftXY.Location = new Point(164, 16);
            TB_TopLeftXY.Name = "TB_TopLeftXY";
            TB_TopLeftXY.ReadOnly = true;
            TB_TopLeftXY.Size = new Size(122, 29);
            TB_TopLeftXY.TabIndex = 6;
            TB_TopLeftXY.Text = "X: ??? Y: ???";
            TB_TopLeftXY.DoubleClick += TB_TopLeftXY_DoubleClick;
            // 
            // L_NextPageXY
            // 
            L_NextPageXY.AutoSize = true;
            L_NextPageXY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_NextPageXY.Location = new Point(6, 86);
            L_NextPageXY.Name = "L_NextPageXY";
            L_NextPageXY.Size = new Size(151, 21);
            L_NextPageXY.TabIndex = 5;
            L_NextPageXY.Text = "Next Page Button ---";
            // 
            // L_BottomRightXY
            // 
            L_BottomRightXY.AutoSize = true;
            L_BottomRightXY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_BottomRightXY.Location = new Point(6, 52);
            L_BottomRightXY.Name = "L_BottomRightXY";
            L_BottomRightXY.Size = new Size(152, 21);
            L_BottomRightXY.TabIndex = 3;
            L_BottomRightXY.Text = "Bottom-right Corner";
            // 
            // L_TopLeftXY
            // 
            L_TopLeftXY.AutoSize = true;
            L_TopLeftXY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_TopLeftXY.Location = new Point(6, 21);
            L_TopLeftXY.Name = "L_TopLeftXY";
            L_TopLeftXY.Size = new Size(142, 21);
            L_TopLeftXY.TabIndex = 1;
            L_TopLeftXY.Text = "Top-left Corner ----";
            // 
            // CB_TopMost
            // 
            CB_TopMost.AutoSize = true;
            CB_TopMost.Checked = true;
            CB_TopMost.CheckState = CheckState.Checked;
            CB_TopMost.Location = new Point(384, 285);
            CB_TopMost.Name = "CB_TopMost";
            CB_TopMost.Size = new Size(80, 19);
            CB_TopMost.TabIndex = 2;
            CB_TopMost.Text = "Top Most?";
            CB_TopMost.UseVisualStyleBackColor = true;
            CB_TopMost.CheckedChanged += CB_TopMost_CheckedChanged;
            // 
            // LL_SelfAd
            // 
            LL_SelfAd.AutoSize = true;
            LL_SelfAd.Location = new Point(12, 292);
            LL_SelfAd.Name = "LL_SelfAd";
            LL_SelfAd.Size = new Size(65, 15);
            LL_SelfAd.TabIndex = 3;
            LL_SelfAd.TabStop = true;
            LL_SelfAd.Text = "zemi.space";
            LL_SelfAd.LinkClicked += LL_SelfAd_LinkClicked;
            // 
            // B_TmpFolder
            // 
            B_TmpFolder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            B_TmpFolder.Location = new Point(470, 281);
            B_TmpFolder.Name = "B_TmpFolder";
            B_TmpFolder.Size = new Size(80, 27);
            B_TmpFolder.TabIndex = 11;
            B_TmpFolder.Text = "open temp";
            B_TmpFolder.UseVisualStyleBackColor = true;
            B_TmpFolder.Click += B_TmpFolder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 15);
            label1.Name = "label1";
            label1.Size = new Size(311, 45);
            label1.TabIndex = 12;
            label1.Text = "double-click on XY boxes to select individual coordinates.\r\na minimum delay of 100\r\nms is recommended.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 312);
            Controls.Add(label1);
            Controls.Add(B_TmpFolder);
            Controls.Add(LL_SelfAd);
            Controls.Add(CB_TopMost);
            Controls.Add(GB_Options);
            Controls.Add(L_Title);
            Name = "Form1";
            Text = "zKitap2Pdf";
            TopMost = true;
            GB_Options.ResumeLayout(false);
            GB_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Delay).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_PageCount).EndInit();
            GB_Coordinates.ResumeLayout(false);
            GB_Coordinates.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L_Title;
        private GroupBox GB_Options;
        private GroupBox GB_Coordinates;
        private Label L_PageCount;
        private CheckBox CB_TopMost;
        private Label L_BottomRightXY;
        private Label L_TopLeftXY;
        private LinkLabel LL_SelfAd;
        private Label L_Delay;
        private Label L_NextPageXY;
        private TextBox TB_NextPageXY;
        private TextBox TB_BottomRightXY;
        private TextBox TB_TopLeftXY;
        private Button B_PickAll;
        private NumericUpDown NUD_Delay;
        private NumericUpDown NUD_PageCount;
        private Button B_Start;
        private ProgressBar PB;
        private Label L_FastAlert;
        private Label L_Picker;
        private Button B_TmpFolder;
        private Label label1;
    }
}