using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using AngleSharp.Parser.Html;

namespace dotnetRGR
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
                
        static string getResponse(string url)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buf = new byte[8192];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            int count = 0;
            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    sb.Append(Encoding.Default.GetString(buf, 0, count));
                }
            }
            while (count > 0);
            return sb.ToString();
        }
                     
        private void FormMain_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dotnetRGRDataSet.Plants". При необходимости она может быть перемещена или удалена.
            this.plantsTableAdapter.Fill(this.dotnetRGRDataSet.Plants);                     
        }

       

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            int numberPlant = 970; //номер страницы первого растения
            for (int i = numberPlant; i < numberPlant+20; i++)
            {
                dotnetRGRDataSet.PlantsRow row = dotnetRGRDataSet.Plants.NewPlantsRow();

                string url = "http://www.pro-landshaft.ru/plants/detail/"+i.ToString()+"/";
                string source = getResponse(url);
                
                var parser = new HtmlParser();
                var document = parser.Parse(source);
                
                var error = document.QuerySelector(".errortext");
                if ((error != null) && (error.InnerHtml.ToString() == "Элемент не найден!"))
                {
                    continue;
                }
                if (error != null)
                {
                    continue;
                }
                
                else
                {
                    var work = document.QuerySelector("#work");
                    string name = work.QuerySelector("div > h1").InnerHtml;

                    var str = work.QuerySelector(".news-detail > .text");
                    string latName = str.Children.ElementAt(0).InnerHtml;
                    string patternLN = @"(<strong>|Латинское название:|</strong>|</font>|\.)";
                    latName = Regex.Replace(latName, patternLN, String.Empty);


                    string category = str.Children.ElementAt(1).InnerHtml;
                    string patternC = @"<strong>|Категории:|</strong>|<a .*\"">|</a>\.|</strong>|</font>|\.";
                    category = Regex.Replace(category, patternC, String.Empty);

                    string family = str.Children.ElementAt(2).InnerHtml;
                    string patternF = @"<strong>|<font color|=|\""#ff9900\"">|Семейство:|</font>|</strong>|\.";
                    family = Regex.Replace(family, patternF, String.Empty);

                    string homeLand = str.Children.ElementAt(4).InnerHtml;
                    string patternH = @"<strong>|<font|color|=\""#ff9900\"">|Родина|</font>|</strong>|\.";
                    homeLand = Regex.Replace(homeLand, patternH, String.Empty);

                    string form = str.Children.ElementAt(5).InnerHtml;
                    string patternForm = @"<strong>|<font|color|=\""#ff9900\"">|Форма:|</font>|</strong>|\.";
                    form = Regex.Replace(form, patternForm, String.Empty);

                    string description = str.Children.ElementAt(7).InnerHtml;
                    string patternD = @"<em>|</em>|<strong>|<font|color|=\""#ff9900\"">|<img .*;\"">|<img .*\"">|<a .*\"">|</a>| Описание |</strong>|</font>|\.";
                    description = Regex.Replace(description, patternD, String.Empty);
                                       
                    row.Name = name.ToString();
                    row.LatName = latName.ToString();
                    row.Category = category.ToString();
                    row.HomeLand = homeLand.ToString();
                    row.Family = family.ToString();
                    row.Form = form.ToString();
                    row.Description = description.ToString();
                    this.dotnetRGRDataSet.Plants.Rows.Add(row);
                    try
                    {
                        this.plantsTableAdapter.Update(this.dotnetRGRDataSet.Plants);
                        
                    }
                    catch (Exception)
                    {
                        this.plantsTableAdapter.Fill(this.dotnetRGRDataSet.Plants);
                        MessageBox.Show("Запись уже существует в таблице. Она не будет добавлена.");
                    }
                }
            }
            try
            {
                this.plantsTableAdapter.Update(this.dotnetRGRDataSet.Plants);
                this.plantsTableAdapter.Fill(this.dotnetRGRDataSet.Plants);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось сохранить данные.");
            }
        }

      

        private void plantsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.plantsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dotnetRGRDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось сохранить данные.");
            }
        }

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dotnetRGRDataSet.Plants". При необходимости она может быть перемещена или удалена.
            this.plantsTableAdapter.Fill(this.dotnetRGRDataSet.Plants);
        }
    }
}
