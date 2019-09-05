<!--======================================================================================
    Markdown Cheat Sheet
=======================================================================================-->
# Markdown Cheat Sheet

_Copyright 2019 Erick Fernandez de Arteaga. All rights reserved._

- [Erick's GitHub Profile][ref_github_profile]

- [Erick's LinkedIn Profile][ref_linkedin_profile]

<br>

<!--======================================================================================
    Table of Contents
=======================================================================================-->
## Table of Contents

<br>

1. [How to Read This Cheat Sheet](#section_how_to_read)
2. [Escaping Special Characters](#section_escaping_special_characters)
3. [Headers](#section_headers)
4. [Horizontal Rules](#section_horizontal_rules)
5. [Inline Styles](#section_inline_styles)
6. [Line Breaks](#section_line_breaks)
7. [Blockquotes](#section_blockquotes)
8. [Preformatted Text](#section_preformatted_text)
9.  [Lists](#section_lists)
10. [Tables](#section_tables)
11. [Links](#section_links)
12. [Images](#section_images)
13. [Videos](#section_videos)

<br>

<!--======================================================================================
    How to Read This Cheat Sheet
=======================================================================================-->
<a id="section_how_to_read"></a>
## How to Read This Cheat Sheet

Each section of this cheat sheet begins with a description of a particular feature of Markdown, including examples of the feature in the text itself.

After the description, the raw Markdown used to generate the description will be displayed in a preformatted textbox.

Compare the output with the raw syntax used in the preformatted textboxes to observe Markdown parsing in action!

<!--For example, this HTML comment appears in this preformatted textbox, but not in the output below, as text inside comment tags is never rendered.-->

<br/>

### A Note on HTML Syntax in Markdown Documents


Since Markdown is just a more easily readable syntax used to generate HTML, this means that all valid HTML is also valid Markdown!

This fact normally only comes into play in the form of `<!-- -->` comments (used to comment your Markdown code), `<br>` tags (used to create line breaks), `<a>` tags (used to create internal links), and `<style>` tags (used to include internal stylesheets). All of these uses are touched upon later in the cheat sheet, but only with regards to how these tags are typically used in Markdown documents. For more information on HTML and CSS usage, I recommend you look elsewhere.

<br>

``` markdown
Each section of this cheat sheet begins with a box of preformatted Markdown text that one might enter into a Markdown-compatible text editor.

After the preformatted text, the corresponding output is displayed.

<!--For example, this HTML comment appears in this preformatted textbox, but not in the output below, as text inside comment tags is never rendered.-->

<br>

### A Note on HTML Syntax in Markdown Documents


Since Markdown is just a more easily readable syntax used to generate HTML, this means that all valid HTML is also valid Markdown!

This convenient fact normally only comes into play in the form of `<!-- -->` comments (used to comment your Markdown code), `<br>` tags (used to create line breaks), `<a>` tags (used to create internal links), and `<style>` tags (used to include internal stylesheets). All of these uses are touched upon later in the cheat sheet, but only with regards to how these tags are typically used in Markdown documents. For more information on HTML and CSS syntax, I recommend you look elsewhere.
```

<br>

<!--======================================================================================
    Escaping Special Characters
=======================================================================================-->
<a id="section_escaping_special_characters"/></a>
## Escaping Special Characters

You can interpret Markdown's special characters literally by preceding them with a \\ backslash character.

This is useful if, for example, you need to discuss a construct such as \<br> without actually inserting a line break.

Keep in mind that because \\ is itself a special character, you will need to type \\\\ to include a literal backslash in your text.

`Inline preformatted text`, discussed later in this cheat sheet, is also a useful way to display special characters such as `\` literally.

<br>

``` markdown
You can interpret Markdown's special characters literally by preceding them with a \\ backslash character.

This is useful if, for example, you need to discuss a construct such as "\<br>" without actually inserting a line break.

Keep in mind that because \\ is itself a special character, you will need to type \\\\ to include a literal backslash in your text.

`Inline preformatted text`, discussed later in this cheat sheet, is also a useful way to display special characters such as `\` literally.
```

<br>

<!--======================================================================================
    Headers
=======================================================================================-->
<a id="section_headers"></a>
## Headers

Headers are useful for titling the sections and subsections of your document.

To create a header, precede the header text by one to six `#` number sign characters, depending on what level of header you want to create.

# H1
## H2
### H3
#### H4
##### H5
###### H6

H1 and H2 headers can also be created by following them with a line containing any number of `=` equals or `-` hyphen characters, respectively.

H1 With Equal Signs
=

H2 With Hyphens
---

<br>

``` markdown
Headers are useful for titling the sections and subsections of your document.

To create a header, precede the header text by one to six `#` number sign characters, depending on what level of header you want to create.

# H1
## H2
### H3
#### H4
##### H5
###### H6

H1 and H2 headers can also be created by following them with a line containing any number of `=` equals or `-` hyphen characters, respectively.

H1 With Equal Signs
=

H2 With Hyphens
---
```

<br>

<!--======================================================================================
    Horizontal Rules
=======================================================================================-->
<a id="section_horizontal_rules"/></a>
## Horizontal Rules

Horizontal rules are useful for creating underlines for your headers or, alternatively, sectioning off parts of your document without using a header.

To create a horizontal rule, insert a line containing at least three `-` hyphen, `_` underscore, or `*` asterisk characters and nothing else.

---

or

___

or

***

<br>

``` markdown
Horizontal rules are useful for creating underlines for your headers or, alternatively, sectioning off parts of your document without using a header.

To create a horizontal rule, insert a line containing at least three `-` hyphen, `_` underscore, or `*` asterisk characters and nothing else.


---

or

___

or

***
```

<br>

<!--======================================================================================
    Inline Styles
=======================================================================================-->
<a id="section_inline_styles"/></a>
## Inline Styles

To italicize text inline, insert `*` *asterisks* or `_` _underscores_ around the text to format.

To bold text inline, insert double `**` **asterisks** or `__` __underscores__ around the text to format.

You can **mix _and_** _match_ by __combining *the*__ *two*. Keep in mind that this syntax functions like parentheses or XML, and thus itlicized and bolded sections of text must  be properly _ne**st**ed_. Otherwise, you will get **_we**ird_ output.

For the sake of consistency, a common convention is to use only `_` _underscores for italicized text_ and only `**` **asterisks for bold text**.

You can also create strikethrough text by inserting double `~~` ~~squiggles~~ tildes around the text to format.

<br>

``` markdown
To italicize text inline, insert `*` *asterisks* or `_` _underscores_ around the text to format.

To bold text inline, insert double `**` **asterisks** or `__` __underscores__ around the text to format.

You can **mix _and_** _match_ by __combining *the*__ *two*. Keep in mind that this syntax functions like parentheses or XML, and thus itlicized and bolded sections of text must  be properly _ne**st**ed_. Otherwise, you will get **_we**ird_ output.

For the sake of consistency, a common convention is to use only `_` _underscores for italicized text_ and only `**` **asterisks for bold text**.

You can also create strikethrough text by inserting double `~~` ~~squiggles~~ tildes around the text to format.
```

<br>

<!--======================================================================================
    Line Breaks
=======================================================================================-->
<a id="section_line_breaks"/></a>
## Line Breaks

Text on the same line appear as part of the same paragraph.

Text separated by
only one newline
will appear as
part of the same
paragraph. The line
breaks
are converted to
spaces.

Text separated by two or more newlines will appear as separate paragraphs.

Like this!

You can insert line breaks without starting a new paragraph using HTML `<br>` tags.<br>It's handy!

`<br>` tags can also be used to insert multiple empty lines between paragraphs.

<br><br><br>

The empty lines above push this text so far away!

<br>

``` markdown
Text on the same line appear as part of the same paragraph.

Text separated by
only one newline
will appear as
part of the same
paragraph. The line
breaks
are converted to
spaces.

Text separated by two or more newlines will appear as separate paragraphs.

Like this!

You can insert line breaks without starting a new paragraph using HTML `<br>` tags.<br>It's handy!

`<br>` tags can also be used to insert multiple empty lines between paragraphs.

<br><br><br>

The empty lines above push this text so far away!

<br>
```

<br>

<!--======================================================================================
    Blockquotes
=======================================================================================-->
<a id="section_blockquotes"/></a>
## Blockquotes

To create a blockquote, precede each line in the paragraph to format with one ">" (greater than) and one space character.

> "I give myself very good advice,
> but I very seldom follow it."<br>-- Alice (_Alice in Wonderland_)

> "Note that blockquote lines separated by two or more newlines (or anything that isn't a blockquote) will appear as part of separate blockquotes."<br>-- Erick Fernandez de Arteaga (_Markdown Cheat Sheet_)

<br>

``` markdown
To create a blockquote, precede each line in the paragraph to format with one ">" (greater than) and one space character.

> "I give myself very good advice,
> but I very seldom follow it."<br>-- Alice (_Alice in Wonderland_)

> "Note that blockquote lines separated by two or more newlines (or anything that isn't a blockquote) will appear as part of separate blockquotes."<br>-- Erick Fernandez de Arteaga (_Markdown Cheat Sheet_)
```

<br>

<!--======================================================================================
    Preformatted Text
=======================================================================================-->
<a id="section_preformatted_text"/></a>
## Preformatted Text

To create preformatted text inline (like I do to highlight special characters throughout this cheat sheet), insert `backticks` around the text to format.

```
To create a preformatted text block (like I've been doing in every section of this cheat sheet to show the raw Markdown), type three backticks on the lines before and after the text to preformat.
```

To apply the syntax highlighting for a specific code language to a preformatted text block, type a space and the name of the language after the three backticks in the first line.

Sometimes the filetype extension is used rather than the language name, such as in the case of "`cs`" for C#. You can google what to type for your desired language.

``` cs
int myInt = 5;
Debug.Log("Some text.");
```

<br>

_NOTE: Because the following code itself features the triple backticks that are used to make preformatted text blocks, I had to escape the backticks using `\` backslash characters to prevent the formatting from breaking._

_To actually generate the output text above, `\` backslash characters should not be used._ 

``` markdown
To create preformatted text inline (like I do to highlight special characters throughout this cheat sheet), insert `backticks` around the text to format.

\```
To create a preformatted text block (like I've been doing in every section of this cheat sheet to show the raw Markdown), type three backticks on the lines before and after the text to preformat.
\```

To apply the syntax highlighting for a specific code language to a preformatted text block, type a space and the name of the language after the three backticks in the first line.

Sometimes the filetype extension is used rather than the language name, such as in the case of "`cs`" for C#. You can google what to type for your desired language.

\``` cs
int myInt = 5;
Debug.Log("Some text.");
\```
```

<br>

<!--======================================================================================
    Lists
=======================================================================================-->
<a id="section_lists"/></a>
## Lists

### Ordered Lists


1. To create an ordered (i.e., numbered) list, begin a line with a number, a period, and a space character, followed by the list item text.

2. Continue numbering consecutive lines to add more items to the list.

3. The number used for the first list item determines what number the list's numbering starts at, but subsequent numbers don't matter. For example, all three list items so far have been numbered 1 in the raw Markdown but will appear as item 3 in the output.

   1. You can create sub-items by preceding a list item with 3 space characters.

   2. Keep in mind that the first in a string of sub-items is considered the beginning of a new list, and so its number _does_ matter. Note how the item above this one is numbered 7 in both the raw Markdown and the output.

      1. You can keep nesting list items with three-space indentations as far as you want.

4. List items indented the same amount will be treated as belonging to the same list level. Their numbering will behave as expected. For example, this item is numbered 1 in the raw Markdown, but 4 in the output, since it continues from the previous numbering.

<br>

### Unordered Lists


- To create an unordered (i.e., bulleted) list, use `-` hyphens...

* ...`*` asterisks...

+ ...or `+` plus signs. You can mix and match these three within a single unordered list without any trouble.

   - Sub-items are created the same way as with numbered lists: by preceding the item with three space characters.

   - Instead of starting a new numbered list, as numbered sub-items do, unordered sub-items normally have bullets that look different from those of the first list level.

      - As with numbered lists, unordered lists can be nested as much as you want.

* Returning to the regular list indentation also works the same way as with numbered lists.

<br>

### Mixing List Types


1. You can create an ordered list...
   - ...with unordered sub-items!

<br>

- Or an unordered list...
   1. ...with numbered sub-items!

<br>

``` markdown
### Ordered Lists


1. To create an ordered (i.e., numbered) list, begin a line with a number, a period, and a space character, followed by the list item text.

1. Continue numbering consecutive lines to add more items to the list.

2. The number used for the first list item determines what number the list's numbering starts at, but subsequent numbers don't matter. For example, all three list items so far have been numbered 1 in the raw Markdown but will appear as item 3 in the output.

   1. You can create sub-items by preceding a list item with 3 space characters.

   2. Keep in mind that the first in a string of sub-items is considered the beginning of a new list, and so its number _does_ matter. Note how the item above this one is numbered 7 in both the raw Markdown and the output.

      1. You can keep nesting list items with three-space indentations as far as you want.

1. List items indented the same amount will be treated as belonging to the same list level. Their numbering will behave as expected. For example, this item is numbered 1 in the raw Markdown, but 4 in the output, since it continues from the previous numbering.

<br>

### Unordered Lists


- To create an unordered (i.e., bulleted) list, use `-` hyphens...

* ...`*` asterisks...

+ ...or `+` plus signs. You can mix and match these three within a single unordered list without any trouble.

   - Sub-items are created the same way as with numbered lists: by preceding the item with three space characters.

   - Instead of starting a new numbered list, as numbered sub-items do, unordered sub-items normally have bullets that look different from those of the first list level.

      - As with numbered lists, unordered lists can be nested as much as you want.

* Returning to the regular list indentation also works the same way as with numbered lists.

<br>

### Mixing List Types


1. You can create an ordered list...
   - ...with unordered sub-items!

<br>

- Or an unordered list...
   1. ...with numbered sub-items!
```

<br>

<!--======================================================================================
    Tables
=======================================================================================-->
<a id="section_tables"/></a>
## Tables

To create a table, use `|` vertical bars to define columns and `-` hyphens to define the header row.

| A      | Nice | Header |
| ------ | ---- | ------ |
| Here's | some | data.  |
| And    | some | more.  |
| And    | some | more.  |
| And    | some | more.  |

You can use colon characters to left-, center-, or right-align the text within table columns as below.

| Left | Center | Right |
| ---- |:------:| -----:|
| 1    | 1      | 1     |
| 22   | 22     | 22    |
| 333  | 333    | 333   |
| 4444 | 4444   | 4444  |

Your Markdown text doesn't need to be neatly aligned for the table to display properly. The outer vertical bars and padding spaces are optional, and you only need three hyphen characters per column to indicate the header row.

This|Ugly|Formatting
---|---|---
can|still|become
a|beautiful|table.
Isn't|it|great
how|this|works?|

<br>

``` markdown
To create a table, use `|` vertical bars to define columns and `-` hyphens to define the header row.

| A      | Nice | Header |
| ------ | ---- | ------ |
| Here's | some | data.  |
| And    | some | more.  |

You can use colon characters to left-, center-, or right-align the text within table columns as below.

| Left | Center | Right |
| ---- |:------:| -----:|
| 1    | 1      | 1     |
| 22   | 22     | 22    |
| 333  | 333    | 333   |

Your Markdown text doesn't need to be neatly aligned for the table to display properly. The outer vertical bars and padding spaces are optional, and you only need three hyphen characters per column to indicate the header row.

This|Ugly|Formatting
---|---|---
can|still|become
a|beautiful|table.
```

<br>

<!--======================================================================================
    Links
=======================================================================================-->
<a id="section_links"/></a>
## Links

### External Links


In other words, links to a resource OUTSIDE your Markdown document, such as a webpage.

[An inline link.](https://www.google.com)

[An inline link with a tooltip.](https://www.google.com "Hover over the link for a tooltip.")

[A reference link.][Any text you want]

[A reference link with a tooltip.][This reference defines both the link source and the tooltip text]

A reference link using [the link text as the reference name.]


<!-- The references used in the links above. These must be defined in order for your links to work, and will not be rendered by a parser. -->

[Any text you want]: https://www.google.com

[This reference defines both the link source and the tooltip text]: https://www.google.com "Hover over the reference link for a tooltip."

[the link text as the reference name.]: https://www.google.com "This type of link can have a tooltip, too."

<br>

### Internal Links (Anchors)


In other words, a link to a particular place WITHIN your Markdown document, such as a heading. Internal links are great for making tables of contents!

[This link goes to an anchor in the document with the given #name.](#anchor_id_to_jump_to "Just like with external links, you can define tooltip text for anchors.")

The anchor link above will link you to the text below.

<a id="anchor_id_to_jump_to"></a>
The anchor link above will link you here!

<br>

``` markdown
### External Links


In other words, links to a resource OUTSIDE your Markdown document, such as a webpage.

[An inline link.](https://www.google.com)

[An inline link with a tooltip.](https://www.google.com "Hover over the link for a tooltip.")

[A reference link.][Any text you want]

[A reference link with a tooltip.][This reference defines both the link source and the tooltip text]

A reference link using [the link text as the reference name.]


<!-- The references used in the links above. These must be defined in order for your links to work, and will not be rendered by a parser. -->

[Any text you want]: https://www.google.com

[This reference defines both the link source and the tooltip text]: https://www.google.com "Hover over the reference link for a tooltip."

[the link text as the reference name.]: https://www.google.com "This type of link can have a tooltip, too."

<br>

### Internal Links (Anchors)


In other words, a link to a particular place WITHIN your Markdown document, such as a heading. Internal links are great for making tables of contents!

[This link goes to an anchor in the document with the given #name.](#anchor_id_to_jump_to "Just like with external links, you can define tooltip text for anchors.")

The anchor link above will link you to the text below.

<a id="anchor_id_to_jump_to"></a>
The anchor link above will link you here!
```

<br>

<!--======================================================================================
    Images
=======================================================================================-->
<a id="section_images"/></a>
## Images

To insert an image in your document, use the same syntax as for links, but precede it with an exclamation point.

An inline image link:

![Alternate text for the image that will appear if the image cannot be displayed](https://www.google.ca/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png)

An inline image link with a tooltip:

![Alternate text for the image](https://www.google.ca/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png "Hover over the image for a tooltip.")

A reference image link with a tooltip:

![Alternate text for the image][Just as with regular reference links, this reference defines both the image source and the tooltip text]

[Just as with regular reference links, this reference defines both the image source and the tooltip text]: https://www.google.ca/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png "Hover over the reference image for a tooltip."

To create an image that is also a link, wrap the normal image syntax in square brackets and follow it with the source link in parentheses.

[![Alternate text for the image](https://www.google.ca/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png)](https://www.google.com/ "This image is a link that will take you to www.google.com.")

<br>

``` markdown
To insert an image in your document, use the same syntax as for links, but precede it with an exclamation point.

An inline image link:

![Alternate text for the image that will appear if the image cannot be displayed](https://www.google.ca/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png)

An inline image link with a tooltip:

![Alternate text for the image](https://www.google.ca/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png "Hover over the image for a tooltip.")

A reference image link with a tooltip:

![Alternate text for the image][Just as with regular reference links, this reference defines both the image source and the tooltip text]

[Just as with regular reference links, this reference defines both the image source and the tooltip text]: https://www.google.ca/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png "Hover over the reference image for a tooltip."

To create an image that is also a link, wrap the normal image syntax in square brackets and follow it with the source link in parentheses.

[![Alternate text for the image](https://www.google.ca/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png)](https://www.google.com/ "This image is a link that will take you to www.google.com.")
```

<br>

<!--======================================================================================
    Videos
=======================================================================================-->
<a id="section_videos"/></a>
## Videos

Although you cannot embed an online video in a Markdown document, you can easily insert an image of its thumbnail and make it a link to the video.

[![Alternate text for the image](https://img.youtube.com/vi/pTCROLZLhDM/maxresdefault.jpg)](https://www.youtube.com/watch?v=pTCROLZLhDM)

<br>

``` markdown
Although you cannot embed an online video in a Markdown document, you can easily insert an image of its thumbnail and make it a link to the video.

[![Alternate text for the image](https://img.youtube.com/vi/pTCROLZLhDM/maxresdefault.jpg)](https://www.youtube.com/watch?v=pTCROLZLhDM)
```

<!--======================================================================================
    Reference Links
=======================================================================================-->
[ref_github_profile]: https://github.com/erick-fda "Erick's GitHub Profile"

[ref_linkedin_profile]: https://www.linkedin.com/in/erick-fda "Erick's LinkedIn Profile"

<!--======================================================================================
   CSS
=======================================================================================-->
<link href="../CSS/dark.css" rel="stylesheet"></link>