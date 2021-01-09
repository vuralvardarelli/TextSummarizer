using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummarizer
{
    public static class Summarizer
    {
        public static string Execute(string header, string body)
        {
            List<string> headerWords = new List<string>();
            List<string> bodySentences = new List<string>();
            List<string> bodyParagraphs = new List<string>();
            List<string> summarySentences = new List<string>();

            if (!header.Contains(" "))
            {
                headerWords.Add(header);
            }
            else
            {
                headerWords = header.Split(' ').ToList();
            }

            
            if (body.Contains("\n")) //paragraf varsa paragraflara böl.
            {
                bodyParagraphs = body.Split('\n').ToList();

                if (bodyParagraphs.Count > 0)
                {
                    foreach (var bodyParagraph in bodyParagraphs) //her paragrafin içindeki cümleleri listeye ekle.
                    {
                        if (bodyParagraph.Contains("."))
                        {
                            bodySentences.AddRange(bodyParagraph.Split('.').ToList());
                        }
                    }

                }
            }
            else if (body.Contains(".")) //tek paragrafsa cümlelere böl , cümleleri listeye ekle.
            {
                bodySentences = body.Split('.').ToList();
            }

            foreach (var bodySentence in bodySentences) //cümle listesini tek tek dön
            {
                List<string> sentencesWords = bodySentence.Split(' ').ToList();

                foreach (var word in sentencesWords) //her cümlenin içindeki kelimeyi header'da geçen kelime ile kıyasla, varsa özete ekle.
                {
                    if (headerWords.Where(x => x == word).FirstOrDefault() != null)
                    {
                        summarySentences.Add(bodySentence);
                    }
                }

            }

            //özette aynı oluşabilecek cümleleri ele.
            if (summarySentences.Count > 1)
                summarySentences = summarySentences.Distinct().ToList();


            
            if (bodySentences.Count < 2) //body'de paragraf veya cümleler yok ise direkt body'yi döndür.
            {
                return body;
            }
            else //özet cümlelerini nokta ile birleştirerek paragraf oluştur ve döndür.
            {
                return string.Join(". ", summarySentences);
            }
        }
    }
}
