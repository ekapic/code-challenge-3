﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("App.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
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
        ///   Busca una cadena traducida similar a ************************  Library App  ******************************.
        /// </summary>
        internal static string Apptitle {
            get {
                return ResourceManager.GetString("Apptitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Introduzca el libro:.
        /// </summary>
        internal static string EnterBook {
            get {
                return ResourceManager.GetString("EnterBook", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Please press any key to continue.
        /// </summary>
        internal static string EnterKeyToContinue {
            get {
                return ResourceManager.GetString("EnterKeyToContinue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Introduzca la fecha del préstamo:.
        /// </summary>
        internal static string EnterLoanDate {
            get {
                return ResourceManager.GetString("EnterLoanDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Introduzca el usuario:.
        /// </summary>
        internal static string EnterName {
            get {
                return ResourceManager.GetString("EnterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Introduzca la fecha de la devolución:.
        /// </summary>
        internal static string EnterReturnDate {
            get {
                return ResourceManager.GetString("EnterReturnDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Préstamo realizado. .
        /// </summary>
        internal static string LoanBookSuccess {
            get {
                return ResourceManager.GetString("LoanBookSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El libro está registrado correctamente.
        /// </summary>
        internal static string RegisterBookSuccess {
            get {
                return ResourceManager.GetString("RegisterBookSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El libro está disponible ahora mismo..
        /// </summary>
        internal static string ReturnBookSuccess {
            get {
                return ResourceManager.GetString("ReturnBookSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a ¿Quiere (R)egistrar un libro, hacer un (P)réstamo o una (D)evolución:.
        /// </summary>
        internal static string SelectOperation {
            get {
                return ResourceManager.GetString("SelectOperation", resourceCulture);
            }
        }
    }
}
