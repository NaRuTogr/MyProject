namespace BDLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршруткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водійToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зупинкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звітToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.проToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціБДToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.проToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціБДToolStripMenuItem
            // 
            this.таблиціБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.маршруткаToolStripMenuItem,
            this.маршрутToolStripMenuItem,
            this.водійToolStripMenuItem,
            this.зупинкаToolStripMenuItem});
            this.таблиціБДToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.таблиціБДToolStripMenuItem.Name = "таблиціБДToolStripMenuItem";
            this.таблиціБДToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.таблиціБДToolStripMenuItem.Text = "Таблиці БД";
            // 
            // маршруткаToolStripMenuItem
            // 
            this.маршруткаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("маршруткаToolStripMenuItem.Image")));
            this.маршруткаToolStripMenuItem.Name = "маршруткаToolStripMenuItem";
            this.маршруткаToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.маршруткаToolStripMenuItem.Text = "Маршрутка";
            this.маршруткаToolStripMenuItem.Click += new System.EventHandler(this.маршруткаToolStripMenuItem_Click);
            // 
            // маршрутToolStripMenuItem
            // 
            this.маршрутToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("маршрутToolStripMenuItem.Image")));
            this.маршрутToolStripMenuItem.Name = "маршрутToolStripMenuItem";
            this.маршрутToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.маршрутToolStripMenuItem.Text = "Маршрут";
            this.маршрутToolStripMenuItem.Click += new System.EventHandler(this.маршрутToolStripMenuItem_Click_1);
            // 
            // водійToolStripMenuItem
            // 
            this.водійToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("водійToolStripMenuItem.Image")));
            this.водійToolStripMenuItem.Name = "водійToolStripMenuItem";
            this.водійToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.водійToolStripMenuItem.Text = "Водій";
            this.водійToolStripMenuItem.Click += new System.EventHandler(this.водійToolStripMenuItem_Click_1);
            // 
            // зупинкаToolStripMenuItem
            // 
            this.зупинкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("зупинкаToolStripMenuItem.Image")));
            this.зупинкаToolStripMenuItem.Name = "зупинкаToolStripMenuItem";
            this.зупинкаToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.зупинкаToolStripMenuItem.Text = "Зупинка";
            this.зупинкаToolStripMenuItem.Click += new System.EventHandler(this.зупинкаToolStripMenuItem_Click_1);
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.звітToolStripMenuItem,
            this.калькуляторToolStripMenuItem1});
            this.калькуляторToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.калькуляторToolStripMenuItem.Text = "Додаток";
            // 
            // звітToolStripMenuItem
            // 
            this.звітToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("звітToolStripMenuItem.Image")));
            this.звітToolStripMenuItem.Name = "звітToolStripMenuItem";
            this.звітToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.звітToolStripMenuItem.Text = "Звіт";
            this.звітToolStripMenuItem.Click += new System.EventHandler(this.звітToolStripMenuItem_Click);
            // 
            // калькуляторToolStripMenuItem1
            // 
            this.калькуляторToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("калькуляторToolStripMenuItem1.Image")));
            this.калькуляторToolStripMenuItem1.Name = "калькуляторToolStripMenuItem1";
            this.калькуляторToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.калькуляторToolStripMenuItem1.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem1.Click += new System.EventHandler(this.калькуляторToolStripMenuItem1_Click);
            // 
            // проToolStripMenuItem
            // 
            this.проToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.вийтиToolStripMenuItem});
            this.проToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.проToolStripMenuItem.Name = "проToolStripMenuItem";
            this.проToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.проToolStripMenuItem.Text = "Про програму";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("проПрограмуToolStripMenuItem.Image")));
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вийтиToolStripMenuItem.Image")));
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.вийтиToolStripMenuItem.Text = "Вийти";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршруткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водійToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зупинкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem звітToolStripMenuItem;
    }
}

