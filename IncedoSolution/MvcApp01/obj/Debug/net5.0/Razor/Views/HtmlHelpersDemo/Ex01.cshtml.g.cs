#pragma checksum "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d43bcf61779f574a1cd8e6b86c704cf2b298fed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HtmlHelpersDemo_Ex01), @"mvc.1.0.view", @"/Views/HtmlHelpersDemo/Ex01.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43bcf61779f574a1cd8e6b86c704cf2b298fed6", @"/Views/HtmlHelpersDemo/Ex01.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11208f584f909c0a251e8c70d85ca7c354611120", @"/Views/_ViewImports.cshtml")]
    public class Views_HtmlHelpersDemo_Ex01 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Html Helpers Demo, Ex01</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
Write(Html.Label("a", "Enter Number 1 :"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
                                        ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
Write(Html.TextBox("a"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
Write(Html.Label("b", "Enter Number 1 :"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
                                        ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
Write(Html.TextBox("b"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br />
    <input type=""submit"" name=""ch"" value=""Add"" />
    <input type=""submit"" name=""ch"" value=""Sub"" />
    <input type=""submit"" name=""ch"" value=""Mul"" />
    <input type=""submit"" name=""ch"" value=""Div"" />
    <input type=""submit"" name=""ch"" value=""Big"" />
    <input type=""submit"" name=""ch"" value=""Small"" />
");
#nullable restore
#line 23 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 25 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\HtmlHelpersDemo\Ex01.cshtml"
Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d43bcf61779f574a1cd8e6b86c704cf2b298fed67132", async() => {
                WriteLiteral("Back to Index");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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