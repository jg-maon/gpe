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

        /// <summary>
        /// パラメータから情報をコピーする
        /// </summary>
        /// <remarks>
        /// 派生先で必ずオーバーライドし、
        /// base.CopyFromを呼んでください。
        /// </remarks>
        /// <param name="srcParameter">コピー元パラメータ</param>
        /// <returns>
        /// true    成功
        /// false   失敗(派生クラスの情報が間違っている)
        /// </returns>
        public virtual bool CopyFrom(ParameterBase srcParameter)
        {
            this.ID = srcParameter.ID;
            this.Comment = srcParameter.Comment;
            return true;
        }
    }
}
