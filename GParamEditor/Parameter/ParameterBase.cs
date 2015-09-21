using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GParamEditor.Parameter
{
    /// <summary>
    /// パラメータの基底クラス
    /// </summary>
    public class ParameterBase
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// コメント
        /// </summary>
        public string Comment { set; get; }
    }
}
