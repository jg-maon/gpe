using GParamEditor.Parameter;
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
    public partial class Form1 : Form
    {
        Dictionary<string, List<Parameter.ParameterBase>> m_parameterList = new Dictionary<string,List<ParameterBase>>();
        private static readonly string KeyLightSet = "LightSet";

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
                lightSet.a = 0.0f * i;
                lightSet.b = 0.0f * i;
                lightSet.c = 0.0f * i;

                _AddLightSetParameter(lightSet);
            }
        }

        private void _AddLightSetParameter(ParameterLightSet parameter)
        {
            if(!m_parameterList.ContainsKey(KeyLightSet))
            {
                m_parameterList.Add(KeyLightSet, new List<ParameterBase>());
            }
            m_parameterList[KeyLightSet].Add(parameter);

            List<string> names = new List<string>();

            Type t = typeof(ParameterLightSet);
            var memberInfo = t.GetMembers();
            foreach(var member in memberInfo)
            {
                names.Add(member.Name);
            }
            ListViewItem item = new ListViewItem(names.ToArray());
            listView1.Items.Add(item);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RecordListDialog dialog = new RecordListDialog();
            dialog.IdList = m_parameterList[KeyLightSet];

            DialogResult result = dialog.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecordListDialog dialog = new RecordListDialog(RecordListDialog.InsertMode.COPY);
            dialog.IdList = m_parameterList[KeyLightSet];

            DialogResult result = dialog.ShowDialog();
        }
    }
}
