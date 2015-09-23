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

            // ビューの項目用データ作成
            List<string> items = new List<string>();
            Type type = typeof(ParameterLightSet);
            var info = type.GetMembers();
            foreach (var member in info)
            {
                if (System.Reflection.MemberTypes.Field == member.MemberType)
                {
                    FieldInfo field = type.GetField(member.Name);
                    items.Add(field.GetValue(parameter).ToString());
                }
                else if (System.Reflection.MemberTypes.Property == member.MemberType)
                {
                    PropertyInfo property = type.GetProperty(member.Name);
                    object o = property.GetValue(parameter);
                    if(null != o)
                    {
                        items.Add(o.ToString());
                    }
                }
            }

            // リストにデータの追加
            int index = 0;
            foreach(var item in  m_parameterList[KeyLightSet])
            {
                // 既にIDが存在している
                if(item.ID == parameter.ID)
                {
                    break;
                }
                ++index;
            }
            // IDが存在していない場合
            if (m_parameterList[KeyLightSet].Count == index)
            {
                m_parameterList[KeyLightSet].Add(parameter);
                // ビューの追加
                ListViewItem item = new ListViewItem(items.ToArray());
                listView1.Items.Add(item);
            }
            else
            {
                // レコードの上書き
                m_parameterList[KeyLightSet][index].CopyFrom(parameter);

                // ビューのデータに反映
                ListViewItem item = new ListViewItem(items.ToArray());
                for (int itemIndex = 0; itemIndex < listView1.Items.Count; ++itemIndex )
                {
                    ListViewItem listItem = listView1.Items[itemIndex];
                    // 最初の項目(ID)が一致している行の変更
                    if (listItem.Text == item.Text)
                    {
                        listView1.Items[itemIndex] = item;
                        break;
                    }
                }

            }

        }
        /// <summary>
        /// レコードのダイアログ表示
        /// </summary>
        /// <param name="mode">表示モード</param>
        private void _OpenRecordDialog(RecordListDialog.InsertMode mode)
        {
            m_recordListDialog.Mode = mode;
            m_recordListDialog.IdList = m_parameterList[KeyLightSet];
            if (1 <= listView1.SelectedItems.Count)
            {
                m_recordListDialog.CopyBaseId = int.Parse(listView1.SelectedItems[0].Text);
            }

            DialogResult result = m_recordListDialog.ShowDialog();
            if (DialogResult.OK == result)
            {
                // レコードの追加
                ParameterLightSet parameter = new ParameterLightSet();
                if (RecordListDialog.InsertMode.ADD == mode)
                {
                    parameter.ID = m_recordListDialog.NewId;
                    parameter.Comment = m_recordListDialog.NewComment;
                }
                else
                {
                    // パラメータのコピー

                }
                _AddLightSetParameter(parameter);
            }
        }
        /// <summary>
        /// レコードの削除確認ダイアログ表示
        /// </summary>
        private void _OpenDeleteRecorddialog()
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
                // リストから削除
                foreach(ListViewItem selectedItem in listView1.SelectedItems)
                {
                    // IDの取得
                    int deleteId = int.Parse(selectedItem.Text);

                    Predicate<ParameterBase> predicate = (param) => param.ID == deleteId;
                    m_parameterList[KeyLightSet].RemoveAll(predicate);

                    
                    // ビューから削除
                    listView1.Items.Remove(selectedItem);
                }

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
            _OpenDeleteRecorddialog();
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
