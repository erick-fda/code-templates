/*========================================================================================
    MySingleton
	
    <<Description goes here.>>
	
    Copyright 2019 Erick Fernandez de Arteaga. All rights reserved.
        https://github.com/erick-fda
        https://www.linkedin.com/in/erick-fda
	
========================================================================================*/

/*========================================================================================
	Dependencies
========================================================================================*/


namespace MyNamespace { public sealed class MySingleton : Singleton<MySingleton>
{
    /*----------------------------------------------------------------------------------------
        Fields
    ----------------------------------------------------------------------------------------*/


    /*----------------------------------------------------------------------------------------
        Properties
    ----------------------------------------------------------------------------------------*/
    public static MySingleton Instance { get { return base._instance; } }

    /*----------------------------------------------------------------------------------------
        Constructors and Destructors
    ----------------------------------------------------------------------------------------*/
	private MySingleton() { }
    
    /*----------------------------------------------------------------------------------------
        Methods
    ----------------------------------------------------------------------------------------*/
    
}}