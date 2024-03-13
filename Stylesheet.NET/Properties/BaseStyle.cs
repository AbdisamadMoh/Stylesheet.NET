

using System;
using System.Collections.Generic;

namespace StylesheetNET
{
    /// <summary>
    /// Represents the base css style of HTML element. It houses all the css properties of an element. 
    /// </summary>
    public abstract class BaseStyle : Validation
    {
        #region fields

       internal protected readonly Dictionary<string, string> _css = new Dictionary<string, string>();

        #endregion

        #region methods/ctor
        protected string GetProperties(bool _minified = false)
        {
            var newLine = _minified ? "" : "\n";
            var indent = _minified ? "" : Extension.Indent;
            var style = "";
            foreach (var _p in _css)
            {
                if (_p.Value.IsNullOrWhiteSpace())
                    continue;
                var property = ValidateProperty(_p.Key, _p.Value, _minified);

                if (BrowserSupport.IsWebKit(_p.Key))
                {
                    var webkit = $"{ValidateProperty("-webkit-" + _p.Key, _p.Value, _minified)}{newLine}";
                    style += $"{indent}{webkit}";
                }
                if (BrowserSupport.IsMoz(_p.Key))
                {
                    var moz = $"{ValidateProperty("-moz-" + _p.Key, _p.Value, _minified)}{newLine}";
                    style += $"{indent}{moz}";
                }


                style += $"{indent}{property}{newLine}";
            }
            return style;
        }
        #endregion

        #region Override/indexer
        /// <summary>
        /// Gets or Sets css property.
        /// </summary>
        /// <param name="_property"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public string this[string _property]
        {
            get
            {
                if (!_css.ContainsKey(_property))
                    throw new ArgumentNullException($"You are trying access a CSS property that has not been assigned.\nPropery: {_property}");
                return _css[_property];
            }
            set
            {
                _css[_property] = value;
            }
        }
        #endregion

        #region CSS Properties

        /// <summary>
        /// The AlignContent property aligns items in a flex container. The alignment is along flex lines (horizontal virtual lines). A flex line works like a magnet, pulling items towards it.
        /// </summary>
        public AlignContentOptions AlignContent
        {
            get
            {
                var val = _css.ContainsKey("align-content") ? _css["align-content"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AlignContent");
                var opt = (AlignContentOptions)Keywords.GetOptionByKeyword<AlignContentOptions>(val);
                return opt;
            }
            set
            {
                _css["align-content"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The AlignItems property aligns, and evenly spaces, items. The items are arranged inside a flex container.
        /// </summary>
        public AlignItemsOptions AlignItems
        {
            get
            {
                var val = _css.ContainsKey("align-items") ? _css["align-items"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AlignItems");
                var opt = (AlignItemsOptions)Keywords.GetOptionByKeyword<AlignItemsOptions>(val);
                return opt;
            }
            set
            {
                _css["align-items"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The AlignSelf property aligns an item in a flex container. This property overides the container‘s <see cref="AlignItems"/> value.
        /// </summary>
        public AlignSelfOptions AlignSelf
        {
            get
            {
                var val = _css.ContainsKey("align-self") ? _css["align-self"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AlignSelf");
                var opt = (AlignSelfOptions)Keywords.GetOptionByKeyword<AlignSelfOptions>(val);
                return opt;
            }
            set
            {
                _css["align-self"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The All property resets All element properties. Their values are reset to their default or inherited values. This property is used to reset styles and start with a clean slate.
        /// </summary>
        public AllOptions All
        {
            get
            {
                var val = _css.ContainsKey("all") ? _css["all"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: All");
                var opt = (AllOptions)Keywords.GetOptionByKeyword<AllOptions>(val);
                return opt;
            }
            set
            {
                _css["all"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Animation property defines an Animation. It is a shorthand property for several Animation properties. These include <see cref="AnimationDuration"/>, <see cref="AnimationDirection"/>, and others.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Animation =  new Animation(...);</c>
        /// <br/>
        /// <c>Animation = "your css value(s) here";</c>
        /// <br/>
        /// <c>Animation = AnimationOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Animation = Animation;</c>
        /// <br/>
        /// <c>string cssValue = Animation;</c>
        /// <br/>
        /// <c>AnimationOptions option = Animation;</c>
        /// </summary>
        public Animation Animation
        {
            get
            {
                if (!_css.ContainsKey("animation"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Animation");
                return _css["animation"];
            }
            set
            {
                _css["animation"] = value;
            }
        }

        /// <summary>
        /// The AnimationDelay property delays the animation before it starts. Its value is defined in seconds (s) or milliseconds (ms).
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>AnimationDelay =  new AnimationDelay(...);</c>
        /// <br/>
        /// <c>AnimationDelay = "your css value(s) here";</c>
        /// <br/>
        /// <c>AnimationDelay = AnimationDelayOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_AnimationDelay = AnimationDelay;</c>
        /// <br/>
        /// <c>string cssValue = AnimationDelay;</c>
        /// <br/>
        /// <c>AnimationDelayOptions option = AnimationDelay;</c>
        /// </summary>
        public AnimationDelay AnimationDelay
        {
            get
            {
                if (!_css.ContainsKey("animation-delay"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AnimationDelay");
                return _css["animation-delay"];
            }
            set
            {
                _css["animation-delay"] = value;
            }
        }

        /// <summary>
        /// The AnimationDirection specifies the direction of the animation. Possible values are forward, backward, and alternate (back and forth).
        /// </summary>
        public AnimationDirectionOptions AnimationDirection
        {
            get
            {
                var val = _css.ContainsKey("animation-direction") ? _css["animation-direction"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AnimationDirection");
                var opt = (AnimationDirectionOptions)Keywords.GetOptionByKeyword<AnimationDirectionOptions>(val);
                return opt;
            }
            set
            {
                _css["animation-direction"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The AnimationDuration sets the timespan of an animation cycle. The value is defined in seconds (s) or milliseconds (ms).
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>AnimationDuration =  new AnimationDuration(...);</c>
        /// <br/>
        /// <c>AnimationDuration = "your css value(s) here";</c>
        /// <br/>
        /// <c>AnimationDuration = AnimationDurationOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_AnimationDuration = AnimationDuration;</c>
        /// <br/>
        /// <c>string cssValue = AnimationDuration;</c>
        /// <br/>
        /// <c>AnimationDurationOptions option = AnimationDuration;</c>
        /// </summary>
        public AnimationDuration AnimationDuration
        {
            get
            {
                if (!_css.ContainsKey("animation-duration"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AnimationDuration");
                return _css["animation-duration"];
            }
            set
            {
                _css["animation-duration"] = value;
            }
        }

        /// <summary>
        /// AnimationFillMode defines a style for when the animation stops. This can be before or after the animation, or both.
        /// </summary>
        public AnimationFillModeOptions AnimationFillMode
        {
            get
            {
                var val = _css.ContainsKey("animation-fill-mode") ? _css["animation-fill-mode"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AnimationFillMode");
                var opt = (AnimationFillModeOptions)Keywords.GetOptionByKeyword<AnimationFillModeOptions>(val);
                return opt;
            }
            set
            {
                _css["animation-fill-mode"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// AnimationIterationCount sets the number of times an animation plays. To continually loop an animation, set the value to infinite. If no value is set, the animation will play only once.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>AnimationIterationCount =  new AnimationIterationCount(...);</c>
        /// <br/>
        /// <c>AnimationIterationCount = "your css value(s) here";</c>
        /// <br/>
        /// <c>AnimationIterationCount = AnimationIterationCountOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_AnimationIterationCount = AnimationIterationCount;</c>
        /// <br/>
        /// <c>string cssValue = AnimationIterationCount;</c>
        /// <br/>
        /// <c>AnimationIterationCountOptions option = AnimationIterationCount;</c>
        /// </summary>
        public AnimationIterationCount AnimationIterationCount
        {
            get
            {
                if (!_css.ContainsKey("animation-iteration-count"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AnimationIterationCount");
                return _css["animation-iteration-count"];
            }
            set
            {
                _css["animation-iteration-count"] = value;
            }
        }

        /// <summary>
        /// The AnimationName references a keyframes name. @keyframes rules specify the animation conditions. This is the animation that will play.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>AnimationName =  new AnimationName(...);</c>
        /// <br/>
        /// <c>AnimationName = "your css value(s) here";</c>
        /// <br/>
        /// <c>AnimationName = AnimationNameOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_AnimationName = AnimationName;</c>
        /// <br/>
        /// <c>string cssValue = AnimationName;</c>
        /// <br/>
        /// <c>AnimationNameOptions option = AnimationName;</c>
        /// </summary>
        public AnimationName AnimationName
        {
            get
            {
                if (!_css.ContainsKey("animation-name"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AnimationName");
                return _css["animation-name"];
            }
            set
            {
                _css["animation-name"] = value;
            }
        }

        /// <summary>
        /// The AnimationPlayState sets the animation play state. Possible values include paused and running. The default is running.
        /// </summary>
        public AnimationPlayStateOptions AnimationPlayState
        {
            get
            {
                var val = _css.ContainsKey("animation-play-state") ? _css["animation-play-state"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AnimationPlayState");
                var opt = (AnimationPlayStateOptions)Keywords.GetOptionByKeyword<AnimationPlayStateOptions>(val);
                return opt;
            }
            set
            {
                _css["animation-play-state"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The AnimationTimingFunction sets the animation speed curve. Options include: linear, ease, steps, and cubic-bezier. These functions describe the transition from one state to another.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>AnimationTimingFunction =  new AnimationTimingFunction(...);</c>
        /// <br/>
        /// <c>AnimationTimingFunction = "your css value(s) here";</c>
        /// <br/>
        /// <c>AnimationTimingFunction = AnimationTimingFunctionOptions.Ease;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_AnimationTimingFunction = AnimationTimingFunction;</c>
        /// <br/>
        /// <c>string cssValue = AnimationTimingFunction;</c>
        /// <br/>
        /// <c>AnimationTimingFunctionOptions option = AnimationTimingFunction;</c>
        /// </summary>
        public AnimationTimingFunction AnimationTimingFunction
        {
            get
            {
                if (!_css.ContainsKey("animation-timing-function"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: AnimationTimingFunction");
                return _css["animation-timing-function"];
            }
            set
            {
                _css["animation-timing-function"] = value;
            }
        }

        /// <summary>
        /// A backface is a reversed mirror image of the element's front side. The BackfaceVisibility shows the element's back face to the user. This property is used with rotated elements.
        /// </summary>
        public BackfaceVisibilityOptions BackfaceVisibility
        {
            get
            {
                var val = _css.ContainsKey("backface-visibility") ? _css["backface-visibility"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackfaceVisibility");
                var opt = (BackfaceVisibilityOptions)Keywords.GetOptionByKeyword<BackfaceVisibilityOptions>(val);
                return opt;
            }
            set
            {
                _css["backface-visibility"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Background property defines the Background of an element. This can include a color, an image, a color gradient, and more.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Background =  new Background(...);</c>
        /// <br/>
        /// <c>Background = "your css value(s) here";</c>
        /// <br/>
        /// <c>Background = BackgroundOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Background = Background;</c>
        /// <br/>
        /// <c>string cssValue = Background;</c>
        /// <br/>
        /// <c>BackgroundOptions option = Background;</c>
        /// </summary>
        public Background Background
        {
            get
            {
                if (!_css.ContainsKey("background"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Background");
                return _css["background"];
            }
            set
            {
                _css["background"] = value;
            }
        }

        /// <summary>
        /// The BackgroundAttachment sets the background scroll behavior. Possible values include fixed or scroll. A fixed background stays at a fixed position, relative to the viewport. A scroll background scrolls with the page.
        /// </summary>
        public BackgroundAttachmentOptions BackgroundAttachment
        {
            get
            {
                var val = _css.ContainsKey("background-attachment") ? _css["background-attachment"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackgroundAttachment");
                var opt = (BackgroundAttachmentOptions)Keywords.GetOptionByKeyword<BackgroundAttachmentOptions>(val);
                return opt;
            }
            set
            {
                _css["background-attachment"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The BackgroundBlendMode property blends background layers together. This property may include multiple images to be blended. Background images can also blend with a background color.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BackgroundBlendMode =  new BackgroundBlendMode(...);</c>
        /// <br/>
        /// <c>BackgroundBlendMode = "your css value(s) here";</c>
        /// <br/>
        /// <c>BackgroundBlendMode = BackgroundBlendModeOptions.Normal;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BackgroundBlendMode = BackgroundBlendMode;</c>
        /// <br/>
        /// <c>string cssValue = BackgroundBlendMode;</c>
        /// <br/>
        /// <c>BackgroundBlendModeOptions option = BackgroundBlendMode;</c>
        /// </summary>
        public BackgroundBlendMode BackgroundBlendMode
        {
            get
            {
                if (!_css.ContainsKey("background-blend-mode"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackgroundBlendMode");
                return _css["background-blend-mode"];
            }
            set
            {
                _css["background-blend-mode"] = value;
            }
        }

        /// <summary>
        /// The BackgroundClip property extends the background inside the element. The clipping can extend to the content-box, padding-box, or border-box.
        /// </summary>
        public BackgroundClipOptions BackgroundClip
        {
            get
            {
                var val = _css.ContainsKey("background-clip") ? _css["background-clip"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackgroundClip");
                var opt = (BackgroundClipOptions)Keywords.GetOptionByKeyword<BackgroundClipOptions>(val);
                return opt;
            }
            set
            {
                _css["background-clip"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The BackgroundColor property specifies the background color. Background color values can be hex, rgb, hsl, rgba, hsla, or a color name. This property can also be set to transparent (no background).
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BackgroundColor =  new BackgroundColor(...);</c>
        /// <br/>
        /// <c>BackgroundColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>BackgroundColor = BackgroundColorOptions.Transparent;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BackgroundColor = BackgroundColor;</c>
        /// <br/>
        /// <c>string cssValue = BackgroundColor;</c>
        /// <br/>
        /// <c>BackgroundColorOptions option = BackgroundColor;</c>
        /// </summary>
        public BackgroundColor BackgroundColor
        {
            get
            {
                if (!_css.ContainsKey("background-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackgroundColor");
                return _css["background-color"];
            }
            set
            {
                _css["background-color"] = value;
            }
        }

        /// <summary>
        /// The BackgroundImage property sets the element's background image. By default, the image repeats vertically and horizontally. This property can also specify a color gradient.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BackgroundImage =  new BackgroundImage(...);</c>
        /// <br/>
        /// <c>BackgroundImage = "your css value(s) here";</c>
        /// <br/>
        /// <c>BackgroundImage = BackgroundImageOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BackgroundImage = BackgroundImage;</c>
        /// <br/>
        /// <c>string cssValue = BackgroundImage;</c>
        /// <br/>
        /// <c>BackgroundImageOptions option = BackgroundImage;</c>
        /// </summary>
        public BackgroundImage BackgroundImage
        {
            get
            {
                if (!_css.ContainsKey("background-image"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackgroundImage");
                return _css["background-image"];
            }
            set
            {
                _css["background-image"] = value;
            }
        }

        /// <summary>
        /// BackgroundOrigin sets the origin position of the background image. The origin can align with content-box, padding-box, or border-box.
        /// </summary>
        public BackgroundOriginOptions BackgroundOrigin
        {
            get
            {
                var val = _css.ContainsKey("background-origin") ? _css["background-origin"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackgroundOrigin");
                var opt = (BackgroundOriginOptions)Keywords.GetOptionByKeyword<BackgroundOriginOptions>(val);
                return opt;
            }
            set
            {
                _css["background-origin"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The BackgroundPosition sets the background image position. Possible values are left, right, center, percentage, pixels, and others. The default position is top left (0 0).
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BackgroundPosition =  new BackgroundPosition(...);</c>
        /// <br/>
        /// <c>BackgroundPosition = "your css value(s) here";</c>
        /// <br/>
        /// <c>BackgroundPosition = BackgroundPositionOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BackgroundPosition = BackgroundPosition;</c>
        /// <br/>
        /// <c>string cssValue = BackgroundPosition;</c>
        /// <br/>
        /// <c>BackgroundPositionOptions option = BackgroundPosition;</c>
        /// </summary>
        public BackgroundPosition BackgroundPosition
        {
            get
            {
                if (!_css.ContainsKey("background-position"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackgroundPosition");
                return _css["background-position"];
            }
            set
            {
                _css["background-position"] = value;
            }
        }

        /// <summary>
        /// The BackgroundRepeat property repeats a background image. Options include: repeat horizontally, vertically, tiled, or never.
        /// </summary>
        public BackgroundRepeatOptions BackgroundRepeat
        {
            get
            {
                var val = _css.ContainsKey("background-repeat") ? _css["background-repeat"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackgroundRepeat");
                var opt = (BackgroundRepeatOptions)Keywords.GetOptionByKeyword<BackgroundRepeatOptions>(val);
                return opt;
            }
            set
            {
                _css["background-repeat"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The BackgroundSize property sets the background image size. It accepts two values: width and height.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BackgroundSize =  new BackgroundSize(...);</c>
        /// <br/>
        /// <c>BackgroundSize = "your css value(s) here";</c>
        /// <br/>
        /// <c>BackgroundSize = BackgroundSizeOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BackgroundSize = BackgroundSize;</c>
        /// <br/>
        /// <c>string cssValue = BackgroundSize;</c>
        /// <br/>
        /// <c>BackgroundSizeOptions option = BackgroundSize;</c>
        /// </summary>
        public BackgroundSize BackgroundSize
        {
            get
            {
                if (!_css.ContainsKey("background-size"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BackgroundSize");
                return _css["background-size"];
            }
            set
            {
                _css["background-size"] = value;
            }
        }

        /// <summary>
        /// The Border property adds a Border to an element. Borders can vary in width, line style, and color.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Border =  new Border(...);</c>
        /// <br/>
        /// <c>Border = "your css value(s) here";</c>
        /// <br/>
        /// <c>Border = BorderOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Border = Border;</c>
        /// <br/>
        /// <c>string cssValue = Border;</c>
        /// <br/>
        /// <c>BorderOptions option = Border;</c>
        /// </summary>
        public Border Border
        {
            get
            {
                if (!_css.ContainsKey("border"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Border");
                return _css["border"];
            }
            set
            {
                _css["border"] = value;
            }
        }

        /// <summary>
        /// The BorderBottom property adds a bottom border to an element. Borders can vary in width, line style, and color.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderBottom =  new BorderBottom(...);</c>
        /// <br/>
        /// <c>BorderBottom = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderBottom = BorderBottomOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderBottom = BorderBottom;</c>
        /// <br/>
        /// <c>string cssValue = BorderBottom;</c>
        /// <br/>
        /// <c>BorderBottomOptions option = BorderBottom;</c>
        /// </summary>
        public BorderBottom BorderBottom
        {
            get
            {
                if (!_css.ContainsKey("border-bottom"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderBottom");
                return _css["border-bottom"];
            }
            set
            {
                _css["border-bottom"] = value;
            }
        }

        /// <summary>
        /// The BorderBottomColor property sets the bottom border color. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-bottom-style value is required for any border to show.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderBottomColor =  new BorderBottomColor(...);</c>
        /// <br/>
        /// <c>BorderBottomColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderBottomColor = BorderBottomColorOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderBottomColor = BorderBottomColor;</c>
        /// <br/>
        /// <c>string cssValue = BorderBottomColor;</c>
        /// <br/>
        /// <c>BorderBottomColorOptions option = BorderBottomColor;</c>
        /// </summary>
        public BorderBottomColor BorderBottomColor
        {
            get
            {
                if (!_css.ContainsKey("border-bottom-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderBottomColor");
                return _css["border-bottom-color"];
            }
            set
            {
                _css["border-bottom-color"] = value;
            }
        }

        /// <summary>
        /// A BorderBottomLeftRadius sets the bottom left corner radius. This property gives an element a rounded border effect.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderBottomLeftRadius =  new BorderBottomLeftRadius(...);</c>
        /// <br/>
        /// <c>BorderBottomLeftRadius = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderBottomLeftRadius = BorderBottomLeftRadiusOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderBottomLeftRadius = BorderBottomLeftRadius;</c>
        /// <br/>
        /// <c>string cssValue = BorderBottomLeftRadius;</c>
        /// <br/>
        /// <c>BorderBottomLeftRadiusOptions option = BorderBottomLeftRadius;</c>
        /// </summary>
        public BorderBottomLeftRadius BorderBottomLeftRadius
        {
            get
            {
                if (!_css.ContainsKey("border-bottom-left-radius"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderBottomLeftRadius");
                return _css["border-bottom-left-radius"];
            }
            set
            {
                _css["border-bottom-left-radius"] = value;
            }
        }

        /// <summary>
        /// A BorderBottomRightRadius sets the bottom right corner radius. This property gives an element a rounded border effect.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderBottomRightRadius =  new BorderBottomRightRadius(...);</c>
        /// <br/>
        /// <c>BorderBottomRightRadius = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderBottomRightRadius = BorderBottomRightRadiusOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderBottomRightRadius = BorderBottomRightRadius;</c>
        /// <br/>
        /// <c>string cssValue = BorderBottomRightRadius;</c>
        /// <br/>
        /// <c>BorderBottomRightRadiusOptions option = BorderBottomRightRadius;</c>
        /// </summary>
        public BorderBottomRightRadius BorderBottomRightRadius
        {
            get
            {
                if (!_css.ContainsKey("border-bottom-right-radius"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderBottomRightRadius");
                return _css["border-bottom-right-radius"];
            }
            set
            {
                _css["border-bottom-right-radius"] = value;
            }
        }

        /// <summary>
        /// The BorderBottomStyle property sets the bottom border style. Possible values include solid, dashed, dotted, and others. A border-style value is required for any border to display.
        /// </summary>
        public BorderBottomStyleOptions BorderBottomStyle
        {
            get
            {
                var val = _css.ContainsKey("border-bottom-style") ? _css["border-bottom-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderBottomStyle");
                var opt = (BorderBottomStyleOptions)Keywords.GetOptionByKeyword<BorderBottomStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["border-bottom-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// BorderBottomWidth defines the width of the bottom border. The width is set as a pixel value, or as thin, medium, or thick.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderBottomWidth =  new BorderBottomWidth(...);</c>
        /// <br/>
        /// <c>BorderBottomWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderBottomWidth = BorderBottomWidthOptions.Medium;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderBottomWidth = BorderBottomWidth;</c>
        /// <br/>
        /// <c>string cssValue = BorderBottomWidth;</c>
        /// <br/>
        /// <c>BorderBottomWidthOptions option = BorderBottomWidth;</c>
        /// </summary>
        public BorderBottomWidth BorderBottomWidth
        {
            get
            {
                if (!_css.ContainsKey("border-bottom-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderBottomWidth");
                return _css["border-bottom-width"];
            }
            set
            {
                _css["border-bottom-width"] = value;
            }
        }

        /// <summary>
        /// The BorderCollapse property sets how table borders display. Possible values are separate and collapse. By default, table borders are separate.
        /// </summary>
        public BorderCollapseOptions BorderCollapse
        {
            get
            {
                var val = _css.ContainsKey("border-collapse") ? _css["border-collapse"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderCollapse");
                var opt = (BorderCollapseOptions)Keywords.GetOptionByKeyword<BorderCollapseOptions>(val);
                return opt;
            }
            set
            {
                _css["border-collapse"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The BorderColor property sets the color of the border. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-style value is required for a border to show.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderColor =  new BorderColor(...);</c>
        /// <br/>
        /// <c>BorderColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderColor = BorderColorOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderColor = BorderColor;</c>
        /// <br/>
        /// <c>string cssValue = BorderColor;</c>
        /// <br/>
        /// <c>BorderColorOptions option = BorderColor;</c>
        /// </summary>
        public BorderColor BorderColor
        {
            get
            {
                if (!_css.ContainsKey("border-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderColor");
                return _css["border-color"];
            }
            set
            {
                _css["border-color"] = value;
            }
        }

        /// <summary>
        /// The BorderImage property specifies an image as border. Instead of a solid color, the border is drawn with an image.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderImage =  new BorderImage(...);</c>
        /// <br/>
        /// <c>BorderImage = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderImage = BorderImageOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderImage = BorderImage;</c>
        /// <br/>
        /// <c>string cssValue = BorderImage;</c>
        /// <br/>
        /// <c>BorderImageOptions option = BorderImage;</c>
        /// </summary>
        public BorderImage BorderImage
        {
            get
            {
                if (!_css.ContainsKey("border-image"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderImage");
                return _css["border-image"];
            }
            set
            {
                _css["border-image"] = value;
            }
        }

        /// <summary>
        /// The BorderImageOutset property sets a border image outset. It specifies how far the image extends beyond the border. Values are specified in pixels or in numbers where 1 unit is equal to the border width.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderImageOutset =  new BorderImageOutset(...);</c>
        /// <br/>
        /// <c>BorderImageOutset = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderImageOutset = BorderImageOutsetOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderImageOutset = BorderImageOutset;</c>
        /// <br/>
        /// <c>string cssValue = BorderImageOutset;</c>
        /// <br/>
        /// <c>BorderImageOutsetOptions option = BorderImageOutset;</c>
        /// </summary>
        public BorderImageOutset BorderImageOutset
        {
            get
            {
                if (!_css.ContainsKey("border-image-outset"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderImageOutset");
                return _css["border-image-outset"];
            }
            set
            {
                _css["border-image-outset"] = value;
            }
        }

        /// <summary>
        /// BorderImageRepeat specifies how a border image displays. Possible values are repeat, round, stretch, etc.
        /// </summary>
        public BorderImageRepeatOptions BorderImageRepeat
        {
            get
            {
                var val = _css.ContainsKey("border-image-repeat") ? _css["border-image-repeat"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderImageRepeat");
                var opt = (BorderImageRepeatOptions)Keywords.GetOptionByKeyword<BorderImageRepeatOptions>(val);
                return opt;
            }
            set
            {
                _css["border-image-repeat"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// BorderImageSlice sets how a border image is sliced. There are 9 slices: four corners, four edges, and the middle.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderImageSlice =  new BorderImageSlice(...);</c>
        /// <br/>
        /// <c>BorderImageSlice = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderImageSlice = BorderImageSliceOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderImageSlice = BorderImageSlice;</c>
        /// <br/>
        /// <c>string cssValue = BorderImageSlice;</c>
        /// <br/>
        /// <c>BorderImageSliceOptions option = BorderImageSlice;</c>
        /// </summary>
        public BorderImageSlice BorderImageSlice
        {
            get
            {
                if (!_css.ContainsKey("border-image-slice"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderImageSlice");
                return _css["border-image-slice"];
            }
            set
            {
                _css["border-image-slice"] = value;
            }
        }

        /// <summary>
        /// The BorderImageSource property sets the border image URL. The URL can be relative or absolute.
        /// </summary>
        public BorderImageSourceOptions BorderImageSource
        {
            get
            {
                var val = _css.ContainsKey("border-image-source") ? _css["border-image-source"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderImageSource");
                var opt = (BorderImageSourceOptions)Keywords.GetOptionByKeyword<BorderImageSourceOptions>(val);
                return opt;
            }
            set
            {
                _css["border-image-source"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The BorderImageWidth property sets the image border width. It accepts any length value, such as, px, %, em, etc. If no value is provided, it inherits the border-width value.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderImageWidth =  new BorderImageWidth(...);</c>
        /// <br/>
        /// <c>BorderImageWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderImageWidth = BorderImageWidthOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderImageWidth = BorderImageWidth;</c>
        /// <br/>
        /// <c>string cssValue = BorderImageWidth;</c>
        /// <br/>
        /// <c>BorderImageWidthOptions option = BorderImageWidth;</c>
        /// </summary>
        public BorderImageWidth BorderImageWidth
        {
            get
            {
                if (!_css.ContainsKey("border-image-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderImageWidth");
                return _css["border-image-width"];
            }
            set
            {
                _css["border-image-width"] = value;
            }
        }

        /// <summary>
        /// The BorderLeft property adds a left border to an element. Borders can vary in width, line style, and color.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderLeft =  new BorderLeft(...);</c>
        /// <br/>
        /// <c>BorderLeft = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderLeft = BorderLeftOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderLeft = BorderLeft;</c>
        /// <br/>
        /// <c>string cssValue = BorderLeft;</c>
        /// <br/>
        /// <c>BorderLeftOptions option = BorderLeft;</c>
        /// </summary>
        public BorderLeft BorderLeft
        {
            get
            {
                if (!_css.ContainsKey("border-left"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderLeft");
                return _css["border-left"];
            }
            set
            {
                _css["border-left"] = value;
            }
        }

        /// <summary>
        /// The BorderLeftColor property sets the color of the left border. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-left-style value is required for a border to show.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderLeftColor =  new BorderLeftColor(...);</c>
        /// <br/>
        /// <c>BorderLeftColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderLeftColor = BorderLeftColorOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderLeftColor = BorderLeftColor;</c>
        /// <br/>
        /// <c>string cssValue = BorderLeftColor;</c>
        /// <br/>
        /// <c>BorderLeftColorOptions option = BorderLeftColor;</c>
        /// </summary>
        public BorderLeftColor BorderLeftColor
        {
            get
            {
                if (!_css.ContainsKey("border-left-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderLeftColor");
                return _css["border-left-color"];
            }
            set
            {
                _css["border-left-color"] = value;
            }
        }

        /// <summary>
        /// The BorderLeftStyle property sets the left border style. Possible values include solid, dashed, dotted, and others. A border-style value is required for any border to display.
        /// </summary>
        public BorderLeftStyleOptions BorderLeftStyle
        {
            get
            {
                var val = _css.ContainsKey("border-left-style") ? _css["border-left-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderLeftStyle");
                var opt = (BorderLeftStyleOptions)Keywords.GetOptionByKeyword<BorderLeftStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["border-left-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// BorderLeftWidth defines the width of the left border. The width is set as a pixel value, or as thin, medium, or thick.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderLeftWidth =  new BorderLeftWidth(...);</c>
        /// <br/>
        /// <c>BorderLeftWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderLeftWidth = BorderLeftWidthOptions.Medium;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderLeftWidth = BorderLeftWidth;</c>
        /// <br/>
        /// <c>string cssValue = BorderLeftWidth;</c>
        /// <br/>
        /// <c>BorderLeftWidthOptions option = BorderLeftWidth;</c>
        /// </summary>
        public BorderLeftWidth BorderLeftWidth
        {
            get
            {
                if (!_css.ContainsKey("border-left-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderLeftWidth");
                return _css["border-left-width"];
            }
            set
            {
                _css["border-left-width"] = value;
            }
        }

        /// <summary>
        /// A BorderRadius adds rounded corners to an element. The BorderRadius can have one to four values, one for each corner.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderRadius =  new BorderRadius(...);</c>
        /// <br/>
        /// <c>BorderRadius = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderRadius = BorderRadiusOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderRadius = BorderRadius;</c>
        /// <br/>
        /// <c>string cssValue = BorderRadius;</c>
        /// <br/>
        /// <c>BorderRadiusOptions option = BorderRadius;</c>
        /// </summary>
        public BorderRadius BorderRadius
        {
            get
            {
                if (!_css.ContainsKey("border-radius"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderRadius");
                return _css["border-radius"];
            }
            set
            {
                _css["border-radius"] = value;
            }
        }

        /// <summary>
        /// The BorderRight property adds a right border to an element. Borders can vary in width, line style, and color.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderRight =  new BorderRight(...);</c>
        /// <br/>
        /// <c>BorderRight = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderRight = BorderRightOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderRight = BorderRight;</c>
        /// <br/>
        /// <c>string cssValue = BorderRight;</c>
        /// <br/>
        /// <c>BorderRightOptions option = BorderRight;</c>
        /// </summary>
        public BorderRight BorderRight
        {
            get
            {
                if (!_css.ContainsKey("border-right"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderRight");
                return _css["border-right"];
            }
            set
            {
                _css["border-right"] = value;
            }
        }

        /// <summary>
        /// The BorderRightColor property sets the color of the right border. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-right-style value is required for a border to show.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderRightColor =  new BorderRightColor(...);</c>
        /// <br/>
        /// <c>BorderRightColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderRightColor = BorderRightColorOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderRightColor = BorderRightColor;</c>
        /// <br/>
        /// <c>string cssValue = BorderRightColor;</c>
        /// <br/>
        /// <c>BorderRightColorOptions option = BorderRightColor;</c>
        /// </summary>
        public BorderRightColor BorderRightColor
        {
            get
            {
                if (!_css.ContainsKey("border-right-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderRightColor");
                return _css["border-right-color"];
            }
            set
            {
                _css["border-right-color"] = value;
            }
        }

        /// <summary>
        /// The BorderRightStyle property sets the right border style. Possible values include solid, dashed, dotted, and others. A border-style value is required for any border to display.
        /// </summary>
        public BorderRightStyleOptions BorderRightStyle
        {
            get
            {
                var val = _css.ContainsKey("border-right-style") ? _css["border-right-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderRightStyle");
                var opt = (BorderRightStyleOptions)Keywords.GetOptionByKeyword<BorderRightStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["border-right-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// BorderRightWidth defines the width of the right border. The width is set as a pixel value, or as thin, medium, or thick.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderRightWidth =  new BorderRightWidth(...);</c>
        /// <br/>
        /// <c>BorderRightWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderRightWidth = BorderRightWidthOptions.Medium;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderRightWidth = BorderRightWidth;</c>
        /// <br/>
        /// <c>string cssValue = BorderRightWidth;</c>
        /// <br/>
        /// <c>BorderRightWidthOptions option = BorderRightWidth;</c>
        /// </summary>
        public BorderRightWidth BorderRightWidth
        {
            get
            {
                if (!_css.ContainsKey("border-right-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderRightWidth");
                return _css["border-right-width"];
            }
            set
            {
                _css["border-right-width"] = value;
            }
        }

        /// <summary>
        /// BorderSpacing sets the table cell border spacing. This property is used for table cells only.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderSpacing =  new BorderSpacing(...);</c>
        /// <br/>
        /// <c>BorderSpacing = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderSpacing = BorderSpacingOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderSpacing = BorderSpacing;</c>
        /// <br/>
        /// <c>string cssValue = BorderSpacing;</c>
        /// <br/>
        /// <c>BorderSpacingOptions option = BorderSpacing;</c>
        /// </summary>
        public BorderSpacing BorderSpacing
        {
            get
            {
                if (!_css.ContainsKey("border-spacing"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderSpacing");
                return _css["border-spacing"];
            }
            set
            {
                _css["border-spacing"] = value;
            }
        }

        /// <summary>
        /// The BorderStyle property sets the style of the border. It accepts one to four values for top, right, bottom, and left style. A BorderStyle value is required for any border to display.
        /// </summary>
        public BorderStyleOptions BorderStyle
        {
            get
            {
                var val = _css.ContainsKey("border-style") ? _css["border-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderStyle");
                var opt = (BorderStyleOptions)Keywords.GetOptionByKeyword<BorderStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["border-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The BorderTop property adds a top border to an element. Borders can vary in width, line style, and color.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderTop =  new BorderTop(...);</c>
        /// <br/>
        /// <c>BorderTop = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderTop = BorderTopOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderTop = BorderTop;</c>
        /// <br/>
        /// <c>string cssValue = BorderTop;</c>
        /// <br/>
        /// <c>BorderTopOptions option = BorderTop;</c>
        /// </summary>
        public BorderTop BorderTop
        {
            get
            {
                if (!_css.ContainsKey("border-top"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderTop");
                return _css["border-top"];
            }
            set
            {
                _css["border-top"] = value;
            }
        }

        /// <summary>
        /// The BorderTopColor property sets the color of the top border. Color values can be hex, rgb, hsl, rgba, hsla, or a color name. A border-top-style value is required for a border to show.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderTopColor =  new BorderTopColor(...);</c>
        /// <br/>
        /// <c>BorderTopColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderTopColor = BorderTopColorOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderTopColor = BorderTopColor;</c>
        /// <br/>
        /// <c>string cssValue = BorderTopColor;</c>
        /// <br/>
        /// <c>BorderTopColorOptions option = BorderTopColor;</c>
        /// </summary>
        public BorderTopColor BorderTopColor
        {
            get
            {
                if (!_css.ContainsKey("border-top-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderTopColor");
                return _css["border-top-color"];
            }
            set
            {
                _css["border-top-color"] = value;
            }
        }

        /// <summary>
        /// A BorderTopLeftRadius sets the top left corner radius. This property gives an element a rounded border effect.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderTopLeftRadius =  new BorderTopLeftRadius(...);</c>
        /// <br/>
        /// <c>BorderTopLeftRadius = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderTopLeftRadius = BorderTopLeftRadiusOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderTopLeftRadius = BorderTopLeftRadius;</c>
        /// <br/>
        /// <c>string cssValue = BorderTopLeftRadius;</c>
        /// <br/>
        /// <c>BorderTopLeftRadiusOptions option = BorderTopLeftRadius;</c>
        /// </summary>
        public BorderTopLeftRadius BorderTopLeftRadius
        {
            get
            {
                if (!_css.ContainsKey("border-top-left-radius"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderTopLeftRadius");
                return _css["border-top-left-radius"];
            }
            set
            {
                _css["border-top-left-radius"] = value;
            }
        }

        /// <summary>
        /// A BorderTopRightRadius sets the top right corner radius. This property gives the element a rounded border effect.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderTopRightRadius =  new BorderTopRightRadius(...);</c>
        /// <br/>
        /// <c>BorderTopRightRadius = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderTopRightRadius = BorderTopRightRadiusOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderTopRightRadius = BorderTopRightRadius;</c>
        /// <br/>
        /// <c>string cssValue = BorderTopRightRadius;</c>
        /// <br/>
        /// <c>BorderTopRightRadiusOptions option = BorderTopRightRadius;</c>
        /// </summary>
        public BorderTopRightRadius BorderTopRightRadius
        {
            get
            {
                if (!_css.ContainsKey("border-top-right-radius"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderTopRightRadius");
                return _css["border-top-right-radius"];
            }
            set
            {
                _css["border-top-right-radius"] = value;
            }
        }

        /// <summary>
        /// The BorderTopStyle property sets the top border style. Possible values include solid, dashed, dotted, and others. A border-style value is required for any border to display.
        /// </summary>
        public BorderTopStyleOptions BorderTopStyle
        {
            get
            {
                var val = _css.ContainsKey("border-top-style") ? _css["border-top-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderTopStyle");
                var opt = (BorderTopStyleOptions)Keywords.GetOptionByKeyword<BorderTopStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["border-top-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// A BorderTopWidth defines the width of the tpp border. The width is set as a pixel value, or as thin, medium, or thick.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderTopWidth =  new BorderTopWidth(...);</c>
        /// <br/>
        /// <c>BorderTopWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderTopWidth = BorderTopWidthOptions.Medium;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderTopWidth = BorderTopWidth;</c>
        /// <br/>
        /// <c>string cssValue = BorderTopWidth;</c>
        /// <br/>
        /// <c>BorderTopWidthOptions option = BorderTopWidth;</c>
        /// </summary>
        public BorderTopWidth BorderTopWidth
        {
            get
            {
                if (!_css.ContainsKey("border-top-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderTopWidth");
                return _css["border-top-width"];
            }
            set
            {
                _css["border-top-width"] = value;
            }
        }

        /// <summary>
        /// The BorderWidth property sets the width of the border. The width is set as a pixel value, or as thin, medium, or thick.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BorderWidth =  new BorderWidth(...);</c>
        /// <br/>
        /// <c>BorderWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>BorderWidth = BorderWidthOptions.Medium;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BorderWidth = BorderWidth;</c>
        /// <br/>
        /// <c>string cssValue = BorderWidth;</c>
        /// <br/>
        /// <c>BorderWidthOptions option = BorderWidth;</c>
        /// </summary>
        public BorderWidth BorderWidth
        {
            get
            {
                if (!_css.ContainsKey("border-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BorderWidth");
                return _css["border-width"];
            }
            set
            {
                _css["border-width"] = value;
            }
        }

        /// <summary>
        /// The Bottom property specifies the vertical position of a positioned element. Positioned elements are positioned as absolute, sticky, etc. The effect of the Bottom setting depends on the position value.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Bottom =  new Bottom(...);</c>
        /// <br/>
        /// <c>Bottom = "your css value(s) here";</c>
        /// <br/>
        /// <c>Bottom = BottomOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Bottom = Bottom;</c>
        /// <br/>
        /// <c>string cssValue = Bottom;</c>
        /// <br/>
        /// <c>BottomOptions option = Bottom;</c>
        /// </summary>
        public Bottom Bottom
        {
            get
            {
                if (!_css.ContainsKey("bottom"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Bottom");
                return _css["bottom"];
            }
            set
            {
                _css["bottom"] = value;
            }
        }

        /// <summary>
        /// A BoxDecorationBreak sets the style of element fragments. Fragments are the pieces that occur when an in-line element does not fit inside its container and needs to wrap.
        /// </summary>
        public BoxDecorationBreakOptions BoxDecorationBreak
        {
            get
            {
                var val = _css.ContainsKey("box-decoration-break") ? _css["box-decoration-break"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BoxDecorationBreak");
                var opt = (BoxDecorationBreakOptions)Keywords.GetOptionByKeyword<BoxDecorationBreakOptions>(val);
                return opt;
            }
            set
            {
                _css["box-decoration-break"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The BoxShadow property adds a shadow effect to an element. An element can have one or more box shadows.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>BoxShadow =  new BoxShadow(...);</c>
        /// <br/>
        /// <c>BoxShadow = "your css value(s) here";</c>
        /// <br/>
        /// <c>BoxShadow = BoxShadowOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_BoxShadow = BoxShadow;</c>
        /// <br/>
        /// <c>string cssValue = BoxShadow;</c>
        /// <br/>
        /// <c>BoxShadowOptions option = BoxShadow;</c>
        /// </summary>
        public BoxShadow BoxShadow
        {
            get
            {
                if (!_css.ContainsKey("box-shadow"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BoxShadow");
                return _css["box-shadow"];
            }
            set
            {
                _css["box-shadow"] = value;
            }
        }

        /// <summary>
        /// The BoxSizing property specifies how width and height are calculated. By default, padding and borders are excluded from these calculations. Element sizes may be calculated with or without padding and border values.
        /// </summary>
        public BoxSizingOptions BoxSizing
        {
            get
            {
                var val = _css.ContainsKey("box-sizing") ? _css["box-sizing"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: BoxSizing");
                var opt = (BoxSizingOptions)Keywords.GetOptionByKeyword<BoxSizingOptions>(val);
                return opt;
            }
            set
            {
                _css["box-sizing"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The CaptionSide property sets the position of a table caption. Options are the top or bottom of the table. By default, the caption is located at the bottom.
        /// </summary>
        public CaptionSideOptions CaptionSide
        {
            get
            {
                var val = _css.ContainsKey("caption-side") ? _css["caption-side"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: CaptionSide");
                var opt = (CaptionSideOptions)Keywords.GetOptionByKeyword<CaptionSideOptions>(val);
                return opt;
            }
            set
            {
                _css["caption-side"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The caret is the blinking indicator in input elements. The CaretColor property sets the color of the caret. Color values can be hex, rgb, hsl, rgba, hsla, or a color name.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>CaretColor =  new CaretColor(...);</c>
        /// <br/>
        /// <c>CaretColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>CaretColor = CaretColorOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_CaretColor = CaretColor;</c>
        /// <br/>
        /// <c>string cssValue = CaretColor;</c>
        /// <br/>
        /// <c>CaretColorOptions option = CaretColor;</c>
        /// </summary>
        public CaretColor CaretColor
        {
            get
            {
                if (!_css.ContainsKey("caret-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: CaretColor");
                return _css["caret-color"];
            }
            set
            {
                _css["caret-color"] = value;
            }
        }


        /// <summary>
        /// The Clear property removes the float effect. After Clearing the page flow will return back to normal.
        /// </summary>
        public ClearOptions Clear
        {
            get
            {
                var val = _css.ContainsKey("clear") ? _css["clear"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Clear");
                var opt = (ClearOptions)Keywords.GetOptionByKeyword<ClearOptions>(val);
                return opt;
            }
            set
            {
                _css["clear"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Clip property defines the visible region of an image. It does this by Clipping (or cropping) the element. This only works with position:absolute or position:fixed settings.
        /// </summary>
        public ClipOptions Clip
        {
            get
            {
                var val = _css.ContainsKey("clip") ? _css["clip"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Clip");
                var opt = (ClipOptions)Keywords.GetOptionByKeyword<ClipOptions>(val);
                return opt;
            }
            set
            {
                _css["clip"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Color property specifies the text Color of an element. Text decorations, such as underlines inherit the same Color. Color values can be hex, rgb, hsl, rgba, hsla, or a Color name.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Color =  new Color(...);</c>
        /// <br/>
        /// <c>Color = "your css value(s) here";</c>
        /// <br/>
        /// <c>Color = ColorOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Color = Color;</c>
        /// <br/>
        /// <c>string cssValue = Color;</c>
        /// <br/>
        /// <c>ColorOptions option = Color;</c>
        /// </summary>
        public Color Color
        {
            get
            {
                if (!_css.ContainsKey("color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Color");
                return _css["color"];
            }
            set
            {
                _css["color"] = value;
            }
        }

        /// <summary>
        /// The ColumnCount property partitions an element into columns. This property is used to create columns for long text content. Examples include articles, news, blogs, essays, and more.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>ColumnCount =  new ColumnCount(...);</c>
        /// <br/>
        /// <c>ColumnCount = "your css value(s) here";</c>
        /// <br/>
        /// <c>ColumnCount = ColumnCountOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_ColumnCount = ColumnCount;</c>
        /// <br/>
        /// <c>string cssValue = ColumnCount;</c>
        /// <br/>
        /// <c>ColumnCountOptions option = ColumnCount;</c>
        /// </summary>
        public ColumnCount ColumnCount
        {
            get
            {
                if (!_css.ContainsKey("column-count"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ColumnCount");
                return _css["column-count"];
            }
            set
            {
                _css["column-count"] = value;
            }
        }

        /// <summary>
        /// The ColumnFill property defines how columns are filled with text. One option is balance, in which column heights are equal. Another is auto, in which columns are filled by height first.
        /// </summary>
        public ColumnFillOptions ColumnFill
        {
            get
            {
                var val = _css.ContainsKey("column-fill") ? _css["column-fill"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ColumnFill");
                var opt = (ColumnFillOptions)Keywords.GetOptionByKeyword<ColumnFillOptions>(val);
                return opt;
            }
            set
            {
                _css["column-fill"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The ColumnGap property specifies the space between columns. The gap value can be any length value, including percentages. This property is used by column, flexbox and grid layout systems.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>ColumnGap =  new ColumnGap(...);</c>
        /// <br/>
        /// <c>ColumnGap = "your css value(s) here";</c>
        /// <br/>
        /// <c>ColumnGap = ColumnGapOptions.Normal;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_ColumnGap = ColumnGap;</c>
        /// <br/>
        /// <c>string cssValue = ColumnGap;</c>
        /// <br/>
        /// <c>ColumnGapOptions option = ColumnGap;</c>
        /// </summary>
        public ColumnGap ColumnGap
        {
            get
            {
                if (!_css.ContainsKey("column-gap"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ColumnGap");
                return _css["column-gap"];
            }
            set
            {
                _css["column-gap"] = value;
            }
        }

        /// <summary>
        /// A column rule is a line between columns in a multi-column layout. The ColumnRule property is a shorthand property that specifies the style, width, and color.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>ColumnRule =  new ColumnRule(...);</c>
        /// <br/>
        /// <c>ColumnRule = "your css value(s) here";</c>
        /// <br/>
        /// <c>ColumnRule = ColumnRuleOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_ColumnRule = ColumnRule;</c>
        /// <br/>
        /// <c>string cssValue = ColumnRule;</c>
        /// <br/>
        /// <c>ColumnRuleOptions option = ColumnRule;</c>
        /// </summary>
        public ColumnRule ColumnRule
        {
            get
            {
                if (!_css.ContainsKey("column-rule"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ColumnRule");
                return _css["column-rule"];
            }
            set
            {
                _css["column-rule"] = value;
            }
        }

        /// <summary>
        /// A column rule is a line between columns in a multi-column layout. The ColumnRuleColor property sets the color of this line. Color values can be hex, rgb, hsl, rgba, hsla, or a color name.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>ColumnRuleColor =  new ColumnRuleColor(...);</c>
        /// <br/>
        /// <c>ColumnRuleColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>ColumnRuleColor = ColumnRuleColorOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_ColumnRuleColor = ColumnRuleColor;</c>
        /// <br/>
        /// <c>string cssValue = ColumnRuleColor;</c>
        /// <br/>
        /// <c>ColumnRuleColorOptions option = ColumnRuleColor;</c>
        /// </summary>
        public ColumnRuleColor ColumnRuleColor
        {
            get
            {
                if (!_css.ContainsKey("column-rule-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ColumnRuleColor");
                return _css["column-rule-color"];
            }
            set
            {
                _css["column-rule-color"] = value;
            }
        }

        /// <summary>
        /// A column rule is a line between columns in a multi-column layout. The ColumnRuleStyle property sets the style of this line. Possible values include solid, dashed, dotted, double, etc.
        /// </summary>
        public ColumnRuleStyleOptions ColumnRuleStyle
        {
            get
            {
                var val = _css.ContainsKey("column-rule-style") ? _css["column-rule-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ColumnRuleStyle");
                var opt = (ColumnRuleStyleOptions)Keywords.GetOptionByKeyword<ColumnRuleStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["column-rule-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// A column rule is a line between columns in a multi-column layout. The ColumnRuleWidth property sets the width of this line. If no value is specified, it uses medium or 1px column width.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>ColumnRuleWidth =  new ColumnRuleWidth(...);</c>
        /// <br/>
        /// <c>ColumnRuleWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>ColumnRuleWidth = ColumnRuleWidthOptions.Medium;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_ColumnRuleWidth = ColumnRuleWidth;</c>
        /// <br/>
        /// <c>string cssValue = ColumnRuleWidth;</c>
        /// <br/>
        /// <c>ColumnRuleWidthOptions option = ColumnRuleWidth;</c>
        /// </summary>
        public ColumnRuleWidth ColumnRuleWidth
        {
            get
            {
                if (!_css.ContainsKey("column-rule-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ColumnRuleWidth");
                return _css["column-rule-width"];
            }
            set
            {
                _css["column-rule-width"] = value;
            }
        }

        /// <summary>
        /// The ColumnSpan property enables an element to span across columns. This property is used by headings that span multi-column layouts.
        /// </summary>
        public ColumnSpanOptions ColumnSpan
        {
            get
            {
                var val = _css.ContainsKey("column-span") ? _css["column-span"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ColumnSpan");
                var opt = (ColumnSpanOptions)Keywords.GetOptionByKeyword<ColumnSpanOptions>(val);
                return opt;
            }
            set
            {
                _css["column-span"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The ColumnWidth property sets the minimum width of a column. The browser then calculates the number of columns to fit the element. If the value exceeds the element width, a single column is rendered.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>ColumnWidth =  new ColumnWidth(...);</c>
        /// <br/>
        /// <c>ColumnWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>ColumnWidth = ColumnWidthOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_ColumnWidth = ColumnWidth;</c>
        /// <br/>
        /// <c>string cssValue = ColumnWidth;</c>
        /// <br/>
        /// <c>ColumnWidthOptions option = ColumnWidth;</c>
        /// </summary>
        public ColumnWidth ColumnWidth
        {
            get
            {
                if (!_css.ContainsKey("column-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ColumnWidth");
                return _css["column-width"];
            }
            set
            {
                _css["column-width"] = value;
            }
        }

        /// <summary>
        /// The Columns property divides an element into Columns. Its value includes a min column width and a number of Columns.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Columns =  new Columns(...);</c>
        /// <br/>
        /// <c>Columns = "your css value(s) here";</c>
        /// <br/>
        /// <c>Columns = ColumnsOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Columns = Columns;</c>
        /// <br/>
        /// <c>string cssValue = Columns;</c>
        /// <br/>
        /// <c>ColumnsOptions option = Columns;</c>
        /// </summary>
        public Columns Columns
        {
            get
            {
                if (!_css.ContainsKey("columns"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Columns");
                return _css["columns"];
            }
            set
            {
                _css["columns"] = value;
            }
        }

        /// <summary>
        /// The Content property inserts Content before or after an element. It uses the ::before and ::after pseudo-elements with this. Content can be a string, a symbol, or an image.
        ///<br/>
        ///<br/>
        /// <c>NOTE:</c> Content can be string or non string. for string value you should use single quotation marks ' ' or double quoation marks " ". 
        /// <br/>
        /// <br/>
        /// Example:
        /// <br/>
        /// <c><see cref="Content"/> = "'some string values'";</c>.
        /// <br/>
        /// OR
        /// <br/>
        /// <c><see cref="Content"/> = @"""some string values""";</c>.
        /// </summary>
        public string Content
        {
            get
            {
                if (!_css.ContainsKey("content"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Content");
                return _css["content"];
            }
            set
            {
                _css["content"] = value;
            }
        }

        /// <summary>
        /// The CounterIncrement property increases a CSS counter value. This property works with counter-reset and content properties.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>CounterIncrement =  new CounterIncrement(...);</c>
        /// <br/>
        /// <c>CounterIncrement = "your css value(s) here";</c>
        /// <br/>
        /// <c>CounterIncrement = CounterIncrementOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_CounterIncrement = CounterIncrement;</c>
        /// <br/>
        /// <c>string cssValue = CounterIncrement;</c>
        /// <br/>
        /// <c>CounterIncrementOptions option = CounterIncrement;</c>
        /// </summary>
        public CounterIncrement CounterIncrement
        {
            get
            {
                if (!_css.ContainsKey("counter-increment"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: CounterIncrement");
                return _css["counter-increment"];
            }
            set
            {
                _css["counter-increment"] = value;
            }
        }

        /// <summary>
        /// A counter is an incrementing variable that can be used in CSS. The CounterReset property resets a CSS counter value. This property works together with counter-increment and content.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>CounterReset =  new CounterReset(...);</c>
        /// <br/>
        /// <c>CounterReset = "your css value(s) here";</c>
        /// <br/>
        /// <c>CounterReset = CounterResetOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_CounterReset = CounterReset;</c>
        /// <br/>
        /// <c>string cssValue = CounterReset;</c>
        /// <br/>
        /// <c>CounterResetOptions option = CounterReset;</c>
        /// </summary>
        public CounterReset CounterReset
        {
            get
            {
                if (!_css.ContainsKey("counter-reset"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: CounterReset");
                return _css["counter-reset"];
            }
            set
            {
                _css["counter-reset"] = value;
            }
        }

        /// <summary>
        /// The Cursor property defines a mouse Cursor for an element. The Cursor value can be a keyword or an image. The Cursor appears when the pointer hovers over the element.
        /// </summary>
        public CursorOptions Cursor
        {
            get
            {
                var val = _css.ContainsKey("cursor") ? _css["cursor"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Cursor");
                var opt = (CursorOptions)Keywords.GetOptionByKeyword<CursorOptions>(val);
                return opt;
            }
            set
            {
                _css["cursor"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Direction property specifies the text writing Direction. This property is useful for languages that are written right-to-left. These include Urdu, Arabic, Kurdish, Persian, and Hebrew.
        /// </summary>
        public DirectionOptions Direction
        {
            get
            {
                var val = _css.ContainsKey("direction") ? _css["direction"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Direction");
                var opt = (DirectionOptions)Keywords.GetOptionByKeyword<DirectionOptions>(val);
                return opt;
            }
            set
            {
                _css["direction"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Display property sets an element's Display behavior. Common values include block, inline, flex, and grid. Its value determines how the element participates in the page flow.
        /// </summary>
        public DisplayOptions Display
        {
            get
            {
                var val = _css.ContainsKey("display") ? _css["display"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Display");
                var opt = (DisplayOptions)Keywords.GetOptionByKeyword<DisplayOptions>(val);
                return opt;
            }
            set
            {
                _css["display"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The EmptyCells property sets borders on empty table cells. The setting only affects the borders, not the space the cells occupy.
        /// </summary>
        public EmptyCellsOptions EmptyCells
        {
            get
            {
                var val = _css.ContainsKey("empty-cells") ? _css["empty-cells"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: EmptyCells");
                var opt = (EmptyCellsOptions)Keywords.GetOptionByKeyword<EmptyCellsOptions>(val);
                return opt;
            }
            set
            {
                _css["empty-cells"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Filter property adds visual effects to images. Filter effects include blur, color shift, grayscale, drop-shadow, etc. The Filter property can also be used for backgrounds and borders.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Filter =  new Filter(...);</c>
        /// <br/>
        /// <c>Filter = "your css value(s) here";</c>
        /// <br/>
        /// <c>Filter = FilterOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Filter = Filter;</c>
        /// <br/>
        /// <c>string cssValue = Filter;</c>
        /// <br/>
        /// <c>FilterOptions option = Filter;</c>
        /// </summary>
        public Filter Filter
        {
            get
            {
                if (!_css.ContainsKey("filter"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Filter");
                return _css["filter"];
            }
            set
            {
                _css["filter"] = value;
            }
        }

        /// <summary>
        /// The Flex property is a shorthand for 3 Flex item properties: They are: Flex-grow, Flex-shrink, and Flex-basis. This property is commonly used to create responsive layouts.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Flex =  new Flex(...);</c>
        /// <br/>
        /// <c>Flex = "your css value(s) here";</c>
        /// <br/>
        /// <c>Flex = FlexOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Flex = Flex;</c>
        /// <br/>
        /// <c>string cssValue = Flex;</c>
        /// <br/>
        /// <c>FlexOptions option = Flex;</c>
        /// </summary>
        public Flex Flex
        {
            get
            {
                if (!_css.ContainsKey("flex"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Flex");
                return _css["flex"];
            }
            set
            {
                _css["flex"] = value;
            }
        }

        /// <summary>
        /// The FlexBasis property sets the initial width of a flex item. Flex items are elements inside a flex container.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>FlexBasis =  new FlexBasis(...);</c>
        /// <br/>
        /// <c>FlexBasis = "your css value(s) here";</c>
        /// <br/>
        /// <c>FlexBasis = FlexBasisOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_FlexBasis = FlexBasis;</c>
        /// <br/>
        /// <c>string cssValue = FlexBasis;</c>
        /// <br/>
        /// <c>FlexBasisOptions option = FlexBasis;</c>
        /// </summary>
        public FlexBasis FlexBasis
        {
            get
            {
                if (!_css.ContainsKey("flex-basis"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FlexBasis");
                return _css["flex-basis"];
            }
            set
            {
                _css["flex-basis"] = value;
            }
        }

        /// <summary>
        /// FlexDirection specifies the the pack direction of flex items. Items can be packed row-wise, column-wise, and in reverse order. By default, flex items are packed in rows.
        /// </summary>
        public FlexDirectionOptions FlexDirection
        {
            get
            {
                var val = _css.ContainsKey("flex-direction") ? _css["flex-direction"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FlexDirection");
                var opt = (FlexDirectionOptions)Keywords.GetOptionByKeyword<FlexDirectionOptions>(val);
                return opt;
            }
            set
            {
                _css["flex-direction"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The FlexFlow property is a shortcut for two flex properties. They are flex-direction and flex-wrap.
        /// </summary>
        public FlexFlowOptions FlexFlow
        {
            get
            {
                var val = _css.ContainsKey("flex-flow") ? _css["flex-flow"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FlexFlow");
                var opt = (FlexFlowOptions)Keywords.GetOptionByKeyword<FlexFlowOptions>(val);
                return opt;
            }
            set
            {
                _css["flex-flow"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The FlexGrow property sets the growth factor for a flex item. This setting is relevant when space is left inside a container. FlexGrow sets the growth relative to other items.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>FlexGrow =  new FlexGrow(...);</c>
        /// <br/>
        /// <c>FlexGrow = "your css value(s) here";</c>
        /// <br/>
        /// <c>FlexGrow = FlexGrowOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_FlexGrow = FlexGrow;</c>
        /// <br/>
        /// <c>string cssValue = FlexGrow;</c>
        /// <br/>
        /// <c>FlexGrowOptions option = FlexGrow;</c>
        /// </summary>
        public FlexGrow FlexGrow
        {
            get
            {
                if (!_css.ContainsKey("flex-grow"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FlexGrow");
                return _css["flex-grow"];
            }
            set
            {
                _css["flex-grow"] = value;
            }
        }

        /// <summary>
        /// The FlexShrink property sets the shrink factor for a flex item. This is relevant when items do not fit inside a container. FlexShrink sets the shrinkage relative to other items.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>FlexShrink =  new FlexShrink(...);</c>
        /// <br/>
        /// <c>FlexShrink = "your css value(s) here";</c>
        /// <br/>
        /// <c>FlexShrink = FlexShrinkOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_FlexShrink = FlexShrink;</c>
        /// <br/>
        /// <c>string cssValue = FlexShrink;</c>
        /// <br/>
        /// <c>FlexShrinkOptions option = FlexShrink;</c>
        /// </summary>
        public FlexShrink FlexShrink
        {
            get
            {
                if (!_css.ContainsKey("flex-shrink"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FlexShrink");
                return _css["flex-shrink"];
            }
            set
            {
                _css["flex-shrink"] = value;
            }
        }

        /// <summary>
        /// The FlexWrap property sets how items wrap in a container. By default, flex items do not wrap and are packed in a single row.
        /// </summary>
        public FlexWrapOptions FlexWrap
        {
            get
            {
                var val = _css.ContainsKey("flex-wrap") ? _css["flex-wrap"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FlexWrap");
                var opt = (FlexWrapOptions)Keywords.GetOptionByKeyword<FlexWrapOptions>(val);
                return opt;
            }
            set
            {
                _css["flex-wrap"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Float property aligns an element in a container. An element can align (Float) to the left or the right. This property is useful for images with wrapped text.
        /// </summary>
        public FloatOptions Float
        {
            get
            {
                var val = _css.ContainsKey("float") ? _css["float"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Float");
                var opt = (FloatOptions)Keywords.GetOptionByKeyword<FloatOptions>(val);
                return opt;
            }
            set
            {
                _css["float"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Font property specifies several Font styling settings. These include Font, color, height, style, weight, and more.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Font =  new Font(...);</c>
        /// <br/>
        /// <c>Font = "your css value(s) here";</c>
        /// <br/>
        /// <c>Font = FontOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Font = Font;</c>
        /// <br/>
        /// <c>string cssValue = Font;</c>
        /// <br/>
        /// <c>FontOptions option = Font;</c>
        /// </summary>
        public Font Font
        {
            get
            {
                if (!_css.ContainsKey("font"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Font");
                return _css["font"];
            }
            set
            {
                _css["font"] = value;
            }
        }

        /// <summary>
        /// The FontFamily property specifies the font to use for text. The value can be any number of font names. All but the first font are fallback fonts. A fallback will be used if the first font is not supported.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>FontFamily =  new FontFamily(...);</c>
        /// <br/>
        /// <c>FontFamily = "your css value(s) here";</c>
        /// <br/>
        /// <c>FontFamily = FontFamilyOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_FontFamily = FontFamily;</c>
        /// <br/>
        /// <c>string cssValue = FontFamily;</c>
        /// <br/>
        /// <c>FontFamilyOptions option = FontFamily;</c>
        /// </summary>
        public FontFamily FontFamily
        {
            get
            {
                if (!_css.ContainsKey("font-family"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FontFamily");
                return _css["font-family"];
            }
            set
            {
                _css["font-family"] = value;
            }
        }

        /// <summary>
        /// Kerning is the spacing between letters. It's part of the font file. It can make text easier and more pleasing to read. The FontKerning property enables kerning.
        /// </summary>
        public FontKerningOptions FontKerning
        {
            get
            {
                var val = _css.ContainsKey("font-kerning") ? _css["font-kerning"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FontKerning");
                var opt = (FontKerningOptions)Keywords.GetOptionByKeyword<FontKerningOptions>(val);
                return opt;
            }
            set
            {
                _css["font-kerning"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The FontSize property defines the text size. It accepts any length value, such as, px, %, em, and others. Keywords, such as, small, larger, and x-large are also accepted.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>FontSize =  new FontSize(...);</c>
        /// <br/>
        /// <c>FontSize = "your css value(s) here";</c>
        /// <br/>
        /// <c>FontSize = FontSizeOptions.Medium;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_FontSize = FontSize;</c>
        /// <br/>
        /// <c>string cssValue = FontSize;</c>
        /// <br/>
        /// <c>FontSizeOptions option = FontSize;</c>
        /// </summary>
        public FontSize FontSize
        {
            get
            {
                if (!_css.ContainsKey("font-size"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FontSize");
                return _css["font-size"];
            }
            set
            {
                _css["font-size"] = value;
            }
        }

        /// <summary>
        /// The FontSizeAdjust property gives you better control of the font size when the first selected font is not available.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>FontSizeAdjust =  new FontSizeAdjust(...);</c>
        /// <br/>
        /// <c>FontSizeAdjust = "your css value(s) here";</c>
        /// <br/>
        /// <c>FontSizeAdjust = FontSizeAdjustOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_FontSizeAdjust = FontSizeAdjust;</c>
        /// <br/>
        /// <c>string cssValue = FontSizeAdjust;</c>
        /// <br/>
        /// <c>FontSizeAdjustOptions option = FontSizeAdjust;</c>
        /// </summary>
        public FontSizeAdjust FontSizeAdjust
        {
            get
            {
                if (!_css.ContainsKey("font-size-adjust"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FontSizeAdjust");
                return _css["font-size-adjust"];
            }
            set
            {
                _css["font-size-adjust"] = value;
            }
        }

        /// <summary>
        /// The FontStretch property widens or narrows text. The font used must support condensed and expanded font faces. Many fonts do not support these separate faces.
        /// </summary>
        public FontStretchOptions FontStretch
        {
            get
            {
                var val = _css.ContainsKey("font-stretch") ? _css["font-stretch"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FontStretch");
                var opt = (FontStretchOptions)Keywords.GetOptionByKeyword<FontStretchOptions>(val);
                return opt;
            }
            set
            {
                _css["font-stretch"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The FontStyle property specifies the style of the font. Fonts can be styled as normal, italic, or oblique.
        /// </summary>
        public FontStyleOptions FontStyle
        {
            get
            {
                var val = _css.ContainsKey("font-style") ? _css["font-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FontStyle");
                var opt = (FontStyleOptions)Keywords.GetOptionByKeyword<FontStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["font-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The FontVariant property displays text in small-caps font. Small caps are uppercase letters, but in a smaller font size.
        /// </summary>
        public FontVariantOptions FontVariant
        {
            get
            {
                var val = _css.ContainsKey("font-variant") ? _css["font-variant"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FontVariant");
                var opt = (FontVariantOptions)Keywords.GetOptionByKeyword<FontVariantOptions>(val);
                return opt;
            }
            set
            {
                _css["font-variant"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The FontWeight property specifies the thickness of the text. Text can be displayed in light, normal, bold, bolder, etc. Values can be built-in names, or a number from 100 - 900.
        /// </summary>
        public FontWeightOptions FontWeight
        {
            get
            {
                var val = _css.ContainsKey("font-weight") ? _css["font-weight"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: FontWeight");
                var opt = (FontWeightOptions)Keywords.GetOptionByKeyword<FontWeightOptions>(val);
                return opt;
            }
            set
            {
                _css["font-weight"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Grid property defines a Grid layout. It specifies rows, columns, and areas by name and position. This property is a shorthand for several Grid settings.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Grid =  new Grid(...);</c>
        /// <br/>
        /// <c>Grid = "your css value(s) here";</c>
        /// <br/>
        /// <c>Grid = GridOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Grid = Grid;</c>
        /// <br/>
        /// <c>string cssValue = Grid;</c>
        /// <br/>
        /// <c>GridOptions option = Grid;</c>
        /// </summary>
        public Grid Grid
        {
            get
            {
                if (!_css.ContainsKey("grid"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Grid");
                return _css["grid"];
            }
            set
            {
                _css["grid"] = value;
            }
        }
        /// <summary>
        /// A grid area is an area that covers multiple grid cells. The GridArea property defines the boundaries for the area. It is specified as start-row / start-column / end-row / end-column.
        /// </summary>
        public string GridArea
        {
            get
            {
                if (!_css.ContainsKey("grid-area"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridArea");
                return _css["grid-area"];
            }
            set
            {
                _css["grid-area"] = value;
            }
        }

        /// <summary>
        /// The GridAutoColumns property sets the column sizes in a grid. The value represents the minimum width of a grid item. Options include a length value, or auto, min-content, minmax, etc.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridAutoColumns =  new GridAutoColumns(...);</c>
        /// <br/>
        /// <c>GridAutoColumns = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridAutoColumns = GridAutoColumnsOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridAutoColumns = GridAutoColumns;</c>
        /// <br/>
        /// <c>string cssValue = GridAutoColumns;</c>
        /// <br/>
        /// <c>GridAutoColumnsOptions option = GridAutoColumns;</c>
        /// </summary>
        public GridAutoColumns GridAutoColumns
        {
            get
            {
                if (!_css.ContainsKey("grid-auto-columns"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridAutoColumns");
                return _css["grid-auto-columns"];
            }
            set
            {
                _css["grid-auto-columns"] = value;
            }
        }

        /// <summary>
        /// The GridAutoFlow specifies the placement of items in a grid. By default, grid items will flow in rows, from left to right. Other options include column, row dense, etc.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridAutoFlow =  new GridAutoFlow(...);</c>
        /// <br/>
        /// <c>GridAutoFlow = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridAutoFlow = GridAutoFlowOptions.Row;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridAutoFlow = GridAutoFlow;</c>
        /// <br/>
        /// <c>string cssValue = GridAutoFlow;</c>
        /// <br/>
        /// <c>GridAutoFlowOptions option = GridAutoFlow;</c>
        /// </summary>
        public GridAutoFlow GridAutoFlow
        {
            get
            {
                if (!_css.ContainsKey("grid-auto-flow"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridAutoFlow");
                return _css["grid-auto-flow"];
            }
            set
            {
                _css["grid-auto-flow"] = value;
            }
        }

        /// <summary>
        /// The GridAutoRows property sets the row sizes in a grid. The value represents the minimum height of a grid item. Values include a length value, or auto, min-content, etc.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridAutoRows =  new GridAutoRows(...);</c>
        /// <br/>
        /// <c>GridAutoRows = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridAutoRows = GridAutoRowsOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridAutoRows = GridAutoRows;</c>
        /// <br/>
        /// <c>string cssValue = GridAutoRows;</c>
        /// <br/>
        /// <c>GridAutoRowsOptions option = GridAutoRows;</c>
        /// </summary>
        public GridAutoRows GridAutoRows
        {
            get
            {
                if (!_css.ContainsKey("grid-auto-rows"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridAutoRows");
                return _css["grid-auto-rows"];
            }
            set
            {
                _css["grid-auto-rows"] = value;
            }
        }
        /// <summary>
        /// The GridColumn property sets the start and end of a grid item. This setting allows an item to stretch over multiple columns. The end is either a column number, or the number of columns.
        /// </summary>
        public string GridColumn
        {
            get
            {
                if (!_css.ContainsKey("grid-column"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridColumn");
                return _css["grid-column"];
            }
            set
            {
                _css["grid-column"] = value;
            }
        }

        /// <summary>
        /// The GridColumnEnd property sets the end column for a grid item. The value can also be a range of columns with a span n value Columns with insufficient or no items will be left blank or empty.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridColumnEnd =  new GridColumnEnd(...);</c>
        /// <br/>
        /// <c>GridColumnEnd = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridColumnEnd = GridColumnEndOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridColumnEnd = GridColumnEnd;</c>
        /// <br/>
        /// <c>string cssValue = GridColumnEnd;</c>
        /// <br/>
        /// <c>GridColumnEndOptions option = GridColumnEnd;</c>
        /// </summary>
        public GridColumnEnd GridColumnEnd
        {
            get
            {
                if (!_css.ContainsKey("grid-column-end"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridColumnEnd");
                return _css["grid-column-end"];
            }
            set
            {
                _css["grid-column-end"] = value;
            }
        }
        /// <summary>
        /// The GridColumnGap is the space between the columns in a grid. This property accepts any length value, such as, px, %, em, and others. The default is 0, meaning there is no gap between the columns.
        /// </summary>
        public string GridColumnGap
        {
            get
            {
                if (!_css.ContainsKey("grid-column-gap"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridColumnGap");
                return _css["grid-column-gap"];
            }
            set
            {
                _css["grid-column-gap"] = value;
            }
        }

        /// <summary>
        /// The GridColumnStart sets the start column of a grid item. Its value can also be a range of columns with span n. Columns with insufficient or no items will be left blank or empty.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridColumnStart =  new GridColumnStart(...);</c>
        /// <br/>
        /// <c>GridColumnStart = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridColumnStart = GridColumnStartOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridColumnStart = GridColumnStart;</c>
        /// <br/>
        /// <c>string cssValue = GridColumnStart;</c>
        /// <br/>
        /// <c>GridColumnStartOptions option = GridColumnStart;</c>
        /// </summary>
        public GridColumnStart GridColumnStart
        {
            get
            {
                if (!_css.ContainsKey("grid-column-start"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridColumnStart");
                return _css["grid-column-start"];
            }
            set
            {
                _css["grid-column-start"] = value;
            }
        }
        /// <summary>
        /// The GridGap is the space between grid rows and columns. It accepts any length value, such as, px, %, em, and others. The default is 0, meaning no gaps between rows and columns.
        /// </summary>
        public string GridGap
        {
            get
            {
                if (!_css.ContainsKey("grid-gap"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridGap");
                return _css["grid-gap"];
            }
            set
            {
                _css["grid-gap"] = value;
            }
        }
        /// <summary>
        /// The GridRow property sets the start and end row of a grid item. This setting allows an item to stretch over multiple rows. The value is either a row number, or the number of rows the item spans.
        /// </summary>
        public string GridRow
        {
            get
            {
                if (!_css.ContainsKey("grid-row"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridRow");
                return _css["grid-row"];
            }
            set
            {
                _css["grid-row"] = value;
            }
        }

        /// <summary>
        /// The GridRowEnd property sets the end row for a grid item. The value can also be a range of rows with a span n value Rows with insufficient or no items will be left blank or empty.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridRowEnd =  new GridRowEnd(...);</c>
        /// <br/>
        /// <c>GridRowEnd = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridRowEnd = GridRowEndOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridRowEnd = GridRowEnd;</c>
        /// <br/>
        /// <c>string cssValue = GridRowEnd;</c>
        /// <br/>
        /// <c>GridRowEndOptions option = GridRowEnd;</c>
        /// </summary>
        public GridRowEnd GridRowEnd
        {
            get
            {
                if (!_css.ContainsKey("grid-row-end"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridRowEnd");
                return _css["grid-row-end"];
            }
            set
            {
                _css["grid-row-end"] = value;
            }
        }
        /// <summary>
        /// The GridRowGap sets the space between the grid rows. It accepts any length value, such as, px, %, em, and others. The default is 0, meaning there is no gap between the rows.
        /// </summary>
        public string GridRowGap
        {
            get
            {
                if (!_css.ContainsKey("grid-row-gap"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridRowGap");
                return _css["grid-row-gap"];
            }
            set
            {
                _css["grid-row-gap"] = value;
            }
        }

        /// <summary>
        /// The GridRowStart sets the start row of a grid item. The value can also be a range of rows with a span n value. Rows with insufficient or no items will be left blank or empty.
        /// </summary>
        public GridRowStartOptions GridRowStart
        {
            get
            {
                var val = _css.ContainsKey("grid-row-start") ? _css["grid-row-start"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridRowStart");
                var opt = (GridRowStartOptions)Keywords.GetOptionByKeyword<GridRowStartOptions>(val);
                return opt;
            }
            set
            {
                _css["grid-row-start"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// Grid is a layout system that uses a grid with rows and columns. A GridTemplate defines rows, columns, and areas in a grid layout. It's a shorthand for 3 properties that define rows, columns, and areas.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridTemplate =  new GridTemplate(...);</c>
        /// <br/>
        /// <c>GridTemplate = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridTemplate = GridTemplateOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridTemplate = GridTemplate;</c>
        /// <br/>
        /// <c>string cssValue = GridTemplate;</c>
        /// <br/>
        /// <c>GridTemplateOptions option = GridTemplate;</c>
        /// </summary>
        public GridTemplate GridTemplate
        {
            get
            {
                if (!_css.ContainsKey("grid-template"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridTemplate");
                return _css["grid-template"];
            }
            set
            {
                _css["grid-template"] = value;
            }
        }

        /// <summary>
        /// Grid is a layout system that uses a grid with rows and columns. The GridTemplateAreas property defines named grid areas. The value is a sequence of names that define rows and columns.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridTemplateAreas =  new GridTemplateAreas(...);</c>
        /// <br/>
        /// <c>GridTemplateAreas = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridTemplateAreas = GridTemplateAreasOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridTemplateAreas = GridTemplateAreas;</c>
        /// <br/>
        /// <c>string cssValue = GridTemplateAreas;</c>
        /// <br/>
        /// <c>GridTemplateAreasOptions option = GridTemplateAreas;</c>
        /// </summary>
        public GridTemplateAreas GridTemplateAreas
        {
            get
            {
                if (!_css.ContainsKey("grid-template-areas"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridTemplateAreas");
                return _css["grid-template-areas"];
            }
            set
            {
                _css["grid-template-areas"] = value;
            }
        }

        /// <summary>
        /// Grid is a layout system that uses a grid with rows and columns. The GridTemplateColumns property defines grid columns. The value is a space-separated list with column widths.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridTemplateColumns =  new GridTemplateColumns(...);</c>
        /// <br/>
        /// <c>GridTemplateColumns = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridTemplateColumns = GridTemplateColumnsOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridTemplateColumns = GridTemplateColumns;</c>
        /// <br/>
        /// <c>string cssValue = GridTemplateColumns;</c>
        /// <br/>
        /// <c>GridTemplateColumnsOptions option = GridTemplateColumns;</c>
        /// </summary>
        public GridTemplateColumns GridTemplateColumns
        {
            get
            {
                if (!_css.ContainsKey("grid-template-columns"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridTemplateColumns");
                return _css["grid-template-columns"];
            }
            set
            {
                _css["grid-template-columns"] = value;
            }
        }

        /// <summary>
        /// Grid is a layout system that uses a grid with rows and columns. The GridTemplateRows property specifies grid rows. The value is a space-separated list with row heights.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>GridTemplateRows =  new GridTemplateRows(...);</c>
        /// <br/>
        /// <c>GridTemplateRows = "your css value(s) here";</c>
        /// <br/>
        /// <c>GridTemplateRows = GridTemplateRowsOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_GridTemplateRows = GridTemplateRows;</c>
        /// <br/>
        /// <c>string cssValue = GridTemplateRows;</c>
        /// <br/>
        /// <c>GridTemplateRowsOptions option = GridTemplateRows;</c>
        /// </summary>
        public GridTemplateRows GridTemplateRows
        {
            get
            {
                if (!_css.ContainsKey("grid-template-rows"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: GridTemplateRows");
                return _css["grid-template-rows"];
            }
            set
            {
                _css["grid-template-rows"] = value;
            }
        }

        /// <summary>
        /// The HangingPunctuation property specifies whether a punctuation mark may be placed outside the line box at the start or at the end of a full line of text.
        /// <code>NOTE: NON OF ALL MOJAR BROWSERS SUPPORT THIS. ONLY SAFARI 10+ SUPPORTS. BECAREFUL!</code>
        /// </summary>
        public HangingPunctuationOptions HangingPunctuation
        {
            get
            {
                var val = _css.ContainsKey("hanging-punctuation") ? _css["hanging-punctuation"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: HangingPunctuation");
                var opt = (HangingPunctuationOptions)Keywords.GetOptionByKeyword<HangingPunctuationOptions>(val);
                return opt;
            }
            set
            {
                _css["hanging-punctuation"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Height property specifies the Height of an element. Height is calculated without the padding, margin, or border. This property accepts any length value (e.g. px, %, cm)
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Height =  new Height(...);</c>
        /// <br/>
        /// <c>Height = "your css value(s) here";</c>
        /// <br/>
        /// <c>Height = HeightOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Height = Height;</c>
        /// <br/>
        /// <c>string cssValue = Height;</c>
        /// <br/>
        /// <c>HeightOptions option = Height;</c>
        /// </summary>
        public Height Height
        {
            get
            {
                if (!_css.ContainsKey("height"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Height");
                return _css["height"];
            }
            set
            {
                _css["height"] = value;
            }
        }

        /// <summary>
        /// The Hyphens property specifies how words break at the end of a line. One option is to hyphenate, with a hyphen (-), at specified text positions. Another is to disallow hyphenation, or let the browser handle it entirely.
        /// </summary>
        public HyphensOptions Hyphens
        {
            get
            {
                var val = _css.ContainsKey("hyphens") ? _css["hyphens"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Hyphens");
                var opt = (HyphensOptions)Keywords.GetOptionByKeyword<HyphensOptions>(val);
                return opt;
            }
            set
            {
                _css["hyphens"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Isolation property defines whether an element must create a new stacking content.
        /// </summary>
        public IsolationOptions Isolation
        {
            get
            {
                var val = _css.ContainsKey("isolation") ? _css["isolation"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Isolation");
                var opt = (IsolationOptions)Keywords.GetOptionByKeyword<IsolationOptions>(val);
                return opt;
            }
            set
            {
                _css["isolation"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The JustifyContent property aligns items in a flex container. This property only has effect when space is available. The grid layout system can also use this property.
        /// </summary>
        public JustifyContentOptions JustifyContent
        {
            get
            {
                var val = _css.ContainsKey("justify-content") ? _css["justify-content"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: JustifyContent");
                var opt = (JustifyContentOptions)Keywords.GetOptionByKeyword<JustifyContentOptions>(val);
                return opt;
            }
            set
            {
                _css["justify-content"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Left property specifies the horizontal position of a positioned element. Positioned elements have a position, such as absolute, sticky, etc. The effect of the Left setting depends on the position value.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Left =  new Left(...);</c>
        /// <br/>
        /// <c>Left = "your css value(s) here";</c>
        /// <br/>
        /// <c>Left = LeftOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Left = Left;</c>
        /// <br/>
        /// <c>string cssValue = Left;</c>
        /// <br/>
        /// <c>LeftOptions option = Left;</c>
        /// </summary>
        public Left Left
        {
            get
            {
                if (!_css.ContainsKey("left"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Left");
                return _css["left"];
            }
            set
            {
                _css["left"] = value;
            }
        }

        /// <summary>
        /// LetterSpacing specifies the spacing between text characters. This property accepts any length value, such as, px, pt, em, etc. Both positive and negative values are allowed.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>LetterSpacing =  new LetterSpacing(...);</c>
        /// <br/>
        /// <c>LetterSpacing = "your css value(s) here";</c>
        /// <br/>
        /// <c>LetterSpacing = LetterSpacingOptions.Normal;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_LetterSpacing = LetterSpacing;</c>
        /// <br/>
        /// <c>string cssValue = LetterSpacing;</c>
        /// <br/>
        /// <c>LetterSpacingOptions option = LetterSpacing;</c>
        /// </summary>
        public LetterSpacing LetterSpacing
        {
            get
            {
                if (!_css.ContainsKey("letter-spacing"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: LetterSpacing");
                return _css["letter-spacing"];
            }
            set
            {
                _css["letter-spacing"] = value;
            }
        }

        /// <summary>
        /// The LineHeight property specifies the height of a line of text. Higher values create text with more space between the lines. And lower values create lines that are closer to each other.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>LineHeight =  new LineHeight(...);</c>
        /// <br/>
        /// <c>LineHeight = "your css value(s) here";</c>
        /// <br/>
        /// <c>LineHeight = LineHeightOptions.Normal;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_LineHeight = LineHeight;</c>
        /// <br/>
        /// <c>string cssValue = LineHeight;</c>
        /// <br/>
        /// <c>LineHeightOptions option = LineHeight;</c>
        /// </summary>
        public LineHeight LineHeight
        {
            get
            {
                if (!_css.ContainsKey("line-height"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: LineHeight");
                return _css["line-height"];
            }
            set
            {
                _css["line-height"] = value;
            }
        }

        /// <summary>
        /// Markers are the bullets on a list of items. The ListStyle property specifies the markers for the items. This includes marker type, position, and, optionally, an image.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>ListStyle =  new ListStyle(...);</c>
        /// <br/>
        /// <c>ListStyle = "your css value(s) here";</c>
        /// <br/>
        /// <c>ListStyle = ListStyleOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_ListStyle = ListStyle;</c>
        /// <br/>
        /// <c>string cssValue = ListStyle;</c>
        /// <br/>
        /// <c>ListStyleOptions option = ListStyle;</c>
        /// </summary>
        public ListStyle ListStyle
        {
            get
            {
                if (!_css.ContainsKey("list-style"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ListStyle");
                return _css["list-style"];
            }
            set
            {
                _css["list-style"] = value;
            }
        }

        /// <summary>
        /// Markers are the bullets on a list with items. The ListStyleImage property uses an image as marker. The image marker displays as is, and cannot be resized.
        /// </summary>
        public ListStyleImageOptions ListStyleImage
        {
            get
            {
                var val = _css.ContainsKey("list-style-image") ? _css["list-style-image"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ListStyleImage");
                var opt = (ListStyleImageOptions)Keywords.GetOptionByKeyword<ListStyleImageOptions>(val);
                return opt;
            }
            set
            {
                _css["list-style-image"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// Markers are the bullets on a list with items. The ListStylePosition property specifies a marker position. They can be displayed inside or outside the list items.
        /// </summary>
        public ListStylePositionOptions ListStylePosition
        {
            get
            {
                var val = _css.ContainsKey("list-style-position") ? _css["list-style-position"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ListStylePosition");
                var opt = (ListStylePositionOptions)Keywords.GetOptionByKeyword<ListStylePositionOptions>(val);
                return opt;
            }
            set
            {
                _css["list-style-position"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// Markers are the bullets or numeric values on a list with items. The ListStyleType property defines the type of marker.
        /// </summary>
        public ListStyleTypeOptions ListStyleType
        {
            get
            {
                var val = _css.ContainsKey("list-style-type") ? _css["list-style-type"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ListStyleType");
                var opt = (ListStyleTypeOptions)Keywords.GetOptionByKeyword<ListStyleTypeOptions>(val);
                return opt;
            }
            set
            {
                _css["list-style-type"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// Margin is the spacing outside an element. The Margin property specifies the element‘s Margins.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Margin =  new Margin(...);</c>
        /// <br/>
        /// <c>Margin = "your css value(s) here";</c>
        /// <br/>
        /// <c>Margin = MarginOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Margin = Margin;</c>
        /// <br/>
        /// <c>string cssValue = Margin;</c>
        /// <br/>
        /// <c>MarginOptions option = Margin;</c>
        /// </summary>
        public Margin Margin
        {
            get
            {
                if (!_css.ContainsKey("margin"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Margin");
                return _css["margin"];
            }
            set
            {
                _css["margin"] = value;
            }
        }

        /// <summary>
        /// Margin is the spacing outside an element. The MarginBottom property specifies the bottom margin of an element.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>MarginBottom =  new MarginBottom(...);</c>
        /// <br/>
        /// <c>MarginBottom = "your css value(s) here";</c>
        /// <br/>
        /// <c>MarginBottom = MarginBottomOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_MarginBottom = MarginBottom;</c>
        /// <br/>
        /// <c>string cssValue = MarginBottom;</c>
        /// <br/>
        /// <c>MarginBottomOptions option = MarginBottom;</c>
        /// </summary>
        public MarginBottom MarginBottom
        {
            get
            {
                if (!_css.ContainsKey("margin-bottom"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: MarginBottom");
                return _css["margin-bottom"];
            }
            set
            {
                _css["margin-bottom"] = value;
            }
        }

        /// <summary>
        /// Margin is the spacing outside an element. The MarginLeft property specifies the left margin of an element.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>MarginLeft =  new MarginLeft(...);</c>
        /// <br/>
        /// <c>MarginLeft = "your css value(s) here";</c>
        /// <br/>
        /// <c>MarginLeft = MarginLeftOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_MarginLeft = MarginLeft;</c>
        /// <br/>
        /// <c>string cssValue = MarginLeft;</c>
        /// <br/>
        /// <c>MarginLeftOptions option = MarginLeft;</c>
        /// </summary>
        public MarginLeft MarginLeft
        {
            get
            {
                if (!_css.ContainsKey("margin-left"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: MarginLeft");
                return _css["margin-left"];
            }
            set
            {
                _css["margin-left"] = value;
            }
        }

        /// <summary>
        /// Margin is the spacing outside an element. The MarginRight property specifies the right margin of an element.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>MarginRight =  new MarginRight(...);</c>
        /// <br/>
        /// <c>MarginRight = "your css value(s) here";</c>
        /// <br/>
        /// <c>MarginRight = MarginRightOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_MarginRight = MarginRight;</c>
        /// <br/>
        /// <c>string cssValue = MarginRight;</c>
        /// <br/>
        /// <c>MarginRightOptions option = MarginRight;</c>
        /// </summary>
        public MarginRight MarginRight
        {
            get
            {
                if (!_css.ContainsKey("margin-right"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: MarginRight");
                return _css["margin-right"];
            }
            set
            {
                _css["margin-right"] = value;
            }
        }

        /// <summary>
        /// Margin is spacing added to the outside of an element. The MarginTop property specifies the top margin of an element.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>MarginTop =  new MarginTop(...);</c>
        /// <br/>
        /// <c>MarginTop = "your css value(s) here";</c>
        /// <br/>
        /// <c>MarginTop = MarginTopOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_MarginTop = MarginTop;</c>
        /// <br/>
        /// <c>string cssValue = MarginTop;</c>
        /// <br/>
        /// <c>MarginTopOptions option = MarginTop;</c>
        /// </summary>
        public MarginTop MarginTop
        {
            get
            {
                if (!_css.ContainsKey("margin-top"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: MarginTop");
                return _css["margin-top"];
            }
            set
            {
                _css["margin-top"] = value;
            }
        }

        /// <summary>
        /// The MaxHeight property sets the maximum height of an element. It prevents an element from becoming any larger than the specified value.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>MaxHeight =  new MaxHeight(...);</c>
        /// <br/>
        /// <c>MaxHeight = "your css value(s) here";</c>
        /// <br/>
        /// <c>MaxHeight = MaxHeightOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_MaxHeight = MaxHeight;</c>
        /// <br/>
        /// <c>string cssValue = MaxHeight;</c>
        /// <br/>
        /// <c>MaxHeightOptions option = MaxHeight;</c>
        /// </summary>
        public MaxHeight MaxHeight
        {
            get
            {
                if (!_css.ContainsKey("max-height"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: MaxHeight");
                return _css["max-height"];
            }
            set
            {
                _css["max-height"] = value;
            }
        }

        /// <summary>
        /// The MaxWidth property sets the maximum width of an element. It prevents an element from becoming any larger than the specified value.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>MaxWidth =  new MaxWidth(...);</c>
        /// <br/>
        /// <c>MaxWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>MaxWidth = MaxWidthOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_MaxWidth = MaxWidth;</c>
        /// <br/>
        /// <c>string cssValue = MaxWidth;</c>
        /// <br/>
        /// <c>MaxWidthOptions option = MaxWidth;</c>
        /// </summary>
        public MaxWidth MaxWidth
        {
            get
            {
                if (!_css.ContainsKey("max-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: MaxWidth");
                return _css["max-width"];
            }
            set
            {
                _css["max-width"] = value;
            }
        }

        /// <summary>
        /// The MinHeight property sets the minimum height of an element. It prevents an element from becoming any smaller than the specified value. This property is used when the content is smaller than MinHeight, otherwise it has no effect.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>MinHeight =  new MinHeight(...);</c>
        /// <br/>
        /// <c>MinHeight = "your css value(s) here";</c>
        /// <br/>
        /// <c>MinHeight = MinHeightOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_MinHeight = MinHeight;</c>
        /// <br/>
        /// <c>string cssValue = MinHeight;</c>
        /// <br/>
        /// <c>MinHeightOptions option = MinHeight;</c>
        /// </summary>
        public MinHeight MinHeight
        {
            get
            {
                if (!_css.ContainsKey("min-height"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: MinHeight");
                return _css["min-height"];
            }
            set
            {
                _css["min-height"] = value;
            }
        }

        /// <summary>
        /// The MinWidth property sets the minimum width of an element. It prevents an element from becoming any smaller than the specified value.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>MinWidth =  new MinWidth(...);</c>
        /// <br/>
        /// <c>MinWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>MinWidth = MinWidthOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_MinWidth = MinWidth;</c>
        /// <br/>
        /// <c>string cssValue = MinWidth;</c>
        /// <br/>
        /// <c>MinWidthOptions option = MinWidth;</c>
        /// </summary>
        public MinWidth MinWidth
        {
            get
            {
                if (!_css.ContainsKey("min-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: MinWidth");
                return _css["min-width"];
            }
            set
            {
                _css["min-width"] = value;
            }
        }

        /// <summary>
        /// The MixBlendMode property specifies how an element's content should blend with its direct parent background.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>MixBlendMode =  new MixBlendMode(...);</c>
        /// <br/>
        /// <c>MixBlendMode = "your css value(s) here";</c>
        /// <br/>
        /// <c>MixBlendMode = MixBlendModeOptions.Normal;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_MixBlendMode = MixBlendMode;</c>
        /// <br/>
        /// <c>string cssValue = MixBlendMode;</c>
        /// <br/>
        /// <c>MixBlendModeOptions option = MixBlendMode;</c>
        /// </summary>
        public MixBlendMode MixBlendMode
        {
            get
            {
                if (!_css.ContainsKey("mix-blend-mode"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: MixBlendMode");
                return _css["mix-blend-mode"];
            }
            set
            {
                _css["mix-blend-mode"] = value;
            }
        }

        /// <summary>
        /// The ObjectFit property specifies how an image fits its container. The image may be scaled down, shown fully, or cropped to make it fit. The object-position property is often used to set the image position.
        /// </summary>
        public ObjectFitOptions ObjectFit
        {
            get
            {
                var val = _css.ContainsKey("object-fit") ? _css["object-fit"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ObjectFit");
                var opt = (ObjectFitOptions)Keywords.GetOptionByKeyword<ObjectFitOptions>(val);
                return opt;
            }
            set
            {
                _css["object-fit"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The ObjectPosition defines an offset for an image or video. The effect is that the image appears offset in its own container. It accepts both positive and negative values.
        /// </summary>
        public ObjectPositionOptions ObjectPosition
        {
            get
            {
                var val = _css.ContainsKey("object-position") ? _css["object-position"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ObjectPosition");
                var opt = (ObjectPositionOptions)Keywords.GetOptionByKeyword<ObjectPositionOptions>(val);
                return opt;
            }
            set
            {
                _css["object-position"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Opacity property defines the transparency of an element. It specifies how much of the background is visible through the element. Opacity values range from 0 (transparent) to 1 (opaque).
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Opacity =  new Opacity(...);</c>
        /// <br/>
        /// <c>Opacity = "your css value(s) here";</c>
        /// <br/>
        /// <c>Opacity = OpacityOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Opacity = Opacity;</c>
        /// <br/>
        /// <c>string cssValue = Opacity;</c>
        /// <br/>
        /// <c>OpacityOptions option = Opacity;</c>
        /// </summary>
        public Opacity Opacity
        {
            get
            {
                if (!_css.ContainsKey("opacity"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Opacity");
                return _css["opacity"];
            }
            set
            {
                _css["opacity"] = value;
            }
        }

        /// <summary>
        /// Flex is a layout system that arranges items in rows and columns. The position of each item can be specified with the Order property. It sets the item Order relative to the other items inside the container.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Order =  new Order(...);</c>
        /// <br/>
        /// <c>Order = "your css value(s) here";</c>
        /// <br/>
        /// <c>Order = OrderOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Order = Order;</c>
        /// <br/>
        /// <c>string cssValue = Order;</c>
        /// <br/>
        /// <c>OrderOptions option = Order;</c>
        /// </summary>
        public Order Order
        {
            get
            {
                if (!_css.ContainsKey("order"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Order");
                return _css["order"];
            }
            set
            {
                _css["order"] = value;
            }
        }

        /// <summary>
        /// The Outline property defines an Outline for an element. An Outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Outline =  new Outline(...);</c>
        /// <br/>
        /// <c>Outline = "your css value(s) here";</c>
        /// <br/>
        /// <c>Outline = OutlineOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Outline = Outline;</c>
        /// <br/>
        /// <c>string cssValue = Outline;</c>
        /// <br/>
        /// <c>OutlineOptions option = Outline;</c>
        /// </summary>
        public Outline Outline
        {
            get
            {
                if (!_css.ContainsKey("outline"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Outline");
                return _css["outline"];
            }
            set
            {
                _css["outline"] = value;
            }
        }

        /// <summary>
        /// The OutlineColor property specifies the color of the outline. An outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>OutlineColor =  new OutlineColor(...);</c>
        /// <br/>
        /// <c>OutlineColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>OutlineColor = OutlineColorOptions.Invert;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_OutlineColor = OutlineColor;</c>
        /// <br/>
        /// <c>string cssValue = OutlineColor;</c>
        /// <br/>
        /// <c>OutlineColorOptions option = OutlineColor;</c>
        /// </summary>
        public OutlineColor OutlineColor
        {
            get
            {
                if (!_css.ContainsKey("outline-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: OutlineColor");
                return _css["outline-color"];
            }
            set
            {
                _css["outline-color"] = value;
            }
        }

        /// <summary>
        /// The OutlineOffset property specifies the space between border and outline. An outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>OutlineOffset =  new OutlineOffset(...);</c>
        /// <br/>
        /// <c>OutlineOffset = "your css value(s) here";</c>
        /// <br/>
        /// <c>OutlineOffset = OutlineOffsetOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_OutlineOffset = OutlineOffset;</c>
        /// <br/>
        /// <c>string cssValue = OutlineOffset;</c>
        /// <br/>
        /// <c>OutlineOffsetOptions option = OutlineOffset;</c>
        /// </summary>
        public OutlineOffset OutlineOffset
        {
            get
            {
                if (!_css.ContainsKey("outline-offset"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: OutlineOffset");
                return _css["outline-offset"];
            }
            set
            {
                _css["outline-offset"] = value;
            }
        }

        /// <summary>
        /// The OutlineStyle property specifies the style of the outline. An outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
        /// </summary>
        public OutlineStyleOptions OutlineStyle
        {
            get
            {
                var val = _css.ContainsKey("outline-style") ? _css["outline-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: OutlineStyle");
                var opt = (OutlineStyleOptions)Keywords.GetOptionByKeyword<OutlineStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["outline-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The OutlineWidth property specifies the width of the outline. An outline is a focus indicator that looks like a border. Outlines do not take up space and can overlap adjacent elements.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>OutlineWidth =  new OutlineWidth(...);</c>
        /// <br/>
        /// <c>OutlineWidth = "your css value(s) here";</c>
        /// <br/>
        /// <c>OutlineWidth = OutlineWidthOptions.Medium;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_OutlineWidth = OutlineWidth;</c>
        /// <br/>
        /// <c>string cssValue = OutlineWidth;</c>
        /// <br/>
        /// <c>OutlineWidthOptions option = OutlineWidth;</c>
        /// </summary>
        public OutlineWidth OutlineWidth
        {
            get
            {
                if (!_css.ContainsKey("outline-width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: OutlineWidth");
                return _css["outline-width"];
            }
            set
            {
                _css["outline-width"] = value;
            }
        }

        /// <summary>
        /// The Overflow property handles content that exceeds the size of the container. Options include scroll, visible, hidden and others.
        /// </summary>
        public OverflowOptions Overflow
        {
            get
            {
                var val = _css.ContainsKey("overflow") ? _css["overflow"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Overflow");
                var opt = (OverflowOptions)Keywords.GetOptionByKeyword<OverflowOptions>(val);
                return opt;
            }
            set
            {
                _css["overflow"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The OverflowX property handles content that exceeds the container width (x-direction) Possible values include hidden, visible, scroll and others.
        /// </summary>
        public OverflowXOptions OverflowX
        {
            get
            {
                var val = _css.ContainsKey("overflow-x") ? _css["overflow-x"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: OverflowX");
                var opt = (OverflowXOptions)Keywords.GetOptionByKeyword<OverflowXOptions>(val);
                return opt;
            }
            set
            {
                _css["overflow-x"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The OverflowY property handles content that exceeds the container height (y-direction). Possible values include hidden, visible, scroll and others.
        /// </summary>
        public OverflowYOptions OverflowY
        {
            get
            {
                var val = _css.ContainsKey("overflow-y") ? _css["overflow-y"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: OverflowY");
                var opt = (OverflowYOptions)Keywords.GetOptionByKeyword<OverflowYOptions>(val);
                return opt;
            }
            set
            {
                _css["overflow-y"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// Padding is the space between the content and the border of an element. The Padding property add spacing inside the element. This property accepts any length value, such as, px, %, em, and others.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Padding =  new Padding(...);</c>
        /// <br/>
        /// <c>Padding = "your css value(s) here";</c>
        /// <br/>
        /// <c>Padding = PaddingOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Padding = Padding;</c>
        /// <br/>
        /// <c>string cssValue = Padding;</c>
        /// <br/>
        /// <c>PaddingOptions option = Padding;</c>
        /// </summary>
        public Padding Padding
        {
            get
            {
                if (!_css.ContainsKey("padding"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Padding");
                return _css["padding"];
            }
            set
            {
                _css["padding"] = value;
            }
        }

        /// <summary>
        /// Padding is the space between the content of an element and its border. The PaddingBottom property adds spacing to the bottom of the element. It accepts any length value, such as, px, %, em, etc.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>PaddingBottom =  new PaddingBottom(...);</c>
        /// <br/>
        /// <c>PaddingBottom = "your css value(s) here";</c>
        /// <br/>
        /// <c>PaddingBottom = PaddingBottomOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_PaddingBottom = PaddingBottom;</c>
        /// <br/>
        /// <c>string cssValue = PaddingBottom;</c>
        /// <br/>
        /// <c>PaddingBottomOptions option = PaddingBottom;</c>
        /// </summary>
        public PaddingBottom PaddingBottom
        {
            get
            {
                if (!_css.ContainsKey("padding-bottom"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: PaddingBottom");
                return _css["padding-bottom"];
            }
            set
            {
                _css["padding-bottom"] = value;
            }
        }

        /// <summary>
        /// Padding is the space between the content of an element and its border. The PaddingLeft property adds spacing to the left of the element. It accepts any length value, such as, px, %, em, etc.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>PaddingLeft =  new PaddingLeft(...);</c>
        /// <br/>
        /// <c>PaddingLeft = "your css value(s) here";</c>
        /// <br/>
        /// <c>PaddingLeft = PaddingLeftOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_PaddingLeft = PaddingLeft;</c>
        /// <br/>
        /// <c>string cssValue = PaddingLeft;</c>
        /// <br/>
        /// <c>PaddingLeftOptions option = PaddingLeft;</c>
        /// </summary>
        public PaddingLeft PaddingLeft
        {
            get
            {
                if (!_css.ContainsKey("padding-left"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: PaddingLeft");
                return _css["padding-left"];
            }
            set
            {
                _css["padding-left"] = value;
            }
        }

        /// <summary>
        /// Padding is the space between the content and the border of an element. The PaddingRight property adds spacing to the right of the element. It accepts any length value, such as, px, %, em, etc.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>PaddingRight =  new PaddingRight(...);</c>
        /// <br/>
        /// <c>PaddingRight = "your css value(s) here";</c>
        /// <br/>
        /// <c>PaddingRight = PaddingRightOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_PaddingRight = PaddingRight;</c>
        /// <br/>
        /// <c>string cssValue = PaddingRight;</c>
        /// <br/>
        /// <c>PaddingRightOptions option = PaddingRight;</c>
        /// </summary>
        public PaddingRight PaddingRight
        {
            get
            {
                if (!_css.ContainsKey("padding-right"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: PaddingRight");
                return _css["padding-right"];
            }
            set
            {
                _css["padding-right"] = value;
            }
        }

        /// <summary>
        /// Padding is the space between the content and the border of an element. The PaddingTop property adds spacing to the top of the element. It accepts any length value, such as, px, %, em, etc.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>PaddingTop =  new PaddingTop(...);</c>
        /// <br/>
        /// <c>PaddingTop = "your css value(s) here";</c>
        /// <br/>
        /// <c>PaddingTop = PaddingTopOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_PaddingTop = PaddingTop;</c>
        /// <br/>
        /// <c>string cssValue = PaddingTop;</c>
        /// <br/>
        /// <c>PaddingTopOptions option = PaddingTop;</c>
        /// </summary>
        public PaddingTop PaddingTop
        {
            get
            {
                if (!_css.ContainsKey("padding-top"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: PaddingTop");
                return _css["padding-top"];
            }
            set
            {
                _css["padding-top"] = value;
            }
        }

        /// <summary>
        /// The page-break-before property adds a page-break after an element. This property is used to control the printing of an HTML document. It does not work with absolute positioned elements or empty div elements.
        /// </summary>
        public PageBreakAfterOptions PageBreakAfter
        {
            get
            {
                var val = _css.ContainsKey("page-break-after") ? _css["page-break-after"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: PageBreakAfter");
                var opt = (PageBreakAfterOptions)Keywords.GetOptionByKeyword<PageBreakAfterOptions>(val);
                return opt;
            }
            set
            {
                _css["page-break-after"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The PageBreakBefore property adds a page-break before an element. This property is used to control the printing of an HTML document. It does not work with absolute positioned elements or empty <div> elements.
        /// </summary>
        public PageBreakBeforeOptions PageBreakBefore
        {
            get
            {
                var val = _css.ContainsKey("page-break-before") ? _css["page-break-before"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: PageBreakBefore");
                var opt = (PageBreakBeforeOptions)Keywords.GetOptionByKeyword<PageBreakBeforeOptions>(val);
                return opt;
            }
            set
            {
                _css["page-break-before"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The PageBreakInside property specifies whether to avoid page-breaks. This property is used to control the printing of an HTML document. It does not work with absolute positioned elements or empty <div> elements.
        /// </summary>
        public PageBreakInsideOptions PageBreakInside
        {
            get
            {
                var val = _css.ContainsKey("page-break-inside") ? _css["page-break-inside"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: PageBreakInside");
                var opt = (PageBreakInsideOptions)Keywords.GetOptionByKeyword<PageBreakInsideOptions>(val);
                return opt;
            }
            set
            {
                _css["page-break-inside"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Perspective property gives 3D elements a Perspective view. Perspective defines how far away the object is from the user. This property is assigned to a parent element. Only child elements will get a Perspective view.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Perspective =  new Perspective(...);</c>
        /// <br/>
        /// <c>Perspective = "your css value(s) here";</c>
        /// <br/>
        /// <c>Perspective = PerspectiveOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Perspective = Perspective;</c>
        /// <br/>
        /// <c>string cssValue = Perspective;</c>
        /// <br/>
        /// <c>PerspectiveOptions option = Perspective;</c>
        /// </summary>
        public Perspective Perspective
        {
            get
            {
                if (!_css.ContainsKey("perspective"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Perspective");
                return _css["perspective"];
            }
            set
            {
                _css["perspective"] = value;
            }
        }

        /// <summary>
        /// The PerspectiveOrigin property sets the user position in 3D space. This position allows the browser to calculate the perpective of 3D elements. Only child elements will get the 3D effect when using this property.
        /// </summary>
        public PerspectiveOriginOptions PerspectiveOrigin
        {
            get
            {
                var val = _css.ContainsKey("perspective-origin") ? _css["perspective-origin"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: PerspectiveOrigin");
                var opt = (PerspectiveOriginOptions)Keywords.GetOptionByKeyword<PerspectiveOriginOptions>(val);
                return opt;
            }
            set
            {
                _css["perspective-origin"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The PointerEvents property sets whether an element responds to pointer events. Pointer events includes hover or active states, clicking events, touching events, etc. Most PointerEvents values are relevant for SVG images only.
        /// </summary>
        public PointerEventsOptions PointerEvents
        {
            get
            {
                var val = _css.ContainsKey("pointer-events") ? _css["pointer-events"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: PointerEvents");
                var opt = (PointerEventsOptions)Keywords.GetOptionByKeyword<PointerEventsOptions>(val);
                return opt;
            }
            set
            {
                _css["pointer-events"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Position property specifies that an element is Positioned. Positioned elements do not participate in the standard page flow. Options are: static, relative, absolute, fixed, or sticky.
        /// </summary>
        public PositionOptions Position
        {
            get
            {
                var val = _css.ContainsKey("position") ? _css["position"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Position");
                var opt = (PositionOptions)Keywords.GetOptionByKeyword<PositionOptions>(val);
                return opt;
            }
            set
            {
                _css["position"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Quotes property sets the quotation marks to use for quotations. It accepts any kind of quotation mark: ", ', ‘, ’, “, ”, ‹, ›, «, », etc. This value overrides the default which is a pair of double Quotes ("").
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Quotes =  new Quotes(...);</c>
        /// <br/>
        /// <c>Quotes = "your css value(s) here";</c>
        /// <br/>
        /// <c>Quotes = QuotesOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Quotes = Quotes;</c>
        /// <br/>
        /// <c>string cssValue = Quotes;</c>
        /// <br/>
        /// <c>QuotesOptions option = Quotes;</c>
        /// </summary>
        public Quotes Quotes
        {
            get
            {
                if (!_css.ContainsKey("quotes"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Quotes");
                return _css["quotes"];
            }
            set
            {
                _css["quotes"] = value;
            }
        }

        /// <summary>
        /// The Resize property defines if (and how) an element is resizable by the user.
        /// <code>Note: The Resize property does not apply to inline elements or to block elements where <see cref="Overflow"/> is <see cref="OverflowOptions.Visible"/>.
        /// <br/>
        /// So, make sure that overflow is set to <see cref="OverflowOptions.Scroll"/>, <see cref="OverflowOptions.Auto"/>, or <see cref="OverflowOptions.Hidden"/>.</code>
        /// </summary>
        public ResizeOptions Resize
        {
            get
            {
                var val = _css.ContainsKey("resize") ? _css["resize"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Resize");
                var opt = (ResizeOptions)Keywords.GetOptionByKeyword<ResizeOptions>(val);
                return opt;
            }
            set
            {
                _css["resize"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Right property specifies the horizontal position of a positioned element. Positioned elements have a position, such as absolute, sticky, etc. The effect of the Right setting depends on the position value.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Right =  new Right(...);</c>
        /// <br/>
        /// <c>Right = "your css value(s) here";</c>
        /// <br/>
        /// <c>Right = RightOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Right = Right;</c>
        /// <br/>
        /// <c>string cssValue = Right;</c>
        /// <br/>
        /// <c>RightOptions option = Right;</c>
        /// </summary>
        public Right Right
        {
            get
            {
                if (!_css.ContainsKey("right"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Right");
                return _css["right"];
            }
            set
            {
                _css["right"] = value;
            }
        }

        /// <summary>
        /// The ScrollBehavior property sets the scroll animation style. Scrolling can be instant, or it can be an animated scroll to the target. Not all browser support this property.
        /// </summary>
        public ScrollBehaviorOptions ScrollBehavior
        {
            get
            {
                var val = _css.ContainsKey("scroll-behavior") ? _css["scroll-behavior"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ScrollBehavior");
                var opt = (ScrollBehaviorOptions)Keywords.GetOptionByKeyword<ScrollBehaviorOptions>(val);
                return opt;
            }
            set
            {
                _css["scroll-behavior"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The TabSize property specifies the width of a tab character. Default is 8.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>TabSize =  new TabSize(...);</c>
        /// <br/>
        /// <c>TabSize = "your css value(s) here";</c>
        /// <br/>
        /// <c>TabSize = TabSizeOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_TabSize = TabSize;</c>
        /// <br/>
        /// <c>string cssValue = TabSize;</c>
        /// <br/>
        /// <c>TabSizeOptions option = TabSize;</c>
        /// </summary>
        public TabSize TabSize
        {
            get
            {
                if (!_css.ContainsKey("tab-size"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TabSize");
                return _css["tab-size"];
            }
            set
            {
                _css["tab-size"] = value;
            }
        }

        /// <summary>
        /// The TableLayout property specifies the table layout algorithm. This algorithm calculates the table, column, and cell widths. This property informs the browser how to best render a table.
        /// </summary>
        public TableLayoutOptions TableLayout
        {
            get
            {
                var val = _css.ContainsKey("table-layout") ? _css["table-layout"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TableLayout");
                var opt = (TableLayoutOptions)Keywords.GetOptionByKeyword<TableLayoutOptions>(val);
                return opt;
            }
            set
            {
                _css["table-layout"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The TextAlign property sets the text's horizontal alignment. Options include left, center, right, and justify. By default, text is left aligned.
        /// </summary>
        public TextAlignOptions TextAlign
        {
            get
            {
                var val = _css.ContainsKey("text-align") ? _css["text-align"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextAlign");
                var opt = (TextAlignOptions)Keywords.GetOptionByKeyword<TextAlignOptions>(val);
                return opt;
            }
            set
            {
                _css["text-align"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The TextAlignLast property aligns the last line of a block of text. Options include left, center, right, justify, and others. Not all browsers support this property.
        /// </summary>
        public TextAlignLastOptions TextAlignLast
        {
            get
            {
                var val = _css.ContainsKey("text-align-last") ? _css["text-align-last"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextAlignLast");
                var opt = (TextAlignLastOptions)Keywords.GetOptionByKeyword<TextAlignLastOptions>(val);
                return opt;
            }
            set
            {
                _css["text-align-last"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// A text decoration is an underline, an overline, or a strike-through line. The TextDecoration property adds one of these lines to text. The lines can be customized with different styles and colors.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>TextDecoration =  new TextDecoration(...);</c>
        /// <br/>
        /// <c>TextDecoration = "your css value(s) here";</c>
        /// <br/>
        /// <c>TextDecoration = TextDecorationOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_TextDecoration = TextDecoration;</c>
        /// <br/>
        /// <c>string cssValue = TextDecoration;</c>
        /// <br/>
        /// <c>TextDecorationOptions option = TextDecoration;</c>
        /// </summary>
        public TextDecoration TextDecoration
        {
            get
            {
                if (!_css.ContainsKey("text-decoration"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextDecoration");
                return _css["text-decoration"];
            }
            set
            {
                _css["text-decoration"] = value;
            }
        }

        /// <summary>
        /// A text decoration is an underline, an overline, or a strike-through line. The TextDecorationColor property specifies the color of the line. Color values can be hex, rgb, hsl, rgba, hsla, or a color name.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>TextDecorationColor =  new TextDecorationColor(...);</c>
        /// <br/>
        /// <c>TextDecorationColor = "your css value(s) here";</c>
        /// <br/>
        /// <c>TextDecorationColor = TextDecorationColorOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_TextDecorationColor = TextDecorationColor;</c>
        /// <br/>
        /// <c>string cssValue = TextDecorationColor;</c>
        /// <br/>
        /// <c>TextDecorationColorOptions option = TextDecorationColor;</c>
        /// </summary>
        public TextDecorationColor TextDecorationColor
        {
            get
            {
                if (!_css.ContainsKey("text-decoration-color"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextDecorationColor");
                return _css["text-decoration-color"];
            }
            set
            {
                _css["text-decoration-color"] = value;
            }
        }

        /// <summary>
        /// A text decoration is an underline, an overline, or a strike-through line. The TextDecorationLine property specifies the type of decoration. Options include underline, overline, and line-through.
        /// </summary>
        public TextDecorationLineOptions TextDecorationLine
        {
            get
            {
                var val = _css.ContainsKey("text-decoration-line") ? _css["text-decoration-line"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextDecorationLine");
                var opt = (TextDecorationLineOptions)Keywords.GetOptionByKeyword<TextDecorationLineOptions>(val);
                return opt;
            }
            set
            {
                _css["text-decoration-line"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// A text decoration is an underline, an overline, or a strike-through line. The TextDecorationStyle property sets the decoration line style. Valid values include solid, wavy, dotted, dashed, or double.
        /// </summary>
        public TextDecorationStyleOptions TextDecorationStyle
        {
            get
            {
                var val = _css.ContainsKey("text-decoration-style") ? _css["text-decoration-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextDecorationStyle");
                var opt = (TextDecorationStyleOptions)Keywords.GetOptionByKeyword<TextDecorationStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["text-decoration-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The TextIndent property sets the indentation of text. Indentation is extra space that is added before the first line of text. This property accepts any CSS length value, such as, px, %, em, and others.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>TextIndent =  new TextIndent(...);</c>
        /// <br/>
        /// <c>TextIndent = "your css value(s) here";</c>
        /// <br/>
        /// <c>TextIndent = TextIndentOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_TextIndent = TextIndent;</c>
        /// <br/>
        /// <c>string cssValue = TextIndent;</c>
        /// <br/>
        /// <c>TextIndentOptions option = TextIndent;</c>
        /// </summary>
        public TextIndent TextIndent
        {
            get
            {
                if (!_css.ContainsKey("text-indent"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextIndent");
                return _css["text-indent"];
            }
            set
            {
                _css["text-indent"] = value;
            }
        }

        /// <summary>
        /// The TextJustify property sets the text justification method. Justification means that text is spread out to fill the available space. It does this by spacing words or characters. This property is only relevant when text-align:justified is set.
        /// </summary>
        public TextJustifyOptions TextJustify
        {
            get
            {
                var val = _css.ContainsKey("text-justify") ? _css["text-justify"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextJustify");
                var opt = (TextJustifyOptions)Keywords.GetOptionByKeyword<TextJustifyOptions>(val);
                return opt;
            }
            set
            {
                _css["text-justify"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The TextOverflow property sets how overflowing text is handled. Options include clip, ellipsis, and others. white-space:nowrap and overflow:hidden are required to make it work.
        /// </summary>
        public TextOverflowOptions TextOverflow
        {
            get
            {
                var val = _css.ContainsKey("text-overflow") ? _css["text-overflow"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextOverflow");
                var opt = (TextOverflowOptions)Keywords.GetOptionByKeyword<TextOverflowOptions>(val);
                return opt;
            }
            set
            {
                _css["text-overflow"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The TextShadow property adds a shadow effect to text. The details of the shadow are specified by a number of values. These include x-offset, y-offset, blur-radius, and color.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>TextShadow =  new TextShadow(...);</c>
        /// <br/>
        /// <c>TextShadow = "your css value(s) here";</c>
        /// <br/>
        /// <c>TextShadow = TextShadowOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_TextShadow = TextShadow;</c>
        /// <br/>
        /// <c>string cssValue = TextShadow;</c>
        /// <br/>
        /// <c>TextShadowOptions option = TextShadow;</c>
        /// </summary>
        public TextShadow TextShadow
        {
            get
            {
                if (!_css.ContainsKey("text-shadow"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextShadow");
                return _css["text-shadow"];
            }
            set
            {
                _css["text-shadow"] = value;
            }
        }

        /// <summary>
        /// The TextTransform property specifies the casing of the font. Options include none, uppercase, lowercase, and capitalized.
        /// </summary>
        public TextTransformOptions TextTransform
        {
            get
            {
                var val = _css.ContainsKey("text-transform") ? _css["text-transform"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TextTransform");
                var opt = (TextTransformOptions)Keywords.GetOptionByKeyword<TextTransformOptions>(val);
                return opt;
            }
            set
            {
                _css["text-transform"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Top property specifies the vertical position of a positioned element. Positioned elements have a position, such as absolute, sticky and others. The effect of the Top setting depends on the position value.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Top =  new Top(...);</c>
        /// <br/>
        /// <c>Top = "your css value(s) here";</c>
        /// <br/>
        /// <c>Top = TopOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Top = Top;</c>
        /// <br/>
        /// <c>string cssValue = Top;</c>
        /// <br/>
        /// <c>TopOptions option = Top;</c>
        /// </summary>
        public Top Top
        {
            get
            {
                if (!_css.ContainsKey("top"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Top");
                return _css["top"];
            }
            set
            {
                _css["top"] = value;
            }
        }

        /// <summary>
        /// The Transform property adds a Transformation to an element. This property allows you to rotate, scale, move, or skew elements. It does this by modifying the coordinates of the elements.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Transform =  new Transform(...);</c>
        /// <br/>
        /// <c>Transform = "your css value(s) here";</c>
        /// <br/>
        /// <c>Transform = TransformOptions.None;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Transform = Transform;</c>
        /// <br/>
        /// <c>string cssValue = Transform;</c>
        /// <br/>
        /// <c>TransformOptions option = Transform;</c>
        /// </summary>
        public Transform Transform
        {
            get
            {
                if (!_css.ContainsKey("transform"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Transform");
                return _css["transform"];
            }
            set
            {
                _css["transform"] = value;
            }
        }

        /// <summary>
        /// The TransformOrigin property defines the origin of the transformation. The origin is the reference point for the transformation calculations. By default, the origin is located at (0,0), or (0,0,0) for 3D transformations.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>TransformOrigin =  new TransformOrigin(...);</c>
        /// <br/>
        /// <c>TransformOrigin = "your css value(s) here";</c>
        /// <br/>
        /// <c>TransformOrigin = TransformOriginOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_TransformOrigin = TransformOrigin;</c>
        /// <br/>
        /// <c>string cssValue = TransformOrigin;</c>
        /// <br/>
        /// <c>TransformOriginOptions option = TransformOrigin;</c>
        /// </summary>
        public TransformOrigin TransformOrigin
        {
            get
            {
                if (!_css.ContainsKey("transform-origin"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TransformOrigin");
                return _css["transform-origin"];
            }
            set
            {
                _css["transform-origin"] = value;
            }
        }

        /// <summary>
        /// The TransformStyle defines how child elements are rendered in 3D space. Child elements can be positioned in 3D space or they can be flattened. This setting only applies to elements that take part in 3D transformations.
        /// </summary>
        public TransformStyleOptions TransformStyle
        {
            get
            {
                var val = _css.ContainsKey("transform-style") ? _css["transform-style"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TransformStyle");
                var opt = (TransformStyleOptions)Keywords.GetOptionByKeyword<TransformStyleOptions>(val);
                return opt;
            }
            set
            {
                _css["transform-style"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Transition property creates animations. It does this by changing property values over a period of time. Transition is a shorthand for several other Transition properties.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Transition =  new Transition(...);</c>
        /// <br/>
        /// <c>Transition = "your css value(s) here";</c>
        /// <br/>
        /// <c>Transition = TransitionOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Transition = Transition;</c>
        /// <br/>
        /// <c>string cssValue = Transition;</c>
        /// <br/>
        /// <c>TransitionOptions option = Transition;</c>
        /// </summary>
        public Transition Transition
        {
            get
            {
                if (!_css.ContainsKey("transition"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Transition");
                return _css["transition"];
            }
            set
            {
                _css["transition"] = value;
            }
        }

        /// <summary>
        /// The TransitionDelay specifies a time delay before the transition starts. Transition delay can be set in seconds (s) or in milliseconds (ms). By default, transitions are played immediately, i.e. upon page load.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>TransitionDelay =  new TransitionDelay(...);</c>
        /// <br/>
        /// <c>TransitionDelay = "your css value(s) here";</c>
        /// <br/>
        /// <c>TransitionDelay = TransitionDelayOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_TransitionDelay = TransitionDelay;</c>
        /// <br/>
        /// <c>string cssValue = TransitionDelay;</c>
        /// <br/>
        /// <c>TransitionDelayOptions option = TransitionDelay;</c>
        /// </summary>
        public TransitionDelay TransitionDelay
        {
            get
            {
                if (!_css.ContainsKey("transition-delay"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TransitionDelay");
                return _css["transition-delay"];
            }
            set
            {
                _css["transition-delay"] = value;
            }
        }

        /// <summary>
        /// The TransitionDuration property specifies the time a transition takes. The duration is specified in seconds (s) or in milliseconds (ms). With a value of 0, no transition will occur.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>TransitionDuration =  new TransitionDuration(...);</c>
        /// <br/>
        /// <c>TransitionDuration = "your css value(s) here";</c>
        /// <br/>
        /// <c>TransitionDuration = TransitionDurationOptions.Initial;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_TransitionDuration = TransitionDuration;</c>
        /// <br/>
        /// <c>string cssValue = TransitionDuration;</c>
        /// <br/>
        /// <c>TransitionDurationOptions option = TransitionDuration;</c>
        /// </summary>
        public TransitionDuration TransitionDuration
        {
            get
            {
                if (!_css.ContainsKey("transition-duration"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TransitionDuration");
                return _css["transition-duration"];
            }
            set
            {
                _css["transition-duration"] = value;
            }
        }

        /// <summary>
        /// The TransitionProperty property specifies the property to animate. Multiple properties can be specified with a comma separated list. If no property is specified, all animatable properties will transition.
        /// </summary>
        public TransitionPropertyOptions TransitionProperty
        {
            get
            {
                var val = _css.ContainsKey("transition-property") ? _css["transition-property"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TransitionProperty");
                var opt = (TransitionPropertyOptions)Keywords.GetOptionByKeyword<TransitionPropertyOptions>(val);
                return opt;
            }
            set
            {
                _css["transition-property"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The TransitionTimingFunction sets the transition speed curve. The speed curve specifies the speed and acceleration of a transition. Options include ease-in, steps, and bezier.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>TransitionTimingFunction =  new TransitionTimingFunction(...);</c>
        /// <br/>
        /// <c>TransitionTimingFunction = "your css value(s) here";</c>
        /// <br/>
        /// <c>TransitionTimingFunction = TransitionTimingFunctionOptions.Ease;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_TransitionTimingFunction = TransitionTimingFunction;</c>
        /// <br/>
        /// <c>string cssValue = TransitionTimingFunction;</c>
        /// <br/>
        /// <c>TransitionTimingFunctionOptions option = TransitionTimingFunction;</c>
        /// </summary>
        public TransitionTimingFunction TransitionTimingFunction
        {
            get
            {
                if (!_css.ContainsKey("transition-timing-function"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: TransitionTimingFunction");
                return _css["transition-timing-function"];
            }
            set
            {
                _css["transition-timing-function"] = value;
            }
        }

        /// <summary>
        /// The UnicodeBidi property is used together with the <see cref="Direction"/> property to set or return whether the text should be overridden to support multiple languages in the same document.
        /// </summary>
        public UnicodeBidiOptions UnicodeBidi
        {
            get
            {
                var val = _css.ContainsKey("unicode-bidi") ? _css["unicode-bidi"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: UnicodeBidi");
                var opt = (UnicodeBidiOptions)Keywords.GetOptionByKeyword<UnicodeBidiOptions>(val);
                return opt;
            }
            set
            {
                _css["unicode-bidi"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The UserSelect property sets whether text can be selected. This setting has no effect on the appearance of the element. Users commonly select and highlight text. Text that prevents this feels 'dead'.
        /// </summary>
        public UserSelectOptions UserSelect
        {
            get
            {
                var val = _css.ContainsKey("user-select") ? _css["user-select"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: UserSelect");
                var opt = (UserSelectOptions)Keywords.GetOptionByKeyword<UserSelectOptions>(val);
                return opt;
            }
            set
            {
                _css["user-select"] = Keywords.GetKeywordByOption(value);
            }
        }
        /// <summary>
        /// The VerticalAlign property sets the element's vertical alignment. Vertical alignment only affects inline, inline-block, and table-cell boxes. Elements can be aligned at the top, bottom, and some values in between.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>VerticalAlign =  new VerticalAlign(...);</c>
        /// <br/>
        /// <c>VerticalAlign = "your css value(s) here";</c>
        /// <br/>
        /// <c>VerticalAlign = VerticalAlignOptions.Baseline;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_VerticalAlign = VerticalAlign;</c>
        /// <br/>
        /// <c>string cssValue = VerticalAlign;</c>
        /// <br/>
        /// <c>VerticalAlignOptions option = VerticalAlign;</c>
        /// </summary>
        public VerticalAlign VerticalAlign
        {
            get
            {
                if (!_css.ContainsKey("vertical-align"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: VerticalAlign");
                return _css["vertical-align"];
            }
            set
            {
                _css["vertical-align"] = value;
            }
        }

        /// <summary>
        /// The Visibility property specifies whether an element is visible or hidden. When hidden the element still occupies the same space on the page.
        /// </summary>
        public VisibilityOptions Visibility
        {
            get
            {
                var val = _css.ContainsKey("visibility") ? _css["visibility"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Visibility");
                var opt = (VisibilityOptions)Keywords.GetOptionByKeyword<VisibilityOptions>(val);
                return opt;
            }
            set
            {
                _css["visibility"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The WhiteSpace property handles WhiteSpace inside an element. It specifies whether WhiteSpace should collapse (into a single space). And whether lines should wrap at the end of a line.
        /// </summary>
        public WhiteSpaceOptions WhiteSpace
        {
            get
            {
                var val = _css.ContainsKey("white-space") ? _css["white-space"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: WhiteSpace");
                var opt = (WhiteSpaceOptions)Keywords.GetOptionByKeyword<WhiteSpaceOptions>(val);
                return opt;
            }
            set
            {
                _css["white-space"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The Width property sets an element's Width. Element Width is calculated without the padding, margin, or border. This property accepts any valid CSS length value (e.g. px, %, cm)
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>Width =  new Width(...);</c>
        /// <br/>
        /// <c>Width = "your css value(s) here";</c>
        /// <br/>
        /// <c>Width = WidthOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_Width = Width;</c>
        /// <br/>
        /// <c>string cssValue = Width;</c>
        /// <br/>
        /// <c>WidthOptions option = Width;</c>
        /// </summary>
        public Width Width
        {
            get
            {
                if (!_css.ContainsKey("width"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: Width");
                return _css["width"];
            }
            set
            {
                _css["width"] = value;
            }
        }

        /// <summary>
        /// The WordBreak property sets how words break at the end of a line. By default, a line of text only breaks at a space or a hyphen position. To insert hyphens (-) at the end of a break, add the hyphens property.
        /// </summary>
        public WordBreakOptions WordBreak
        {
            get
            {
                var val = _css.ContainsKey("word-break") ? _css["word-break"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: WordBreak");
                var opt = (WordBreakOptions)Keywords.GetOptionByKeyword<WordBreakOptions>(val);
                return opt;
            }
            set
            {
                _css["word-break"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The WordSpacing property specifies the spacing between words. This property accepts any CSS length value, such as, px, %, em, and others.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>WordSpacing =  new WordSpacing(...);</c>
        /// <br/>
        /// <c>WordSpacing = "your css value(s) here";</c>
        /// <br/>
        /// <c>WordSpacing = WordSpacingOptions.Normal;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_WordSpacing = WordSpacing;</c>
        /// <br/>
        /// <c>string cssValue = WordSpacing;</c>
        /// <br/>
        /// <c>WordSpacingOptions option = WordSpacing;</c>
        /// </summary>
        public WordSpacing WordSpacing
        {
            get
            {
                if (!_css.ContainsKey("word-spacing"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: WordSpacing");
                return _css["word-spacing"];
            }
            set
            {
                _css["word-spacing"] = value;
            }
        }

        /// <summary>
        /// When a word does not fit its container it wraps onto the next line. The WordWrap property specifies how words break and wrap. It does not specify where the break occurs; for that you use.
        /// </summary>
        public WordWrapOptions WordWrap
        {
            get
            {
                var val = _css.ContainsKey("word-wrap") ? _css["word-wrap"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: WordWrap");
                var opt = (WordWrapOptions)Keywords.GetOptionByKeyword<WordWrapOptions>(val);
                return opt;
            }
            set
            {
                _css["word-wrap"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The WritingMode property writes text horizontally or vertically. This is important for languages where text flows vertically (Chinese, Korean, etc.). For other languages WritingMode can help with page design.
        /// </summary>
        public WritingModeOptions WritingMode
        {
            get
            {
                var val = _css.ContainsKey("writing-mode") ? _css["writing-mode"] : "";
                if (val == "")
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: WritingMode");
                var opt = (WritingModeOptions)Keywords.GetOptionByKeyword<WritingModeOptions>(val);
                return opt;
            }
            set
            {
                _css["writing-mode"] = Keywords.GetKeywordByOption(value);
            }
        }

        /// <summary>
        /// The ZIndex property defines the element‘s vertical stack order. With overlapping elements, those with the highest value display in front. And those with lower values display behind the other elements.
        /// <br/>
        /// <list type="bullet"> <c>You can use in any of these ways:</c> </list>
        /// <br/>
        /// <br/>
        /// <c>ZIndex =  new ZIndex(...);</c>
        /// <br/>
        /// <c>ZIndex = "your css value(s) here";</c>
        /// <br/>
        /// <c>ZIndex = ZIndexOptions.Auto;</c>
        /// <br/>
        /// <br/>
        /// <list type="bullet"> <c>Also</c> </list>
        /// <c>_ZIndex = ZIndex;</c>
        /// <br/>
        /// <c>string cssValue = ZIndex;</c>
        /// <br/>
        /// <c>ZIndexOptions option = ZIndex;</c>
        /// </summary>
        public ZIndex ZIndex
        {
            get
            {
                if (!_css.ContainsKey("z-index"))
                    throw new Exception("You are trying access a CSS property that has not been assigned.\nPropery: ZIndex");
                return _css["z-index"];
            }
            set
            {
                _css["z-index"] = value;
            }
        }
        #endregion
    }
}
