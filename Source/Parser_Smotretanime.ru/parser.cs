using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using AngleSharp.Html.Parser;

namespace Parser_Smotretanime.ru
{
    class Parser
    {
        Form1 parent;
        private int nowIndexPage, counterErrors;
        private bool isActiveParse = false;
        private int startIndexPage = 150000;
        private int countThreads;
        public int LastParsedPage { get; set; }
        private bool[] respondsByThreads;
        event Action<string> ProfileFound;
        event Action<string> ProfileNotFound;

        public Parser(Action<string> pf, Action<string> pnf, Form1 parent)
        {
            this.parent = parent;
            this.ProfileFound += pf;
            this.ProfileNotFound += pnf;
            respondsByThreads = new bool[countThreads];
        }
        public void StartParse(string pageVk, string pageShk, string nick, int countThreads)
        {
            this.countThreads = countThreads;
            nowIndexPage = startIndexPage;
            isActiveParse = true;
            
            idThread = -1;
            Task.Run(() =>
            {
                for (int i = 0; i < countThreads; i++)
                {
                    Thread.Sleep(50);
                    (new Thread(() => ParsePages(pageVk, pageShk, nick))).Start();
                }
            });
        }

        private int idThread, incrementForFunctionParsePages = 1;
        private void ParsePages(string pageVk, string pageShk, string nick)
        {
            int id = ++idThread;
            HttpClient client = new HttpClient();
            HtmlParser parser = new HtmlParser();
            while (isActiveParse)
            {
                if (ParseOnePage(pageVk, pageShk, nick, nowIndexPage += incrementForFunctionParsePages, id, client, parser) == 1)
                {
                    if (nowIndexPage < 4769 && isActiveParse)
                    {
                        isActiveParse = false;
                        ProfileNotFound("Профиля с такими данными не найдено.");
                    }
                    counterErrors++;
                    if (counterErrors > 50) // парс дошёл до самой последней страницы, нужно парсить от новых к старым
                    {
                        if (incrementForFunctionParsePages == 1)
                        {
                            counterErrors = 0;
                            nowIndexPage = startIndexPage;
                            incrementForFunctionParsePages = -1;
                        }
                        else
                        {
                            isActiveParse = false;
                            ProfileNotFound("Парс не удался. Какие-то проблемы с ответом от сервера");
                        }
                    }
                }
                else counterErrors = 0;
            }
        }

        private int ParseOnePage(string pageVk, string pageShk, string nick, int indexPage, int id, HttpClient client, HtmlParser parser)
        {
            //respondsByThreads[id] = true;
            var responce = client.GetAsync("https://smotret-anime.online/users/" + indexPage.ToString()).Result;
            string code = responce.Content.ReadAsStringAsync().Result;
            var document = parser.ParseDocumentAsync(code).Result;
            var results = document.QuerySelectorAll(selectors: "#yw0>li>a, #yw2>li>a");

            bool isFound = false;
            string nickName = null;
            try { nickName = document.QuerySelector(selectors: "div.m-small-title").TextContent; }
            catch (System.NullReferenceException) {
                return 1; 
            }

            if (String.Compare(nickName, nick) == 0 && nickName.Length != 0 && nick.Length != 0)
                isFound = true;
            foreach (var keks in results)
            {
                if (keks.TextContent.Contains("Профиль ВКонтакте"))
                    if (String.Compare(pageVk, keks.GetAttribute("href")) == 0)
                        isFound = true;
                if (keks.TextContent.Contains("Профиль Шикимори"))
                    if (String.Compare(pageShk, keks.GetAttribute("href")) == 0)
                        isFound = true;
            }

            parent.IncCountParsedPages();
            LastParsedPage = indexPage;

            if (isFound)
                ProfileFound(nickName + " - smotret-anime.online/users/" + indexPage.ToString());

            return 0;
        }

        public void StopParse()
        {
            isActiveParse = false;
        }

        public string GetCountRunningThreads()
        {
            int count = 0;
            for (int i = 0; i < countThreads; i++)
                if (respondsByThreads[i] == true)
                {
                    count++;
                    respondsByThreads[i] = false;
                }
            return count.ToString();
        }
    }
}
