using _01conceitos;
// instanciar um objeto
Pessoa obj1 = new Pessoa();
obj1.Nome = "João";
//obj1.Apresentacao();

Pessoa obj2 = new ();
obj2.Nome = "Maria";
//obj2.Apresentacao();
Pessoa obj3 = new ()
 { 
    Nome = "José",
    Idade = 20
};
obj3.Apresentacao();
string responsta = obj3.MinhaIdade();
Console.WriteLine(responsta);