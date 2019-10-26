using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Calendario
    {
        // Membros

        private string _DataInicioAno1;
        private string _DataOutrosAnos;
        private string _DataFimAno;

        // Inicializar os respetivos valores;
        public Calendario()
        {
            _DataInicioAno1 = "21-Setembro-2009";
            _DataOutrosAnos = "14-Setembro-2009";
            _DataFimAno = "4-Junho-2010";
        }

        // Método de Escrita;
        public string MostrarDataInicio() 
        
        {
            return _DataInicioAno1;
        
        }
        public string MostrarDataOutrosAnos()

        {
            return _DataOutrosAnos;

        }
        public string MostrarFimAno()

        {
            return _DataFimAno;

        }


        // Metodo de Leitura;

    }
}