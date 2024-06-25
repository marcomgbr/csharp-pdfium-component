###### [<img src="flag-us.png" alt="English">](readme.md)
# Apenas mais um PDF Reader

By [Marco Aurélio Oliveira](https://maurelio.com.br)
Modificado de https://github.com/pvginkel/PdfiumViewer, de Pieter van Ginkel (https://github.com/pvginkel)

Este projeto não tem nada de especial. Eu apenas queria ter um leitor de arquivos PDF RÁPIDO E SIMPLES. Então modifiquei o projeto do van Ginkel e adicionei algumas coisas que eu queria, além de modificar a interface de usuário, também ao meu gosto.

Fique à vontade para deixá-lo com a aparência que você quiser.

Além disso, migrei quase todo o código da aplicação principal para dentro da DLL, tornando o componente praticamente completo para inclusão em outras aplicações. O programador tem que seguir poucos passos e escrever poucas linhas de código para colocar o componente funcionando.

- Crie um novo projeto Windows Forms;
- Escolha um par de arquivos `pdfium.dll` e `PDFiumMMG.dll`, a seu gosto;
>*Lembre-se de que podem ser "Release" ou "Debug", de 32 ou 64 bits.*
- Adicione `pdfium.dll` ao projeto clicando com o botão direito sobre o projeto na janela "Solution Explorer" e escolhendo Add > Existent Item.
>*O arquivo será copiado para a pasta raiz do projeto. Essa é a forma mais prática de fazer o Visual Studio copiá-lo para a mesma pasta que o executável quando o aplicativo for compilado.*
- Na janela "Solution Explorer" sobre `pdfium.dll`;
>*A janela "Propriedades" irá exibir os atributos do arquivo.*
- Defina a propriedade "Copy to Output Directory" como "Copy always";
- Na janela "Solution Explorer", clique com o botão direito do mouse e selecione Add > Reference;
- Na janela "Reference Manager", clique no botão `Browse` e procure o arquiv `PDFiumMMG.dll` e o selecione.

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
    }

    private void InitViewer()
    {
        // Defina as opções que serão exibidas para o usuário
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

        // Aqui vai um ponteirinho de função para atualizar a barra de título
        Action<string> setDocumentName = (name) => this.Text = name + " - MMG PDF Viewer";
        pdfViewer.Init(p, setDocumentName);

        
        // Aqui a gente l&ecirc; os dados de inicialização
        IniFile iniFile;
        if (File.Exists(this.iniFilePath))
        {
            StreamReader xmlStream = new StreamReader(this.iniFilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
            iniFile = (IniFile)serializer.Deserialize(xmlStream);
        }
        else
        {
            iniFile = new IniFile();
        }
        pdfViewer.IniFile = iniFile;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        
        // Aqui a gente grava os dados de inicialização
        IniFile iniFile = this.pdfViewer.IniFile;

        StreamWriter xmlStream = new StreamWriter(this.iniFilePath);
        XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
        serializer.Serialize(xmlStream, iniFile);
    }
}
```

>*Grave o arquivo de inicilização no formato que você preferir. Neste exemplo eu usei XML porque não queria mais DLLs incluídas no projeto para utilizar JSON.*