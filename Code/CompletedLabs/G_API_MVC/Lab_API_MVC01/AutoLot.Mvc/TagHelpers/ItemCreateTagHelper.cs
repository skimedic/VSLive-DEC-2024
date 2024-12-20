﻿// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Mvc - ItemCreateTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/06/30
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemCreateTagHelper : ItemLinkTagHelperBase
{
    public ItemCreateTagHelper(
        IActionContextAccessor contextAccessor,
        IUrlHelperFactory urlHelperFactory)
        : base(contextAccessor, urlHelperFactory)
    {
        ActionName = nameof(CarsController.CreateAsync).RemoveAsyncSuffix();
    }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        BuildContent(output, "text-success", "Create New", "plus");
    }
}