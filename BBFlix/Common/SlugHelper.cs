using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Web;

namespace BBFlix.Common
{
    public class SlugHelper
    {
        public static string GetSlug(string text)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string slug = text.Normalize(NormalizationForm.FormD).Trim().ToLower();

            slug = regex.Replace(slug, String.Empty)
                .Replace('đ', 'd').Replace('Đ', 'D')
                .Replace(",", "-").Replace(".", "-").Replace("!", "")
                .Replace("(", "").Replace(")", "").Replace(";", "-")
                .Replace("/", "-").Replace("%", "ptram").Replace("&", "va")
                .Replace("?", "").Replace('"', '-').Replace(' ', '-');

            return slug;
        }
    }
}