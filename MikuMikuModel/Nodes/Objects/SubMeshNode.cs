using System.ComponentModel;
using MikuMikuLibrary.Geometry;
using MikuMikuLibrary.Objects;

namespace MikuMikuModel.Nodes.Objects
{
    public class SubMeshNode : Node<SubMesh>
    {
        public override NodeFlags Flags => NodeFlags.None;

        [DisplayName( "包围球" )]
        public BoundingSphere BoundingSphere
        {
            get => GetProperty<BoundingSphere>();
            set => SetProperty( value );
        }

        public ushort[] Indices
        {
            get => GetProperty<ushort[]>();
            set => SetProperty( value );
        }

        [DisplayName( "骨指数" )]
        public ushort[] BoneIndices
        {
            get => GetProperty<ushort[]>();
            set => SetProperty( value );
        }

        [DisplayName( "材质索引" )]
        public int MaterialIndex
        {
            get => GetProperty<int>();
            set => SetProperty( value );
        }

        [DisplayName( "材质纹理UV指数" )]
        public byte[] MaterialUVIndices
        {
            get => GetProperty<byte[]>();
            set => SetProperty( value );
        }

        [DisplayName( "原始类型" )]
        public PrimitiveType PrimitiveType
        {
            get => GetProperty<PrimitiveType>();
            set => SetProperty( value );
        }

        [DisplayName( "边界盒" )]
        public BoundingBox BoundingBox
        {
            get => GetProperty<BoundingBox>();
            set => SetProperty( value );
        }

        public int Field00
        {
            get => GetProperty<int>();
            set => SetProperty( value );
        }

        protected override void Initialize()
        {
        }

        protected override void PopulateCore()
        {
        }

        protected override void SynchronizeCore()
        {
        }

        public SubMeshNode( string name, SubMesh data ) : base( name, data )
        {
        }
    }
}
