using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjohj
{
    class Program
    {
        enum DialogResult { Y, N, CANCEL, CONFIRM, OK}
        enum DResult { Y = 10, N, CANCEL, CONFIRM = 50, OK }
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);
            int b = (int)a;
            Console.WriteLine(b);
            int c = 128;
            Console.WriteLine(c);
            sbyte d = (sbyte)c;//크기가 작아서 이상한거 나옴
            Console.WriteLine(d);

            Console.WriteLine();

            float aa = 69.6875f;
            Console.WriteLine(aa);
            double bb = (double)aa;
            Console.WriteLine(bb);
            Console.WriteLine("69.6875 == bb : {0}", 69.6875 == bb);
            float cc = 0.1f;//소수가 0.5 이상이아니라서 이상하게 뜸 ex)1.23, 1.32, 56.34..
            Console.WriteLine(cc);
            double dd = (double)cc;
            Console.WriteLine(dd);
            Console.WriteLine("0.1 == dd : {0}", 0.1 == dd);

            Console.WriteLine();

            int aaa = 500;
            Console.WriteLine(aaa);
            uint bbb = (uint)aaa;
            Console.WriteLine(bbb);
            int ccc = -30;
            Console.WriteLine(ccc);
            uint ddd = (uint)ccc;//부호없는거
            Console.WriteLine(ddd);

            Console.WriteLine();

            float aaaa = 0.9f;
            int bbbb = (int)aaaa;
            Console.WriteLine(bbbb);
            float cccc = 1.1f;
            int dddd = (int)cccc;//float -> int하면 소수점 떼짐
            Console.WriteLine(dddd);

            Console.WriteLine();

            int aaaaa = 123;
            string bbbbb = aaaaa.ToString();//문자열 변환
            Console.WriteLine(bbbbb);
            float ccccc = 3.14f;
            string ddddd = ccccc.ToString();
            Console.WriteLine(ddddd);
            string eeeee = "12324";
            int fffff = Convert.ToInt32(eeeee);//정수형 변환
            Console.WriteLine(fffff);
            string ggggg = "1.2324";
            float hhhhh = float.Parse(ggggg);//flaot변환
            Console.WriteLine(hhhhh);

            Console.WriteLine();

            const int MAX_INT = 2147483647;//const는 상수(안변하는거)지정함
            const int MIN_INT = -2147483647;
            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);
            //MAX_INT = 1; 이거하면 오류남
            Console.WriteLine();

            DialogResult result = DialogResult.Y;//Y면 True 아니면 False
            Console.WriteLine(result == DialogResult.Y);
            Console.WriteLine(result == DialogResult.N);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);

            Console.WriteLine((int)DialogResult.Y);//0부터 순서대로
            Console.WriteLine((int)DialogResult.N);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

            Console.WriteLine((int)DResult.Y);//10다음 순서대로
            Console.WriteLine((int)DResult.N);
            Console.WriteLine((int)DResult.CANCEL);
            Console.WriteLine((int)DResult.CONFIRM);//50다음 순서대로
            Console.WriteLine((int)DResult.OK);

            Console.WriteLine();

            int? aaaaaa = null;
            Console.WriteLine(aaaaaa.HasValue);//값있나?
            Console.WriteLine(a != null);//널 아닌가?
            aaaaaa = 3;
            Console.WriteLine(aaaaaa.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(aaaaaa.Value);//aaaaaa값

            Console.WriteLine();

            var x = 20;//var는 자동형식지정해줌 근데 초기화 필수고 지역변수로만 사용
            Console.WriteLine("Type: {0}, Value: {1}", x.GetType(), x);
            var y = new int[] { 10, 20, 30 };
            Console.WriteLine("Type: {0}, Value: ", y.GetType());
            foreach(var z in y)
                Console.WriteLine("{0}", z);

            Console.WriteLine();

            System.Int32 xx = 123;
            int yy = 456;
            Console.WriteLine("xx type:{0}, value:{1}", xx.GetType().ToString(), xx);
            Console.WriteLine("yy type:{0}, value:{1}", yy.GetType().ToString(), yy);

            System.String zz = "abc";
            string yyy = "sdad";
            Console.WriteLine("zz type:{0}, value:{1}", zz.GetType().ToString(), zz);
            Console.WriteLine("yyy type:{0}, value:{1}", yyy.GetType().ToString(), yyy);
        }
    }
}
