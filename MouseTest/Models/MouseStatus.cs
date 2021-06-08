using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseTest.Models
{
    /// <summary>
    ///      MouseStatus
    /// </summary>
    public class MouseStatus
    {
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public Point Position { get; set; }

        /// <summary>
        /// Gets or sets the left button.
        /// </summary>
        /// <value>
        /// The left button.
        /// </value>
        public MouseButton LeftButton { get; set; }
        /// <summary>
        /// Gets or sets the middle button.
        /// </summary>
        /// <value>
        /// The middle button.
        /// </value>
        public MouseButton MiddleButton { get; set; }
        /// <summary>
        /// Gets or sets the right button.
        /// </summary>
        /// <value>
        /// The right button.
        /// </value>
        public MouseButton RightButton { get; set; }

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <value>
        /// The buttons.
        /// </value>
        public List<MouseButton> Buttons { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether [in area].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [in area]; otherwise, <c>false</c>.
        /// </value>
        public bool InArea { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseStatus"/> class.
        /// </summary>
        public MouseStatus()
        {
            Buttons = new List<MouseButton>();
        }
    }
}
