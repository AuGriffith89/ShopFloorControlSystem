using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Models
{
    /// <summary>
    /// Represents a user of the application.
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Unique identifer for the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User's first name.
        /// </summary>
        public string FirstName { get; set; } = String.Empty;

        /// <summary>
        /// User's last name.
        /// </summary>
        public string LastName { get; set; } = String.Empty;

        /// <summary>
        /// User's display name, in the foramt of Last Name, First Initial
        /// </summary>
        public string DisplayName
        {
            get
            {
                string displayName = LastName;
                if (FirstName.Length > 0)
                {
                    displayName += $", {FirstName.Substring(0, 1)}";
                }

                return displayName;
            }
        }
    }
}
