/*
	Software Developer: Fred Ekstrand 
    Copyright (C) 2016 by: Fred Ekstrand


    Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
	to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
	and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE SOFTWARE DEVLOPER BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER 
	IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

    Except as contained in this notice, the name of the software developer shall not be used in advertising or otherwise to promote the sale, 
	use or other dealings in this "Software" without prior written authorization from the software developer.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekstrand.Encryption.Ciphers
{
    /// <summary>
    /// Defines Plugboard operations.
    /// </summary>
    /// <seealso cref="AbstractPlugboard" />
    [Serializable]
    public class Plugboard : AbstractPlugboard
	{
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Plugboard"/> class.
        /// </summary>
        public Plugboard():base()
		{
			
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="Plugboard"/> class.
        /// </summary>
        /// <param name="values">Array of EndPointPair&lt;byte, byte&gt;</param>
        public Plugboard(EndPointPair<byte,byte>[] values):this()
		{
            ValidateTranslationPoints(values);
            PopulateTransulationPoints(values);
		}

        #endregion

        #region Methods

        /// <summary>
        /// Transposes the specified value.
        /// </summary>
        /// <param name="value">byte value to be transposed</param>
        /// <returns>
        /// Return a transposed byte iff plugboard has a transpose mapping, otherwise; return the given byte
        /// </returns>
        public override byte Transpose(byte value)
		{
            m_SettingsInUse = true;

            if(m_Translation.Count == 0)
            {
                throw new NotFiniteNumberException(TRANSPOSITIONSET_NULL);
            }
            if (m_Translation.ContainsKey(value))
            {
                return m_Translation[value];
            }
            return value;
		}

        /// <summary>
        /// Clears all settings
        /// </summary>
        public override void Clear()
		{
            m_Translation = new Dictionary<byte, byte>();
            m_SettingsInUse = false;

        }

        #endregion;
    }
}
