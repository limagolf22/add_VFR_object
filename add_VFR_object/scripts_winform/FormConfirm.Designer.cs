
namespace WindowsForms_add_water_tower
{
    partial class FormConfirm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSelAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(31, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(222, 154);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkBoxSelAll
            // 
            this.checkBoxSelAll.AutoSize = true;
            this.checkBoxSelAll.Location = new System.Drawing.Point(31, 173);
            this.checkBoxSelAll.Name = "checkBoxSelAll";
            this.checkBoxSelAll.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSelAll.TabIndex = 1;
            this.checkBoxSelAll.Text = "select all";
            this.checkBoxSelAll.UseVisualStyleBackColor = true;
            this.checkBoxSelAll.CheckedChanged += new System.EventHandler(this.checkBoxSelAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure you want to compile the selected files ?";
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(190, 253);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 3;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(19, 252);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormConfirm
            // 
            this.ClientSize = new System.Drawing.Size(282, 288);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSelAll);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "FormConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBoxSelAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonCancel;
    }
}

