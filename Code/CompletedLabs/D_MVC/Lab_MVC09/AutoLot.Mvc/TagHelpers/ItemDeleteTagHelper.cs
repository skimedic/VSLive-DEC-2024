// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Mvc - ItemDeleteTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemDeleteTagHelper : ItemLinkTagHelperBase
{
    public ItemDeleteTagHelper(
        IActionContextAccessor contextAccessor, 
        IUrlHelperFactory urlHelperFactory) 
        : base(contextAccessor, urlHelperFactory)
    {
        ActionName = nameof(CarsController.DeleteAsync).RemoveAsyncSuffix();
    }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        BuildContent(output,"text-danger","Delete","trash");
    }
}