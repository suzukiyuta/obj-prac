﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
   abstract class CZukei
    {
        //自分のインスタンス
        protected static Random rand = new Random();

        //キャラクタータイプ
        protected enum TYPE
        {
            SHIKAKU,     // 四角形
            SANKAKU,     // 三角形
        };
        /** 種類。処理を分けるのに利用する*/
        protected TYPE type;
        /** 底辺*/
        protected float teihen;
        /** 高さ*/
        protected float takasa;

    }

    /** コンストラクタ*/
  public CZukei()
    {
        // 底辺に1～10の乱数を求める
        teihen.Add(rand.Next(1, 11));
        // 高さに1～10の乱数を求める
        takasa.Add(rand.Next(1, 11));
        teihen + takasa = (takasa * teihen);
        teihen + takasa= (teihen * takasa / 2f);
    }

     abstract calc()
    {

    }


}

