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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Many = new System.Windows.Forms.RadioButton();
            this.One = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.by_date = new System.Windows.Forms.RadioButton();
            this.by_name = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rollback = new System.Windows.Forms.CheckBox();
            this.skipping = new System.Windows.Forms.CheckBox();
            this.quick_menu = new System.Windows.Forms.CheckBox();
            this.console = new System.Windows.Forms.CheckBox();
            this.decompile = new System.Windows.Forms.CheckBox();
            this.unpacking = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dump = new System.Windows.Forms.CheckBox();
            this.deobfuscation = new System.Windows.Forms.CheckBox();
            this.Overwrite = new System.Windows.Forms.CheckBox();
            this.open_folder = new System.Windows.Forms.Button();
            this.execute = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.delarchives = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.Size = new System.Drawing.Size(535, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console Log";
            // 
            // console_log
            // 
            this.console_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console_log.Location = new System.Drawing.Point(6, 19);
            this.console_log.Name = "console_log";
            this.console_log.Size = new System.Drawing.Size(523, 135);
            this.console_log.TabIndex = 0;
            this.console_log.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.directories_list);
            this.groupBox2.Controls.Add(this.open_folder);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 269);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game folders";
            // 
            // directories_list
            // 
            this.directories_list.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directories_list.FormattingEnabled = true;
            this.directories_list.ItemHeight = 18;
            this.directories_list.Location = new System.Drawing.Point(5, 19);
            this.directories_list.Name = "directories_list";
            this.directories_list.Size = new System.Drawing.Size(413, 238);
            this.directories_list.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Many);
            this.groupBox4.Controls.Add(this.One);
            this.groupBox4.Location = new System.Drawing.Point(424, 14);
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
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.by_date);
            this.groupBox3.Controls.Add(this.by_name);
            this.groupBox3.Location = new System.Drawing.Point(424, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 72);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sorting";
            // 
            // by_date
            // 
            this.by_date.AutoSize = true;
            this.by_date.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by_date.Location = new System.Drawing.Point(7, 44);
            this.by_date.Name = "by_date";
            this.by_date.Size = new System.Drawing.Size(82, 22);
            this.by_date.TabIndex = 1;
            this.by_date.TabStop = true;
            this.by_date.Text = "by Date";
            this.by_date.UseVisualStyleBackColor = true;
            this.by_date.Click += new System.EventHandler(this.By_date_Click);
            // 
            // by_name
            // 
            this.by_name.AutoSize = true;
            this.by_name.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by_name.Location = new System.Drawing.Point(7, 20);
            this.by_name.Name = "by_name";
            this.by_name.Size = new System.Drawing.Size(82, 22);
            this.by_name.TabIndex = 0;
            this.by_name.TabStop = true;
            this.by_name.Text = "by Name";
            this.by_name.UseVisualStyleBackColor = true;
            this.by_name.Click += new System.EventHandler(this.By_name_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rollback);
            this.groupBox5.Controls.Add(this.skipping);
            this.groupBox5.Controls.Add(this.quick_menu);
            this.groupBox5.Controls.Add(this.console);
            this.groupBox5.Controls.Add(this.decompile);
            this.groupBox5.Controls.Add(this.unpacking);
            this.groupBox5.Location = new System.Drawing.Point(12, 455);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 182);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Executable commands";
            // 
            // rollback
            // 
            this.rollback.AutoSize = true;
            this.rollback.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollback.Location = new System.Drawing.Point(10, 120);
            this.rollback.Name = "rollback";
            this.rollback.Size = new System.Drawing.Size(299, 18);
            this.rollback.TabIndex = 5;
            this.rollback.Text = "6. Force enable rollback (scroll wheel)";
            this.rollback.UseVisualStyleBackColor = true;
            // 
            // skipping
            // 
            this.skipping.AutoSize = true;
            this.skipping.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipping.Location = new System.Drawing.Point(10, 100);
            this.skipping.Name = "skipping";
            this.skipping.Size = new System.Drawing.Size(313, 18);
            this.skipping.TabIndex = 4;
            this.skipping.Text = "5. Force enabling skipping unseen content";
            this.skipping.UseVisualStyleBackColor = true;
            // 
            // quick_menu
            // 
            this.quick_menu.AutoSize = true;
            this.quick_menu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quick_menu.Location = new System.Drawing.Point(10, 80);
            this.quick_menu.Name = "quick_menu";
            this.quick_menu.Size = new System.Drawing.Size(243, 18);
            this.quick_menu.TabIndex = 3;
            this.quick_menu.Text = "4. Enabling quick save and load";
            this.quick_menu.UseVisualStyleBackColor = true;
            // 
            // console
            // 
            this.console.AutoSize = true;
            this.console.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.Location = new System.Drawing.Point(10, 60);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(320, 18);
            this.console.TabIndex = 2;
            this.console.Text = "3. Enabling the developer console and menu";
            this.console.UseVisualStyleBackColor = true;
            // 
            // decompile
            // 
            this.decompile.AutoSize = true;
            this.decompile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompile.Location = new System.Drawing.Point(10, 40);
            this.decompile.Name = "decompile";
            this.decompile.Size = new System.Drawing.Size(152, 18);
            this.decompile.TabIndex = 1;
            this.decompile.Text = "2. Decompile files";
            this.decompile.UseVisualStyleBackColor = true;
            // 
            // unpacking
            // 
            this.unpacking.AutoSize = true;
            this.unpacking.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpacking.Location = new System.Drawing.Point(10, 20);
            this.unpacking.Name = "unpacking";
            this.unpacking.Size = new System.Drawing.Size(110, 18);
            this.unpacking.TabIndex = 0;
            this.unpacking.Text = "1. Unpacking";
            this.unpacking.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dump);
            this.groupBox6.Controls.Add(this.deobfuscation);
            this.groupBox6.Controls.Add(this.Overwrite);
            this.groupBox6.Location = new System.Drawing.Point(361, 455);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(186, 97);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Decompiler options";
            // 
            // dump
            // 
            this.dump.AutoSize = true;
            this.dump.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dump.Location = new System.Drawing.Point(10, 70);
            this.dump.Name = "dump";
            this.dump.Size = new System.Drawing.Size(98, 17);
            this.dump.TabIndex = 2;
            this.dump.Text = "Write a dump";
            this.dump.UseVisualStyleBackColor = true;
            // 
            // deobfuscation
            // 
            this.deobfuscation.AutoSize = true;
            this.deobfuscation.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deobfuscation.Location = new System.Drawing.Point(10, 45);
            this.deobfuscation.Name = "deobfuscation";
            this.deobfuscation.Size = new System.Drawing.Size(104, 17);
            this.deobfuscation.TabIndex = 1;
            this.deobfuscation.Text = "Deobfuscation";
            this.deobfuscation.UseVisualStyleBackColor = true;
            // 
            // Overwrite
            // 
            this.Overwrite.AutoSize = true;
            this.Overwrite.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overwrite.Location = new System.Drawing.Point(10, 20);
            this.Overwrite.Name = "Overwrite";
            this.Overwrite.Size = new System.Drawing.Size(170, 17);
            this.Overwrite.TabIndex = 0;
            this.Overwrite.Text = "Overwrite existing files";
            this.Overwrite.UseVisualStyleBackColor = true;
            // 
            // open_folder
            // 
            this.open_folder.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_folder.Location = new System.Drawing.Point(424, 181);
            this.open_folder.Name = "open_folder";
            this.open_folder.Size = new System.Drawing.Size(105, 76);
            this.open_folder.TabIndex = 6;
            this.open_folder.Text = "Open\r\ngames\r\nfolder";
            this.open_folder.UseVisualStyleBackColor = true;
            this.open_folder.Click += new System.EventHandler(this.Open_folder_Click);
            // 
            // execute
            // 
            this.execute.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute.Location = new System.Drawing.Point(361, 606);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(186, 31);
            this.execute.TabIndex = 7;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.delarchives);
            this.groupBox7.Location = new System.Drawing.Point(361, 558);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(186, 42);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Unpaking options";
            // 
            // delarchives
            // 
            this.delarchives.AutoSize = true;
            this.delarchives.Location = new System.Drawing.Point(7, 18);
            this.delarchives.Name = "delarchives";
            this.delarchives.Size = new System.Drawing.Size(152, 17);
            this.delarchives.TabIndex = 0;
            this.delarchives.Text = "Del unpacked archives";
            this.delarchives.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 645);
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
        private System.Windows.Forms.RadioButton by_date;
        private System.Windows.Forms.RadioButton by_name;
        private System.Windows.Forms.CheckBox rollback;
        private System.Windows.Forms.CheckBox skipping;
        private System.Windows.Forms.CheckBox quick_menu;
        private System.Windows.Forms.CheckBox console;
        private System.Windows.Forms.CheckBox decompile;
        private System.Windows.Forms.CheckBox unpacking;
        private System.Windows.Forms.CheckBox dump;
        private System.Windows.Forms.CheckBox deobfuscation;
        private System.Windows.Forms.CheckBox Overwrite;
        private System.Windows.Forms.ListBox directories_list;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox delarchives;
    }
}

