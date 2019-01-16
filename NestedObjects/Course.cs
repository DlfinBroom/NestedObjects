using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects {
    class Course {
        /// <summary>
        /// The name of the course
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The number of credits this course is worth
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The description of the course
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The Instructor who teaches the course
        /// </summary>
        public Instructor CourceInstructor { get; set; }
    }
}
