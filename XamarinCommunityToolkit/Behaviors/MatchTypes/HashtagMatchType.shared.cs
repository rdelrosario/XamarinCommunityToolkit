﻿using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;
namespace Xamarin.CommunityToolkit.Behaviors
{
	public class HashtagMatchType : MatchType
	{
#if !NETSTANDARD1_0
        public override Lazy<Regex> Regex { get; } = new Lazy<Regex>(() => new Regex(@"#\w+", RegexOptions.Compiled | RegexOptions.Singleline));
#else
		public override Lazy<Regex> Regex { get; } = new Lazy<Regex>(() => new Regex(@"#\w+", RegexOptions.Singleline));
#endif
		public override Style Style => new Style(typeof(Span))
		{
			Class = "HashtagSpanStyle",
			Setters =
				{
					new Setter
					{
						Property = Span.TextColorProperty,
						Value = Color.Green
					}
				}
		};
	}
}