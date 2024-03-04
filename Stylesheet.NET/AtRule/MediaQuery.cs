using System;

namespace StylesheetNET
{
    public class MediaQuery : BaseSheet, ICssObject
    {
        #region fields
        private string _mediaQueryCondition = "";

        #endregion

        #region Constructors
        /// <summary>
        /// Query condions
        /// </summary>
        /// <param name="condition"></param>
        /// <exception cref="Exception"></exception>
        public MediaQuery(string condition)
        {
            if (condition.IsNullOrWhiteSpace())
                throw new Exception("Conditon can not be empty.");
            _mediaQueryCondition = condition;
        }
        public MediaQuery(AtRule conditon)
        {
            if (conditon == null)
                throw new Exception("MediaRule can not be null.");

            string _mr = conditon;
            if (_mr.IsNullOrWhiteSpace())
                throw new Exception("MediaRule conditon can not be empty.");

            _mediaQueryCondition = _mr;
        }

        #endregion

        #region Overrides
        /// <summary>
        /// Returns umninified CSS stylesheet as a string of the current object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.ToString(false);
        }
        /// <summary>
        /// Returns CSS stylesheet as a string of the current object.
        /// </summary>
        /// <param name="minified">Whether to be minified</param>
        /// <returns></returns>
        public override string ToString(bool minified)
        {
            var indent = minified ? "" : "\n";

            string _q = $"@media {_mediaQueryCondition}{{{indent}{base.ToString(minified)}{indent}}}";

            return _q;
        }
        /// <summary>
        /// Returns umninified CSS stylesheet as a string of the current object.
        /// </summary>
        /// <returns></returns>
        public override string GenerateCss()
        {
            return this.ToString();
        }
        /// <summary>
        /// Returns CSS stylesheet as a string of the current object.
        /// </summary>
        /// <param name="minified">Whether to be minified</param>
        /// <returns></returns>
        public override string GenerateCss(bool minified)
        {
            return this.ToString(minified);
        }
        public static implicit operator string(MediaQuery mediaQuery)
        {
            return mediaQuery.ToString();
        }
        #endregion
        /// <summary>
        /// Returns Query conditions of the current media query.
        /// </summary>
        public string Condition
        {
            get
            {
                return _mediaQueryCondition;
            }
        }
    }
}
