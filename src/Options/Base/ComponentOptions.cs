using Microsoft.AspNetCore.Components;
using Soenneker.Quark.Components.Builders;
using Soenneker.Quark.Components.Builders.Borders;
using Soenneker.Quark.Components.Builders.BoxShadows;
using Soenneker.Quark.Components.Builders.Colors;
using Soenneker.Quark.Components.Builders.Displays;
using Soenneker.Quark.Components.Builders.Flexes;
using Soenneker.Quark.Components.Builders.Floats;
using Soenneker.Quark.Components.Builders.FontStyles;
using Soenneker.Quark.Components.Builders.FontWeights;
using Soenneker.Quark.Components.Builders.Gaps;
using Soenneker.Quark.Components.Builders.Heights;
using Soenneker.Quark.Components.Builders.LineHeights;
using Soenneker.Quark.Components.Builders.Margins;
using Soenneker.Quark.Components.Builders.ObjectFits;
using Soenneker.Quark.Components.Builders.Opacities;
using Soenneker.Quark.Components.Builders.Overflows;
using Soenneker.Quark.Components.Builders.Paddings;
using Soenneker.Quark.Components.Builders.PointerEventss;
using Soenneker.Quark.Components.Builders.PositionOffsets;
using Soenneker.Quark.Components.Builders.Positions;
using Soenneker.Quark.Components.Builders.TextAlignments;
using Soenneker.Quark.Components.Builders.TextBreaks;
using Soenneker.Quark.Components.Builders.TextDecorations;
using Soenneker.Quark.Components.Builders.TextOverflows;
using Soenneker.Quark.Components.Builders.TextSizes;
using Soenneker.Quark.Components.Builders.TextTransforms;
using Soenneker.Quark.Components.Builders.TextWraps;
using Soenneker.Quark.Components.Builders.UserSelects;
using Soenneker.Quark.Components.Builders.VerticalAligns;
using Soenneker.Quark.Components.Builders.Visibilities;
using Soenneker.Quark.Components.Builders.Widths;
using Soenneker.Quark.Components.Builders.ZIndexes;

namespace Soenneker.Quark.Themes.Options.Base;

public class ComponentOptions
{
    [Parameter]
    public string Name { get; set; } = string.Empty;

    [Parameter]
    public CssValue<DisplayBuilder>? Display { get; set; }

    [Parameter]
    public CssValue<VisibilityBuilder>? Visibility { get; set; }

    [Parameter]
    public CssValue<FloatBuilder>? Float { get; set; }

    [Parameter]
    public CssValue<VerticalAlignBuilder>? VerticalAlign { get; set; }

    [Parameter]
    public CssValue<TextOverflowBuilder>? TextOverflow { get; set; }

    [Parameter]
    public CssValue<BoxShadowBuilder>? BoxShadow { get; set; }

    [Parameter]
    public CssValue<MarginBuilder>? Margin { get; set; }

    [Parameter]
    public CssValue<PaddingBuilder>? Padding { get; set; }

    [Parameter]
    public CssValue<PositionBuilder>? Position { get; set; }

    [Parameter]
    public CssValue<PositionOffsetBuilder>? Offset { get; set; }

    [Parameter]
    public CssValue<TextSizeBuilder>? TextSize { get; set; }

    [Parameter]
    public CssValue<WidthBuilder>? Width { get; set; }

    [Parameter]
    public CssValue<WidthBuilder>? MinWidth { get; set; }

    [Parameter]
    public CssValue<WidthBuilder>? MaxWidth { get; set; }

    [Parameter]
    public CssValue<HeightBuilder>? Height { get; set; }

    [Parameter]
    public CssValue<HeightBuilder>? MinHeight { get; set; }

    [Parameter]
    public CssValue<HeightBuilder>? MaxHeight { get; set; }

    [Parameter]
    public CssValue<OverflowBuilder>? Overflow { get; set; }

    [Parameter]
    public CssValue<OverflowBuilder>? OverflowX { get; set; }

    [Parameter]
    public CssValue<OverflowBuilder>? OverflowY { get; set; }

    [Parameter]
    public CssValue<ObjectFitBuilder>? ObjectFit { get; set; }

    [Parameter]
    public CssValue<TextAlignmentBuilder>? TextAlignment { get; set; }

    [Parameter]
    public CssValue<TextDecorationBuilder>? TextDecorationLine { get; set; }

    [Parameter]
    public CssValue<TextDecorationBuilder>? TextDecorationCss { get; set; }

    [Parameter]
    public CssValue<FlexBuilder>? Flex { get; set; }

    [Parameter]
    public CssValue<GapBuilder>? Gap { get; set; }

    [Parameter]
    public CssValue<BorderBuilder>? Border { get; set; }

    [Parameter]
    public CssValue<OpacityBuilder>? Opacity { get; set; }

    [Parameter]
    public CssValue<ZIndexBuilder>? ZIndex { get; set; }

    [Parameter]
    public CssValue<PointerEventsBuilder>? PointerEvents { get; set; }

    [Parameter]
    public CssValue<UserSelectBuilder>? UserSelect { get; set; }

    [Parameter]
    public CssValue<TextTransformBuilder>? TextTransform { get; set; }

    [Parameter]
    public CssValue<FontWeightBuilder>? FontWeight { get; set; }

    [Parameter]
    public CssValue<FontStyleBuilder>? FontStyle { get; set; }

    [Parameter]
    public CssValue<LineHeightBuilder>? LineHeight { get; set; }

    [Parameter]
    public CssValue<TextWrapBuilder>? TextWrap { get; set; }

    [Parameter]
    public CssValue<TextBreakBuilder>? TextBreak { get; set; }

    [Parameter]
    public CssValue<ColorBuilder>? TextColor { get; set; }

    [Parameter]
    public CssValue<ColorBuilder>? BackgroundColor { get; set; }

    [Parameter]
    public CssValue<ColorBuilder>? TextBackgroundColor { get; set; }
}