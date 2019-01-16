using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedObjects {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Student s = new Student();
            s.Name = "J. doe";
            s.DOB = new DateTime(1980, 1, 1);
            s.AssignedAdvisor.Name = "Annemarie Solbrack";
            s.AssignedAdvisor.Email = "Anne@marie.com";

            MessageBox.Show("Hey " + s.Name + ", your advisor is " + s.AssignedAdvisor.Name + ".");
        }
    }
}
