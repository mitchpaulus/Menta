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
            if (blist is AutParser.NormalBlockContext nb)
            {
                var left = nb.block().INTEGER(0).GetText();
                var top = nb.block().INTEGER(1).GetText();
                var header = nb.block().DQUOTESTRING().GetText();
                var blockType = nb.block().BLOCK_DATA().GetText().Split(null)[0];

                if (blockType == "COMENT")
                {
                    string fullBlockText = nb.block().BLOCK_DATA().GetText();
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

public class Block
{
    public List<Block> InputBlocks = new();
    public List<int> InputBlockPorts = new();
    public string Number { get; set; }

    public string Name { get; set; }

    public List<Block> SubBlocks = new();

    public string BlockData;

    public Block(AutParser.BlockContext blockContext)
    {
        Name = blockContext.DQUOTESTRING().GetText().Substring(1, blockContext.DQUOTESTRING().GetText().Length - 2);
        Number = blockContext.NUMBERED().GetText();
        BlockData = blockContext.BLOCK_DATA().GetText();
    }

    public Block()
    {
        Name = "NULL";
        Number = "0";
        BlockData = "NULL";
    }

    public List<MentaType> Evaluate()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"\"{Name}\" {BlockData} ({InputBlocks.Count})";
    }
}

public class MentaType
{

}

public class MentaListener : AutBaseListener
{
    private List<Block> Blocks = new();
    private Dictionary<string, Block> NumberedLookup = new Dictionary<string, Block>();

    private readonly Stack<Block> _parentBlocks = new ();

    public MentaListener()
    {
    }

    public override void EnterBlock(AutParser.BlockContext context)
    {
        Block b = new(context);

        if (b.BlockData.StartsWith("COMENT")) return;

        if (_parentBlocks.Count == 0)
        {
            Blocks.Add(b);
        }
        else
        {
            _parentBlocks.Peek().SubBlocks.Add(b);
        }
    }

    public override void EnterNestedBlock(AutParser.NestedBlockContext context)
    {
        _parentBlocks.Push(Blocks.Last());
    }

    public override void ExitNestedBlock(AutParser.NestedBlockContext context)
    {
        _parentBlocks.Pop();
    }

    public override void EnterConnection(AutParser.ConnectionContext context)
    {
        int fromBlockInt = int.Parse(context.INTEGER(0).GetText());
        int fromBlockPort = int.Parse(context.INTEGER(1).GetText());
        var toConnections = context.connection_line().Connections();

        if (_parentBlocks.Count > 0)
        {
            Block currentBlockContext = _parentBlocks.Peek();
            Block fromBlock = currentBlockContext.SubBlocks[fromBlockInt - 1];

            foreach (var toConnection in toConnections)
            {
                int toBlockInt = toConnection.Item1;
                int toBlockPortInt = toConnection.Item2;

                var toBlock = currentBlockContext.SubBlocks[toBlockInt - 1];

                if (toBlockPortInt - 1 < toBlock.InputBlocks.Count)
                {
                    toBlock.InputBlocks[toBlockPortInt - 1] = fromBlock;
                    toBlock.InputBlockPorts[toBlockPortInt - 1] = fromBlockPort;
                }
                else if (toBlockPortInt - 1 == toBlock.InputBlocks.Count)
                {
                    toBlock.InputBlocks.Add(fromBlock);
                    toBlock.InputBlockPorts.Add(fromBlockPort);
                }
                else
                {
                    for (int i = 0; i < ((toBlockPortInt - 1) - toBlock.InputBlocks.Count) ; i++)
                    {
                        toBlock.InputBlocks.Add(new Block());
                        toBlock.InputBlockPorts.Add(-1);
                    }
                    toBlock.InputBlocks.Add(fromBlock);
                    toBlock.InputBlockPorts.Add(fromBlockPort);
                }
            }
        }

    }
}

public static class Extensions
{
    public static List<(int, int)> Connections(this AutParser.Connection_lineContext clContext)
    {
        if (clContext.connection_line() is null)
        {
            var xyPair = clContext.xy_pair().Last();
            if (xyPair.PERIOD() is null) return new List<(int, int)>();

            return new List<(int, int)>() { (int.Parse(xyPair.INTEGER(0).GetText()), int.Parse(xyPair.INTEGER(1).GetText())) };
        }

        return clContext.connection_line().SelectMany(connLine => connLine.Connections()).ToList();
    }
}