﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc;

namespace RazorPagesWebSite;

public class ClientValidationDisabledController : Controller
{
    [HttpGet("/Controller/ClientValidationDisabled")]
    public IActionResult ValidationDisabled() => View();
}
