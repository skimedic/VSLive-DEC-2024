// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Mvc - ErrorViewModel.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Mvc.Models;

public class ErrorViewModel
{
    public string RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
