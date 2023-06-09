using Microsoft.AspNetCore.Mvc;
using Sign_Language_Robot_Web_Application.Models;
using System.Diagnostics;
using System.IO.Ports;
using System.Security.Cryptography.X509Certificates;

namespace Sign_Language_Robot_Web_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private String message;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult ButtonClick(string buttonName)
        {
            Numbers(buttonName);
            Alphabets(buttonName);
            Words(buttonName);

            if (buttonName == "Open Port") OpenPortMethod();
            else if (buttonName == "Close Port") ClosePortMethod();
            else
            {
                Thread.Sleep(1000);
                SerialPortProgram.Execute(buttonName);
                Console.WriteLine(buttonName);
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult SpeechTextInput(String speech)
        {
            Numbers(speech);
            Alphabets(speech); 
            Words(speech);

            return Ok();
        }

        public void OpenPortMethod()
        {
            SerialPortProgram.OpenPort();
        }

        public void ClosePortMethod()
        {
            SerialPortProgram.ClosePort();
        }

        public void Numbers(String speech)
        {
            if (speech == "0.")
            {
                message = "444444444444'Zero'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "1.")
            {
                message = "555555113355'One'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "2.")
            {
                message = "555511113355'Two'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "3.")
            {
                message = "551111113355'Three'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "4.")
            {
                message = "111111113355'Four'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "5.")
            {
                message = "111111111111'Five'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "6.")
            {
                message = "441111113355'Six'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "7.")
            {
                message = "114411113355'Seven'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "8.")
            {
                message = "111144113355'Eight'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "9.")
            {
                message = "111111443355'Nine'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "10.")
            {
                message = "555555551111'Ten'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
        }

        public void Alphabets(String speech)
        {
            // A
            if (speech == "A.")
            {
                message = "555555555511'A'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // B
            else if (speech == "B.")
            {
                message = "111111115511'B'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // C
            else if (speech == "C.")
            {
                message = "333333333322'C'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // D
            else if (speech == "D.")
            {
                message = "333333113344'D'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // E
            else if (speech == "E.")
            {
                message = "333333335555'E'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // F
            else if (speech == "F.")
            {
                message = "111111445555'F'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // G
            else if (speech == "G.")
            {
                message = "555555335544'G'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // H
            else if (speech == "H.")
            {
                message = "333311115555'H'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // I
            else if (speech == "I.")
            {
                message = "115555555555'I'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // J
            else if (speech == "J.")
            {
                message = "115555554411'J'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // K
            else if (speech == "K.")
            {
                message = "555522115555'K'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // L
            else if (speech == "L.")
            {
                message = "555555111111'L'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // M
            else if (speech == "M.")
            {
                message = "553333335555'M'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // N
            else if (speech == "N.")
            {
                message = "555533335555'N'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // O
            else if (speech == "O.")
            {
                message = "444444444444'Zero'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // P
            else if (speech == "P.")
            {
                message = "555522115155'P - Need FH'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // Q
            else if (speech == "Q.")
            {
                message = "555555223355'Q'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // R
            else if (speech == "R.")
            {
                message = "555522224455'R'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // S
            else if (speech == "S.")
            {
                message = "555555551155'S'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // T
            else if (speech == "T.")
            {
                message = "555555331155'T'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // U
            else if (speech == "U.")
            {
                message = "555511115555'U'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // V
            else if (speech == "V.")
            {
                message = "555522225555'V'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // W
            else if (speech == "W.")
            {
                message = "552222225555'W'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // X
            else if (speech == "X.")
            {
                message = "555555335555'X'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // Y
            else if (speech == "Y.")
            {
                message = "115555551111'Y'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            // Z
            else if(speech == "Z.")
            {
                message = "555555515555'Z'";
                SerialPortProgram.Execute(message);
                Thread.Sleep(500);
                message = "555555515555'Z'";
                SerialPortProgram.Execute(message);
                Thread.Sleep(500);
                message = "555555115555'Z'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
        }

        public void Words(String speech)
        {
            if (speech == "Nice.")
            {
                message = "313131315111'Nice'";
                SerialPortProgram.Execute(message);
                Thread.Sleep(500);
                message = "313131315511'Nice'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "Yes.")
            {
                message = "555555551111'Yes'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "No.")
            {
                message = "555555555551'No'";
                SerialPortProgram.Execute(message);
                Thread.Sleep(500);
                message = message = "555555555551'No'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "**** you.")
            {
                message = "555511555555'**** you'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "Hi.")
            {
                message = "515151515151'Hi'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "Hello.")
            {
                message = "515151515151'Hello";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "What?")
            {
                message = "554433221111'What?'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if (speech == "What is your name?")
            {
                message = "554433221111'What is your name?'";
                SerialPortProgram.Execute(message);
            }
            else if (speech == "Reset.")
            {
                message = "111111111111'Reset'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if(speech == "Who?")
            {
                message = "554433221111'Who?'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if(speech == "Yo-yo.")
            {
                message = "115555115555'Yo-yo?";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
            else if(speech == "OK.")
            {
                message = "555555551111'OK'";
                SerialPortProgram.Execute(message);
                Console.WriteLine(message);
            }
        }
    }

    public static class SerialPortProgram
    {
        // Create the serial port with basic settings
        public static SerialPort port = new SerialPort("COM15", 9600, Parity.None, 8, StopBits.One);

        public static void OpenPort()
        {
            if (port.IsOpen) Console.WriteLine("Port is Already Opened!");
            else
            {
                try
                {
                    port.Open();
                }
                catch (System.IO.IOException message)
                {
                    Console.WriteLine(message.Message);
                }
                Console.WriteLine("COM8 Opened");
            }
        }

        public static void ClosePort()
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Close();
                }
                catch (System.IO.IOException message)
                {
                    Console.Write(message.Message);
                }

                Console.WriteLine("COM8 Closed");
            }
            else
            {
                Console.WriteLine("Port is Already Closed!");
            }
        }

        public static void Execute(string value)
        {
            if (port.IsOpen) { port.Write(value); }
            else { Console.WriteLine("Port is Not Opened!"); }
        }
    }
}
