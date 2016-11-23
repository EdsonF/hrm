﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.NPoco;
    using Frapid.WebsiteBuilder;
    using MixERP.HRM;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Setup/JobTitles/Index.cshtml")]
    public partial class _Views_Setup_JobTitles_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Setup_JobTitles_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Setup\JobTitles\Index.cshtml"
  
    ViewBag.Title = "Job Titles";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral(@"
<script>
	var scrudFactory = new Object();

    scrudFactory.title =  ""Job Titles"";

    scrudFactory.viewAPI = ""/api/forms/hrm/job-titles"";
    scrudFactory.viewTableName = ""hrm.job_titles"";

    scrudFactory.formAPI = ""/api/forms/hrm/job-titles"";
    scrudFactory.formTableName = ""hrm.job_titles"";

    scrudFactory.excludedColumns = [""AuditUserId"", ""AuditTs""];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
        {
            tab: """",
            fields: [
                [""JobTitleId""],
                [""JobTitleCode"", ""JobTitleName""],
                [""Description""]
            ]
        }
    ];

    scrudFactory.live = ""JobTitleName"";
    $.get('/ScrudFactory/View.html', function (view) {
        $.get('/ScrudFactory/Form.html', function (form) {
            $(""#ScrudFactoryView"").html(view);
            $(""#ScrudFactoryForm"").html(form);
            $.cachedScript(""/assets/js/scrudfactory-view.js"");
            $.cachedScript(""/assets/js/scrudfactory-form.js"");
        });
    });

    scrudFactory.card = {
        header: ""job_title_name"",
        description: ""job_title_code""
    };

</script>

<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>\r\n");

        }
    }
}
#pragma warning restore 1591
