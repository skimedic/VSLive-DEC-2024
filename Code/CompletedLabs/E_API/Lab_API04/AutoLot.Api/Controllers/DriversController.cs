// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Api - DriversController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/06/29
// ==================================

namespace AutoLot.Api.Controllers;

[ApiVersion(1.0)]
public class DriversController(IAppLogging<DriversController> logger, IDriverRepo repo)
    : BaseCrudController<Driver, DriversController>(logger, repo);