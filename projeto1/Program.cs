using projeto1.models;

var meuContador = new Contador();

meuContador.Incrementar();
meuContador.Incrementar();
meuContador.Incrementar();
meuContador.Decrementar();

Console.WriteLine("valor final do contador : " + meuContador.Valor);
