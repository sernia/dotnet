using System;

namespace recodeType
{
    class Program
    {
        static void Main(string[] args)
        {
            //レコード型のインスタンスを生成して初期値を設定
            data p = new data("recodeType", 30);
            Console.Write($"Title:{p.Title}, Count:{p.Count}");
            //出力：Title:recodeType, Count:30

            //レコード型はイミュータブルのためエラーが発生する
            //p.Title = "エラー";
        }
    }

    /// <summary>
    /// C#9.0 新しいキーワードのレコード型が追加
    /// イミュータブルのレコード型
    /// </summary>
    /// <value></value>
    public record data
    {
        public string Title { get; }
        public int Count { get; }

        public data(string title, int count)
            => (Title, Count) = (title, count);
    }
}