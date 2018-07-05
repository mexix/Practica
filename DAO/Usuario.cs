using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavanderia.DAO
{
    class Usuario
    {
        private string nombre;
        private string apaterno;
        private string amaterno;
        private int edad;

        public Usuario()
        {

        }

        public string Getnombre(string nombre)
        {
            return this.nombre;
        }

        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }


        public string Getapaterno(string apaterno)
        {
            return this.apaterno;
        }

        public void Setapaterno(string apaterno)
        {
            this.apaterno = apaterno;
        }


        public string Getamaterno(string amaterno)
        {
            return this.amaterno;
        }

        public void Setamaterno(string amaterno)
        {
            this.amaterno = amaterno;
        }


        public int Getedad(int edad)
        {
            return this.edad;
        }

        public void Setedad(int edad)
        {
            this.edad = edad;
        }

    }
}
