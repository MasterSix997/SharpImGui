using System.Text;

namespace Generator.CodeGen;

public abstract class CodeWriter
{
    protected int CurrentIndentLevel = 0;

    public abstract CodeWriter Write(string text);
    public abstract CodeWriter Write(char c);
    public abstract CodeWriter WriteLine(string text = "");

    public virtual CodeWriter WriteLines(params string[] lines)
    {
        foreach (var line in lines)
            WriteLine(line);
        return this;
    }

    public virtual CodeWriter StartLine()
    {
        Write(GetIndentText());
        return this;
    }

    public virtual CodeWriter EndLine()
    {
        WriteLine();
        return this;
    }

    public virtual CodeWriter PushBlock()
    {
        WriteLine("{");
        AddIndent();
        return this;
    }

    public virtual CodeWriter PopBlock()
    {
        RemoveIndent();
        WriteLine("}");
        return this;
    }

    public virtual CodeWriter AddIndent()
    {
        CurrentIndentLevel++;
        return this;
    }

    public virtual CodeWriter RemoveIndent()
    {
        CurrentIndentLevel--;
        return this;
    }
    
    protected string GetIndentText()
    {
        return new string('\t', CurrentIndentLevel);
    }
}

public class StreamCodeWriter : CodeWriter, IDisposable, IAsyncDisposable
{
    private readonly StreamWriter _writer;

    public StreamCodeWriter(string outputPath)
    {
        _writer = new StreamWriter(outputPath);
    }

    public override CodeWriter Write(string text)
    {
        _writer.Write(text);
        return this;
    }
    
    public override CodeWriter Write(char c)
    {
        _writer.Write(c);
        return this;
    }

    public override CodeWriter WriteLine(string text = "")
    {
        if (text.Length == 0)
            _writer.WriteLine();
        else
        {
            _writer.Write(GetIndentText());
            _writer.WriteLine(text);
        }
        return this;
    }

    public void Dispose()
    {
        _writer.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        await _writer.DisposeAsync();
    }
}

public class StringCodeWriter : CodeWriter
{
    private readonly StringBuilder _builder = new();

    public override CodeWriter Write(string text)
    {
        _builder.Append(text);
        return this;
    }
    
    public override CodeWriter Write(char c)
    {
        _builder.Append(c);
        return this;
    }

    public override CodeWriter WriteLine(string text = "")
    {
        if (text.Length == 0)
            _builder.AppendLine();
        else
        {
            _builder.Append(GetIndentText());
            _builder.AppendLine(text);
        }
        return this;
    }

    public override string ToString()
    {
        return _builder.ToString();
    }
}

