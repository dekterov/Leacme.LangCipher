using System.Collections.Generic;

namespace Leacme.Lib.LangCipher {
	public class TranslationPairs {

		public static List<(string fromLang, string toLang, string fromCode, string toCode)> AvailableTranslations { get; } =
			new List<(string fromLang, string toLang, string fromCode, string toCode)>() {
				("Afrikaans","Dutch","af","nl"),
				("Aragonese","Spanish","arg","spa"),
				("Aragonese","Catalan","arg","cat"),
				("Basque","English","eu","en"),
				("Basque","Spanish","eu","es"),
				("Belarusian","Russian","bel","rus"),
				("Bokmal","Norwegian Nynorsk","nob","nno"),
				("Breton","French","br","fr"),
				("Bulgarian","Macedonian","bg","mk"),
				("Catalan","Aragonese","cat","arg"),
				("Catalan","Spanish","ca","es"),
				("Catalan","English","ca","en"),
				("Catalan","Portuguese","ca","pt"),
				("Catalan","Sardinian","srd","cat"),
				("Catalan","Occitan","ca","oc"),
				("Catalan","French","cat","fra"),
				("Catalan","Esperanto","ca","eo"),
				("CrimeanTatar","Turkish","crh","tur"),
				("Danish","Norwegian","dan","nor"),
				("Danish","Swedish","dan","swe"),
				("Dutch","Afrikaans","nl","af"),
				("English","Galician","en","gl"),
				("English","Esperanto","en","eo"),
				("English","Spanish","en","es"),
				("English","Catalan","en","ca"),
				("Esperanto","English","eo","en"),
				("French","Catalan","fra","cat"),
				("French","Spanish","fr","es"),
				("French","Occitan","fra","oci"),
				("French","Esperanto","fr","eo"),
				("Galician","Portuguese","gl","pt"),
				("Galician","English","gl","en"),
				("Galician","Spanish","gl","es"),
				("Hindi","Urdu","hin","urd"),
				("Icelandic","Swedish","is","sv"),
				("Icelandic","English","isl","eng"),
				("Indonesian","Malaysian","id","ms"),
				("Italian","Catalan","it","ca"),
				("Italian","Sardinian","srd","ita"),
				("Kazakh","Tatar","kaz","tat"),
				("Macedonian","English","mk","en"),
				("Macedonian","Bulgarian","mk","bg"),
				("Malaysian","Indonesian","ms","id"),
				("Maltese","Arabic","mlt","ara"),
				("North Sami","Norwegian","sme","nob"),
				("Norwegian","Swedish","nor","swe"),
				("Norwegian","Danish","nor","dan"),
				("Norwegian Nynorsk","Bokmal","nno","nob"),
				("Occitan","Catalan","oc","ca"),
				("Occitan","Spanish","oc","es"),
				("Polish","Silesian","pol","szl"),
				("Portuguese","Catalan","pt","ca"),
				("Portuguese","Galician","pt","gl"),
				("Portuguese","Spanish","pt","es"),
				("Romanian","Spanish","ro","es"),
				("Russian","Ukrainian","rus","ukr"),
				("Russian","Belarusian","rus","bel"),
				("Serbo Croatian","Slovenian","hbs","slv"),
				("Serbo Croatian","English","hbs","eng"),
				("Serbo Croatian","Macedonian","hbs","mkd"),
				("Slovenian","Serbo Croatian","slv","hbs"),
				("Spanish","Esperanto","es","eo"),
				("Spanish","Portuguese","es","pt"),
				("Spanish","Catalan","es","ca"),
				("Spanish","Asturian","spa","ast"),
				("Spanish","Galician","es","gl"),
				("Spanish","French","es","fr"),
				("Spanish","English","es","en"),
				("Spanish","Occitan","es","oc"),
				("Spanish","Aragonese","spa","arg"),
				("Swedish","Danish","swe","dan"),
				("Swedish","Icelandic","sv","is"),
				("Swedish","Norwegian","swe","nor"),
				("Tatar","Kazakh","tat","kaz"),
				("Ukrainian","Russian","ukr","rus"),
				("Urdu","Hindi","urd","hin"),
				("Welsh","English","cy","en"),
			};
	}
}