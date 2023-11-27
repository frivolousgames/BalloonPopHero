// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("vwtboV7FW4xbrg+y1Lc78mpt70TAhMxdQ48gVzJ6klQQN8m0JfOa0zg26RfYgiY/PvublH0swTP9+xmojz3deOhJ9T/Co0HahuKhsAPNRE6yc4RH0jGdiTzOI6DL0mPllPUBVLg7NToKuDswOLg7Ozr47mrdkBCmu5Wnl6xZ1GBW8GZKv99rJZqc0wYKuDsYCjc8MxC8crzNNzs7Oz86OQ2XGRt7NCihJYduzM8lXpvFC6//N6YGFLaK4omfY9A+8SAnnXKv4y146MVk0OwLAxh047KjguLjk+hai5EZQvbq5fEd6UGR+B2XIRGbrfu8pXUG1Ua8LgRWei5PasPydz90B9XWpIBlzZVCUry/p4baxp4XyoBMNLir8CqSvBsLZTg5Ozo7");
        private static int[] order = new int[] { 3,7,12,4,12,7,13,12,8,10,11,11,13,13,14 };
        private static int key = 58;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
