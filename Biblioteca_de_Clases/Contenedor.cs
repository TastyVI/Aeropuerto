using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Contenedor
    {
        /*########################### Variables e Inicilizaicones #########################
         * ###############################################################################*/
        
        List<Coordenada> coordenadas;

        public Contenedor()
        {
            coordenadas = new List<Coordenada>();
        }

        /*################################### Metodos #################################
       * ###############################################################################*/
        public void Agregar(Coordenada c)
        {
            coordenadas.Add(c); 
        }

        public Coordenada getCoordenada(int index)
        {
            Coordenada coordenada = coordenadas[index];
            return coordenada;
        }

        public List<Coordenada> GetCoordenadas()
        {
            return coordenadas;
        }
    }
}
