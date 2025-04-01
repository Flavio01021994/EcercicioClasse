//Listas
using System;
using POO;

//string[] nomes = new string[5];
//// Generico
//List<string> ListaDeNomes = new List<string>();
//// List<string> ListaDeNomes = new List<string>(); - formato reduzido

//ListaDeNomes.Add("Flavio");
//ListaDeNomes.Add("Suellen");
//ListaDeNomes.Add("Andre");

//foreach (var item in ListaDeNomes)
//{
//    Console.WriteLine((item));
//}

// remover nome - ListaDeNomes.Remove("Suellen");

// POO - Programação Orientada a objetos

//Programação estruturada a objetos

//Objetivo - Aproximar a programação do mundo real
//Separar nossos sistemas em partes menores

//Classes e Objetos

//Classe - Definição (item da vida real apresentada em código)
//Atributos (caracteristicas) - Metodos (ações)

// Objetos - Instancia de uma classe
//using System.Runtime.Intrinsics.X86;
//using POO;

////Carro carro1 = new Carro();
//// para acessr informações do objeto eu uso o "."
//carro1.modelo = "HB20";
//carro1.marca = "Hyundai";
//carro1.anoFabricacao = 2024;

//carro1.Andar();
//carro1.Parar();

//Carro carro2 = new Carro();

//carro2.modelo = "Impreza";
//carro2.marca = "Subaru";
//carro2.anoFabricacao = 2009;

//carro2.Andar();
//carro2.Parar();

//Carro carro3 = new Carro();

//carro3.modelo = "208";
//carro3.marca = "Peugeot";
//carro3.anoFabricacao = 2025;

//carro3.Andar();
//carro3.Parar();

//List<Carro> carros = new List<Carro>();
//carros.Add(carro1);
//carros.Add(carro2);
//carros.Add(carro3);

// 4 pilares da POO

//Classe e objeto
//Classe - Definição ( molde )
//Objetivo - Instancia da classe

//### **1 - Criando uma Classe "Livro" e Instanciando um Objeto**

//Crie uma classe chamada `Livro` com os seguintes atributos:

//- `titulo` (tipo `string`)
//- `autor` (tipo `string`)
//- `paginas` (tipo `int`)

//Depois, instancie um objeto da classe `Livro`, atribua valores aos atributos e exiba as informações no console.

//Livro livro1 = new Livro();
//livro1.autor = "Roberto Martin";
//livro1.titulo = "Clean Code";
//livro1.paginas = 353;

//Livro livro2 = new Livro();
//{
//    livro1.autor = "Roberto Martin";
//    livro1.titulo = "Clean Code";
//    livro1.paginas = 353;
//};

//Console.WriteLine(livro1.autor);
//Console.WriteLine(livro1.titulo);
//Console.WriteLine(livro1.paginas);

//### **2 - Criando e Utilizando um Objeto "Aluno"**

//Crie uma classe chamada `Aluno` com os seguintes atributos:

//- `nome` (tipo `string`)
//- `idade` (tipo `int`)
//- `notaFinal` (tipo `double`)

//Depois, crie dois objetos da classe `Aluno`, atribua valores a eles e exiba os detalhes de ambos.

//Aluno aluno1 = new Aluno();
//{
//    //Aluno aluno1 = new Aluno();
//    aluno1.nome = "Andre";
//    aluno1.idade = 16;
//    aluno1.notaFinal = 10;
//}

//Aluno aluno2 = new Aluno();
//{
//    aluno2.nome = "Giovana";
//    aluno2.idade = 14;
//    aluno2.notaFinal = 9;
//}

//Console.WriteLine(aluno1.nome);
//Console.WriteLine(aluno1.idade);
//Console.WriteLine(aluno1.notaFinal);

//Console.WriteLine(aluno2.nome);
//Console.WriteLine(aluno2.idade);
//Console.WriteLine(aluno2.notaFinal);


////////////////////////////////////////////////////////////
//### **3 - Criando uma Classe "Produto" e Trabalhando com Objetos**

//Crie uma classe chamada `Produto` com os seguintes atributos:

//- `nome` (tipo `string`)
//- `preco` (tipo `double`)
//- `quantidadeEmEstoque` (tipo `int`)

//Produto p1 = new Produto();

//p1.nome = "Camiseta";
//p1.preco = 25.99;
//p1.quantidadeEmEstoque = 100;

//Console.WriteLine(p1.nome);
//Console.WriteLine(p1.preco);
//Console.WriteLine(p1.quantidadeEmEstoque);

//Console.WriteLine(p1.CalcularTotal());

// Ferramentas - Formas de Trabalhar com POO

// Encapsulamento e Herança

// Abstração e Polimorfismo

// Encapsulamento - Esconder comportamentos e atributos 
// Evitar que sejam acessados diretamentes
// Conta bancaria (saldo)
// Sacar() - Depositar() podem acessar o saldo
// conta.saldo = 300000;
// Vantagens 
//1 Esconder atributo/metodo/classe
//2 Defino regas para alteração ou listagem



//public - Este atriburo / metodo / classe pode ser acessado por qualquer um
//private - Este atriburo / metodo / classe so pode seracessado dentro dele mesmo
//protected/Internal - Este atriburo / metodo / classe so pode ser acessado por ele mesmo e por sua classe pai

// 4 Pilares

// Banco de dados - Sql Server
// Desenvolvimento Backend
// Polimorfismo depende de herança
// Polimorfismo - Um métodos (com mesmo nome) pode ter implementação variavel. EX carro automatico e manual, mesma coisa mas funciona de jeto diferente.
// Abstração - 