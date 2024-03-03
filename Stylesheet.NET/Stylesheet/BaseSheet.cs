using System;
using System.Collections.Generic;

namespace Stylesheet.NET
{
    /// <summary>
    /// Represents the base of a CSS Stylesheet.
    /// </summary>
    public abstract class BaseSheet : Validation
    {

        #region fields

        readonly Dictionary<string, Element> _elements = new Dictionary<string, Element>();

        #endregion

        #region Properties/Indexers
        internal Dictionary<string, Element> Elements
        {
            get
            {
                return _elements;
            }
        }
        public virtual Element this[string _el]
        {
            get
            {
                if (!_elements.ContainsKey(_el))
                    throw new Exception($"You are trying access a CSS selector that has not been assigned.\nSelector: {_el}");
                return _elements[_el];
            }
            set
            {

                if (IsValidSelector(_el) == null)
                    throw new Exception($"Selector can not be empty");
                if (!IsValidSelector(_el).Value)
                    throw new Exception($"Selector '{_el + value.PseudoSignature}' is not valid.");

                if (value == null)
                    throw new Exception($"Element can not be null.\nProperty name: {_el}");

                var name = _el + value.PseudoSignature;
                _elements[name] = value;
                _elements[name]._Name = _el;
            }
        }
        public virtual List<Element> this[string _el, PseudoType type]
        {
            get
            {
                List<Element> els = new List<Element>();
                var _n = _el + Keywords.GetPseudoByType(type);
                foreach (var e in _elements)
                {
                    if (e.Key.StartsWith(_n))
                    {
                        els.Add(e.Value);
                    }
                }
                if (els.Count == 0)
                    throw new Exception($"You are trying access a CSS selector that has not been assigned.\nSelector: {_el + Keywords.GetPseudoByType(type)}");
                return els;
            }
        }

        /// <summary>
        /// Gets elements in the sheet.
        /// </summary>
        /// <param name="name">Name of the element (ID, Class, tag, etc)</param>
        /// <param name="includePseudo">Whether pseudos are also included.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual List<Element> this[string name, bool includePseudo]
        {
            get
            {
                if (!includePseudo)
                    return new List<Element> { this[name] };
                List<Element> els = new List<Element>();
                var _n = name;
                foreach (var e in _elements)
                {
                    if (e.Key.StartsWith(_n + ":") || e.Key == _n)
                    {
                        els.Add(e.Value);
                    }
                }
                if (els.Count == 0)
                    throw new ArgumentNullException($"You are trying access a CSS selector that has not been assigned.\nSelector: {name}");
                return els;
            }
        }

        #endregion

        #region Overrides
        public static implicit operator string(BaseSheet baseSheet)
        {
            return baseSheet.ToString();
        }

        /// <summary>
        /// Returns unminified CSS in the current stylesheet as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GetCss(false);
        }
        /// <summary>
        /// Returns CSS in the current stylesheet as a string.
        /// </summary>
        /// <param name="minified">Whether the css is minified.</param>
        /// <returns></returns>
        public virtual string ToString(bool minified)
        {
            return GetCss(minified);
        }

        #endregion

        #region Methods
        /// <summary>
        /// Returns CSS in the current stylesheet as a string.
        /// </summary>
        /// <returns></returns>
        public virtual string GenerateCss()
        {
            return GetCss(false);
        }

        /// <summary>
        /// Returns CSS in the current stylesheet as a string.
        /// </summary>
        /// <param name="minified">Whether the css is minified.</param>
        /// <returns></returns>
        public virtual string GenerateCss(bool minified)
        {
            return GetCss(minified);
        }

        protected string GetCss(bool minified)
        {
            string _newLine = minified ? "" : "\n";
            List<string> _els = new List<string>();
            foreach (var e in _elements)
            {
                if (e.Value == null)
                    continue;
                _els.Add(e.Value.ToString(minified));
            }

            return string.Join(_newLine, _els.ToArray());
        }

        #endregion
    }
}
