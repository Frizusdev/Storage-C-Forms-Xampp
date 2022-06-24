namespace Magazyn
{
    partial class Form2
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
            this.additem = new System.Windows.Forms.Button();
            this.dedlitem = new System.Windows.Forms.Button();
            this.edititem = new System.Windows.Forms.Button();
            this.addorder = new System.Windows.Forms.Button();
            this.delorder = new System.Windows.Forms.Button();
            this.editorder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.producent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addpos = new System.Windows.Forms.Button();
            this.showorder = new System.Windows.Forms.Button();
            this.tablename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new Magazyn.Controls.RJToggleButton();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // additem
            // 
            this.additem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.additem.Location = new System.Drawing.Point(12, 12);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(173, 62);
            this.additem.TabIndex = 0;
            this.additem.Text = "Dodaj Przedmiot";
            this.additem.UseVisualStyleBackColor = true;
            this.additem.Click += new System.EventHandler(this.additem_Click);
            // 
            // dedlitem
            // 
            this.dedlitem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dedlitem.Location = new System.Drawing.Point(12, 80);
            this.dedlitem.Name = "dedlitem";
            this.dedlitem.Size = new System.Drawing.Size(173, 62);
            this.dedlitem.TabIndex = 1;
            this.dedlitem.Text = "Usuń Przedmiot";
            this.dedlitem.UseVisualStyleBackColor = true;
            this.dedlitem.Click += new System.EventHandler(this.dedlitem_Click);
            // 
            // edititem
            // 
            this.edititem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edititem.Location = new System.Drawing.Point(12, 148);
            this.edititem.Name = "edititem";
            this.edititem.Size = new System.Drawing.Size(173, 62);
            this.edititem.TabIndex = 3;
            this.edititem.Text = "Edytuj Przedmiot";
            this.edititem.UseVisualStyleBackColor = true;
            this.edititem.Click += new System.EventHandler(this.edititem_Click);
            // 
            // addorder
            // 
            this.addorder.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addorder.Location = new System.Drawing.Point(12, 216);
            this.addorder.Name = "addorder";
            this.addorder.Size = new System.Drawing.Size(173, 62);
            this.addorder.TabIndex = 4;
            this.addorder.Text = "Dodaj Zamówienie";
            this.addorder.UseVisualStyleBackColor = true;
            this.addorder.Click += new System.EventHandler(this.addorder_Click);
            // 
            // delorder
            // 
            this.delorder.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delorder.Location = new System.Drawing.Point(12, 285);
            this.delorder.Name = "delorder";
            this.delorder.Size = new System.Drawing.Size(173, 62);
            this.delorder.TabIndex = 5;
            this.delorder.Text = "Usuń Zamówienie";
            this.delorder.UseVisualStyleBackColor = true;
            this.delorder.Click += new System.EventHandler(this.delorder_Click);
            // 
            // editorder
            // 
            this.editorder.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editorder.Location = new System.Drawing.Point(12, 353);
            this.editorder.Name = "editorder";
            this.editorder.Size = new System.Drawing.Size(173, 62);
            this.editorder.TabIndex = 6;
            this.editorder.Text = "Zmień Nazwe Zamówienia";
            this.editorder.UseVisualStyleBackColor = true;
            this.editorder.Click += new System.EventHandler(this.editorder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(597, 335);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Przedmiotu:";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id.Location = new System.Drawing.Point(189, 383);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 29);
            this.id.TabIndex = 9;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(348, 383);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 29);
            this.name.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(335, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwa Przedmiotu:";
            // 
            // producent
            // 
            this.producent.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.producent.Location = new System.Drawing.Point(686, 383);
            this.producent.Name = "producent";
            this.producent.Size = new System.Drawing.Size(100, 29);
            this.producent.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(686, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Producent:";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantity.Location = new System.Drawing.Point(516, 383);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 29);
            this.quantity.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(516, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ilość:";
            // 
            // addpos
            // 
            this.addpos.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addpos.Location = new System.Drawing.Point(226, 489);
            this.addpos.Name = "addpos";
            this.addpos.Size = new System.Drawing.Size(173, 62);
            this.addpos.TabIndex = 16;
            this.addpos.Text = "Dodaj Pozycje ";
            this.addpos.UseVisualStyleBackColor = true;
            this.addpos.Click += new System.EventHandler(this.addpos_Click);
            // 
            // showorder
            // 
            this.showorder.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showorder.Location = new System.Drawing.Point(12, 421);
            this.showorder.Name = "showorder";
            this.showorder.Size = new System.Drawing.Size(173, 62);
            this.showorder.TabIndex = 18;
            this.showorder.Text = "Szczegóły Zamówienia ";
            this.showorder.UseVisualStyleBackColor = true;
            this.showorder.Click += new System.EventHandler(this.showorder_Click);
            // 
            // tablename
            // 
            this.tablename.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tablename.Location = new System.Drawing.Point(191, 454);
            this.tablename.Name = "tablename";
            this.tablename.Size = new System.Drawing.Size(100, 29);
            this.tablename.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(191, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nazwa Zamówienia:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(743, 461);
            this.checkBox1.MinimumSize = new System.Drawing.Size(45, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.OffBackColor = System.Drawing.Color.Gray;
            this.checkBox1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.checkBox1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Size = new System.Drawing.Size(45, 22);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(719, 437);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(87, 21);
            this.label.TabIndex = 22;
            this.label.Text = "Zamówienia:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(624, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 62);
            this.button1.TabIndex = 23;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(405, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 62);
            this.button2.TabIndex = 24;
            this.button2.Text = "Usuń Pozycje ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(12, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 62);
            this.button3.TabIndex = 25;
            this.button3.Text = "Edytuj Pozycje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(348, 454);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(348, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nowa Nazwa Zamówienia:";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(809, 563);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tablename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showorder);
            this.Controls.Add(this.addpos);
            this.Controls.Add(this.producent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editorder);
            this.Controls.Add(this.delorder);
            this.Controls.Add(this.addorder);
            this.Controls.Add(this.edititem);
            this.Controls.Add(this.dedlitem);
            this.Controls.Add(this.additem);
            this.MinimumSize = new System.Drawing.Size(825, 466);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button additem;
        private Button dedlitem;
        private Button edititem;
        private Button addorder;
        private Button delorder;
        private Button editorder;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox id;
        private TextBox name;
        private Label label2;
        private TextBox producent;
        private Label label3;
        private TextBox quantity;
        private Label label4;
        private Button addpos;
        private Button showorder;
        private TextBox tablename;
        private Label label5;
        private Controls.RJToggleButton checkBox1;
        private Label label;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label6;
    }
}