namespace Calculator
{
    partial class calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtBox = new TextBox();
            ModuBtn = new Button();
            CEBtn = new Button();
            CBtn = new Button();
            BackBtn = new Button();
            button5 = new Button();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            PosNegBtn = new Button();
            button10 = new Button();
            EightBtn = new Button();
            FiveBtn = new Button();
            TwoBtn = new Button();
            ZeroBtn = new Button();
            button15 = new Button();
            NineBtn = new Button();
            SixBtn = new Button();
            ThreeBtn = new Button();
            DotBtn = new Button();
            DivBtn = new Button();
            MulBtn = new Button();
            SubBtn = new Button();
            AddBtn = new Button();
            EqualBtn = new Button();
            operationStatement = new TextBox();
            AdvanceFeatures = new ComboBox();
            panel1 = new Panel();
            HistoryBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 30F);
            TxtBox.ForeColor = SystemColors.Desktop;
            TxtBox.Location = new Point(-1, 91);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(373, 74);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // ModuBtn
            // 
            ModuBtn.Font = new Font("Segoe UI", 15F);
            ModuBtn.Location = new Point(12, 171);
            ModuBtn.Name = "ModuBtn";
            ModuBtn.Size = new Size(78, 57);
            ModuBtn.TabIndex = 1;
            ModuBtn.Text = "%";
            ModuBtn.UseVisualStyleBackColor = true;
            ModuBtn.Click += operatorClick;
            // 
            // CEBtn
            // 
            CEBtn.Font = new Font("Segoe UI", 15F);
            CEBtn.Location = new Point(106, 171);
            CEBtn.Name = "CEBtn";
            CEBtn.Size = new Size(78, 57);
            CEBtn.TabIndex = 2;
            CEBtn.Text = "CE";
            CEBtn.UseVisualStyleBackColor = true;
            CEBtn.Click += CEBtn_Click;
            // 
            // CBtn
            // 
            CBtn.Font = new Font("Segoe UI", 15F);
            CBtn.Location = new Point(201, 171);
            CBtn.Name = "CBtn";
            CBtn.Size = new Size(78, 57);
            CBtn.TabIndex = 3;
            CBtn.Text = "C";
            CBtn.UseVisualStyleBackColor = true;
            CBtn.Click += CBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Segoe UI", 15F);
            BackBtn.Location = new Point(294, 171);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(78, 57);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "⌫";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(12, 234);
            button5.Name = "button5";
            button5.Size = new Size(78, 57);
            button5.TabIndex = 5;
            button5.Text = "1/x";
            button5.UseVisualStyleBackColor = true;
            button5.Click += operatorClick;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 15F);
            SevenBtn.Location = new Point(12, 297);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(78, 57);
            SevenBtn.TabIndex = 6;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += BtnNumClick;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 15F);
            FourBtn.Location = new Point(12, 360);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(78, 57);
            FourBtn.TabIndex = 7;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += BtnNumClick;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 15F);
            OneBtn.Location = new Point(12, 423);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(78, 57);
            OneBtn.TabIndex = 8;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += BtnNumClick;
            // 
            // PosNegBtn
            // 
            PosNegBtn.Font = new Font("Segoe UI", 15F);
            PosNegBtn.Location = new Point(12, 486);
            PosNegBtn.Name = "PosNegBtn";
            PosNegBtn.Size = new Size(78, 57);
            PosNegBtn.TabIndex = 9;
            PosNegBtn.Text = "+/-";
            PosNegBtn.UseVisualStyleBackColor = true;
            PosNegBtn.Click += negPosConverter;
            // 
            // button10
            // 
            button10.Location = new Point(106, 234);
            button10.Name = "button10";
            button10.Size = new Size(78, 57);
            button10.TabIndex = 10;
            button10.Text = "X^2";
            button10.UseVisualStyleBackColor = true;
            button10.Click += operatorClick;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 15F);
            EightBtn.Location = new Point(106, 297);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(78, 57);
            EightBtn.TabIndex = 11;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += BtnNumClick;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 15F);
            FiveBtn.Location = new Point(106, 360);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(78, 57);
            FiveBtn.TabIndex = 12;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += BtnNumClick;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 15F);
            TwoBtn.Location = new Point(106, 423);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(78, 57);
            TwoBtn.TabIndex = 13;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += BtnNumClick;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 15F);
            ZeroBtn.Location = new Point(106, 486);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(78, 57);
            ZeroBtn.TabIndex = 14;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += BtnNumClick;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 15F);
            button15.Location = new Point(201, 234);
            button15.Name = "button15";
            button15.Size = new Size(78, 57);
            button15.TabIndex = 15;
            button15.Text = "root";
            button15.UseVisualStyleBackColor = true;
            button15.Click += operatorClick;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 15F);
            NineBtn.Location = new Point(201, 297);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(78, 57);
            NineBtn.TabIndex = 16;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += BtnNumClick;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 15F);
            SixBtn.Location = new Point(201, 360);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(78, 57);
            SixBtn.TabIndex = 17;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += BtnNumClick;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 15F);
            ThreeBtn.Location = new Point(201, 423);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(78, 57);
            ThreeBtn.TabIndex = 18;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += BtnNumClick;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 15F);
            DotBtn.Location = new Point(201, 486);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(78, 57);
            DotBtn.TabIndex = 19;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += BtnNumClick;
            // 
            // DivBtn
            // 
            DivBtn.Font = new Font("Segoe UI", 15F);
            DivBtn.Location = new Point(294, 234);
            DivBtn.Name = "DivBtn";
            DivBtn.Size = new Size(78, 57);
            DivBtn.TabIndex = 20;
            DivBtn.Text = "÷";
            DivBtn.UseVisualStyleBackColor = true;
            DivBtn.Click += operatorClick;
            // 
            // MulBtn
            // 
            MulBtn.Font = new Font("Segoe UI", 15F);
            MulBtn.Location = new Point(294, 297);
            MulBtn.Name = "MulBtn";
            MulBtn.Size = new Size(78, 57);
            MulBtn.TabIndex = 21;
            MulBtn.Text = "X";
            MulBtn.UseVisualStyleBackColor = true;
            MulBtn.Click += operatorClick;
            // 
            // SubBtn
            // 
            SubBtn.Font = new Font("Segoe UI", 15F);
            SubBtn.Location = new Point(294, 360);
            SubBtn.Name = "SubBtn";
            SubBtn.Size = new Size(78, 57);
            SubBtn.TabIndex = 22;
            SubBtn.Text = "-";
            SubBtn.UseVisualStyleBackColor = true;
            SubBtn.Click += operatorClick;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI", 15F);
            AddBtn.Location = new Point(294, 423);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(78, 57);
            AddBtn.TabIndex = 23;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += operatorClick;
            // 
            // EqualBtn
            // 
            EqualBtn.BackColor = SystemColors.Highlight;
            EqualBtn.Font = new Font("Segoe UI", 15F);
            EqualBtn.Location = new Point(294, 486);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(78, 57);
            EqualBtn.TabIndex = 24;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = false;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // operationStatement
            // 
            operationStatement.BackColor = SystemColors.InactiveBorder;
            operationStatement.Font = new Font("Segoe UI", 15F);
            operationStatement.ForeColor = SystemColors.GrayText;
            operationStatement.Location = new Point(-1, 52);
            operationStatement.Name = "operationStatement";
            operationStatement.Size = new Size(373, 41);
            operationStatement.TabIndex = 2;
            operationStatement.TextAlign = HorizontalAlignment.Right;
            // 
            // AdvanceFeatures
            // 
            AdvanceFeatures.Font = new Font("Segoe UI", 15F);
            AdvanceFeatures.FormattingEnabled = true;
            AdvanceFeatures.ItemHeight = 35;
            AdvanceFeatures.Items.AddRange(new object[] { "Standard", "Scientific", "Graphing", "Programmer", "Date Calculator" });
            AdvanceFeatures.Location = new Point(0, 3);
            AdvanceFeatures.Name = "AdvanceFeatures";
            AdvanceFeatures.Size = new Size(298, 43);
            AdvanceFeatures.TabIndex = 26;
            AdvanceFeatures.Text = "Standard";
            // 
            // panel1
            // 
            panel1.Controls.Add(HistoryBtn);
            panel1.Controls.Add(AdvanceFeatures);
            panel1.Location = new Point(12, 4);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 45);
            panel1.TabIndex = 15;
            // 
            // HistoryBtn
            // 
            HistoryBtn.Location = new Point(298, 0);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Size = new Size(52, 53);
            HistoryBtn.TabIndex = 27;
            HistoryBtn.Text = "H";
            HistoryBtn.UseVisualStyleBackColor = true;
            HistoryBtn.Click += HistoryBtn_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 557);
            Controls.Add(operationStatement);
            Controls.Add(panel1);
            Controls.Add(EqualBtn);
            Controls.Add(AddBtn);
            Controls.Add(SubBtn);
            Controls.Add(MulBtn);
            Controls.Add(DivBtn);
            Controls.Add(DotBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(button15);
            Controls.Add(ZeroBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(button10);
            Controls.Add(PosNegBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(button5);
            Controls.Add(BackBtn);
            Controls.Add(CBtn);
            Controls.Add(CEBtn);
            Controls.Add(ModuBtn);
            Controls.Add(TxtBox);
            Name = "calculator";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button ModuBtn;
        private Button CEBtn;
        private Button CBtn;
        private Button BackBtn;
        private Button button5;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button PosNegBtn;
        private Button button10;
        private Button EightBtn;
        private Button FiveBtn;
        private Button TwoBtn;
        private Button ZeroBtn;
        private Button button15;
        private Button NineBtn;
        private Button SixBtn;
        private Button ThreeBtn;
        private Button DotBtn;
        private Button DivBtn;
        private Button MulBtn;
        private Button SubBtn;
        private Button AddBtn;
        private Button EqualBtn;
        private TextBox operationStatement;
        private ComboBox AdvanceFeatures;
        private Panel panel1;
        private Button HistoryBtn;
    }
}
