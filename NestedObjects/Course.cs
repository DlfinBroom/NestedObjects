using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects {
    class Course {
        /// <summary>
        /// The name of the class
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The number of credits this class is worth
        /// </summary>
        public string Credits { get; set; }

        /// <summary>
        /// The description of the class
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of hours the course is in one quarter
        /// </summary>
        public string Hours { get; set; }
    }
}
