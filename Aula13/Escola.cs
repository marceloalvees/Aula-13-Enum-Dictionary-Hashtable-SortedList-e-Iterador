using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    public class Escola
    {
        Dictionary<int, Aluno> Matriculados = new Dictionary<int, Aluno>();

        public void CadastrarAluno()
             
        {
            Console.WriteLine("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do Aluno: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite o telefone do Aluno: ");
            int telefone = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Matricula: ");
            int matricula = int.Parse(Console.ReadLine());
        
            Matriculados.Add(Matriculados.Count + 1, new Aluno { matricula = matricula , nome = nome, sobrenome = sobrenome, telefone = telefone});


        
        }

        public void RemoverAluno()
        {
            Console.WriteLine("Qual a matricula do aluno que você deseja remover: ");
            int matricula = int.Parse(Console.ReadLine());
            Matriculados.Remove(matricula);

        }

        public void listarMatriculas()
        {
            foreach(var matricula in Matriculados)
            {
                Console.WriteLine(matricula);
            }
        }
        
        
    }   

}
