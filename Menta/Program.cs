// See https://aka.ms/new-console-template for more information

using System.Text;
using Antlr4.Runtime;

namespace Menta;


public class Program
{
    public static int Main(string[] args)
    {
        string filePath = args[0];

        AntlrFileStream fileStream = new(filePath);
        AutLexer lexer = new AutLexer(fileStream);
        CommonTokenStream commonTokenStream = new(lexer);
        AutParser autParser = new(commonTokenStream);

        StringBuilder b = new StringBuilder();

        int width = 3935;
        int height = 419;

        int widthInch = 11 * 12;
        int heightInch = 17; // 8.5 x 2

        b.Append($"<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"100%\" height=\"100%\"  viewBox=\"0 0 3935 419\">\n");

        var tree = autParser.file();

        var page = tree.page();

        int fontSize = 1;

        foreach (var blist in page.block_list())
        {
            var block = blist.block();
            if (block is not null)
            {
                var left = block.INTEGER(0).GetText();
                var top = block.INTEGER(1).GetText();
                var header = block.DQUOTESTRING().GetText();
                var blockType = block.BLOCK_DATA().GetText().Split(null)[0];

                if (blockType == "COMENT")
                {
                    string fullBlockText = block.BLOCK_DATA().GetText();
                    // Read from first colon to last '}'
                    int firstColon = fullBlockText.IndexOf(':');
                    int lastBrace = fullBlockText.LastIndexOf('}');
                    string comment = fullBlockText.Substring(firstColon + 1, lastBrace - firstColon - 1);
                    // Replace special XML characters
                    comment = comment.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
                    b.Append($"  <text x=\"{left}\" y=\"{int.Parse(top)}\" font-size=\"{fontSize}\">{comment}</text>\n");
                }
                else
                {
                    b.Append($"  <rect x=\"{left}\" y=\"{top}\" width=\"10\" height=\"10\" fill=\"none\" stroke=\"black\" stroke-width=\"0.25\" />\n");
                    b.Append($"  <text x=\"{left}\" y=\"{int.Parse(top)-1}\" font-size=\"{fontSize}\">{header}</text>\n");
                    b.Append($"  <text x=\"{int.Parse(left) + 5}\" y=\"{int.Parse(top) + 5}\" text-anchor=\"middle\" font-size=\"{fontSize}\">{blockType}</text>\n");
                }
            }
        }

        b.Append("</svg>\n");

        Console.Write(b.ToString());
        return 0;
    }
}
