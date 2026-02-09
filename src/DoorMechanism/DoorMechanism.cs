namespace DoorMechanism
{
    internal class DoorMechanism
    {
        // Enums for door states and player actions
        enum DoorState
        {
            open,
            closed,
            locked
        }
        // Numerical values allow for conversion to integer and back
        enum PlayerAction
        {
            Open = 0,
            Lock = 1,
            Unlock = 2,
            Close = 3
        }

        static void Main(string[] args)
        {
            // Set the starting state for the door
            DoorState doorState = DoorState.open;
            // Ask what PlayerAction, store into playerAction
            // TODO
            PlayerAction playerAction = PlayerAction.Open;
            // Placeholder so the methods I'm working on are bright in the editor
            DoorAction(doorState, playerAction);
        }

        static void DoorAction(DoorState doorState, PlayerAction playerAction)
        {
            // Placeholders so the methods I'm working on are bright in the editor
            DoorOpen(doorState);
            DoorLock(doorState);
            DoorUnlock(doorState);
            DoorClose(doorState);
        }

        static DoorState DoorOpen(DoorState doorState)
        {
            Console.WriteLine("You try to open the door.");
            if (doorState == DoorState.closed)
            {
                doorState = DoorState.open;
                Console.WriteLine($"You successfully open the door. It is now {doorState}");
                return DoorState.open;
            }
            else if (doorState == DoorState.locked)
            {
                Console.WriteLine($"The door is {doorState}");
            }
            else if (doorState == DoorState.open)
            {
                Console.WriteLine($"The door is already {doorState}");
            }
            else
            {
                Console.WriteLine($"You're not sure how you would do that. The door remains {doorState}");
            }
            return doorState;
        }

        static void DoorLock(DoorState doorState)
        {
            Console.WriteLine("You try to lock the door.");
        }
        static void DoorUnlock(DoorState doorState)
        {
            Console.WriteLine("You try to unlock the door.");
        }
        static void DoorClose(DoorState doorState)
        {
            Console.WriteLine("You try to close the door.");
        }
    }
}
