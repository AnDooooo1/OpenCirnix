﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cirnix.Global.Properties {
    using System;
    
    
    /// <summary>
    ///   지역화된 문자열 등을 찾기 위한 강력한 형식의 리소스 클래스입니다.
    /// </summary>
    // 이 클래스는 ResGen 또는 Visual Studio와 같은 도구를 통해 StronglyTypedResourceBuilder
    // 클래스에서 자동으로 생성되었습니다.
    // 멤버를 추가하거나 제거하려면 .ResX 파일을 편집한 다음 /str 옵션을 사용하여 ResGen을
    // 다시 실행하거나 VS 프로젝트를 다시 빌드하십시오.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   이 클래스에서 사용하는 캐시된 ResourceManager 인스턴스를 반환합니다.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Cirnix.Global.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   이 강력한 형식의 리소스 클래스를 사용하여 모든 리소스 조회에 대해 현재 스레드의 CurrentUICulture 속성을
        ///   재정의합니다.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   |cffff0000[|r |cff646464  |cff646eff|r |cff288C28 http://Cheatmap.tistory.com |r |cffffa500vA|r |cffff0000]|r
        ///|r*|r |cffFFB1BCThanks to used |cffFFFA78Getting Cheat Maps Welcome! |r|r*
        ///|cff288C28@선택|r - |cffffA500선택|r |cff646464 영웅/유닛 치트 적용자를 선택합니다.|r
        ///|cffCD0000Cafe Address|r |cffEE84EA
        ///|cff646eff이 방은|r |cffffbe0a3초 후|r|cff646eff에 저절로 |cffffbe0a폭파|r|cff646eff됩니다.|r |cffff0000(취소따윈 못합니다. 이미 늦었어!)|r
        ///|r |cff2c952c이(가)|r |cffffbe0a선택|r|cff2c952c되었습니다.|r
        ///|cffCD0000자동으로 리플레이가|r |cffEE84EA삭제 됩니다|r |cff6482FF[나머지 문자열은 잘림]&quot;;과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string CheatSetPhrase {
            get {
                return ResourceManager.GetString("CheatSetPhrase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.Byte[] 형식의 지역화된 리소스를 찾습니다.
        /// </summary>
        public static byte[] Cirnix {
            get {
                object obj = ResourceManager.GetObject("Cirnix", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   (아이콘)과(와) 유사한 System.Drawing.Icon 형식의 지역화된 리소스를 찾습니다.
        /// </summary>
        public static System.Drawing.Icon CirnixIcon {
            get {
                object obj = ResourceManager.GetObject("CirnixIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   System.Byte[] 형식의 지역화된 리소스를 찾습니다.
        /// </summary>
        public static byte[] max {
            get {
                object obj = ResourceManager.GetObject("max", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}