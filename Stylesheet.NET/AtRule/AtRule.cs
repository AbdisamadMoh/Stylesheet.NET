
using System;
using System.Collections.Generic;


namespace StylesheetNET
{
    /// <summary>
    /// AtRule query builder.
    /// <br/>
    /// example: 
    /// <br/>
    /// new AtRule().Screen.and.MaxWidth("480px")
    /// </summary>
    public class AtRule
    {
        //reference https://www.w3.org/TR/CSS21/media.html%23media-types
        #region fields

        readonly List<MQuery> _Queries = new List<MQuery>();

        #endregion

        #region Methods/Overrides
        public static implicit operator string(AtRule mediaRule)
        {
            return mediaRule.ToString();
        }

        /// <summary>
        /// Returns CSS as a srting of the current object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GetCondition();
        }
        private string GetCondition()
        {
            var l = new List<string>();
            foreach (var q in _Queries)
            {
                l.Add(q.Value);
            }
            return string.Join(" ", l.ToArray());
        }
        #endregion

        #region Media Types

        /// <summary>
        /// Used for all media type devices
        /// </summary>
        public AtRule All
        {
            get
            {
                _Queries.Add(new MQuery("all", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// Intended for speech synthesizers.
        /// </summary>
        public AtRule Aural
        {
            get
            {
                _Queries.Add(new MQuery("aural", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// Intended for braille tactile feedback devices.
        /// </summary>
        public AtRule Braille
        {
            get
            {
                _Queries.Add(new MQuery("braille", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// Intended for paged braille printers.
        /// </summary>
        public AtRule Embossed
        {
            get
            {
                _Queries.Add(new MQuery("embossed", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// Intended for handheld devices (typically small screen, monochrome, limited bandwidth).
        /// </summary>
        public AtRule Handheld
        {
            get
            {
                _Queries.Add(new MQuery("handheld", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// Intended for paged, opaque material and for documents viewed on screen in print preview mode.
        /// </summary>
        public AtRule Print
        {
            get
            {
                _Queries.Add(new MQuery("print", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// Intended for projected presentations, for example projectors or print to transparencies.
        /// </summary>
        public AtRule Projection
        {
            get
            {
                _Queries.Add(new MQuery("projection", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// Intended primarily for color computer screens.
        /// </summary>
        public AtRule Screen
        {
            get
            {
                _Queries.Add(new MQuery("screen", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// Intended for television-type devices.
        /// </summary>
        public AtRule Tv
        {
            get
            {
                _Queries.Add(new MQuery("tv", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// Intended for media using a fixed-pitch character grid, such as teletypes, terminals, or portable devices with limited display capabilities.
        /// </summary>
        public AtRule Tty
        {
            get
            {
                _Queries.Add(new MQuery("tty", MediaQueryType.MediaType));
                return this;
            }
        }

        /// <summary>
        /// It combines multiple media features together into a single media query, 
        /// where each connected feature must be true for the entire query to be true.
        /// </summary>
        public AtRule And
        {
            get
            {
                _Queries.Add(new MQuery("and", MediaQueryType.Condition));
                return this;
            }
        }

        /// <summary>
        /// Please use <see langword="Or"/> instead.
        /// <br/>
        /// Both are same.
        /// </summary>
        public AtRule Comma
        {
            get
            {
                _Queries.Add(new MQuery(",", MediaQueryType.Condition));
                return this;
            }
        }

        /// <summary>
        /// It combines two or more media queries into a single rule. 
        /// If any of the media queries in <c>Or</c>-separated list is true, the entire media statement will also be true.
        /// <para>Same as <see langword="Comma"/>.</para>
        /// </summary>
        public AtRule Or
        {
            get
            {
                _Queries.Add(new MQuery(",", MediaQueryType.Condition));
                return this;
            }
        }

        /// <summary>
        /// It can be used to reverse the logic of a condition.
        /// <br/>
        /// The <see langword="Not"/> operator is <see langword="true"/> only when all media features are <see langword="false"/>.
        /// <code>You can't use the <see langword="Not"/> operator to negate a single condition in a media query, it can only be applied to an entire media query.</code>
        /// </summary>
        public AtRule Not
        {
            get
            {
                _Queries.Add(new MQuery("not", MediaQueryType.Condition));
                return this;
            }
        }

        /// <summary>
        /// Applies a style only if the entire media query matches.
        /// This can be helpful to prevent older browsers from applying styles.
        /// </summary>
        public AtRule Only
        {
            get
            {
                _Queries.Add(new MQuery("only", MediaQueryType.Condition));
                return this;
            }
        }

        #endregion

        #region Media features
        /// <summary>
        /// Used to check if any of the user's input devices can (support) hover over elements on the page.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule AnyHover(AnyHoverOptions option)
        {
            switch (option)
            {
                case AnyHoverOptions.None:
                    {
                        _Queries.Add(new MQuery("(any-hover: none)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case AnyHoverOptions.Hover:
                    {
                        _Queries.Add(new MQuery("(any-hover: hover)", MediaQueryType.MediaFeature));
                        return this;
                    }
                default:
                    {
                        return this;
                    }
            }
        }

        /// <summary>
        /// Used to detect the presence of any available input mechanism for pointing at elements, such as a mouse, stylus, or touchscreen. 
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule AnyPointer(AnyPointerOptions option)
        {
            switch (option)
            {
                case AnyPointerOptions.None:
                    {
                        _Queries.Add(new MQuery("(any-pointer: none)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case AnyPointerOptions.Coarse:
                    {
                        _Queries.Add(new MQuery("(any-pointer: coarse)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case AnyPointerOptions.Fine:
                    {
                        _Queries.Add(new MQuery("(any-pointer: fine)", MediaQueryType.MediaFeature));
                        return this;
                    }
                default:
                    {
                        return this;
                    }
            }
        }

        /// <summary>
        /// AspectRadio is used to check the aspect ratio of the viewport or the rendering surface. The aspect ratio is the ratio of the width to the height of a box.
        /// <br/>
        /// <br/>
        /// Example:
        /// <br/>
        /// AspectRatio("2/3")
        /// </summary>
        /// <param name="ratio">Ratio value to apply e.g. 2/3</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule AspectRatio(string ratio)
        {
            if (ratio.IsNullOrWhiteSpace())
                throw new Exception("AspectRatio can not be null");

            _Queries.Add(new MQuery($"(aspect-ratio: {ratio.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// MaxAspectRadio is used to check the maximum aspect ratio of the viewport or the rendering surface. The aspect ratio is the ratio of the width to the height of a box.
        /// <br/>
        /// <br/>
        /// Example:
        /// <br/>
        /// MaxAspectRatio("2/3")
        /// </summary>
        /// <param name="ratio">Ratio value to apply e.g. 2/3</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MaxAspectRatio(string ratio)
        {
            if (ratio.IsNullOrWhiteSpace())
                throw new Exception("MaxAspectRatio can not be null");

            _Queries.Add(new MQuery($"(max-aspect-ratio: {ratio.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// MinAspectRadio is used to check the minimum aspect ratio of the viewport or the rendering surface. The aspect ratio is the ratio of the width to the height of a box.
        /// <br/>
        /// <br/>
        /// Example:
        /// <br/>
        /// MinAspectRatio("2/3")
        /// </summary>
        /// <param name="ratio">Ratio value to apply e.g. 2/3</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MinAspectRatio(string ratio)
        {
            if (ratio.IsNullOrWhiteSpace())
                throw new Exception("MinAspectRatio can not be null");

            _Queries.Add(new MQuery($"(min-aspect-ratio: {ratio.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// Color feature tests if the number of bits per color component such as red, green, and blue of the output device is greater than 0.
        /// </summary>
        /// <returns></returns>
        public AtRule Color()
        {
            _Queries.Add(new MQuery($"(color)", MediaQueryType.MediaFeature));
            return this;
        }
        /// <summary>
        /// Color feature tests if the number of bits per color component such as red, green, and blue of the output device matches the condition.
        /// <br/>
        /// Example:
        /// <br/>
        /// Color("8")
        /// <br/>
        /// Color("&lt;=8")
        /// <br/>
        /// Color("&gt;=8")
        /// </summary>
        /// <param name="count">Number of bits. You can add greater/less symbols
        /// <br/>
        /// Example:
        /// <br/>
        /// Color("8")
        /// <br/>
        /// Color("&lt;=8")
        /// <br/>
        /// Color("&gt;=8")
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule Color(string count)
        {
            if (count.IsNullOrWhiteSpace())
                throw new Exception("Color bit value can not be null");
            _Queries.Add(new MQuery($"(color: {count.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// MaxColor feature tests if the maximum number of bits per color component such as red, green, and blue of the output device matches the condition.
        /// <br/>
        /// Example:
        /// <br/>
        /// MaxColor("8")
        /// <br/>
        /// MaxColor("&lt;=8")
        /// <br/>
        /// MaxColor("&gt;=8")
        /// </summary>
        /// <param name="count">Number of bits. You can add greater/less symbols
        /// <br/>
        /// Example:
        /// <br/>
        /// MaxColor("8")
        /// <br/>
        /// MaxColor("&lt;=8")
        /// <br/>
        /// MaxColor("&gt;=8")
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MaxColor(string count)
        {
            if (count.IsNullOrWhiteSpace())
                throw new Exception("MaxColor bit value can not be null");
            _Queries.Add(new MQuery($"(max-color: {count.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// MinColor feature tests if the minimum number of bits per color component such as red, green, and blue of the output device matches the condition.
        /// <br/>
        /// Example:
        /// <br/>
        /// MinColor("8")
        /// <br/>
        /// MinColor("&lt;=8")
        /// <br/>
        /// MinColor("&gt;=8")
        /// </summary>
        /// <param name="count">Number of bits. You can add greater/less symbols
        /// <br/>
        /// Example:
        /// <br/>
        /// MinColor("8")
        /// <br/>
        /// MinColor("&lt;=8")
        /// <br/>
        /// MinColor("&gt;=8")
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MinColor(string count)
        {
            if (count.IsNullOrWhiteSpace())
                throw new Exception("MinColor bit value can not be null");
            _Queries.Add(new MQuery($"(min-color: {count.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// ColorIndex is used to detect the number of colors that a device's display can represent.
        /// <br/>
        /// Example:
        /// <br/>
        /// ColorIndex("8")
        /// <br/>
        /// ColorIndex("&lt;=8")
        /// <br/>
        /// ColorIndex("&gt;=8")
        /// </summary>
        /// <param name="count">Number of bits. You can add greater/less symbols
        /// <br/>
        /// Example:
        /// <br/>
        /// ColorIndex("8")
        /// <br/>
        /// ColorIndex("&lt;=8")
        /// <br/>
        /// ColorIndex(gt;=8")
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule ColorIndex(string count)
        {
            if (count.IsNullOrWhiteSpace())
                throw new Exception("ColorIndex bit value can not be null");
            _Queries.Add(new MQuery($"(color-index: {count.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// MaxColorIndex is used to detect the maximum number of colors that a device's display can represent.
        /// <br/>
        /// Example:
        /// <br/>
        /// ColorIndex("8")
        /// <br/>
        /// MaxColorIndex("&lt;=8")
        /// <br/>
        /// MaxColorIndex("&gt;=8")
        /// </summary>
        /// <param name="count">Number of bits. You can add greater/less symbols
        /// <br/>
        /// Example:
        /// <br/>
        /// MaxColorIndex("8")
        /// <br/>
        /// MaxColorIndex("&lt;=8")
        /// <br/>
        /// MaxColorIndex(;=8")
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MaxColorIndex(string count)
        {
            if (count.IsNullOrWhiteSpace())
                throw new Exception("MaxColorIndex bit value can not be null");
            _Queries.Add(new MQuery($"(max-color-index: {count.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// MinColorIndex is used to detect the minimum number of colors that a device's display can represent.
        /// <br/>
        /// Example:
        /// <br/>
        /// MinColorIndex("8")
        /// <br/>
        /// MinColorIndex("&lt;=8")
        /// <br/>
        /// MinColorIndex("&gt;=8")
        /// </summary>
        /// <param name="count">Number of bits. You can add greater/less symbols
        /// <br/>
        /// Example:
        /// <br/>
        /// MinColorIndex("8")
        /// <br/>
        /// MinColorIndex("&lt;=8")
        /// <br/>
        /// MinColorIndex(gt;=8")
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MinColorIndex(string count)
        {
            if (count.IsNullOrWhiteSpace())
                throw new Exception("MinColorIndex bit value can not be null");
            _Queries.Add(new MQuery($"(min-color-index: {count.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// To determine the width of the viewport.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule Width(string width)
        {
            if (width.IsNullOrWhiteSpace())
                throw new Exception("Width value can not be null");
            _Queries.Add(new MQuery($"(width: {width.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// To determine the minimum width of the viewport.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MinWidth(string width)
        {
            if (width.IsNullOrWhiteSpace())
                throw new Exception("MinWidth value can not be null");
            _Queries.Add(new MQuery($"(min-width: {width.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// To determine the maximum width of the viewport.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MaxWidth(string width)
        {
            if (width.IsNullOrWhiteSpace())
                throw new Exception("MaxWidth value can not be null");
            _Queries.Add(new MQuery($"(max-width: {width.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// To determine the height of the viewport.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule Height(string height)
        {
            if (height.IsNullOrWhiteSpace())
                throw new Exception("Height value can not be null");
            _Queries.Add(new MQuery($"(height: {height.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// To determine the minimum height of the viewport.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MinHeight(string height)
        {
            if (height.IsNullOrWhiteSpace())
                throw new Exception("MinHeight value can not be null");
            _Queries.Add(new MQuery($"(min-height: {height.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// To determine the maximum height of the viewport.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MaxHeight(string height)
        {
            if (height.IsNullOrWhiteSpace())
                throw new Exception("MaxHeight value can not be null");
            _Queries.Add(new MQuery($"(max-height: {height.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// Helps check the refresh rate of the device, which determines how frequently the displayed content can be updated.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule Update(RefreshUpdateOptions option)
        {
            switch (option)
            {
                case RefreshUpdateOptions.None:
                    {
                        _Queries.Add(new MQuery("(update: none)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case RefreshUpdateOptions.Slow:
                    {
                        _Queries.Add(new MQuery("(update: slow)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case RefreshUpdateOptions.Fast:
                    {
                        _Queries.Add(new MQuery("(update: fast)", MediaQueryType.MediaFeature));
                        return this;
                    }
                default:
                    {
                        return this;
                    }
            }
        }

        /// <summary>
        /// Used to check how many pixels are displayed per inch on a screen.
        /// <para>
        /// Example:
        /// <br/>
        /// Resolution("80dpi")
        /// </para>
        /// </summary>
        /// <param name="resolution"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule Resolution(string resolution)
        {
            if (resolution.IsNullOrWhiteSpace())
                throw new Exception("Resolution value can not be null");
            _Queries.Add(new MQuery($"(resolution: {resolution.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// Used to check the minimum pixels displayed per inch on a screen.
        /// <para>
        /// Example:
        /// <br/>
        /// MinResolution("80dpi")
        /// </para>
        /// </summary>
        /// <param name="resolution"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MinResolution(string resolution)
        {
            if (resolution.IsNullOrWhiteSpace())
                throw new Exception("MinResolution value can not be null");
            _Queries.Add(new MQuery($"(min-resolution: {resolution.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// Used to check the maximum pixels displayed per inch on a screen.
        /// <para>
        /// Example:
        /// <br/>
        /// MaxResolution("80dpi")
        /// </para>
        /// </summary>
        /// <param name="resolution"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MaxResolution(string resolution)
        {
            if (resolution.IsNullOrWhiteSpace())
                throw new Exception("MaxResolution value can not be null");
            _Queries.Add(new MQuery($"(max-resolution: {resolution.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// Allows checking if a user has enabled a setting on their device to reduce unnecessary animations. 
        /// This setting informs the device's browser that the user has chosen an interface that removes, minimises, 
        /// or substitutes motion-driven animations.
        /// </summary>
        /// <returns></returns>
        public AtRule PrefersReducedMotion()
        {
            _Queries.Add(new MQuery($"(prefers-reduced-motion)", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// Allows checking if a user has enabled a setting on their device to reduce unnecessary animations. 
        /// This setting informs the device's browser that the user has chosen an interface that removes, minimises, 
        /// or substitutes motion-driven animations.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule PrefersReducedMotion(PrefersReducedMotionOptions option)
        {
            switch (option)
            {
                case PrefersReducedMotionOptions.NoPreference:
                    {
                        _Queries.Add(new MQuery($"(prefers-reduced-motion: no-preference)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case PrefersReducedMotionOptions.Reduce:
                    {
                        _Queries.Add(new MQuery($"(prefers-reduced-motion: reduce)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }

            return this;
        }

        /// <summary>
        /// Used to check whether the device's screen or page is in a portrait or landscape orientation.
        /// <para>
        /// The orientation of the device is not always the same as the orientation of the screen. 
        /// For example, if you open the soft keyboard on a device in portrait orientation, the screen will become wider than it is tall. 
        /// In this case, the browser will use landscape styles instead of portrait styles.
        /// </para>
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule Orientation(DeviceOrientationOptions option)
        {
            switch (option)
            {
                case DeviceOrientationOptions.Portrait:
                    {
                        _Queries.Add(new MQuery($"(orientation: portrait)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DeviceOrientationOptions.Landscape:
                    {
                        _Queries.Add(new MQuery($"(orientation: landscape)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }

            return this;
        }

        /// <summary>
        /// Used to determine the number of bits are used to represent each pixel in the monochrome frame buffer of the output device.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule Monochrome(string value)
        {
            if (value.IsNullOrWhiteSpace())
                throw new Exception("Monochrome value can not be null");
            _Queries.Add(new MQuery($"(monochrome: {value.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// Used to determine the minimum number of bits are used to represent each pixel in the monochrome frame buffer of the output device.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MinMonochrome(string value)
        {
            if (value.IsNullOrWhiteSpace())
                throw new Exception("MinMonochrome value can not be null");
            _Queries.Add(new MQuery($"(min-monochrome: {value.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// Used to determine the maximum number of bits are used to represent each pixel in the monochrome frame buffer of the output device.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AtRule MaxMonochrome(string value)
        {
            if (value.IsNullOrWhiteSpace())
                throw new Exception("MaxMonochrome value can not be null");
            _Queries.Add(new MQuery($"(max-monochrome: {value.Trim()})", MediaQueryType.MediaFeature));
            return this;
        }

        /// <summary>
        /// Used to determine if the user's device is able to hover over elements.
        /// <para>
        /// Example:
        /// <br/>
        /// <c>A touchscreen device does not have a pointing input mechanism (like a mouse) that can be used to hover over elements.</c>
        /// </para>
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule Hover(HoverSupportOptions option)
        {
            switch (option)
            {
                case HoverSupportOptions.None:
                    {
                        _Queries.Add(new MQuery($"(hover: none)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case HoverSupportOptions.Hover:
                    {
                        _Queries.Add(new MQuery($"(hover: hover)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }

            return this;
        }

        /// <summary>
        /// Used to detect and style web content based on the current display mode of a web application.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule DisplayMode(DisplayModeOptions option)
        {
            switch (option)
            {
                case DisplayModeOptions.FullScreen:
                    {
                        _Queries.Add(new MQuery($"(display-mode: fullscreen)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DisplayModeOptions.Standalone:
                    {
                        _Queries.Add(new MQuery($"(display-mode: standalone)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DisplayModeOptions.MinimalUI:
                    {
                        _Queries.Add(new MQuery($"(display-mode: minimal-ui)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DisplayModeOptions.Browser:
                    {
                        _Queries.Add(new MQuery($"(display-mode: browser)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DisplayModeOptions.WindowControlsOverlay:
                    {
                        _Queries.Add(new MQuery($"(display-mode: window-controls-overlay)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }

            return this;
        }

        /// <summary>
        /// Used to check whether the user agent and output device supports the high brightness, contrast ratio, and color depth.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule DynamicRange(DynamicRangeOptions option)
        {
            switch (option)
            {
                case DynamicRangeOptions.Standard:
                    {
                        _Queries.Add(new MQuery($"(dynamic-range: standard)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DynamicRangeOptions.High:
                    {
                        _Queries.Add(new MQuery($"(dynamic-range: high)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }
            return this;
        }

        /// <summary>
        /// Used to determine how the user device handles content that goes beyond the initial container's boundaries in a vertical direction.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule OverflowBlock(DeviceOverflowBlockOptions option)
        {
            switch (option)
            {
                case DeviceOverflowBlockOptions.None:
                    {
                        _Queries.Add(new MQuery($"(overflow-block: none)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DeviceOverflowBlockOptions.Scroll:
                    {
                        _Queries.Add(new MQuery($"(overflow-block: scroll)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DeviceOverflowBlockOptions.OptionalPaged:
                    {
                        _Queries.Add(new MQuery($"(overflow-block: optional-paged)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DeviceOverflowBlockOptions.Paged:
                    {
                        _Queries.Add(new MQuery($"(overflow-block: paged)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }
            return this;
        }

        /// <summary>
        /// Used to determine how the user device handles content that goes beyond the initial container's boundaries in a horizontal direction.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule OverflowInline(OverflowInlineOptions option)
        {
            switch (option)
            {
                case OverflowInlineOptions.None:
                    {
                        _Queries.Add(new MQuery($"(overflow-inline: none)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case OverflowInlineOptions.Scroll:
                    {
                        _Queries.Add(new MQuery($"(overflow-inline: scroll)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }
            return this;
        }

        /// <summary>
        /// Used to check if the user wants the website to have more or less contrast.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule PrefersContrast(PrefersContrastOptions option)
        {
            switch (option)
            {
                case PrefersContrastOptions.NoPreference:
                    {
                        _Queries.Add(new MQuery($"(prefers-contrast: no-preference)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case PrefersContrastOptions.More:
                    {
                        _Queries.Add(new MQuery($"(prefers-contrast: more)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case PrefersContrastOptions.Less:
                    {
                        _Queries.Add(new MQuery($"(prefers-contrast: less)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case PrefersContrastOptions.Custom:
                    {
                        _Queries.Add(new MQuery($"(prefers-contrast: custom)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }
            return this;
        }

        /// <summary>
        /// Used to determine whether a user prefers a website to have a light or dark mode.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule PrefersColorScheme(PrefersColorSchemeOptions option)
        {
            switch (option)
            {
                case PrefersColorSchemeOptions.Light:
                    {
                        _Queries.Add(new MQuery($"(prefers-color-scheme: light)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case PrefersColorSchemeOptions.Dark:
                    {
                        _Queries.Add(new MQuery($"(prefers-color-scheme: dark)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }
            return this;
        }

        /// <summary>
        /// Used to check if the user has enabled a forced colors mode on their device.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule ForcedColors(ForcedColorsOptions option)
        {
            switch (option)
            {
                case ForcedColorsOptions.None:
                    {
                        _Queries.Add(new MQuery($"(forced-colors: none)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case ForcedColorsOptions.Active:
                    {
                        _Queries.Add(new MQuery($"(forced-colors: active)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }
            return this;
        }

        /// <summary>
        /// Used to check if the user has a pointing device they can use to point and click, such as a mouse or touchscreen.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule Pointer(AnyPointerOptions option)
        {
            switch (option)
            {
                case AnyPointerOptions.Coarse:
                    {
                        _Queries.Add(new MQuery($"(pointer: coarse)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case AnyPointerOptions.Fine:
                    {
                        _Queries.Add(new MQuery($"(pointer: fine)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case AnyPointerOptions.None:
                    {
                        _Queries.Add(new MQuery($"(pointer: none)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }
            return this;
        }

        /// <summary>
        /// Used to check if the user device or screen supports a grid layout.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule Gird(DeviceGridSupportOptions option)
        {
            switch (option)
            {
                case DeviceGridSupportOptions.Yes:
                    {
                        _Queries.Add(new MQuery($"(grid: 1)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case DeviceGridSupportOptions.No:
                    {
                        _Queries.Add(new MQuery($"(grid: 0)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }
            return this;
        }

        /// <summary>
        /// Used to apply different styles to your web page depending on the range of colors that the user's device can display.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public AtRule ColorGamut(ColorGamutOptions option)
        {
            switch (option)
            {
                case ColorGamutOptions.Srgb:
                    {
                        _Queries.Add(new MQuery($"(color-gamut: srgb)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case ColorGamutOptions.P3:
                    {
                        _Queries.Add(new MQuery($"(color-gamut: p3)", MediaQueryType.MediaFeature));
                        return this;
                    }
                case ColorGamutOptions.Rec2020:
                    {
                        _Queries.Add(new MQuery($"(color-gamut: rec2020)", MediaQueryType.MediaFeature));
                        return this;
                    }
            }
            return this;
        }

        #endregion


        //end class
    }

    internal class MQuery
    {
        public MQuery(string value, MediaQueryType type)
        {
            Value = value;
            Type = type;
        }
        public MediaQueryType Type
        {
            get; set;
        }
        public string Value
        {
            get; set;
        }
    }


}
