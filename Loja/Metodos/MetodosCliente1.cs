using System.Data.SqlClient;

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

    public static string PrimeiraMaiuscula(this string Valor)
    {
        return Valor.Substring(0, 1).ToUpper() + Valor.Substring(1, Valor.Length - 1).ToLower();
    }

    public static string PrimeiraMaiuscula(this string Valor, bool ultimasMinusculas)
    {
        if (ultimasMinusculas)
        {
            return Valor.Substring(0, 1).ToUpper() + Valor.Substring(1, Valor.Length - 1).ToLower();
        }
        else
        {
            return Valor.Substring(0, 1).ToUpper() + Valor.Substring(1, Valor.Length - 1);
        }
    }
}

namespace Loja.Classes
{
}