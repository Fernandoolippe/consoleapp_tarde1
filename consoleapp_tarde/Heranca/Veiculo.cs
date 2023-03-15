using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp_tarde.Heranca
{
    public class Veiculo
    {
        public string cor;
        public int quantidadedeRodas;
        public int quantidadedeAssentos;
        public bool TemMotor;

        public string ExibirDados()
        {
            if (TemMotor)
            {
                return "TemMotor" + cor + " " + quantidadedeAssentos + " " + quantidadedeRodas;
            }
            else
            {
                return cor + " " + quantidadedeAssentos + " " + quantidadedeRodas;
            }
        }

    }
    
}
