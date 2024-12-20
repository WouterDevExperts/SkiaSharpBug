using Spire.Xls;

namespace SkiaSharpBug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //"SkiaSharp.NativeAssets.Linux.NoDependencies" version "2.88.9" works
                using var workbook = new Workbook();
                Console.WriteLine("SkiaSharp works!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SkiaSharp error: {0}", ex.ToString());
            }
        }
    }
}
