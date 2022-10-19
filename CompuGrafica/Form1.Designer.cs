namespace CompuGrafica
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pARCIALIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onePixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dibujoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banderaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dosColoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosColoresConDegradadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degradadoAMARILLOVERDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dibujarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parabolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarPantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encenderSegmentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCircunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejesXYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dibujoTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 24);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(700, 500);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pARCIALIToolStripMenuItem,
            this.aCCIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pARCIALIToolStripMenuItem
            // 
            this.pARCIALIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelToolStripMenuItem,
            this.banderaToolStripMenuItem1,
            this.vectorToolStripMenuItem,
            this.segmentoToolStripMenuItem,
            this.circunferenciaToolStripMenuItem});
            this.pARCIALIToolStripMenuItem.Name = "pARCIALIToolStripMenuItem";
            this.pARCIALIToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.pARCIALIToolStripMenuItem.Text = "PARCIAL I";
            // 
            // pixelToolStripMenuItem
            // 
            this.pixelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onePixelToolStripMenuItem,
            this.dibujoToolStripMenuItem});
            this.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            this.pixelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pixelToolStripMenuItem.Text = "1. Pixel";
            // 
            // onePixelToolStripMenuItem
            // 
            this.onePixelToolStripMenuItem.Name = "onePixelToolStripMenuItem";
            this.onePixelToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.onePixelToolStripMenuItem.Text = "One Pixel";
            this.onePixelToolStripMenuItem.Click += new System.EventHandler(this.onePixelToolStripMenuItem_Click);
            // 
            // dibujoToolStripMenuItem
            // 
            this.dibujoToolStripMenuItem.Name = "dibujoToolStripMenuItem";
            this.dibujoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dibujoToolStripMenuItem.Text = "Dibujo";
            this.dibujoToolStripMenuItem.Click += new System.EventHandler(this.dibujoToolStripMenuItem_Click);
            // 
            // banderaToolStripMenuItem1
            // 
            this.banderaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosColoresToolStripMenuItem,
            this.dosColoresConDegradadoToolStripMenuItem,
            this.degradadoAMARILLOVERDEToolStripMenuItem});
            this.banderaToolStripMenuItem1.Name = "banderaToolStripMenuItem1";
            this.banderaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.banderaToolStripMenuItem1.Text = "2. Bandera";
            // 
            // dosColoresToolStripMenuItem
            // 
            this.dosColoresToolStripMenuItem.Name = "dosColoresToolStripMenuItem";
            this.dosColoresToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.dosColoresToolStripMenuItem.Text = "Dos Colores";
            this.dosColoresToolStripMenuItem.Click += new System.EventHandler(this.dosColoresToolStripMenuItem_Click);
            // 
            // dosColoresConDegradadoToolStripMenuItem
            // 
            this.dosColoresConDegradadoToolStripMenuItem.Name = "dosColoresConDegradadoToolStripMenuItem";
            this.dosColoresConDegradadoToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.dosColoresConDegradadoToolStripMenuItem.Text = "Dos Colores con degradado";
            this.dosColoresConDegradadoToolStripMenuItem.Click += new System.EventHandler(this.dosColoresConDegradadoToolStripMenuItem_ClickAsync);
            // 
            // degradadoAMARILLOVERDEToolStripMenuItem
            // 
            this.degradadoAMARILLOVERDEToolStripMenuItem.Name = "degradadoAMARILLOVERDEToolStripMenuItem";
            this.degradadoAMARILLOVERDEToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.degradadoAMARILLOVERDEToolStripMenuItem.Text = "Degradado AMARILLO/VERDE";
            this.degradadoAMARILLOVERDEToolStripMenuItem.Click += new System.EventHandler(this.degradadoAMARILLOVERDEToolStripMenuItem_Click);
            // 
            // vectorToolStripMenuItem
            // 
            this.vectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encenderToolStripMenuItem,
            this.dibujarToolStripMenuItem,
            this.parabolaToolStripMenuItem});
            this.vectorToolStripMenuItem.Name = "vectorToolStripMenuItem";
            this.vectorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vectorToolStripMenuItem.Text = "3. Vector";
            // 
            // encenderToolStripMenuItem
            // 
            this.encenderToolStripMenuItem.Name = "encenderToolStripMenuItem";
            this.encenderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.encenderToolStripMenuItem.Text = "Encender";
            this.encenderToolStripMenuItem.Click += new System.EventHandler(this.encenderToolStripMenuItem_Click);
            // 
            // dibujarToolStripMenuItem
            // 
            this.dibujarToolStripMenuItem.Name = "dibujarToolStripMenuItem";
            this.dibujarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dibujarToolStripMenuItem.Text = "Dibujar";
            this.dibujarToolStripMenuItem.Click += new System.EventHandler(this.dibujarToolStripMenuItem_Click);
            // 
            // parabolaToolStripMenuItem
            // 
            this.parabolaToolStripMenuItem.Name = "parabolaToolStripMenuItem";
            this.parabolaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.parabolaToolStripMenuItem.Text = "Secuencia x^2";
            this.parabolaToolStripMenuItem.Click += new System.EventHandler(this.parabolaToolStripMenuItem_Click);
            // 
            // aCCIONESToolStripMenuItem
            // 
            this.aCCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarPantallaToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.aCCIONESToolStripMenuItem.Name = "aCCIONESToolStripMenuItem";
            this.aCCIONESToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.aCCIONESToolStripMenuItem.Text = "ACCIONES";
            // 
            // limpiarPantallaToolStripMenuItem
            // 
            this.limpiarPantallaToolStripMenuItem.Name = "limpiarPantallaToolStripMenuItem";
            this.limpiarPantallaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.limpiarPantallaToolStripMenuItem.Text = "Limpiar pantalla";
            this.limpiarPantallaToolStripMenuItem.Click += new System.EventHandler(this.limpiarPantallaToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligthToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.darkModeToolStripMenuItem.Text = "DarkMode";
            // 
            // ligthToolStripMenuItem
            // 
            this.ligthToolStripMenuItem.Name = "ligthToolStripMenuItem";
            this.ligthToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.ligthToolStripMenuItem.Text = "Light";
            this.ligthToolStripMenuItem.Click += new System.EventHandler(this.ligthToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // segmentoToolStripMenuItem
            // 
            this.segmentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encenderSegmentoToolStripMenuItem,
            this.ejesXYToolStripMenuItem});
            this.segmentoToolStripMenuItem.Name = "segmentoToolStripMenuItem";
            this.segmentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.segmentoToolStripMenuItem.Text = "4. Segmento";
            // 
            // encenderSegmentoToolStripMenuItem
            // 
            this.encenderSegmentoToolStripMenuItem.Name = "encenderSegmentoToolStripMenuItem";
            this.encenderSegmentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encenderSegmentoToolStripMenuItem.Text = "Encender Segmento";
            this.encenderSegmentoToolStripMenuItem.Click += new System.EventHandler(this.encenderSegmentoToolStripMenuItem_Click);
            // 
            // circunferenciaToolStripMenuItem
            // 
            this.circunferenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCircunferenciaToolStripMenuItem,
            this.dibujoTareaToolStripMenuItem});
            this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
            this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circunferenciaToolStripMenuItem.Text = "5. Circunferencia";
            // 
            // crearCircunferenciaToolStripMenuItem
            // 
            this.crearCircunferenciaToolStripMenuItem.Name = "crearCircunferenciaToolStripMenuItem";
            this.crearCircunferenciaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.crearCircunferenciaToolStripMenuItem.Text = "Crear Circunferencia";
            this.crearCircunferenciaToolStripMenuItem.Click += new System.EventHandler(this.crearCircunferenciaToolStripMenuItem_Click);
            // 
            // ejesXYToolStripMenuItem
            // 
            this.ejesXYToolStripMenuItem.Name = "ejesXYToolStripMenuItem";
            this.ejesXYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejesXYToolStripMenuItem.Text = "EjesXY";
            this.ejesXYToolStripMenuItem.Click += new System.EventHandler(this.ejesXYToolStripMenuItem_Click);
            // 
            // dibujoTareaToolStripMenuItem
            // 
            this.dibujoTareaToolStripMenuItem.Name = "dibujoTareaToolStripMenuItem";
            this.dibujoTareaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dibujoTareaToolStripMenuItem.Text = "Dibujo tarea";
            this.dibujoTareaToolStripMenuItem.Click += new System.EventHandler(this.dibujoTareaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 524);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computacion Grafica - Richard Vinueza | 6745";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pARCIALIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onePixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dibujoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banderaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dosColoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosColoresConDegradadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degradadoAMARILLOVERDEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarPantallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dibujarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parabolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encenderSegmentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCircunferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejesXYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dibujoTareaToolStripMenuItem;
    }
}

