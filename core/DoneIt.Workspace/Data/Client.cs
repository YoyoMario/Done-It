namespace DoneIt.Workspace.Data
{
    public class Client
    {
        private Guid _guid = default;
        private Guid _ownerGuid = default;
        private string _title = default!;
        private Project[] _projects = default!;

        public Client(Guid guid, Guid ownerGuid, string title, Project[] projects)
        {
            _guid = guid;
            _ownerGuid = ownerGuid;
            _title = title;
            _projects = projects;
        }
    }
}
