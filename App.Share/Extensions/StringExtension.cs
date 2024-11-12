using System.Text;

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
			// Normalize the string to decompose combined characters into base characters and diacritics
			string normalizedString = phrase.Normalize(NormalizationForm.FormD);
			var stringBuilder = new System.Text.StringBuilder();

			foreach (var c in normalizedString)
			{
				var unicodeCategory = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
				if (unicodeCategory != System.Globalization.UnicodeCategory.NonSpacingMark)
				{
					stringBuilder.Append(c);
				}
			}

			// Convert the string back to a composed form
			string str = stringBuilder.ToString().Normalize(NormalizationForm.FormC);

			// Convert to lower case
			str = str.ToLowerInvariant();

			// Replace spaces with hyphens
			str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", "-");

			// Remove all non-word characters
			str = System.Text.RegularExpressions.Regex.Replace(str, @"[^\w\-]+", "");

			// Replace multiple hyphens with a single hyphen
			str = System.Text.RegularExpressions.Regex.Replace(str, @"\-\-+", "-");

			return str;
		}
	}
}