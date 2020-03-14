using System;

namespace Serialization_Deserialization {
    [Serializable]
    public class Novel : Book
    {
        private double dipinjam;

        public Novel(int _jmlhlmn, float _noBuku, string _name, double _dipinjam) : base(_jmlhlmn, _noBuku, _name) {
            dipinjam = _dipinjam;
        }

        public override void Run() {
            Console.WriteLine("Book" + name + ", kondisi " + dipinjam);
        }
    }
}
