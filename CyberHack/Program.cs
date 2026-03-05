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




            if ((systemType & (SystemType.CorporateServer)) == (SystemType.CorporateServer))
            {

                if (
                    hacktools == "Phishing Backdoor BruteForce ZeroDay" ||
                 hacktools == "Phishing Backdoor BruteForce" ||
                 hacktools == "Phishing Backdoor ZeroDay" ||
                  hacktools == "Backdoor BruteForce" ||
                  hacktools == "Backdoor ZeroDay" ||
                  hacktools == "Phishing ZeroDay" ||
                   hacktools == "Phishing BruteForce")
                {
                    hackTool |= HackTool.Phishing;
                    hackTool |= HackTool.Backdoor;
                    hackTool |= HackTool.BruteForce;
                    hackTool |= HackTool.ZeroDay;

                }



                if ((hackTool & (HackTool.Phishing | HackTool.Backdoor & HackTool.ZeroDay | HackTool.BruteForce)) != 0)
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
