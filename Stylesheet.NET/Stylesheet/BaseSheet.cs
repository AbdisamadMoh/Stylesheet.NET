using System;
using System.Collections.Generic;
using System.Linq;

namespace StylesheetNET
{
    /// <summary>
    /// Represents the base of a CSS Stylesheet.
    /// </summary>
    public abstract class BaseSheet : Validation
    {

        #region fields

        readonly StylesheetCustomDictionary<string, Element> _elements = new StylesheetCustomDictionary<string, Element>(true);

        #endregion

        #region Properties/Indexers
        internal StylesheetCustomDictionary<string, Element> Elements
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

        public void AddOrUpdateElement(string name, Element element)
        {
            if (name.IsNullOrWhiteSpace())
                throw new ArgumentNullException("name");
            if (element == null)
                throw new ArgumentNullException("name");

            if (_elements.ContainsKey(name))
            {
                var el = _elements[name];
                var css = el._css;
                foreach (var e in element._css)
                {
                    css[e.Key] = e.Value;
                }
            }
            else
            {
                this[name] = element;
            }
        }
        /// <summary>
        /// Removes an element from the stylesheet.
        /// </summary>
        /// <param name="name">The name, tag, id, class, attribute etc of the element</param>
        /// <returns></returns>
        public bool RemoveElement(string name)
        {
            if (name.IsNullOrWhiteSpace())
                return false;
            for (int i = 0; i < _elements.Count; i++)
            {
                var el = _elements.ElementAt(i);
                if (el.Key.Trim() == name.Trim())
                {
                    _elements.Remove(el.Key);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        ///  Removes the psuedo of an element from the stylesheet.
        /// </summary>
        /// <param name="name">The name, tag, id, class, attribute etc of the element.</param>
        /// <param name="pseudoType">The type of the pseudo.</param>
        /// <returns></returns>
        public bool RemoveElement(string name, PseudoType pseudoType)
        {
            if (name.IsNullOrWhiteSpace())
                return false;
            var pt = Keywords.GetPseudoByType(pseudoType);
            for (int i = 0; i < _elements.Count; i++)
            {
                var el = _elements.ElementAt(i);
                if (el.Key.Trim() == name.Trim() + pt)
                {
                    _elements.Remove(el.Key);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Removes the psuedo of an element from the stylesheet.
        /// </summary>
        /// <param name="name">The name, tag, id, class, attribute etc of the element.</param>
        /// <param name="pseudoType">The type of the pseudo.</param>
        /// <param name="psuudoValue">The value of the pseudo e.g. div:nthchild(2)... 2 is the value.</param>
        /// <returns></returns>
        public bool RemoveElement(string name, PseudoType pseudoType, string psuudoValue)
        {
            if (name.IsNullOrWhiteSpace())
                return false;
            var pt = $"{Keywords.GetPseudoByType(pseudoType)}({psuudoValue})";
            for (int i = 0; i < _elements.Count; i++)
            {
                var el = _elements.ElementAt(i);
                if (el.Key.Trim() == name.Trim() + pt.Trim())
                {
                    _elements.Remove(el.Key);
                    return true;
                }
            }
            return false;
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
