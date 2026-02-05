namespace DoorMechanism
{
    internal class DoorMechanism
    {
        // Enums for door states and player actions
        enum DoorState
        {
            Open,
            Closed,
            Locked
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
            DoorState doorState = DoorState.Open;
            // Ask what PlayerAction, store into playerAction
            PlayerAction playerAction = PlayerAction.Open;
            // Placeholder so the methods I'm working on are bright in the editor
            DoorAction(doorState, playerAction);
        }

        static void DoorAction(DoorState doorState, PlayerAction playerAction)
        {
            // Placeholders so the methods I'm working on are bright in the editor
            DoorOpen(doorState);
            DoorLock();
            DoorUnlock();
            DoorClose();
        }

        static void DoorOpen(DoorState doorState)
        {
            Console.WriteLine("You try to open the door.");
            if (doorState == DoorState.Closed)
            {
                doorState = DoorState.Open;
                Console.WriteLine($"You successfully open the door. It is now {doorState}");
            }
        }
        static void DoorLock()
        {
            Console.WriteLine("You try to lock the door.");
        }
        static void DoorUnlock()
        {
            Console.WriteLine("You try to unlock the door.");
        }
        static void DoorClose()
        {
            Console.WriteLine("You try to close the door.");
        }
    }
}
