namespace Plumber.Api.States
{
    public abstract class State
    {
        protected readonly Concierge Concierge;

        public const string Enter = "Enter";
        public const string Leave = "Leave";

        protected State(Concierge concierge)
        {
            Concierge = concierge;
        }

        public abstract void HandleEnterRoomRequest();
        public abstract void HandleLeaveRoomRequest();
    }
}