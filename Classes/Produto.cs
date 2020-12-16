using System;

namespace EX2.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }

        public Produto(){
            
        }

        public Produto(int codigo, string nome, string descricao, int estoque){
            if (codigo < 0)
            {
                Console.WriteLine("Valor Inválido");
            }else{
                Codigo = codigo;
                Nome = nome;
                Descricao = descricao;
                Estoque = estoque;

                Console.WriteLine($"Produto cadastrado Código - {Codigo} - Nome {Nome}");
            }
        }

        public Produto(int codigo){
            if (codigo >= 0)
            {
                Codigo = codigo;
                Nome = "Pepsi";
                Console.WriteLine($"Produto cadastrado Código - {Codigo} - Nome {Nome ?? "Sem Nome"}");
            }else{
                Console.WriteLine("Código Inválido");
            }
        }
        
        
        
        
        
        
        
        
    }
}