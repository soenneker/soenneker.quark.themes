using System;
using System.Collections.Generic;

namespace Soenneker.Quark;

public interface IThemeProvider
{
    string? CurrentTheme { get; set; }

    // Core Bootstrap CSS Variables
    BootstrapColorsCssVariables? BootstrapColorsCssVariables { get; set; }
    BootstrapTypographyCssVariables? BootstrapTypographyCssVariables { get; set; }
    BootstrapSpacingCssVariables? BootstrapSpacingCssVariables { get; set; }
    BootstrapBordersCssVariables? BootstrapBordersCssVariables { get; set; }
    BootstrapShadowsCssVariables? BootstrapShadowsCssVariables { get; set; }
    BootstrapButtonsCssVariables? BootstrapButtonsCssVariables { get; set; }

    // Component Bootstrap CSS Variables
    BootstrapCardsCssVariables? BootstrapCardsCssVariables { get; set; }
    BootstrapAlertsCssVariables? BootstrapAlertsCssVariables { get; set; }
    BootstrapBadgesCssVariables? BootstrapBadgesCssVariables { get; set; }
    BootstrapModalsCssVariables? BootstrapModalsCssVariables { get; set; }
    BootstrapNavigationCssVariables? BootstrapNavigationCssVariables { get; set; }
    BootstrapFormsCssVariables? BootstrapFormsCssVariables { get; set; }

    // Additional Component Bootstrap CSS Variables
    BootstrapListGroupsCssVariables? BootstrapListGroupsCssVariables { get; set; }
    BootstrapProgressCssVariables? BootstrapProgressCssVariables { get; set; }
    BootstrapCloseButtonsCssVariables? BootstrapCloseButtonsCssVariables { get; set; }
    BootstrapOffcanvasCssVariables? BootstrapOffcanvasCssVariables { get; set; }
    BootstrapCarouselCssVariables? BootstrapCarouselCssVariables { get; set; }
    BootstrapAccordionCssVariables? BootstrapAccordionCssVariables { get; set; }
    BootstrapGeneralCssVariables? BootstrapGeneralCssVariables { get; set; }

    Dictionary<string, Theme>? Themes { get; set; }

    Dictionary<string, Func<Theme, ComponentOptions?>> ComponentOptions { get; set; }

    string GenerateRootCss();
}
