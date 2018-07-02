namespace SCW
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpg_control = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_iniciar2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pausa1 = new System.Windows.Forms.Button();
            this.lb_timeRest = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbox_1 = new System.Windows.Forms.ComboBox();
            this.tpg_Nuevo = new System.Windows.Forms.TabPage();
            this.navegador = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_pausar2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpg_control.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpg_control);
            this.tabControl.Controls.Add(this.tpg_Nuevo);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(752, 435);
            this.tabControl.TabIndex = 0;
            // 
            // tpg_control
            // 
            this.tpg_control.BackColor = System.Drawing.Color.Green;
            this.tpg_control.Controls.Add(this.panel2);
            this.tpg_control.Controls.Add(this.label6);
            this.tpg_control.Controls.Add(this.label5);
            this.tpg_control.Controls.Add(this.lbel);
            this.tpg_control.Controls.Add(this.label3);
            this.tpg_control.Controls.Add(this.panel1);
            this.tpg_control.Location = new System.Drawing.Point(4, 22);
            this.tpg_control.Name = "tpg_control";
            this.tpg_control.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_control.Size = new System.Drawing.Size(744, 409);
            this.tpg_control.TabIndex = 0;
            this.tpg_control.Text = "Control";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_pausar2);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.btn_iniciar2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(6, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 51);
            this.panel2.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkGreen;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(595, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(92, 30);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkGreen;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(417, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 30);
            this.textBox3.TabIndex = 6;
            // 
            // btn_iniciar2
            // 
            this.btn_iniciar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_iniciar2.Location = new System.Drawing.Point(258, -2);
            this.btn_iniciar2.Name = "btn_iniciar2";
            this.btn_iniciar2.Size = new System.Drawing.Size(71, 45);
            this.btn_iniciar2.TabIndex = 1;
            this.btn_iniciar2.Text = "Iniciar";
            this.btn_iniciar2.UseVisualStyleBackColor = true;
            this.btn_iniciar2.Click += new System.EventHandler(this.btn_iniciar2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Restante";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tiempo";
            // 
            // lbel
            // 
            this.lbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbel.Location = new System.Drawing.Point(272, 13);
            this.lbel.Name = "lbel";
            this.lbel.Size = new System.Drawing.Size(74, 21);
            this.lbel.TabIndex = 1;
            this.lbel.Text = "Comenzar";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_pausa1);
            this.panel1.Controls.Add(this.lb_timeRest);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbox_1);
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(6, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 51);
            this.panel1.TabIndex = 0;
            // 
            // btn_pausa1
            // 
            this.btn_pausa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pausa1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_pausa1.Location = new System.Drawing.Point(332, 1);
            this.btn_pausa1.Name = "btn_pausa1";
            this.btn_pausa1.Size = new System.Drawing.Size(71, 45);
            this.btn_pausa1.TabIndex = 8;
            this.btn_pausa1.Text = "Pausar";
            this.btn_pausa1.UseVisualStyleBackColor = true;
            this.btn_pausa1.Click += new System.EventHandler(this.btn_pausa1_Click);
            // 
            // lb_timeRest
            // 
            this.lb_timeRest.BackColor = System.Drawing.Color.DarkGreen;
            this.lb_timeRest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_timeRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeRest.Location = new System.Drawing.Point(595, 9);
            this.lb_timeRest.Name = "lb_timeRest";
            this.lb_timeRest.Size = new System.Drawing.Size(92, 30);
            this.lb_timeRest.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(417, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 30);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(258, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbox_1
            // 
            this.cbox_1.FormattingEnabled = true;
            this.cbox_1.Location = new System.Drawing.Point(13, 15);
            this.cbox_1.Name = "cbox_1";
            this.cbox_1.Size = new System.Drawing.Size(208, 21);
            this.cbox_1.TabIndex = 0;
            // 
            // tpg_Nuevo
            // 
            this.tpg_Nuevo.Location = new System.Drawing.Point(4, 22);
            this.tpg_Nuevo.Name = "tpg_Nuevo";
            this.tpg_Nuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_Nuevo.Size = new System.Drawing.Size(744, 409);
            this.tpg_Nuevo.TabIndex = 1;
            this.tpg_Nuevo.Text = "Cliente";
            this.tpg_Nuevo.UseVisualStyleBackColor = true;
            // 
            // navegador
            // 
            this.navegador.Location = new System.Drawing.Point(770, 34);
            this.navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegador.Name = "navegador";
            this.navegador.Size = new System.Drawing.Size(342, 409);
            this.navegador.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_pausar2
            // 
            this.btn_pausar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pausar2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_pausar2.Location = new System.Drawing.Point(332, -3);
            this.btn_pausar2.Name = "btn_pausar2";
            this.btn_pausar2.Size = new System.Drawing.Size(71, 45);
            this.btn_pausar2.TabIndex = 9;
            this.btn_pausar2.Text = "Pausar";
            this.btn_pausar2.UseVisualStyleBackColor = true;
            this.btn_pausar2.Click += new System.EventHandler(this.btn_pausar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 465);
            this.Controls.Add(this.navegador);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tpg_control.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpg_control;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpg_Nuevo;
        private System.Windows.Forms.ComboBox cbox_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser navegador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_iniciar2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox lb_timeRest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_pausa1;
        private System.Windows.Forms.Button btn_pausar2;
    }
}

