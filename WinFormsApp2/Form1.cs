using System.Text.RegularExpressions;
using ZemberekDotNet.Morphology;
using ZemberekDotNet.Tokenization;
using ZemberekDotNet.Normalization;
using ZemberekDotNet.Morphology.Lexicon;
using Microsoft.VisualBasic.ApplicationServices;
using ZemberekDotNet.Morphology.Analysis;

namespace WinFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static string metin = "";
		public void btnAddFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Dosya Seç";
			openFileDialog.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
			openFileDialog.Multiselect = false;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.SafeFileName;
				string filePath = openFileDialog.FileName;
				txtName.Text = fileName;

				try
				{
					using (StreamReader sr = new StreamReader(filePath))
					{	
						string satir;
						metin = "";
						while ((satir = sr.ReadLine()) != null)
						{
							metin += satir;
						}
					}
				}
				catch (Exception error)
				{
					Console.WriteLine("Dosya okuma hatasý: " + error.Message);
				}
			}

		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			if (txtName.Text != "" && txtRegExFilter.Text!="") { 
				string pattern = txtRegExFilter.Text;
				Regex regex = new Regex(pattern);
				string input = metin;
			
				// Metinde eþleþenleri bulma
				MatchCollection matches = regex.Matches(input);
				Result result = new Result();
				result.txtResult.Text = "";
			
				// Eþleþenleri ekrana yazdýrma
				foreach (Match match in matches)
				{
					result.txtResult.Text += match.Value;
				}
				result.Show();
				txtRegExFilter.Text = "";
			}
			else
			{
				MessageBox.Show("Dosya veya RegEx komutu seçmeniz gerekmektedir.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnMorp_Click(object sender, EventArgs e)
		{
			if (txtName.Text != "") { 
			Result result = new Result();
			string metin0 = metin;

			// Zemberek NLP kütüphanesinin analiz yapmasý için gerekli sýnýflarý oluþturuyoruz.
			TurkishMorphology morphology = TurkishMorphology.Builder().SetLexicon(RootLexicon.GetDefault()).Build();
			TurkishTokenizer tokenizer = TurkishTokenizer.Default;
			string lookupRoot = "normalization";
			string lmPath = "lm/lm.2gram.slm";
			TurkishSentenceNormalizer normalizer = new TurkishSentenceNormalizer(morphology, lookupRoot, lmPath);
			
			Morp morp = new Morp();

			// Metindeki hatalý yazýmlarý düzeltme iþlemi.
			string duzeltilmisMetin = normalizer.Normalize(metin0);
			// Noktalama iþaretlerini silme iþlemi.
			string noktalamaSilinmisMetin = RemovePunctuation(duzeltilmisMetin);
			morp.Show();

			// Metindeki kelimeleri ayýrma iþlemi.
			List<string> kelimeler = new List<string>();
			foreach (Token token in tokenizer.Tokenize(noktalamaSilinmisMetin))
			{
				kelimeler.Add(token.GetText());
			}

			//Distinct tekrar eden kelimeleri ayýrýr.
			List<string> benzersizKelimeler = kelimeler.Distinct().ToList();

			List<string> kelimelerinKokleri = new List<string>();
			List<string> benzersizKokler = new List<string>();
			List<string> longTerm = new List<string>();
			List<string> uniqueLongTerm = new List<string>();

			foreach (string kelime in benzersizKelimeler)
			{
				var analysisResults = morphology.Analyze(kelime);
				if (analysisResults.Count() > 0)
				{
					//analysisResults nesnesi içindeki Result deðerlerini geçiçi deðiþkene atýyoruz
					var tempanalysis = analysisResults.GetAnalysisResults();
					var templongterm = analysisResults.GetAnalysisResults();
					var tempanalysislongterm = "";
					var tempanalysistext = "";
					//aþaðýdaki for bloðunda analiz ettiðimiz metini köklerine ayýrýyoruz
					for (int i = 0; i < tempanalysis.Count; i++)
					{
						tempanalysistext += tempanalysis[i].GetStem().ToString()+" ";
						tempanalysislongterm += tempanalysis[i].FormatLong()+"\t";	
					}
					kelimelerinKokleri.Add(tempanalysistext);
					longTerm.Add(tempanalysislongterm);
					/*kelimelerinKokleri listemiz içinde birden fazla stem türü barýndýrýyor örneðin gülüyor için
					gül(fiil) gül(isim) gibi aþaðýdaki for bloðu içinde bunlarýn sayýsýný da teke düþürüyoruz*/
					for (int i = 0; i < kelimelerinKokleri.Count; i++)
					{
						string tempSplit = kelimelerinKokleri[i];
						var tempSplited = tempSplit.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
						string sonucMetin = string.Join(" ", tempSplited.Distinct());
						kelimelerinKokleri[i] = sonucMetin;
					}
				}
				else
				{
					// Eðer analiz sonucu yoksa, kelimenin kendisini kullanabiliriz.
					kelimelerinKokleri.Add(kelime);
				}
			}
				//unik hale getirdiðimiz listeyi yeni listemize atýyoruz
				benzersizKokler = kelimelerinKokleri.Distinct().ToList();
				uniqueLongTerm = longTerm.Distinct().ToList();
				//textbox alanýna köklerimizi yazdýrýyoruz
				foreach(string temp in benzersizKokler) { 
					morp.txtMorp.Text += temp + Environment.NewLine;
					
				}
				foreach (string temp in uniqueLongTerm)
				{
					morp.txtResultFull.Text += temp + Environment.NewLine;
				}
				
			// Noktalama iþaretlerini silme iþlemi için bir yardýmcý metot.
			static string RemovePunctuation(string input)
			{
				return new string(input.ToCharArray()
					.Where(c => !char.IsPunctuation(c))
					.ToArray());
			}
				morp.txtBeforeAnalyze.Text = benzersizKelimeler.Count().ToString();
				morp.txtAfterAnalyze.Text = benzersizKokler.Count().ToString();
		}
			else
			{
				MessageBox.Show("Dosya seçmeniz gerekmektedir.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
		}
		
	}
}
	
