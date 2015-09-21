using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GParamEditor
{
    public partial class RecordListDialog : Form
    {
        /// <summary>
        /// ID一覧
        /// </summary>
        [DefaultValue(null)]
        public List<Parameter.ParameterBase> IdList { set; get; }

        /// <summary>
        /// 追加モード
        /// </summary>
        public enum InsertMode
        {
            ADD = 0,    //!< 新規追加
            COPY,       //!< コピー
        }
        private InsertMode m_mode = InsertMode.ADD;
        public InsertMode Mode
        {
            set
            {
                m_mode = value;
                _ChangedMode(m_mode);
            }
            get
            {
                return m_mode;
            }
        }


        private int m_newId = 0;
        /// <summary>
        /// 新規ID
        /// </summary>
        public int NewId
        {
            get
            {
                return m_newId;
            }
        }

        /// <summary>
        /// コピー元ID
        /// </summary>
        public int CopyBaseId
        {
            set 
            {
                m_copyBaseIdBox.Value = value;
            }
            get
            {
                return (int)(m_copyBaseIdBox.Value);
            }
        }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="insertMode">追加モード</param>
        /// <param name="idList">ID一覧</param>
        public RecordListDialog(InsertMode insertMode = InsertMode.ADD, List<Parameter.ParameterBase> idList = null)
        {
            InitializeComponent();
            m_mode = insertMode;
            IdList = idList;
            _ChangedMode(insertMode);
        }

        /// <summary>
        /// ページを開く
        /// </summary>
        /// <param name="insertMode">モード</param>
        private void _ChangedMode(InsertMode insertMode)
        {
            // コピーモードの時のみ表示
            m_copyBaseIdBox.Visible = m_copyBaseIdLabel.Visible = (InsertMode.COPY == insertMode);
            
        }

        /// <summary>
        /// 実行処理
        /// </summary>
        private void _Accept()
        {
            bool ok = true;
            // IDの重複チェック
            if (null != IdList)
            {
                bool hasId = false;
                foreach(var item in IdList)
                {
                    if (NewId == item.ID)
                    {
                        // 重複
                        hasId = true;
                        break;
                    }
                }
                if(hasId)
                {
                    DialogResult result = MessageBox.Show("作成先のIDが既に存在しています\n上書きしますか？", "ID重複", MessageBoxButtons.OKCancel);
                    ok = (DialogResult.OK == result); 
                }
            }
            

            if(ok)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// キャンセル処理
        /// </summary>
        private void _Cancel()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        #region イベント

        /// <summary>
        /// キャンセルボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _button1_Click(object sender, EventArgs e)
        {
            // キャンセル処理
            _Cancel();
        }

        /// <summary>
        /// 実行ボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _button2_Click(object sender, EventArgs e)
        {
            // 実行処理
            _Accept();
        }

        /// <summary>
        /// フォーム上でキーが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _RecordListDialog_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // ESCキーが押された場合
            if (e.KeyCode == Keys.Escape)
            {
                // キャンセル処理
                _Cancel();
            }
        }

        /// <summary>
        /// IDの値が変更された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _IdBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = (NumericUpDown)(sender);

            m_newId = (int)(box.Value);
        }

        #endregion  // イベント

    }
}
