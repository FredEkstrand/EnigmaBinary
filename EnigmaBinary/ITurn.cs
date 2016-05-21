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
    /// Defines methods for Turn operations
    /// </summary>
    public interface ITurn
	{
        /// <summary>
        /// Turns the rotor.
        /// </summary>
        void TurnRotor();

        /// <summary>
        /// Clears all settings
        /// </summary>
        void Clear();

        /// <summary>
        /// Resets back to its start state if it has one.
        /// </summary>
        void Reset();

        /// <summary>
        /// Gets or sets the rotor.
        /// </summary>
        /// <value>
        /// Rotor object
        /// </value>
        IRotor Rotor
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the next turn.
        /// </summary>
        /// <value>
        /// Next Turn object
        /// </value>
        ITurn NextTurn
		{
			get;
			set;
		}

        /// <summary>
        /// Gets a value indicating whether [fully cycled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fully cycled]; otherwise, <c>false</c>.
        /// </value>
        bool FullyCycled
		{
			get;
		}

        /// <summary>
        /// Gets a value indicating whether Rotor is starter 
        /// </summary>
        /// <value>
        ///   <c>true</c> if starter rotor otherwise, <c>false</c>.
        /// </value>
        bool StarterRotor
        {
            get;
            set;
        }
	}
}
