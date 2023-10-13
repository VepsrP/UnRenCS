namespace UnRenCS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.console_log = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.directories_list = new System.Windows.Forms.ListBox();
            this.open_folder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Many = new System.Windows.Forms.RadioButton();
            this.One = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.By_Date = new System.Windows.Forms.RadioButton();
            this.By_Name = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Rollback = new System.Windows.Forms.CheckBox();
            this.Skipping = new System.Windows.Forms.CheckBox();
            this.Quick_menu = new System.Windows.Forms.CheckBox();
            this.Console = new System.Windows.Forms.CheckBox();
            this.Decompile = new System.Windows.Forms.CheckBox();
            this.Unpacking = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Dump = new System.Windows.Forms.CheckBox();
            this.Deobfuscation = new System.Windows.Forms.CheckBox();
            this.Overwrite = new System.Windows.Forms.CheckBox();
            this.execute = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Delarchives = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.console_log);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console Log";
            // 
            // console_log
            // 
            this.console_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console_log.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.console_log.Location = new System.Drawing.Point(6, 19);
            this.console_log.Name = "console_log";
            this.console_log.ReadOnly = true;
            this.console_log.Size = new System.Drawing.Size(807, 233);
            this.console_log.TabIndex = 0;
            this.console_log.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.directories_list);
            this.groupBox2.Controls.Add(this.open_folder);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 269);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game folders";
            // 
            // directories_list
            // 
            this.directories_list.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directories_list.FormattingEnabled = true;
            this.directories_list.ItemHeight = 19;
            this.directories_list.Location = new System.Drawing.Point(5, 19);
            this.directories_list.Name = "directories_list";
            this.directories_list.Size = new System.Drawing.Size(697, 232);
            this.directories_list.TabIndex = 2;
            // 
            // open_folder
            // 
            this.open_folder.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_folder.Location = new System.Drawing.Point(708, 181);
            this.open_folder.Name = "open_folder";
            this.open_folder.Size = new System.Drawing.Size(105, 76);
            this.open_folder.TabIndex = 6;
            this.open_folder.Text = "Open\r\ngames\r\nfolder";
            this.open_folder.UseVisualStyleBackColor = true;
            this.open_folder.Click += new System.EventHandler(this.Open_folder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Many);
            this.groupBox4.Controls.Add(this.One);
            this.groupBox4.Location = new System.Drawing.Point(708, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(105, 83);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount of games";
            // 
            // Many
            // 
            this.Many.AutoSize = true;
            this.Many.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Many.Location = new System.Drawing.Point(7, 54);
            this.Many.Name = "Many";
            this.Many.Size = new System.Drawing.Size(58, 22);
            this.Many.TabIndex = 1;
            this.Many.TabStop = true;
            this.Many.Text = "Many";
            this.Many.UseVisualStyleBackColor = true;
            this.Many.Click += new System.EventHandler(this.Many_Click);
            // 
            // One
            // 
            this.One.AutoSize = true;
            this.One.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(7, 30);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(50, 22);
            this.One.TabIndex = 0;
            this.One.TabStop = true;
            this.One.Text = "One";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.By_Date);
            this.groupBox3.Controls.Add(this.By_Name);
            this.groupBox3.Location = new System.Drawing.Point(708, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 72);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sorting";
            // 
            // By_Date
            // 
            this.By_Date.AutoSize = true;
            this.By_Date.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.By_Date.Location = new System.Drawing.Point(7, 44);
            this.By_Date.Name = "By_Date";
            this.By_Date.Size = new System.Drawing.Size(82, 22);
            this.By_Date.TabIndex = 1;
            this.By_Date.TabStop = true;
            this.By_Date.Text = "by Date";
            this.By_Date.UseVisualStyleBackColor = true;
            this.By_Date.Click += new System.EventHandler(this.By_date_Click);
            // 
            // By_Name
            // 
            this.By_Name.AutoSize = true;
            this.By_Name.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.By_Name.Location = new System.Drawing.Point(7, 20);
            this.By_Name.Name = "By_Name";
            this.By_Name.Size = new System.Drawing.Size(82, 22);
            this.By_Name.TabIndex = 0;
            this.By_Name.TabStop = true;
            this.By_Name.Text = "by Name";
            this.By_Name.UseVisualStyleBackColor = true;
            this.By_Name.Click += new System.EventHandler(this.By_name_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Rollback);
            this.groupBox5.Controls.Add(this.Skipping);
            this.groupBox5.Controls.Add(this.Quick_menu);
            this.groupBox5.Controls.Add(this.Console);
            this.groupBox5.Controls.Add(this.Decompile);
            this.groupBox5.Controls.Add(this.Unpacking);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(12, 554);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(555, 182);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Executable commands";
            // 
            // Rollback
            // 
            this.Rollback.AutoSize = true;
            this.Rollback.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rollback.Location = new System.Drawing.Point(5, 145);
            this.Rollback.Name = "Rollback";
            this.Rollback.Size = new System.Drawing.Size(379, 23);
            this.Rollback.TabIndex = 5;
            this.Rollback.Text = "6. Force enable rollback (scroll wheel)";
            this.Rollback.UseVisualStyleBackColor = true;
            // 
            // Skipping
            // 
            this.Skipping.AutoSize = true;
            this.Skipping.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Skipping.Location = new System.Drawing.Point(5, 120);
            this.Skipping.Name = "Skipping";
            this.Skipping.Size = new System.Drawing.Size(397, 23);
            this.Skipping.TabIndex = 4;
            this.Skipping.Text = "5. Force enabling skipping unseen content";
            this.Skipping.UseVisualStyleBackColor = true;
            // 
            // Quick_menu
            // 
            this.Quick_menu.AutoSize = true;
            this.Quick_menu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quick_menu.Location = new System.Drawing.Point(5, 95);
            this.Quick_menu.Name = "Quick_menu";
            this.Quick_menu.Size = new System.Drawing.Size(307, 23);
            this.Quick_menu.TabIndex = 3;
            this.Quick_menu.Text = "4. Enabling quick save and load";
            this.Quick_menu.UseVisualStyleBackColor = true;
            // 
            // Console
            // 
            this.Console.AutoSize = true;
            this.Console.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Console.Location = new System.Drawing.Point(5, 70);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(406, 23);
            this.Console.TabIndex = 2;
            this.Console.Text = "3. Enabling the developer console and menu";
            this.Console.UseVisualStyleBackColor = true;
            // 
            // Decompile
            // 
            this.Decompile.AutoSize = true;
            this.Decompile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decompile.Location = new System.Drawing.Point(5, 45);
            this.Decompile.Name = "Decompile";
            this.Decompile.Size = new System.Drawing.Size(190, 23);
            this.Decompile.TabIndex = 1;
            this.Decompile.Text = "2. Decompile files";
            this.Decompile.UseVisualStyleBackColor = true;
            // 
            // Unpacking
            // 
            this.Unpacking.AutoSize = true;
            this.Unpacking.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unpacking.Location = new System.Drawing.Point(5, 20);
            this.Unpacking.Name = "Unpacking";
            this.Unpacking.Size = new System.Drawing.Size(136, 23);
            this.Unpacking.TabIndex = 0;
            this.Unpacking.Text = "1. Unpacking";
            this.Unpacking.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Dump);
            this.groupBox6.Controls.Add(this.Deobfuscation);
            this.groupBox6.Controls.Add(this.Overwrite);
            this.groupBox6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(573, 554);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(258, 97);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Decompiler options";
            // 
            // Dump
            // 
            this.Dump.AutoSize = true;
            this.Dump.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dump.Location = new System.Drawing.Point(10, 70);
            this.Dump.Name = "Dump";
            this.Dump.Size = new System.Drawing.Size(136, 23);
            this.Dump.TabIndex = 2;
            this.Dump.Text = "Write a dump";
            this.Dump.UseVisualStyleBackColor = true;
            // 
            // Deobfuscation
            // 
            this.Deobfuscation.AutoSize = true;
            this.Deobfuscation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deobfuscation.Location = new System.Drawing.Point(10, 45);
            this.Deobfuscation.Name = "Deobfuscation";
            this.Deobfuscation.Size = new System.Drawing.Size(145, 23);
            this.Deobfuscation.TabIndex = 1;
            this.Deobfuscation.Text = "Deobfuscation";
            this.Deobfuscation.UseVisualStyleBackColor = true;
            // 
            // Overwrite
            // 
            this.Overwrite.AutoSize = true;
            this.Overwrite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Overwrite.Location = new System.Drawing.Point(10, 20);
            this.Overwrite.Name = "Overwrite";
            this.Overwrite.Size = new System.Drawing.Size(244, 23);
            this.Overwrite.TabIndex = 0;
            this.Overwrite.Text = "Overwrite existing files";
            this.Overwrite.UseVisualStyleBackColor = true;
            // 
            // execute
            // 
            this.execute.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute.Location = new System.Drawing.Point(573, 705);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(255, 31);
            this.execute.TabIndex = 7;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Delarchives);
            this.groupBox7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(573, 655);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(258, 42);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Unpaking options";
            // 
            // Delarchives
            // 
            this.Delarchives.AutoSize = true;
            this.Delarchives.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delarchives.Location = new System.Drawing.Point(7, 18);
            this.Delarchives.Name = "Delarchives";
            this.Delarchives.Size = new System.Drawing.Size(217, 23);
            this.Delarchives.TabIndex = 0;
            this.Delarchives.Text = "Del unpacked archives";
            this.Delarchives.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 752);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnRenGui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox console_log;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button open_folder;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.RadioButton Many;
        private System.Windows.Forms.RadioButton One;
        private System.Windows.Forms.RadioButton By_Date;
        private System.Windows.Forms.RadioButton By_Name;
        private System.Windows.Forms.CheckBox Rollback;
        private System.Windows.Forms.CheckBox Skipping;
        private System.Windows.Forms.CheckBox Quick_menu;
        private System.Windows.Forms.CheckBox Console;
        private System.Windows.Forms.CheckBox Decompile;
        private System.Windows.Forms.CheckBox Unpacking;
        private System.Windows.Forms.CheckBox Dump;
        private System.Windows.Forms.CheckBox Deobfuscation;
        private System.Windows.Forms.CheckBox Overwrite;
        private System.Windows.Forms.ListBox directories_list;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox Delarchives;
    }
}

