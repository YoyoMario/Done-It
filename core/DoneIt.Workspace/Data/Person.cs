namespace DoneIt.Workspace.Data
{
    public class Person
    {
        private Guid _guid = default;
        internal Guid _ownerGuid = default;
        internal string _displayName = default!;

        public Person(Guid guid, Guid ownerGuid, string displayName)
        {
            _guid = guid;
            _ownerGuid = ownerGuid;
            _displayName = displayName;
        }
    }
}
