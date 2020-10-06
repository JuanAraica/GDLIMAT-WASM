using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GDLIMAT_WASM.Data
{
    public class Respuesta
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public List<Cliente> Data { get; set; }
    }
}
