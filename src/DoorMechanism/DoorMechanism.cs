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
            // Placeholder so the methods I'm working on are bright in the editor
            DoorAction();
        }

        static void DoorAction()
        {
            // Hmm could it be done this way instead of four different methods?
            // Or perhaps... both?
            // Placeholders so the methods I'm working on are bright in the editor
            DoorOpen();
            DoorLock();
            DoorUnlock();
            DoorClose();
        }

        static void DoorOpen()
        {
            Console.WriteLine("You try to open the door.");
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
