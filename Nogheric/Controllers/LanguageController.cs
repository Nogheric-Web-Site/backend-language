using Nogheric.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web;

namespace Nogheric.Controllers
{
    
    public class LanguageController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetLanguage(PageIndex pageIndex)
        {
            string language;

            //dynamic jsonRequest = pageIndex;

            //string transalatedText = "";

            //var url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl="
            //    + jsonRequest.sourceLang + "&tl=" + jsonRequest.targetLang + "&dt=t&q=" + jsonRequest.sourceText;

            //using (HttpClient client = new HttpClient())
            //using (HttpResponseMessage response = client.GetAsync(url))
            //using (HttpContent content = response.Content)
            //{
            //    var tr = content.ReadAsStringAsync().Result;
            //    JArray ja = JsonConvert.DeserializeObject<JArray>(tr);
            //    transalatedText = ja[0][0][0].ToString();
            //}

            try
            {
                switch (pageIndex.Language)
                {
                    case 1:
                        language = "";
                        break;
                    case 2:
                        language = "en-US";
                        break;
                    case 3:
                        language = "de-DE";
                        break;
                    case 4:
                        language = "es-ES";
                        break;
                    case 5:
                        language = "fr-FR";
                        break;
                    case 6:
                        language = "it-IT";
                        break;
                    case 7:
                        language = "nl-BE";
                        break;
                    case 8:
                        language = "zh-CHS";
                        break;
                    case 9:
                        language = "zh-CHT";
                        break;
                    case 10:
                        language = "ja-JP";
                        break;
                    case 11:
                        language = "ko-KR";
                        break;
                    case 12:
                        language = "ru-RU";
                        break;
                    case 13:
                        language = "cs-CZ";
                        break;
                    case 14:
                        language = "pl-PL";
                        break;
                    case 15:
                        language = "hu-HU";
                        break;
                    case 16:
                        language = "pt-BR";
                        break;
                    default:
                        // Maybe new value of the enum hasn't own 
                        // `case`...
                        language = "es-ES";
                        break;
                }
                CultureInfo ui_culture = new CultureInfo(language);
                CultureInfo culture = new CultureInfo(language);

                Thread.CurrentThread.CurrentUICulture = ui_culture;
                Thread.CurrentThread.CurrentCulture = culture;


                return Ok(new { status = 200, message = "Exitoso.", response = pageIndex });
            }
            catch (Exception e)
            {
                return Ok(new { status = 400, message = "Error de respuesta." });
            }

        }

        [HttpPost]
        public IHttpActionResult PostLanguage(PageIndex pageIndex)
        {
            var toLanguage = "";//English

            var fromLanguage = "es";//Deutsch

            String text = "";

            switch (pageIndex.Language)
            {
                case 1:
                    toLanguage = "en";
                    break;
                case 2:
                    toLanguage = "de";
                    break;
                case 3:
                    toLanguage = "es";
                    break;
                case 4:
                    toLanguage = "fr";
                    break;
                case 5:
                    toLanguage = "it";
                    break;
                case 6:
                    toLanguage = "nl";
                    break;
                case 7:
                    toLanguage = "zh";
                    break;
                case 8:
                    toLanguage = "ja";
                    break;
                case 9:
                    toLanguage = "ko";
                    break;
                case 10:
                    toLanguage = "ru";
                    break;
                case 11:
                    toLanguage = "cs";
                    break;
                case 12:
                    toLanguage = "pl";
                    break;
                case 13:
                    toLanguage = "hu";
                    break;
                case 14:
                    toLanguage = "pt";
                    break;
                default:
                    // Maybe new value of the enum hasn't own 
                    // `case`...
                    toLanguage = "es";
                    break;
            }

            text = pageIndex.Head;

            var urlHead = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(pageIndex.Head)}";
            var urlBody = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(pageIndex.Body)}";
            var urlFoot = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(pageIndex.Foot)}";
            var webClient = new WebClient { Encoding = System.Text.Encoding.UTF8 }; 

            var head = webClient.DownloadString(urlHead);

            var body = webClient.DownloadString(urlBody);

            var foot = webClient.DownloadString(urlFoot);
            try 
            {
                pageIndex.Head = head.Substring(4, head.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                pageIndex.Body = body.Substring(4, body.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                pageIndex.Foot = foot.Substring(4, foot.IndexOf("\"", 4, StringComparison.Ordinal) - 4);

                return Ok(new { status = 200, message = "Exitoso.", response = pageIndex });
            } 
            catch (Exception e)
            {
                return Ok(new { status = 400, message = "Error de respuesta." });
            }

        }


    }
}
