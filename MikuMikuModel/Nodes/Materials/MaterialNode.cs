using System.ComponentModel;
using System.Drawing;
using MikuMikuLibrary.Materials;
using MikuMikuModel.Nodes.TypeConverters;
using MikuMikuModel.Resources;
using Color = MikuMikuLibrary.Misc.Color;

namespace MikuMikuModel.Nodes.Materials
{
    public class MaterialNode : Node<Material>
    {
        public override NodeFlags Flags => NodeFlags.Add | NodeFlags.Rename;
        public override Bitmap Image => ResourceStore.LoadBitmap( "Icons/Material.png" );

        [DisplayName( "Shader名字" )]
        public string Shader
        {
            get => GetProperty<string>();
            set => SetProperty( value );
        }

        [TypeConverter( typeof( ColorTypeConverter ) )]
        [DisplayName( "漫反射颜色" )]
        public Color DiffuseColor
        {
            get => GetProperty<Color>();
            set => SetProperty( value );
        }

        [TypeConverter( typeof( ColorTypeConverter ) )]
        [DisplayName( "环境颜色" )]
        public Color AmbientColor
        {
            get => GetProperty<Color>();
            set => SetProperty( value );
        }

        [TypeConverter( typeof( ColorTypeConverter ) )]
        [DisplayName( "镜面颜色" )]
        public Color SpecularColor
        {
            get => GetProperty<Color>();
            set => SetProperty( value );
        }

        [TypeConverter( typeof( ColorTypeConverter ) )]
        [DisplayName( "Emission颜色" )]
        public Color EmissionColor
        {
            get => GetProperty<Color>();
            set => SetProperty( value );
        }

        [DisplayName( "激活Alpha" )]
        public bool IsAlphaEnabled
        {
            get => GetProperty<bool>();
            set => SetProperty( value );
        }

        [DisplayName( "光泽度" )]
        public float Shininess
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        [TypeConverter( typeof( Int32HexTypeConverter ) )]
        public int Field00
        {
            get => GetProperty<int>();
            set => SetProperty( value );
        }

        [TypeConverter( typeof( Int32HexTypeConverter ) )]
        public int Field01
        {
            get => GetProperty<int>();
            set => SetProperty( value );
        }

        [TypeConverter( typeof( Int32HexTypeConverter ) )]
        public int Field02
        {
            get => GetProperty<int>();
            set => SetProperty( value );
        }

        public float Field20
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field21
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field22
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field23
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field24
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field25
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field26
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field27
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field28
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field29
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field30
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field31
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field32
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field33
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field34
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field35
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field36
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field37
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field38
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field39
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        public float Field40
        {
            get => GetProperty<float>();
            set => SetProperty( value );
        }

        protected override void Initialize()
        {
        }

        protected override void PopulateCore()
        {
            Nodes.Add( new MaterialTextureNode( "漫反射", Data.Diffuse ) );
            Nodes.Add( new MaterialTextureNode( "环境", Data.Ambient ) );
            Nodes.Add( new MaterialTextureNode( "法线", Data.Normal ) );
            Nodes.Add( new MaterialTextureNode( "镜面反射", Data.Specular ) );
            Nodes.Add( new MaterialTextureNode( "Toon曲线", Data.ToonCurve ) );
            Nodes.Add( new MaterialTextureNode( "反射", Data.Reflection ) );
            Nodes.Add( new MaterialTextureNode( "切线", Data.Tangent ) );
            Nodes.Add( new MaterialTextureNode( "未知slot", Data.Texture08 ) );
        }

        protected override void SynchronizeCore()
        {
        }

        public MaterialNode( string name, Material data ) : base( name, data )
        {
        }
    }
}
