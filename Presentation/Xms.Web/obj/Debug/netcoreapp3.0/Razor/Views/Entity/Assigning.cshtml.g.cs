#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "119a4a830481fc88a600979ef72c3a03084f1046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entity_Assigning), @"mvc.1.0.view", @"/Views/Entity/Assigning.cshtml")]
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
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Infrastructure.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\projects\xms_v2\Presentation\Xms.Web\Views\_ViewImports.cshtml"
using Xms.Web.Framework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119a4a830481fc88a600979ef72c3a03084f1046", @"/Views/Entity/Assigning.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0011d9a8909cdacaf42363c4ba3a5683bc0ece", @"/Views/_ViewImports.cshtml")]
    public class Views_Entity_Assigning : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Models.AssignModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-jsonajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-istip", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- （Modal） -->
<div class=""modal fade"" id=""assignedModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""assignedModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""
                        aria-hidden=""true"">
                    ×
                </button>
                <h4 class=""modal-title"" id=""assignedModalLabel"">
                    <span class=""glyphicon glyphicon-user""></span> ");
#nullable restore
#line 16 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                                                              Write(app.T["assign"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <div class=\"row container-fluid\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "119a4a830481fc88a600979ef72c3a03084f10466614", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"entityid\"");
                BeginWriteAttribute("value", " value=\"", 997, "\"", 1020, 1);
#nullable restore
#line 22 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
WriteAttributeValue("", 1005, Model.EntityId, 1005, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"ownerid\"");
                BeginWriteAttribute("value", " value=\"", 1085, "\"", 1107, 1);
#nullable restore
#line 23 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
WriteAttributeValue("", 1093, Model.OwnerId, 1093, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 24 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                          
                            int i = 0;
                            foreach (var item in Model.ObjectId)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"hidden\" data-hiddendata=\"true\"");
                BeginWriteAttribute("name", " name=\"", 1353, "\"", 1372, 3);
                WriteAttributeValue("", 1360, "objectid[", 1360, 9, true);
#nullable restore
#line 28 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
WriteAttributeValue("", 1369, i, 1369, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1371, "]", 1371, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1373, "\"", 1386, 1);
#nullable restore
#line 28 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
WriteAttributeValue("", 1381, item, 1381, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 29 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                                i++;
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group col-sm-12\">\r\n                            <span class=\"glyphicon glyphicon-warning-sign\"></span>\r\n                            <span class=\"text-muted\">");
#nullable restore
#line 34 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                                                 Write(string.Format(app.T["security_assignrecords_tip"], Model.ObjectId.Length, Model.EntityMetaData.LocalizedName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            <label><input type=\"radio\" name=\"owneridtype\" value=\"1\" checked /> ");
#nullable restore
#line 37 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                                                                                          Write(app.T["assign_tome"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"form-group col-sm-12\">\r\n                            <label><input type=\"radio\" name=\"owneridtype\" value=\"2\" /> ");
#nullable restore
#line 40 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                                                                                  Write(app.T["assign_toother"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            <div class=""owner_selector hide"">
                                <input type=""text"" id=""ownerid"" name=""ownerid_text"" class=""form-control input-sm lookup"" />
                            </div>
                        </div>
                        <div class=""form-group col-sm-12"">
                            <label><input type=""radio"" name=""owneridtype"" value=""3"" /> ");
#nullable restore
#line 46 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                                                                                  Write(app.T["assign_toteam"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            <div class=""team_selector hide"">
                                <input type=""text"" id=""teamid"" name=""teamid_text"" class=""form-control input-sm lookup"" />
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 873, "/", 873, 1, true);
#nullable restore
#line 21 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
AddHtmlAttributeValue("", 874, app.OrganizationUniqueName, 874, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 903, "/api/data/assign", 903, 16, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <script");
            BeginWriteAttribute("src", " src=\"", 3002, "\"", 3072, 2);
            WriteAttributeValue("", 3008, "/content/js/jquery.form.js?v=", 3008, 29, true);
#nullable restore
#line 53 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
WriteAttributeValue("", 3037, app.PlatformSettings.VersionNumber, 3037, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n                <script>\r\n                    var AssignedModel = {\r\n                        dialog: $(\'#assignedModal\'),\r\n                        dialogid: \'assignedModal\',\r\n                        entityid: \'");
#nullable restore
#line 58 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                              Write(Model.EntityId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                        objectid: \'");
#nullable restore
#line 59 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                              Write(Model.ObjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                        ownerid: \'");
#nullable restore
#line 60 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
                             Write(Model.OwnerId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        singlemode: true,
                        initForm: function () {
                            var $form = AssignedModel.dialog.find('form');
                            Xms.Web.Form($form, function (response) {
                                console.log(response);
                                if (response.IsSuccess == false) {
                                    AssignedModel.resetForm();
                                } else {
                                    AssignedModel.dialog.modal('hide');
                                }
                            });
                        },
                        submit: function () {
                            AssignedModel.disabledForm();
                            var $form = AssignedModel.dialog.find('form');
                            $form.submit();
                        },
                        dialog_return: function () {
                            AssignedModel.dialog.modal('hide');
        ");
            WriteLiteral(@"                },
                        disabledForm: function () {
                            AssignedModel.dialog.find('button').prop('disabled', true);
                        },
                        resetForm: function () {
                            AssignedModel.dialog.find('button').prop('disabled', false);
                        },
                        bindselected: function (result, inputid) {
                            console.log(result);
                            if (!result || result.length == 0) return;
                            AssignedModel.dialog.find('#' + inputid).val(result[0].name);
                            AssignedModel.dialog.find('input[name=ownerid]').val(result[0].id);
                            var target = [];
                            $(result).each(function (i, n) {
                                target.push(n.id);
                            });
                            console.log(target);
                        }
                  ");
            WriteLiteral(@"  };
                    $(function () {
                        AssignedModel.initForm();
                        AssignedModel.dialog.modal({
                            //backdrop: 'static'
                        });
                        AssignedModel.dialog.on('hidden.bs.modal', function () {
                            Xms.Web.CloseDialog(AssignedModel.dialogid);
                        });
                        AssignedModel.dialog.find('input[name=owneridtype]').on('click', null, function (e) {
                            var type = $(e.target).val();
                            if (type == 1) {
                                $('.owner_selector').addClass('hide');
                                $('.team_selector').addClass('hide');
                            }
                            else if (type == 2) {
                                $('.owner_selector').removeClass('hide');
                                $('.team_selector').addClass('hide');
                         ");
            WriteLiteral(@"   }
                            else if (type == 3) {
                                $('.owner_selector').addClass('hide');
                                $('.team_selector').removeClass('hide');
                            }
                        });
                        AssignedModel.dialog.find('#ownerid').lookup({
                            dialog: function () { Xms.Web.OpenDialog('/entity/RecordsDialog?entityname=systemuser&singlemode=true&inputid=ownerid', 'AssignedModel.bindselected'); }
                        , clear: function () {
                            $('#' + inputid).val('');
                            $('#' + valueid).val('');
                            return false;
                        }
                        });
                        AssignedModel.dialog.find('#teamid').lookup({
                            dialog: function () { Xms.Web.OpenDialog('/entity/RecordsDialog?entityname=team&singlemode=true&inputid=teamid', 'AssignedModel.bindselected'); }
    ");
            WriteLiteral(@"                    , clear: function () {
                            $('#' + inputid).val('');
                            $('#' + valueid).val('');
                            return false;
                        }
                        });
                        AssignedModel.dialog.find('form').ajaxForm(function (response) {
                            if (response.IsSuccess) {
                                Xms.Web.Alert(true, response.Content);
                                AssignedModel.dialog_return();
                                AssignedModel.resetForm();
                                Xms.Web.Event.publish('refresh');
                                location.reload(true);
                                return;
                            }
                            Xms.Web.Alert(false, response.Content);
                            AssignedModel.resetForm();
                        });
                    });
                </script>
            </div>
         ");
            WriteLiteral("   <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-default\"\r\n                        data-dismiss=\"modal\">\r\n                    <span class=\"glyphicon glyphicon-remove\"></span>\r\n                    ");
#nullable restore
#line 157 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
               Write(app.T["dialog_close"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                <button type=\"button\" class=\"btn btn-primary\" onclick=\"AssignedModel.submit()\">\r\n                    <span class=\"glyphicon glyphicon-ok\"></span>\r\n                    ");
#nullable restore
#line 161 "G:\projects\xms_v2\Presentation\Xms.Web\Views\Entity\Assigning.cshtml"
               Write(app.T["dialog_ok"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n        </div><!-- /.modal-content -->\r\n    </div><!-- /.modal-dialog -->\r\n</div><!-- /.modal -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Xms.Web.Framework.Context.IWebAppContext app { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Models.AssignModel> Html { get; private set; }
    }
}
#pragma warning restore 1591