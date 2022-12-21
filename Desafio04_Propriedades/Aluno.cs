using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04_Propriedades
{
    class Aluno
    {
        public int _matricula;
        private int Matricula
        {
            get { return _matricula; }
            set
            {
                if (value > 0)
                {
                    _matricula = value;
                }
                else
                {
                    Console.WriteLine("O valor atribuido não pode ser menor que 1");
                }
            }
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }
    }
}
