#pragma checksum "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80fe0a0ce8ec72e523f22778003af3ace7a2c875"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdoDemo_Index), @"mvc.1.0.view", @"/Views/AdoDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80fe0a0ce8ec72e523f22778003af3ace7a2c875", @"/Views/AdoDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11208f584f909c0a251e8c70d85ca7c354611120", @"/Views/_ViewImports.cshtml")]
    public class Views_AdoDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ADO.NET Demo</h1>\r\n");
#nullable restore
#line 7 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table border=\"1\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 11 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
       Write(Html.Label("id", "Employee ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 12 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
       Write(Html.TextBox("id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><input type=\"submit\" name=\"b1\" value=\"Create\" /></td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
       Write(Html.Label("ename", "Employee Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
       Write(Html.TextBox("ename"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><input type=\"submit\" name=\"b1\" value=\"Retrieve\" /></td>\r\n    </tr>\r\n    <tr>\r\n        <td>Job</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
       Write(Html.TextBox("job"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><input type=\"submit\" name=\"b1\" value=\"Update\" /></td>\r\n    </tr>\r\n    <tr>\r\n        <td>Salary</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
       Write(Html.TextBox("salary"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><input type=\"submit\" name=\"b1\" value=\"Delete\" /></td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 31 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />  \r\n");
#nullable restore
#line 33 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />  \r\n");
#nullable restore
#line 35 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 37 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
Write(ViewBag.ename);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 39 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
Write(ViewBag.job);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />  \r\n");
#nullable restore
#line 41 "C:\Users\harshit.gupta2\OneDrive - Incedo Technology Solutions Ltd\Documents\C# Practice\IncedoSolution\MvcApp01\MvcApp01\Views\AdoDemo\Index.cshtml"
Write(ViewBag.salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
