namespace DoorMechanism
{
    internal class DoorMechanism
    {
        // Enums for door states and player actions
        enum DoorState
        {
            open,
            closed,
            locked,
            undefined
        }
        // Numerical values allow for conversion to integer and back
        enum PlayerAction
        {
            Open = 0,
            Lock = 1,
            Unlock = 2,
            Close = 3,
            Enter = 4
        }

        static void Main(string[] args)
        {
            // Set the starting state for the door
            DoorState doorState = DoorState.closed;
            Console.WriteLine("You encounter a tricky door.");
            Console.WriteLine("Some common door related actions include:");
            string[] choices = Enum.GetNames(typeof(PlayerAction));
            for (int i = 0; i < choices.Length - 1; i++)
            {
                Console.WriteLine($"{i}: {choices[i]}");
            }

            DoorAction(doorState);
        }

        /* A started attempt of making what DoorAction was always supposed to be
        static PlayerAction ChooseAction()
        {
            Console.WriteLine("Now, what shall you do?");
            string decision = Console.ReadLine();

            if (decision == "0" || decision == "Open" || decision == "open")
                return PlayerAction.Open;

            return (PlayerAction) 2;
        }
        */

        /* The silly thing that DoorAction accidentally became, preserved for legacy
        static void DoorAction(DoorState doorState, PlayerAction playerAction)
        {

            switch (playerAction)
            {
                case PlayerAction.Open:
                    DoorOpen(doorState);
                    break;
                case PlayerAction.Lock:
                    DoorLock(doorState);
                    break;
                case PlayerAction.Unlock:
                    DoorUnlock(doorState);
                    break;
                case PlayerAction.Close:
                    DoorClose(doorState);
                    break;
            }
        }
        */

        static DoorState DoorAction(DoorState doorState)
        {
            Console.WriteLine("Now, what shall you do?");
            string decision = Console.ReadLine();

            if (decision == "0" || decision == "Open" || decision == "open")
            {
                DoorOpen(doorState);
                return doorState;
            }
            else if (decision == "1" || decision == "Lock" || decision == "lock")
            {
                DoorLock(doorState);
                return doorState;
            }
            else if (decision == "2" || decision == "Unlock" || decision == "unlock")
            {
                DoorUnlock(doorState);
                return doorState;
            }
            else if (decision == "3" || decision == "Close" || decision == "close")
            {
                DoorClose(doorState);
                return doorState;
            }
            else if ((decision == "4" || decision == "Enter" || decision == "enter") && doorState == DoorState.open)
            {
                Console.WriteLine($"Through the {doorState} door, you successfully escape.");
                doorState = DoorState.undefined;
                return doorState;
            }
            else
            {
                Console.WriteLine($"You're not sure how you would do that. The door remains {doorState}.");
                return doorState;
            }
        }

        static DoorState DoorOpen(DoorState doorState)
        {
            Console.WriteLine("You try to open the door.");
            switch (doorState)
            {
                case DoorState.open:
                    Console.WriteLine($"The door is already {doorState}.");
                    return DoorState.open;
                case DoorState.closed:
                    doorState = DoorState.open;
                    Console.WriteLine($"You successfully open the door. It is now {doorState}.");
                    return DoorState.open;
                case DoorState.locked:
                    Console.WriteLine($"The door is {doorState}.");
                    return DoorState.locked;
                default:
                    Console.WriteLine($"It seems the door no longer heeds the common laws of physics.");
                    return doorState;
            }
        }

        static DoorState DoorLock(DoorState doorState)
        {
            Console.WriteLine("You try to lock the door.");
            switch (doorState)
            {
                case DoorState.open:
                    Console.WriteLine($"The door is {doorState}.");
                    return DoorState.open;
                case DoorState.closed:
                    doorState = DoorState.locked;
                    Console.WriteLine($"You successfully lock the door. It is now {doorState}.");
                    return DoorState.locked;
                case DoorState.locked:
                    Console.WriteLine($"The door is already {doorState}.");
                    return DoorState.locked;
                default:
                    Console.WriteLine($"It seems the door no longer heeds the common laws of physics.");
                    return doorState;
            }
        }

        static DoorState DoorUnlock(DoorState doorState)
        {
            Console.WriteLine("You try to unlock the door.");
            switch (doorState)
            {
                case DoorState.open:
                    Console.WriteLine($"The door is {doorState}.");
                    return DoorState.open;
                case DoorState.closed:
                    Console.WriteLine($"The door is already unlocked. It remains {doorState}.");
                    return DoorState.closed;
                case DoorState.locked:
                    doorState = DoorState.closed;
                    Console.WriteLine($"You successfully unlock the door. It is still {doorState}.");
                    return DoorState.closed;
                default:
                    Console.WriteLine($"It seems the door no longer heeds the common laws of physics.");
                    return doorState;
            }
        }

        static DoorState DoorClose(DoorState doorState)
        {
            Console.WriteLine("You try to close the door.");
            switch (doorState)
            {
                case DoorState.open:
                    doorState = DoorState.closed;
                    Console.WriteLine($"You successfully close the door. It is now {doorState}.");
                    return DoorState.closed;
                case DoorState.closed:
                    Console.WriteLine($"The door is already {doorState}.");
                    return DoorState.closed;
                case DoorState.locked:
                    Console.WriteLine($"The door is {doorState}.");
                    return DoorState.locked;
                default:
                    Console.WriteLine($"It seems the door no longer heeds the common laws of physics.");
                    return doorState;
            }
        }

    }
}
