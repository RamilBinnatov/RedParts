#pragma checksum "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\Shared\_ValidationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce0380d72c173ad6f99db60fa62386481d5f848f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Shared__ValidationPartial), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Shared/_ValidationPartial.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.ProducrCategory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Country;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Material;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Tag;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.BlogCategory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Slider;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Banner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Final_Project.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0380d72c173ad6f99db60fa62386481d5f848f", @"/Areas/AdminArea/Views/Shared/_ValidationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbcf0782a0bf1f7255803d5687ac1eb19f6d7400", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_Shared__ValidationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.5/jquery.validate.min.js"" integrity=""sha512-rstIgDs0xPgmG6RX1Aba4KV5cWJbAMcvRCVmglpam9SoHZiUCyQVDdH2LPlxoHtrv17XWblE/V/PP+Tr04hbtA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/4.0.0/jquery.validate.unobtrusive.min.js"" integrity=""sha512-x+Vm8jC94ynOikewaQXMEkJIOBp7iArs3IhFWSWdRT3Pq8wFz46p+ZDFAR7kHnSFf+zUv52B3prRYnbDRdgog=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>");
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
