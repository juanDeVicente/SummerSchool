using System;
using System.Collections.Generic;
using System.Linq;

namespace Ahorcado
{
    class Program
    {
        //GLOBALS
        static int fails = 7;
        static string word;
        static bool[] correct;
        static List<char> failLetters;
        static char currentLetter;
        //TREE
        static Entity tree;
        static char[,] pixelsTree = new char[8, 6]
        {
            {' ',' ','_','_', '_', ' '},
            {' ','|',' ',' ', ' ', '|'},
            {' ','|',' ',' ', ' ', ' '},
            {' ','|',' ',' ', ' ', ' '},
            {' ','|',' ',' ', ' ', ' '},
            {' ','|',' ',' ', ' ', ' '},
            {' ','|',' ',' ', ' ', ' '},
            {'/',' ','\\',' ', ' ', ' '}
        };
        //HEAD
        static Entity head;
        static char[,] pixelsHead = new char[1, 1]
        {
            {'O'}
        };
        //BODY
        static Entity body;
        static char[,] pixelsBody = new char[2, 1]
        {
            {'|'},
            {'|'}
        };
        //LEFT ARM
        static Entity leftArm;
        static char[,] pixelsLeftArm = new char[2, 2]
        {
            {' ', '-'},
            {'/', ' '}
        };
        //RIGHT ARM
        static Entity rightArm;
        static char[,] pixelsRightArm = new char[2, 2]
        {
            {'-', ' '},
            {' ', '\\'}
        };
        //LEFT LEG
        static Entity leftLeg;
        static char[,] pixelsLeftLeg = new char[1, 1]
        {
            {'/'}
        };
        //RIGHT LEG
        static Entity rightLeg;
        static char[,] pixelsRightLeg = new char[1, 1]
        {
            {'\\'}
        };
        static void Create()
        {
            failLetters = new List<char>();
            word = ""; 
            while (word == "" || word.Contains(' '))
            {
                Console.Write("Escribe una palabra: ");
                word = Console.ReadLine().ToLower();
                Console.Clear();
            }
            correct = new bool[word.Length];

            Console.Clear();
            Console.CursorVisible = false;

            tree = new Entity(0, 0, pixelsTree);
            head = new Entity(5, 2, pixelsHead);
            body = new Entity(5, 3, pixelsBody);
            leftArm = new Entity(3, 3, pixelsLeftArm);
            rightArm = new Entity(6, 3, pixelsRightArm);
            leftLeg = new Entity(4, 5, pixelsLeftLeg);
            rightLeg = new Entity(6, 5, pixelsRightLeg);
        }
        static void Update()
        {
            bool someCorrect = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == currentLetter)
                {
                    correct[i] = true;
                    someCorrect = true;
                }
            }
            if (!someCorrect)
            {
                fails--;
                if (!failLetters.Contains(currentLetter))
                    failLetters.Add(currentLetter);
            }
        }
        static void Draw()
        {
            tree.Draw();
            if (fails < 7)
                head.Draw();
            if (fails < 6)
                body.Draw();
            if (fails < 5)
                leftArm.Draw();
            if (fails < 4)
                rightArm.Draw();
            if (fails < 3)
                leftLeg.Draw();
            if (fails < 2)
                rightLeg.Draw();
            DrawWord();
            DrawLifes();
            DrawFailLetters();
        }
        static void DrawWord()
        {
            Console.SetCursorPosition(0, 10);
            for(int i = 0; i < word.Length; i++)
                if (correct[i])
                    Console.Write(word[i] + " ");
                else
                    Console.Write("_ ");
        }
        static void DrawLifes()
        {
            Console.Write("    fallos:" + (7 - fails));
        }
        static void DrawFailLetters()
        {
            Console.WriteLine("     letras no válidas: " + string.Join(",", failLetters));
        }
        static void Input()
        {
            Console.WriteLine();
            Console.Write("Escribe una letra: ");
            currentLetter = char.ToLower(Console.ReadKey().KeyChar);
        }
        static void Main(string[] args)
        {
            Create();
            while(fails > 0 && !correct.All(x => x))
            {
                Draw();
                Input();
                Update();
                Console.Clear();
            }
            if (fails == 0)
            {
                Console.WriteLine("Has perdido");
                Console.WriteLine("La palabra es " + word);
            }
            else
                Console.WriteLine("¡¡Has ganado!!");
            Console.ReadKey();
        }
    }
}