using System.Collections.Generic;

namespace Stylesheet.NET
{
    internal static class BrowserSupport
    {
        public static bool IsMoz(string property)
        {
            return Moz.Contains(property, true);
        }
        public static bool IsWebKit(string property)
        {
            return WebKit.Contains(property, true);
        }

        //Mozilla Firefox
        static List<string> Moz = new List<string>()
        {
            "Animation",
            "AnimationDelay",
            "AnimationDirection",
            "AnimationDuration",
            "AnimationFillMode",
            "AnimationIterationCount",
            "AnimationName",
            "AnimationPlayState",
            "AnimationTimingFunction",
            "BackfaceVisibility",
            "BackgroundSize",
            "BorderBottomLeftRadius",
            "BorderBottomRightRadius",
            "BorderImage",
            "BorderRadius",
            "BorderTopLeftRadius",
            "BorderTopRightRadius",
            "BoxShadow",
            "BoxSizing",
            "ColumnCount",
            "ColumnFill",
            "ColumnGap",
            "ColumnRule",
            "ColumnRuleColor",
            "ColumnRuleStyle",
            "ColumnRuleWidth",
            "ColumnWidth",
            "Columns",
            "Flex",
            "FlexBasis",
            "FlexDirection",
            "FlexFlow",
            "FlexGrow",
            "FlexShrink",
            "FlexWrap",
            "JustifyContent",
            "Order",
            "Perspective",
            "PerspectiveOrigin",
            "Resize",
            "TabSize",
            "TextAlignLast",
            "TextDecorationColor",
            "TextDecorationLine",
            "TextDecorationStyle",
            "Transform",
            "TransformOrigin",
            "TransformStyle",
            "Transition",
            "TransitionDelay",
            "TransitionDuration",
            "TransitionProperty",
            "TransitionTimingFunction",
            "UserSelect",

        };

        //Chrome, Opera, Safari,iOS, Android
        static List<string> WebKit = new List<string>()
        {
            "AlignContent",
            "AlignItems",
            "AlignSelf",
            "Animation",
            "AnimationDelay",
            "AnimationDirection",
            "AnimationDuration",
            "AnimationFillMode",
            "AnimationIterationCount",
            "AnimationName",
            "AnimationPlayState",
            "AnimationTimingFunction",
            "BackfaceVisibility",
            "BackgroundSize",
            "BorderBottomLeftRadius",
            "BorderBottomRightRadius",
            "BorderImage",
            "BorderRadius",
            "BorderTopLeftRadius",
            "BorderTopRightRadius",
            "BoxDecorationBreak",
            "BoxShadow",
            "BoxSizing",
            "ColumnCount",
            "ColumnFill",
            "ColumnGap",
            "ColumnRule",
            "ColumnRuleColor",
            "ColumnRuleStyle",
            "ColumnRuleWidth",
            "ColumnSpan",
            "ColumnWidth",
            "Columns",
            "Filter",
            "Flex",
            "FlexBasis",
            "FlexDirection",
            "FlexFlow",
            "FlexGrow",
            "FlexShrink",
            "FlexWrap",
            "FontKerning",
            "Hyphens",
            "JustifyContent",
            "Order",
            "Perspective",
            "PerspectiveOrigin",
            "TextDecorationColor",
            "TextDecorationLine",
            "Transform",
            "TransformOrigin",
            "TransformStyle",
            "Transition",
            "TransitionDelay",
            "TransitionDuration",
            "TransitionProperty",
            "TransitionTimingFunction",
            "UserSelect",

        };
    }
}
