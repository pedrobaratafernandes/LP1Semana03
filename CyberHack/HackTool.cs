using System;

namespace CyberHack
{
    [Flags]
    public enum HackTool
    {
        BruteForce,
        Phishing,
        Backdoor,
        ZeroDay,
        AIOverride,
        QuantumExploit
    }
}