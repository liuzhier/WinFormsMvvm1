namespace WinFormsApp1.Views;

public partial class Form1 : Form
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
        label1 = new Label();
        label2 = new Label();
        label_playerAction = new Label();
        label_cpuAction = new Label();
        label5 = new Label();
        label_checkReturn = new Label();
        button_石头 = new Button();
        button_剪刀 = new Button();
        button_布 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft YaHei UI", 16F);
        label1.Location = new Point(45, 83);
        label1.Name = "label1";
        label1.Size = new Size(114, 41);
        label1.TabIndex = 0;
        label1.Text = "玩家：";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft YaHei UI", 16F);
        label2.Location = new Point(752, 83);
        label2.Name = "label2";
        label2.Size = new Size(114, 41);
        label2.TabIndex = 0;
        label2.Text = "电脑：";
        // 
        // label_playerAction
        // 
        label_playerAction.AutoSize = true;
        label_playerAction.Font = new Font("Microsoft YaHei UI", 16F);
        label_playerAction.Location = new Point(174, 83);
        label_playerAction.Name = "label_playerAction";
        label_playerAction.Size = new Size(114, 41);
        label_playerAction.TabIndex = 0;
        label_playerAction.Text = "无动作";
        // 
        // label_cpuAction
        // 
        label_cpuAction.AutoSize = true;
        label_cpuAction.Font = new Font("Microsoft YaHei UI", 16F);
        label_cpuAction.Location = new Point(881, 83);
        label_cpuAction.Name = "label_cpuAction";
        label_cpuAction.Size = new Size(114, 41);
        label_cpuAction.TabIndex = 0;
        label_cpuAction.Text = "无动作";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Microsoft YaHei UI", 16F);
        label5.Location = new Point(372, 251);
        label5.Name = "label5";
        label5.Size = new Size(114, 41);
        label5.TabIndex = 0;
        label5.Text = "裁判：";
        // 
        // label_checkReturn
        // 
        label_checkReturn.AutoSize = true;
        label_checkReturn.Font = new Font("Microsoft YaHei UI", 16F);
        label_checkReturn.Location = new Point(501, 251);
        label_checkReturn.Name = "label_checkReturn";
        label_checkReturn.Size = new Size(220, 41);
        label_checkReturn.TabIndex = 0;
        label_checkReturn.Text = "游戏未开始！!";
        // 
        // button_石头
        // 
        button_石头.AutoSize = true;
        button_石头.Font = new Font("Microsoft YaHei UI", 16F);
        button_石头.Location = new Point(132, 429);
        button_石头.Name = "button_石头";
        button_石头.Size = new Size(151, 51);
        button_石头.TabIndex = 1;
        button_石头.Text = "石头";
        button_石头.UseVisualStyleBackColor = true;
        // 
        // button_剪刀
        // 
        button_剪刀.AutoSize = true;
        button_剪刀.Font = new Font("Microsoft YaHei UI", 16F);
        button_剪刀.Location = new Point(466, 429);
        button_剪刀.Name = "button_剪刀";
        button_剪刀.Size = new Size(151, 51);
        button_剪刀.TabIndex = 1;
        button_剪刀.Text = "剪刀";
        button_剪刀.UseVisualStyleBackColor = true;
        // 
        // button_布
        // 
        button_布.AutoSize = true;
        button_布.Font = new Font("Microsoft YaHei UI", 16F);
        button_布.Location = new Point(782, 429);
        button_布.Name = "button_布";
        button_布.Size = new Size(151, 51);
        button_布.TabIndex = 1;
        button_布.Text = "布";
        button_布.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(11F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1072, 686);
        Controls.Add(button_布);
        Controls.Add(button_剪刀);
        Controls.Add(button_石头);
        Controls.Add(label_cpuAction);
        Controls.Add(label_checkReturn);
        Controls.Add(label_playerAction);
        Controls.Add(label2);
        Controls.Add(label5);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label_playerAction;
    private Label label_cpuAction;
    private Label label5;
    private Label label_checkReturn;
    private Button button_石头;
    private Button button_剪刀;
    private Button button_布;
}
