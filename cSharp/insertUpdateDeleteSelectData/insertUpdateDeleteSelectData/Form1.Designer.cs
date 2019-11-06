namespace insertUpdateDeleteSelectData
{
    partial class form
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
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.heights = new System.Windows.Forms.TextBox();
            this.weights = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(13, 15);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(57, 13);
            this.l1.TabIndex = 1;
            this.l1.Text = "First Name";
            this.l1.Click += new System.EventHandler(this.l1_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(13, 51);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(58, 13);
            this.l2.TabIndex = 2;
            this.l2.Text = "Last Name";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(13, 87);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(18, 13);
            this.l3.TabIndex = 3;
            this.l3.Text = "ID";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(13, 123);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(26, 13);
            this.l4.TabIndex = 4;
            this.l4.Text = "Age";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(13, 161);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(38, 13);
            this.l5.TabIndex = 5;
            this.l5.Text = "Height";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(13, 200);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(41, 13);
            this.l6.TabIndex = 6;
            this.l6.Text = "Weight";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(140, 12);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(152, 20);
            this.fName.TabIndex = 7;
            this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(140, 48);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(152, 20);
            this.lName.TabIndex = 8;
            this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(140, 84);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(152, 20);
            this.id.TabIndex = 9;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(140, 120);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(152, 20);
            this.age.TabIndex = 10;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // heights
            // 
            this.heights.Location = new System.Drawing.Point(140, 158);
            this.heights.Name = "heights";
            this.heights.Size = new System.Drawing.Size(152, 20);
            this.heights.TabIndex = 11;
            // 
            // weights
            // 
            this.weights.Location = new System.Drawing.Point(140, 197);
            this.weights.Name = "weights";
            this.weights.Size = new System.Drawing.Size(152, 20);
            this.weights.TabIndex = 12;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(217, 325);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 13;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(217, 234);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 14;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 337);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(55, 326);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 16;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(136, 325);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 17;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.weights);
            this.Controls.Add(this.heights);
            this.Controls.Add(this.age);
            this.Controls.Add(this.id);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "form";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox heights;
        private System.Windows.Forms.TextBox weights;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
    }
}

