using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class LineInfo
    {
        private List<string> lines;
        public LineInfo()
        {
            lines = new List<string>();
        }

        public void Add(string input) { 
            lines.Add(input);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lines.Count; i++)
            {
                sb.Append(this[i]);
                sb.Append(",");

            }
            return sb.ToString();
        }
        // 索引器定義
        public string this[int index]
        {
            get { return lines[index]; } // 取得特定索引的行
            set { lines[index] = value; } // 設定特定索引的行
        }

    }
}
