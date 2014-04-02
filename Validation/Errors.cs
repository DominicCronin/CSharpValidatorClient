using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpValidatorClient
{
    /// <summary>
    /// List of the errors that can appear on a document
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
    public class Errors : IEnumerable<Error>
    {
        #region Variables
        /// <summary>
        /// Variable that represents the list of errors
        /// </summary>
        private List<Error> errorsList;
        #endregion

        #region Properties
        /// <summary>
        /// Number of errors of the document
        /// </summary>
        public string errorsCount { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor without parameters
        /// </summary>
        public Errors()
        {
            errorsList = new List<Error>();
        }
        #endregion

        #region Methods
        #region IEnumerable<Error> Members
        /// <summary>
        /// Method that return an iterator of the list
        /// </summary>
        /// <returns>Iterator of the list</returns>
        public IEnumerator<Error> GetEnumerator()
        {
            return errorsList.GetEnumerator();
        }
        #endregion

        #region IEnumerable Members
        /// <summary>
        /// Method that return an iterator of the list
        /// </summary>
        /// <returns>Iterator of the list</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return errorsList.GetEnumerator();
        }
        #endregion
        /// <summary>
        /// Method to add an item to the list
        /// </summary>
        /// <param name="item">Element to add</param>
        public void Add(Error item)
        {
            errorsList.Add(item);
        }
        #endregion
    }
}
