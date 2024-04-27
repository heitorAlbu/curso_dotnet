using projeto1.models;

var smartphone = new Smartphone("Android", "XIAOMI", "Redmi", "2022");

smartphone.Desligar();
smartphone.Ligar();
smartphone.ObterDescricao();
smartphone.VerificarBateria();


var tablet = new Tablet("100x90", "iphone", "apple", "2019");

tablet.Desligar();
tablet.Ligar();
tablet.ObterDescricao();
tablet.VerificarBateria();