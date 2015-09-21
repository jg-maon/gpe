namespace GParamEditor
{
    partial class RecordListDialog
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
            this.m_commentBox = new System.Windows.Forms.TextBox();
            this.m_copyBaseIdBox = new System.Windows.Forms.NumericUpDown();
            this.m_copyBaseIdLabel = new System.Windows.Forms.Label();
            this.m_commentLabel = new System.Windows.Forms.Label();
            this.m_idLabel = new System.Windows.Forms.Label();
            this.m_idBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_copyBaseIdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_idBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_commentBox
            // 
            this.m_commentBox.Location = new System.Drawing.Point(11, 93);
            this.m_commentBox.Name = "m_commentBox";
            this.m_commentBox.Size = new System.Drawing.Size(195, 19);
            this.m_commentBox.TabIndex = 3;
            // 
            // m_copyBaseIdBox
            // 
            this.m_copyBaseIdBox.Location = new System.Drawing.Point(137, 41);
            this.m_copyBaseIdBox.Name = "m_copyBaseIdBox";
            this.m_copyBaseIdBox.Size = new System.Drawing.Size(69, 19);
            this.m_copyBaseIdBox.TabIndex = 2;
            // 
            // m_copyBaseIdLabel
            // 
            this.m_copyBaseIdLabel.AutoSize = true;
            this.m_copyBaseIdLabel.Location = new System.Drawing.Point(9, 43);
            this.m_copyBaseIdLabel.Name = "m_copyBaseIdLabel";
            this.m_copyBaseIdLabel.Size = new System.Drawing.Size(61, 12);
            this.m_copyBaseIdLabel.TabIndex = 1;
            this.m_copyBaseIdLabel.Text = "コピー元ID：";
            this.m_copyBaseIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_commentLabel
            // 
            this.m_commentLabel.AutoSize = true;
            this.m_commentLabel.Location = new System.Drawing.Point(26, 67);
            this.m_commentLabel.Name = "m_commentLabel";
            this.m_commentLabel.Size = new System.Drawing.Size(44, 12);
            this.m_commentLabel.TabIndex = 1;
            this.m_commentLabel.Text = "コメント：";
            this.m_commentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_idLabel
            // 
            this.m_idLabel.AutoSize = true;
            this.m_idLabel.Location = new System.Drawing.Point(48, 19);
            this.m_idLabel.Name = "m_idLabel";
            this.m_idLabel.Size = new System.Drawing.Size(22, 12);
            this.m_idLabel.TabIndex = 1;
            this.m_idLabel.Text = "ID：";
            this.m_idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_idBox
            // 
            this.m_idBox.Location = new System.Drawing.Point(137, 17);
            this.m_idBox.Name = "m_idBox";
            this.m_idBox.Size = new System.Drawing.Size(69, 19);
            this.m_idBox.TabIndex = 0;
            this.m_idBox.ValueChanged += new System.EventHandler(this._IdBox_ValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(142, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "キャンセル";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(83, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "実行";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this._button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 50);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_commentLabel);
            this.panel2.Controls.Add(this.m_commentBox);
            this.panel2.Controls.Add(this.m_copyBaseIdBox);
            this.panel2.Controls.Add(this.m_copyBaseIdLabel);
            this.panel2.Controls.Add(this.m_idLabel);
            this.panel2.Controls.Add(this.m_idBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 122);
            this.panel2.TabIndex = 4;
            // 
            // RecordListDialog
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(229, 172);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordListDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RecordListDialog";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this._RecordListDialog_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.m_copyBaseIdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_idBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown m_idBox;
        private System.Windows.Forms.TextBox m_commentBox;
        private System.Windows.Forms.NumericUpDown m_copyBaseIdBox;
        private System.Windows.Forms.Label m_copyBaseIdLabel;
        private System.Windows.Forms.Label m_commentLabel;
        private System.Windows.Forms.Label m_idLabel;
        private System.Windows.Forms.Panel panel2;

    }
}