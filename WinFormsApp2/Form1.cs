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
			openFileDialog.Title = "Dosya Se�";
			openFileDialog.Filter = "Metin Dosyalar� (*.txt)|*.txt|T�m Dosyalar (*.*)|*.*";
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
					Console.WriteLine("Dosya okuma hatas�: " + error.Message);
				}
			}

		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			if (txtName.Text != "" && txtRegExFilter.Text!="") { 
				string pattern = txtRegExFilter.Text;
				Regex regex = new Regex(pattern);
				string input = metin;
			
				// Metinde e�le�enleri bulma
				MatchCollection matches = regex.Matches(input);
				Result result = new Result();
				result.txtResult.Text = "";
			
				// E�le�enleri ekrana yazd�rma
				foreach (Match match in matches)
				{
					result.txtResult.Text += match.Value;
				}
				result.Show();
				txtRegExFilter.Text = "";
			}
			else
			{
				MessageBox.Show("Dosya veya RegEx komutu se�meniz gerekmektedir.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnMorp_Click(object sender, EventArgs e)
		{
			if (txtName.Text != "") { 
			Result result = new Result();
			string metin0 = metin;

			// Zemberek NLP k�t�phanesinin analiz yapmas� i�in gerekli s�n�flar� olu�turuyoruz.
			TurkishMorphology morphology = TurkishMorphology.Builder().SetLexicon(RootLexicon.GetDefault()).Build();
			TurkishTokenizer tokenizer = TurkishTokenizer.Default;
			string lookupRoot = "normalization";
			string lmPath = "lm/lm.2gram.slm";
			TurkishSentenceNormalizer normalizer = new TurkishSentenceNormalizer(morphology, lookupRoot, lmPath);
			
			Morp morp = new Morp();

			// Metindeki hatal� yaz�mlar� d�zeltme i�lemi.
			string duzeltilmisMetin = normalizer.Normalize(metin0);
			// Noktalama i�aretlerini silme i�lemi.
			string noktalamaSilinmisMetin = RemovePunctuation(duzeltilmisMetin);
			morp.Show();

			// Metindeki kelimeleri ay�rma i�lemi.
			List<string> kelimeler = new List<string>();
			foreach (Token token in tokenizer.Tokenize(noktalamaSilinmisMetin))
			{
				kelimeler.Add(token.GetText());
			}

			//Distinct tekrar eden kelimeleri ay�r�r.
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
					//analysisResults nesnesi i�indeki Result de�erlerini ge�i�i de�i�kene at�yoruz
					var tempanalysis = analysisResults.GetAnalysisResults();
					var templongterm = analysisResults.GetAnalysisResults();
					var tempanalysislongterm = "";
					var tempanalysistext = "";
					//a�a��daki for blo�unda analiz etti�imiz metini k�klerine ay�r�yoruz
					for (int i = 0; i < tempanalysis.Count; i++)
					{
						tempanalysistext += tempanalysis[i].GetStem().ToString()+" ";
						tempanalysislongterm += tempanalysis[i].FormatLong()+"\t";	
					}
					kelimelerinKokleri.Add(tempanalysistext);
					longTerm.Add(tempanalysislongterm);
					/*kelimelerinKokleri listemiz i�inde birden fazla stem t�r� bar�nd�r�yor �rne�in g�l�yor i�in
					g�l(fiil) g�l(isim) gibi a�a��daki for blo�u i�inde bunlar�n say�s�n� da teke d���r�yoruz*/
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
					// E�er analiz sonucu yoksa, kelimenin kendisini kullanabiliriz.
					kelimelerinKokleri.Add(kelime);
				}
			}
				//unik hale getirdi�imiz listeyi yeni listemize at�yoruz
				benzersizKokler = kelimelerinKokleri.Distinct().ToList();
				uniqueLongTerm = longTerm.Distinct().ToList();
				//textbox alan�na k�klerimizi yazd�r�yoruz
				foreach(string temp in benzersizKokler) { 
					morp.txtMorp.Text += temp + Environment.NewLine;
					
				}
				foreach (string temp in uniqueLongTerm)
				{
					morp.txtResultFull.Text += temp + Environment.NewLine;
				}
				
			// Noktalama i�aretlerini silme i�lemi i�in bir yard�mc� metot.
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
				MessageBox.Show("Dosya se�meniz gerekmektedir.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
		}
		
	}
}
	
