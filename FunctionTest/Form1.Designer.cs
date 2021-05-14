namespace FunctionTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_SourceFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_TargetFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_NewName = new System.Windows.Forms.TextBox();
            this.TextBox_Extension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Start = new System.Windows.Forms.Button();
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Rename = new System.Windows.Forms.TabPage();
            this.tabPage_Replace = new System.Windows.Forms.TabPage();
            this.TextBox_RPsource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_RPtarget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_OriSymbol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBox_NewSymbol = new System.Windows.Forms.TextBox();
            this.RichTextBox_Display = new System.Windows.Forms.RichTextBox();
            this.TabControl_Main.SuspendLayout();
            this.tabPage_Rename.SuspendLayout();
            this.tabPage_Replace.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_SourceFolder
            // 
            this.TextBox_SourceFolder.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.TextBox_SourceFolder.Location = new System.Drawing.Point(109, 15);
            this.TextBox_SourceFolder.Name = "TextBox_SourceFolder";
            this.TextBox_SourceFolder.Size = new System.Drawing.Size(493, 23);
            this.TextBox_SourceFolder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Folder :";
            // 
            // TextBox_TargetFolder
            // 
            this.TextBox_TargetFolder.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.TextBox_TargetFolder.Location = new System.Drawing.Point(109, 44);
            this.TextBox_TargetFolder.Name = "TextBox_TargetFolder";
            this.TextBox_TargetFolder.Size = new System.Drawing.Size(493, 23);
            this.TextBox_TargetFolder.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Folder :";
            // 
            // TextBox_NewName
            // 
            this.TextBox_NewName.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.TextBox_NewName.Location = new System.Drawing.Point(109, 79);
            this.TextBox_NewName.Name = "TextBox_NewName";
            this.TextBox_NewName.Size = new System.Drawing.Size(163, 23);
            this.TextBox_NewName.TabIndex = 0;
            // 
            // TextBox_Extension
            // 
            this.TextBox_Extension.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.TextBox_Extension.Location = new System.Drawing.Point(109, 108);
            this.TextBox_Extension.Name = "TextBox_Extension";
            this.TextBox_Extension.Size = new System.Drawing.Size(93, 23);
            this.TextBox_Extension.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(30, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Extension :";
            // 
            // Button_Start
            // 
            this.Button_Start.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.Button_Start.Location = new System.Drawing.Point(286, 434);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(75, 23);
            this.Button_Start.TabIndex = 2;
            this.Button_Start.Text = "Rename";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.tabPage_Rename);
            this.TabControl_Main.Controls.Add(this.tabPage_Replace);
            this.TabControl_Main.Location = new System.Drawing.Point(12, 12);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(635, 416);
            this.TabControl_Main.TabIndex = 3;
            this.TabControl_Main.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Main_Selected);
            // 
            // tabPage_Rename
            // 
            this.tabPage_Rename.Controls.Add(this.TextBox_SourceFolder);
            this.tabPage_Rename.Controls.Add(this.TextBox_TargetFolder);
            this.tabPage_Rename.Controls.Add(this.label4);
            this.tabPage_Rename.Controls.Add(this.TextBox_NewName);
            this.tabPage_Rename.Controls.Add(this.label2);
            this.tabPage_Rename.Controls.Add(this.TextBox_Extension);
            this.tabPage_Rename.Controls.Add(this.label3);
            this.tabPage_Rename.Controls.Add(this.label1);
            this.tabPage_Rename.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Rename.Name = "tabPage_Rename";
            this.tabPage_Rename.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Rename.Size = new System.Drawing.Size(627, 312);
            this.tabPage_Rename.TabIndex = 0;
            this.tabPage_Rename.Text = "Rename";
            this.tabPage_Rename.UseVisualStyleBackColor = true;
            // 
            // tabPage_Replace
            // 
            this.tabPage_Replace.Controls.Add(this.RichTextBox_Display);
            this.tabPage_Replace.Controls.Add(this.TextBox_RPsource);
            this.tabPage_Replace.Controls.Add(this.label6);
            this.tabPage_Replace.Controls.Add(this.TextBox_NewSymbol);
            this.tabPage_Replace.Controls.Add(this.label8);
            this.tabPage_Replace.Controls.Add(this.TextBox_OriSymbol);
            this.tabPage_Replace.Controls.Add(this.label7);
            this.tabPage_Replace.Controls.Add(this.TextBox_RPtarget);
            this.tabPage_Replace.Controls.Add(this.label5);
            this.tabPage_Replace.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Replace.Name = "tabPage_Replace";
            this.tabPage_Replace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Replace.Size = new System.Drawing.Size(627, 390);
            this.tabPage_Replace.TabIndex = 1;
            this.tabPage_Replace.Text = "Replace";
            this.tabPage_Replace.UseVisualStyleBackColor = true;
            // 
            // TextBox_RPsource
            // 
            this.TextBox_RPsource.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.TextBox_RPsource.Location = new System.Drawing.Point(107, 16);
            this.TextBox_RPsource.Name = "TextBox_RPsource";
            this.TextBox_RPsource.Size = new System.Drawing.Size(493, 23);
            this.TextBox_RPsource.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Source c :";
            // 
            // TextBox_RPtarget
            // 
            this.TextBox_RPtarget.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.TextBox_RPtarget.Location = new System.Drawing.Point(107, 45);
            this.TextBox_RPtarget.Name = "TextBox_RPtarget";
            this.TextBox_RPtarget.Size = new System.Drawing.Size(493, 23);
            this.TextBox_RPtarget.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Target Folder :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Original Symbol :";
            // 
            // TextBox_OriSymbol
            // 
            this.TextBox_OriSymbol.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.TextBox_OriSymbol.Location = new System.Drawing.Point(122, 74);
            this.TextBox_OriSymbol.Name = "TextBox_OriSymbol";
            this.TextBox_OriSymbol.Size = new System.Drawing.Size(72, 23);
            this.TextBox_OriSymbol.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(242, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "New Symbol :";
            // 
            // TextBox_NewSymbol
            // 
            this.TextBox_NewSymbol.Font = new System.Drawing.Font("新細明體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.TextBox_NewSymbol.Location = new System.Drawing.Point(337, 74);
            this.TextBox_NewSymbol.Name = "TextBox_NewSymbol";
            this.TextBox_NewSymbol.Size = new System.Drawing.Size(72, 23);
            this.TextBox_NewSymbol.TabIndex = 5;
            // 
            // RichTextBox_Display
            // 
            this.RichTextBox_Display.Location = new System.Drawing.Point(6, 103);
            this.RichTextBox_Display.Name = "RichTextBox_Display";
            this.RichTextBox_Display.ReadOnly = true;
            this.RichTextBox_Display.Size = new System.Drawing.Size(591, 271);
            this.RichTextBox_Display.TabIndex = 8;
            this.RichTextBox_Display.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 512);
            this.Controls.Add(this.TabControl_Main);
            this.Controls.Add(this.Button_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rename Function";
            this.TabControl_Main.ResumeLayout(false);
            this.tabPage_Rename.ResumeLayout(false);
            this.tabPage_Rename.PerformLayout();
            this.tabPage_Replace.ResumeLayout(false);
            this.tabPage_Replace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_SourceFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_TargetFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_NewName;
        private System.Windows.Forms.TextBox TextBox_Extension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Rename;
        private System.Windows.Forms.TabPage tabPage_Replace;
        private System.Windows.Forms.TextBox TextBox_RPsource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_RPtarget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_NewSymbol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBox_OriSymbol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RichTextBox_Display;
    }
}

