using System;

namespace StylesheetNET
{
    /// <summary>
    /// Represents the css style of HTML element. It houses all the css properties of an element. 
    /// </summary>
    public class Element : BaseStyle
    {
        #region fields

        internal string _Name = "";
        private bool _IsMinified = false;

        #endregion


        #region methods/ctor

        /// <summary>
        /// Creates new Css element with the passed selector
        /// </summary>
        /// <param name="Selector"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException" ></exception>
        public Element(string Selector)
        {
            if (IsValidSelector(Selector) == null)
                throw new ArgumentNullException($"Selector can not be empty");
            if (!IsValidSelector(Selector).Value)
                throw new InvalidOperationException($"Selector '{Selector}' is not valid.");
            _Name = Selector;
        }

        /// <summary>
        /// Creates new CSS element.
        /// </summary>
        public Element()
        {
        }
        public virtual string GenerateCss()
        {
            return GenerateCss(false);
        }
        public virtual string GenerateCss(bool _minified)
        {
            var newLine = _minified ? "" : "\n";
            var indent = _minified ? "" : Extension.Indent;
            var style = $"{_Name}{PseudoSignature}{{{newLine}{GetProperties(_minified).TrimEnd()}{newLine}}}";
            return style;
        }

        #endregion

        #region Override/indexer
        /// <summary>
        /// Returns the CSS of the current element as string
        /// </summary>
        /// <returns>Unminified CSS e.g. <br/>#div{<br/>   height: 20px;<br/>   width: 40px;<br/>}</returns>
        public override string ToString()
        {
            return GenerateCss();
        }

        /// <summary>
        /// Returns the CSS of the current element as string
        /// </summary>
        /// <param name="minified">True if returned css will be minified.</param>
        /// <returns>Minified CSS e.g. <br/>#div{height:20px;width:40px;}</returns>
        public string ToString(bool minified)
        {
            return GenerateCss(minified);
        }
        #endregion

        #region properties
        /// <summary>
        /// Gets the pseudo signature of this element.
        /// <br/>
        /// <br/>
        /// <c>Example:</c>
        /// <list type="bullet">:hover</list>
        /// <list type="bullet">:nth-child(2)</list>
        /// <list type="bullet">::after</list>
        /// <list type="bullet">...etc</list>
        /// </summary>
        public virtual string PseudoSignature
        {
            get; internal set;
        }

        /// <summary>
        /// Gets the pseudo signature value of this element.
        /// <br/>
        /// <br/>
        /// <c>Example:</c>
        /// <list type="bullet"><c>:hover</c> will return empty string since it doesnt have a value</list>
        /// <list type="bullet"><c>:nth-child(2)</c> will return 2</list>
        /// <list type="bullet"><c>:not(span, div, .myclass, #myid)</c> will return <c>span, div, .myclass, #myid</c></list>
        /// <list type="bullet"><c>::after</c> will return empty string since it doesnt have a value</list>
        /// <list type="bullet">...etc</list>
        /// </summary>
        public virtual string PseudoSignatureValue
        {
            get; internal set;
        }
        #endregion

    }
}
