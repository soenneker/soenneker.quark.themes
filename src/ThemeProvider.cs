using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Quark.Themes.Abstract;
using Soenneker.Quark.Themes.Options.Base;
using Soenneker.Quark.Variables.Bootstrap;
using Soenneker.Quark.Variables.Bootstrap.Utils;

namespace Soenneker.Quark.Themes;

///<inheritdoc cref="IThemeProvider"/>
public class ThemeProvider : IThemeProvider
{
    public string? CurrentTheme { get; set; }

    // Core Bootstrap CSS Variables
    public BootstrapColorsCssVariables? BootstrapColorsCssVariables { get; set; }
    public BootstrapTypographyCssVariables? BootstrapTypographyCssVariables { get; set; }
    public BootstrapSpacingCssVariables? BootstrapSpacingCssVariables { get; set; }
    public BootstrapBordersCssVariables? BootstrapBordersCssVariables { get; set; }
    public BootstrapShadowsCssVariables? BootstrapShadowsCssVariables { get; set; }
    public BootstrapButtonsCssVariables? BootstrapButtonsCssVariables { get; set; }

    // Component Bootstrap CSS Variables
    public BootstrapCardsCssVariables? BootstrapCardsCssVariables { get; set; }
    public BootstrapAlertsCssVariables? BootstrapAlertsCssVariables { get; set; }
    public BootstrapBadgesCssVariables? BootstrapBadgesCssVariables { get; set; }
    public BootstrapModalsCssVariables? BootstrapModalsCssVariables { get; set; }
    public BootstrapNavigationCssVariables? BootstrapNavigationCssVariables { get; set; }
    public BootstrapFormsCssVariables? BootstrapFormsCssVariables { get; set; }

    // Additional Component Bootstrap CSS Variables
    public BootstrapListGroupsCssVariables? BootstrapListGroupsCssVariables { get; set; }
    public BootstrapProgressCssVariables? BootstrapProgressCssVariables { get; set; }
    public BootstrapCloseButtonsCssVariables? BootstrapCloseButtonsCssVariables { get; set; }
    public BootstrapOffcanvasCssVariables? BootstrapOffcanvasCssVariables { get; set; }
    public BootstrapCarouselCssVariables? BootstrapCarouselCssVariables { get; set; }
    public BootstrapAccordionCssVariables? BootstrapAccordionCssVariables { get; set; }
    public BootstrapGeneralCssVariables? BootstrapGeneralCssVariables { get; set; }

    public Dictionary<string, Theme>? Themes { get; set; }

    public Dictionary<string, Func<Theme, ComponentOptions?>> ComponentOptions { get; set; } = new()
    {
        ["Alert"] = theme => theme.Alerts,
        ["Anchor"] = theme => theme.Anchors,
        ["Badge"] = theme => theme.Badges,
        ["Bar"] = theme => theme.Bars,
        ["Breadcrumb"] = theme => theme.Breadcrumbs,
        ["Button"] = theme => theme.Buttons,
        ["Card"] = theme => theme.Cards,
        ["Check"] = theme => theme.Checks,
        ["Code"] = theme => theme.Codes,
        ["Column"] = theme => theme.Columns,
        ["Container"] = theme => theme.Containers,
        ["Datepicker"] = theme => theme.Datepickers,
        ["Div"] = theme => theme.Divs,
        ["Field"] = theme => theme.Fields,
        ["Heading"] = theme => theme.Headings,
        ["Icon"] = theme => theme.Icons,
        ["Image"] = theme => theme.Images,
        ["Label"] = theme => theme.Labels,
        ["Layout"] = theme => theme.Layouts,
        ["ListItem"] = theme => theme.ListItems,
        ["MemoEdit"] = theme => theme.MemoEdits,
        ["Modal"] = theme => theme.Modals,
        ["Nav"] = theme => theme.Navs,
        ["NumericEdit"] = theme => theme.NumericEdits,
        ["Offcanvas"] = theme => theme.Offcanvases,
        ["OrderedList"] = theme => theme.OrderedLists,
        ["Pagination"] = theme => theme.Paginations,
        ["Paragraph"] = theme => theme.Paragraphs,
        ["Progress"] = theme => theme.Progresses,
        ["Radio"] = theme => theme.Radios,
        ["Row"] = theme => theme.Rows,
        ["Section"] = theme => theme.Sections,
        ["Slider"] = theme => theme.Sliders,
        ["Snackbar"] = theme => theme.Snackbars,
        ["Span"] = theme => theme.Spans,
        ["Step"] = theme => theme.Steps,
        ["Strong"] = theme => theme.Strongs,
        ["Switch"] = theme => theme.Switches,
        ["Table"] = theme => theme.Tables,
        ["Tab"] = theme => theme.Tabs,
        ["TextEdit"] = theme => theme.TextEdits,
        ["Text"] = theme => theme.Texts,
        ["UnorderedList"] = theme => theme.UnorderedLists
    };

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string GenerateRootCss()
    {
        var objects = new object?[]
        {
            // Core
            BootstrapColorsCssVariables,
            BootstrapTypographyCssVariables,
            BootstrapSpacingCssVariables,
            BootstrapBordersCssVariables,
            BootstrapShadowsCssVariables,
            BootstrapButtonsCssVariables,

            // Components
            BootstrapCardsCssVariables,
            BootstrapAlertsCssVariables,
            BootstrapBadgesCssVariables,
            BootstrapModalsCssVariables,
            BootstrapNavigationCssVariables,
            BootstrapFormsCssVariables,

            // Additional
            BootstrapListGroupsCssVariables,
            BootstrapProgressCssVariables,
            BootstrapCloseButtonsCssVariables,
            BootstrapOffcanvasCssVariables,
            BootstrapCarouselCssVariables,
            BootstrapAccordionCssVariables,
            BootstrapGeneralCssVariables
        };

        return BootstrapCssGenerator.GenerateRootCss(objects);
    }
}