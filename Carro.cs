using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Carro
    {
        public string marca;

        // Nomenclatura
        // todo atributo privado começa com _
        public string _modelo;
        public int anoFabricacao;

        //  Metodos
        // Get e Set
        // get - Metodo para pegar um atributo privado
        // set - metodo para alterar um atributo privado
        public void SetModelos(string mod)
        {
            if (mod == "Fiesta" || mod == "HB20")
            {
                _modelo = mod;
            }
            else
            {
                Console.WriteLine("Alteração invalida");
            }
        }
        
        public void Andar()
        {
            Console.WriteLine("Carro está andando!");
        }
        public void Parar()
        {
            Console.WriteLine("Carro está parando!");
        }
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {_modelo}, Ano de Fabricacao: {anoFabricacao}");
        }
    }
}