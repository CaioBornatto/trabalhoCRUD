using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoCrud
{


    class Shop
    {
        Screen tela;
        List<Stock> shopStock = new List<Stock>();
        
        public Shop(Screen t)
        {
            this.tela = t;
            this.defShopstock();
        }


        public void buy()
        {
            string op = string.Empty;
            this.tela.clearArea(1,8,78,23);
            
            while (true)
            {
                int initLine = 4;
                int initCol = 2;
                Console.SetCursorPosition(2, 11);
                Console.Write("                 ");
                Console.SetCursorPosition(initCol, initLine - 1);
                Console.Write($"Your balance : ¤ {Wallet.balance} ");

                foreach (Stock item in shopStock)
                {
                    Console.SetCursorPosition(initCol, initLine);
                    Console.Write($"> {item.index} - {item.itemName } - Preço : {item.itemPrice}");
                    initLine++;
                }

                Console.SetCursorPosition(2, initLine);
                Console.Write("> 9 - Encerar compra");
                Console.SetCursorPosition(2, initLine + 1);

                Console.Write("Opção : ");
          
                op = Console.ReadLine();

                Console.SetCursorPosition(1, initLine + 1);
                

                if (op == "9")
                {
                    Console.SetCursorPosition(2, initLine + 2);
                    Console.Write("Aperte enter para voltar ao menu...");
                    break;
                } else
                {
                

                    if(Wallet.balance == 0)
                    {
                        Console.SetCursorPosition(2, initLine + 2);
                        Console.Write("Ops você está sem dinheiro, Aperte enter para voltar ao menu...");
                        break;
                    }

           
                    Wallet.balance = Wallet.balance - shopStock[int.Parse(op)].itemPrice;
                    Console.SetCursorPosition(2, initLine + 1);
                    continue;
                }
            }
 
        }

        private void defShopstock()
        {
            Stock item1 = new Stock(0,"Broad Sword",50.00);
            Stock item2 = new Stock(1,"Wooden Shield", 15.00);
            Stock item3 = new Stock(2,"Healing Potion",  5.00);
            Stock item4 = new Stock(3,"Mana Potion",  50.00);
            Stock item5 = new Stock(4,"Battle Axe", 100.00);

            this.shopStock.Add(item1);
            this.shopStock.Add(item2);
            this.shopStock.Add(item3);
            this.shopStock.Add(item4);
            this.shopStock.Add(item5);
        }

    }
}
