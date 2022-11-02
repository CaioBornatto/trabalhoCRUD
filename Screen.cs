using System;
using System.Collections.Generic;
using System.Linq;
using trabalhoCrud;

class Screen
{
    // propriedades
    ConsoleColor corTexto, corFundo;


    // construtor
    public Screen(ConsoleColor ct = ConsoleColor.Green, ConsoleColor cf = ConsoleColor.Black)
    {
        this.corFundo = cf;
        this.corTexto = ct;
        this.configScreen();
    }


    public void configScreen()
    {
        Console.BackgroundColor = this.corFundo;
        Console.ForegroundColor = this.corTexto;
        Console.Clear();
    }


    public void montarTelaSistema()
    {
       

        this.drawFrame(0, 0, 79, 24);
        this.drawHorizontalLine(2, 0, 79);
        this.center(1, 0, 34, "■ █ ■ █ ■ █ ■ █ Caio's RPG store █ ■ █ ■ █ ■ █ ■ ");
        this.drawHorizontalLine(22, 0, 79);
        Console.SetCursorPosition(3, 23);
        Console.Write($"Your balance : ¤ {Wallet.balance} ");
    }


    public void drawFrame(int ci, int li, int cf, int lf)
    {
        int col, lin;

        // limpa a area em que será montada a moldura
        this.clearArea(ci, li, cf, lf);

        // desenha as linhas horizontais
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("═");
            Console.SetCursorPosition(col, lf);
            Console.Write("═");
        }

        // desenha as linhas verticais
        for (lin = li; lin <= lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("║");
            Console.SetCursorPosition(cf, lin);
            Console.Write("║");
        }

        // desenha os cantos da moldura
        Console.SetCursorPosition(ci, li); Console.Write("╔");
        Console.SetCursorPosition(ci, lf); Console.Write("╚");
        Console.SetCursorPosition(cf, li); Console.Write("╗");
        Console.SetCursorPosition(cf, lf); Console.Write("╝");
    }


    public void clearArea(int ci, int li, int cf, int lf)
    {
        int col, lin;
        // para cada coluna
        for (col = ci; col <= cf; col++)
        {
            // em cada uma das linahs
            for (lin = li; lin <= lf; lin++)
            {
                // posiciona
                Console.SetCursorPosition(col, lin);
                // imprime 1 espaço em branco para "limpar"
                Console.Write(" ");
            }
        }
    }


    public void drawHorizontalLine(int lin, int ci, int cf)
    {
        int col;
        // traça a linha
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, lin);
            Console.Write("═");
        }
        // arruma as pontas
        Console.SetCursorPosition(ci, lin);
        Console.Write("╠");
        Console.SetCursorPosition(cf, lin);
        Console.Write("╣");
    }


    public void center(int lin, int ci, int cf, string msg)
    {
        int col;
        col = ci+((cf-ci)/2);
        Console.SetCursorPosition(col,lin);
        Console.Write(msg);
    }

    public string showMenu(List<string> menu,int ci, int li)
    {

        int cf, lf;
        string op;
        int x;

        cf = ci + menu[0].Length + 1;
        lf = li + menu.Count() + 2;

 
        this.drawFrame(ci, li , cf, lf);

        for ( x = 0; x < menu.Count(); x++)
        {
 
            Console.SetCursorPosition(ci + 1, li + x + 1);
            Console.Write(menu[x]);
        }

        Console.SetCursorPosition(ci + 2, li + x + 1);
        Console.Write(" Opção :  ");
        op = Console.ReadLine();
        return op;
    }

}