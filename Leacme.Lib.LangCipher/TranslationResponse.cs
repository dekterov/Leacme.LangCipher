namespace Leacme.Lib.LangCipher {
	public class TranslationResponse {
		public string ResponseDetails { get; set; }
		public long ResponseStatus { get; set; }
		public ResponseData ResponseData { get; set; }
	}

	public class ResponseData {
		public string TranslatedText { get; set; }
	}
}