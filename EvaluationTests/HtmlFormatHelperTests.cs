using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;

namespace EvaluationTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
       public void Init()
        {
            _htmlFormatHelper =new HtmlFormatHelper();
        }
        
        [TestMethod]
        [DataRow("test","<b>test</b>")]
        public void GetBoldFormat_WithBalise_ReturnTrue(string content, string expectedValue)
        {
            var result = _htmlFormatHelper.GetBoldFormat(content);
            Assert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        [DataRow("test", "<i>test</i>")]
        public void GetItalicFormat_WithBalise_ReturnTrue(string content, string expectedValue)
        {
            var result = _htmlFormatHelper.GetItalicFormat(content);
            Assert.AreEqual(expectedValue, result);
        }
       
    }
}
