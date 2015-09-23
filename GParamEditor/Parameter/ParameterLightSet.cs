using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GParamEditor.Parameter
{
    class ParameterLightSet : ParameterBase
    {
        public float a, b, c;

        /// <summary>
        /// パラメータから情報をコピーする
        /// </summary>
        /// <param name="srcParameter">コピー元パラメータ</param>
        /// <returns>
        /// true    成功
        /// false   失敗(派生クラスの情報が間違っている)
        /// </returns>
        public override bool CopyFrom(ParameterBase srcParameter)
        {
            base.CopyFrom(srcParameter);

            ParameterLightSet param = srcParameter as ParameterLightSet;
            if (null != param)
            {
                this.a = param.a;
                this.b = param.b;
                this.c = param.c;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
