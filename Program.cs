using System;
using System.Collections.Generic;
using trabalhoCrud;

Screen tela = new Screen();
Wallet wllt = new Wallet(500.00);
Shop shp = new Shop(tela);
string opcao = string.Empty;


List<string> opcoes = new List<string>();

opcoes.Add("  <1> - Comprar     <<<$>>>    ");
opcoes.Add("  <0> - Sair        <<[X]>>    ");


tela.configScreen();
tela.montarTelaSistema();
tela.drawFrame(5,5,40,10);
tela.drawFrame(10,7,50,20);

while (true)
{
    tela.montarTelaSistema();
    opcao = tela.showMenu(opcoes, 24, 8);

    if (opcao == "0") break;
    if (opcao == "1") shp.buy();

    Console.ReadKey();
}