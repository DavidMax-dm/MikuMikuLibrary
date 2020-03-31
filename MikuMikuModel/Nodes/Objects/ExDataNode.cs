using System.Collections.Generic;
using System.ComponentModel;
using MikuMikuLibrary.Objects;

namespace MikuMikuModel.Nodes.Objects
{
    public class ExDataNode : Node<ExData>
    {
        public override NodeFlags Flags => NodeFlags.None;

        [DisplayName( "Osage骨骼" )] public List<ExOsageBone> OsageBones => GetProperty<List<ExOsageBone>>();

        [DisplayName( "Osage名称" )] public List<string> OsageNames => GetProperty<List<string>>();

        [DisplayName( "节点" )] public List<ExNode> ExNodes => GetProperty<List<ExNode>>( "Nodes" );

        [DisplayName( "骨骼名称" )] public List<string> BoneNames => GetProperty<List<string>>();

        [DisplayName( "条目" )] public List<ExEntry> Entries => GetProperty<List<ExEntry>>();

        protected override void Initialize()
        {
        }

        protected override void PopulateCore()
        {
        }

        protected override void SynchronizeCore()
        {
        }

        public ExDataNode( string name, ExData data ) : base( name, data )
        {
        }
    }
}
