/*========================================================================================
    Singleton<T>
	
	Abstract superclass for singletons.
	
    Copyright 2019 Erick Fernandez de Arteaga. All rights reserved.
        https://github.com/erick-fda
        https://www.linkedin.com/in/erick-fda
	
========================================================================================*/

/*========================================================================================
	Singleton<T>
========================================================================================*/
namespace MyNamespace { public abstract class Singleton<T> where T : class
{
    /*----------------------------------------------------------------------------------------
        Fields
    ----------------------------------------------------------------------------------------*/
	protected static readonly System.Lazy<T> _instance = 
        new System.Lazy<T>(() => CreateInstance()); /* Private singleton instance */

    /*----------------------------------------------------------------------------------------
        Methods
    ----------------------------------------------------------------------------------------*/
	/*
        Lazily creates the singleton instance when it is first accessed.
    */
    private static T CreateInstance()
    {
        return System.Activator.CreateInstance(typeof(T), true) as T;
    }
}}
