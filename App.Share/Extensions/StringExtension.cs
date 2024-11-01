namespace App.Share.Extensions
{
	public static class StringExtension
	{
		public static bool IsNullOrEmpty(this string text)
		{
			return String.IsNullOrEmpty(text);
		}

		public static bool IsNullOrWhiteSpace(this string text)
		{
			return String.IsNullOrWhiteSpace(text);
		}

		public static string ReplaceTagInput(this string text)
		{
			var rep = text.Replace('"', ' ');
			var rep1 = rep.Replace("{ value :", "");
			var rep2 = rep1.Replace("[", "");
			var rep3 = rep2.Replace('}', ' ');
			var result = rep3.Replace(']', ' ');
			return result;
		}

		public static string Slugify(this string phrase)
		{
			string str = phrase.ToLowerInvariant();
			str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", "-"); // Replace spaces with hyphens
			str = System.Text.RegularExpressions.Regex.Replace(str, @"[^\w\-]+", ""); // Remove all non-word characters
			str = System.Text.RegularExpressions.Regex.Replace(str, @"\-\-+", "-"); // Replace multiple hyphens with a single hyphen
			return str;
		}
	}
}