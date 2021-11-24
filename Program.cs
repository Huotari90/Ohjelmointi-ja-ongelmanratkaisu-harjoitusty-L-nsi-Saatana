using System;
using System.Net;
using HtmlAgilityPack;

namespace Länsi_Saatana
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.lansi-savo.fi/");
            string theWholePage = document.DocumentNode.OuterHtml;
            Console.Write(theWholePage);
        }


        HtmlNodeCollection importantRows =
        document.DocumentNode.SelectNodes("//a[@class='card__link']");
 
        foreach (HtmlNode node in importantRows)
    {
        string textValue = node.InnerText;
        Console.WriteLine(textValue);
    }

}

}
