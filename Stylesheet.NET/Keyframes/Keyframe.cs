namespace StylesheetNET
{
    /// <summary>
    /// Represents a keyframe. A keyframe can be a percent, a word etc. E.g. 0%, 40%, 100%, to, from etc.
    /// </summary>
    public class Keyframe : BaseStyle
    {
        #region Constructors

        /// <summary>
        /// Creates a keyframe.
        /// </summary>
        public Keyframe()
        {
        }
        /// <summary>
        /// Creates a keyframe with provided value key.
        /// </summary>
        /// <param name="frame">value key</param>
        public Keyframe(string frame)
        {
            Frame = frame;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets frame value key.
        /// </summary>
        public string Frame
        {
            get; set;
        }

        #endregion

        #region Methods

        internal virtual string GetFrameCss(bool minified)
        {
            string indent = minified ? "" : "\n";
            string space = minified ? "" : "   ";
            string frame = $"{Frame}{space}{{{indent}{GetProperties(minified)}{indent}}}";

            return frame;
        }

        #endregion
    }
}