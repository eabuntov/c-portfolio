using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace SemiFit
{
	public class FileImport
	{
		static int m_fileCounter=0;
		public enum Delimiter {Tab, Space, Comma, Semicolon };
		public enum ImportType {XYY, XYXY} // to be implemented: Matrix, Curves3D
		Delimiter m_delimiter;
		ImportType m_importType;
		int m_headerLines, m_columns;
		char m_fractionSeparator;

		[DescriptionAttribute("Type of data in the file")]
		[DisplayName("Import type")]
		public ImportType Type
		{
			get { return m_importType; }
			set { m_importType = value; }
		}

		[DescriptionAttribute("Which sign denotes new column")]
		[DisplayName("Column delimiter")]
		public Delimiter ColumnDelimiter
		{
			get { return m_delimiter; }
			set { m_delimiter = value; }
		}

		[DescriptionAttribute("Number of lines to skip")]
		[DisplayName("Header lines")]
		public int HeaderLines
		{
			get { return m_headerLines; }
			set { m_headerLines = value; }
		}

		[DescriptionAttribute("Number of columns")]
		public int Columns
		{
			get { return m_columns; }
			set { m_columns = value; }
		}

		[DescriptionAttribute("Fractions separator")]
		public char Separator
		{
			get { return m_fractionSeparator; }
			set { m_fractionSeparator = value; }
		}

		public FileImport()
		{
			m_columns = 2;
			m_delimiter = FileImport.Delimiter.Tab;
			m_fractionSeparator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];
			m_headerLines = 0;
			m_importType = ImportType.XYY;
		}

		public FileImport(string filename)
		{
			AnalyseFile(filename);
		}

		public string GetHtmlFile(string filename)
		{
			string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "_tmp_htm" + m_fileCounter.ToString() + ".tmp");
			m_fileCounter++;
			string s = htmlHeader;
			string[] ss = File.ReadAllLines(filename);
			int i = 0;
			if (m_headerLines > 0)
			{
				s += "<div class=\"headers\">";
				for (; i < m_headerLines; i++)
					s += ss[i] + "\n";
				s += "</div>";
			}
			for (; i < ss.Length; i++)
				s += ss[i] + "\n";
			s += htmlFooter;
			File.WriteAllText(path, s);
			return path;
		}

		public void AnalyseFile(string filename) //too much AI will kill you :)
		{
			//this is a stub. Rewrite!
			m_columns = 2;
			m_delimiter = FileImport.Delimiter.Tab;
			m_fractionSeparator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];
			m_headerLines = 0;
			m_importType = ImportType.XYY;
		}

		public FitDataSet [] Import(string filename)
		{
			FitDataSet [] dss = new FitDataSet[m_columns];
			switch (m_importType)
			{
				case ImportType.XYY:
					for (int i = 0; i < m_columns - 1; i++)
						dss[i] = new FitDataSet2D();
					FillDataXYY(dss, filename);
					break;
				case ImportType.XYXY:
					for (int i = 0; i < m_columns/2; i++)
						dss[i] = new FitDataSet2D();
					FillDataXYXY(dss, filename);
					break;
				default:
					dss[0] =  new FitDataSet2D();
					break;
			}
			return dss;
		}

		private void FillDataXYY(FitDataSet[] dss, string filename)
		{
			string[] ss = File.ReadAllLines(filename);
			char[] sep = new char[1];
			switch (m_delimiter)
			{
				case Delimiter.Comma:
					sep[0] = ',';
					break;
				case Delimiter.Semicolon:
					sep[0] = ';';
					break;
				case Delimiter.Space:
					sep[0] = ' ';
					break;
				case Delimiter.Tab:
				default:
					sep[0] = '\t';
					break;
			}
			string[] values;
			int j = 1;
			double x, y;
			for (int i = m_headerLines; i < ss.Length; i++)
			{
				values = ss[i].Split(sep);
				for (j = 1; (j < values.Length) && (j <= m_columns); j++)
				{
					if (!double.TryParse(values[0], out x))
						x = 0;
					if (!double.TryParse(values[j], out y))
						y = 0;
					dss[j - 1].Data[0].Add(x);
					dss[j - 1].Data[1].Add(y);
				}
			}
		}

		private void FillDataXYXY(FitDataSet[] dss, string filename)
		{
			string[] ss = File.ReadAllLines(filename);
			char[] sep = new char[1];
			switch (m_delimiter)
			{
				case Delimiter.Comma:
					sep[0] = ',';
					break;
				case Delimiter.Semicolon:
					sep[0] = ';';
					break;
				case Delimiter.Space:
					sep[0] = ' ';
					break;
				case Delimiter.Tab:
				default:
					sep[0] = '\t';
					break;
			}
			string[] values;
			int j = 1;
			double x, y;
			for (int i = m_headerLines; i < ss.Length; i++)
			{
				values = ss[i].Split(sep);
				for (j = 1; (j < values.Length) && (j <= m_columns); j+=2)
				{
					if (!double.TryParse(values[j-1], out x))
						x = 0;
					if (!double.TryParse(values[j], out y))
						y = 0;
					dss[(j - 1) / 2].Data[0].Add(x);
					dss[(j - 1) / 2].Data[1].Add(y);
				}
			}
		}

		const string htmlHeader = "<html xmlns=\"http://www.w3.org/1999/xhtml\" lang=\"en\">\n<body>\n<style type=\"text/css\">\n.headers {\ncolor:#FF0000;\n }\n  </style> ";
		const string htmlFooter = "\n</body>\n</html>";
	}
}
