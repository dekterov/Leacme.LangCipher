// Copyright (c) 2017 Leacme (http://leac.me). View LICENSE.md for more information.
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using Leacme.Lib.LangCipher;

namespace Leacme.App.LangCipher {

	public class AppUI {

		private StackPanel rootPan = (StackPanel)Application.Current.MainWindow.Content;
		private Library lib = new Library();

		public AppUI() {

			var trltSlt = App.ComboBoxWithLabel;
			trltSlt.label.Text = "Select translation:";
			trltSlt.comboBox.Items = TranslationPairs.AvailableTranslations.Select(z => (z.fromLang + " to " + z.toLang));
			trltSlt.comboBox.SelectedIndex = 0;
			trltSlt.holder.HorizontalAlignment = HorizontalAlignment.Center;

			var tsltBt = App.Button;
			tsltBt.Content = "Translate";
			trltSlt.holder.Children.Add(tsltBt);

			var ftBlurb = App.TextBlock;
			var ttBlurb = App.TextBlock;
			ftBlurb.Text = "Text to translate:";
			ftBlurb.Margin = ttBlurb.Margin = new Thickness(40, 3, 3, 3);
			ttBlurb.Text = "Translated text:";

			var ftPan = App.TextBox;
			var ttPan = App.TextBox;
			ftPan.Width = ttPan.Width = 900;
			ftPan.Height = ttPan.Height = 190;
			ftPan.AcceptsReturn = ttPan.AcceptsReturn = true;
			ftPan.TextWrapping = ttPan.TextWrapping = TextWrapping.Wrap;

			tsltBt.Click += async (z, zz) => {
				if (!string.IsNullOrWhiteSpace(ftPan.Text)) {
					var si = ((string)trltSlt.comboBox.SelectedItem).Split(" to ");
					var si2 = TranslationPairs.AvailableTranslations.First(zzz => zzz.fromLang.Equals(si[0]) && zzz.toLang.Equals(si[1]));
					((App)Application.Current).LoadingBar.IsIndeterminate = true;
					var resp1 = await lib.GetSearchTermResponceAsync(ftPan.Text, si2.fromCode, si2.toCode);
					((App)Application.Current).LoadingBar.IsIndeterminate = false;
					if (resp1.ResponseStatus.Equals(200)) {
						ttPan.Text = resp1.ResponseData.TranslatedText;
					} else {
						ttPan.Text = "ERROR";
					}
				}
			};

			rootPan.Children.AddRange(new List<IControl> { trltSlt.holder, ftBlurb, ftPan, ttBlurb, ttPan });
		}
	}
}