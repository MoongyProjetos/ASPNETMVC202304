using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CompradorDto
    {
        public Cliente cliente { get; set; }
        public List<Livro> livros { get; set; }
    }
}
