#pragma checksum "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f69ad8146aa562e953db8dae0966bdee0aaf366c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlogDetail_Index), @"mvc.1.0.view", @"/Views/BlogDetail/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\_ViewImports.cshtml"
using Final_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Page;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f69ad8146aa562e953db8dae0966bdee0aaf366c", @"/Views/BlogDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0cf4ca5c7ab08cba79a42a0abc9927e646d3c50", @"/Views/_ViewImports.cshtml")]
    public class Views_BlogDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDetVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section id=\"blog-detail\">\r\n    <div class=\"blog-background\">\r\n        <div class=\"blog-image-text\">\r\n            <a href=\"blog.html\">Latest News</a>\r\n            <h2>");
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p><span>By ");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                   Write(Model.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span>");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                                               Write(Model.Createdate.ToString("MMMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n        </div>\r\n\r\n\r\n        <div class=\"blog-image\"");
            BeginWriteAttribute("style", " style=\"", 359, "\"", 439, 4);
            WriteAttributeValue("", 367, "background-image:", 367, 17, true);
            WriteAttributeValue(" ", 384, "url(\'", 385, 6, true);
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
WriteAttributeValue("", 390, Url.Content("~/Assets/Img/blog/download.jpg"), 390, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 436, "\');", 436, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">

        </div>
    </div>


    <div class=""blog-detail-main"">
        <div class=""my-container"">
            <div class=""all-blog-detail-main"">
                <div class=""left-blog-detail"">
                    <div class=""about-box blog-box"">
                        <div class=""box-head"">
                            <h3>About Blog</h3>
                        </div>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tincidunt, erat in malesuada aliquam, est erat faucibus purus, eget viverra nulla sem vitae neque. Quisque id sodales libero.</p>
                        <div class=""bottom-ico"">
                            <div class=""ico-box ins"">
                                <i class=""fa-brands fa-instagram""></i>
                            </div>
                            <div class=""ico-box tw"">
                                <i class=""fa-brands fa-twitter""></i>
                            </div>
                            <div class=""ico-");
            WriteLiteral(@"box yt"">
                                <i class=""fa-brands fa-youtube""></i>
                            </div>
                            <div class=""ico-box fb"">
                                <i class=""fa-brands fa-facebook""></i>
                            </div>
                        </div>
                    </div>

                    <div class=""categories-box blog-box"">
                        <div class=""box-head"">
                            <h3>Categories</h3>
                        </div>
                        <ul>
");
#nullable restore
#line 48 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                             foreach (var item in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f69ad8146aa562e953db8dae0966bdee0aaf366c9456", async() => {
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>


                    <div class=""latest-box blog-box"">
                        <div class=""box-head"">
                            <h3>Latest Posts</h3>
                        </div>

                        <div class=""latest-main"">

");
#nullable restore
#line 64 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                             foreach (var item in Model.RecentPosts)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"post-box\">\r\n                                    <div class=\"post-img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f69ad8146aa562e953db8dae0966bdee0aaf366c13138", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2850, "~/Assets/Img/blog/", 2850, 18, true);
#nullable restore
#line 68 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
AddHtmlAttributeValue("", 2868, item.Image, 2868, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n\r\n                                    <div class=\"post-text\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f69ad8146aa562e953db8dae0966bdee0aaf366c14879", async() => {
#nullable restore
#line 72 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                                                                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-catId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["catId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-catId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["catId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <p>");
#nullable restore
#line 73 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                                      Write(item.CreateDate.ToString("MMMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 76 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                    </div>


                    <div class=""tags-box blog-box"">
                        <div class=""box-head"">
                            <h3>Tags Cloud</h3>
                        </div>

                        <div class=""tags-main"">

");
#nullable restore
#line 91 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                             foreach (var item in Model.AllTag)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"tag-box\">\r\n                                    <a >");
#nullable restore
#line 94 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </div>\r\n");
#nullable restore
#line 96 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                    </div>
                </div>


                <div class=""right-blog-detail"">
                    <div class=""right-text"">
                        <div class=""blog-d-image"">
                            <div class=""img-box"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f69ad8146aa562e953db8dae0966bdee0aaf366c19825", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4246, "~/Assets/Img/blog/", 4246, 18, true);
#nullable restore
#line 108 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
AddHtmlAttributeValue("", 4264, Model.Image, 4264, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""img-text"">
                                <p>Nunc viverra, dui nec commodo dignissim, libero arcu.</p>
                            </div>
                        </div>


                            ");
#nullable restore
#line 116 "C:\Users\ASUS\Desktop\Projects\FinalProject-Eli\Final-Project\Views\BlogDetail\Index.cshtml"
                       Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        <div class=""tags-box blog-box"">

                            <div class=""tags-main"">
                                <div class=""tag-box"">
                                    <a href=""blog.html"">Philosophy</a>
                                </div>


                            </div>

                        </div>
                    </div>

                    <div class=""blog-review"">
                        <div class=""comment-box"">
                            <div class=""comment-author"">
                                <h4>Leonid</h4>
                            </div>

                            <div class=""comment-content"">
                                <p>I'd like this one on my car</p>
                            </div>
                        </div>






                        <div class=""write-place"">
                            <h3>Write A Comment</h3>
                            <div class=""write-main"">
                            ");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f69ad8146aa562e953db8dae0966bdee0aaf366c23027", async() => {
                WriteLiteral(@"
                                    <div class=""review-stars"">
                                        <div class=""rating-head"">
                                            <h6>Review Stars</h6>
                                        </div>
                                        <div class=""product-rating"">
                                            <span>???</span><span>???</span><span>???</span><span>???</span><span>???</span>
                                        </div>
                                    </div>

                                    <div class=""input-box"">
                                        <label for=""name"">Your Name</label>
                                        <input type=""text"" id=""name"" placeholder=""Your Name"">
                                    </div>


                                    <div class=""input-box"">
                                        <label for=""email"">Email Address</label>
                                        <input type=""email"" id=""email"" p");
                WriteLiteral(@"laceholder=""Email Address"">
                                    </div>


                                    <div class=""textarea-box"">
                                        <label for=""textarea"">Your Review</label>
                                        <textarea id=""textarea""></textarea>
                                    </div>



                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            </div>

                            <div class=""write-btn"">

                                <button type=""button"">Post Comment</button>

                            </div>
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>



</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDetVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
