namespace lab_6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.A_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.C_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.B_vector_dgv = new System.Windows.Forms.DataGridView();
            this.X_vector_dgv = new System.Windows.Forms.DataGridView();
            this.NUD_rozmir = new System.Windows.Forms.NumericUpDown();
            this.BCreateGrid = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Method = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).BeginInit();
            this.SuspendLayout();
            // 
            // A_matrix_dgv
            // 
            this.A_matrix_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.A_matrix_dgv.BackgroundColor = System.Drawing.Color.MistyRose;
            this.A_matrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_matrix_dgv.Location = new System.Drawing.Point(93, 114);
            this.A_matrix_dgv.Name = "A_matrix_dgv";
            this.A_matrix_dgv.RowHeadersWidth = 51;
            this.A_matrix_dgv.Size = new System.Drawing.Size(280, 173);
            this.A_matrix_dgv.TabIndex = 0;
            this.A_matrix_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.A_matrix_dgv_CellClick);
            // 
            // C_matrix_dgv
            // 
            this.C_matrix_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.C_matrix_dgv.BackgroundColor = System.Drawing.Color.MistyRose;
            this.C_matrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C_matrix_dgv.Location = new System.Drawing.Point(93, 323);
            this.C_matrix_dgv.Name = "C_matrix_dgv";
            this.C_matrix_dgv.RowHeadersWidth = 51;
            this.C_matrix_dgv.Size = new System.Drawing.Size(280, 173);
            this.C_matrix_dgv.TabIndex = 1;
            // 
            // B_vector_dgv
            // 
            this.B_vector_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.B_vector_dgv.BackgroundColor = System.Drawing.Color.MistyRose;
            this.B_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B_vector_dgv.Location = new System.Drawing.Point(480, 114);
            this.B_vector_dgv.Name = "B_vector_dgv";
            this.B_vector_dgv.RowHeadersWidth = 51;
            this.B_vector_dgv.Size = new System.Drawing.Size(119, 173);
            this.B_vector_dgv.TabIndex = 2;
            this.B_vector_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B_vector_dgv_CellClick);
            // 
            // X_vector_dgv
            // 
            this.X_vector_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.X_vector_dgv.BackgroundColor = System.Drawing.Color.MistyRose;
            this.X_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.X_vector_dgv.Location = new System.Drawing.Point(649, 116);
            this.X_vector_dgv.Name = "X_vector_dgv";
            this.X_vector_dgv.RowHeadersWidth = 51;
            this.X_vector_dgv.Size = new System.Drawing.Size(119, 173);
            this.X_vector_dgv.TabIndex = 3;
            // 
            // NUD_rozmir
            // 
            this.NUD_rozmir.Location = new System.Drawing.Point(297, 16);
            this.NUD_rozmir.Name = "NUD_rozmir";
            this.NUD_rozmir.Size = new System.Drawing.Size(79, 27);
            this.NUD_rozmir.TabIndex = 4;
            this.NUD_rozmir.ValueChanged += new System.EventHandler(this.NUD_rozmir_ValueChanged);
            // 
            // BCreateGrid
            // 
            this.BCreateGrid.BackColor = System.Drawing.SystemColors.Control;
            this.BCreateGrid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.BCreateGrid.Location = new System.Drawing.Point(490, 352);
            this.BCreateGrid.Name = "BCreateGrid";
            this.BCreateGrid.Size = new System.Drawing.Size(122, 33);
            this.BCreateGrid.TabIndex = 5;
            this.BCreateGrid.Text = "Розвʼязати";
            this.BCreateGrid.UseVisualStyleBackColor = false;
            this.BCreateGrid.Click += new System.EventHandler(this.BCreateGrid_Click);
            // 
            // BClear
            // 
            this.BClear.BackColor = System.Drawing.SystemColors.Control;
            this.BClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.BClear.Location = new System.Drawing.Point(649, 352);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(119, 33);
            this.BClear.TabIndex = 6;
            this.BClear.Text = "Очистити";
            this.BClear.UseVisualStyleBackColor = false;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BClose
            // 
            this.BClose.BackColor = System.Drawing.SystemColors.Control;
            this.BClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.BClose.Location = new System.Drawing.Point(569, 401);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(115, 32);
            this.BClose.TabIndex = 7;
            this.BClose.Text = "Вихід";
            this.BClose.UseVisualStyleBackColor = false;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оберіть розмір матриці А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(106, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Матриця А коефіцієнтів СЛАР";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(89, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Матриця С коефіцієнтів L/U розкладу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(502, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вектор В";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(676, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Вектор Х";
            // 
            // CB_Method
            // 
            this.CB_Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Method.FormattingEnabled = true;
            this.CB_Method.Items.AddRange(new object[] {
            "Метод LU-розкладу",
            "Метод Гауса"});
            this.CB_Method.Location = new System.Drawing.Point(662, 20);
            this.CB_Method.Name = "CB_Method";
            this.CB_Method.Size = new System.Drawing.Size(121, 27);
            this.CB_Method.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(589, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Метод:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(869, 528);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_Method);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BCreateGrid);
            this.Controls.Add(this.NUD_rozmir);
            this.Controls.Add(this.X_vector_dgv);
            this.Controls.Add(this.B_vector_dgv);
            this.Controls.Add(this.C_matrix_dgv);
            this.Controls.Add(this.A_matrix_dgv);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "Form1";
            this.Text = "Димчак Дана. Метод L/U перетворення для розвʼязання СЛАР";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView A_matrix_dgv;
        private System.Windows.Forms.DataGridView C_matrix_dgv;
        private System.Windows.Forms.DataGridView B_vector_dgv;
        private System.Windows.Forms.DataGridView X_vector_dgv;
        private System.Windows.Forms.NumericUpDown NUD_rozmir;
        private System.Windows.Forms.Button BCreateGrid;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5;
        private System.Windows.Forms.ComboBox CB_Method;
        private System.Windows.Forms.Label label6;
    }
}
