using System.Collections;

namespace Aula13
{
    internal class Program
    {
        enum enumerador 
        {
           Ok = 200,
           Redirecionamento_Permanente = 301, 
           Redirecionamento_temporário = 302, 
           Não_encontrado =  404,
           Não_autorizado = 405,
           Servidor_indisponível = 503,
           Tempo_esgotado = 504

        };
        static void Main(string[] args)
        {
            Escola escola = new Escola();
            escola.listarMatriculas();
            escola.RemoverAluno();
            escola.RemoverAluno();


        }
    }
}