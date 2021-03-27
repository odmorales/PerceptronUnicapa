
namespace Perceptron
{
    partial class Presentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasYSalidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umbralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMaxText = new System.Windows.Forms.TextBox();
            this.rataText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iteracionesText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.errorPatronText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iteracionActual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.activacionCombo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.salidaText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.botonEntrenar = new System.Windows.Forms.Button();
            this.tablaUmbral = new System.Windows.Forms.DataGridView();
            this.tablaPesos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.somaText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.constanteText = new System.Windows.Forms.TextBox();
            this.umbralText = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tablaEntradasIdeales = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.entradasIText = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUmbral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPesos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntradasIdeales)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarDatosToolStripMenuItem
            // 
            this.cargarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasYSalidasToolStripMenuItem,
            this.pesosToolStripMenuItem,
            this.umbralToolStripMenuItem});
            this.cargarDatosToolStripMenuItem.Name = "cargarDatosToolStripMenuItem";
            this.cargarDatosToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.cargarDatosToolStripMenuItem.Text = "Cargar datos";
            // 
            // entradasYSalidasToolStripMenuItem
            // 
            this.entradasYSalidasToolStripMenuItem.Name = "entradasYSalidasToolStripMenuItem";
            this.entradasYSalidasToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.entradasYSalidasToolStripMenuItem.Text = "Entradas y salidas";
            this.entradasYSalidasToolStripMenuItem.Click += new System.EventHandler(this.entradasYSalidasToolStripMenuItem_Click);
            // 
            // pesosToolStripMenuItem
            // 
            this.pesosToolStripMenuItem.Name = "pesosToolStripMenuItem";
            this.pesosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.pesosToolStripMenuItem.Text = "Pesos";
            this.pesosToolStripMenuItem.Click += new System.EventHandler(this.pesosToolStripMenuItem_Click);
            // 
            // umbralToolStripMenuItem
            // 
            this.umbralToolStripMenuItem.Name = "umbralToolStripMenuItem";
            this.umbralToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.umbralToolStripMenuItem.Text = "Umbral";
            this.umbralToolStripMenuItem.Click += new System.EventHandler(this.umbralToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // errorMaxText
            // 
            this.errorMaxText.Location = new System.Drawing.Point(13, 58);
            this.errorMaxText.Name = "errorMaxText";
            this.errorMaxText.Size = new System.Drawing.Size(100, 20);
            this.errorMaxText.TabIndex = 2;
            // 
            // rataText
            // 
            this.rataText.Location = new System.Drawing.Point(225, 58);
            this.rataText.Name = "rataText";
            this.rataText.Size = new System.Drawing.Size(100, 20);
            this.rataText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rata de aprendizaje";
            // 
            // iteracionesText
            // 
            this.iteracionesText.Location = new System.Drawing.Point(119, 58);
            this.iteracionesText.Name = "iteracionesText";
            this.iteracionesText.Size = new System.Drawing.Size(100, 20);
            this.iteracionesText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iteraciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 115);
            this.dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datos generados ";
            // 
            // errorPatronText
            // 
            this.errorPatronText.Location = new System.Drawing.Point(62, 396);
            this.errorPatronText.Name = "errorPatronText";
            this.errorPatronText.Size = new System.Drawing.Size(100, 20);
            this.errorPatronText.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Error iteracion";
            // 
            // iteracionActual
            // 
            this.iteracionActual.Location = new System.Drawing.Point(168, 396);
            this.iteracionActual.Name = "iteracionActual";
            this.iteracionActual.Size = new System.Drawing.Size(100, 20);
            this.iteracionActual.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Iteracion actual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Error maximo";
            // 
            // activacionCombo
            // 
            this.activacionCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione",
            "Lineal",
            "Escalon",
            "Sigmoide"});
            this.activacionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activacionCombo.FormattingEnabled = true;
            this.activacionCombo.Items.AddRange(new object[] {
            "LINEAL",
            "ESCALON",
            "SIGMOIDE"});
            this.activacionCombo.Location = new System.Drawing.Point(124, 222);
            this.activacionCombo.Name = "activacionCombo";
            this.activacionCombo.Size = new System.Drawing.Size(144, 21);
            this.activacionCombo.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(122, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Funcion de activacion";
            // 
            // salidaText
            // 
            this.salidaText.Location = new System.Drawing.Point(304, 198);
            this.salidaText.Name = "salidaText";
            this.salidaText.Size = new System.Drawing.Size(56, 20);
            this.salidaText.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Salida Red";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // botonEntrenar
            // 
            this.botonEntrenar.Location = new System.Drawing.Point(324, 318);
            this.botonEntrenar.Name = "botonEntrenar";
            this.botonEntrenar.Size = new System.Drawing.Size(75, 23);
            this.botonEntrenar.TabIndex = 30;
            this.botonEntrenar.Text = "Entrenar";
            this.botonEntrenar.UseVisualStyleBackColor = true;
            this.botonEntrenar.Click += new System.EventHandler(this.botonEntrenar_Click);
            // 
            // tablaUmbral
            // 
            this.tablaUmbral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUmbral.Location = new System.Drawing.Point(12, 374);
            this.tablaUmbral.Name = "tablaUmbral";
            this.tablaUmbral.Size = new System.Drawing.Size(286, 64);
            this.tablaUmbral.TabIndex = 31;
            // 
            // tablaPesos
            // 
            this.tablaPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPesos.Location = new System.Drawing.Point(13, 267);
            this.tablaPesos.Name = "tablaPesos";
            this.tablaPesos.Size = new System.Drawing.Size(285, 72);
            this.tablaPesos.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Entradas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(124, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Pesos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(114, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Umbral";
            // 
            // somaText
            // 
            this.somaText.Location = new System.Drawing.Point(36, 222);
            this.somaText.Name = "somaText";
            this.somaText.Size = new System.Drawing.Size(72, 20);
            this.somaText.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(55, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Net";
            // 
            // constanteText
            // 
            this.constanteText.Enabled = false;
            this.constanteText.Location = new System.Drawing.Point(110, 40);
            this.constanteText.Name = "constanteText";
            this.constanteText.Size = new System.Drawing.Size(31, 20);
            this.constanteText.TabIndex = 39;
            // 
            // umbralText
            // 
            this.umbralText.Location = new System.Drawing.Point(163, 94);
            this.umbralText.Name = "umbralText";
            this.umbralText.Size = new System.Drawing.Size(31, 20);
            this.umbralText.TabIndex = 40;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(331, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 515);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.umbralText);
            this.tabPage1.Controls.Add(this.activacionCombo);
            this.tabPage1.Controls.Add(this.constanteText);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.salidaText);
            this.tabPage1.Controls.Add(this.botonEntrenar);
            this.tabPage1.Controls.Add(this.errorPatronText);
            this.tabPage1.Controls.Add(this.somaText);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.iteracionActual);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrenar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Perceptron.Properties.Resources.Screenshot_3;
            this.pictureBox1.Location = new System.Drawing.Point(22, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSimular);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tablaEntradasIdeales);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.entradasIText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(430, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simular";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablaEntradasIdeales
            // 
            this.tablaEntradasIdeales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEntradasIdeales.Location = new System.Drawing.Point(6, 79);
            this.tablaEntradasIdeales.Name = "tablaEntradasIdeales";
            this.tablaEntradasIdeales.Size = new System.Drawing.Size(205, 65);
            this.tablaEntradasIdeales.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Ingresar entradas:";
            // 
            // entradasIText
            // 
            this.entradasIText.Location = new System.Drawing.Point(19, 53);
            this.entradasIText.Name = "entradasIText";
            this.entradasIText.Size = new System.Drawing.Size(100, 20);
            this.entradasIText.TabIndex = 0;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(19, 155);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 4;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 505);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tablaPesos);
            this.Controls.Add(this.tablaUmbral);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iteracionesText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rataText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorMaxText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Presentacion";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUmbral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPesos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntradasIdeales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasYSalidasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox errorMaxText;
        private System.Windows.Forms.TextBox rataText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iteracionesText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox errorPatronText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iteracionActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox activacionCombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox salidaText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button botonEntrenar;
        private System.Windows.Forms.DataGridView tablaUmbral;
        private System.Windows.Forms.DataGridView tablaPesos;
        private System.Windows.Forms.ToolStripMenuItem pesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umbralToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox somaText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox constanteText;
        private System.Windows.Forms.TextBox umbralText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox entradasIText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tablaEntradasIdeales;
        private System.Windows.Forms.Button btnSimular;
    }
}

