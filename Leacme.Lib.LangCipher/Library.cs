// Copyright (c) 2017 Leacme (http://leac.me). View LICENSE.md for more information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Leacme.Lib.LangCipher {

	public class Library {

		public static RestClient dicClient { get; } = new RestClient("https://www.apertium.org");

		public Library() {

			TranslationPairs.AvailableTranslations.Sort(Comparer<(string fromLang, string toLang, string fromCode, string toCode)>.Create((z, zz) => z.fromLang.CompareTo(zz.fromLang)));

		}

		/// <summary>
		/// Returns the translation service responce.
		/// /// </summary>
		/// <param name="textToTranslate"></param>
		/// <param name="fromCode">The letter code of the language from TranslationPairs.</param>
		/// <param name="toCode">The letter code of the language from TranslationPairs.</param>
		/// <returns>The translation responce with TranslationResponse.ResponseData.TranslatedText as the
		/// text content.</returns>
		public async Task<TranslationResponse> GetSearchTermResponceAsync(string textToTranslate, string fromCode, string toCode) {
			if (!TranslationPairs.AvailableTranslations.Any(z => z.fromCode.Equals(fromCode) && z.toCode.Equals(toCode))) {
				throw new ArgumentException("Not a valid translation.");
			}
			var searchReq = new RestRequest(new Uri(dicClient.BaseUrl, "apy/translate"), Method.GET, DataFormat.Json);

			searchReq.AddQueryParameter("langpair", fromCode + "|" + toCode);
			searchReq.AddQueryParameter("q", textToTranslate);
			return await Task.Run(() => JsonConvert.DeserializeObject<TranslationResponse>(dicClient.Execute(searchReq).Content));
		}
	}
}