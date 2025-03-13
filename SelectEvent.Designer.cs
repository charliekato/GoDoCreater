namespace GoDoCreater
{
    partial class SelectEvent
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
            listEvent = new ListBox();
            btnSelect = new Button();
            btnQuit = new Button();
            checkBoxScenario1 = new CheckBox();
            checkBoxScenario2 = new CheckBox();
            SuspendLayout();
            // 
            // listEvent
            // 
            listEvent.FormattingEnabled = true;
            listEvent.Location = new Point(22, 12);
            listEvent.Margin = new Padding(2);
            listEvent.Name = "listEvent";
            listEvent.Size = new Size(1046, 544);
            listEvent.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(161, 594);
            btnSelect.Margin = new Padding(2);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(67, 46);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "選択";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(835, 594);
            btnQuit.Margin = new Padding(2);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(71, 46);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "終了";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // checkBoxScenario1
            // 
            checkBoxScenario1.AutoSize = true;
            checkBoxScenario1.Location = new Point(315, 579);
            checkBoxScenario1.Name = "checkBoxScenario1";
            checkBoxScenario1.Size = new Size(228, 24);
            checkBoxScenario1.TabIndex = 3;
            checkBoxScenario1.Text = "合同ができるようにレーンをずらす。";
            checkBoxScenario1.UseVisualStyleBackColor = true;
            // 
            // checkBoxScenario2
            // 
            checkBoxScenario2.AutoSize = true;
            checkBoxScenario2.Location = new Point(315, 616);
            checkBoxScenario2.Name = "checkBoxScenario2";
            checkBoxScenario2.Size = new Size(232, 24);
            checkBoxScenario2.TabIndex = 4;
            checkBoxScenario2.Text = "合同のレースを作ってしまう。(推奨)";
            checkBoxScenario2.UseVisualStyleBackColor = true;
            checkBoxScenario2.CheckedChanged += checkBoxScenario2_CheckedChanged;
            // 
            // SelectEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 659);
            Controls.Add(checkBoxScenario2);
            Controls.Add(checkBoxScenario1);
            Controls.Add(btnQuit);
            Controls.Add(btnSelect);
            Controls.Add(listEvent);
            Margin = new Padding(2);
            Name = "SelectEvent";
            Text = "競技選択  　　　一般社団法人 大津市水泳協会";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listEvent;
        private Button btnSelect;
        private Button btnQuit;
        private CheckBox checkBoxScenario1;
        private CheckBox checkBoxScenario2;
    }

}