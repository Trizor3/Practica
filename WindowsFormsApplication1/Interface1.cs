using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IHtmlCreator
    {
        string CreateHtml();
    }
    public class HtmlInputTextCreator : IHtmlCreator
    {
        public string CreateHtml()
        {
            return "<input type=\"text\" />";
        }
    }
    public class HtmlInputCheckboxCreator : IHtmlCreator
    {
        public string CreateHtml()
        {
            return "<input type=\"checkbox\" />";
        }
    }
}
