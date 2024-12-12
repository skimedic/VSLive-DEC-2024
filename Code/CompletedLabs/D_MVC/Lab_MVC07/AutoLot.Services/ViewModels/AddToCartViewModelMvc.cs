// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Services - AddToCartViewModelMvc.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Services.ViewModels;

public class AddToCartViewModelMvc : AddToCartViewModelBase
{
    [Required]
    [MustBeGreaterThanZero]
    [MustNotBeGreaterThan(nameof(StockQuantity))]
    public int Quantity { get; set; }
}