﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharpTAL.Demo {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SharpTAL.Demo.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;tal:root
        ///	xmlns:tal=&quot;http://xml.zope.org/namespaces/tal&quot;
        ///	xmlns:tales=&quot;http://xml.zope.org/namespaces/tales&quot;
        ///	xmlns:metal=&quot;http://xml.zope.org/namespaces/metal&quot;&gt;
        ///
        ///&lt;tal:tag metal:define-macro=&quot;macroWithSlot&quot;&gt;
        ///    Special friend name: &lt;p metal:define-slot=&quot;slot&quot;&gt;default content&lt;/p&gt;
        ///&lt;/tal:tag&gt;
        ///
        ///&lt;/tal:root&gt;
        ///.
        /// </summary>
        internal static string Macros {
            get {
                return ResourceManager.GetString("Macros", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;!DOCTYPE html PUBLIC &quot;-//W3C//DTD XHTML 1.1//EN&quot; &quot;http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd&quot;&gt;
        ///&lt;tal:root&gt;
        ///
        ///&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot; xmlns:tal=&quot;http://xml.zope.org/namespaces/tal&quot;&gt;
        ///&lt;body tal:define=&quot;specialFriend from f in friends where f.Age &amp;lt; 30 select f&quot;&gt;
        ///	
        ///	&lt;!-- Executing void methods --&gt;
        ///	&lt;tal:tag tal:define=&apos;z 0;;Console.WriteLine(&quot;One!&quot;);;Console.WriteLine(&quot;Two!&quot;);;&apos;/&gt;
        ///
        ///	&lt;!-- Include and use Macros in default namespace --&gt;
        ///	&lt;tal:tag metal: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Main {
            get {
                return ResourceManager.GetString("Main", resourceCulture);
            }
        }
    }
}
