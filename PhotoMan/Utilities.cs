using System.Text;

namespace PhotoMan.Utilities
{
    public class CodeGenerator
    {
          private static Random r = new Random();
        private const string chars = "ABCDEFGHIJKMNLOPQRSTUVXYZabcdefghijklmnopqrstuxyz1234567890";
        public static string GenerateRandomCode(int length)
        {
            var code = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                code.Append(chars[r.Next(chars.Length)]);
            }
            return code.ToString();
        }
    }
}
