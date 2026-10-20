namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblProteins = new System.Windows.Forms.Label();
            this.txtProteins = new System.Windows.Forms.TextBox();
            this.lblFats = new System.Windows.Forms.Label();
            this.txtFats = new System.Windows.Forms.TextBox();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEntries = new System.Windows.Forms.Label();
            this.lstEntries = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 35);
            this.lblTitle.Text = "АС «Дневник питания» v1.0";

            // lblName, txtName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 85);
            this.lblName.Text = "Название продукта:";
            this.txtName.Location = new System.Drawing.Point(15, 105);
            this.txtName.Size = new System.Drawing.Size(250, 20);

            // lblCalories, txtCalories
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(15, 140);
            this.lblCalories.Text = "Калории (ккал):";
            this.txtCalories.Location = new System.Drawing.Point(15, 160);
            this.txtCalories.Size = new System.Drawing.Size(120, 20);
            this.txtCalories.Text = "0";

            // lblProteins, txtProteins
            this.lblProteins.AutoSize = true;
            this.lblProteins.Location = new System.Drawing.Point(150, 140);
            this.lblProteins.Text = "Белки (г):";
            this.txtProteins.Location = new System.Drawing.Point(150, 160);
            this.txtProteins.Size = new System.Drawing.Size(60, 20);
            this.txtProteins.Text = "0";

            // lblFats, txtFats
            this.lblFats.AutoSize = true;
            this.lblFats.Location = new System.Drawing.Point(220, 140);
            this.lblFats.Text = "Жиры (г):";
            this.txtFats.Location = new System.Drawing.Point(220, 160);
            this.txtFats.Size = new System.Drawing.Size(60, 20);
            this.txtFats.Text = "0";

            // lblCarbs, txtCarbs
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Location = new System.Drawing.Point(290, 140);
            this.lblCarbs.Text = "Углеводы (г):";
            this.txtCarbs.Location = new System.Drawing.Point(290, 160);
            this.txtCarbs.Size = new System.Drawing.Size(60, 20);
            this.txtCarbs.Text = "0";

            // btnAdd, btnClear
            this.btnAdd.Location = new System.Drawing.Point(15, 200);
            this.btnAdd.Size = new System.Drawing.Size(160, 35);
            this.btnAdd.Text = "Добавить запись";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnClear.Location = new System.Drawing.Point(185, 200);
            this.btnClear.Size = new System.Drawing.Size(160, 35);
            this.btnClear.Text = "Очистить день";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblEntries, lstEntries
            this.lblEntries.AutoSize = true;
            this.lblEntries.Location = new System.Drawing.Point(15, 250);
            this.lblEntries.Text = "Записи за сегодня:";

            this.lstEntries.Location = new System.Drawing.Point(15, 270);
            this.lstEntries.Size = new System.Drawing.Size(330, 130);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(15, 410);
            this.lblTotal.Text = "Всего за день: 0 ккал";

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.statusLabel });
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusLabel.Text = "Готово к работе";

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.файлToolStripMenuItem, this.справкаToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);

            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.выходToolStripMenuItem });
            this.файлToolStripMenuItem.Text = "Файл";

            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);

            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.оПрограммеToolStripMenuItem });
            this.справкаToolStripMenuItem.Text = "Справка";

            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstEntries);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCarbs);
            this.Controls.Add(this.lblCarbs);
            this.Controls.Add(this.txtFats);
            this.Controls.Add(this.lblFats);
            this.Controls.Add(this.txtProteins);
            this.Controls.Add(this.lblProteins);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АС «Дневник питания»";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Label lblProteins;
        private System.Windows.Forms.TextBox txtProteins;
        private System.Windows.Forms.Label lblFats;
        private System.Windows.Forms.TextBox txtFats;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.ListBox lstEntries;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}