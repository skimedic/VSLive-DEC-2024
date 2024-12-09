// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - Details.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/28
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;
public class DetailsModel(IAppLogging<DetailsModel> appLogging, IMakeRepo makeRepo)
    : BasePageModel<Make, DetailsModel>(appLogging, makeRepo, "Details")
{
    public void OnGet(int? id) => GetOne(id);
}