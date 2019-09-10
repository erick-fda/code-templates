<!--======================================================================================
    Coding Style Convetions
=======================================================================================-->
# Coding Style Convetions

_Copyright 2019 Erick Fernandez de Arteaga. All rights reserved._

- [Erick's GitHub Profile][ref_github_profile]

- [Erick's LinkedIn Profile][ref_linkedin_profile]

<br>

<!--======================================================================================
    Table of Contents
=======================================================================================-->
## Table of Contents

<br>

1. **[Naming Conventions](#section_naming_conventions)**

   1. [Folders](#section_folders)
   2. [Files](#section_files)
   3. [Namespaces](#section_namespaces)
   4. [Classes](#section_classes)
   5. [Structs](#section_structs)
   6. [Enumerated Types](#section_enums)
   7. [Constants](#section_constants)
   8. [Instance and Class Fields](#section_fields)
   9. [Instance and Class Properties](#section_properties)
   10. [Functions](#section_functions)
   11. [Parameters](#section_parameters)
   12. [Local Variables](#section_local_variables)

2. **[Layout Conventions](#section_layout_conventions)**

   1. [Code File Layout](#section_code_file_layout)
   2. [Line Length](#section_line_length)
   3. [Tabs](#section_tabs)
   4. [Braces](#section_braces)
   5. [Whitespace](#section_whitespace)
   6. [Line Breaks](#section_line_breaks)
   7. [Parentheses](#section_parentheses)

3. **[Commenting Conventions](#section_commenting_conventions)**

   1. [Inline Comments](#section_inline_comments)
   2. [Block Comments](#section_block_comments)
   3. [File Headers](#section_file_headers)
   4. [Class Headers](#section_class_headers)
   5. [Function Headers](#section_function_headers)
   6. [Section Headers](#section_section_headers)
   7. [Field Comments](#section_field_comments)

<br>

<!--======================================================================================
    Naming Conventions
=======================================================================================-->
<a id="section_naming_conventions"></a>
## Naming Conventions

A huge part of code readability derives from choosing proper names for classes, variables, functions, and other program building blocks.

Specific advice for each construct follows, but here are some good guidelines for naming in general:

- **Always choose specific names!**

   - A variable named `x` or `temp` tells us nothing about its purpose and makes for difficult-to-read code. `xDistance` and `swap` are some examples of much better names that could be used.
   
   - Someone who has little knowledge of the program should be able to get some idea of what a variable or function's purpose is based on the name.

   - The exception to this rule is using `i`, `j`, and `k` as loop counter variable names; `it` for an iterator; or other similar conventions. 
   
      - This is acceptable because it is a common convention, and thus naming a variable `i` _does_ tell us about its purpose: it tells us that it is a loop counter.

      - However, when the loop variable represents anything other than a mere counter or index (such as the loop variable in a `foreach` loop), a more descriptive name is recommended.

- **Don't go too short or too long!**

   - When naming variables, methods, etc., a name that's too short will be ambiguous, but a name that's too long will be a jumbled mess that's difficult to remember.
   
   - In general, aim to make your variable names as concise as possible while keeping their purpose clear.
   
   - Remember that variable names do not exist in a vacuum. The context that a variable is in, such as a particular function, class, or method, tells us about it.
     
     - The function `Serve()`, for example, will mean something very different in a `Waiter` class than it would in a `TennisPlayer` class.
     
     - However, the function name does not need to be any longer in either class to differentiate it, since the classes themselves provide the context that makes the difference clear.

- **Use appropriate parts of language for names!**

   - In general, classes and variables _are_ things, while functions _do_ things. Accordingly, use noun phrases for variable and class names and verb phrases for function names most of the time. 
   
      - An acceptable exception is naming public getters for private variables with nouns that reflect the variable. For example, making `Size()` the getter method for the `_size` field.
<br>

<!--======================================================================================
    Folders
=======================================================================================-->
<a id="section_folders"></a>
### Folders

Use `PascalCase` for naming folders.

- Use only alphanumeric and underscore characters.

- When numbering folders, left-pad with zeroes to the maximum number of digits you expect to use in numbering (e.g., favor `Folder01` over `Folder1` if you expect to have 10 or more such folders).

  - This will ensure your folders sort into numerical order when sorting alphabetically.

- Optionally, prepend an underscore to important folders to make them appear at the top of an alphabetical sorting (e.g., `_AnImportantFolder`).

<br>

<!--======================================================================================
    Files
=======================================================================================-->
<a id="section_files"></a>
### Files

Use `PascalCase.extension` for naming class files.

Use `snake_case.extension` for naming other files.

- Use only alphanumeric and underscore characters.

- When numbering files, left-pad with zeroes to the maximum number of digits you expect to use in numbering (e.g., favor `file_01.txt` over `file_1.txt` if you expect to have 10 or more such files).

- Preferably, make use of a naming convetion such as `type_subtype_id.extension` (e.g., `img_button_ok.png`).

   - A naming convention such as the above will keep closely related files sorted together when you sort them alphabetically in a file viewer.

- Optionally, prepend an underscore to important files to make them appear at the top of an alphabetical sorting (e.g., `_an_important_file.txt`).

<br>

<!--======================================================================================
    Namespaces
=======================================================================================-->
<a id="section_namespaces"></a>
### Namespaces

Use `PascalCase` for naming namespaces.

<br>

<!--======================================================================================
    Classes
=======================================================================================-->
<a id="section_classes"></a>
### Classes


Use `PascalCase` and singular noun phrase names for naming classes.

- Filenames for class files should match the class name.

- Prepend an `I` to interface names (e.g., `IEnumerator`).

- Aside from the above point, interfaces and extensions should generally follow the same conventions as classes.

<br>

<!--======================================================================================
    Structs
=======================================================================================-->
<a id="section_structs"></a>
### Structs


Use `PascalCase` and singular noun phrase names for naming structs.

- In general, structs should be treated as classes for the purposes of naming, formatting, and commenting. Struct fields, methods, etc. should also follow the same naming conventions as their class counterparts.

<br>

<!--======================================================================================
    Enumerated Types
=======================================================================================-->
<a id="section_enums"></a>
### Enumerated Types


Use `ALL_CAPS_SNAKE_CASE` and singular noun phrase names for naming both enum types and values.

<br>

<!--======================================================================================
    Constants
=======================================================================================-->
<a id="section_constants"></a>
### Constants


Use `ALL_CAPS_SNAKE_CASE` and noun phrase names (usually singular) for naming constant values.

<br>

<!--======================================================================================
    Fields
=======================================================================================-->
<a id="section_fields"></a>
### Instance and Class Fields


Use `_camelCaseWithUnderscore` and noun phrase names for naming private fields (except for booleans, which should use verb phrase names like `_isActive` or `_wasClicked`).

In the case of booleans, names should _always_ be phrased in the positive. In other words, opt for a name like `_isSelected` rather than `_isNotSelected`. The following example illustrates why:

``` cs
if (_isSelected) ...
/*
   Good. Easy-to-read.
*/

if (_isNotSelected) ...
/*
   A little unintuitive.
*/

if (!_isNotSelected) ...
/*
   Okay, this is getting bad.
*/

if (!_isNotSelected == false) ...
/*
   Please stop.
*/
```

<br>

<!--======================================================================================
    Properties
=======================================================================================-->
<a id="section_properties"></a>
### Instance and Class Properties


Use `PascalCase` and noun phrase names for naming properties (except for booleans, which should use verb phrase names like `isActive`).

In the case of booleans, names should _always_ be in the positive, _never_ in the negative. In other words, opt for a name like `IsSelected` rather than `IsNotSelected`. The following example illustrates why:

``` cs
/*
   Good. Easy-to-read.
*/
if (IsSelected) ...

/*
   A little unintuitive.
*/
if (IsNotSelected) ...

/*
   Okay, this is getting bad.
*/
if (!IsNotSelected) ...

/*
   Please stop.
*/
if (!IsNotSelected == false) ...
```

<br>

<!--======================================================================================
    Functions
=======================================================================================-->
<a id="section_functions"></a>
### Functions


Use `PascalCase()` and verb phrase names for naming functions.

<br>

<!--======================================================================================
    Parameters
=======================================================================================-->
<a id="section_parameters"></a>
### Parameters


Use `camelCase` and noun phrase names for naming function parameters (except for booleans, which should use verb phrase names like `isActive`).

<br>

<!--======================================================================================
    Local Variables
=======================================================================================-->
<a id="section_local_variables"></a>
### Local Variables


Use `camelCase` and noun phrase names for naming local variables (except for booleans, which should use verb phrase names like `isActive`).

<br>

<!--======================================================================================
    Layout Conventions
=======================================================================================-->
<a id="section_layout_conventions"></a>
## Layout Convetions

Unlike with naming conventions, there is often little or no reason to pick a particular layout convention over another. However, there is plenty of reason to pick _one_ and stick to it. The consistency afforded by layout conventions will complement proper naming conventions and, in practice, lead to greater code readability and maintainability.

<br>

<!--======================================================================================
    Code File Layout
=======================================================================================-->
<a id="section_code_file_layout"></a>
### Code File Layout


Content within files should generally be ordered as follows, using the [StyleCop Rules][ref_stylecop_rules] as a guide:

1. Dependencies (i.e., `import`, `using`, etc. statements)

2. Class definition

   1. Enums
   2. Constants
   3. Fields
   4. Properties (Or Accessors/Mutators, Getters/Setters, etc. depending on the language)
   5. Constructors
   6. Destructors
   7. Interface Methods
   8. Methods
   9. Structs
   10. Classes

Each of these groups should be further sorted by access level:

1. Public
2. Internal
3. Protected Internal
4. Protected
5. Private

Each of the access groups should be further sorted by class (`static`) or instance members:

1. Class Members
2. Instance Members

Each of the class/instance groups should be further sorted by `readonly` or not:

1. Readonly
2. Non-Readonly

<br>

<!--======================================================================================
    Line Length
=======================================================================================-->
<a id="section_line_length"></a>
### Line Length


Line length should be limited to about 90 characters (not counting initial tabs or spaces).

- Lines of code longer than this amount can easily become difficult to read and debug.

- However, use sensible judgement and allow for exceeding this limit when adhering to it would worsen readability.

   - For example, do not split just the last few characters of a line onto a new line. Only split the line if it would otherwise significantly exceed the 90-character limit.

<br>


<!--======================================================================================
    Tabs
=======================================================================================-->
<a id="section_tabs"></a>
### Tabs


Use four space characters instead of tab characters.

   - Most modern IDEs will have a setting to automatically replace tabs with a certain number of spaces.

Use tabs to indent lines contained by braces. Indent again for each subsequent level of nesting.

``` cs
/* Outside braces, no indent. */

MyClass
{
   /* Inside one pair of braces, indented once. */

   MyFunction()
   {
      /* Inside another pair of braces, indented twice. */
   }

   /* Back to a single level of indentation. */
} 
```

<br>

Also indent when splitting a long line of code.

``` cs
/* You can keep the closing parenthesis at the end of the argument list...*/
thisIsAReallyLongFunctionCallThatIWillSplit(
   thisIsAnArgument);

/* ...or you can keep it on its own un-indented line, treating it much like a brace.*/
thisIsAReallyLongFunctionCallThatIWillSplit(
   thisIsAnArgument
);
```

<br>

<!--======================================================================================
    Braces
=======================================================================================-->
<a id="section_braces"></a>
### Braces


Use **Allman style** brace alignment in most cases. (Sorry, Steve McConnell!)

``` cs
/* Allman style keeps opening and closing braces vertically aligned. */

MyClass
{
    /* Code inside braces is indented. */
}
```

The exception is when declaring a single class within a namespace in a class file. In such cases, the recommended convention is as follows:

``` cs
namespace MyNamespace { public class MyClass : public MyBaseClass
{
   /* Class code goes here. */
}}
```

This admittedly irregular (but very readable) alignment helps to avoid needing to indent all of your class code twice.

<br>

<!--======================================================================================
    Whitespace
=======================================================================================-->
<a id="section_whitespace"></a>
### Whitespace


Sometimes including additional whitespace between text can improve code readability, and in these cases, you should do so. This can especially be the case when you have several layers of nested parentheses.

``` cs
/*
   This line is hard to read.
   Try figuring out how many parameters MyBooleanCheck() takes and you'll see why.
*/
if(MyBooleanCheck(GetInput(myVar1,myVar2),GetMoreInput(myVar3,myVar4)))

/*
   Try it again with some helpful whitespace provided. Much easier!
*/
if (MyBooleanCheck( GetInput(myVar1,myVar2), GetMoreInput(myVar3,myVar4) ))

/*
    Using line breaks together with the extra whitespace can aid readability even more.
*/
if(
    MyBooleanCheck(
        GetInput(myVar1,myVar2), 
        GetMoreInput(myVar3,myVar4)))
```

Annoyingly, some IDEs will automatically remove extra spaces within function calls when you type the closing parenthesis. Worse, this auto-correction setting is often tied up with other auto-corrections that you *do* want, so turning it off can be undesirable. It's up to you to make a call as to whether you'll bother with extra spaces in such cases.

<br>

<!--======================================================================================
    Line Breaks
=======================================================================================-->
<a id="section_line_breaks"></a>
### Line Breaks


It's a good practice to break up code into "paragraphs" of related functionality using blank lines.

``` cs
/* Even without reading the code in detail, it's clear that the first three lines are related in some way that the fourth isn't. */

myVar = GetAValue();
myVar = DoSomething(myVar);
Debug.Log = (myVar);

anotherVar = DoSomethingUnrelated();
```

<br>

<!--======================================================================================
    Parentheses
=======================================================================================-->
<a id="section_parentheses"></a>
### Parentheses


Use as many parentheses as necessary for readability, even if they are not necessary to achieve correct order of execution.

``` cs
/* This line is hard to read. What's the value of theResult? */
theResult = 1+2*3+6/2+7-9;

/* Using parentheses avoids the risk that your reader will forget the order of operations and improves readability. */
theResult = 1+(2*3)+(6/2)+7-9;

/* Combine the use of parentheses and whitespace for the most readable result! */
theResult = 1 + (2*3) + (6/2) + 7 - 9;
```

This particular example is unrealistic since it uses only constant integer values, but the parentheses and whitespace would be just as helpful if the integers were replaced with variables and method calls.

<br>

<!--======================================================================================
    Commenting Conventions
=======================================================================================-->
<a id="section_commenting_conventions"></a>
## Commenting Conventions

The conventions listed in this section describe where in files certain types of comments should appear and how they should be formatted.

<br>

<!--======================================================================================
    Inline Comments
=======================================================================================-->
<a id="section_inline_comments"></a>
### Inline Comments


All comments should be multi-line comments (if the language you're using supports them), even if they only occupy one line. This affords visual consistency for all inline comments.

``` cs
/* That means that for most languages, your comments should look like this... */

// ...not like this.
```

Any comment that exists on a line of its own should be never be immediately preceded by a line of code. This avoids having code lines and comment lines intermixed.

``` cs
DoSomething();
/* This is comment blasphemy! */
DoSomethingElse();

/* This is how to properly use a comment. */
DoYetAnotherThing();

A(); /* This is fine, though. */
B(); /* These comments exist on the same lines as code. */
C(); /* Therefore you do not need blank lines in front of them. */
```

<br>

- **DO NOT restate in inline comments anything that can be deduced from the code itself!**

   - Comments that provide the same information as the code they document only bloat code and add more lines to sift through when looking for a particular section.

- **DO use inline comments to clarify your intent!**

   - In other words, don't use inline comments to say what your code is doing, but rather _why_.

   - For example, rather than writing a comment like `/* Print out  the numbers from 1 to 30. */`, write `/* Print the line numbers for the user document. */`. The former could be deduced by reading the code itself; the latter could only be known by the original programmer (at least without additional context) and is useful to someone reading the code later, and thus makes for a good comment.

<br>

<!--======================================================================================
    Block Comments
=======================================================================================-->
<a id="section_block_comments"></a>
### Block Comments


Block comments are similar to multi-line comments, with the main formatting difference being that the opening and ending slashes appear on their own lines, rather than inline with the comment content.

These comments are generally used at the top of class and function definitions to summarize the purpose of those structures.

``` cs
/*
    This is how a block comment looks.
*/
```

<br>

- **DO use block comments to summarize the purpose of a class or function!**

   - Unlike inline comments, you have a bit more liberty to describe _what_ your code does with these as long as you're concise.
   
     - In other words, it's fine to use a 10-line comment to summarize what 100-200 lines of code do, but don't use 10 lines in a comment to describe 10 lines of code.

<br>

<!--======================================================================================
    File Headers
=======================================================================================-->
<a id="section_file_headers"></a>
### File Headers


File headers should be formatted as follows and appear at the top of each file.

``` cs
/*========================================================================================
    <<Filename>>

    <<Summary of contents of file.>>
    
    Copyright <<Year>> <<Author name(s)>>. All rights reserved.
        <<Author email or website 1>>
        <<Author email or website 2>>
        <<etc.>>
    
========================================================================================*/
```

- If there are multiple authors for a single file, each adjacent pair of names should be separated using a comma and a space.

- In non-code files, such as text files, you can drop the opening and closing `/* */` slashes and use only `=` equals signs in the top and bottom lines.

- In files that contain only one top-level class (i.e., not counting internal classes), you can replace the name and summary of the file with the name and summary of the class instead instead of having separate file and class headers.

<br>

<!--======================================================================================
    Section Headers
=======================================================================================-->
<a id="section_section_headers"></a>
### Section Headers


Section headers should be formatted as follows and appear at the beginning of major "sections" of a file:

``` cs
/*========================================================================================
	<<Section Name>>
========================================================================================*/
```

It is up to you to decide what is a significant enough section of a file to merit a header.

You can use a similar format, but with hyphens instead of equals signs for sub-section headers within a section. Again, it is up to you to decide what parts of a file are worth splitting up like this.

``` cs
/*----------------------------------------------------------------------------------------
	<<Sub-section Name>>
----------------------------------------------------------------------------------------*/
```

A suggested convention is to use major section headings for sections outside of class definitions (to group related classes in a file, for example) and sub-section headings for sections within class definitions (to group fields, properties, and methods separately, for example).

<br>

<!--======================================================================================
    Class Headers
=======================================================================================-->
<a id="section_class_headers"></a>
### Class Headers


Class headers should be formatted as follows and appear at the top of each class definition. This type of header should also be used for enumerated types, structs, interfaces, and extensions.

``` cs
/*
    <<ClassName>>

    <<Summary of class functionality.>>
*/
```

<br>

<!--======================================================================================
    Function Headers
=======================================================================================-->
<a id="section_function_headers"></a>
### Function Headers


Function headers should be formatted as follows and appear at the top of each function definition.

``` cs
/*
    <<Concise summary of what the function does.>>

    @returns <<What the function returns.>>

    @param <<parameterName1>> - <<What parameterName1 is.>>
    @param <<parameterName2>> - <<What parameterName2 is.>>

    @throws <<exceptionName1>> - <<Under what conditions exceptionName1 is thrown.>>
    @throws <<exceptionName2>> - <<Under what conditions exceptionName2 is thrown.>>
*/
```

- The `@returns` tag should only be used when the function has a return value.

- The `@param` tag should only be used if the function takes parameters.

- You can use a single `@param` to document multiple related parameters, such as `x`, `y`, and `z` parameters describing a point in 3D space. In such a case, separate each adjacent pair of parameter names with a comma and a space.

- The `@throws` tag should only be used if the function can throw any exceptions.

- Unlike with the `@param` tag, multiple exceptions cannot be documented by a single `@throws` tag (since their descriptions will differ). Each exception should be documented by a separate `@throws` tag.

<br>

<!--======================================================================================
    Field Comments
=======================================================================================-->
<a id="section_field_comments"></a>
### Field Comments


An inline comment that documents a field, property, or local variable should look like this:

``` cs
int myVar;  /* A variable. */
```

<br>

<!--======================================================================================
    References
=======================================================================================-->
<a id="section_references"></a>
## References

- McConnell, S. (2004). Code Complete. Redmond, Washington: Microsoft Press.

- Reeves, A. (2011). StyleCop. Retrieved from http://stylecop.soyuz5.com

<!--======================================================================================
    Reference Links
=======================================================================================-->
[ref_github_profile]: https://github.com/erick-fda "Erick's GitHub Profile"

[ref_linkedin_profile]: https://www.linkedin.com/in/erick-fda "Erick's LinkedIn Profile"

[ref_stylecop_rules]: http://stylecop.soyuz5.com/StyleCop%20Rules.html "StyleCop Rules Documentation"

<!--======================================================================================
   CSS
=======================================================================================-->
<link href="./CSS/dark.css" rel="stylesheet"></link>