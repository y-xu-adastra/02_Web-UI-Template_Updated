#pragma checksum "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f52ffc61d0d083550ab271d75819141021e44eeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\_ViewImports.cshtml"
using CognitiveSearch.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\_ViewImports.cshtml"
using CognitiveSearch.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52ffc61d0d083550ab271d75819141021e44eeb", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37ea4e4196ffd63b0571e2d033e7f9c9b3dfa642", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CognitiveSearch.UI.Models.SearchResultViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Copyright (c) Microsoft Corporation. All rights reserved.\n     Licensed under the MIT License. -->\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search Results";
    ViewData["Path"] = "Home / Search Results";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Pass controller data to view -->\n<script>\n    aspViewModel = ");
#nullable restore
#line 12 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
              Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    q = ");
#nullable restore
#line 13 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
   Write(Html.Raw(Json.Serialize(Model.query)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    searchId = ");
#nullable restore
#line 14 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
          Write(Html.Raw(Json.Serialize((Model.searchId))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    applicationInstrumentationKey = ");
#nullable restore
#line 15 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
                               Write(Html.Raw(Json.Serialize(Model.applicationInstrumentationKey)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    searchServiceName = ");
#nullable restore
#line 16 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
                   Write(Html.Raw(Json.Serialize(Model.searchServiceName)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    indexName = ");
#nullable restore
#line 17 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
           Write(Html.Raw(Json.Serialize(Model.indexName)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    semanticEnabled = ");
#nullable restore
#line 18 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.semanticEnabled)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n</script>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f52ffc61d0d083550ab271d75819141021e44eeb6785", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!--Details Modal-->
<div class=""modal"" id=""details-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div id=""details-modal-body"" class=""modal-body"">
                <div class=""row"" style=""height: 100%;"">
                    <div class=""modal-control-group"">
                        <span id=""close-control"" class=""modal-control"" data-dismiss=""modal""><i class=""ms-Icon ms-Icon--Clear""></i></span>
                    </div>
                    <div id=""details-pivot"" class=""ms-Pivot col-md-8"">
                        <ul id=""details-pivot-links"" class=""ms-Pivot-links""></ul>
                        <div id=""details-pivot-content"">
                        </div>
                    </div>
                    <div id=""tags-panel"" class=""col-md-4"">
                        <div id=""transcript-search-box"" class=""ms-SearchBox"">
                            <input class=""ms-SearchBox-field"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 1871, "\"", 1879, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""transcript-search-input"" placeholder=""Search..."">
                            <label class=""ms-SearchBox-label"">
                                <i class=""ms-SearchBox-icon ms-Icon ms-Icon--Search""></i>
                            </label>
                            <div class=""ms-CommandButton ms-SearchBox-clear ms-CommandButton--noLabel"">
                                <button class=""ms-CommandButton-button"">
                                    <span class=""ms-CommandButton-icon""><i class=""ms-Icon ms-Icon--Clear""></i></span>
                                    <span class=""ms-CommandButton-label""></span>
                                </button>
                            </div>
                        </div>
                        <div id=""details-viewer"" style=""display:none""></div>
                        <div id=""tag-viewer""></div>
                        <hr />
                        <div id=""reference-viewer""></div>
                    </div>
                    <input id=""result-id"" type=""hi");
            WriteLiteral(@"dden"" />
                </div>
            </div>
        </div>
    </div>
</div>

<!--Search, Filters, and Facets-->
<div id=""results-container"" class=""row content-results"">
    <div class=""col-md-2"">
        <div id=""search-input-group"" class=""input-group"">
            <input type=""text"" class=""form-control advancedAutoComplete"" name=""q"" id=""q"" placeholder=""Search..."" autocomplete=""off"">
            <span class=""input-group-btn"">
                <button id=""search-button"" class=""btn btn-default"" onclick=""Search();""><span class=""ms-Icon ms-Icon--Search""></span></button>
            </span>
        </div>
        <div class=""input-group""");
            BeginWriteAttribute("style", " style=\"", 3551, "\"", 3614, 1);
#nullable restore
#line 70 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
WriteAttributeValue("", 3559, Model.semanticEnabled?"display:block":"display:none", 3559, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            Semantic Search
            <label class=""switch""> <input name=""queryType"" id=""semantic-toogle"" type=""checkbox""><span class=""slider round""></span> </label>
        </div>
        <br />
        <br />
        <button style=""width:100%"" class=""btn btn-default"" onclick=""EntityMapClick()"">View Entity Map</button>
        <br />
        <br />
        <div>
            <div id=""filterReset""></div>
            <div class=""widget-content"">
                <div id=""facet-nav"" class=""facet-nav""></div>
            </div>
        </div>
    </div>

    <!--Results-->
    <div class=""col-md-10"">
        <div style=""margin:0 10px 10px 10px;"">
            <h2 id=""query-div"" style=""margin-top:-10px; font-size:14px;"" class=""alert info""></h2>
            <h2 id=""answer-div"" style=""margin-top:-10px; font-size:14px;"" class=""alert info""></h2>
            <h2 id=""doc-count"" style=""margin-top:-10px; font-size:14px; display:inline""></h2>
            <div id=""maps-viewer""></div>
            <div style=""display:inline;");
            WriteLiteral(@"position: relative;top:-10px;left:10px;"">
                <span id=""loading-indicator"" class=""ms-Spinner ms-Spinner--large"" style=""display:none;""></span>
            </div>
        </div>
        <div id=""doc-details-div"">
        </div>
        <div class=""clearfix"">
            <ul id=""paginationFooter"" class=""pagination pull-right""></ul>
        </div>
    </div>
</div>

<div id=""entity-map"" style=""display:none"">
    <div id=""results-container"" class=""row content-results"">
        <div class=""col-md-2"">
            <div id=""search-input-group"" class=""input-group"">
                <input type=""text"" class=""form-control"" name=""e"" id=""e"" placeholder=""Search..."">
                <span class=""input-group-btn"">
                    <button class=""btn btn-default"" onclick=""SearchEntities();""><span class=""ms-Icon ms-Icon--Search""></span></button>
                </span>

                <div style=""display:inline;position: relative;top:-10px;left:10px;"">
                    <span id=""entity-loading-indicator"" class");
            WriteLiteral(@"=""ms-Spinner ms-Spinner--large"" style=""display:none;""></span>
                </div>
            </div>

            <br />
            <button style=""width:100%"" class=""btn btn-default"" onclick=""EntityMapClick()"">Return to Search Results</button>
        </div>
        <div class=""col-md-5""></div>
        <div class=""col-md-2"">
            <label for=""slider-currentMaxNodes"">Max Levels</label>
            <label id=""lbl-currentMaxLevels"" style=""float:right"">0</label>
            <input type=""range"" class=""custom-range"" min=""1"" max=""5"" id=""slider-currentMaxLevels"" oninput=""changeMaxLevels(this.value, false)"" onchange=""changeMaxLevels(this.value, true)"">
        </div>
        <div class=""col-md-2"">
            <label for=""slider-currentMaxNodes"">Max Nodes</label>
            <label id=""lbl-currentMaxNodes"" style=""float:right"">0</label>
            <input type=""range"" class=""custom-range"" min=""3"" max=""30"" id=""slider-currentMaxNodes"" oninput=""changeMaxNodes(this.value, false)"" onchange=""changeMaxNodes(this.valu");
            WriteLiteral(@"e, true)"">
        </div>
        <div class=""col-md-1"">
            <button class=""btn btn-default dropdown-toggle"" type=""button""
                    id=""dropdownMenu1"" data-toggle=""dropdown""
                    aria-haspopup=""true"" aria-expanded=""true""
                    float=""right"">
                <strong>Select Facets</strong>
                <span class=""caret""></span>
            </button>

            <ul class=""dropdown-menu checkbox-menu allow-focus dropdown-graphfields"">
");
#nullable restore
#line 144 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
                 foreach (var f in Model.facetableFields)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\n                        <label>\n                            <input");
            BeginWriteAttribute("value", " value=\"", 7344, "\"", 7354, 1);
#nullable restore
#line 148 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
WriteAttributeValue("", 7352, f, 7352, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\"> ");
#nullable restore
#line 148 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
                                                          Write(f);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </label>\n                    </li>\n");
#nullable restore
#line 151 "C:\Users\yuanyuan.xu\Documents\Azure Projects\Frontend\02 - Web UI Template\CognitiveSearch.UI\Views\Home\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n        <div class=\"col-md-10\">\n            <svg height=\"600px\"></svg>\n        </div>\n    </div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CognitiveSearch.UI.Models.SearchResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
