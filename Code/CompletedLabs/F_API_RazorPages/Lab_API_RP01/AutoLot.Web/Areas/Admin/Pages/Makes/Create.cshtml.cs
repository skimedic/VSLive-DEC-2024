// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - Create.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;
public class CreateModel(IAppLogging<CreateModel> appLogging, IMakeDataService dataService)
    : BasePageModel<Make, CreateModel>(appLogging, dataService, "Create")
{
    public void OnGet() => Entity = new Make();
    public async Task<IActionResult> OnPostAsync() => await SaveOneAsync(MainDataService.AddAsync);
}