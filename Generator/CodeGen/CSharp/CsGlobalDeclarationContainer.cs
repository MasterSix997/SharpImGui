using System.Collections;
using System.Runtime.CompilerServices;

namespace Generator.CodeGen.CSharp;

/// <summary>
/// A base Cs container for macros, classes, fields, functions, enums, typesdefs.
/// </summary>
public class CsGlobalDeclarationContainer : CsElement, ICsGlobalDeclarationContainer
{
    private readonly Dictionary<ICsContainer, Dictionary<string, CacheByName>> _multiCacheByName;

    /// <summary>
    /// Create a new instance of this container.
    /// </summary>
    public CsGlobalDeclarationContainer()
    {
        _multiCacheByName = new Dictionary<ICsContainer, Dictionary<string, CacheByName>>(ReferenceEqualityComparer<ICsContainer>.Default);
        Fields = new CsContainerList<CsField>(this);
        Methods = new CsContainerList<CsMethod>(this);
        Delegates = new CsContainerList<CsDelegate>(this);
        Enums = new CsContainerList<CsEnum>(this);
        Classes = new CsContainerList<CsClass>(this);
        Namespaces = new CsContainerList<CsNamespace>(this);
        Attributes = new List<CsAttribute>();
    }

    /// <inheritdoc />
    public CsContainerList<CsField> Fields { get; }

    /// <inheritdoc />
    public CsContainerList<CsMethod> Methods { get; }

    public CsContainerList<CsDelegate> Delegates { get; }

    /// <inheritdoc />
    public CsContainerList<CsEnum> Enums { get; }

    /// <inheritdoc />
    public CsContainerList<CsClass> Classes { get; }

    /// <inheritdoc />
    public CsContainerList<CsNamespace> Namespaces { get; }

    /// <inheritdoc />
    public List<CsAttribute> Attributes { get; }

    /// <inheritdoc />
    public virtual IEnumerable<ICsDeclaration> Children()
    {
        return CsContainerHelper.Children(this);
    }

    /// <summary>
    /// Find a <see cref="CsElement"/> by name declared directly by this container.
    /// </summary>
    /// <param name="name">Name of the element to find</param>
    /// <returns>The CsElement found or null if not found</returns>
    public CsElement FindByName(string name)
    {
        return FindByName(this, name);
    }

    private CsElement? SearchForChild(CsElement parent, string childName)
    {
        ICsDeclarationContainer? container = null;
        if(parent is CsClass @class)
        {
            container = @class;
        }

        if(container != null)
        {
            var c = container.Classes.FirstOrDefault(x => x.Name == childName);
            if (c != null) return c;

            var e = container.Enums.FirstOrDefault(x => x.Name == childName);
            if (e != null) return e;

            var f = container.Methods.FirstOrDefault(x => x.Name == childName);
            if (f != null) return f;
        }

        return null;
    }

    /// <summary>
    /// Find a <see cref="CsElement"/> by full name(such as gbf::math::Vector3).
    /// </summary>
    /// <param name="name">Name of the element to find</param>
    /// <returns>The CsElement found or null if not found</returns>
	public CsElement FindByFullName(string name)
    {
        var arr = name.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
        if(arr.Length == 0) return null;

        CsElement elem = null;
        for(int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
            {
               elem = FindByName(arr[0]);
            }
            else
            {
               elem = SearchForChild(elem, arr[i]);
            }

            if (elem == null) return null;
        }
        return elem;
    }

    /// <summary>
    /// Find a <see cref="CsElement"/> by full name(such as gbf::math::Vector3).
    /// </summary>
    /// <param name="name">Name of the element to find</param>
    /// <returns>The CsElement found or null if not found</returns>
    public TCsElement FindByFullName<TCsElement>(string name) where TCsElement : CsElement
    {
        return (TCsElement)FindByFullName(name);
    }

    /// <summary>
    /// Find a <see cref="CsElement"/> by name declared within the specified container.
    /// </summary>
    /// <param name="container">The container to search for the element by name</param>
    /// <param name="name">Name of the element to find</param>
    /// <returns>The CsElement found or null if not found</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public CsElement FindByName(ICsContainer container, string name)
    {
        if (container == null) throw new ArgumentNullException(nameof(container));
        if (name == null) throw new ArgumentNullException(nameof(name));

        var cacheByName = FindByNameInternal(container, name);
        return cacheByName.Element;
    }

    /// <summary>
    /// Find a list of <see cref="CsElement"/> matching name (overloads) declared within the specified container.
    /// </summary>
    /// <param name="container">The container to search for the element by name</param>
    /// <param name="name">Name of the element to find</param>
    /// <returns>A list of CsElement found or empty enumeration if not found</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public IEnumerable<CsElement> FindListByName(ICsContainer container, string name)
    {
        if (container == null) throw new ArgumentNullException(nameof(container));
        if (name == null) throw new ArgumentNullException(nameof(name));

        var cacheByName = FindByNameInternal(container, name);
        return cacheByName;
    }

    /// <summary>
    /// Find a <see cref="CsElement"/> by name and type declared directly by this container.
    /// </summary>
    /// <param name="name">Name of the element to find</param>
    /// <returns>The CsElement found or null if not found</returns>
    public TCsElement FindByName<TCsElement>(string name) where TCsElement : CsElement
    {
        return FindByName<TCsElement>(this, name);
    }

    /// <summary>
    /// Find a <see cref="CsElement"/> by name and type declared within the specified container.
    /// </summary>
    /// <param name="container">The container to search for the element by name</param>
    /// <param name="name">Name of the element to find</param>
    /// <returns>The CsElement found or null if not found</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public TCsElement FindByName<TCsElement>(ICsContainer container, string name) where TCsElement : CsElement
    {
        return (TCsElement)FindByName(container, name);
    }

    /// <summary>
    /// Clear the cache used by all <see cref="FindByName(string)"/> functions.
    /// </summary>
    /// <remarks>
    /// Used this method when new elements are added to this instance.
    /// </remarks>
    public void ClearCacheByName()
    {
        // TODO: reuse previous internal cache
        _multiCacheByName.Clear();
    }

    private CacheByName FindByNameInternal(ICsContainer container, string name)
    {
        if (!_multiCacheByName.TryGetValue(container, out var cacheByNames))
        {
            cacheByNames = new Dictionary<string, CacheByName>();
            _multiCacheByName.Add(container, cacheByNames);

            foreach (var element in container.Children())
            {
                var CsElement = (CsElement)element;
                if (element is ICsMember member && !string.IsNullOrEmpty(member.Name))
                {
                    var elementName = member.Name;
                    if (!cacheByNames.TryGetValue(elementName, out var cacheByName))
                    {
                        cacheByName = new CacheByName();
                    }

                    if (cacheByName.Element == null)
                    {
                        cacheByName.Element = CsElement;
                    }
                    else
                    {
                        if (cacheByName.List == null)
                        {
                            cacheByName.List = new List<CsElement>();
                        }
                        cacheByName.List.Add(CsElement);
                    }

                    cacheByNames[elementName] = cacheByName;
                }
            }

        }

        return cacheByNames.TryGetValue(name, out var cacheByNameFound) ? cacheByNameFound : new CacheByName();
    }

    private struct CacheByName : IEnumerable<CsElement>
    {
        public CsElement Element;

        public List<CsElement> List;
        public IEnumerator<CsElement> GetEnumerator()
        {
            if (Element != null) yield return Element;
            if (List != null)
            {
                foreach (var CsElement in List)
                {
                    yield return CsElement;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

internal class ReferenceEqualityComparer<T> : IEqualityComparer<T>
{
    public static readonly ReferenceEqualityComparer<T> Default = new ReferenceEqualityComparer<T>();

    private ReferenceEqualityComparer()
    {
    }

    /// <inheritdoc />
    public bool Equals(T x, T y)
    {
        return ReferenceEquals(x, y);
    }

    /// <inheritdoc />
    public int GetHashCode(T obj)
    {
        return RuntimeHelpers.GetHashCode(obj);
    }
}