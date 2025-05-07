public static class Logger {
   private static string BrackColor = "#65659A";
   private static string TypColor = "#9F0A45";
   private static string MsgColor = "#65659A";

   private static string Color(string str, string c) => $"\x1b[38;2;{Convert.ToInt32(c.Substring(1, 2), 16)};{Convert.ToInt32(c.Substring(3, 2), 16)};{Convert.ToInt32(c.Substring(5, 2), 16)}m{str}\x1b[0m";
   public static void Log(string tstr, string str) => Console.WriteLine($"{Color("[", BrackColor)}{Color(tstr, TypColor)}{Color("]", BrackColor)} {Color(str, MsgColor)}");
}