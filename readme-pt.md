###### [<img src="flag-us.png" alt="English">](readme.md "English Version")
# Apenas mais um PDF Reader

By [Marco Aurélio Oliveira](https://maurelio.com.br)

Derivado de https://github.com/pvginkel/PdfiumViewer

Este projeto não tem nada de especial. Eu apenas queria ter um leitor de arquivos PDF RÁPIDO E SIMPLES, o que é difícil de encontrar hoje em dia.

Além disso, eu estava mesmo precisando treinar um pouco de *frontend*, componentização, etc.

Fique à vontade para deixá-lo com a aparência que você quiser.

## Resumo das Modificações Realizadas
- Transferi as funcionalidades da aplicação principal para a DLL.
- >*Assim, o componente leitor de PDF ficou muito simples de usar. Basta colocar na tela e escrever umas poucas linhas de código.* 
- Modifiquei toda a aparência da aplicação, incluindo:
  - Remodelagem de todas as telas, com Implementação de herança de formulários.
  >*Quase todos os formulários derivam de 1 único formulário agora. Fica muito mais fácil personalizar todos de uma vez.*
  - Reorganização dos menus e painéis de controle para melhor usabilidade, incluindo novos ícones e facilidades.
  - Mensagens em Rich Text Format (texto formatado).
  >*Facilitam chamar a atenção do usuário com cores e outras formatações.*
  - Lista de documentos abertos recentemente.
  - Extração e seleção de texto na tela.
  - Criação de parâmetros de permissões de uso.
  >*O programador define quais comandos estarão habilitados para o usuário.*

## Usando o Componente em seu Aplicativo
1. Crie um novo projeto Windows Forms;
2. Escolha um par de arquivos `pdfium.dll` e `PDFiumMMG.dll`, a seu gosto;
>*Lembre-se de que podem ser "Release" ou "Debug", de 32-bit ou 64-bit.*
3. Adicione `pdfium.dll` ao projeto clicando com o botão direito sobre o projeto na janela `Solution Explorer` e escolhendo `Add > Existent Item`.
>*O arquivo será copiado para a pasta raiz do projeto. Essa é a forma mais prática de fazer o Visual Studio copiá-lo para a mesma pasta em que o executável será criado quando a aplicação for compilada.*
4. Na janela `Solution Explorer`, clique com o botão esquerdo sobre `pdfium.dll`;
>*A janela `Propriedades` irá exibir os atributos do arquivo.*
5. Defina a propriedade `Copy to Output Directory` como `Copy always`;
6. Na janela `Solution Explorer`, clique em `References` ou `Dependencies` com o botão direito do mouse e selecione `Add > Reference`;
7. Na janela `Reference Manager", clique no botão `Browse`, procure o arquivo `PDFiumMMG.dll`, e selecione este arquivo.

Pronto! O projeto está preparado para executar o PDF Reader, com mais algumas poucas linhas de código, conforme mostrado a seguir:
### Adicionar o componente ao Form
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
### Definir as permissões de usuário
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
### Adicionar função de callback
```
Action<string> setDocumentName = (name) => this.Text = name + " - MMG PDF Viewer";
pdfViewer.Init(permissions, setDocumentName);
```
### Ler arquivo de inicialização
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
### Salvar arquivo de inicialização
```
IniFile iniFile = this.pdfViewer.IniFile;
StreamWriter xmlStream = new StreamWriter(this.iniFilePath);
XmlSerializer serializer = new XmlSerializer(typeof(IniFile));
serializer.Serialize(xmlStream, iniFile);
xmlStream.Close();
```
>*Grave o arquivo de inicilização no formato que você preferir. Neste exemplo eu usei XML porque não queria mais DLLs incluídas no projeto para utilizar JSON.*

## Recurso Adicional: Mensagens em Formato RTF
Desenvolvi um formatador de Rich Text Format (Formato de Texto Rico) para usar com um novo formulário de mensagens que visa substituir o MessageBox padrão do Windows Forms.

A implementação busca reproduzir a sintaxe HTML, que é bem mais conhecida do que RTF, como demonstrado a seguir:

### Usando a sintaxe padrão da MessageBox do Windows Forms
```
MsgBox.Show("Exibindo MsgBox com sintaxe de MessageBox.");
```
![Amostra MsgBox](/imgs/msgbox-01.png "MsgBox com sintaxe de MessageBox")

### Usando o RTF MsgBox
```
MsgBox.Format().t("Exibindo MsgBox com formatação").i.t("em itálico").ei.t("para fins de demonstração.").Show();
```
![Amostra MsgBox](/imgs/msgbox-02.png "MsgBox com formatação RTF")

### Formatando textos complexos
#### Parágrafos, atributos de fonte e lista...
```
MsgBox.Format()
    .p.t("O texto a seguir está escrito em").green.i.b.t("verde itálico negrito.").ei.eb
    .white.t("Repare que a ordem de abertura e fechamento das tags aninhadas não importa.").ep

    .p.t("Você também pode criar listas, como a seguir:").ep
    .ul
        .li.t("Primeiro item da lista.").eli
        .li.t("Segundo item da lista.").eli
    .eul

    .Show();
```
![Amostra MsgBox](/imgs/msgbox-03.png "Parágrafos, cores e lista")

#### Parágrafos, cores, tag "code" e hiperlinks...
```
MsgBox.Format()
    .p.t("Você pode incluir links diretamente na string, como https://www.microsoft.com, mas eles ficarão com a formatação padrão.")
    .t("Além disso, o link mais próximo do final do texto pode não funcionar, devido a um bug do RichTextBox.").ep

    .p.t("Usando a função").yellow.code("href").white.t(" você pode formatar o link como a seguir, em")
    .cyan.href("https://www.microsoft.com/", "Cyan Microsoft").white.t(", ou como").salmon.i.href("https://www.google.com", "Salmon Italic Google").ei.white.ep

    .Show();
```
![Amostra MsgBox](/imgs/msgbox-04.png "Parágrafos, cores e hiperlinks")
### Observações
#### Fontes e cores
O formato RTF não é exatamente equivalente ao HTML. Portanto, a API criada tem funções diferentes e alguns truques, como:
- O header do arquivo RTF já vem pré-definido na API. Coisas como tabelas de cores e fontes não podem ser modificadas.
  - São 3 fontes disponíveis:
    - Sem serifa: Helvetica
    - Com serifa: Times
    - Mono-espaçada: Courier
  - As cores disponíveis são: vermelho, verde, azul, amarelo, preto, branco, ciano, magenta e salmão.
#### A função `pack()`
- Quando precisar codificar pedaços de RTF para uni-los em outro ponto do código, utilize a função `pack()`. Esta função é uma *noop*, e serve apenas para completar a última tag de uma sequência, quando esta não for uma função. Exemplo:
```
RTFBuilder rtfBuilder = new RTFBuilder();
foreach (string item in this.lines)
{
    rtfBuilder.p.t(item).ep.pack(); // pack não faz nada
}
```
#### O bug do RichTextBox
Acima da versão 4.6 do .NET Framework o componente RichTextBox não gera o evento click de um *link* que esteja muito perto do fim do texto.

Para o *link* funcionar é preciso haver um certo número de caracteres após o fim do *link*. Este número de caracteres é a soma do total de caracteres de cada link existente no texto. (acreditem, eu testei)

Portanto, a cada *link* inserido com `href`, o RTFBuilder adiciona o número de caracteres a um contador. Ao exibir a mensagem, MsgBox lê esse contador e insere espaços em branco ao final da mensagem, se ela contiver algum *hiperlink*.
