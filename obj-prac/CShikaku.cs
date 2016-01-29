using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    class CShikaku: CZukei
    {
        void instantiateShikaku()
        {
            // 種類を四角形にする
            type.Add(TYPE.SHIKAKU);
            // 底辺に1～10の乱数を求める
            teihen.Add(rand.Next(1, 11));
            // 高さに1～99の乱数を求める
            takasa.Add(rand.Next(1, 11));
        }
    }
}
