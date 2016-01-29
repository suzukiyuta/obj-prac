using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
   abstract class CZukei
    {
      protected static Random rand = new Random();
        /** 種類。処理を分けるのに利用する*/
      protected  List<TYPE> type;
        /** 底辺*/
       protected List<float> teihen;
        /** 高さ*/
       protected List<float> takasa;

    }

    
    public CZukei()
    {
         // 底辺に1～10の乱数を求める
            teihen.Add(rand.Next(1, 11));
            // 高さに1～10の乱数を求める
            takasa.Add(rand.Next(1, 11));
    }

}

