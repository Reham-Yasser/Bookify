#pragma checksum "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa9f759fcbd2e545e9b83976f05c0fa7e410b1d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admins_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Admins/Index.cshtml")]
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
#line 1 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\_ViewImports.cshtml"
using SamarApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9f759fcbd2e545e9b83976f05c0fa7e410b1d7", @"/Areas/Admin/Views/Admins/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb4ef3b69560b4833d48caf5c0e9dfaf41c46f9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Admins_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/assets/images/dashboard/circle.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("circle-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialVeiw", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <div class=""content-wrapper"">
            <div class=""page-header"">
              <h3 class=""page-title"">
                <span class=""page-title-icon bg-gradient-primary text-white me-2"">
                  <i class=""mdi mdi-home""></i>
                </span> Home
              </h3>
              <nav aria-label=""breadcrumb"">
                <ul class=""breadcrumb"">
                  <li class=""breadcrumb-item active"" aria-current=""page"">
                    <span></span>Overview <i class=""mdi mdi-alert-circle-outline icon-sm text-primary align-middle""></i>
                  </li>
                </ul>
              </nav>
            </div>
            <div class=""row"">
              <div class=""col-md-4 stretch-card grid-margin"">
                <div class=""card bg-gradient-danger card-img-holder text-white"">
                  <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa9f759fcbd2e545e9b83976f05c0fa7e410b1d76972", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <h4 class=""font-weight-normal mb-3"">Weekly Sales <i class=""mdi mdi-chart-line mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">$ 15,0000</h2>
                    <h6 class=""card-text"">Increased by 60%</h6>
                  </div>
                </div>
              </div>
              <div class=""col-md-4 stretch-card grid-margin"">
                <div class=""card bg-gradient-info card-img-holder text-white"">
                  <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa9f759fcbd2e545e9b83976f05c0fa7e410b1d78730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <h4 class=""font-weight-normal mb-3"">Weekly Orders <i class=""mdi mdi-bookmark-outline mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">45,6334</h2>
                    <h6 class=""card-text"">Decreased by 10%</h6>
                  </div>
                </div>
              </div>
              <div class=""col-md-4 stretch-card grid-margin"">
                <div class=""card bg-gradient-success card-img-holder text-white"">
                  <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa9f759fcbd2e545e9b83976f05c0fa7e410b1d710496", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <h4 class=""font-weight-normal mb-3"">Visitors Online <i class=""mdi mdi-diamond mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">95,5741</h2>
                    <h6 class=""card-text"">Increased by 5%</h6>
                  </div>
                </div>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-7 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <div class=""clearfix"">
                      <h4 class=""card-title float-left"">Visit And Sales Statistics</h4>
                      <div id=""visit-sale-chart-legend"" class=""rounded-legend legend-horizontal legend-top-right float-right""></div>
                    </div>
                    <canvas id=""visit-sale-chart"" class=""mt-4""></canvas>
                  </div>
                </div>
              </div>
              <div class=""col-md-5 grid-margin s");
            WriteLiteral(@"tretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title"">Traffic Sources</h4>
                    <canvas id=""traffic-chart""></canvas>
                    <div id=""traffic-chart-legend"" class=""rounded-legend legend-vertical legend-bottom-left pt-4""></div>
                  </div>
                </div>
              </div>
            </div>


            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa9f759fcbd2e545e9b83976f05c0fa7e410b1d713235", async() => {
                WriteLiteral(@" 
            <div class=""row"">
            <div class=""col-sm-8"">
            <input placeholder=""Search by User Name"" name=""SearchValue"" class=""form-control"" />
           </div>
           <div class=""col-sm-4"">
            <input type=""submit"" value=""Search"" class=""btn btn-success btn-block"" />
            </div>
           </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


            <div class=""row"">
              <div class=""col-12 grid-margin"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title"">Users Of The App</h4>
                    <div class=""table-responsive"">
                    
");
#nullable restore
#line 99 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                         if (Model.Count()>0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <table class=\"table\">\r\n                                <thead>\r\n                                    <tr>\r\n                                        <th>");
#nullable restore
#line 104 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                       Write(Html.DisplayNameFor(D => D.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 105 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                       Write(Html.DisplayNameFor(D => D.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 106 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                       Write(Html.DisplayNameFor(D => D.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                                        <th>");
#nullable restore
#line 107 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                       Write(Html.DisplayNameFor(D => D.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 111 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                     foreach (var User in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 114 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                           Write(Html.DisplayFor(S => @User.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 115 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                           Write(Html.DisplayFor(S => @User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td>");
#nullable restore
#line 116 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                           Write(Html.DisplayFor(S => @User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 117 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                           Write(Html.DisplayFor(S => @User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa9f759fcbd2e545e9b83976f05c0fa7e410b1d719149", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 118 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = User.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </tr>\r\n");
#nullable restore
#line 120 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
#nullable restore
#line 123 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                        } else  {
                          

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <div class=\"  mt-3 alert alert-warning\">\r\n                             <h4> There is No Users!</h4>\r\n                            </div>\r\n");
#nullable restore
#line 128 "D:\route\C#\ITI_Traning\SamarApp\Areas\Admin\Views\Admins\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                  </div>
                </div>
              </div>
            </div>


            <div class=""row"">
              <div class=""col-md-7 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title"">Project Status</h4>
                    <div class=""table-responsive"">
                      <table class=""table"">
                        <thead>
                          <tr>
                            <th> # </th>
                            <th> Name </th>
                            <th> Due Date </th>
                            <th> Progress </th>
                          </tr>
                        </thead>
                        <tbody>
                          <tr>
                            <td> 1 </td>
                            <td> Herman Beck </td>
                            <td> May 15, 2015 </td>
                            <td>
   ");
            WriteLiteral(@"                           <div class=""progress"">
                                <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                              </div>
                            </td>
                          </tr>
                          <tr>
                            <td> 2 </td>
                            <td> Messsy Adam </td>
                            <td> Jul 01, 2015 </td>
                            <td>
                              <div class=""progress"">
                                <div class=""progress-bar bg-gradient-danger"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                              </div>
                            </td>
                          </tr>
                          <tr>
                            <td> 3 </td>
                            <td> John Richards </td>
     ");
            WriteLiteral(@"                       <td> Apr 12, 2015 </td>
                            <td>
                              <div class=""progress"">
                                <div class=""progress-bar bg-gradient-warning"" role=""progressbar"" style=""width: 90%"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                              </div>
                            </td>
                          </tr>
                          <tr>
                            <td> 4 </td>
                            <td> Peter Meggik </td>
                            <td> May 15, 2015 </td>
                            <td>
                              <div class=""progress"">
                                <div class=""progress-bar bg-gradient-primary"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                              </div>
                            </td>
                          </tr>
                          <tr>
              ");
            WriteLiteral(@"              <td> 5 </td>
                            <td> Edward </td>
                            <td> May 03, 2015 </td>
                            <td>
                              <div class=""progress"">
                                <div class=""progress-bar bg-gradient-danger"" role=""progressbar"" style=""width: 35%"" aria-valuenow=""35"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                              </div>
                            </td>
                          </tr>
                          <tr>
                            <td> 5 </td>
                            <td> Ronald </td>
                            <td> Jun 05, 2015 </td>
                            <td>
                              <div class=""progress"">
                                <div class=""progress-bar bg-gradient-info"" role=""progressbar"" style=""width: 65%"" aria-valuenow=""65"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                              </div>
                            </td>
         ");
            WriteLiteral(@"                 </tr>
                        </tbody>
                      </table>
                    </div>
                  </div>
                </div>
              </div>
              <div class=""col-md-5 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title text-white"">Todo</h4>
                    <div class=""add-items d-flex"">
                      <input type=""text"" class=""form-control todo-list-input"" placeholder=""What do you need to do today?"">
                      <button class=""add btn btn-gradient-primary font-weight-bold todo-list-add-btn"" id=""add-task"">Add</button>
                    </div>
                    <div class=""list-wrapper"">
                      <ul class=""d-flex flex-column-reverse todo-list todo-list-custom"">
                        <li>
                          <div class=""form-check"">
                            <label class=""form-check-label"">
           ");
            WriteLiteral(@"                   <input class=""checkbox"" type=""checkbox""> Meeting with Alisa </label>
                          </div>
                          <i class=""remove mdi mdi-close-circle-outline""></i>
                        </li>
                        <li class=""completed"">
                          <div class=""form-check"">
                            <label class=""form-check-label"">
                              <input class=""checkbox"" type=""checkbox"" checked> Call John </label>
                          </div>
                          <i class=""remove mdi mdi-close-circle-outline""></i>
                        </li>
                        <li>
                          <div class=""form-check"">
                            <label class=""form-check-label"">
                              <input class=""checkbox"" type=""checkbox""> Create invoice </label>
                          </div>
                          <i class=""remove mdi mdi-close-circle-outline""></i>
                        </li>
  ");
            WriteLiteral(@"                      <li>
                          <div class=""form-check"">
                            <label class=""form-check-label"">
                              <input class=""checkbox"" type=""checkbox""> Print Statements </label>
                          </div>
                          <i class=""remove mdi mdi-close-circle-outline""></i>
                        </li>
                        <li class=""completed"">
                          <div class=""form-check"">
                            <label class=""form-check-label"">
                              <input class=""checkbox"" type=""checkbox"" checked> Prepare for presentation </label>
                          </div>
                          <i class=""remove mdi mdi-close-circle-outline""></i>
                        </li>
                        <li>
                          <div class=""form-check"">
                            <label class=""form-check-label"">
                              <input class=""checkbox"" type=""checkbox""> Pick ");
            WriteLiteral(@"up kids from school </label>
                          </div>
                          <i class=""remove mdi mdi-close-circle-outline""></i>
                        </li>
                      </ul>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
