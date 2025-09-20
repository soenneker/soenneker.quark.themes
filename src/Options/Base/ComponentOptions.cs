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
    public string Name { get; set; } = string.Empty;

    public CssValue<DisplayBuilder>? Display { get; set; }

    public CssValue<VisibilityBuilder>? Visibility { get; set; }

    public CssValue<FloatBuilder>? Float { get; set; }

    public CssValue<VerticalAlignBuilder>? VerticalAlign { get; set; }

    public CssValue<TextOverflowBuilder>? TextOverflow { get; set; }

    public CssValue<BoxShadowBuilder>? BoxShadow { get; set; }

    public CssValue<MarginBuilder>? Margin { get; set; }

    public CssValue<PaddingBuilder>? Padding { get; set; }

    public CssValue<PositionBuilder>? Position { get; set; }

    public CssValue<PositionOffsetBuilder>? Offset { get; set; }

    public CssValue<TextSizeBuilder>? TextSize { get; set; }

    public CssValue<WidthBuilder>? Width { get; set; }

    public CssValue<WidthBuilder>? MinWidth { get; set; }

    public CssValue<WidthBuilder>? MaxWidth { get; set; }

    public CssValue<HeightBuilder>? Height { get; set; }

    public CssValue<HeightBuilder>? MinHeight { get; set; }

    public CssValue<HeightBuilder>? MaxHeight { get; set; }

    public CssValue<OverflowBuilder>? Overflow { get; set; }

    public CssValue<OverflowBuilder>? OverflowX { get; set; }

    public CssValue<OverflowBuilder>? OverflowY { get; set; }

    public CssValue<ObjectFitBuilder>? ObjectFit { get; set; }

    public CssValue<TextAlignmentBuilder>? TextAlignment { get; set; }

    public CssValue<TextDecorationBuilder>? TextDecorationLine { get; set; }

    public CssValue<TextDecorationBuilder>? TextDecorationCss { get; set; }

    public CssValue<FlexBuilder>? Flex { get; set; }

    public CssValue<GapBuilder>? Gap { get; set; }

    public CssValue<BorderBuilder>? Border { get; set; }

    public CssValue<OpacityBuilder>? Opacity { get; set; }

    public CssValue<ZIndexBuilder>? ZIndex { get; set; }

    public CssValue<PointerEventsBuilder>? PointerEvents { get; set; }

    public CssValue<UserSelectBuilder>? UserSelect { get; set; }

    public CssValue<TextTransformBuilder>? TextTransform { get; set; }

    public CssValue<FontWeightBuilder>? FontWeight { get; set; }

    public CssValue<FontStyleBuilder>? FontStyle { get; set; }

    public CssValue<LineHeightBuilder>? LineHeight { get; set; }

    public CssValue<TextWrapBuilder>? TextWrap { get; set; }

    public CssValue<TextBreakBuilder>? TextBreak { get; set; }

    public CssValue<ColorBuilder>? TextColor { get; set; }

    public CssValue<ColorBuilder>? BackgroundColor { get; set; }

    public CssValue<ColorBuilder>? TextBackgroundColor { get; set; }
}