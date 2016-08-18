namespace Interfaces_IO_Hombre_Maquina
{
    partial class Form_Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox_Puertos = new System.Windows.Forms.ComboBox();
            this.groupBox_PuertoSerial = new System.Windows.Forms.GroupBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.groupBox_Datos = new System.Windows.Forms.GroupBox();
            this.chart_Datos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Iniciar = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox_caracter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_PuertoSerial.SuspendLayout();
            this.groupBox_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Datos)).BeginInit();
            this.groupBox_Control.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Puertos
            // 
            this.comboBox_Puertos.FormattingEnabled = true;
            this.comboBox_Puertos.Location = new System.Drawing.Point(6, 19);
            this.comboBox_Puertos.Name = "comboBox_Puertos";
            this.comboBox_Puertos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Puertos.TabIndex = 0;
            // 
            // groupBox_PuertoSerial
            // 
            this.groupBox_PuertoSerial.Controls.Add(this.button_Refresh);
            this.groupBox_PuertoSerial.Controls.Add(this.comboBox_Puertos);
            this.groupBox_PuertoSerial.Location = new System.Drawing.Point(12, 12);
            this.groupBox_PuertoSerial.Name = "groupBox_PuertoSerial";
            this.groupBox_PuertoSerial.Size = new System.Drawing.Size(222, 53);
            this.groupBox_PuertoSerial.TabIndex = 1;
            this.groupBox_PuertoSerial.TabStop = false;
            this.groupBox_PuertoSerial.Text = "Puerto Serial Arduino";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(133, 17);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // groupBox_Datos
            // 
            this.groupBox_Datos.Controls.Add(this.chart_Datos);
            this.groupBox_Datos.Location = new System.Drawing.Point(12, 72);
            this.groupBox_Datos.Name = "groupBox_Datos";
            this.groupBox_Datos.Size = new System.Drawing.Size(711, 353);
            this.groupBox_Datos.TabIndex = 2;
            this.groupBox_Datos.TabStop = false;
            this.groupBox_Datos.Text = "Grafica";
            // 
            // chart_Datos
            // 
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.chart_Datos.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_Datos.Legends.Add(legend1);
            this.chart_Datos.Location = new System.Drawing.Point(6, 19);
            this.chart_Datos.Name = "chart_Datos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Datos.Series.Add(series1);
            this.chart_Datos.Size = new System.Drawing.Size(699, 328);
            this.chart_Datos.TabIndex = 0;
            this.chart_Datos.Text = "Datos del Arduino";
            // 
            // groupBox_Control
            // 
            this.groupBox_Control.Controls.Add(this.button_Stop);
            this.groupBox_Control.Controls.Add(this.button_Iniciar);
            this.groupBox_Control.Location = new System.Drawing.Point(241, 13);
            this.groupBox_Control.Name = "groupBox_Control";
            this.groupBox_Control.Size = new System.Drawing.Size(190, 53);
            this.groupBox_Control.TabIndex = 3;
            this.groupBox_Control.TabStop = false;
            this.groupBox_Control.Text = "Control de la ejecucion";
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(88, 15);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 1;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Iniciar
            // 
            this.button_Iniciar.Location = new System.Drawing.Point(7, 15);
            this.button_Iniciar.Name = "button_Iniciar";
            this.button_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.button_Iniciar.TabIndex = 0;
            this.button_Iniciar.Text = "Iniciar";
            this.button_Iniciar.UseVisualStyleBackColor = true;
            this.button_Iniciar.Click += new System.EventHandler(this.button_Iniciar_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_caracter
            // 
            this.textBox_caracter.Location = new System.Drawing.Point(124, 19);
            this.textBox_caracter.Name = "textBox_caracter";
            this.textBox_caracter.Size = new System.Drawing.Size(42, 20);
            this.textBox_caracter.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_caracter);
            this.groupBox1.Location = new System.Drawing.Point(438, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracter Obtenido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ing. Hazael Fernando Mojica García";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(735, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Control);
            this.Controls.Add(this.groupBox_Datos);
            this.Controls.Add(this.groupBox_PuertoSerial);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "Proyecto de Interfaces IO Hombre Máquina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_PuertoSerial.ResumeLayout(false);
            this.groupBox_Datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Datos)).EndInit();
            this.groupBox_Control.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Puertos;
        private System.Windows.Forms.GroupBox groupBox_PuertoSerial;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.GroupBox groupBox_Datos;
        private System.Windows.Forms.GroupBox groupBox_Control;
        private System.Windows.Forms.Button button_Iniciar;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Datos;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox_caracter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

