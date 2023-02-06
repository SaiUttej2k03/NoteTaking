namespace NoteTaking
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title1 = new System.Windows.Forms.Label();
            this.Messages = new System.Windows.Forms.Label();
            this.txtTitle1 = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttRead = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Location = new System.Drawing.Point(82, 29);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(113, 20);
            this.Title1.TabIndex = 0;
            this.Title1.Text = "Your Note Tittle";
            // 
            // Messages
            // 
            this.Messages.AutoSize = true;
            this.Messages.Location = new System.Drawing.Point(82, 72);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(67, 20);
            this.Messages.TabIndex = 1;
            this.Messages.Text = "Your text";
            // 
            // txtTitle1
            // 
            this.txtTitle1.Location = new System.Drawing.Point(230, 29);
            this.txtTitle1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle1.Name = "txtTitle1";
            this.txtTitle1.Size = new System.Drawing.Size(114, 27);
            this.txtTitle1.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(230, 64);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(567, 135);
            this.txtMessage.TabIndex = 3;
            // 
            // bttNew
            // 
            this.bttNew.Location = new System.Drawing.Point(221, 265);
            this.bttNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(86, 31);
            this.bttNew.TabIndex = 5;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(399, 265);
            this.bttSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(86, 31);
            this.bttSave.TabIndex = 6;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttRead
            // 
            this.bttRead.Location = new System.Drawing.Point(221, 356);
            this.bttRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttRead.Name = "bttRead";
            this.bttRead.Size = new System.Drawing.Size(86, 31);
            this.bttRead.TabIndex = 7;
            this.bttRead.Text = "Read";
            this.bttRead.UseVisualStyleBackColor = true;
            this.bttRead.Click += new System.EventHandler(this.bttRead_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(499, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(341, 186);
            this.dataGridView1.TabIndex = 9;
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(399, 356);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(94, 29);
            this.bttDelete.TabIndex = 10;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteTaking.Properties.Resources.fgfherj;
            this.pictureBox1.Location = new System.Drawing.Point(12, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttRead);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTitle1);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.Title1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Your Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title1;
        private Label Messages;
        private TextBox txtTitle1;
        private TextBox txtMessage;
        private Button bttNew;
        private Button bttSave;
        private Button bttRead;
        private DataGridView dataGridView1;
        private Button bttDelete;
        private PictureBox pictureBox1;
    }
}