#pragma checksum "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b3c76a7385af8a8bd6fb052ed1eb657890216b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RazorDemo_Example05), @"mvc.1.0.view", @"/Views/RazorDemo/Example05.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\_ViewImports.cshtml"
using MvcApp01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\_ViewImports.cshtml"
using MvcApp01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3c76a7385af8a8bd6fb052ed1eb657890216b6", @"/Views/RazorDemo/Example05.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11208f584f909c0a251e8c70d85ca7c354611120", @"/Views/_ViewImports.cshtml")]
    public class Views_RazorDemo_Example05 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RazorDemo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
  
    string message = "Hello from message, this is to inform you that";
    string[] fruits = new string[] { "Apple", "Banana", "Mango", "Grapes", "Cherry" };

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Razor Demo, Example05</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
 for (int i = 1; i <= 10; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>");
#nullable restore
#line 12 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 404, "\"", 414, 1);
#nullable restore
#line 13 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
WriteAttributeValue("", 412, i, 412, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"radio\" />");
#nullable restore
#line 14 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"checkbox\" />");
#nullable restore
#line 15 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<textarea>");
#nullable restore
#line 19 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
     Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n<br />\r\n<select>\r\n");
#nullable restore
#line 22 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
     foreach (string fruit in fruits)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3c76a7385af8a8bd6fb052ed1eb657890216b67149", async() => {
#nullable restore
#line 24 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
           Write(fruit);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example05.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</select>\r\n<br />\r\nGoTo : ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3c76a7385af8a8bd6fb052ed1eb657890216b68632", async() => {
                WriteLiteral("Razor Demo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
