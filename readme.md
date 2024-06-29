###### [<img src="flag-br.png" alt="Portugu&ecirc;s">](readme-pt.md "Versão em Português")
# Just Another PDF Reader

By [Marco Aurélio Oliveira](https://maurelio.com.br)

Derived from https://github.com/pvginkel/PdfiumViewer

![Main window sample](/imgs/main-window.png "Main window")

This project isn’t anything special. I just wanted a FAST AND SIMPLE PDF reader, which is hard to find these days.

Furthermore, I really needed to train a little in *frontend*, componentization, etc.

Feel free to make it look however you want.

## Summary of Modifications Made
- Transferred the functionalities of the main application to the DLL.
>*This way, the PDF reader component became very easy to use. Just put it on the screen and write a few lines of code.*
- Modified the entire appearance of the application, including:
 - Remodeling of all screens, with implementation of form inheritance.
 >*Almost all forms derive from 1 single form now. It's much easier to customize them all at once.*
 - Reorganization of menus and control panels for better usability, including new features and icons.
 - Messages in Rich Text Format.
 >*Enhance the ability to capture the user's attention with vibrant colors and rich formatting.*
 - List of recently opened documents.
 - Text extraction and selection with a single click on the screen (Ctrl+Click).
 - Creation of usage permission parameters.
 >*The programmer defines which commands will be enabled for the user.*

## Using the Component in your Application
1. Create a new Windows Forms project;
2. In the DLL project, select the `pdfium.dll` and `PDFiumMMG.dll` files that best suit your project;
>*Remember that they can be "Release" or "Debug", 32-bit or 64-bit.*
3. Add `pdfium.dll` to the project by right-clicking on the project in the `Solution Explorer` window and choosing `Add > Existing Item`.
>*The file will be copied to the project root folder. This is the most practical way to make Visual Studio copy it to the same folder where the executable will be created when the application is compiled.*
4. In the `Solution Explorer` window, left-click on `pdfium.dll`;
>*The `Properties` window will display the file attributes.*
5. Set the `Copy to Output Directory` property to `Copy always`;
6. In the `Solution Explorer` window, click on `References` or `Dependencies` with the right mouse button and select `Add > Reference`;
7. In the `Reference Manager` window, click the `Browse` button, look for the file `PDFiumMMG.dll`, and select this file.

Ready! The project is prepared to run PDF Reader, with a few more lines of code, as shown below:
### Add the component to the Form
```
PdfViewer pdfViewer;
public MainForm()
{
    InitializeComponent();

    pdfViewer = new PdfViewer();
    pdfViewer.Dock = DockStyle.Fill;
    Controls.Add(pdfViewer);
    Disposed += (s, e) => pdfViewer.Document?.Dispose();
}
```
### Set user permissions
```
PDFPermissions permissions = new PDFPermissions
{
    MainMenuVisible = true,
    MainToolBarVisible = true,
    MainStatusBarVisible = true,

    OpenEnabled = true,
    SaveEnabled = true,
    PrintEnabled = true,
    DocumentPropertiesEnabled = true,
    EditEnabled = true
};
```
### Add title callback function
```
Action<string> setDocumentName = (name) => this.Text = name + " - MMG PDF Viewer";
pdfViewer.Init(permissions, setDocumentName);
```
### Read initialization file
```
IniFile iniFile;
if (File.Exists(this.iniFilePath))
{
    StreamReader xmlStream = new StreamReader(this.iniFilePath);
    XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
    iniFile = (IniFile)serializer.Deserialize(xmlStream);
    xmlStream.Close();
}
else
{
    iniFile = new IniFile();
}
pdfViewer.IniFile = iniFile;
```
### When closing the application, save initialization file
```
IniFile iniFile = this.pdfViewer.IniFile;
StreamWriter xmlStream = new StreamWriter(this.iniFilePath);
XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
serializer.Serialize(xmlStream, iniFile);
xmlStream.Close();
```
>*Save the initialization file in the format you prefer. In this example I used XML because I didn't want more DLLs included in the project to use JSON.*

## Additional Feature: Messages in RTF Format
I developed a Rich Text Format generator for use with a new messaging form designed to replace the standard Windows Forms MessageBox.

The implementation aims to replicate HTML syntax, which is more widely recognized than RTF, as demonstrated below:

### Show message using MessageBox like syntax
```
MsgBox.Show("Displaying unformatted text on MsgBox with MessageBox syntax.");
```
![MsgBox sample](/imgs/en_US/msgbox-01.png "MsgBox with MessageBox syntax")

### Show message using Using RTF MsgBox
```
MsgBox.Format().t("Displaying MsgBox with formatting").i.t("in italics").ei.t("for demonstration purposes.").Show();
```
![MsgBox sample](/imgs/en_US/msgbox-02.png "MsgBox with RTF formatting")

### Formatting complex texts
#### Paragraphs, font attributes and list...
```
MsgBox.Format()
 .p.t("The following text is written in").green.i.b.t("green bold italics.").ei.eb
 .white.t("Notice that the opening and closing order of nested tags does not matter.").ep

 .p.t("You can also create lists, as follows:").ep
 .ul
 .li.t("First item in the list.").eli
 .li.t("Second item in the list.").eli
 .eul

 .Show();
```
![MsgBox Sample](/imgs/en_US/msgbox-03.png "Paragraphs, colors and list")

#### Paragraphs, colors, "code" tag and hyperlinks...
```
MsgBox.Format()
 .p.t("You can include links directly in the string, such as https://www.microsoft.com, but they will have the default formatting.")
 .t("Also, the link closest to the end of the text may not work, due to a RichTextBox bug.").ep

 .p.t("Using function").yellow.code("href").white.t(" you can format the link as below, in")
 .cyan.href("https://www.microsoft.com/", "Cyan Microsoft").white.t(", or like").salmon.i.href("https://www.google. com", "Salmon Italic Google").ei.white.ep

 .Show();
```
![MsgBox Sample](/imgs/en_US/msgbox-04.png "Paragraphs, colors and hyperlinks")
### Comments
#### Fonts and colors
The RTF format is not exactly equivalent to HTML. Therefore, the RTF API has slightly different aspects and some limitations, such as:
- Not all HTML tags exist in the API.
- It is not possible to use CSS.
- The RTF file header is pre-defined in the API, so things like fonts/color tables cannot be modified.
 - There are 3 sources available:
 - Sans serif: Helvetica
 - Serif: Times
 - Monospaced: Courier
 - The available colors are: red, green, blue, yellow, black, white, cyan, magenta and salmon.
#### The `pack()` function
- When you need to encode pieces of RTF to join them at another point in the code, use the `pack()` function. This function is a *noop*, and is only used to complete the last tag of a sequence, when this tag is not a function. Example:
```
RTFBuilder rtfBuilder = new RTFBuilder();
foreach (string item in this.lines)
{
    rtfBuilder.p.t(item).ep.pack(); // pack does nothing
}
```
#### The RichTextBox bug
Above version 4.6 of the .NET Framework, the RichTextBox component does not generate the click event of a *link* that is very close to the end of the text.

For *link* to work there must be a certain number of characters after the end of *link*. This number of characters is the sum of the total characters of each link in the text. (believe me, I tested it)

Therefore, for each *link* inserted with `href`, RTFBuilder adds the number of characters to a counter. When displaying the message, MsgBox reads this counter and inserts blanks at the end of the message if it contains any *hyperlinks*.