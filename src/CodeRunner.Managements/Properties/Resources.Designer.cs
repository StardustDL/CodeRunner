﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeRunner.Managements.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CodeRunner.Managements.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 #include &lt;stdio.h&gt;
        ///#include &lt;stdlib.h&gt;
        ///int main()
        ///{
        ///
        ///    return EXIT_SUCCESS;
        ///} 的本地化字符串。
        /// </summary>
        internal static string tpl_c {
            get {
                return ResourceManager.GetString("tpl_c", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #include &lt;cstdio&gt;
        ///#include &lt;cstdlib&gt;
        ///#include &lt;iostream&gt;
        ///
        ///using namespace std;
        ///
        ///int main()
        ///{
        ///
        ///    return EXIT_SUCCESS;
        ///} 的本地化字符串。
        /// </summary>
        internal static string tpl_cpp {
            get {
                return ResourceManager.GetString("tpl_cpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 using System;
        ///
        ///class Program
        ///{
        ///    static void Main(String[] args)
        ///    {
        ///        
        ///    }
        ///} 的本地化字符串。
        /// </summary>
        internal static string tpl_csharp {
            get {
                return ResourceManager.GetString("tpl_csharp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 open System
        ///
        ///[&lt;EntryPoint&gt;]
        ///let main argv = 
        ///    0
        /// 的本地化字符串。
        /// </summary>
        internal static string tpl_fsharp {
            get {
                return ResourceManager.GetString("tpl_fsharp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package main
        ///import &quot;fmt&quot;
        ///
        ///func main() {
        ///    
        ///}
        ///
        /// 的本地化字符串。
        /// </summary>
        internal static string tpl_go {
            get {
                return ResourceManager.GetString("tpl_go", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 import java.util.Scanner;
        ///
        ///public class Main {
        ///    public static void main(String[] args) {
        ///        
        ///    }
        ///}
        /// 的本地化字符串。
        /// </summary>
        internal static string tpl_java {
            get {
                return ResourceManager.GetString("tpl_java", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 def main():
        ///
        ///    return 0
        ///
        ///
        ///if __name__ == &quot;__main__&quot;:
        ///    exit(main())
        /// 的本地化字符串。
        /// </summary>
        internal static string tpl_python {
            get {
                return ResourceManager.GetString("tpl_python", resourceCulture);
            }
        }
    }
}