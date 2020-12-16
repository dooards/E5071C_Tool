namespace E5071C_Tool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_center = new System.Windows.Forms.Button();
            this.textBox_span = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.textBox_stop = new System.Windows.Forms.TextBox();
            this.button_span = new System.Windows.Forms.Button();
            this.textBox_center = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_recall = new System.Windows.Forms.Button();
            this.button_image = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_done = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_short = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            this.textBox_VISA = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_MK6 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_MK1 = new System.Windows.Forms.TextBox();
            this.textBox_MK2 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox_MK5 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox_MK3 = new System.Windows.Forms.TextBox();
            this.textBox_MK4 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_S1PDB = new System.Windows.Forms.Button();
            this.button_hold = new System.Windows.Forms.Button();
            this.button_S1PRI = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_center);
            this.groupBox1.Controls.Add(this.textBox_span);
            this.groupBox1.Controls.Add(this.button_start);
            this.groupBox1.Controls.Add(this.textBox_start);
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.textBox_stop);
            this.groupBox1.Controls.Add(this.button_span);
            this.groupBox1.Controls.Add(this.textBox_center);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency[MHz]";
            // 
            // button_center
            // 
            this.button_center.Location = new System.Drawing.Point(112, 78);
            this.button_center.Name = "button_center";
            this.button_center.Size = new System.Drawing.Size(75, 23);
            this.button_center.TabIndex = 8;
            this.button_center.Text = "CENTER";
            this.button_center.UseVisualStyleBackColor = true;
            this.button_center.Click += new System.EventHandler(this.button_center_Click);
            // 
            // textBox_span
            // 
            this.textBox_span.Location = new System.Drawing.Point(6, 109);
            this.textBox_span.Name = "textBox_span";
            this.textBox_span.Size = new System.Drawing.Size(100, 19);
            this.textBox_span.TabIndex = 7;
            this.textBox_span.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(112, 18);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_start
            // 
            this.textBox_start.Location = new System.Drawing.Point(6, 22);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.Size = new System.Drawing.Size(100, 19);
            this.textBox_start.TabIndex = 5;
            this.textBox_start.Text = "0";
            this.textBox_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(112, 47);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "STOP";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // textBox_stop
            // 
            this.textBox_stop.Location = new System.Drawing.Point(6, 51);
            this.textBox_stop.Name = "textBox_stop";
            this.textBox_stop.Size = new System.Drawing.Size(100, 19);
            this.textBox_stop.TabIndex = 3;
            this.textBox_stop.Text = "0";
            this.textBox_stop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_span
            // 
            this.button_span.Location = new System.Drawing.Point(112, 107);
            this.button_span.Name = "button_span";
            this.button_span.Size = new System.Drawing.Size(75, 23);
            this.button_span.TabIndex = 2;
            this.button_span.Text = "SPAN";
            this.button_span.UseVisualStyleBackColor = true;
            this.button_span.Click += new System.EventHandler(this.button_span_Click);
            // 
            // textBox_center
            // 
            this.textBox_center.Location = new System.Drawing.Point(6, 80);
            this.textBox_center.Name = "textBox_center";
            this.textBox_center.Size = new System.Drawing.Size(100, 19);
            this.textBox_center.TabIndex = 1;
            this.textBox_center.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_num);
            this.groupBox2.Controls.Add(this.button_save);
            this.groupBox2.Controls.Add(this.button_recall);
            this.groupBox2.Location = new System.Drawing.Point(211, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(6, 20);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(75, 19);
            this.textBox_num.TabIndex = 9;
            this.textBox_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(249, 18);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_recall
            // 
            this.button_recall.Location = new System.Drawing.Point(87, 18);
            this.button_recall.Name = "button_recall";
            this.button_recall.Size = new System.Drawing.Size(75, 23);
            this.button_recall.TabIndex = 0;
            this.button_recall.Text = "RECALL";
            this.button_recall.UseVisualStyleBackColor = true;
            this.button_recall.Click += new System.EventHandler(this.button_recall_Click);
            // 
            // button_image
            // 
            this.button_image.Location = new System.Drawing.Point(249, 18);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(75, 23);
            this.button_image.TabIndex = 3;
            this.button_image.Text = "Image";
            this.button_image.UseVisualStyleBackColor = true;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_done);
            this.groupBox3.Controls.Add(this.button_load);
            this.groupBox3.Controls.Add(this.button_short);
            this.groupBox3.Controls.Add(this.button_open);
            this.groupBox3.Location = new System.Drawing.Point(211, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calibration";
            // 
            // button_done
            // 
            this.button_done.Location = new System.Drawing.Point(249, 18);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(75, 23);
            this.button_done.TabIndex = 3;
            this.button_done.Text = "DONE";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(168, 18);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "LOAD";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_short
            // 
            this.button_short.Location = new System.Drawing.Point(87, 18);
            this.button_short.Name = "button_short";
            this.button_short.Size = new System.Drawing.Size(75, 23);
            this.button_short.TabIndex = 1;
            this.button_short.Text = "SHORT";
            this.button_short.UseVisualStyleBackColor = true;
            this.button_short.Click += new System.EventHandler(this.button_short_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(6, 18);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(460, 248);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(75, 23);
            this.button_end.TabIndex = 5;
            this.button_end.Text = "END";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // textBox_VISA
            // 
            this.textBox_VISA.Location = new System.Drawing.Point(12, 248);
            this.textBox_VISA.Name = "textBox_VISA";
            this.textBox_VISA.Size = new System.Drawing.Size(436, 19);
            this.textBox_VISA.TabIndex = 6;
            this.textBox_VISA.Text = "USB0::0x0957::0x0D09::MY46101208::0::INSTR";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.textBox_MK6);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.textBox_MK1);
            this.groupBox4.Controls.Add(this.textBox_MK2);
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.textBox_MK5);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.textBox_MK3);
            this.groupBox4.Controls.Add(this.textBox_MK4);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Location = new System.Drawing.Point(12, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 53);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Marker";
            // 
            // textBox_MK6
            // 
            this.textBox_MK6.Location = new System.Drawing.Point(395, 18);
            this.textBox_MK6.Name = "textBox_MK6";
            this.textBox_MK6.Size = new System.Drawing.Size(30, 19);
            this.textBox_MK6.TabIndex = 17;
            this.textBox_MK6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(431, 21);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(30, 16);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(70, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox_MK1
            // 
            this.textBox_MK1.Location = new System.Drawing.Point(34, 18);
            this.textBox_MK1.Name = "textBox_MK1";
            this.textBox_MK1.Size = new System.Drawing.Size(30, 19);
            this.textBox_MK1.TabIndex = 7;
            this.textBox_MK1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MK2
            // 
            this.textBox_MK2.Location = new System.Drawing.Point(106, 18);
            this.textBox_MK2.Name = "textBox_MK2";
            this.textBox_MK2.Size = new System.Drawing.Size(30, 19);
            this.textBox_MK2.TabIndex = 9;
            this.textBox_MK2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(359, 21);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(30, 16);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(142, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 16);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox_MK5
            // 
            this.textBox_MK5.Location = new System.Drawing.Point(322, 19);
            this.textBox_MK5.Name = "textBox_MK5";
            this.textBox_MK5.Size = new System.Drawing.Size(30, 19);
            this.textBox_MK5.TabIndex = 15;
            this.textBox_MK5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(214, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(30, 16);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox_MK3
            // 
            this.textBox_MK3.Location = new System.Drawing.Point(178, 18);
            this.textBox_MK3.Name = "textBox_MK3";
            this.textBox_MK3.Size = new System.Drawing.Size(30, 19);
            this.textBox_MK3.TabIndex = 13;
            this.textBox_MK3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MK4
            // 
            this.textBox_MK4.Location = new System.Drawing.Point(250, 18);
            this.textBox_MK4.Name = "textBox_MK4";
            this.textBox_MK4.Size = new System.Drawing.Size(30, 19);
            this.textBox_MK4.TabIndex = 11;
            this.textBox_MK4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(286, 21);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(30, 16);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_S1PDB);
            this.groupBox5.Controls.Add(this.button_hold);
            this.groupBox5.Controls.Add(this.button_S1PRI);
            this.groupBox5.Controls.Add(this.button_image);
            this.groupBox5.Location = new System.Drawing.Point(211, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(330, 53);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SAVE";
            // 
            // button_S1PDB
            // 
            this.button_S1PDB.Location = new System.Drawing.Point(87, 18);
            this.button_S1PDB.Name = "button_S1PDB";
            this.button_S1PDB.Size = new System.Drawing.Size(75, 23);
            this.button_S1PDB.TabIndex = 4;
            this.button_S1PDB.Text = "S1P DB";
            this.button_S1PDB.UseVisualStyleBackColor = true;
            this.button_S1PDB.Click += new System.EventHandler(this.button_S1PDB_Click);
            // 
            // button_hold
            // 
            this.button_hold.Location = new System.Drawing.Point(168, 18);
            this.button_hold.Name = "button_hold";
            this.button_hold.Size = new System.Drawing.Size(75, 23);
            this.button_hold.TabIndex = 7;
            this.button_hold.Text = "Hold";
            this.button_hold.UseVisualStyleBackColor = true;
            this.button_hold.Click += new System.EventHandler(this.button_hold_Click);
            // 
            // button_S1PRI
            // 
            this.button_S1PRI.Location = new System.Drawing.Point(6, 18);
            this.button_S1PRI.Name = "button_S1PRI";
            this.button_S1PRI.Size = new System.Drawing.Size(75, 23);
            this.button_S1PRI.TabIndex = 0;
            this.button_S1PRI.Text = "S1P RI";
            this.button_S1PRI.UseVisualStyleBackColor = true;
            this.button_S1PRI.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(18, 154);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(181, 19);
            this.textBox_log.TabIndex = 9;
            this.textBox_log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(482, 21);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(30, 16);
            this.checkBox7.TabIndex = 18;
            this.checkBox7.Text = "7";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 282);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox_VISA);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "E5071C Control V1.00";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TextBox textBox_stop;
        private System.Windows.Forms.Button button_span;
        private System.Windows.Forms.TextBox textBox_center;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_recall;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_short;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.TextBox textBox_VISA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_MK6;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox_MK5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox textBox_MK3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox_MK4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox_MK2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox_MK1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_center;
        private System.Windows.Forms.TextBox textBox_span;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_S1PDB;
        private System.Windows.Forms.Button button_S1PRI;
        private System.Windows.Forms.Button button_hold;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.CheckBox checkBox7;
    }
}

