namespace PythonExecuter
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_python_script = new System.Windows.Forms.Button();
            this.btn_work_dir = new System.Windows.Forms.Button();
            this.btn_python_dir = new System.Windows.Forms.Button();
            this.txt_python_cmd = new System.Windows.Forms.TextBox();
            this.txt_work_dir = new System.Windows.Forms.TextBox();
            this.txt_python_dir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exec = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_python_script);
            this.groupBox1.Controls.Add(this.btn_work_dir);
            this.groupBox1.Controls.Add(this.btn_python_dir);
            this.groupBox1.Controls.Add(this.txt_python_cmd);
            this.groupBox1.Controls.Add(this.txt_work_dir);
            this.groupBox1.Controls.Add(this.txt_python_dir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Python Settings";
            // 
            // btn_python_script
            // 
            this.btn_python_script.Location = new System.Drawing.Point(698, 111);
            this.btn_python_script.Name = "btn_python_script";
            this.btn_python_script.Size = new System.Drawing.Size(75, 23);
            this.btn_python_script.TabIndex = 8;
            this.btn_python_script.Text = "Browse";
            this.btn_python_script.UseVisualStyleBackColor = true;
            this.btn_python_script.Click += new System.EventHandler(this.btn_python_script_Click);
            // 
            // btn_work_dir
            // 
            this.btn_work_dir.Location = new System.Drawing.Point(698, 59);
            this.btn_work_dir.Name = "btn_work_dir";
            this.btn_work_dir.Size = new System.Drawing.Size(75, 23);
            this.btn_work_dir.TabIndex = 7;
            this.btn_work_dir.Text = "Browse";
            this.btn_work_dir.UseVisualStyleBackColor = true;
            this.btn_work_dir.Click += new System.EventHandler(this.btn_work_dir_Click);
            // 
            // btn_python_dir
            // 
            this.btn_python_dir.Location = new System.Drawing.Point(698, 17);
            this.btn_python_dir.Name = "btn_python_dir";
            this.btn_python_dir.Size = new System.Drawing.Size(75, 23);
            this.btn_python_dir.TabIndex = 6;
            this.btn_python_dir.Text = "Browse";
            this.btn_python_dir.UseVisualStyleBackColor = true;
            this.btn_python_dir.Click += new System.EventHandler(this.btn_python_dir_Click);
            // 
            // txt_python_cmd
            // 
            this.txt_python_cmd.Location = new System.Drawing.Point(111, 111);
            this.txt_python_cmd.Name = "txt_python_cmd";
            this.txt_python_cmd.Size = new System.Drawing.Size(578, 19);
            this.txt_python_cmd.TabIndex = 5;
            // 
            // txt_work_dir
            // 
            this.txt_work_dir.Location = new System.Drawing.Point(111, 61);
            this.txt_work_dir.Name = "txt_work_dir";
            this.txt_work_dir.Size = new System.Drawing.Size(578, 19);
            this.txt_work_dir.TabIndex = 4;
            // 
            // txt_python_dir
            // 
            this.txt_python_dir.Location = new System.Drawing.Point(111, 19);
            this.txt_python_dir.Name = "txt_python_dir";
            this.txt_python_dir.Size = new System.Drawing.Size(578, 19);
            this.txt_python_dir.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Python Script";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Working Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Python Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_input);
            this.groupBox2.Location = new System.Drawing.Point(15, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_input.Location = new System.Drawing.Point(9, 18);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(764, 77);
            this.txt_input.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_output);
            this.groupBox3.Location = new System.Drawing.Point(15, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 350);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(7, 18);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_output.Size = new System.Drawing.Size(764, 326);
            this.txt_output.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(103, 639);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exec
            // 
            this.btn_exec.Location = new System.Drawing.Point(22, 639);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(75, 23);
            this.btn_exec.TabIndex = 5;
            this.btn_exec.Text = "Execute(&E)";
            this.btn_exec.UseVisualStyleBackColor = true;
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(184, 639);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel(&C)";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(711, 639);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit(&E)";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "C:\\Users\\XXX\\anaconda3\\envs\\XXX\\python.exe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "C:\\Users\\XXX\\";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "XXX.py args";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 674);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Python Executor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_work_dir;
        private System.Windows.Forms.Button btn_python_dir;
        private System.Windows.Forms.TextBox txt_python_cmd;
        private System.Windows.Forms.TextBox txt_work_dir;
        private System.Windows.Forms.TextBox txt_python_dir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_python_script;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

