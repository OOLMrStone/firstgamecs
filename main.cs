using System;

namespace MyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] myField = {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            char[,] myMask = {
                { '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~' }
            };

            char[,] enemyField1 = {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '#', '~', '~', '~', '#', '~', '#', '~', '#', '~', '.' },
                { '.', '#', '~', '~', '~', '#', '~', '~', '~', '~', '~', '.' },
                { '.', '#', '~', '#', '~', '~', '~', '~', '~', '~', '#', '.' },
                { '.', '#', '~', '~', '~', '~', '#', '#', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '#', '#', '#', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '#', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '#', '~', '~', '~', '~', '.' },
                { '.', '#', '#', '#', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            char[,] enemyField2 = {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '#', '#', '~', '#', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '#', '~', '#', '#', '~', '#', '#', '#', '#', '~', '.' },
                { '.', '#', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '#', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '#', '~', '#', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '#', '~', '~', '~', '~', '~', '#', '#', '~', '.' },
                { '.', '~', '~', '~', '#', '#', '#', '~', '~', '~', '~', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            char[,] enemyField3 = {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '#', '~', '#', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '#', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '#', '~', '#', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '#', '~', '#', '~', '~', '~', '#', '#', '#', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '#', '~', '#', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '#', '~', '~', '#', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '#', '.' },
                { '.', '#', '~', '~', '~', '~', '~', '~', '~', '~', '#', '.' },
                { '.', '~', '~', '~', '~', '#', '#', '~', '~', '~', '#', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            char[,] enemyField4 = {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '#', '~', '#', '~', '~', '~', '~', '~', '~', '#', '.' },
                { '.', '~', '~', '#', '~', '#', '#', '#', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '#', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '#', '~', '~', '~', '#', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '#', '#', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '#', '#', '#', '#', '~', '~', '~', '.' },
                { '.', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '.' },
                { '.', '#', '~', '~', '~', '#', '#', '#', '~', '~', '~', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            string[] myShips = {
                "#", "#", "#", "#",
                "##", "##", "##",
                "###", "###",
                "####"};

            char[,] enemyMask = {
                { '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '?', '?', '?', '?', '?', '?', '?', '?', '?', '?', '~' },
                { '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~' }
            };

            Random mysteryBox = new Random();

            bool playing = true;
            bool shipsPlaced = false;
            bool haveShip;
            bool killedShipDown;
            bool killedShipRight;
            bool killedShipUp;
            bool killedShipLeft;
            bool canBePlaced;
            bool playerTurn = Convert.ToBoolean(mysteryBox.Next(0, 2));
            bool sayHello = true;
            bool pickRandomCell = true;
            bool terminatorMode = false;

            int[] firstShipHit = new int[2];
            int[] tempHit = new int[2];
            int[] myFirstShipHit = new int[2];
            int[] myTempHit = new int[2];

            int nooby = mysteryBox.Next(0, 10);
            int myShipsKilled = 0;
            int enemyShipsKilled = 0;
            int enemyShotY;
            int enemyShotX;
            int shootX, shootY;
            int count;
            int c;

            ConsoleColor defaultColor = Console.ForegroundColor;

            char[,] enemyField = new char[11, 11];
            int randomNumber = mysteryBox.Next(0, 10);
            while (randomNumber >= 4)
            {
                randomNumber = mysteryBox.Next(0, 10);
            }

            switch (randomNumber)
            {
                case 0:
                    enemyField = enemyField1;
                    break;
                case 1:
                    enemyField = enemyField2;
                    break;
                case 2:
                    enemyField = enemyField3;
                    break;
                case 3:
                    enemyField = enemyField4;
                    break;
            }

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("--- SEA BATTLE GAME ---\n");
            Console.WriteLine("Hi, let's play sea battle game!\n");
            Console.WriteLine("Press any button to start...");
            Console.ReadKey();
            Console.Clear();

            while (playing)
            {
                int[,] shipCells = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
                Console.SetCursorPosition(0, 10);
                if (terminatorMode)
                {
                    Console.WriteLine("Field of hopeless:                           Field of your DEATH:\n");
                    Console.WriteLine("            D              I                                E               ");
                }
                else
                {
                    Console.WriteLine("Your field:                                  Enemy field:\n");
                    Console.WriteLine("o  A  B  C  D  E  F  G  H  I  J              o  A  B  C  D  E  F  G  H  I  J");
                }
                for (int y = 1; y < myField.GetLength(0) - 1; y++)
                {
                    Console.Write((y - 1) + "  ");
                    for (int x = 1; x < myField.GetLength(1) - 1; x++)
                    {
                        switch (myField[y, x])
                        {
                            case '~':
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case '#':
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            case '*':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                        }
                        Console.Write(myField[y, x] + "  ");
                        Console.ForegroundColor = defaultColor;
                    }

                    Console.Write("            " + (y - 1) + "  ");

                    for (int x = 1; x < enemyMask.GetLength(1) - 1; x++)
                    {
                        switch (enemyMask[y, x])
                        {
                            case '~':
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case '*':
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            case '?':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                        }
                        Console.Write(enemyMask[y, x] + "  ");
                        Console.ForegroundColor = defaultColor;
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("--- SEA BATTLE GAME ---\n");
                if (!shipsPlaced)
                {
                    shipsPlaced = true;
                    try
                    {
                        Console.WriteLine("Place your ships:");
                        Console.SetCursorPosition(64, 2);
                        Console.WriteLine("Ships left:");
                        Console.SetCursorPosition(64, 3);
                        foreach (string ship in myShips)
                        {
                            Console.Write(ship + " ");
                        }
                        Console.SetCursorPosition(0, 2);
                        Console.Write("Write here the cell where ship begins (EX: A1): ");
                        string tempShipUpLeft = Console.ReadLine().ToUpper();
                        Console.Write("Write here the cell where ship ends (EX: A4): ");
                        string tempShipDownRight = Console.ReadLine().ToUpper();
                        if (tempShipDownRight.Length > 2 || tempShipUpLeft.Length > 2 ||
                            (Convert.ToInt32(tempShipUpLeft[0]) < 65 && Convert.ToInt32(tempShipUpLeft[1]) < 65) ||
                            (Convert.ToInt32(tempShipUpLeft[0]) >= 65 && Convert.ToInt32(tempShipUpLeft[1]) >= 65) ||
                            (Convert.ToInt32(tempShipDownRight[0]) < 65 && Convert.ToInt32(tempShipDownRight[1]) < 65) ||
                            (Convert.ToInt32(tempShipDownRight[0]) >= 65 && Convert.ToInt32(tempShipDownRight[1]) >= 65))
                        {
                            Console.WriteLine("Input seems strange and incorrect.");
                            Console.Write("Press smth to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            shipsPlaced = false;
                            continue;
                        }
                        int tempSize =
                            Math.Abs(Convert.ToInt32(tempShipUpLeft[1]) - Convert.ToInt32(tempShipDownRight[1])) +
                            Math.Abs(Convert.ToInt32(tempShipUpLeft[0]) - Convert.ToInt32(tempShipDownRight[0])) + 1;
                        haveShip = false;
                        for (int i = 0; i < myShips.Length; i++)
                        {
                            if (myShips[i].Length == tempSize && myShips[i] != "-")
                            {
                                haveShip = true;
                                break;
                            }
                        }
                        if (tempShipDownRight[0] == tempShipUpLeft[0])
                        {
                            count = 0;
                            for (int x = 1; x < myField.GetLength(1) - 1; x++)
                            {
                                if ((Convert.ToInt32(tempShipUpLeft[1]) - 47 <= x && x <= Convert.ToInt32(tempShipDownRight[1]) - 47 ||
                                    Convert.ToInt32(tempShipUpLeft[1]) - 47 >= x && x >= Convert.ToInt32(tempShipDownRight[1]) - 47))
                                {
                                    shipCells[count, 0] = x;
                                    shipCells[count, 1] = Convert.ToInt32(tempShipUpLeft[0]) - 64;
                                    count++;
                                }
                            }
                        }
                        else if (tempShipDownRight[1] == tempShipUpLeft[1])
                        {
                            count = 0;
                            for (int x = 1; x < myField.GetLength(1) - 1; x++)
                            {
                                if (Convert.ToInt32(tempShipUpLeft[0]) - 64 <= x && x <= Convert.ToInt32(tempShipDownRight[0]) - 64 ||
                                        Convert.ToInt32(tempShipUpLeft[0]) - 64 >= x && x >= Convert.ToInt32(tempShipDownRight[0]) - 64)
                                {
                                    shipCells[count, 0] = Convert.ToInt32(tempShipUpLeft[1]) - 47;
                                    shipCells[count, 1] = x;
                                    count++;
                                }
                            }
                        }
                        canBePlaced = false;
                        if (haveShip && shipCells[0, 0] != -1)
                        {
                            for (int cell = 0; cell < shipCells.GetLength(0); cell++)
                            {
                                if (shipCells[cell, 0] != -1)
                                {
                                    if (myField[shipCells[cell, 0] - 1, shipCells[cell, 1] - 1] != '#' &&
                                        myField[shipCells[cell, 0] - 1, shipCells[cell, 1]] != '#' &&
                                        myField[shipCells[cell, 0] - 1, shipCells[cell, 1] + 1] != '#' &&
                                        myField[shipCells[cell, 0], shipCells[cell, 1] - 1] != '#' &&
                                        myField[shipCells[cell, 0], shipCells[cell, 1]] != '#' &&
                                        myField[shipCells[cell, 0], shipCells[cell, 1]] != '.' &&
                                        myField[shipCells[cell, 0], shipCells[cell, 1] + 1] != '#' &&
                                        myField[shipCells[cell, 0] + 1, shipCells[cell, 1] - 1] != '#' &&
                                        myField[shipCells[cell, 0] + 1, shipCells[cell, 1]] != '#' &&
                                        myField[shipCells[cell, 0] + 1, shipCells[cell, 1] + 1] != '#')
                                    {
                                        canBePlaced = true;
                                    }
                                    else
                                    {
                                        canBePlaced = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if (haveShip && canBePlaced)
                        {
                            Console.WriteLine("The ship sails to the battlefield...");
                            for (int i = 0; i < myShips.Length; i++)
                            {
                                if (myShips[i].Length == tempSize && myShips[i] != "-")
                                {
                                    myShips[i] = "-";
                                    break;
                                }
                            }
                            for (int pos = 0; pos < shipCells.GetLength(0); pos++)
                            {
                                if (shipCells[pos, 0] != -1)
                                {
                                    myField[shipCells[pos, 0], shipCells[pos, 1]] = '#';
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have no ships like this or this ship can't be placed.\n" +
                                "Ship need to have at least one free cell between itself and another ship.");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input seems strange and incorrect.");
                    }
                    Console.Write("Press smth to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    foreach (string ship in myShips)
                    {
                        if (ship != "-")
                        {
                            shipsPlaced = false;
                            break;
                        }
                    }
                }
                else if (shipsPlaced)
                {
                    if (sayHello)
                    {
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Congratulations! You have succesfully placed the ships. Now battle begins...");
                        Console.Write("Just a little question, wanna play HARDCORE? Answer YES/NO: ");
                        string answer = Console.ReadLine();
                        if (answer.ToUpper() == "NO")
                        {
                            terminatorMode = false;
                        }
                        else if (answer.ToUpper() == "YES")
                        {
                            terminatorMode = true;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ENTERING TERMINATOR MODE...");
                            Console.ForegroundColor = defaultColor;
                        }
                        else
                        {
                            Console.WriteLine("I think you mean YES...");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ENTERING TERMINATOR MODE...");
                            Console.ForegroundColor = defaultColor;
                            terminatorMode = true;
                        }
                        Console.WriteLine("Press any button to start...");
                        Console.ReadKey();
                        Console.Clear();
                        sayHello = false;
                        Console.SetCursorPosition(0, 10);
                        if (terminatorMode)
                        {
                            playerTurn = true;
                            Console.WriteLine("Field of hopeless:                           Field of your DEATH:\n");
                            Console.WriteLine("            D              I                                E               ");
                        }
                        else
                        {
                            Console.WriteLine("Your field:                                  Enemy field:\n");
                            Console.WriteLine("o  A  B  C  D  E  F  G  H  I  J              o  A  B  C  D  E  F  G  H  I  J");
                        }
                        for (int y = 1; y < myField.GetLength(0) - 1; y++)
                        {
                            Console.Write((y - 1) + "  ");
                            for (int x = 1; x < myField.GetLength(1) - 1; x++)
                            {
                                switch (myField[y, x])
                                {
                                    case '~':
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;
                                    case '#':
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        break;
                                    case '*':
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        break;
                                }
                                Console.Write(myField[y, x] + "  ");
                                Console.ForegroundColor = defaultColor;
                            }

                            Console.Write("            " + (y - 1) + "  ");

                            for (int x = 1; x < enemyMask.GetLength(1) - 1; x++)
                            {
                                switch (enemyMask[y, x])
                                {
                                    case '~':
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;
                                    case '*':
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        break;
                                    case '?':
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        break;
                                }
                                Console.Write(enemyMask[y, x] + "  ");
                                Console.ForegroundColor = defaultColor;
                            }
                            Console.WriteLine();
                        }
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("--- SEA BATTLE GAME ---\n");
                    }
                    Console.SetCursorPosition(84, 5);
                    Console.WriteLine($"You have {10 - myShipsKilled}/10 ships left.");
                    Console.SetCursorPosition(84, 6);
                    Console.WriteLine($"Enemy has {10 - enemyShipsKilled}/10 ships left.");
                    Console.SetCursorPosition(84, 2);
                    if (playerTurn)
                    {
                        shootY = 0;
                        shootX = 0;
                        Console.WriteLine("Now it is your turn!");
                        if (nooby < 7)
                        {
                            Console.SetCursorPosition(84, 3);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Have you tried writing /r?\n");
                            Console.ForegroundColor = defaultColor;
                            nooby = 8;
                        }
                        Console.SetCursorPosition(0, 2);
                        Console.Write("Select a cell you want to shoot (EX: A1): ");
                        string shootPos = Console.ReadLine().ToUpper();
                        if (shootPos == "/R")
                        {
                            if (mysteryBox.Next(0, 50) != 44)
                            {
                                shootY = mysteryBox.Next(1, 11);
                                shootX = mysteryBox.Next(1, 11);
                                while (enemyMask[shootY, shootX] != '?')
                                {
                                    shootY = mysteryBox.Next(1, 11);
                                    shootX = mysteryBox.Next(1, 11);
                                }
                                Console.WriteLine($"The great god of randomness says that you should shoot {Convert.ToChar(shootX + 64)}{shootY - 1}.\nYou follow the advice...");
                            }
                            else
                            {
                                Console.WriteLine("The great god of randomness is sleeping. Do not disturb him, please.");
                            }
                        }
                        else if (shootPos.Length > 2 || shootPos.Length < 2 ||
                            (Convert.ToInt32(shootPos[0]) < 65 && Convert.ToInt32(shootPos[1]) < 65) ||
                            (Convert.ToInt32(shootPos[0]) >= 65 && Convert.ToInt32(shootPos[1]) >= 65))
                        {
                            Console.WriteLine("Try shoot again.");
                            Console.Write("Press any button to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        if (shootY == 0)
                        {
                            shootX = shootPos[0] - 64;
                            shootY = shootPos[1] - 47;
                        }
                        if (shootX < 1 || shootX > 10 || shootY < 1 || shootY > 10)
                        {
                            Console.WriteLine("Try shoot again.");
                            Console.Write("Press any button to continue... ");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        else if (enemyMask[shootY, shootX] != '?')
                        {
                            Console.WriteLine("Wasting ammo isn't a good idea.\n" +
                                "Don't shoot somewhere, you already have shot.");
                            Console.Write("Press any button to continue... ");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            if (enemyField[shootY, shootX] == '~')
                            {
                                enemyMask[shootY, shootX] = '~';
                                int message = mysteryBox.Next(0, 3);
                                switch (message)
                                {
                                    case 0:
                                        Console.WriteLine("Congratulations! You have shot at nothing!");
                                        break;
                                    case 1:
                                        Console.WriteLine("The water has rippled. That's all you got.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Enemy is happy, because you missed.");
                                        break;
                                }
                                playerTurn = false;
                            }
                            else if (enemyField[shootY, shootX] == '#')
                            {
                                enemyField[shootY, shootX] = '*';
                                enemyMask[shootY, shootX] = '*';
                                enemyMask[shootY - 1, shootX - 1] = '~';
                                enemyMask[shootY + 1, shootX - 1] = '~';
                                enemyMask[shootY + 1, shootX + 1] = '~';
                                enemyMask[shootY - 1, shootX + 1] = '~';
                                if (myFirstShipHit[0] == 0 || !(myFirstShipHit[0] == shootY || myFirstShipHit[1] == shootX))
                                {
                                    myFirstShipHit[0] = shootY;
                                    myFirstShipHit[1] = shootX;
                                }
                                else
                                {
                                    for (int y = Min(myFirstShipHit[0], shootY); y <= Max(myFirstShipHit[0], shootY); y++)
                                    {
                                        for (int x = Min(myFirstShipHit[1], shootX); x <= Max(myFirstShipHit[1], shootX); x++)
                                        {
                                            if (myField[y, x] == '~')
                                            {
                                                myFirstShipHit[0] = shootY;
                                                myFirstShipHit[1] = shootX;
                                            }
                                        }
                                    }
                                }
                                myTempHit[0] = shootY;
                                myTempHit[1] = shootX;
                                if (enemyField[shootY + 1, shootX] == '*')
                                {
                                    c = 2;
                                    while (enemyField[shootY + c, shootX] == '*')
                                    {
                                        c++;
                                    }
                                    if (enemyField[shootY + c, shootX] == '~' || enemyField[shootY + c, shootX] == '.')
                                    {
                                        killedShipDown = true;
                                    }
                                    else
                                    {
                                        killedShipDown = false;
                                    }
                                }
                                else if (enemyField[shootY + 1, shootX] == '~' || enemyField[shootY + 1, shootX] == '.')
                                {
                                    killedShipDown = true;
                                }
                                else
                                {
                                    killedShipDown = false;
                                }
                                if (enemyField[shootY, shootX + 1] == '*')
                                {
                                    c = 2;
                                    while (enemyField[shootY, shootX + c] == '*')
                                    {
                                        c++;
                                    }
                                    if (enemyField[shootY, shootX + c] == '~' || enemyField[shootY, shootX + c] == '.')
                                    {
                                        killedShipRight = true;
                                    }
                                    else
                                    {
                                        killedShipRight = false;
                                    }
                                }
                                else if (enemyField[shootY, shootX + 1] == '~' || enemyField[shootY, shootX + 1] == '.')
                                {
                                    killedShipRight = true;
                                }
                                else
                                {
                                    killedShipRight = false;
                                }
                                if (enemyField[shootY - 1, shootX] == '*')
                                {
                                    c = 2;
                                    while (enemyField[shootY - c, shootX] == '*')
                                    {
                                        c++;
                                    }
                                    if (enemyField[shootY - c, shootX] == '~' || enemyField[shootY - c, shootX] == '.')
                                    {
                                        killedShipUp = true;
                                    }
                                    else
                                    {
                                        killedShipUp = false;
                                    }
                                }
                                else if (enemyField[shootY - 1, shootX] == '~' || enemyField[shootY - 1, shootX] == '.')
                                {
                                    killedShipUp = true;
                                }
                                else
                                {
                                    killedShipUp = false;
                                }
                                if (enemyField[shootY, shootX - 1] == '*')
                                {
                                    c = 2;
                                    while (enemyField[shootY, shootX - c] == '*')
                                    {
                                        c++;
                                    }
                                    if (enemyField[shootY, shootX - c] == '~' || enemyField[shootY, shootX - c] == '.')
                                    {
                                        killedShipLeft = true;
                                    }
                                    else
                                    {
                                        killedShipLeft = false;
                                    }
                                }
                                else if (enemyField[shootY, shootX - 1] == '~' || enemyField[shootY, shootX - 1] == '.')
                                {
                                    killedShipLeft = true;
                                }
                                else
                                {
                                    killedShipLeft = false;
                                }
                                if (killedShipUp && killedShipRight && killedShipLeft && killedShipDown)
                                {
                                    Console.WriteLine("ENEMY'S SHIP IS GOING UNDERWATER!");
                                    enemyShipsKilled++;

                                    c = 1;
                                    while (enemyMask[myFirstShipHit[0] + c, myFirstShipHit[1]] == '*')
                                        c++;
                                    enemyMask[myFirstShipHit[0] + c, myFirstShipHit[1]] = '~';
                                    c = 1;
                                    while (enemyMask[myFirstShipHit[0] - c, myFirstShipHit[1]] == '*')
                                        c++;
                                    enemyMask[myFirstShipHit[0] - c, myFirstShipHit[1]] = '~';
                                    c = 1;
                                    while (enemyMask[myFirstShipHit[0], myFirstShipHit[1] + c] == '*')
                                        c++;
                                    enemyMask[myFirstShipHit[0], myFirstShipHit[1] + c] = '~';
                                    c = 1;
                                    while (enemyMask[myFirstShipHit[0], myFirstShipHit[1] - c] == '*')
                                        c++;
                                    enemyMask[myFirstShipHit[0], myFirstShipHit[1] - c] = '~';

                                    myFirstShipHit[0] = 0;
                                    myFirstShipHit[1] = 0;
                                }
                                else
                                {
                                    Console.WriteLine("GOOD JOB! YOU HIT THE TARGET!");
                                }
                            }
                        }
                        Console.Write("Press any button to continue... ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Now it is enemy's turn.");
                        if (pickRandomCell)
                        {
                            if (terminatorMode)
                            {
                                enemyShotY = mysteryBox.Next(1, 11);
                                enemyShotX = mysteryBox.Next(1, 11);
                                while (myField[enemyShotY, enemyShotX] != '#')
                                {
                                    enemyShotY = mysteryBox.Next(1, 11);
                                    enemyShotX = mysteryBox.Next(1, 11);
                                }
                            }
                            else
                            {
                                enemyShotY = mysteryBox.Next(1, 11);
                                enemyShotX = mysteryBox.Next(1, 11);
                                while (myMask[enemyShotY, enemyShotX] != '?')
                                {
                                    enemyShotY = mysteryBox.Next(1, 11);
                                    enemyShotX = mysteryBox.Next(1, 11);
                                }
                            }
                        }
                        else
                        {
                            enemyShotY = 0;
                            enemyShotX = 0;
                            int[,] nearCells = { { tempHit[0] - 1, tempHit[1] }, { tempHit[0], tempHit[1] + 1 }, { tempHit[0] + 1, tempHit[1] }, { tempHit[0], tempHit[1] - 1 }, };
                            for (int cell = 0; cell < nearCells.GetLength(0); cell++)
                            {
                                if (myMask[nearCells[cell, 0], nearCells[cell, 1]] == '?')
                                {
                                    enemyShotY = nearCells[cell, 0];
                                    enemyShotX = nearCells[cell, 1];
                                    break;
                                }
                            }
                            if (enemyShotY == 0)
                            {
                                int[,] firstCells = { { firstShipHit[0] - 1, firstShipHit[1] }, { firstShipHit[0], firstShipHit[1] + 1 }, { firstShipHit[0] + 1, firstShipHit[1] }, { firstShipHit[0], firstShipHit[1] - 1 }, };
                                for (int cell = 0; cell < firstCells.GetLength(0); cell++)
                                {
                                    if (myMask[firstCells[cell, 0], firstCells[cell, 1]] == '?')
                                    {
                                        enemyShotY = firstCells[cell, 0];
                                        enemyShotX = firstCells[cell, 1];
                                        break;
                                    }
                                }
                            }
                        }
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine($"After thinking a lot, enemy finally shoots {Convert.ToChar(enemyShotX + 64)}{Convert.ToChar(enemyShotY + 47)}");
                        if (myField[enemyShotY, enemyShotX] == '~')
                        {
                            myMask[enemyShotY, enemyShotX] = '~';
                            Console.WriteLine("You can stay calm, enemy missed, and now it is your turn!");
                            playerTurn = true;
                        }
                        else
                        {
                            int message = mysteryBox.Next(0, 3);
                            switch (message)
                            {
                                case 0:
                                    Console.WriteLine("ENEMY HITS YOUR SHIP! AND HE CONTINUES SHOOTING!\nTHIS IS VERY VERY BAAAAAAAAAAAAD!!!");
                                    break;
                                case 1:
                                    Console.WriteLine("You can't keep calm, but you have to keep your attention. Enemy hits your ship.");
                                    break;
                                case 2:
                                    Console.WriteLine("A piece of ship is going underwater, because enemy have done such a great shot!");
                                    break;
                            }
                            playerTurn = false;
                            myField[enemyShotY, enemyShotX] = '*';
                            myMask[enemyShotY, enemyShotX] = '*';
                            myMask[enemyShotY - 1, enemyShotX - 1] = '~';
                            myMask[enemyShotY + 1, enemyShotX - 1] = '~';
                            myMask[enemyShotY + 1, enemyShotX + 1] = '~';
                            myMask[enemyShotY - 1, enemyShotX + 1] = '~';
                            if (firstShipHit[0] == 0)
                            {
                                firstShipHit[0] = enemyShotY;
                                firstShipHit[1] = enemyShotX;
                            }
                            tempHit[0] = enemyShotY;
                            tempHit[1] = enemyShotX;
                            if (myField[enemyShotY + 1, enemyShotX] == '*')
                            {
                                c = 2;
                                while (myField[enemyShotY + c, enemyShotX] == '*')
                                {
                                    c++;
                                }
                                if (myField[enemyShotY + c, enemyShotX] == '~' || myField[enemyShotY + c, enemyShotX] == '.')
                                {
                                    killedShipDown = true;
                                }
                                else
                                {
                                    killedShipDown = false;
                                }
                            }
                            else if (myField[enemyShotY + 1, enemyShotX] == '~' || myField[enemyShotY + 1, enemyShotX] == '.')
                            {
                                killedShipDown = true;
                            }
                            else
                            {
                                killedShipDown = false;
                            }
                            if (myField[enemyShotY, enemyShotX + 1] == '*')
                            {
                                c = 2;
                                while (myField[enemyShotY, enemyShotX + c] == '*')
                                {
                                    c++;
                                }
                                if (myField[enemyShotY, enemyShotX + c] == '~' || myField[enemyShotY, enemyShotX + c] == '.')
                                {
                                    killedShipRight = true;
                                }
                                else
                                {
                                    killedShipRight = false;
                                }
                            }
                            else if (myField[enemyShotY, enemyShotX + 1] == '~' || myField[enemyShotY, enemyShotX + 1] == '.')
                            {
                                killedShipRight = true;
                            }
                            else
                            {
                                killedShipRight = false;
                            }
                            if (myField[enemyShotY - 1, enemyShotX] == '*')
                            {
                                c = 2;
                                while (myField[enemyShotY - c, enemyShotX] == '*')
                                {
                                    c++;
                                }
                                if (myField[enemyShotY - c, enemyShotX] == '~' || myField[enemyShotY - c, enemyShotX] == '.')
                                {
                                    killedShipUp = true;
                                }
                                else
                                {
                                    killedShipUp = false;
                                }
                            }
                            else if (myField[enemyShotY - 1, enemyShotX] == '~' || myField[enemyShotY - 1, enemyShotX] == '.')
                            {
                                killedShipUp = true;
                            }
                            else
                            {
                                killedShipUp = false;
                            }
                            if (myField[enemyShotY, enemyShotX - 1] == '*')
                            {
                                c = 2;
                                while (myField[enemyShotY, enemyShotX - c] == '*')
                                {
                                    c++;
                                }
                                if (myField[enemyShotY, enemyShotX - c] == '~' || myField[enemyShotY, enemyShotX - c] == '.')
                                {
                                    killedShipLeft = true;
                                }
                                else
                                {
                                    killedShipLeft = false;
                                }
                            }
                            else if (myField[enemyShotY, enemyShotX - 1] == '~' || myField[enemyShotY, enemyShotX - 1] == '.')
                            {
                                killedShipLeft = true;
                            }
                            else
                            {
                                killedShipLeft = false;
                            }
                            if (killedShipUp && killedShipRight && killedShipLeft && killedShipDown)
                            {
                                pickRandomCell = true;
                                Console.WriteLine("Your ship is going underwater. That's a pity :(");
                                myShipsKilled++;

                                c = 1;
                                while (myMask[firstShipHit[0] + c, firstShipHit[1]] == '*')
                                    c++;
                                myMask[firstShipHit[0] + c, firstShipHit[1]] = '~';
                                c = 1;
                                while (myMask[firstShipHit[0] - c, firstShipHit[1]] == '*')
                                    c++;
                                myMask[firstShipHit[0] - c, firstShipHit[1]] = '~';
                                c = 1;
                                while (myMask[firstShipHit[0], firstShipHit[1] + c] == '*')
                                    c++;
                                myMask[firstShipHit[0], firstShipHit[1] + c] = '~';
                                c = 1;
                                while (myMask[firstShipHit[0], firstShipHit[1] - c] == '*')
                                    c++;
                                myMask[firstShipHit[0], firstShipHit[1] - c] = '~';

                                firstShipHit[0] = 0;
                                firstShipHit[1] = 0;
                            }
                            else
                            {
                                if (terminatorMode)
                                {
                                    pickRandomCell = true;
                                }
                                else
                                {
                                    pickRandomCell = false;
                                }
                            }
                        }
                        Console.Write("Press any button to continue... ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                if (myShipsKilled == 10 || enemyShipsKilled == 10)
                {
                    playing = false;
                }
            }

            // GAME END

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("--- SEA BATTLE GAME ---\n");
            if (terminatorMode)
            {
                if (myShipsKilled < enemyShipsKilled)
                {
                    Console.WriteLine("HOW. YOU. DID. THIS. YOU WON, BUT HOW???");
                }
                else
                {
                    Console.WriteLine("You lost and that's so strange because it was very easy to win...");

                }
            }
            else
            {
                if (myShipsKilled < enemyShipsKilled)
                {
                    Console.WriteLine("CONGRATULATIONS, YOU WON!");
                }
                else
                {
                    Console.WriteLine("You lost hahahahahah, that's so sad hahahhahahahhahahahaha.");
                }
            }
            Console.WriteLine("Thanks for playing my sea battle game. I hope you like it. Good bye!");
            Console.WriteLine("\nGame released on February 7, 2023. All rights reserved.");
        }
        static private int Min(int a, int b)
        {
            if (a >= b)
            {
                return b;
            }
            return a;
        }
        static private int Max(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }
    }
}
