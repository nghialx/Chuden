namespace MakeReport
{
    partial class frm_update
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
            this.txt_link = new System.Windows.Forms.TextBox();
            this.bt_load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_UT = new System.Windows.Forms.RadioButton();
            this.rdo_tc = new System.Windows.Forms.RadioButton();
            this.rdo_c = new System.Windows.Forms.RadioButton();
            this.rdo_DD = new System.Windows.Forms.RadioButton();
            this.gv_data = new System.Windows.Forms.DataGridView();
            this.bt_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_link
            // 
            this.txt_link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_link.Location = new System.Drawing.Point(93, 28);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(595, 20);
            this.txt_link.TabIndex = 0;
            // 
            // bt_load
            // 
            this.bt_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_load.Location = new System.Drawing.Point(694, 26);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(58, 23);
            this.bt_load.TabIndex = 1;
            this.bt_load.Text = "Load file";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link to file";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdo_UT);
            this.groupBox1.Controls.Add(this.rdo_tc);
            this.groupBox1.Controls.Add(this.rdo_c);
            this.groupBox1.Controls.Add(this.rdo_DD);
            this.groupBox1.Location = new System.Drawing.Point(38, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 41);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdo_UT
            // 
            this.rdo_UT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_UT.AutoSize = true;
            this.rdo_UT.Location = new System.Drawing.Point(578, 14);
            this.rdo_UT.Name = "rdo_UT";
            this.rdo_UT.Size = new System.Drawing.Size(111, 17);
            this.rdo_UT.TabIndex = 5;
            this.rdo_UT.Text = "Unit test evidence";
            this.rdo_UT.UseVisualStyleBackColor = true;
            // 
            // rdo_tc
            // 
            this.rdo_tc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo_tc.AutoSize = true;
            this.rdo_tc.Location = new System.Drawing.Point(392, 14);
            this.rdo_tc.Name = "rdo_tc";
            this.rdo_tc.Size = new System.Drawing.Size(72, 17);
            this.rdo_tc.TabIndex = 4;
            this.rdo_tc.Text = "Test case";
            this.rdo_tc.UseVisualStyleBackColor = true;
            // 
            // rdo_c
            // 
            this.rdo_c.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdo_c.AutoSize = true;
            this.rdo_c.Location = new System.Drawing.Point(209, 14);
            this.rdo_c.Name = "rdo_c";
            this.rdo_c.Size = new System.Drawing.Size(58, 17);
            this.rdo_c.TabIndex = 4;
            this.rdo_c.Text = "Coding";
            this.rdo_c.UseVisualStyleBackColor = true;
            // 
            // rdo_DD
            // 
            this.rdo_DD.AutoSize = true;
            this.rdo_DD.Checked = true;
            this.rdo_DD.Location = new System.Drawing.Point(12, 14);
            this.rdo_DD.Name = "rdo_DD";
            this.rdo_DD.Size = new System.Drawing.Size(88, 17);
            this.rdo_DD.TabIndex = 4;
            this.rdo_DD.TabStop = true;
            this.rdo_DD.Text = "Detail Design";
            this.rdo_DD.UseVisualStyleBackColor = true;
            // 
            // gv_data
            // 
            this.gv_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_data.Location = new System.Drawing.Point(38, 109);
            this.gv_data.Name = "gv_data";
            this.gv_data.Size = new System.Drawing.Size(714, 398);
            this.gv_data.TabIndex = 4;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(38, 513);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 5;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            // 
            // frm_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.gv_data);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.txt_link);
            this.Name = "frm_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_DD;
        private System.Windows.Forms.RadioButton rdo_c;
        private System.Windows.Forms.RadioButton rdo_UT;
        private System.Windows.Forms.RadioButton rdo_tc;
        private System.Windows.Forms.DataGridView gv_data;
        private System.Windows.Forms.Button bt_update;
    }
}

