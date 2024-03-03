using System;
using System.Collections.Generic;
namespace Stylesheet.NET
{
    /// <summary>
    /// Represents Css keyframes
    /// </summary>
    public class Keyframes : ICssObject
    {
        #region fields

        private string _Name;
        readonly List<Keyframe> _frames = new List<Keyframe>();

        #endregion

        #region Constructors

        private Keyframes()
        {
        }

        /// <summary>
        /// Creates keyframes with the name provided.
        /// </summary>
        /// <param name="name">Name of the keyframes</param>
        public Keyframes(string name)
        {
            _Name = name;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Sets a keyframe in the keyframes.
        /// </summary>
        /// <param name="frame">Value of the keyframe e.g. 0%, 50%, to, from etc.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Keyframe this[string frame]
        {
            set
            {
                if (frame.IsNullOrWhiteSpace())
                    throw new ArgumentNullException("frame can not be empty.");
                if (value == null)
                    throw new ArgumentNullException("Keyfame can not be null.");
                value.Frame = frame;
                _frames.Add(value);
            }
        }

        /// <summary>
        /// Gets all keyframes in the current object.
        /// </summary>
        public List<Keyframe> Frames
        {
            get
            {
                return _frames;
            }
        }

        #endregion

        #region Methods

        internal string GetFramesCss(bool minified)
        {
            string indent = minified ? "" : "\n";
            string space = minified ? "" : " ";
            string frames = $"@Keyframes {_Name}{{{indent}";
            foreach (Keyframe frame in _frames)
            {
                frames += $"{frame.GetFrameCss(minified)}{indent}";
            }
            frames += $"}}";

            return frames;
        }

        #endregion
    }
}
