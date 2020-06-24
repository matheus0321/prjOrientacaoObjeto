using System;

public static class MetodoExtensao
{
    public static int Metade(this int Valor)
    {
        return Valor / 2;
    }

    public static double Juros(this double Valor)
    {
        return Valor + 20;
    }
}

namespace prjOrientacaoObjeto.Classes
{
    public partial class Cliente : IDisposable
    {
        public void Gravar()
        {
            int x = 3;
        }

        public void Apagar()
        {
        }

        public Cliente()
        {
        }

        public Cliente(int Coodigo)
        {
            //Criar o prosedimento de leitura baseado no parametro codigo
            int x = 0;
        }

        public void Dispose()
        {
            this.Gravar();
        }
    }
}