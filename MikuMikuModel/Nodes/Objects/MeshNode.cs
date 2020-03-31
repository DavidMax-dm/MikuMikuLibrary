using System.ComponentModel;
using System.Numerics;
using System.Windows.Forms;
using MikuMikuLibrary.Geometry;
using MikuMikuLibrary.Misc;
using MikuMikuLibrary.Objects;
using MikuMikuModel.GUI.Controls;
using MikuMikuModel.Nodes.Misc;

namespace MikuMikuModel.Nodes.Objects
{
    public class MeshNode : Node<Mesh>
    {
        public override NodeFlags Flags => NodeFlags.Add | NodeFlags.Rename;

        public override Control Control
        {
            get
            {
                var objectSetParent = FindParent<ObjectSetNode>();
                var objectParent = FindParent<ObjectNode>();

                if ( objectSetParent == null || objectParent == null )
                    return null;

                ModelViewControl.Instance.SetModel( Data, objectParent.Data, objectSetParent.Data.TextureSet );
                return ModelViewControl.Instance;
            }
        }

        [DisplayName( "包围球" )]
        public BoundingSphere BoundingSphere
        {
            get => GetProperty<BoundingSphere>();
            set => SetProperty( value );
        }

        [DisplayName( "顶点" )]
        public Vector3[] Vertices
        {
            get => GetProperty<Vector3[]>();
            set => SetProperty( value );
        }

        [DisplayName( "法线" )]
        public Vector3[] Normals
        {
            get => GetProperty<Vector3[]>();
            set => SetProperty( value );
        }

        [DisplayName( "切线" )]
        public Vector4[] Tangents
        {
            get => GetProperty<Vector4[]>();
            set => SetProperty( value );
        }

        [DisplayName( "UV通道 1" )]
        public Vector2[] UVChannel1
        {
            get => GetProperty<Vector2[]>();
            set => SetProperty( value );
        }

        [DisplayName( "UV通道 2" )]
        public Vector2[] UVChannel2
        {
            get => GetProperty<Vector2[]>();
            set => SetProperty( value );
        }

        [DisplayName( "颜色" )]
        public Color[] Colors
        {
            get => GetProperty<Color[]>();
            set => SetProperty( value );
        }

        [DisplayName( "权重" )]
        public BoneWeight[] BoneWeights
        {
            get => GetProperty<BoneWeight[]>();
            set => SetProperty( value );
        }

        protected override void Initialize()
        {
        }

        protected override void PopulateCore()
        {
            Nodes.Add( new ListNode<SubMesh>( "Submeshes", Data.SubMeshes ) );
        }

        protected override void SynchronizeCore()
        {
        }

        [DisplayName( "名称" )]
        public MeshNode( string name, Mesh data ) : base( name, data )
        {
        }
    }
}
