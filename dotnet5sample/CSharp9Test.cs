using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5sample
{
    public class CSharp9Test
    {
        // newの型推論(省略)
        private List<string> str = new();

        delegate void testdel(int i, string s);
        testdel t;

        public void test() 
        {
            #region _で引数破棄
            t = (_, _) => { Debug.WriteLine("testcalled."); };
            t(1, "aaa");
            #endregion

            #region 条件文の短縮表記
            int a = -1;
            // a >= 0 かつ a < 10
            if(a is >=0 and < 10)
            {
                Debug.WriteLine("mini");// 到達しないはず
            }

            a = 5;
            // a >= 0 かつ a < 10
            if (a is >= 0 and < 10)
            {
                Debug.WriteLine("ok");// 到達するはず
            }

            a = 10;
            // a >= 0 かつ a < 10
            if (a is >= 0 and < 10)
            {
                Debug.WriteLine("large");// 到達しないはず
            }

            // 複雑な表記

            a = 3;
            // aは 3 または 4 かつ 4でない(つまり3だけ)
            if (a is 3 or 4 and not 4) 
            {
                Debug.WriteLine("is 3");// 到達するはず
            }

            a = 4;
            if (a is 3 or 4 and not 4)
            {
                Debug.WriteLine("not 4");// 到達しないはず
            }

            #endregion
        }
    }
}
