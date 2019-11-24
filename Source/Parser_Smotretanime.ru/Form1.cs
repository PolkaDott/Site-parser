using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Collections.Generic;
using System.Threading;
using System.Net.Http;
using AngleSharp.Html.Parser;

namespace Parser_Smotretanime.ru
{
    public partial class Form1 : Form
    {
        private Parser parser;
        private System.Timers.Timer timer1, timer2;
        public int CountParsedPages { get; private set; }
        private int countParsedPagesForComparison;
        public int LastParsedPage { get; set; }
        private int delayForTimer1 = 40;
        private int delayForTimer2 = 400;
        public event Action<string> ProfileFound;
        public event Action<string> ProfileNotFound;
        private DateTime timeBeginParse;

        public Form1()
        {
            InitializeComponent();
            InitializeParser();
            choiceCountThreads.SelectedIndex = 24;
            Task.Run(() => MessageBox.Show("Эта программа бесплатно предоставляется в свободном доступе с открытым исходным кодом на" +
                " github.com/polkadott/Site-Parser. Связаться с создателем можно в вк vk.com/Ld170. Чтобы пользоваться " +
                "программой, нужно только ввести ссылку на Vk, Shikimori или указать ник, который у пользователя " +
                "в профиле. Этого хватит, чтобы начать поиск профиля на сайте.", "Информация", MessageBoxButtons.OK));
        }
        
        private async void InitializeParser()
        {
            ProfileFound += ShowResult;
            ProfileNotFound += FailSearch;
            await Task.Run(() => parser = new Parser(ProfileFound, ProfileNotFound, this));
            this.btnSearch.Enabled = true;
        }

        public void IncCountParsedPages() { CountParsedPages++; }

        private void Form1_Load(object sender, EventArgs e){}

        private void RefreshCountCheckedPages(Object source, ElapsedEventArgs e)
        {
            try
            {
                lableParsed.BeginInvoke((Action)(() =>
                {
                    lableParsed.Text = "Проверено страниц: " + CountParsedPages.ToString();
                    //lableRunningThreads.Text = "Активных потоков: " + parser.GetCountRunningThreads().ToString();
                    //lableLastPage.Text = "Последняя проверенная страница: " + parser.LastParsedPage.ToString();
                }));
            }
            catch (InvalidOperationException) { Close(); }
        }

        TimeSpan timeOfChecking;
        private void RefreshSpeedOfCheck(Object source, ElapsedEventArgs e)
        {
            try
            {
                int cppfc = countParsedPagesForComparison;
                countParsedPagesForComparison = CountParsedPages;
                timeOfChecking = DateTime.Now - timeBeginParse;
                lableSpeedParsing.BeginInvoke((Action)(() =>
                {
                    labelTimeLost.Text = "Прошло времени: " + timeOfChecking.ToString("hh':'mm':'ss");
                    lableSpeedParsing.Text = "Скорость проверки: " + System.Math.Round((CountParsedPages - cppfc) / (delayForTimer2 / 1000.0)).ToString() + " стр/с";
                }));
            }
            catch(InvalidOperationException) { Close(); }
        }

        private void RunParser(object sender, EventArgs e)
        {            
            if (textBoxVk.Text.Length == 0 && textBoxShk.Text.Length == 0 && textBoxNck.Text.Length == 0)
            {
                MessageBox.Show("Данные для поиска не указаны");
                return;
            }
            try 
            { 
                if (ConvertPages() != 0) return; 
            }
            catch(Exception)
            {
                MessageBox.Show("Кажется, у вас проблемы с интернетом");
                return;
            }

            btnSearch.Visible = false;
            btnStop.Visible = true;
            informationLabel.Text = "Идёт парсинг... Всего страниц более 150000";
            lableParsed.Visible = true;
            lableSpeedParsing.Visible = true;
            labelTimeLost.Visible = true;
            choiceCountThreads.Visible = false;
            labelWithChoiceThreads.Visible = false;
            informationLabel.ForeColor = System.Drawing.Color.Gray;
            if (parser.LastParsedPage == 0)
                timeBeginParse = DateTime.Now;
            else
                timeBeginParse = DateTime.Now - timeOfChecking;

            timer1 = new System.Timers.Timer(delayForTimer1);
            timer2 = new System.Timers.Timer(delayForTimer2);
            timer1.Elapsed += RefreshCountCheckedPages;
            timer2.Elapsed += RefreshSpeedOfCheck;
            timer1.AutoReset = timer2.AutoReset = true;
            timer1.Enabled = timer2.Enabled = true;

            //int nomberStartPage = 0;
            //if (startPage.Text.Length > 0)
            //    try
            //    { nomberStartPage = Int32.Parse(startPage.Text); }
            //    catch (System.FormatException) {;}
            //    catch (System.OverflowException) {;}
            
            parser.StartParse(textBoxVk.Text, textBoxShk.Text, textBoxNck.Text, choiceCountThreads.SelectedIndex+1);
        }

        private int ConvertPages()
        {
            string pageVk = textBoxVk.Text;
            if (pageVk.Length != 0)
            {
                var post = new Dictionary<string, string> { { "uid", pageVk } };
                var postEncoded = new FormUrlEncodedContent(post);
                var response = (new HttpClient()).PostAsync("https://vkserv.ru/api/get-vk-id", postEncoded).Result;
                var html = response.Content.ReadAsStringAsync().Result;
                var document = (new HtmlParser()).ParseDocumentAsync(html).Result;
                var result = document.QuerySelectorAll(selectors: ".get-vk-id-meaning.text-success.font-weight-bold");
                if (result.Length == 0)
                {
                    if (pageVk.StartsWith("vk.com"))
                        MessageBox.Show("Не существует страницы " + "https://" + pageVk);
                    else if (pageVk.StartsWith("id") || !pageVk.StartsWith("https://"))
                        MessageBox.Show("Не существует страницы " + "https://vk.com/" + pageVk);
                    else if (pageVk.StartsWith("https://"))
                        MessageBox.Show("Не существует страницы " + pageVk);
                    return 1;
                }
                else
                {
                    string link = result[4].TextContent;
                    textBoxVk.Text = link;
                }
            }

            string pageShk = textBoxShk.Text;
            if (pageShk.Length != 0)
            {
                if (pageShk.StartsWith("shikimori.one"))
                    textBoxShk.Text = pageShk.Insert(0, "http://");
                else if (!pageShk.StartsWith("http://"))
                    textBoxShk.Text = pageShk.Insert(0, "http://shikimori.one/");
            }

            return 0;
        }

        private void TextBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnSearch.Visible == true)
                RunParser(null, null);
        }

        private void AbortParser(object sender, EventArgs e)
        {
            lableParsed.BeginInvoke((Action)(() =>
            {
                startPage.Text = parser.LastParsedPage.ToString();
                btnSearch.Visible = true;
                btnSearch.Enabled = false;
                btnStop.Visible = false;
                choiceCountThreads.Visible = true;
                labelWithChoiceThreads.Visible = true;
                informationLabel.Text = "Парсинг приостановлен.";
                informationLabel.ForeColor = System.Drawing.Color.Red;
            }));
            
            timer1.Stop();
            timer2.Stop();
            parser.StopParse();

            Task.Run(() =>
            {
                Thread.Sleep(600);
                btnSearch.BeginInvoke((Action)(() => { btnSearch.Enabled = true; }));
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // сука как это удалить
        }

        private void FailSearch(string msg)
        {
            AbortParser(null, null);
            informationLabel.BeginInvoke((Action)(() =>
            {
                informationLabel.ForeColor = System.Drawing.Color.Red;
                informationLabel.Text = msg;
                btnSearch.Visible = false;
                choiceCountThreads.Visible = false;
                labelWithChoiceThreads.Visible = false;
            }));
        }

        private void ShowResult(string result)
        {
            AbortParser(null, null);
            informationLabel.BeginInvoke((Action)(() =>
            {
                informationLabel.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
                informationLabel.Text = "Найден профиль: " + result;
                btnSearch.Visible = false;
                choiceCountThreads.Visible = false;
                labelWithChoiceThreads.Visible = false;
            }));
        }
    }
}
