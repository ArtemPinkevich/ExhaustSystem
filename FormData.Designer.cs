namespace Silencer
{
    partial class FormData
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSilencerLength = new System.Windows.Forms.TextBox();
            this.txtSilenserWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSilenserHeight = new System.Windows.Forms.TextBox();
            this.txtPipeOutLength = new System.Windows.Forms.TextBox();
            this.txtPipeOutDiameter = new System.Windows.Forms.TextBox();
            this.txtPipeOutInnerDiameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPipeInDiameter = new System.Windows.Forms.TextBox();
            this.txtPipeInInnerDiameter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBendLength = new System.Windows.Forms.TextBox();
            this.txtBendRadius = new System.Windows.Forms.TextBox();
            this.txtBendAngle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSilencerLength
            // 
            this.txtSilencerLength.Location = new System.Drawing.Point(12, 19);
            this.txtSilencerLength.Name = "txtSilencerLength";
            this.txtSilencerLength.Size = new System.Drawing.Size(55, 20);
            this.txtSilencerLength.TabIndex = 11;
            this.txtSilencerLength.Text = "100";
            this.txtSilencerLength.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtSilencerLength.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtSilencerLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtSilenserWidth
            // 
            this.txtSilenserWidth.Location = new System.Drawing.Point(12, 45);
            this.txtSilenserWidth.Name = "txtSilenserWidth";
            this.txtSilenserWidth.Size = new System.Drawing.Size(55, 20);
            this.txtSilenserWidth.TabIndex = 12;
            this.txtSilenserWidth.Text = "50";
            this.txtSilenserWidth.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtSilenserWidth.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtSilenserWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Длина (L)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ширина (W)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Высота (H)";
            // 
            // txtSilenserHeight
            // 
            this.txtSilenserHeight.Location = new System.Drawing.Point(12, 71);
            this.txtSilenserHeight.Name = "txtSilenserHeight";
            this.txtSilenserHeight.Size = new System.Drawing.Size(55, 20);
            this.txtSilenserHeight.TabIndex = 16;
            this.txtSilenserHeight.Text = "30";
            this.txtSilenserHeight.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtSilenserHeight.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtSilenserHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtPipeOutLength
            // 
            this.txtPipeOutLength.Location = new System.Drawing.Point(12, 19);
            this.txtPipeOutLength.Name = "txtPipeOutLength";
            this.txtPipeOutLength.Size = new System.Drawing.Size(55, 20);
            this.txtPipeOutLength.TabIndex = 19;
            this.txtPipeOutLength.Text = "40";
            this.txtPipeOutLength.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtPipeOutLength.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtPipeOutLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtPipeOutDiameter
            // 
            this.txtPipeOutDiameter.BackColor = System.Drawing.SystemColors.Window;
            this.txtPipeOutDiameter.Location = new System.Drawing.Point(12, 45);
            this.txtPipeOutDiameter.Name = "txtPipeOutDiameter";
            this.txtPipeOutDiameter.Size = new System.Drawing.Size(55, 20);
            this.txtPipeOutDiameter.TabIndex = 20;
            this.txtPipeOutDiameter.Text = "16";
            this.txtPipeOutDiameter.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtPipeOutDiameter.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtPipeOutDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtPipeOutInnerDiameter
            // 
            this.txtPipeOutInnerDiameter.Location = new System.Drawing.Point(12, 71);
            this.txtPipeOutInnerDiameter.Name = "txtPipeOutInnerDiameter";
            this.txtPipeOutInnerDiameter.Size = new System.Drawing.Size(55, 20);
            this.txtPipeOutInnerDiameter.TabIndex = 21;
            this.txtPipeOutInnerDiameter.Text = "14";
            this.txtPipeOutInnerDiameter.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtPipeOutInnerDiameter.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtPipeOutInnerDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Длина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Диаметр (D)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Диаметр (d)";
            // 
            // txtPipeInDiameter
            // 
            this.txtPipeInDiameter.Location = new System.Drawing.Point(12, 19);
            this.txtPipeInDiameter.Name = "txtPipeInDiameter";
            this.txtPipeInDiameter.Size = new System.Drawing.Size(55, 20);
            this.txtPipeInDiameter.TabIndex = 26;
            this.txtPipeInDiameter.Text = "12";
            this.txtPipeInDiameter.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtPipeInDiameter.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtPipeInDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtPipeInInnerDiameter
            // 
            this.txtPipeInInnerDiameter.Location = new System.Drawing.Point(12, 45);
            this.txtPipeInInnerDiameter.Name = "txtPipeInInnerDiameter";
            this.txtPipeInInnerDiameter.Size = new System.Drawing.Size(55, 20);
            this.txtPipeInInnerDiameter.TabIndex = 27;
            this.txtPipeInInnerDiameter.Text = "10";
            this.txtPipeInInnerDiameter.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtPipeInInnerDiameter.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtPipeInInnerDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Диаметр (D)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Диаметр (d)";
            // 
            // txtBendLength
            // 
            this.txtBendLength.Location = new System.Drawing.Point(6, 19);
            this.txtBendLength.Name = "txtBendLength";
            this.txtBendLength.Size = new System.Drawing.Size(55, 20);
            this.txtBendLength.TabIndex = 31;
            this.txtBendLength.Text = "60";
            this.txtBendLength.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtBendLength.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtBendLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtBendRadius
            // 
            this.txtBendRadius.Location = new System.Drawing.Point(6, 45);
            this.txtBendRadius.Name = "txtBendRadius";
            this.txtBendRadius.Size = new System.Drawing.Size(55, 20);
            this.txtBendRadius.TabIndex = 32;
            this.txtBendRadius.Text = "80";
            this.txtBendRadius.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtBendRadius.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtBendRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtBendAngle
            // 
            this.txtBendAngle.Location = new System.Drawing.Point(6, 71);
            this.txtBendAngle.Name = "txtBendAngle";
            this.txtBendAngle.Size = new System.Drawing.Size(55, 20);
            this.txtBendAngle.TabIndex = 33;
            this.txtBendAngle.Text = "90";
            this.txtBendAngle.TextChanged += new System.EventHandler(this.txtSpace_TextChanged);
            this.txtBendAngle.Enter += new System.EventHandler(this.textBox1SilencerL_Enter);
            this.txtBendAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Длина (L)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Радиус (R)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Угол (g)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(369, 243);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 37);
            this.btnStart.TabIndex = 37;
            this.btnStart.Text = "Построение";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSilencerLength);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSilenserWidth);
            this.groupBox1.Controls.Add(this.txtSilenserHeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Глушитель";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPipeOutLength);
            this.groupBox2.Controls.Add(this.txtPipeOutDiameter);
            this.groupBox2.Controls.Add(this.txtPipeOutInnerDiameter);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Труба выходящая";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtPipeInDiameter);
            this.groupBox3.Controls.Add(this.txtPipeInInnerDiameter);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 182);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Труба входящая";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBendLength);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtBendRadius);
            this.groupBox4.Controls.Add(this.txtBendAngle);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(6, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 100);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Изгиб";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 235);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(478, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Глушитель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Silencer.Properties.Resources.Глушитель;
            this.pictureBox1.Location = new System.Drawing.Point(210, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(478, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Труба (вых.)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Silencer.Properties.Resources.Диаметры2;
            this.pictureBox3.Location = new System.Drawing.Point(210, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(261, 197);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(478, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Труба (вх.)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Silencer.Properties.Resources.Изгиб3;
            this.pictureBox2.Location = new System.Drawing.Point(220, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(8, 241);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(189, 13);
            this.lblError.TabIndex = 42;
            this.lblError.Text = "Все поля должны быть заполнены!!";
            this.lblError.Visible = false;
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 287);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnStart);
            this.Name = "FormData";
            this.Text = "Глушитель";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSilencerLength;
        private System.Windows.Forms.TextBox txtSilenserWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSilenserHeight;
        private System.Windows.Forms.TextBox txtPipeOutLength;
        private System.Windows.Forms.TextBox txtPipeOutDiameter;
        private System.Windows.Forms.TextBox txtPipeOutInnerDiameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPipeInDiameter;
        private System.Windows.Forms.TextBox txtPipeInInnerDiameter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBendLength;
        private System.Windows.Forms.TextBox txtBendRadius;
        private System.Windows.Forms.TextBox txtBendAngle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblError;
    }
}

