namespace GoDoCreater
{
    partial class MainMenu
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
            checkBoxScenario1 = new CheckBox();
            checkBoxScenario3 = new CheckBox();
            checkBoxStrategy1 = new CheckBox();
            checkBoxStrategy2 = new CheckBox();
            checkBoxScenario2 = new CheckBox();
            buttonExe = new Button();
            buttonQuit = new Button();
            labelScenario3 = new Label();
            SuspendLayout();
            // 
            // checkBoxScenario1
            // 
            checkBoxScenario1.AutoSize = true;
            checkBoxScenario1.Location = new Point(178, 65);
            checkBoxScenario1.Name = "checkBoxScenario1";
            checkBoxScenario1.Size = new Size(223, 24);
            checkBoxScenario1.TabIndex = 0;
            checkBoxScenario1.Text = "合同ができるようにレーンを寄せる";
            checkBoxScenario1.UseVisualStyleBackColor = true;
            // 
            // checkBoxScenario3
            // 
            checkBoxScenario3.AutoSize = true;
            checkBoxScenario3.Location = new Point(178, 262);
            checkBoxScenario3.Name = "checkBoxScenario3";
            checkBoxScenario3.Size = new Size(367, 24);
            checkBoxScenario3.TabIndex = 1;
            checkBoxScenario3.Text = "「合同レース」というクラスのレースをつくりそこに移動させる。";
            checkBoxScenario3.UseVisualStyleBackColor = true;
            checkBoxScenario3.CheckedChanged += checkBoxScenario3_CheckedChanged;
            // 
            // checkBoxStrategy1
            // 
            checkBoxStrategy1.AutoSize = true;
            checkBoxStrategy1.Location = new Point(214, 99);
            checkBoxStrategy1.Name = "checkBoxStrategy1";
            checkBoxStrategy1.Size = new Size(137, 24);
            checkBoxStrategy1.TabIndex = 2;
            checkBoxStrategy1.Text = "男女も合同にする";
            checkBoxStrategy1.UseVisualStyleBackColor = true;
            // 
            // checkBoxStrategy2
            // 
            checkBoxStrategy2.AutoSize = true;
            checkBoxStrategy2.Location = new Point(214, 136);
            checkBoxStrategy2.Name = "checkBoxStrategy2";
            checkBoxStrategy2.Size = new Size(293, 24);
            checkBoxStrategy2.TabIndex = 3;
            checkBoxStrategy2.Text = "組単位で合同にする(V6でできるようになった)";
            checkBoxStrategy2.UseVisualStyleBackColor = true;
            // 
            // checkBoxScenario2
            // 
            checkBoxScenario2.AutoSize = true;
            checkBoxScenario2.Location = new Point(178, 195);
            checkBoxScenario2.Name = "checkBoxScenario2";
            checkBoxScenario2.Size = new Size(251, 24);
            checkBoxScenario2.TabIndex = 4;
            checkBoxScenario2.Text = "セイコーリザルトで合同のテーブルを作る";
            checkBoxScenario2.UseVisualStyleBackColor = true;
            // 
            // buttonExe
            // 
            buttonExe.Location = new Point(229, 376);
            buttonExe.Name = "buttonExe";
            buttonExe.Size = new Size(71, 41);
            buttonExe.TabIndex = 6;
            buttonExe.Text = "実行";
            buttonExe.UseVisualStyleBackColor = true;
            buttonExe.Click += buttonExe_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(542, 376);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(71, 41);
            buttonQuit.TabIndex = 7;
            buttonQuit.Text = "終了";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // labelScenario3
            // 
            labelScenario3.AutoSize = true;
            labelScenario3.Location = new Point(232, 289);
            labelScenario3.Name = "labelScenario3";
            labelScenario3.Size = new Size(334, 20);
            labelScenario3.TabIndex = 8;
            labelScenario3.Text = " こうすることによって電光に距離や種目が表示されます。";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelScenario3);
            Controls.Add(buttonQuit);
            Controls.Add(buttonExe);
            Controls.Add(checkBoxScenario2);
            Controls.Add(checkBoxStrategy2);
            Controls.Add(checkBoxStrategy1);
            Controls.Add(checkBoxScenario3);
            Controls.Add(checkBoxScenario1);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxScenario1;
        private CheckBox checkBoxScenario3;
        private CheckBox checkBoxStrategy1;
        private CheckBox checkBoxStrategy2;
        private CheckBox checkBoxScenario2;
        private CheckBox checkBoxScenario4;
        private Button buttonExe;
        private Button buttonQuit;
        private Label labelScenario3;
    }
}