using projeto1.models;

var termometroCozinha = new Termometro();
termometroCozinha.DefinirFaixaDeTemperatura(18.0, 24.0);
termometroCozinha.AjustarTemperatura(17.0);
termometroCozinha.MostrarTemperatura();
