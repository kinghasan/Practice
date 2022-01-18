Shader "Custom/Practice"
{
    Properties{
        _MainColor("选择主颜色",Color) = (1,1,1,1)
        _Ambient("环境颜色",Color) = (0.3,0.3,0.3,1)
        _Specular("镜面反射",Color) = (1,1,1,1)
        _Shininess("高光强度",Range(0,1)) = 0.5
        _Emission("自发光",Color) = (1,1,1,1)
    }

    SubShader{

        pass{
            //Color[_MainColor]
            Material
            {
                DIFFUSE[_MainColor]
                Ambient[_Ambient]
                SPECULAR[_Specular]
                Shininess[_Shininess]
                Emission[_Emission]
            }
            Lighting on
            SeparateSpecular on
        }
    }
}
