﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SlacrafratMarketDiscordBot.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SlacrafratMarketDiscordBot.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {
        ///  &quot;token&quot;: &quot;MTA2NzgyNTU3NDU3NzQ1OTI0MA.G5yp7V.qRuWAcZSS2eoTycPX1avRaDMBvUs2rZ8xKCP7A&quot;,
        ///  &quot;prefix&quot;: &quot;?&quot;
        ///}
        ///.
        /// </summary>
        internal static string config {
            get {
                return ResourceManager.GetString("config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на [
        ///  {
        ///    &quot;data&quot;: &quot;/items/weapon/device/B17n.json&quot;,
        ///    &quot;icon&quot;: &quot;/icons/weapon/device/B17n.png&quot;,
        ///    &quot;name&quot;: {
        ///      &quot;type&quot;: &quot;translation&quot;,
        ///      &quot;key&quot;: &quot;item.device.dud_svecha.name&quot;,
        ///      &quot;args&quot;: {},
        ///      &quot;lines&quot;: {
        ///        &quot;ru&quot;: &quot;Детектор узкого диапазона «Свеча»&quot;,
        ///        &quot;en&quot;: &quot;Candle Short Range Detector&quot;
        ///      }
        ///    }
        ///  },
        ///  {
        ///    &quot;data&quot;: &quot;/items/weapon/device/yZ08.json&quot;,
        ///    &quot;icon&quot;: &quot;/icons/weapon/device/yZ08.png&quot;,
        ///    &quot;name&quot;: {
        ///      &quot;type&quot;: &quot;translation&quot;,
        ///      &quot;key&quot;: &quot;item.dev [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string listing {
            get {
                return ResourceManager.GetString("listing", resourceCulture);
            }
        }
    }
}
