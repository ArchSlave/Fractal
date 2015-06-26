using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace MakeMaker
{
    class Program
    {
        static void Impossibru()
        {
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(587, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(554, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(523, 1200);
            Thread.Sleep(150);
            Console.Beep(466, 150);
            Console.Beep(523, 150);
        }

        static void Imperial()
        {
            int f = 349;
            int gS = 415;
            int a = 440;
            int aS = 455;
            int b = 466;
            int cH = 523;
            int cSH = 554;
            int dH = 587;
            int dSH = 622;
            int eH = 659;
            int fH = 698;
            int fSH = 740;
            int gH = 784;
            int gSH = 830;
            int aH = 880;

            Console.Beep(a, 500);
            Console.Beep(a, 500);
            Console.Beep(a, 500);
            Console.Beep(f, 350);
            Console.Beep(cH, 150);
            Console.Beep(a, 500);
            Console.Beep(f, 350);
            Console.Beep(cH, 150);
            Console.Beep(a, 650);

            Thread.Sleep(150);
            //end of first bit

            Console.Beep(eH, 500);
            Console.Beep(eH, 500);
            Console.Beep(eH, 500);
            Console.Beep(fH, 350);
            Console.Beep(cH, 150);
            Console.Beep(gS, 500);
            Console.Beep(f, 350);
            Console.Beep(cH, 150);
            Console.Beep(a, 650);

            Thread.Sleep(150);
            //end of second bit...

            Console.Beep(aH, 500);
            Console.Beep(a, 300);
            Console.Beep(a, 150);
            Console.Beep(aH, 400);
            Console.Beep(gSH, 200);
            Console.Beep(gH, 200);
            Console.Beep(fSH, 125);
            Console.Beep(fH, 125);
            Console.Beep(fSH, 250);

            Thread.Sleep(250);

            Console.Beep(aS, 250);
            Console.Beep(dSH, 400);
            Console.Beep(dH, 200);
            Console.Beep(cSH, 200);
            Console.Beep(cH, 125);
            Console.Beep(b, 125);
            Console.Beep(cH, 250);

            Thread.Sleep(250);

            Console.Beep(f, 125);
            Console.Beep(gS, 500);
            Console.Beep(f, 375);
            Console.Beep(a, 125);
            Console.Beep(cH, 500);
            Console.Beep(a, 375);
            Console.Beep(cH, 125);
            Console.Beep(eH, 650);

            //end of third bit... (Though it doesn't play well)
            //let's repeat it

            Console.Beep(aH, 500);
            Console.Beep(a, 300);
            Console.Beep(a, 150);
            Console.Beep(aH, 400);
            Console.Beep(gSH, 200);
            Console.Beep(gH, 200);
            Console.Beep(fSH, 125);
            Console.Beep(fH, 125);
            Console.Beep(fSH, 250);

            Thread.Sleep(250);

            Console.Beep(aS, 250);
            Console.Beep(dSH, 400);
            Console.Beep(dH, 200);
            Console.Beep(cSH, 200);
            Console.Beep(cH, 125);
            Console.Beep(b, 125);
            Console.Beep(cH, 250);

            Thread.Sleep(250);

            Console.Beep(f, 250);
            Console.Beep(gS, 500);
            Console.Beep(f, 375);
            Console.Beep(cH, 125);
            Console.Beep(a, 500);
            Console.Beep(f, 375);
            Console.Beep(cH, 125);
            Console.Beep(a, 650);
            //end of the song
        }

        static void Mario()
        {
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(392, 125);
            Thread.Sleep(375);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(880, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(880, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(375);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(698, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
            Thread.Sleep(1125);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(698, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
            Thread.Sleep(625);
        }

        static void Tetris()
        {
            Console.Beep(658, 125);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
        }

        static void PlayRandomMusic()
        {
            var rand = new Random();
            while (true)
            {
                switch (rand.Next(0, 3))
                {
                    case 0:
                        {
                            Impossibru();
                            break;
                        }
                    case 1:
                        {
                            Imperial();
                            break;
                        }
                    case 2:
                        {
                            Mario();
                            break;
                        }
                    case 3:
                        {
                            Tetris();
                            break;
                        }
                }
            }
        }

        static void IziShortcut(string name, string target)
        {
            Console.WriteLine("Tentando criar o shortcut para: " + name);
            Type t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")); //Windows Script Host Shell Object
            dynamic shell = Activator.CreateInstance(t);
            try
            {
                var lnk = shell.CreateShortcut(name);
                try
                {
                    lnk.TargetPath = target;
                    lnk.IconLocation = "shell32.dll, 1";
                    lnk.Save();
                }
                finally
                {
                    Marshal.FinalReleaseComObject(lnk);
                }
            }
            finally
            {
                Marshal.FinalReleaseComObject(shell);
            }
        }

        static void CreateFrigginShortcuts()
        {
            string localFolder = System.Reflection.Assembly.GetEntryAssembly().Location;
            localFolder = Path.GetDirectoryName(localFolder);

            string vanillaInputPath = Path.Combine(localFolder, @"Solutions\Vanilla\x64\Release\Vanilla.exe");
            string cppInputPath = Path.Combine(localFolder, @"Solutions\Cpp Improved\x64\Release\Cpp Improved.exe");
            string csharpInputPath = Path.Combine(localFolder, @"Solutions\CSharp\CSharp\bin\x64\Release\CSharp.exe");
            string diverInputPath = Path.Combine(localFolder, @"C:\Users\Thiago\Documents\GitHub\Fractal\Solutions\Zooming\Zooming\bin\x64\Release\Zooming.exe");

            string vanillaOutputPath = Path.Combine(localFolder, "Vanilla.lnk");
            string cppOutputPath = Path.Combine(localFolder, "Cpp Improved.lnk");
            string csharpOutputPath = Path.Combine(localFolder, "CSharp.lnk");
            string diveOutputPath = Path.Combine(localFolder, "Fractal Diver.lnk");

            try
            {
                IziShortcut(vanillaOutputPath, vanillaInputPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                IziShortcut(cppOutputPath, cppInputPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Hey, se pa a pasta Cpp Improved não foi descompactada.");
            }

            try
            {
                IziShortcut(csharpOutputPath, csharpInputPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                IziShortcut(diveOutputPath, diverInputPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Então... Eu sei que eu deveria fazer um .bat que chama os  compiladores de cada projeto...");
            Console.WriteLine("Mas fazer .bat é complicado e não vale o tempo gasto... Até pq eu teria que aprender" + Environment.NewLine +
                " a syntax da linguagem de scripting...");
            Console.WriteLine("Então eu vou simplesmente criar shortcuts para os executaveis já compilados, ok?");
            Console.WriteLine("Para compensar eu coloquei um easter egg nesse make file ._.");
            Console.WriteLine("Aumente o volume para ouvi-lo ._.");
            Task.Run(() => PlayRandomMusic());
            CreateFrigginShortcuts();

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
