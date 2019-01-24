using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNine
{
    class Student
    {
        private string name;
        private string homeTown;
        private string favFood;
        private string favColor;

        public string Name { get => name; set => name = value; }
        public string HomeTown { get => homeTown; set => homeTown = value; }
        public string FavFood { get => favFood; set => favFood = value; }
        public string FavColor { get => favColor; set => favColor = value; }

        public Student(string nm, string hT, string fF, string fC)
        {
            this.name = nm;
            this.homeTown = hT;
            this.favFood = fF;
            this.favColor = fC;
        }
    }


}
