using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.HelloWorld {

    class Driver
    {
        static void main(String []args) {
            using (var qsim = new QuantumSimulator()) {
                HelloQ.Run(qsim).Wait();
            }
            Console.ReadKey();
        }
    }

}