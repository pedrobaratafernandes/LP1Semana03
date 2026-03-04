using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {

            string perks = args[0];

            //ativar perks
            Perks myRoles = Perks.WarpShift | Perks.DoubleJump | Perks.AutoHeal | Perks.Stealth;

            int countA = 0;
            int countS = 0;
            int countW = 0;
            int countD = 0;
            bool unknown = false;

            // desativar perks
            myRoles &= ~Perks.AutoHeal;
            myRoles &= ~Perks.Stealth;
            myRoles &= ~Perks.DoubleJump;
            myRoles &= ~Perks.WarpShift;
            foreach (char p in perks)
            {

                switch (p)
                {
                    case 'a':
                        countA++;
                        break;
                    case 's':
                        countS++;
                        break;
                    case 'w':
                        countW++;
                        break;
                    case 'd':
                        countD++;
                        break;
                    default:
                        unknown = true;
                        Console.WriteLine("!Unknown perk!");
                        break;
                }



                // se for impar
                if (p == 'a' && countA % 2 == 1)
                {
                    myRoles |= Perks.AutoHeal;

                } // se for pare
                else if (p == 'a' && countA % 2 == 0)
                {
                    myRoles &= ~Perks.AutoHeal;

                }

                if (p == 'w' && countW % 2 == 1)
                {
                    myRoles |= Perks.WarpShift;

                }
                else if (p == 'w' && countW % 2 == 0)
                {
                    myRoles &= ~Perks.WarpShift;

                }

                if (p == 'd' && countD % 2 == 1)
                {
                    myRoles |= Perks.DoubleJump;

                }
                else if (p == 'd' && countD % 2 == 0)
                {
                    myRoles &= ~Perks.DoubleJump;

                }

                if (p == 's' && countS % 2 == 1)
                {
                    myRoles |= Perks.Stealth;

                }
                else if (p == 's' && countS % 2 == 0)
                {
                    myRoles &= ~Perks.Stealth;

                }
            }

            // se todos os perks estao desativos
            if ((myRoles & (Perks.WarpShift | Perks.DoubleJump | Perks.Stealth | Perks.AutoHeal)) == 0)
            {
                Console.WriteLine("!No perks at all!");
            }
            else if (!unknown)
            {
                Console.WriteLine(myRoles);
            }
            // se existir perk double jump e stealth ativos
            if ((myRoles & (Perks.DoubleJump | Perks.Stealth)) == (Perks.DoubleJump | Perks.Stealth) && !unknown)
            {

                Console.WriteLine("!Silent jumper!");

            }
            // se perk autoheal nao esta ativo
            if ((myRoles & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("!Not gonna make it!");

            }
        }

    }
}