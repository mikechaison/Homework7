using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            EmergencyLine emergencyLine = new EmergencyLine();
            emergencyLine.CallFireDepartment();
            emergencyLine.CallPolice();
            emergencyLine.CallAmbulance();
            emergencyLine.CallGasDepartment();
        }
    }


    // "Subsystem ClassA" 
    class PoliceLine
    {
        public void ConnectPolice()
        {
            Console.WriteLine("Connecting to the Police...");
        }
    }

    // Subsystem ClassB" 
    class FireDepartmentLine
    {
        public void ConnectFireDepartment()
        {
            Console.WriteLine("Connecting to the Fire Department...");
        }
    }


    // Subsystem ClassC" 
    class AmbulanceLine
    {
        public void ConnectAmbulance()
        {
            Console.WriteLine("Connecting to the Ambulance...");
        }
    }
    // Subsystem ClassD" 
    class GasDepartmentLine
    {
        public void ConnectGasDepartment()
        {
            Console.WriteLine("Connecting to the Gas Department...");
        }
    }
    // "Facade" 
    class EmergencyLine
    {
        FireDepartmentLine fireDepartmentLine;
        PoliceLine policeLine;
        AmbulanceLine ambulanceLine;
        GasDepartmentLine gasDepartmentLine;

        public EmergencyLine()
        {
            fireDepartmentLine = new FireDepartmentLine();
            policeLine = new PoliceLine();
            ambulanceLine = new AmbulanceLine();
            gasDepartmentLine = new GasDepartmentLine();
        }

        public void CallFireDepartment()
        {
            Console.WriteLine("Calling the Fire Department ---- ");
            fireDepartmentLine.ConnectFireDepartment();
        }

        public void CallPolice()
        {
            Console.WriteLine("Calling the Police ---- ");
            policeLine.ConnectPolice();
        }

        public void CallAmbulance()
        {
            Console.WriteLine("Calling the Ambulance ---- ");
            ambulanceLine.ConnectAmbulance();
        }

        public void CallGasDepartment()
        {
            Console.WriteLine("Calling the Gas Department ---- ");
            gasDepartmentLine.ConnectGasDepartment();
        }
    }
}