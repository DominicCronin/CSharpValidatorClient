﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctypeEncodingValidation
{
    /// <summary>
    /// Class with all the properties needed to represent a Fault according to the xml returned by the W3C
    /// </summary>
    /// <remarks>
    /// This file is part of CSharpValidatorClient, originally released by 
    /// María Eugenia Fernández Menéndez as DoctypeEncodingValidation
    ///
    /// Obviously, she deserves all the credit for that work, but can not 
    /// be blamed for the later modifications, which are documented at 
    /// https://github.com/DominicCronin/CSharpValidatorClient
    ///
    /// License:
    /// 
    ///     This file is part of CSharpValidatorClient
    ///     
    ///     CSharpValidatorClient is free software: you can redistribute
    ///     it and/or modify it under the terms of the GNU General Public 
    ///     License as published by the Free Software Foundation, either 
    ///     version 3 of the License, or (at your option) any later version.
    ///     
    ///     CSharpValidatorClient is distributed in the hope that it 
    ///     will be useful, but WITHOUT ANY WARRANTY; without even the 
    ///     implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR
    ///     PURPOSE. See the GNU General Public License for more details.
    ///  
    ///     You should have received a copy of the GNU General Public License
    ///     along with CSharpValidatorClient. If not, see <http://www.gnu.org/licenses/>.
    ///     
    /// </remarks>
    class Fault
    {
        #region Properties
        /// <summary>
        /// Reason of the fault
        /// </summary>
        public string reason { get; set; }
        /// <summary>
        /// Message identifier of the fault
        /// </summary>
        public string messageid { get; set; }
        /// <summary>
        /// Details of the fault
        /// </summary>
        public string errorDetail { get; set; }
        #endregion


        #region Constructors
        /// <summary>
        /// Default constructor without parameters
        /// </summary>
        public Fault() { }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="reason">Reason of the fault</param>
        /// <param name="messageid">Message idenfier of the fault</param>
        /// <param name="errorDetail">Details of the fault</param>
        public Fault(string reason, string messageid, string errorDetail)
        {
            this.reason = reason;
            this.messageid = messageid;
            this.errorDetail = errorDetail;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method that returns a string with all the information of the fault 
        /// </summary>
        /// <returns>String with all the information of the fault </returns>
        public override string ToString()
        {
            string cadena = "Reason: " + this.reason + " - MessageId: " + this.messageid + " - Error Detail: " + this.errorDetail;
            return cadena;
        }
        #endregion
    }
}
