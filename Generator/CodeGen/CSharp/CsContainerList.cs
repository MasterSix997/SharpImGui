using System.Collections;
using System.Diagnostics;

namespace Generator.CodeGen.CSharp;

/// <summary>
/// A generic list of <see cref="CsElement"/> hold by a <see cref="ICsContainer"/>
/// </summary>
/// <typeparam name="TElement"></typeparam>
[DebuggerTypeProxy(typeof(CsContainerListDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public class CsContainerList<TElement> : IList<TElement> where TElement : CsElement
{
    private readonly List<TElement> _elements;

    public CsContainerList(ICsContainer container)
    {
        Container = container ?? throw new ArgumentNullException(nameof(container));
        _elements = new List<TElement>();
    }

    /// <summary>
    /// Gets the container this list is attached to.
    /// </summary>
    public ICsContainer Container { get; }

    /// <inheritdoc />
    public IEnumerator<TElement> GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_elements).GetEnumerator();
    }

    /// <inheritdoc />
    public void Add(TElement item)
    {
        if (item.Parent != null)
        {
            throw new ArgumentException("The item belongs already to a container");
        }
        item.Parent = Container;
        _elements.Add(item);
    }

    public void AddRange(IEnumerable<TElement> collection)
    {
        if (collection != null)
        {
            foreach (var element in collection)
            {
                Add(element);
            }
        }
    }

    /// <inheritdoc />
    public void Clear()
    {
        foreach (var element in _elements)
        {
            element.Parent = null;
        }

        _elements.Clear();
    }

    /// <inheritdoc />
    public bool Contains(TElement item)
    {
        return _elements.Contains(item);
    }

    /// <inheritdoc />
    public void CopyTo(TElement[] array, int arrayIndex)
    {
        _elements.CopyTo(array, arrayIndex);
    }

    public void MoveTo(CsContainerList<TElement> destinationList)
    {
        foreach (var element in _elements)
        {
            element.Parent = destinationList.Container;
            destinationList._elements.Add(element);
        }

        _elements.Clear();
    }

    /// <inheritdoc />
    public bool Remove(TElement item)
    {
        if (_elements.Remove(item))
        {
            item.Parent = null;
            return true;
        }
        return false;
    }

    /// <inheritdoc />
    public int Count => _elements.Count;

    /// <inheritdoc />
    public bool IsReadOnly => false;

    /// <inheritdoc />
    public int IndexOf(TElement item)
    {
        return _elements.IndexOf(item);
    }

    /// <inheritdoc />
    public void Insert(int index, TElement item)
    {
        if (item.Parent != null)
        {
            throw new ArgumentException("The item belongs already to a container");
        }

        item.Parent = Container;
        _elements.Insert(index, item);
    }

    /// <inheritdoc />
    public void RemoveAt(int index)
    {
        var element = _elements[index];
        element.Parent = null;
        _elements.RemoveAt(index);
    }

    /// <inheritdoc />
    public TElement this[int index]
    {
        get => _elements[index];
        set => _elements[index] = value;
    }
}

internal class CsContainerListDebugView<T>
{
    private readonly ICollection<T> _collection;

    public CsContainerListDebugView(ICollection<T> collection)
    {
        _collection = collection ?? throw new ArgumentNullException(nameof(collection));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T[] Items
    {
        get
        {
            T[] array = new T[_collection.Count];
            _collection.CopyTo(array, 0);
            return array;
        }
    }
}