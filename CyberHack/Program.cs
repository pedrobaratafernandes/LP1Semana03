using System;

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            HackTool hackTool = 0;
            SystemType systemType = 0;

            string system = Console.ReadLine();

            string hacktools = Console.ReadLine();

            if (system == "CorporateServer")
            {
                systemType |= SystemType.CorporateServer;
            }
            else if (system == "BankDatabase")
            {
                systemType |= SystemType.BankDatabase;
            }
            else if (system == "SmartCityCore")
            {
                systemType |= SystemType.SmartCityCore;
            }
            else if (system == "MilitaryAI")
            {
                systemType |= SystemType.MilitaryAI;
            }



            if (hacktools == "Phishing")
            {
                hackTool |= HackTool.Phishing;


            }
            else if (hacktools == "Backdoor")
            {
                hackTool |= HackTool.Backdoor;
            }
            else if (hacktools == "BruteForce")
            {
                hackTool |= HackTool.BruteForce;
            }

            else if (hacktools == "ZeroDay")
            {
                hackTool |= HackTool.ZeroDay;
            }
            else if (hacktools == "AIOverride")
            {
                hackTool |= HackTool.AIOverride;
            }
            else if (hacktools == "QuantumExploit")
            {
                hackTool |= HackTool.QuantumExploit;
            }


            if ((systemType & (SystemType.CorporateServer)) == (SystemType.CorporateServer))
            {

                if ((hackTool & (HackTool.Phishing & HackTool.Backdoor)) == (HackTool.ZeroDay & HackTool.BruteForce))
                {
                    Console.WriteLine("System Hacked!");
                }
                else
                {
                    Console.WriteLine("System Secure");
                }
            } else if ((systemType & (SystemType.BankDatabase)) == (SystemType.BankDatabase))
            {

                if ((hackTool & (HackTool.ZeroDay & HackTool.Backdoor)) == (HackTool.ZeroDay & HackTool.BruteForce))
                {
                    Console.WriteLine("System Hacked!");
                }
                else
                {
                    Console.WriteLine("System Secure");
                }
            }



        }
    }
}
