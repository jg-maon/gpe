namespace GParamEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RecordCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Comment";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "a";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "b";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "c";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecordCopyToolStripMenuItem,
            this.RecordDeleteToolStripMenuItem,
            this.RecordAddToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 70);
            // 
            // RecordCopyToolStripMenuItem
            // 
            this.RecordCopyToolStripMenuItem.Name = "RecordCopyToolStripMenuItem";
            this.RecordCopyToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.RecordCopyToolStripMenuItem.Text = "レコードのコピー(&C)...";
            this.RecordCopyToolStripMenuItem.Click += new System.EventHandler(this._RecordCopyToolStripMenuItem_Click);
            // 
            // RecordDeleteToolStripMenuItem
            // 
            this.RecordDeleteToolStripMenuItem.Name = "RecordDeleteToolStripMenuItem";
            this.RecordDeleteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.RecordDeleteToolStripMenuItem.Text = "レコードの削除(&D)...";
            this.RecordDeleteToolStripMenuItem.Click += new System.EventHandler(this._RecordDeleteToolStripMenuItem_Click);
            // 
            // RecordAddToolStripMenuItem
            // 
            this.RecordAddToolStripMenuItem.Name = "RecordAddToolStripMenuItem";
            this.RecordAddToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.RecordAddToolStripMenuItem.Text = "レコードの追加(&A)...";
            this.RecordAddToolStripMenuItem.Click += new System.EventHandler(this._RecordAddToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RecordCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RecordDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RecordAddToolStripMenuItem;
    }
}

