#pragma checksum "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example04.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d752ca61c4b36f33e79f3e49129f8ba680059f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RazorDemo_Example04), @"mvc.1.0.view", @"/Views/RazorDemo/Example04.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84d752ca61c4b36f33e79f3e49129f8ba680059f", @"/Views/RazorDemo/Example04.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11208f584f909c0a251e8c70d85ca7c354611120", @"/Views/_ViewImports.cshtml")]
    public class Views_RazorDemo_Example04 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example04.cshtml"
  
    string[] inputs = new string[] { "Name", "City", "Age", "Email" };

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Razor Demo, Example04</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example04.cshtml"
 for (int i = 0; i < inputs.Length; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral(" Enter ");
#nullable restore
#line 11 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example04.cshtml"
        Write(inputs[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"text\" />\r\n    <br />\r\n");
#nullable restore
#line 14 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\RazorDemo\Example04.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\nGoTo : ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d752ca61c4b36f33e79f3e49129f8ba680059f5250", async() => {
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
