namespace WinForm
{
    partial class Operation
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameRentalDataSet = new WinForm.GameRentalDataSet();
            this.gameRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMETableAdapter = new WinForm.GameRentalDataSetTableAdapters.GAMETableAdapter();
            this.gAMESDataSet = new WinForm.GAMESDataSet();
            this.gameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter1 = new WinForm.GAMESDataSetTableAdapters.GameTableAdapter();
            this.tableAdapterManager = new WinForm.GAMESDataSetTableAdapters.TableAdapterManager();
            this.gAMESDataSet1 = new WinForm.GAMESDataSet1();
            this.gameBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter2 = new WinForm.GAMESDataSet1TableAdapters.GameTableAdapter();
            this.tableAdapterManager1 = new WinForm.GAMESDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMESDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(458, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "RENT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "End Date";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(397, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 27);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(397, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(289, 27);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(397, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 27);
            this.textBox1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(469, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "GAME";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(274, 615);
            this.splitter1.TabIndex = 25;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 32);
            this.button2.TabIndex = 26;
            this.button2.Text = "Update Profile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Desktop;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(30, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 32);
            this.button3.TabIndex = 27;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gAMEBindingSource
            // 
            this.gAMEBindingSource.DataMember = "GAME";
            this.gAMEBindingSource.DataSource = this.gameRentalDataSet;
            // 
            // gameRentalDataSet
            // 
            this.gameRentalDataSet.DataSetName = "GameRentalDataSet";
            this.gameRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameRentalDataSetBindingSource
            // 
            this.gameRentalDataSetBindingSource.DataSource = this.gameRentalDataSet;
            this.gameRentalDataSetBindingSource.Position = 0;
            // 
            // gAMETableAdapter
            // 
            this.gAMETableAdapter.ClearBeforeFill = true;
            // 
            // gAMESDataSet
            // 
            this.gAMESDataSet.DataSetName = "GAMESDataSet";
            this.gAMESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource1
            // 
            this.gameBindingSource1.DataMember = "Game";
            this.gameBindingSource1.DataSource = this.gAMESDataSet;
            // 
            // gameTableAdapter1
            // 
            this.gameTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrowseeTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.GameTableAdapter = this.gameTableAdapter1;
            this.tableAdapterManager.RentTableAdapter = null;
            this.tableAdapterManager.ReturnnTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinForm.GAMESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // gAMESDataSet1
            // 
            this.gAMESDataSet1.DataSetName = "GAMESDataSet1";
            this.gAMESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource2
            // 
            this.gameBindingSource2.DataMember = "Game";
            this.gameBindingSource2.DataSource = this.gAMESDataSet1;
            // 
            // gameTableAdapter2
            // 
            this.gameTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AccountTableAdapter = null;
            this.tableAdapterManager1.AdminTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BrowseeTableAdapter = null;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.GameTableAdapter = this.gameTableAdapter2;
            this.tableAdapterManager1.RentTableAdapter = null;
            this.tableAdapterManager1.ReturnnTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WinForm.GAMESDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(753, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 196);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Desktop;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(933, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 32);
            this.button4.TabIndex = 33;
            this.button4.Text = "show";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Desktop;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(586, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 35;
            this.button5.Text = "CLOSE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(30, 252);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 22);
            this.textBox4.TabIndex = 36;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(30, 315);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 22);
            this.textBox5.TabIndex = 37;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(30, 381);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(184, 22);
            this.textBox6.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "vendor";
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 615);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Operation";
            this.Text = "Operation";
            this.Load += new System.EventHandler(this.Operation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMESDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource gameRentalDataSetBindingSource;
        private GameRentalDataSet gameRentalDataSet;
        private System.Windows.Forms.BindingSource gAMEBindingSource;
        private GameRentalDataSetTableAdapters.GAMETableAdapter gAMETableAdapter;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private GAMESDataSet gAMESDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource1;
        private GAMESDataSetTableAdapters.GameTableAdapter gameTableAdapter1;
        private GAMESDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GAMESDataSet1 gAMESDataSet1;
        private System.Windows.Forms.BindingSource gameBindingSource2;
        private GAMESDataSet1TableAdapters.GameTableAdapter gameTableAdapter2;
        private GAMESDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}