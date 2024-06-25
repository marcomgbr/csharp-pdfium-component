###### [<img src="flag-us.png" alt="English">](readme.md)
# Apenas mais um PDF Reader

By [Marco Aurélio Oliveira](https://maurelio.com.br)

Modificado de https://github.com/pvginkel/PdfiumViewer

Este projeto não tem nada de especial. Eu apenas queria ter um leitor de arquivos PDF RÁPIDO E SIMPLES. Então modifiquei o projeto do van Ginkel e adicionei algumas coisas que eu queria, além de modificar a interface de usuário, também ao meu gosto.

Fique à vontade para deixá-lo com a aparência que você quiser.

Além disso, migrei quase todo o código da aplicação principal para dentro da DLL, tornando o componente praticamente completo para inclusão em outras aplicações. O programador tem que seguir poucos passos e escrever poucas linhas de código para colocar o componente funcionando.

1. Crie um novo projeto Windows Forms;
2. Escolha um par de arquivos `pdfium.dll` e `PDFiumMMG.dll`, a seu gosto;
>*Lembre-se de que podem ser "Release" ou "Debug", de 32-bit ou 64-bit.*
3. Adicione `pdfium.dll` ao projeto clicando com o botão direito sobre o projeto na janela `Solution Explorer` e escolhendo `Add > Existent Item`.
>*O arquivo será copiado para a pasta raiz do projeto. Essa é a forma mais prática de fazer o Visual Studio copiá-lo para a mesma pasta que o executável quando o aplicativo for compilado.*
4. Na janela `Solution Explorer` sobre `pdfium.dll`;
>*A janela `Propriedades` irá exibir os atributos do arquivo.*
5. Defina a propriedade `Copy to Output Directory` como `Copy always`;
6. Na janela `Solution Explorer`, clique em `References` ou `Dependencies` com o botão direito do mouse e selecione `Add > Reference`;
7. Na janela `Reference Manager", clique no botão `Browse`, procure o arquivo `PDFiumMMG.dll`, e selecione este arquivo.

Pronto! O projeto está preparado para executar o PDF Reader, com mais algumas poucas linhas de código, conforme mostrado a seguir:

```
public partial class MainForm : Form
{
    string iniFilePath = Application.UserAppDataPath + @"\MmgPdf.ini";
    PdfViewer pdfViewer;
    public MainForm()
    {
        InitializeComponent();

        pdfViewer = new PdfViewer();
        pdfViewer.Dock = DockStyle.Fill;
        Controls.Add(pdfViewer);
        InitViewer();
        Disposed += (s, e) => pdfViewer.Document?.Dispose();
    }

    private void InitViewer()
    {
        // Set what is to be displayed to the user
        PDFPermissions p = new PDFPermissions
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

        // Here's a little function pointer to update the title bar
        Action<string> setDocumentName = (name) => this.Text = name + " - MMG PDF Viewer";
        pdfViewer.Init(p, setDocumentName);

        // Here we read the initialization data
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
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        IniFile iniFile = this.pdfViewer.IniFile;

        // Here we write the initialization data
        StreamWriter xmlStream = new StreamWriter(this.iniFilePath);
        XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
        serializer.Serialize(xmlStream, iniFile);
        xmlStream.Close();
    }
}
```

>*Grave o arquivo de inicilização no formato que você preferir. Neste exemplo eu usei XML porque não queria mais DLLs incluídas no projeto para utilizar JSON.*