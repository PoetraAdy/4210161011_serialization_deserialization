using System;

namespace Serialization_Deserialization {
    [Serializable]
    public class Book {
        protected int jmlhlmn;
        protected float noBuku;
        protected string name;

        public Book(int _jmlhlmn, float _noBuku, string _name) {
            jmlhlmn = _jmlhlmn;
            noBuku = _noBuku;
            name = _name;
        }

        public virtual void Run() {

        }
    }
}