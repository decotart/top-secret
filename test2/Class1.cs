using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Liquid
    {
        private string _name;
        private int _p, _v;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int P
        {
            get { return _p; }
            set { _p = value; }
        }

        public int V
        {
            get { return _v; }
            set { _v = value; }
        }

        public Liquid(string name, int p, int v)
        {
            _name = name;
            _p = p;
            _v = v;
        }

        public void PlusTen()
        {
            this._p += 10;
        }

        public void SetParams(string name)
        {
            this._name = name;
        }

        public void SetParams(int p, int v)
        {
            this._p = p;
            this._v = v;
        }
        
        /// <summary>
        /// задает параметры жидкости
        /// </summary>
        /// <param name="name"></param>
        /// <param name="p"></param>
        /// <param name="v"></param>
        public void SetParams(string name, int p, int v)
        {
            this._name = name;
            this._v = v;
            this._p = p;
        }

        /// <summary>
        /// показывает информацию о программе
        /// </summary>
        /// <returns>тсрока с информацией</returns>
        public string GetInfo()
        {
            return $"{this.Name}, {this.P}, {this.V}";
        }
    }
}