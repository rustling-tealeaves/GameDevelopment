namespace DoorMechanism
{
    internal class Program
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
            DoorState state = DoorState.Open;
        }

        static void DoorOpen(PlayerAction action)
        {
            // Hmm could it be done this way instead of four different methods?
        }
    }
}
