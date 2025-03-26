// Listas
// string[] nomes = new string[5];
// Generico
//List<string> ListaDeNomes = new List<string>();
//// List<string> ListaDeNomes = new List<string>(); - formato reduzido

//ListaDeNomes.Add("Flavio");
//ListaDeNomes.Add("Suellen");
//ListaDeNomes.Add("Andre");

//foreach (var item in ListaDeNomes)
//{
//    Console.WriteLine((item));
//}

//// remover nome - ListaDeNomes.Remove("Suellen");

// POO - Programação Orientada a objetos

// Programação estruturada a objetos

// Objetivo - Aproximar a programação do mundo real
// Separar nossos sistemas em partes menores

// Classes e Objetos

// Classe - Definição (item da vida real apresentada em código)
// Atributos (caracteristicas) - Metodos (ações)

//// Objetos - Instancia de uma classe
//using System.Runtime.Intrinsics.X86;
//using POO;

//Carro carro1 = new Carro();
//// para acessr informações do objeto eu uso o "."
//carro1.modelo = "HB20";
//carro1.marca = "Hyundai";
//carro1.anoFabricacao = 2024;

//carro1.Andar();
//carro1.Parar();

//Carro carro2 = new Carro();

carro2.modelo = "Impreza";
carro2.marca = "Subaru";
carro2.anoFabricacao = 2009;

carro2.Andar();
carro2.Parar();

Carro carro3 = new Carro();

carro3.modelo = "208";
carro3.marca = "Peugeot";
carro3.anoFabricacao = 2025;

carro3.Andar();
carro3.Parar();

List<Carro> carros = new List<Carro>();
carros.Add(carro1);
carros.Add(carro2);
carros.Add(carro3);

