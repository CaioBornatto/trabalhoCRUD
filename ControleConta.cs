using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoManseira
{
    class ControleConta
    {
        Tela tela;
        string numConta;
        List<Conta> bancoDados = new List<Conta>();
        int posicao;
        string titConta;

       
        public ControleConta(Tela t)
        {
            this.tela = t;
            bancoDados.Add(new Conta("Zé Colmeia",10000));
        }

        public void executarCrud(int opt)
        {
            string title = string.Empty;

            switch (opt)
            {
                case 1:
                    title = "Comprar item";
                break;
                case 2:
                    title = "Vender item";
                 break;
                case 3:
                    title = "Falar com vendedor";
                break;
            }

            while (true)
            {
                this.tela.montarMoldura(10, 5, 70, 14);
                this.tela.montarLinhaHor(8, 10, 70);
                this.tela.centralizar(6, 10, 69, title);
                this.montarTelaConta();

                Console.SetCursorPosition(21, 9);
                this.numConta = Console.ReadLine();
                if (this.numConta == "") break;

                bool achou = false;
                for (int x =0;x < bancoDados.Count; x++)
                {
                    if(this.bancoDados[x].numero == this.numConta)
                    {
                        achou = true;
                        this.posicao = x;
                        break;
                    }

                   
                }

                if (achou)
                {
                    this.mostrarDadosConta();
                    Console.ReadKey();
                }
                else
                {

                }
            }


        }

        private void mostrarDadosConta()
        {
            Console.SetCursorPosition(21, 10);
            Console.WriteLine(this.bancoDados[this.posicao].titular);
            Console.SetCursorPosition(21, 11);
            Console.WriteLine(this.bancoDados[this.posicao].saldo);
        }

        public void montarTelaConta()
        {
            Console.SetCursorPosition(11, 9);
            Console.WriteLine("Numero  :");
            Console.SetCursorPosition(11, 10);
            Console.WriteLine("Numero  :");
            Console.SetCursorPosition(11, 11);
            Console.WriteLine("Numero  :");
        }
    }
}
