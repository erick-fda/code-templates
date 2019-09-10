/*========================================================================================
    MySingleton
	
    <<Description goes here.>>
	
    Copyright 2019 Erick Fernandez de Arteaga. All rights reserved.
        https://github.com/erick-fda
        https://www.linkedin.com/in/erick-fda
	
========================================================================================*/

namespace MyNamespace { public sealed class MySingleton
{
    /*----------------------------------------------------------------------------------------
		Fields
	----------------------------------------------------------------------------------------*/
	private static readonly System.Lazy<T> _instance = 
        new System.Lazy<T>(() => MySingleton()); /* Private singleton instance. */

    /*----------------------------------------------------------------------------------------
		Properties
	----------------------------------------------------------------------------------------*/
    public static MySingleton Instance { get { return base._instance; } }

    /*----------------------------------------------------------------------------------------
		Constructors
	----------------------------------------------------------------------------------------*/
	private MySingleton() { }
}}