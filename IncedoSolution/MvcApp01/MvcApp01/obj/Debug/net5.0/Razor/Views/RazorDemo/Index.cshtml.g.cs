#pragma checksum "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cfc52d93d8e780f36a2b1a26b377ba96b5afaa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RazorDemo_Index), @"mvc.1.0.view", @"/Views/RazorDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cfc52d93d8e780f36a2b1a26b377ba96b5afaa7", @"/Views/RazorDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11208f584f909c0a251e8c70d85ca7c354611120", @"/Views/_ViewImports.cshtml")]
    public class Views_RazorDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RazorDemo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Razor Demo Controller, Index View</h1>\r\n\r\n<p>Razor is a view engine in .cshtml page used to program</p>\r\n<p>Razor can be implemented in two ways: -</p>\r\n\r\n<p>Single line Razor contains, one statement</p>\r\nDate : ");
#nullable restore
#line 13 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
  Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\nTime : ");
#nullable restore
#line 14 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
  Write(DateTime.Now.ToLongTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                        <br />\r\n\r\n\r\n<p>Multiline Razor Contains, Multi statements.</p>\r\n");
#nullable restore
#line 19 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
   
    string name = "Harshit Gupta";
    string city = "Lucknow";

#line default
#line hidden
#nullable disable
            WriteLiteral("Name : ");
#nullable restore
#line 23 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
  Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , City : ");
#nullable restore
#line 23 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
                 Write(city);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 28 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
   
    string[] actions = { "Example01", "Example02", "Example03", "Example04", "Example05" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\nGoTo:\r\n");
#nullable restore
#line 35 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
 for (int i = 0; i < actions.Length; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cfc52d93d8e780f36a2b1a26b377ba96b5afaa76534", async() => {
#nullable restore
#line 37 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
                                                    Write(actions[i]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
                                 WriteLiteral(actions[i]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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