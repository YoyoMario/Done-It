namespace DoneIt.Workspace.Data
{
    public class Project
    {
        public Guid _guid = default;
        public Guid _clientGuid = default;
        public Guid _ownerGuid = default;
        public string _title = default!;

        public Project(Guid guid, Guid clientGuid, Guid ownerGuid, string title)
        {
            _guid = guid;
            _clientGuid = clientGuid;
            _ownerGuid = ownerGuid;
            _title = title;
        }
    }
}
