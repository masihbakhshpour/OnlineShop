﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PublicTools.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MessageResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessageResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PublicTools.Resources.MessageResource", typeof(MessageResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Process was failed..
        /// </summary>
        public static string Error_FailProcess {
            get {
                return ResourceManager.GetString("Error_FailProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object Was Not Found.
        /// </summary>
        public static string Error_FailToFindObject {
            get {
                return ResourceManager.GetString("Error_FailToFindObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Parameter is null.
        /// </summary>
        public static string Error_TheParameterIsNull {
            get {
                return ResourceManager.GetString("Error_TheParameterIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field is mandatory.
        /// </summary>
        public static string Error_ThisFieldIsMandatory {
            get {
                return ResourceManager.GetString("Error_ThisFieldIsMandatory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process was Successful..
        /// </summary>
        public static string Info_SuccessfullProcess {
            get {
                return ResourceManager.GetString("Info_SuccessfullProcess", resourceCulture);
            }
        }
    }
}
