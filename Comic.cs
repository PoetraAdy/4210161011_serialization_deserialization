using System;

namespace Serialization_Deserialization {
    [Serializable]
    public class Comic : Book {
        private int jmlhpinjam;

        public Player(int _jmlhlmn, float _noBuku, string _name, int _jmlhpinjam) : base(_jmlhlmn, _noBuku, _name) {
            jmlhpinjam = _jmlhpinjam;
        }

        public override void Run() {
            Console.WriteLine("Nama Buku" + name + ", jumlah peminjam " + jmlhpinjam);
        }
    }
}