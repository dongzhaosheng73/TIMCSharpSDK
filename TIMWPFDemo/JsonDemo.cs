using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIMSDK.Model;

namespace TIMWPFDemo
{

    //public enum ElemType
    //{
    //    text,
    //    image,
    //    audio
    //}

    //public interface IElem
    //{
    //    ElemType type { set; get; }
    //}

    //public class Elem : IElem
    //{
    //    public ElemType type { set; get; }
    //}

    //public class TextElem:Elem
    //{
    //    public string Text { set; get; }
    //}

    //public class ImageElem:Elem
    //{
    //    public string ImageUrl { set; get; }
    //}

    //public class AudioElem:Elem
    //{
    //    public object AudioData { set; get; }
    //}

    //public class Message
    //{
    //    public  List<IElem> Elems { set; get; }
    //}

    public class JsonDemo
    {
        public JsonDemo()
        {
            var test_json = JsonConvert.SerializeObject(new List<TMessage>()
            {
                new TMessage()
                {
                    kTIMMsgElemArray = new List<Elem>()
                    {
                       new TextElem()
                       {
                        kTIMElemType = TIMSDK.Enum.TIMElemType.kTIMElem_Text,kTIMTextElemContent ="text"
                       },
                       new TextElem(){kTIMElemType = TIMSDK.Enum.TIMElemType.kTIMElem_Text, kTIMTextElemContent= "text2"},
                       new ImageElem(){ kTIMElemType = TIMSDK.Enum.TIMElemType.kTIMElem_Image, kTIMImageElemLargeUrl="test url"}

                    }
                    
                }
            });
           var messages =  JsonConvert.DeserializeObject<List<TMessage>>(test_json);
        }
    }
}
