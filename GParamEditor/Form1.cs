using GParamEditor.Parameter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GParamEditor
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<Parameter.ParameterBase>> m_parameterList = new Dictionary<string,List<ParameterBase>>();
        private static readonly string KeyLightSet = "LightSet";

        private RecordListDialog m_recordListDialog = new RecordListDialog();


        public Form1()
        {
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            for(int i=0; i<10; ++i)
            {
                ParameterLightSet lightSet = new ParameterLightSet();
                lightSet.ID = i;
                lightSet.Comment = "comment " + i;
                lightSet.a = 0.5f * i;
                lightSet.b = 0.5f * i;
                lightSet.c = 0.5f * i;

                _AddLightSetParameter(lightSet);
            }
        }

        private void _AddLightSetParameter(ParameterLightSet parameter)
        {
            // 初めてリストを作成する場合
            if(!m_parameterList.ContainsKey(KeyLightSet))
            {
                // リストの作成
                m_parameterList.Add(KeyLightSet, new List<ParameterBase>());
                // ビューの作成
                listView1.Columns.Clear();
                Type t = typeof(ParameterLightSet);
                var memberInfo = t.GetMembers();
                foreach (var member in memberInfo)
                {
                    if ((member.MemberType & (System.Reflection.MemberTypes.Field | System.Reflection.MemberTypes.Property)) > 0)
                    {
                        listView1.Columns.Add(member.Name);
                    }
                }

            }
            // リストにデータの追加
            m_parameterList[KeyLightSet].Add(parameter);

            // ビューにデータの追加
            List<string> items = new List<string>();
            Type type = typeof(ParameterLightSet);
            var info = type.GetMembers();
            foreach (var member in info)
            {
                if (member.MemberType == System.Reflection.MemberTypes.Field )
                {
                    FieldInfo field = type.GetField(member.Name);
                    items.Add(field.GetValue(parameter).ToString());
                }
                else if (System.Reflection.MemberTypes.Property == member.MemberType)
                {
                    PropertyInfo property = type.GetProperty(member.Name);
                    items.Add(property.GetValue(parameter).ToString());
                }
            }
            ListViewItem item = new ListViewItem(items.ToArray());
            listView1.Items.Add(item);
        }
        /// <summary>
        /// レコードのダイアログ表示
        /// </summary>
        /// <param name="mode">表示モード</param>
        private void _OpenRecordDialog(RecordListDialog.InsertMode mode)
        {
            m_recordListDialog.Mode = mode;
            m_recordListDialog.IdList = m_parameterList[KeyLightSet];

            DialogResult result = m_recordListDialog.ShowDialog();
            if (DialogResult.OK == result)
            {

            }
        }
        /// <summary>
        /// レコードの削除確認ダイアログ表示
        /// </summary>
        private void _DeleteRecord()
        {
            StringBuilder selectedIds = new StringBuilder();
            int selectedNum = 0;
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                if(selectedNum >= 1)
                {
                    selectedIds.Append(" / ");
                }
                // 先頭項目の内容(ID)を追加
                selectedIds.Append(selectedItem.Text);
                //
                ++selectedNum;
            }
            DialogResult result = MessageBox.Show("下記のIDのレコードを削除します。よろしいですか？"
                + "\n\n" + selectedIds.ToString(), "レコードの削除", MessageBoxButtons.OKCancel);

            // 削除
            if(DialogResult.OK == result)
            {
                
            }
        }

        #region イベント

        /// <summary>
        /// レコードのコピー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _RecordCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenRecordDialog(RecordListDialog.InsertMode.COPY);
        }

        /// <summary>
        /// レコードの削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _RecordDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteRecord();
        }

        /// <summary>
        /// レコードの追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _RecordAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenRecordDialog(RecordListDialog.InsertMode.ADD);
        }

        #endregion  // イベント
    }
}
